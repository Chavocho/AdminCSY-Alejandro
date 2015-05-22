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
    public partial class frmAlmacenTrabajador : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        frmNuevoAlmacen frmN = null;
        frmEditarAlmacen frmE = null;

        public frmAlmacenTrabajador(frmNuevoAlmacen frm)
        {
            InitializeComponent();
            this.frmN = frm;
        }

        public frmAlmacenTrabajador(frmEditarAlmacen frm)
        {
            InitializeComponent();
            this.frmE = frm;
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(string p)
        {
            try
            {
                string sql = "SELECT t.id, t.nombre, t.apellidos, p.nombre AS puesto FROM trabajador AS t INNER JOIN puesto AS p ON (t.puesto=p.id) WHERE t.nombre LIKE '%" + p + "%' OR puesto LIKE '%" + p + "%'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar a los trabajadores. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar a los trabajadores.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvTrabajadores.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvTrabajadores.Rows.Add(new object[] { dr["id"], dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), dr["puesto"].ToString() });
                }
                dgvTrabajadores_RowEnter(dgvTrabajadores, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de los trabajadores.", "Admin CSY", ex);
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tmrEspera.Enabled = false;
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
            }
        }

        private void dgvTrabajadores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTrabajadores.CurrentRow != null)
                id = (int)dgvTrabajadores[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvTrabajadores.CurrentRow != null)
            {
                if (frmN != null)
                {
                    frmN.IDTrabajador = id;
                    frmN.NombreTrabajador = dgvTrabajadores[1, dgvTrabajadores.CurrentRow.Index].Value.ToString();
                }
                else if (frmE != null)
                {
                    frmE.IDTrabajador = id;
                    frmE.NombreTrabajador = dgvTrabajadores[1, dgvTrabajadores.CurrentRow.Index].Value.ToString();
                }
                this.Close();
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Buscar(e.Argument.ToString());
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, buscando trabajadores", this);
        }
    }
}
