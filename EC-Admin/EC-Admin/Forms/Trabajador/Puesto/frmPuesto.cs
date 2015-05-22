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
    public partial class frmPuesto : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmPuesto()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar()
        {
            try
            {
                string sql = "SELECT id, nombre, departamento FROM puesto";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar los puestos. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error genérico al cargar los puestos.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvPuestos.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvPuestos.Rows.Add(new object[] { dr["id"], dr["nombre"], dr["departamento"] });
                }
                dgvPuestos_RowEnter(dgvPuestos, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmDatosPuesto()).ShowDialog(this);
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPuestos.CurrentRow != null && id > 0)
            {
                (new frmDatosPuesto(id)).ShowDialog(this);
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync();
            }
        }

        private void dgvPuestos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPuestos.CurrentRow != null)
                id = (int)dgvPuestos[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync();
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Buscar();
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, buscando puestos", this);
        }
    }
}
