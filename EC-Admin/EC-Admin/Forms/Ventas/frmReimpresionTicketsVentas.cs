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
    public partial class frmReimpresionTicketsVentas : Form
    {
        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmReimpresionTicketsVentas()
        {
            InitializeComponent();
            c = new CerrarFrmEspera(Cerrar);
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
                string sql = "SELECT v.id, CONCAT(t.nombre, ' ', t.apellidos) AS vendedor, c.nombre AS cliente, v.total, v.create_time, v.update_time FROM venta AS v INNER JOIN trabajador AS t ON (v.id_vendedor=t.id) INNER JOIN cliente AS c ON (v.id_cliente=c.id) " + 
                    "WHERE v.id='" + p + "' AND abierta=0 AND cancelada=0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas.", "Admin CSY", ex });
            }
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT v.id, CONCAT(t.nombre, ' ', t.apellidos) AS vendedor, c.nombre AS cliente, v.total, v.create_time, v.update_time FROM venta AS v INNER JOIN trabajador AS t ON (v.id_vendedor=t.id) INNER JOIN cliente AS c ON (v.id_cliente=c.id) " +
                    "WHERE (v.create_time BETWEEN ?fechaIni AND ?fechaFin OR v.update_time BETWEEN ?fechaIni AND ?fechaFin) AND abierta=0 AND cancelada=0";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
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
                    DateTime fecha;
                    if (dr["update_time"] != DBNull.Value)
                        fecha = (DateTime)dr["update_time"];
                    else
                        fecha = (DateTime)dr["create_time"];
                    dgvVentas.Rows.Add(new object[] { dr["id"], dr["vendedor"], dr["cliente"], fecha, dr["total"] });
                    Application.DoEvents();
                }
                dgvVentas_RowEnter(dgvVentas, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar las ventas.", "Admin CSY", ex);
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] a = (object[])e.Argument;
            if (a.Length == 1)
            {
                Buscar(a[0].ToString());
            }
            else
            {
                Buscar((DateTime)a[0], (DateTime)a[1]);
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
            FuncionesGenerales.frmEspera("Espere, cargando las ventas", this);
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
                dtpFechaInicio.Value = dtpFechaFin.Value;
            else if (dtpFechaFin.Value < dtpFechaInicio.Value)
                dtpFechaFin.Value = dtpFechaInicio.Value;
        }

        private void dgvVentas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
                id = (int)dgvVentas[0, e.RowIndex].Value;
            else
                id = 0;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                if (FuncionesGenerales.ImprimirTicket(this, "¿Realmente desea imprimir el ticket de ésta venta?"))
                {
                    Ticket t = new Ticket();
                    t.TicketVenta(id);
                }
            }
        }
    }
}
