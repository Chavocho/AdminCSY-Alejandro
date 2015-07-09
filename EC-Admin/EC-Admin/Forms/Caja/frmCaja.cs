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
    public partial class frmCaja : Form
    {
        #region Instancia
        private static frmCaja frmInstancia;
        public static frmCaja Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmCaja();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmCaja();
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
        CerrarFrmEspera c;

        public frmCaja()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(string p)
        {
            c = new CerrarFrmEspera(Cerrar);
            try
            {
                string sql = "SELECT id, efectivo, voucher, descripcion, tipo_movimiento, create_time FROM caja WHERE descripcion LIKE '%" + p + "%' AND id_sucursal='" + Config.idSucursal + "'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar los datos de la caja. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar los datos de la caja.", "Admin CSY", ex });
            }
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            c = new CerrarFrmEspera(Cerrar);
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, efectivo, voucher, descripcion, tipo_movimiento, create_time FROM caja WHERE (create_time BETWEEN ?fechaIni AND ?fechaFin) AND id_sucursal='" + Config.idSucursal + "'";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar los datos de la caja. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar los datos de la caja.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvCaja.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string tipoMovimiento = "";
                    MovimientoCaja mc = (MovimientoCaja)Enum.Parse(typeof(MovimientoCaja), dr["tipo_movimiento"].ToString());
                    switch (mc)
                    {
                        case MovimientoCaja.Entrada:
                            tipoMovimiento = "Entrada";
                            break;
                        case MovimientoCaja.Salida:
                            tipoMovimiento = "Salida";
                            break;
                    }
                    dgvCaja.Rows.Add(new object[] { dr["id"], dr["create_time"], dr["descripcion"].ToString(), dr["efectivo"], dr["voucher"], tipoMovimiento});
                    Application.DoEvents();
                }
                dgvCaja_RowEnter(dgvCaja, new DataGridViewCellEventArgs(0, 0));
                CalcularTotales();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de caja.", "Admin CSY", ex);
            }
        }

        private void CalcularTotales()
        {
            decimal efe = 0M, vou = 0M;
            foreach (DataGridViewRow dr in dgvCaja.Rows)
            {
                efe += (decimal)dr.Cells[3].Value;
                vou += (decimal)dr.Cells[4].Value;
            }
            lblTotEfeMos.Text = efe.ToString("C2");
            lblTotVouMos.Text = vou.ToString("C2");
            lblTotEfeCaj.Text = Caja.TotalEfectivo.ToString("C2");
            lblTotVouCaj.Text = Caja.TotalVouchers.ToString("C2");
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
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(new object[] { txtBusqueda.Text });
            }
        }

        private void dgvCaja_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCaja.CurrentRow != null)
                id = (int)dgvCaja[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnAbrirCerrar_Click(object sender, EventArgs e)
        {
            if (Caja.EstadoCaja)
            {
                (new frmCerrarCaja()).ShowDialog(this);
                if (Caja.EstadoCaja == false)
                {
                    btnAbrirCerrar.Text = "Abrir caja";
                    CalcularTotales();
                }
            }
            else
            {
                (new frmAbrirCaja()).ShowDialog(this);
                if (Caja.EstadoCaja)
                {
                    btnAbrirCerrar.Text = "Cerrar caja";
                    CalcularTotales();
                }
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (Caja.EstadoCaja == false)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "La caja necesita estar abierta para realizar una venta", "Admin CSY");
                return;
            }
            (new frmEntradaSalida(MovimientoCaja.Entrada)).ShowDialog(this);
            CalcularTotales();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (Caja.EstadoCaja == false)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "La caja necesita estar abierta para realizar una venta", "Admin CSY");
                return;
            }
            (new frmEntradaSalida(MovimientoCaja.Salida)).ShowDialog(this);
            CalcularTotales();
        }

        private void frmCaja_Load(object sender, EventArgs e)
        {
            if (Caja.EstadoCaja == false)
            {
                btnAbrirCerrar.Text = "Abrir caja";
            }
            else
            {
                btnAbrirCerrar.Text = "Cerrar caja";
            }
            CalcularTotales();
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Array a = (Array)e.Argument;
            if (a.Length == 1)
            {
                Buscar(a.GetValue(0).ToString());
            }
            else if (a.Length == 2)
            {
                Buscar((DateTime)a.GetValue(0), (DateTime)a.GetValue(1));
            }
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando movimientos de caja", this);
        }

        private void btnCortes_Click(object sender, EventArgs e)
        {
            (new frmCorteCaja()).ShowDialog(this);
        }

        private void frmCaja_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Alt)
            {
                if (e.KeyCode == Keys.F1)
                {
                    btnAbrirCerrar.PerformClick();
                }
                else if (e.KeyCode == Keys.F2)
                {
                    btnEntrada.PerformClick();
                }
                else if (e.KeyCode == Keys.F3)
                {
                    btnSalida.PerformClick();
                }
                else if (e.KeyCode == Keys.F4)
                {
                    btnCortes.PerformClick();
                }
            }
        }
    }
}