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
    public partial class frmCuenta : Form
    {
        #region Instancia
        private static frmCuenta frmInstancia;
        public static frmCuenta Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmCuenta();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmCuenta();
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
        
        public frmCuenta()
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
                string sql = "SELECT * FROM cuenta";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las cuentas. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las cuentas.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            dgvCuentas.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dgvCuentas.Rows.Add(new object[] { dr["id"], dr["clabe"], dr["banco"], dr["beneficiario"], dr["sucursal"], dr["num_cuenta"] });
            }
            dgvCuentas_RowEnter(dgvCuentas, new DataGridViewCellEventArgs(0, 0));
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
            FuncionesGenerales.frmEspera("Espere, buscando cuentas bancarias", this);
        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {
            bgwBusqueda.RunWorkerAsync();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmNuevaCuenta()).ShowDialog(this);
            bgwBusqueda.RunWorkerAsync();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.CurrentRow != null && id > 0)
            {
                (new frmEditarCuenta(id)).ShowDialog(this);
                bgwBusqueda.RunWorkerAsync();
            }
        }

        private void dgvCuentas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentas.CurrentRow != null)
                id = (int)dgvCuentas[0, e.RowIndex].Value;
            else
                id = 0;
        }
    }
}
