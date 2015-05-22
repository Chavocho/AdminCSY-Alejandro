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
    public partial class frmUsuariosEliminados : Form
    {
        int id;
        DataTable dt = new DataTable();

        public frmUsuariosEliminados()
        {
            InitializeComponent();
        }

        private void BuscarUsuarios()
        {
            try
            {
                string sql = "SELECT id, username, nombre, apellidos, nivel, email FROM usuario WHERE eliminado=1";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarDataGrid()
        {
            dgvUsuarios.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string nivel = "";
                switch (dr["nivel"].ToString())
                {
                    case "0":
                        nivel = "Administrador";
                        break;
                    case "1":
                        nivel = "Encargado";
                        break;
                    case "2":
                        nivel = "Desconocido";
                        break;
                }
                dgvUsuarios.Rows.Add(dr["id"], dr["username"], dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), dr["email"], nivel);
            }
            dgvUsuarios_RowEnter(dgvUsuarios, new DataGridViewCellEventArgs(0, 0));
        }

        private void dgvUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                id = (int)dgvUsuarios[0, e.RowIndex].Value;
            }
            else
            {
                id = 0;
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarUsuarios();
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Buscando usuarios eliminados, espere", this);
        }

        private void frmUsuariosEliminados_Load(object sender, EventArgs e)
        {
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync();
        }

        private void btnRestablecerUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                DialogResult r = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente deseas restablecer a " + dgvUsuarios[2, dgvUsuarios.CurrentRow.Index].Value.ToString() + "?", "Admin CSY");
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    Usuario.CambiarEstadoEliminadoUsuario(id, false);
                    tmrEspera.Enabled = true;
                    bgwBusqueda.RunWorkerAsync();
                }
            }
        }

    }
}
