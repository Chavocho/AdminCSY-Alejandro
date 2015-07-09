using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EC_Admin.Forms
{
    public partial class frmNuevoTraspaso : Form
    {
        int id;
        List<int> idSucursalOrigen = new List<int>(), idSucursalDestino = new List<int>();

        public frmNuevoTraspaso()
        {
            InitializeComponent();
        }

        private void CargarSucursales()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, nombre FROM sucursales WHERE eliminado=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idSucursalOrigen.Add((int)dr["id"]);
                    idSucursalDestino.Add((int)dr["id"]);
                    cboSucursalOrigen.Items.Add(dr["descripcion"].ToString());
                    cboSucursalDestino.Items.Add(dr["descripcion"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que agrega un producto a la venta
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <param name="codProd">Código de producto</param>
        /// <param name="nombre">Nombre del producto</param>
        /// <param name="marca">Marca del producto</param>
        /// <param name="descripcion">Descripción del producto</param>
        /// <param name="cant">Cantidad del producto</param>
        public void AgregarProducto(int id, string codProd, string nombre, string marca, string descripcion, int cant)
        {
            if (!VerificarProducto(id, cant))
            {
                int cantInv = Inventario.CantidadProducto(id, Config.idSucursal);
                if (cantInv >= cant)
                {
                    dgvProductos.Rows.Add(new object[] { id, codProd, nombre, marca, descripcion, cant, });
                    dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, 0));
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "La cantidad de productos que tratas de ingresar excede a la cantidad en inventario. La cantidad en inventario de \"" + nombre + "\" son \"" + cantInv.ToString() + "\"", "Admin CSY");
                }
            }
        }

        /// <summary>
        /// Método que verifica la existencia del producto en la venta, en caso de estar registrado, suma la cantidad
        /// dada al producto
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <param name="cant">Cantidad a añadir al producto</param>
        private bool VerificarProducto(int id, int cant)
        {
            bool existe = false;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                if (dr.Cells[0].Value.ToString() == id.ToString())
                {
                    int c = ((int)dr.Cells[5].Value + cant);
                    int cantInv = Inventario.CantidadProducto(id, Config.idSucursal);
                    if (c <= 0)
                    {
                        QuitarProducto(dr);
                        existe = true;
                        break;
                    }
                    if (c <= cantInv)
                    {
                        dr.Cells[5].Value = c;
                    }
                    else
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "La cantidad de productos que tratas de ingresar excede a la cantidad en inventario. La cantidad en inventario de \"" + dr.Cells[2].Value.ToString() + "\" son \"" + cantInv.ToString("0") + "\"", "Admin CSY");
                        dr.Cells[5].Value = cantInv;
                    }
                    CalcularTotales();
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        private void BusquedaProducto(string codProd, int cant)
        {
            try
            {
                string sql = "SELECT id, nombre, codigo, marca, descripcion FROM producto AS p INNER JOIN inventario AS i ON (p.id=i.id_producto) WHERE codigo='" + codProd + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    AgregarProducto((int)dr["id"], dr["codigo"].ToString(), dr["nombre"].ToString(), dr["marca"].ToString(), dr["descripcion"].ToString(), cant);
                    break;
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar el producto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar el producto.", "Admin CSY", ex);
            }
        }

        private void QuitarProducto()
        {
            if (dgvProductos.CurrentRow != null)
            {
                int ind = dgvProductos.CurrentRow.Index;
                dgvProductos.Rows.Remove(dgvProductos.CurrentRow);
                CalcularTotales();
            }
        }

        private void QuitarProducto(DataGridViewRow dr)
        {
            int ind = dr.Index;
            dgvProductos.Rows.Remove(dr);
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            int cantTot = 0;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                cantTot += (int)dr.Cells[5].Value;
            }
            lblCantTot.Text = cantTot.ToString("C2");
            lblCantDif.Text = dgvProductos.RowCount.ToString("C2");
        }

        private bool VerificarDatos()
        {
            if (dgvProductos.RowCount == 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un producto para realizar el traspaso", "Admin CSY");
                return false;
            }
            if (idSucursalOrigen[cboSucursalOrigen.SelectedIndex] != Config.idSucursal && idSucursalDestino[cboSucursalDestino.SelectedIndex] != Config.idSucursal)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No puedes realizar transacciones en sucursales que no sean ésta", "Admin CSY");
                return false;
            }
            return true;
        }

        private void InsertarTraspaso(string descripcion)
        {
            Traspaso t = new Traspaso();
            t.Estado = EstadoTraspaso.Espera;
            t.Descripcion = descripcion;
            t.IDSucursalDestino = idSucursalDestino[cboSucursalDestino.SelectedIndex];
            t.IDSucursalOrigen = idSucursalOrigen[cboSucursalOrigen.SelectedIndex];
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                t.IDProductos.Add((int)dr.Cells[0].Value);
                t.CantProductos.Add((int)dr.Cells[5].Value);
            }
            t.Insertar();
        }

        private void frmNuevoTraspaso_Load(object sender, EventArgs e)
        {
            try
            {
                CargarSucursales();
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar las sucursales. No se ha podido conectar a la base de datos.", "Admin CSY", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar las sucursales.", "Admin CSY", ex);
                this.Close();
            }
        }

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                id = (int)dgvProductos[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void dgvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularTotales();
        }

        private void dgvProductos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotales();
        }

        private void cboSucursalOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idSucursalOrigen[cboSucursalOrigen.SelectedIndex] == idSucursalDestino[cboSucursalDestino.SelectedIndex])
            {
                if (cboSucursalDestino.SelectedIndex + 1 < cboSucursalDestino.Items.Count)
                {
                    cboSucursalDestino.SelectedIndex = cboSucursalDestino.SelectedIndex + 1;
                }
                else
                {
                    cboSucursalDestino.SelectedIndex = cboSucursalDestino.SelectedIndex - 1;
                }
            }
        }

        private void cboSucursalDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idSucursalDestino[cboSucursalDestino.SelectedIndex] == idSucursalOrigen[cboSucursalOrigen.SelectedIndex])
            {
                if (cboSucursalOrigen.SelectedIndex + 1 < cboSucursalOrigen.Items.Count)
                {
                    cboSucursalOrigen.SelectedIndex = cboSucursalOrigen.SelectedIndex + 1;
                }
                else
                {
                    cboSucursalOrigen.SelectedIndex = cboSucursalOrigen.SelectedIndex - 1;
                }
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            (new frmProductosTraspasos(this)).ShowDialog(this);
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtBusqueda.Text.Trim() != "")
                {
                    string[] datos = txtBusqueda.Text.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
                    if (datos.Length > 1)
                    {
                        BusquedaProducto(datos[1].ToString(), int.Parse(datos[0]));
                    }
                    else
                    {
                        BusquedaProducto(datos[0].ToString(), 1);
                    }
                    txtBusqueda.Text = "";
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Deseas realizar éste traspaso?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        InsertarTraspaso((new frmDescripcion()).Descripcion());
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el traspaso con correctamente! Ahora la sucursal de destino debe aceptarla, o en caso de haber solicitado el traspaso, la sucursal de origen debe aceptarla.", "Admin CSY");
                        this.Close();
                    }
                    catch (MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el traspaso. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el traspaso.", "Admin CSY", ex);
                    }
                }
            }
        }
    }
}
