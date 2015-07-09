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
    public partial class frmCorteCaja : Form
    {
        int idA = 0, idC = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmCorteCaja()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void BuscarCortes(DateTime fechaIni, DateTime fechaFin)
        {
            CerrarFrmEspera c = new CerrarFrmEspera(Cerrar);
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, efectivo, voucher, create_time FROM caja WHERE descripcion='CIERRE DE CAJA' AND (create_time BETWEEN ?fechaIni AND ?fechaFin) AND id_sucursal='" + Config.idSucursal + "'";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los cortes de caja. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los cortes de caja.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvCaja.Rows.Clear();
                DateTime fechas;
                foreach (DataRow dr in dt.Rows)
                {
                    fechas = DateTime.Parse(dr["create_time"].ToString());
                    dgvCaja.Rows.Add(new object[] { dr["id"], fechas, (decimal.Parse(dr["efectivo"].ToString()) * -1), (decimal.Parse(dr["voucher"].ToString()) * -1) });
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ha ocurrido un error al mostrar los cortes de caja.", "Admin CSY", ex);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (FuncionesGenerales.ImprimirTicket(this, "¿Desea imprimir este corte?"))
            {
                try
                {
                    (new Ticket()).ImprimirCorteCaja(idA, idC);
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha impreso el ticket correctamente!", "Admin CSY");
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el corte de caja. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el corte de caja.", "Admin CSY", ex);
                }
            }
        }

        private void dgvCaja_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idC = (int)dgvCaja[0, e.RowIndex].Value;
                string sql = "SELECT MAX(id) AS idA FROM caja WHERE descripcion = 'APERTURA DE CAJA' AND id<" + idC;
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idA = (int)dr["idA"];
                }
            }
            catch
            {
            }
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
                dtpFechaInicio.Value = dtpFechaFin.Value;
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
                dtpFechaFin.Value = dtpFechaInicio.Value;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!bgwBusqueda.IsBusy)
            {
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] f = (object[])e.Argument;
            BuscarCortes((DateTime)f[0], (DateTime)f[1]);
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void frmCorteCaja_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Alt)
            {
                if (e.Control && e.KeyCode == Keys.I)
                {
                    btnImprimir.PerformClick();
                }
                if (e.KeyCode == Keys.Up)
                {
                    btnBuscar.Focus();
                    FuncionesGenerales.DataGridViewUp(dgvCaja);
                }
                if (e.KeyCode == Keys.Down)
                {
                    btnBuscar.Focus();
                    FuncionesGenerales.DataGridViewDown(dgvCaja);
                }
            }
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando cortes", this);
        }

    }
}
