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
    public partial class frmTraspasos : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;
        EstadoTraspaso e;

        public frmTraspasos()
        {
            InitializeComponent();
            c = new CerrarFrmEspera(Cerrar);
            cboTraspasos.SelectedIndex = 0;
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, id_sucursal_solicito, <id_sucursal_origen, id_sucursal_destino, descripcion FROM traspaso WHERE (create_time BETWEEN ?fecha_ini AND ?fecha_fin) AND estado=?estado";
                sql.Parameters.AddWithValue("?fecha_ini", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fecha_fin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                sql.Parameters.AddWithValue("?estado", e);
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los traspasos. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los traspasos.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvTraspasos.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvTraspasos.Rows.Add(dr["id"], dr["id_sucursal_solicito"], dr["id_sucursal_origen"], dr["id_sucursal_destino"], Sucursal.NombreSucursal((int)dr["id_sucursal_origen"]), Sucursal.NombreSucursal((int)dr["id_sucursal_destino"]), dr["descripcion"].ToString());
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los traspasos.", "Admin CSY", ex);
            }
        }

        private void dgvTraspasos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTraspasos.CurrentRow != null)
                id = (int)dgvTraspasos[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void cboTraspasos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTraspasos.SelectedIndex)
            {
                case 0:
                    this.e = EstadoTraspaso.Espera;
                    break;
                case 1:
                    this.e = EstadoTraspaso.Aceptada;
                    break;
                case 2:
                    this.e = EstadoTraspaso.Recibida;
                    break;
                case 3:
                    this.e = EstadoTraspaso.Rechazada;
                    break;
            }
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaIni.Value > dtpFechaFin.Value)
                dtpFechaFin.Value = dtpFechaIni.Value;
            else if (dtpFechaFin.Value < dtpFechaIni.Value)
                dtpFechaIni.Value = dtpFechaFin.Value;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Sucursal.Cantidad >= 2)
            {
                (new frmNuevoTraspaso()).ShowDialog(this);
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "Necesitas tener al menos dos sucursales registradas para poder hacer traspasos", "Admin CSY");
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvTraspasos.CurrentRow != null)
            {
                DataGridViewRow dr = dgvTraspasos.CurrentRow;
                switch (this.e)
                {
                    case EstadoTraspaso.Recibida:
                    case EstadoTraspaso.Rechazada:
                        (new frmDetalleTraspaso(id)).ShowDialog(this);
                        break;
                    case EstadoTraspaso.Aceptada:
                        if ((int)dr.Cells[1].Value == Config.idSucursal)
                        {
                            (new frmDetalleTraspaso(id)).ShowDialog(this);
                        }
                        break;
                    case EstadoTraspaso.Espera:
                        if (((int)dr.Cells[1].Value == (int)dr.Cells[2].Value && (int)dr.Cells[3].Value == Config.idSucursal) || ((int)dr.Cells[1].Value == (int)dr.Cells[3].Value && (int)dr.Cells[1].Value == Config.idSucursal))
                        {
                            (new frmDetalleTraspaso(id)).ShowDialog(this);
                        }
                        break;
                }               
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!bgwBusqueda.IsBusy)
            {
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaIni.Value, dtpFechaFin.Value });
            }
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
            FuncionesGenerales.frmEspera("Espere, buscando traspasos", this);
        }
    }
}
