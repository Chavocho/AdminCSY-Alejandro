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
    public partial class frmNuevoUsuario : Form
    {
        frmPrimerUso frm = null;
        NivelesUsuario n;
        Camara c;
        private byte[] huella = null;

        public byte[] Huella
        {
            get { return huella ; }
            set { huella = value; }
        }
        
        public frmNuevoUsuario(string[] niveles)
        {
            InitializeComponent();
            cboNivel.Items.AddRange(niveles);
            cboNivel.SelectedIndex = 0;
        }

        public frmNuevoUsuario(frmPrimerUso frm, string [] niveles)
        {
            InitializeComponent();
            this.frm = frm;
            cboNivel.Items.AddRange(niveles);
            cboNivel.SelectedIndex = 0;
        }

        private void InsertarUsuario()
        {
            try
            {

                Usuario u = new Usuario();
                if (Config.idSucursal > 0)
                    u.IDSucusal = Config.idSucursal;
                else
                    u.IDSucusal = 1;
                u.UserName = txtUsuario.Text;
                u.Contraseña = txtPass.Text;
                u.NivelUsuario = n;
                u.Nombre = txtNombre.Text;
                u.Apellidos = txtApellidos.Text;
                u.Correo = txtCorreo.Text;
                u.Imagen = pcbImagen.Image;
                u.Huella = huella;
                u.InsertarUsuario();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
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
            if (txtUsuario.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo usuario es obligatorio.", "Admin CSY");
                FuncionesGenerales.ColoresError(txtUsuario);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtUsuario);
            }
            if (txtPass.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo contraseña es obligatorio.", "Admin CSY");
                FuncionesGenerales.ColoresError(txtPass);
                return false;
            }
            else
            {
                if (txtPass.Text != txtRepPass.Text)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Las contraseñas no coinciden. Éstas deben coincidir para poder continuar.", "Admin CSY");
                    FuncionesGenerales.ColoresError(txtPass);
                    return false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtPass);
                    FuncionesGenerales.ColoresBien(txtRepPass);
                }
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
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El correo ingresado no es valido. Verifique que este escrito correctamente.", "Admin CSY");
                    FuncionesGenerales.ColoresError(txtCorreo);
                    return false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtCorreo);
                }
            }
            if (lblInfo.Visible)
            {
                return false;
            }
            return true;
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            if (c.FuenteDeVideo != null)
            {
                c.TerminarFuenteDeVideo();
                pcbImagen.Image = null;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen (*.jpeg, *.jpg) | *.jpeg; *.jpg;";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Multiselect = false;
            DialogResult r = ofd.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                pcbImagen.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pcbImagen.Image = null;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    if (frm == null)
                    {
                        InsertarUsuario();
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el usuario con éxito!", "Admin CSY");
                        this.Close();
                    }
                    else
                    {
                        InsertarUsuario();
                        frm.Siguiente();
                        this.Close();
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboNivel.Items[cboNivel.SelectedIndex].ToString())
            {
                case "Administrador":
                    n = NivelesUsuario.Administrador;
                    break;
                case "Encargado":
                    n = NivelesUsuario.Encargado;
                    break;
                case "Desconocido":
                    n = NivelesUsuario.Desconocido;
                    break;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.ExisteUsuario(txtUsuario.Text))
            {
                lblInfo.Visible = true;
                txtUsuario.BackColor = Colores.Error;
                txtUsuario.ForeColor = Colores.Claro;
            }
            else
            {
                lblInfo.Visible = false;
                txtUsuario.BackColor = Colores.Claro;
                txtUsuario.ForeColor = Colores.Obscuro;
            }
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            c = new Camara(ref pcbImagen, ref cboCamaras);
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

        private void frmNuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (c.FuenteDeVideo != null)
            {
                c.TerminarFuenteDeVideo();
            }
        }
    }
}
