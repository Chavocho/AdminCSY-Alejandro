using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin.Forms.Configs
{
    public partial class frmConfigCorreo : Form
    {
        public frmConfigCorreo()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            txtCorreo.Text = Config.correoOrigenExterno;
            txtPass.Text = Config.contraseñaOrigenExterno;
            txtHost.Text = Config.hostExterno;
            txtPuerto.Text = Config.puertoExterno;
        }

        private void GuardarDatos()
        {
            Config.correoOrigenExterno = txtCorreo.Text;
            Config.contraseñaOrigenExterno = txtPass.Text;
            Config.hostExterno = txtHost.Text;
            Config.puertoExterno = txtPuerto.Text;
            ConfiguracionXML.GuardarConfiguracion("correo", "correo", txtCorreo.Text);
            ConfiguracionXML.GuardarConfiguracion("correo", "pass", txtPass.Text);
            ConfiguracionXML.GuardarConfiguracion("correo", "host", txtHost.Text);
            ConfiguracionXML.GuardarConfiguracion("correo", "puerto", txtPuerto.Text);
        }

        private bool VerificarDatos()
        {
            bool res = true;
            if (txtCorreo.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtCorreo); 
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No se reconoce el correo ingresado como uno válido", "Admin CSY");
                res = false;
            }
            else
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.ColoresError(txtCorreo);
                    res = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtCorreo);
                }
            }
            if (txtHost.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtHost);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtHost);
            }
            if (txtPuerto.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtPuerto);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtPuerto);
            }
            return res;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                GuardarDatos();
                FuncionesGenerales.Mensaje(this, Mensajes.Exito, "Se ha guardado la configuración con éxito", "Admin CSY");
                this.Close();
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Los campos en color rojo son obligatorios o tienen errores.", "Admin CSY");
            }
        }

        private void txtPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }
    }
}
