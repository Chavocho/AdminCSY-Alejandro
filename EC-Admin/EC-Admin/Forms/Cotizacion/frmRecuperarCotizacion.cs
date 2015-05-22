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
    public partial class frmRecuperarCotizacion : Form
    {
        int id;
        frmCotizacion frm;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmRecuperarCotizacion(frmCotizacion frm)
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
            c = new CerrarFrmEspera(Cerrar);
            try
            {
                string sql = "SELECT id, total, create_time FROM cotizacion WHERE id='" + id + "'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar las cotizaciones. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar las cotizaciones.", "Admin CSY", ex });
            }
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            c = new CerrarFrmEspera(Cerrar);
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, total, create_time FROM cotizacion WHERE (create_time BETWEEN ?fechaIni AND ?fechaFin)";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar las cotizaciones. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar las cotizaciones.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvCotizacion.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvCotizacion.Rows.Add(new object[] { dr["id"], dr["create_time"], dr["total"] });
                }
                dgvCotizacion_RowEnter(dgvCotizacion, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de las cotizaciones.", "Admin CSY", ex);
            }
        }

        private void dgvCotizacion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCotizacion.CurrentRow != null)
                id = (int)dgvCotizacion[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(new object[] { txtBusqueda.Text });
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
                dtpFechaInicio.Value = dtpFechaFin.Value;
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
                dtpFechaFin.Value = dtpFechaInicio.Value;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvCotizacion.CurrentRow != null)
            {
                frm.RecuperarCotizacion(id);
                this.Close();
            }
        }

        private void frmRecuperarCotizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && (txtBusqueda.Focused || btnBuscar.Focused || dtpFechaInicio.Focused || dtpFechaFin.Focused))
            {
                dgvCotizacion.Focus();
            }
            else if (e.KeyCode == Keys.Up && dgvCotizacion.Focused)
            {
                if (dgvCotizacion.CurrentRow != null)
                {
                    if (dgvCotizacion.CurrentRow.Index == 0)
                    {
                        txtBusqueda.Focus();
                    }
                }
                else
                {
                    txtBusqueda.Focus();
                }
            }
            else if (e.KeyCode == Keys.Enter && dgvCotizacion.Focused && dgvCotizacion.CurrentRow != null)
            {
                dgvCotizacion.Enabled = false;
                btnAceptar.PerformClick();
            }
        }
    }
}
