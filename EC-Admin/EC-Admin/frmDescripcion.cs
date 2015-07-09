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
    public partial class frmDescripcion : Form
    {
        public frmDescripcion()
        {
            InitializeComponent();
        }

        public string Descripcion()
        {
            if (!this.Visible)
                this.ShowDialog();
            this.Close();
            return txtDescripcion.Text;
        }

        private void frmDescripción_Shown(object sender, EventArgs e)
        {
            txtDescripcion.Select();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Descripcion();
        }
    }
}
