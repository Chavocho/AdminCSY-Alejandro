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
    public partial class frmVerificarUsuario : Form
    {
        frmReestablecerPass frm;

        public frmVerificarUsuario(frmReestablecerPass frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private bool VerificarCódigo(string cod)
        {
            bool esCorrecto = false;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT num_aut FROM usuario WHERE num_aut=?num_aut AND id=?id";
                sql.Parameters.AddWithValue("?num_aut", cod);
                sql.Parameters.AddWithValue("?id", frm.ID);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    esCorrecto = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return esCorrecto;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (VerificarCódigo(txtCodigo.Text))
            {
                frm.CambioFormulario(new frmReestablecer(frm));
            }
            else
            {
                MessageBox.Show("El código ingresado no es correcto, verifícalo.", "Admin CSY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Text = "";
            }
        }
    }
}
