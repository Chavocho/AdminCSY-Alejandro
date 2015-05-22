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
    public partial class frmReestablecerPass : Form
    {
        int id;
        string correo;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        
        public frmReestablecerPass()
        {
            InitializeComponent();
            CambioFormulario(new frmIngresarUsuario(this));
        }

        public void CambioFormulario(IWin32Window frm)
        {
            if (pnlFormularios.Controls.Count > 0)
            {
                Form fr = (Form)pnlFormularios.Controls[0];
                fr.Close();
            }
            Form f = (Form)frm;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            pnlFormularios.Controls.Clear();
            pnlFormularios.Controls.Add(f);
            f.Show();
        }

        public void Cerrar()
        {
            Form f = (Form)pnlFormularios.Controls[0];
            f.Close();
            this.Close();
        }
    }
}
