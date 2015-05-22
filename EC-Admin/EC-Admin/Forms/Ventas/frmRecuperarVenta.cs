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
    public partial class frmRecuperarVenta : Form
    {
        int id = 0;
        frmPOS frm;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmRecuperarVenta(frmPOS frm)
        {
            InitializeComponent();
            this.frm = frm;
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
                string sql = "SELECT id, create_time, total FROM venta WHERE id='" + p + "' AND abierta=1";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas.", "Admin CSY", ex });
            }
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, create_time, total FROM venta WHERE (create_time BETWEEN ?fechaIni AND ?fechaFin) AND abierta=1";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvVentas.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvVentas.Rows.Add(new object[] { dr["id"], dr["create_time"], dr["total"] });
                }
                dgvVentas_RowEnter(dgvVentas, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar las ventas.", "Admin CSY", ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(new object[] { txtBusqueda.Text });
            }
        }

        private void dgvVentas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
                id = (int)dgvVentas[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Array a = (Array)e.Argument;
            switch (a.Length)
            {
                case 1:
                    Buscar(a.GetValue(0).ToString());
                    break;
                case 2:
                    Buscar((DateTime)a.GetValue(0), (DateTime)a.GetValue(1));
                    break;
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
            FuncionesGenerales.frmEspera("Espere, cargando ventas", this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                frm.RecuperarVenta(id);
                this.Close();
            }
        }

        private void frmRecuperarVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && (txtBusqueda.Focused || btnBuscar.Focused || dtpFechaInicio.Focused || dtpFechaFin.Focused))
            {
                dgvVentas.Focus();
            }
            else if (e.KeyCode == Keys.Up && dgvVentas.Focused)
            {
                if (dgvVentas.CurrentRow != null)
                {
                    if (dgvVentas.CurrentRow.Index == 0)
                    {
                        txtBusqueda.Focus();
                    }
                }
                else
                {
                    txtBusqueda.Focus();
                }
            }
            else if (e.KeyCode == Keys.Enter && dgvVentas.Focused && dgvVentas.CurrentRow != null)
            {
                dgvVentas.Enabled = false;
                btnAceptar.PerformClick();
            }
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
                dtpFechaInicio.Value = dtpFechaFin.Value;
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
                dtpFechaFin.Value = dtpFechaInicio.Value;
        }
    }
}
