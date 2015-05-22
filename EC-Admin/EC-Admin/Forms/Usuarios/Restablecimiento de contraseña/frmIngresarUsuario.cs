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
    public partial class frmIngresarUsuario : Form
    {
        frmReestablecerPass frm;
        public frmIngresarUsuario(frmReestablecerPass frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void ObtenerCorreoUsuario(string usuario)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, email FROM usuario WHERE username=?username";
                sql.Parameters.AddWithValue("?username", usuario);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    frm.Correo = dr["email"].ToString();
                    frm.ID = (int)dr["id"];
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void EnviarCódigoVerificación()
        {
            try
            {
                Usuario.CrearNumeroAutorizacion(frm.ID, frm.Correo);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mandar el número de verificación al correo del usuario.", "Admin CSY", ex);
            }
        }

        private void bgwVerificar_DoWork(object sender, DoWorkEventArgs e)
        {
            ObtenerCorreoUsuario(e.Argument.ToString());
        }

        private void bgwVerificar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (frm.Correo != "")
            {
                lblCorreo.Text = frm.Correo;
                btnCodigoCorreo.Visible = true;
            }
            else
            {
                lblCorreo.Text = "El usuario ingresado no existe o no tiene un correo asignado.";
                btnCodigoCorreo.Visible = false;
            }
            lblCorreo.Left = (this.Width - lblCorreo.Width) / 2;
            lblCorreo.Visible = true;
        }

        private void btnVerificarUsuario_Click(object sender, EventArgs e)
        {
            bgwVerificar.RunWorkerAsync(txtUsuario.Text);
        }

        private void btnCodigoCorreo_Click(object sender, EventArgs e)
        {
            if (FuncionesGenerales.EsCorreoValido(lblCorreo.Text))
            {
                if (FuncionesGenerales.HayInternet())
                {
                    EnviarCódigoVerificación();
                    frm.CambioFormulario(new frmVerificarUsuario(frm));
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No hay disponible una conexión a internet. Vuelve a intentarlo más tarde.", "Admin CSY");
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Necesitas tener registrado un correo válido para poder continuar.", "Admin CSY");
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!btnCodigoCorreo.Visible)
                {
                    btnVerificarUsuario.PerformClick();
                }
                else
                {
                    btnCodigoCorreo.PerformClick();
                }
            }
        }    
    }
}
