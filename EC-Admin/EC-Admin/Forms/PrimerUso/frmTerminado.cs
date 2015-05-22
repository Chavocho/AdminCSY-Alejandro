using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin
{
    public partial class frmTerminado : Form
    {
        frmPrimerUso frm;

        public frmTerminado(frmPrimerUso frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void ClienteGeneral()
        {
            if (Cliente.Cantidad == 0)
            {
                Cliente.ClienteGeneral();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClienteGeneral();
            frm.Siguiente();
            this.Close();
        }
    }
}
