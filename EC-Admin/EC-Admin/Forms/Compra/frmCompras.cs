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
    public partial class frmCompras : Form
    {
        #region Instancia
        private static frmCompras frmInstancia;
        public static frmCompras Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmCompras();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmCompras();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmCompras()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            c = new CerrarFrmEspera(Cerrar);
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT c.id, c.total, c.create_time FROM compra AS c INNER JOIN compra_detallada AS d ON (c.id=d.id_compra) WHERE (c.create_time BETWEEN ?fechaIni AND ?fechaFin)";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las compras. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las compras.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvCompras.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvCompras.Rows.Add(new object[] { dr["id"], dr["create_time"], dr["total"] });
                }
                dgvCompras_RowEnter(dgvCompras, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar la información de la venta.", "Admin CSY", ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
                dtpFechaInicio.Value = dtpFechaFin.Value;
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
                dtpFechaFin.Value = dtpFechaInicio.Value;
        }

        private void dgvCompras_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Caja.EstadoCaja == false)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "La caja necesita estar abierta para realizar una compra", "Admin CSY");
                return;
            }
            (new frmNuevaCompra()).ShowDialog(this);
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] a = (object[])e.Argument;
            Buscar((DateTime)a[0], (DateTime)a[1]);
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando las compras", this);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvCompras.CurrentRow != null)
            {
                (new frmDetalladoCompra(id)).ShowDialog(this);
            }
        }
    }
}
