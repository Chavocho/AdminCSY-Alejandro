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
    public partial class frmNuevoTrabajador : Form
    {
        Camara c;
        private byte[] huella = null;
        List<int> idSucursal = new List<int>();
        List<int> idPuesto = new List<int>();

        public frmNuevoTrabajador()
        {
            InitializeComponent();
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

        private void Insertar()
        {
            try
            {
                int cp;
                int.TryParse(txtCP.Text, out cp);
                decimal sueldo;
                decimal.TryParse(txtSueldo.Text, out sueldo);
                Trabajador t = new Trabajador();
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
                t.FechaInicio = dtpFechaInicio.Value;
                t.Imagen = pcbImagen.Image;
                t.Huella = huella;
                t.Sueldo = sueldo;
                t.Insertar();
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
                return false;
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio.", "Admin CSY");
                return false;
            }
            if (txtApellidos.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo apellidos es obligatorio.", "Admin CSY");
                return false;
            }
            if (cboPuesto.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Se debe seleccionar un puesto asociado con éste trabajador.", "Admin CSY");
                return false;
            }
            if (txtTelefono.Text.Trim() == "" && txtCelular.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un número de teléfono.", "Admin CSY");
                return false;
            }
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El correo ingresado no se reconoce cómo uno válido.", "Admin CSY");
                    return false;
                }
            }
            return true;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void frmNuevoTrabajador_Load(object sender, EventArgs e)
        {
            c = new Camara(ref pcbImagen, ref cboCamaras);
            CargarPuestos();
            CargarSucursales();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Insertar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el trabajador correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el trabajador. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear el trabajador.", "Admin CSY", ex);
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

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pcbImagen.Image = null;
        }

        private void frmNuevoTrabajador_FormClosed(object sender, FormClosedEventArgs e)
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
