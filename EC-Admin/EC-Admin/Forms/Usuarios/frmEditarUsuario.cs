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
    public partial class frmEditarUsuario : Form
    {
        Camara c;
        NivelesUsuario n;
        Usuario u;
        private byte[] huella = null;
            
        public byte[] Huella
        {
            get { return huella; }
            set { huella = value; }
        }
        
        public frmEditarUsuario(int id, string[] niveles)
        {
            InitializeComponent();
            cboNivel.Items.AddRange(niveles);
            u = new Usuario();
            u.ID = id;
            u.ObtenerDatosUsuario();
            u.UserDataChanged += new EventHandler(frmPrincipal.Instancia.UserDataChanged);
        }

        private void CargarDatosUsuario()
        {
            lblUsuario.Text = u.UserName;
            txtNombre.Text = u.Nombre;
            txtApellidos.Text = u.Apellidos;
            switch (u.NivelUsuario)
            {
                case NivelesUsuario.Administrador:
                    cboNivel.SelectedItem = "Administrador";
                    break;
                case NivelesUsuario.Encargado:
                    cboNivel.SelectedItem = "Encargado";
                    break;
                case NivelesUsuario.Desconocido:
                    cboNivel.SelectedItem = "Desconocido";
                    break;
            }
            txtCorreo.Text = u.Correo;
            pcbImagen.Image = u.Imagen;
        }

        private void EditarUsuario()
        {
            try
            {
                u.NivelUsuario = n;
                u.Nombre = txtNombre.Text;
                u.Apellidos = txtApellidos.Text;
                u.Correo = txtCorreo.Text;
                if (chbPass.Checked)
                {
                    u.Contraseña = txtPass.Text;
                }
                u.Imagen = pcbImagen.Image;
                u.Huella = huella;
                u.EditarUsuario();
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
            if (chbPass.Checked)
            {
                if (txtAntiPass.Text != u.Contraseña)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "La contraseña actual no coincide.", "Admin CSY");
                    return false;
                }
                else
                {
                    if (txtPass.Text.Trim() == "")
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo contraseña es obligatorio.", "Admin CSY");
                        return false;
                    }
                    else
                    {
                        if (txtPass.Text != txtRepPass.Text)
                        {
                            FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Las contraseñas no coinciden. Éstas deben coincidir para poder continuar.", "Admin CSY");
                            return false;
                        }
                    }
                }
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
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El correo ingresado no es valido. Verifique que este escrito correctamente.", "Admin CSY");
                    return false;
                }
            }
            if (u.NivelUsuario == NivelesUsuario.Administrador)
            {
                if (n == NivelesUsuario.Encargado || n == NivelesUsuario.Desconocido)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No puedes bajar el nivel de un usuario administrador.", "Admin CSY");
                    return false;
                }
            }
            return true;
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            c = new Camara(ref pcbImagen, ref cboCamaras);
            CargarDatosUsuario();
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
                    EditarUsuario();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado correctamente el usuario!", "Admin CSY");
                    this.Close();
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

        private void chbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPass.Checked)
            {
                pnlPass.Visible = true;
                this.Size = new Size(this.Width, this.Height + pnlPass.Height);
            }
            else
            {
                pnlPass.Visible = false;
                this.Size = new Size(this.Width, this.Height - pnlPass.Height);
            }
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
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

        private void frmEditarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (c.FuenteDeVideo != null)
            {
                c.TerminarFuenteDeVideo();
            }
        }
    }
}
