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
    public partial class frmConfigBaseDatos : Form
    {
        frmPrimerUso frm = null;
        bool reiniciar;

        public frmConfigBaseDatos(bool reiniciar)
        {
            InitializeComponent();
            this.reiniciar = reiniciar;
        }

        public frmConfigBaseDatos(frmPrimerUso frm)
        {
            InitializeComponent();
            this.frm = frm;
            reiniciar = false;
        }

        private void Cargar()
        {
            txtServer.Text = Config.servidor;
            txtBase.Text = Config.baseDatos;
            txtUsuario.Text = Config.usuario;
            txtPass.Text = Config.pass;
        }

        private void Guardar()
        {
            ConfiguracionXML.GuardarConfiguracion("basedatos", "server", txtServer.Text);
            ConfiguracionXML.GuardarConfiguracion("basedatos", "base", txtBase.Text);
            ConfiguracionXML.GuardarConfiguracion("basedatos", "usuario", txtUsuario.Text);
            ConfiguracionXML.GuardarConfiguracion("basedatos", "pass", txtPass.Text);
            Config.servidor = txtServer.Text;
            Config.baseDatos = txtBase.Text;
            Config.usuario = txtUsuario.Text;
            Config.pass = txtPass.Text;
        }

        private void frmConfigBaseDatos_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult r = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Es correcta la información?", "Admin CSY");
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                if (frm == null)
                {
                    Guardar();
                    try
                    {
                        if (!ConexionBD.Ping())
                        {
                            DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "Admin CSY");
                            if (re == System.Windows.Forms.DialogResult.Yes)
                            {
                                return;
                            }
                        }
                    }
                    catch (MySql.Data.MySqlClient.MySqlException)
                    {
                        DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "Admin CSY");
                        if (re == System.Windows.Forms.DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "Admin CSY");
                        if (re == System.Windows.Forms.DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    this.Close();
                }
                else
                {
                    Guardar();
                    try
                    {
                        if (!ConexionBD.Ping())
                        {
                            DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "Admin CSY");
                            if (re == System.Windows.Forms.DialogResult.Yes)
                            {
                                return;
                            }
                        }
                        frm.Siguiente();
                        this.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "La conexión con los datos ingresados no se ha logrado efectuar.", "Admin CSY", ex);
                    }
                }
            }
        }

        private void frmConfigBaseDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (reiniciar)
            {
                Application.Exit();
                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "La aplicación se cerrará.", "Admin CSY");
            }
        }
    }
}
