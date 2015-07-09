using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Admin.Forms;

namespace EC_Admin
{
    public partial class frmPrimerUso : Form
    {
        int intentos = 0;
        public frmPrimerUso()
        {
            InitializeComponent();
            Bienvenido();
        }

        /// <summary>
        /// Método recursivo que verifica si el servicio de MySQL se encuentra activo, en caso de estarlo, guarda el ID del proceso, en caso contrario,
        /// lo trata de iniciar e inicia la recursividad para verificar si se logro iniciar.
        /// </summary>
        private void MySQL()
        {
            try
            {
                if (intentos <= 3)
                {
                    int id = FuncionesGenerales.IDProceso("mysqld");
                    if (id <= 0)
                    {
                        FuncionesGenerales.IniciarProceso("C:\\xampp\\mysql_start.bat");
                        System.Threading.Thread.Sleep(3000);
                        intentos += 1;
                        MySQL();
                    }
                    else
                    {
                        Config.idMySQL = id;
                    }
                }
                else
                {
                    throw new Exception("No se logro iniciar el servicio de MySQL");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Bienvenido()
        {
            frmBienvenido frm = new frmBienvenido(this);
            frm.TopLevel = false;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            pnlForms.Controls.Clear();
            pnlForms.Controls.Add(frm);
            frm.Show();
            this.Size = new Size(frm.Width, frm.Height + 22);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            pnlForms.Height = frm.Height;
            pnlForms.Location = new Point(0, 22);
        }

        private void BaseDatos()
        {
            frmConfigBaseDatos frm = new frmConfigBaseDatos(this);
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Size = new System.Drawing.Size(597, 233);
            frm.Location = new Point(0, 0);
            pnlForms.Controls.Clear();
            pnlForms.Controls.Add(frm);
            frm.Show();
            this.Size = new Size(frm.Width, frm.Height + 22);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            pnlForms.Height = frm.Height;
            pnlForms.Location = new Point(0, 22);
        }

        private void NuevoUsuario()
        {
            frmNuevoUsuario frm = new frmNuevoUsuario(this, new string[] { "Administador" });
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Size = new System.Drawing.Size(548, 450);
            frm.Location = new Point(0, 0);
            pnlForms.Controls.Clear();
            pnlForms.Controls.Add(frm);
            frm.Show();
            this.Size = new Size(frm.Width, frm.Height + 22);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            pnlForms.Height = frm.Height;
            pnlForms.Location = new Point(0, 22);
        }

        private void NuevaSucursal()
        {
            frmNuevaSucursal frm = new frmNuevaSucursal(this);
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Size = new System.Drawing.Size(813, 669);
            frm.Location = new Point(0, 0);
            pnlForms.Controls.Clear();
            pnlForms.Controls.Add(frm);
            frm.Show();
            this.Size = new Size(frm.Width, frm.Height + 22);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2); 
            pnlForms.Height = frm.Height;
            pnlForms.Location = new Point(0, 22);
        }

        private void Terminado()
        {
            frmTerminado frm = new frmTerminado(this);
            frm.TopLevel = false;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point(0, 0);
            pnlForms.Controls.Clear();
            pnlForms.Controls.Add(frm);
            frm.Show();
            this.Size = new Size(frm.Width, frm.Height + 22);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            pnlForms.Height = frm.Height;
            pnlForms.Location = new Point(0, 22);
        }

        public void Siguiente()
        {
            if (pnlForms.Controls[0].GetType() == typeof(frmBienvenido))
            {
                BaseDatos();
                lblEInicio.ForeColor = lblEBaseDatos.BackColor = Colores.Obscuro;
                lblEInicio.BackColor = lblEBaseDatos.ForeColor = Colores.Claro;
            }
            else if (pnlForms.Controls[0].GetType() == typeof(frmConfigBaseDatos))
            {
                lblCerrar.Enabled = false;
                NuevoUsuario();
                lblEBaseDatos.ForeColor = lblEUsuario.BackColor = Colores.Obscuro;
                lblEBaseDatos.BackColor = lblEUsuario.ForeColor = Colores.Claro;
            }
            else if (pnlForms.Controls[0].GetType() == typeof(frmNuevoUsuario))
            {
                NuevaSucursal();
                lblEUsuario.ForeColor = lblESucursal.BackColor = Colores.Obscuro;
                lblEUsuario.BackColor = lblESucursal.ForeColor = Colores.Claro;
            }
            else if (pnlForms.Controls[0].GetType() == typeof(frmNuevaSucursal))
            {
                lblCerrar.Enabled = true;
                Terminado();
                lblESucursal.ForeColor = lblETerminamos.BackColor = Colores.Obscuro;
                lblESucursal.BackColor = lblETerminamos.ForeColor = Colores.Claro;
            }
            else if (pnlForms.Controls[0].GetType() == typeof(frmTerminado))
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "¡Ha terminado la configuración inicial!", "Admin CSY");
                Properties.Settings.Default.PrimerUso = false;
                Properties.Settings.Default.Save();
                (new frmSplash()).Show();
                this.Close();
            }
        }

        private void lblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Colores.Claro;
            lblCerrar.BackColor = Colores.ErrorObscuro;
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Colores.ErrorObscuro;
            lblCerrar.BackColor = Colores.Claro;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PrimerUso)
            {
                Application.Exit();
            }
            else
            {
                (new frmSplash()).Show();
                this.Close();
            }
        }

        private void frmPrimerUso_Load(object sender, EventArgs e)
        {
            try
            {
                MySQL();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "La aplicación no ha logrado iniciar el servicio de MySQL. La aplicación se cerrará.", "Admin CSY", ex);
                Application.Exit();
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            EC_Admin.Properties.Settings.Default.PrimerUso = false;
            EC_Admin.Properties.Settings.Default.Save();
        }

    }
}
