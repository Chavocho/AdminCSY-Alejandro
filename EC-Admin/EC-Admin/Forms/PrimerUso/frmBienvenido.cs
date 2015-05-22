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
    public partial class frmBienvenido : Form
    {
        frmPrimerUso frm;

        public frmBienvenido(frmPrimerUso frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frm.Siguiente();
            this.Close();
        }
    }
}
