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
    public partial class frmConfigAlmacen : Form
    {
        #region Instancia
        private static frmConfigAlmacen frmInstancia;
        public static frmConfigAlmacen Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmConfigAlmacen();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmConfigAlmacen();
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

        public frmConfigAlmacen()
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
                string sql = "SELECT a.*, t.nombre, t.apellidos FROM almacen AS a INNER JOIN trabajador AS t ON (a.id_trabajador=t.id)";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los almacenes. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los almacenes.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvAlmacen.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvAlmacen.Rows.Add(new object[] { dr["id"], dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), dr["num_alm"], dr["descripcion"].ToString() });
                }
                dgvAlmacen_RowEnter(dgvAlmacen, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de los almacenes.", "Admin CSY", ex);
            }
        }

        private void frmConfigAlmacen_Load(object sender, EventArgs e)
        {
            bgwBusqueda.RunWorkerAsync();
            tmrEspera.Enabled = true;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (Trabajador.Cantidad <= 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "Debes tener registrado al menos a un trabajador para poder crear almacenes", "Admin CSY");
                return;
            }
            (new frmNuevoAlmacen()).ShowDialog(this);
            bgwBusqueda.RunWorkerAsync();
            tmrEspera.Enabled = true;
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvAlmacen.CurrentRow != null)
            {
                (new frmEditarAlmacen(id)).ShowDialog(this);
                bgwBusqueda.RunWorkerAsync();
                tmrEspera.Enabled = true;
            }
        }

        private void dgvAlmacen_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlmacen.CurrentRow != null)
                id = (int)dgvAlmacen[0, e.RowIndex].Value;
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
            FuncionesGenerales.frmEspera("Espere, cargando almacenes", this);
        }
    }
}
