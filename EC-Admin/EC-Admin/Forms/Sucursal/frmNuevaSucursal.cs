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
    public partial class frmNuevaSucursal : Form
    {
        Sucursal s = new Sucursal();
        frmPrimerUso frm = null;
        private int idD = 0;

        public int IDDireccion
        {
            set
            {
                idD = value;
                ObtenerDatosDireccion();
            }
        }
        
        public frmNuevaSucursal()
        {
            InitializeComponent();
        }

        public frmNuevaSucursal(frmPrimerUso frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void ObtenerDatosDireccion()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM direccion WHERE id=?id";
                sql.Parameters.AddWithValue("?id", idD);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    lblFCalle.Text = dr["calle"].ToString();
                    lblFNumExt.Text = dr["num_ext"].ToString();
                    lblFNumInt.Text = dr["num_int"].ToString();
                    lblFCP.Text = dr["cp"].ToString();
                    lblFColonia.Text = dr["colonia"].ToString();
                    lblFCiudad.Text = dr["ciudad"].ToString();
                    lblFEstado.Text = dr["estado"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de la dirección fiscal. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al mostrar los datos de la dirección fiscal.", "Admin CSY", ex);
            }
        }

        private void Insertar()
        {
            try
            {
                s.IDDireccion = idD;
                s.Nombre = txtNombre.Text;
                s.Calle = txtCalle.Text;
                s.NumExt = txtNumExt.Text;
                s.NumInt = txtNumInt.Text;
                s.CP = int.Parse(txtCP.Text);
                s.Colonia = txtColonia.Text;
                s.Estado = txtEstado.Text;
                s.Ciudad = txtCiudad.Text;
                s.Telefono01 = txtTelefono01.Text;
                s.Telefono02 = txtTelefono02.Text;
                s.Fax = txtFax.Text;
                s.Correo = txtCorreo.Text;
                s.Logotipo = pcbLogotipo.Image;
                s.Web = txtWeb.Text;
                s.RFC = txtRFC.Text;
                s.Insertar();
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
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio", "Admin CSY");
                return false;
            }
            if (txtRFC.Text.Trim() != "")
            {
                if (txtRFC.Text.Length < 12)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo RFC debe tener 12 o 13 caracteres", "Admin CSY");
                    return false;
                }
            }
            if (txtCalle.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo calle es obligatorio", "Admin CSY");
                return false;
            }
            if (txtNumInt.Text.Trim() != "" && txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo número exterior necesita ser ingresado antes que el número interior", "Admin CSY");
                return false;
            }
            if (txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo número exterior es obligatorio", "Admin CSY");
                return false;
            }
            if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un número teléfonico", "Admin CSY");
                return false;
            }
            else
            {
                if (txtTelefono02.Text.Trim() != "" && txtTelefono01.Text.Trim() == "")
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El primer campo de teléfono debe ser ingresado antes que el segundo", "Admin CSY");
                    return false;
                }
            }
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El correo ingresado no se reconoce cómo correo válido", "Admin CSY");
                    return false;
                }
            }
            return true;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void pcbLogotipo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen (*.jpg; *.jpeg) | *.jpg; *.jpeg";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            DialogResult r = ofd.ShowDialog(this);
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    pcbLogotipo.Image = new Bitmap(ofd.FileName);
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "El archivo seleccionado no pudo ser encontrado.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al tratar de crear el logotipo", "Admin CSY", ex);
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente desea quitar éste logotipo?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
            {
                pcbLogotipo.Image = null;
            }
        }

        private void btnAsignarDomicilio_Click(object sender, EventArgs e)
        {
            (new frmAsignarDomicilio(this)).ShowDialog(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    if (frm == null)
                    {
                        Insertar();
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado la sucursal correctamente!", "Admin CSY");
                        this.Close();
                    }
                    else
                    {
                        Insertar();
                        ConfiguracionXML.GuardarConfiguracion("sucursal", "id", s.ID.ToString());
                        ConfiguracionXML.GuardarConfiguracion("sucursal", "nombre", txtNombre.Text);
                        frm.Siguiente();
                        this.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear la sucursal. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear la sucursal.", "Admin CSY", ex);
                }
            }
        }

        private void txtTelefonos_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }
    }
}
