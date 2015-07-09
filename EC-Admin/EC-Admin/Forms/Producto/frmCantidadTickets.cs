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
    public partial class frmCantidadTickets : Form
    {
        public frmCantidadTickets()
        {
            InitializeComponent();
        }

        public decimal Cantidad()
        {
            if (!this.Visible)
                this.ShowDialog();
            this.Close();
            return nudCantidad.Value;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cantidad();
        }
    }
}
