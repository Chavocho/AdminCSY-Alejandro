using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin.Forms
{
    public partial class frmEditarTrabajador : Form
    {
        Camara c;
        Trabajador t;
        private byte[] huella;
        List<int> idSucursal = new List<int>();
        List<int> idPuesto = new List<int>();

        public frmEditarTrabajador(int id)
        {
            InitializeComponent();
            t = new Trabajador();
            t.ID = id;
        }

        private void CargarSucursales()
        {
            try
            {
                string sql = "SELECT id, nombre FROM sucursal WHERE eliminado=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idSucursal.Add((int)dr["id"]);
                    cboSucursal.Items.Add(dr["nombre"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarPuestos()
        {
            try
            {
                string sql = "SELECT id, nombre, departamento FROM puesto";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idPuesto.Add((int)dr["id"]);
                    cboPuesto.Items.Add(dr["nombre"].ToString() + "/" + dr["departamento"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int SeleccionarSucursal(int id)
        {
            int suc = 0;
            for (int i = 0; i < idSucursal.Count; i++)
            {
                if (idSucursal[i] == id)
                {
                    suc = i;
                    break;
                }
            }
            return suc;
        }

        private int SeleccionarPuesto(int id)
        {
            int pue = 0;
            for (int i = 0; i < idPuesto.Count; i++)
            {
                if (idPuesto[i] == id)
                {
                    pue = i;
                    break;
                }
            }
            return pue;
        }

        private void CargarDatos()
        {
            try
            {
                t.ObtenerDatos();
                cboSucursal.SelectedIndex = SeleccionarSucursal(t.IDSucursal);
                txtNombre.Text = t.Nombre;
                txtApellidos.Text = t.Apellidos;
                cboPuesto.SelectedIndex = SeleccionarPuesto(t.Puesto);
                txtNumNomina.Text = t.Nomina;
                txtTelefono.Text = t.Telefono;
                txtCelular.Text = t.Celular;
                txtCorreo.Text = t.Correo;
                txtDireccion.Text = t.Direccion;
                txtCiudad.Text = t.Ciudad;
                txtEstado.Text = t.Estado;
                txtCP.Text = t.CP.ToString();
                pcbImagen.Image = t.Imagen;
                huella = t.Huella;
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
                int cp;
                int.TryParse(txtCP.Text, out cp);
                decimal sueldo;
                decimal.TryParse(txtSueldo.Text, out sueldo);
                t.IDSucursal = idSucursal[cboSucursal.SelectedIndex];
                t.Puesto = idPuesto[cboPuesto.SelectedIndex];
                t.Nomina = txtNumNomina.Text;
                t.Nombre = txtNombre.Text;
                t.Apellidos = txtApellidos.Text;
                t.Telefono = txtTelefono.Text;
                t.Celular = txtCelular.Text;
                t.Correo = txtCorreo.Text;
                t.Direccion = txtDireccion.Text;
                t.Ciudad = txtCiudad.Text;
                t.Estado = txtEstado.Text;
                t.CP = cp;
                t.Imagen = pcbImagen.Image;
                t.Huella = huella;
                t.Sueldo = sueldo;
                t.Editar();
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
            if (cboSucursal.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Se debe seleccionar una sucursal asociada con éste trabajador.", "Admin CSY");
                FuncionesGenerales.ColoresError(cboSucursal);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(cboSucursal);
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio.", "Admin CSY");
                FuncionesGenerales.ColoresError(txtNombre);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtNombre);
            }
            if (txtApellidos.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo apellidos es obligatorio.", "Admin CSY");
                FuncionesGenerales.ColoresError(txtApellidos);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtApellidos);
            }
            if (cboPuesto.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Se debe seleccionar un puesto asociado con éste trabajador.", "Admin CSY");
                FuncionesGenerales.ColoresError(cboPuesto);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(cboPuesto);
            }
            if (txtTelefono.Text.Trim() == "" && txtCelular.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un número de teléfono.", "Admin CSY");
                FuncionesGenerales.ColoresError(txtCelular);
                FuncionesGenerales.ColoresError(txtTelefono);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtCelular);
                FuncionesGenerales.ColoresBien(txtTelefono);
            }
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El correo ingresado no se reconoce cómo uno válido.", "Admin CSY");
                    FuncionesGenerales.ColoresError(txtCorreo);
                    return false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtCorreo);
                }
            }

            return true;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void frmEditarTrabajador_Load(object sender, EventArgs e)
        {
            c = new Camara(ref pcbImagen, ref cboCamaras);
            CargarPuestos();
            CargarSucursales();
            CargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Editar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado el trabajador correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el trabajador. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al modificar el trabajador.", "Admin CSY", ex);
                }
            }
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            if (c.FuenteDeVideo == null)
            {
                if (c.ExisteCamara)
                {
                    c.IniciarCamara(cboCamaras.SelectedIndex);
                    cboCamaras.Enabled = false;
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "No hay ninguna cámara seleccionada", "Admin CSY");
                }
            }
            else
            {
                c.TerminarFuenteDeVideo();
                FuncionesGenerales.EfectoFoto(ref pcbImagen);
                cboCamaras.Enabled = true;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pcbImagen.Image = null;
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            if (c.FuenteDeVideo != null)
            {
                c.TerminarFuenteDeVideo();
                pcbImagen.Image = null;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen (*.jpg; *.jpeg) | *.jpg; *.jpeg";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            DialogResult r = ofd.ShowDialog(this);
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                pcbImagen.Image = Bitmap.FromFile(ofd.FileName);
            }
        }

        private void frmEditarTrabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (c.FuenteDeVideo != null)
            {
                c.TerminarFuenteDeVideo();
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void txtTelefonos_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }
    }
}
