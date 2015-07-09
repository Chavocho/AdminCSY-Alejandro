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
    public partial class frmConfigs : Form
    {
        #region Instancia
        private static frmConfigs frmInstancia;
        public static frmConfigs Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmConfigs();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmConfigs();
                return frmInstancia;

            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmConfigs()
        {
            InitializeComponent();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            if (!frmSucursal.Instancia.Visible)
                frmSucursal.Instancia.Show();
            else
                frmSucursal.Instancia.Select();
        }

        private void btnDirecciones_Click(object sender, EventArgs e)
        {
            if (!frmDomicilio.Instancia.Visible)
                frmDomicilio.Instancia.Show();
            else
                frmDomicilio.Instancia.Select();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            if (!frmCuenta.Instancia.Visible)
                frmCuenta.Instancia.Show();
            else
                frmCuenta.Instancia.Select();
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            (new frmConfigBaseDatos(true)).ShowDialog(this);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            if (!frmConfigAlmacen.Instancia.Visible)
                frmConfigAlmacen.Instancia.Show();
            else
                frmConfigAlmacen.Instancia.Select();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (!frmConfigTicket.Instancia.Visible)
                frmConfigTicket.Instancia.Show();
            else
                frmConfigTicket.Instancia.Select(); 
        }

        private void btnGenerales_Click(object sender, EventArgs e)
        {
            if (!frmConfigGeneral.Instancia.Visible)
                frmConfigGeneral.Instancia.Show();
            else
                frmConfigGeneral.Instancia.Focus();
        }
    }
}
