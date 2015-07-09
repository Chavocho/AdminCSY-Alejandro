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
using System.Drawing.Printing;

namespace EC_Admin.Forms
{
    public partial class frmProducto : Form
    {
        #region Instancia
        private static frmProducto frmInstancia;
        public static frmProducto Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmProducto();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmProducto();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmProducto()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(string p, bool existencias)
        {
            try
            {
                string sql;
                if (existencias)
                {
                    sql = "SELECT p.id, p.nombre, p.codigo, p.descripcion1, i.precio, i.cant FROM producto AS p INNER JOIN inventario AS i ON (p.id=i.id_producto)" +
                        "WHERE (p.nombre LIKE '%" + p + "%' OR p.codigo LIKE '%" + p + "%') AND i.cant>0 AND p.eliminado=0";
                }
                else
                {
                    sql = "SELECT p.id, p.nombre, p.codigo, p.descripcion1, i.precio, i.cant FROM producto AS p INNER JOIN inventario AS i ON (p.id=i.id_producto)" +
                        "WHERE (p.nombre LIKE '%" + p + "%' OR p.codigo LIKE '%" + p + "%') AND p.eliminado=0";
                }
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los productos. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los productos.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvProductos.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvProductos.Rows.Add(new object[] { dr["id"], dr["nombre"], dr["descripcion1"], dr["codigo"], dr["precio"], dr["cant"] });
                }
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, 0));
                txtBusqueda.Select();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Eliminar()
        {
            try
            {
                Producto.CambiarEstado(id, true);
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

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                id = (int)dgvProductos[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!bgwBusqueda.IsBusy)
                {
                    tmrEspera.Enabled = true;
                    bgwBusqueda.RunWorkerAsync(new object[] { txtBusqueda.Text, chbExistencias.Checked });
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Categoria.Cantidad <= 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "Necesitas registrar al menos un categoría antes de poder registrar un producto", "Admin CSY");
                return;
            }
            (new frmNuevoProducto()).ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && id > 0)
            {
                (new frmEditarProducto(id)).ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && id > 0)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente desea eliminar el producto con nombre " + dgvProductos[1, dgvProductos.CurrentRow.Index].Value.ToString() + "?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    Eliminar();
                }
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if (!frmCategorias.Instancia.Visible)
                frmCategorias.Instancia.Show();
            else
                frmCategorias.Instancia.Select();
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] a = (object[])e.Argument;
            Buscar(a[0].ToString(), (bool)a[1]);
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando productos", this);
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            if (!frmPromociones.Instancia.Visible)
                frmPromociones.Instancia.Show();
            else
                frmPromociones.Instancia.Select();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                try
                {
                    int cant = int.Parse((new frmCantidadTickets()).Cantidad().ToString());
                    if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Desea imprimir " + cant.ToString() + " tickets?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                    {
                        for (int i = 0; i < cant; i++)
                        {
                            Ticket t = new Ticket();
                            t.TicketCodigoProducto(id);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (InvalidPrinterException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket. La impresora seleccionada se encuentra apagada o no es accesible desde la red.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket.", "Admin CSY", ex);
                }
            }
        }

        private void btnTraspasos_Click(object sender, EventArgs e)
        {
            (new frmTraspasos()).Show();
        }
    }
}
