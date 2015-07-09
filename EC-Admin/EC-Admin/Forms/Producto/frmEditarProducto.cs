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
    public partial class frmEditarProducto : Form
    {
        Producto p;
        Inventario i;
        Unidades u;
        List<int> idPro = new List<int>();
        List<int> idAlm = new List<int>();
        List<int> idCat = new List<int>();

        public frmEditarProducto(int id)
        {
            InitializeComponent();
            p = new Producto(id);
            i = new Inventario(id, Config.idSucursal);
        }

        private void CargarProveedores()
        {
            try
            {
                string sql = "SELECT id, nombre FROM proveedor";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idPro.Add((int)dr["id"]);
                    cboProveedor.Items.Add(dr["nombre"]);
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los proveedores. No se ha podido conectar con la base de datos. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los proveedores. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
        }

        private void CargarCategorias()
        {
            try
            {
                string sql = "SELECT id, nombre FROM categoria";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idCat.Add((int)dr["id"]);
                    cboCategoria.Items.Add(dr["nombre"]);
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar las categorías. No se ha podido conectar con la base de datos. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar las categorías. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
        }

        private int AsignarComboBox(List<int> l, int id)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] == id)
                {
                    return i;
                }
            }
            return -1;
        }

        private void CargarDatos()
        {
            try
            {
                p.ObtenerDatos();
                i.ObtenerDatos();
                cboProveedor.SelectedIndex = AsignarComboBox(idPro, p.IDProveedor);
                cboCategoria.SelectedIndex = AsignarComboBox(idCat, p.IDCategoria);
                txtNombre.Text = p.Nombre;
                txtMarca.Text = p.Marca;
                txtCodigo.Text = p.Codigo;
                txtDescripcion01.Text = p.Descripcion01;
                txtCosto.Text = p.Costo.ToString();
                txtPrecio.Text = i.Precio.ToString();
                txtCant.Text = i.Cantidad.ToString();
                txtPrecioMedioMayoreo.Text = i.PrecioMedioMayoreo.ToString();
                txtPrecioMayoreo.Text = i.PrecioMayoreo.ToString();
                pcbImagen01.Image = p.Imagen01;
                switch (p.Unidad)
                {
                    case Unidades.Pieza:
                        cboUnidad.SelectedIndex = 0;
                        break;
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

        private void CargarPaquetes()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM paquete WHERE id_producto=?id_producto";
                sql.Parameters.AddWithValue("?id_producto", p.ID);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvPaquetes.Rows.Add(new object[] { dr["id"], dr["precio"], dr["cant"], true, false });
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

        private void Editar()
        {
            try
            {
                decimal costo, precio, precioMedioMayoreo, precioMayoreo;
                int cant;
                decimal.TryParse(txtCosto.Text, out costo);
                decimal.TryParse(txtPrecio.Text, out precio);
                int.TryParse(txtCant.Text, out cant);
                decimal.TryParse(txtPrecioMedioMayoreo.Text, out precioMedioMayoreo);
                decimal.TryParse(txtPrecioMayoreo.Text, out precioMayoreo);
                p.IDProveedor = idPro[cboProveedor.SelectedIndex];
                p.IDCategoria = idCat[cboCategoria.SelectedIndex];
                p.Nombre = txtNombre.Text;
                p.Marca = txtMarca.Text;
                p.Codigo = txtCodigo.Text;
                p.Descripcion01 = txtDescripcion01.Text;
                p.Costo = costo;
                i.Precio = precio;
                i.Cantidad = cant;
                i.PrecioMedioMayoreo = precioMedioMayoreo;
                i.PrecioMayoreo = precioMayoreo;
                p.Unidad = u;
                p.Imagen01 = pcbImagen01.Image;
                p.Imagen02 = pcbImagen02.Image;
                p.Imagen03 = pcbImagen03.Image;
                p.Editar();
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

        private bool VerificarDatos()
        {
            if (cboProveedor.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo proveedor es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(cboProveedor);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(cboProveedor);
            }
            if (cboCategoria.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo categoría es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(cboCategoria);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(cboCategoria);
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtNombre);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtNombre);
            }
            if (txtMarca.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo marca es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtMarca);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtMarca);
            }
            if (txtCodigo.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo código es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtCodigo);
                return false;
            }
            else
            {
                if (lblInformacionCodigo.Visible)
                {
                    return false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtCodigo);
                }
            }
            if (txtCosto.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo costo es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtCosto);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtCosto);
            }
            if (txtPrecio.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo precio es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtPrecio);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtPrecio);
            }
            if (txtCant.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo cantidad es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtCant);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtCant);
            }
            if (cboUnidad.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo unidad es obligatorio", "Admin CSY");
                return false;
            }
            return true;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void txtNumerosEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos de imagen (*.jpg, *.jpeg) | *.jpg; *.jpeg";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                ofd.Multiselect = false;
                ofd.Title = "Seleccione la imagen del producto";
                DialogResult r = ofd.ShowDialog(this);
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    pcb.Image = Bitmap.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener la imagen.", "Admin CSY", ex);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string texto = btn.Text.Substring(btn.Text.Length - 2, 2);
            if (texto == "01")
            {
                pcbImagen01.Image = null;
            }
            else if (texto == "02")
            {
                pcbImagen02.Image = null;
            }
            else if (texto == "03")
            {
                pcbImagen03.Image = null;
            }
        }

        private void frmEditarProducto_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarCategorias();
            CargarDatos();
            CargarPaquetes();
        }

        private void cboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboUnidad.SelectedIndex)
            {
                case 0:
                    u = Unidades.Pieza;
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Editar();
                    InsertarPaquete();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado el producto correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el producto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el producto.", "Admin CSY", ex);
                }
            }
        }

        #region Paquetes
        bool edito;

        private void InsertarDataGrid(string precio, string cant)
        {
            dgvPaquetes.Rows.Add(new object[] { 0, decimal.Parse(precio), int.Parse(cant), false, false });
        }

        private void EditarDataGrid(int rowIndex, string precio, string cant)
        {
            dgvPaquetes[1, rowIndex].Value = decimal.Parse(precio);
            dgvPaquetes[2, rowIndex].Value = int.Parse(cant);
            dgvPaquetes[4, rowIndex].Value = true;
        }

        private void EliminarDataGrid(int rowIndex)
        {
            dgvPaquetes.Rows.RemoveAt(rowIndex);
        }

        private void InsertarPaquete()
        {
            try
            {
                foreach (DataGridViewRow dr in dgvPaquetes.Rows)
                {
                    Paquete pa = new Paquete();
                    pa.IDProducto = p.ID;
                    pa.Precio = (decimal)dr.Cells[1].Value;
                    pa.CantidadPaquetes = (int)dr.Cells[2].Value;
                    if (!(bool)dr.Cells[3].Value)
                    {
                        pa.Insertar();
                    }
                    else if ((bool)dr.Cells[4].Value)
                    {
                        pa.ID = (int)dr.Cells[0].Value;
                        pa.Editar();
                    }
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

        private bool VerificarDatosPaquete()
        {
            bool res = true;
            if (txtPrecioPaquete.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtPrecioPaquete);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtPrecioPaquete);
            }
            if (txtCantPaquete.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtCantPaquete);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtCantPaquete);
            }
            return res;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            edito = false;
            btnAceptarPaquete.Text = "Crear";
            txtCantPaquete.Text = "";
            txtPrecioPaquete.Text = "";
            pnlPaquete.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.CurrentRow != null)
            {
                edito = true;
                btnAceptarPaquete.Text = "Modificar";
                txtCantPaquete.Text = dgvPaquetes[2, dgvPaquetes.CurrentRow.Index].Value.ToString();
                txtPrecioPaquete.Text = dgvPaquetes[1, dgvPaquetes.CurrentRow.Index].Value.ToString();
                pnlPaquete.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.CurrentRow != null)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente desea eliminar este paquete?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if ((bool)dgvPaquetes[3, dgvPaquetes.CurrentRow.Index].Value)
                        {
                            Paquete.Eliminar((int)dgvPaquetes[0, dgvPaquetes.CurrentRow.Index].Value);
                        }
                        EliminarDataGrid(dgvPaquetes.CurrentRow.Index);
                    }
                    catch (MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al eliminar el paquete. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al eliminar el paquete.", "Admin CSY", ex);
                    }
                }
            }
        }

        private void btnAceptarPaquete_Click(object sender, EventArgs e)
        {
            if (VerificarDatosPaquete())
            {
                if (!edito)
                {
                    InsertarDataGrid(txtPrecioPaquete.Text, txtCantPaquete.Text);
                    dgvPaquetes.Rows[dgvPaquetes.RowCount - 1].Selected = true;
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha añadido el paquete con éxito!", "Admin CSY");
                }
                else
                {
                    EditarDataGrid(dgvPaquetes.CurrentRow.Index, txtPrecioPaquete.Text, txtCantPaquete.Text);
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado el paquete con éxito!", "Admin CSY");
                }
                pnlPaquete.Visible = false;
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "¡Los campos en rojo son obligatorios!", "Admin CSY");
            }
        }

        #endregion

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (Producto.ExisteCodigo(txtCodigo.Text, p.ID))
            {
                return;
            }
            if (Producto.ExisteCodigo(txtCodigo.Text))
            {
                lblInformacionCodigo.Visible = true;
                FuncionesGenerales.ColoresError(txtCodigo);
            }
            else
            {
                lblInformacionCodigo.Visible = false;
                FuncionesGenerales.ColoresBien(txtCodigo);
            }
        }
    }
}
