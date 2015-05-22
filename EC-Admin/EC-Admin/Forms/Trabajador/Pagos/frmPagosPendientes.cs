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
    public partial class frmPagosPendientes : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmPagosPendientes()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            txtBusqueda.Enabled = false;
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
        }

        private void Cerrar()
        {
            txtBusqueda.Enabled = true;
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(string p)
        {
            try
            {
                string sql = "SELECT t.id, t.nombre, t.apellidos, t.nomina, t.sueldo, pu.nombre AS puesto, p.pago, p.fecha FROM trabajador AS t INNER JOIN puesto AS pu ON (t.puesto=pu.id) LEFT JOIN pago_trabajador AS p ON (t.id=p.id_trabajador) WHERE ((t.nombre LIKE '%" + p + "%' OR t.apellidos LIKE '%" + p + "%') OR t.nomina='" + p + "') AND t.eliminado=0 ORDER BY t.id DESC LIMIT 1";
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
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar a los trabajadores. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            dgvPagos.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string ultimoPago = "Sin información";
                if (dr["fecha"] != DBNull.Value)
                {
                    DateTime fecha = (DateTime)dr["fecha"];
                    ultimoPago = fecha.ToString("dd") + " de " + fecha.ToString("MMMM") + " del " + fecha.ToString("yyyy") + ", " + fecha.ToString("hh:mm tt") + ", " + decimal.Parse(dr["pago"].ToString()).ToString("C2");
                }
                dgvPagos.Rows.Add(new object[] { dr["id"], dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), dr["nomina"], dr["puesto"], dr["sueldo"], ultimoPago });
            }
        }

        private void IngresarPago(decimal sueldo)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO pago_trabajador (id_trabajador, pago, fecha) VALUES (?id_trabajador, ?pago, NOW())";
                sql.Parameters.AddWithValue("?id", id);
                sql.Parameters.AddWithValue("?sueldo", sueldo);
                ConexionBD.EjecutarConsulta(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
            }
        }

        private void dgvPagos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPagos.CurrentRow != null)
            {
                id = (int)dgvPagos[0, dgvPagos.CurrentRow.Index].Value;
            }
            else
            {
                id = 0;
            }
        }

        private void dgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                IngresarPago((decimal)dgvPagos[4, e.RowIndex].Value);
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
            FuncionesGenerales.frmEspera("Espere, búscando trabajadores", this);
        }
    }
}
