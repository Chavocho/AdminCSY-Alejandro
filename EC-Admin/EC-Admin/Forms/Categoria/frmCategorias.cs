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
    public partial class frmCategorias : Form
    {
        #region Instancia
        private static frmCategorias frmInstancia;
        public static frmCategorias Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmCategorias();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmCategorias();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmCategorias()
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
                string sql = "SELECT * FROM categoria";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar las categorías. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar las categorías.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvCategorias.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvCategorias.Rows.Add(new object[] { dr["id"], dr["nombre"].ToString(), dr["descripcion"].ToString() });
                }
                dgvCategorias_RowEnter(dgvCategorias, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar las categorías.", "Admin CSY", ex);
            }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmNuevaCategoria()).ShowDialog(this);
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                (new frmEditarCategoria(id)).ShowDialog(this);
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync();
            }
        }

        private void dgvCategorias_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
                id = (int)dgvCategorias[0, e.RowIndex].Value;
            else
                id = 0;
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
            FuncionesGenerales.frmEspera("Espere, cargando categorías", this);
        }
    }
}
