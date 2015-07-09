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
    public partial class frmVentaPromociones : Form
    {
        int id;
        frmPOS frm;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmVentaPromociones(frmPOS frm)
        {
            InitializeComponent();
            c = new CerrarFrmEspera(Cerrar);
            cboTipoPromocion.SelectedIndex = 0;
            this.frm = frm;
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void BuscarExistencias()
        {
            try
            {
                string sql = "SELECT p.id, p.cant, p.cant_prod, p.precio, pr.id AS idP, pr.nombre, pr.codigo, pr.unidad FROM promocion AS p INNER JOIN producto AS pr ON (p.id_producto=pr.id) WHERE p.existencias=1 AND p.cant_prod>0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las promociones. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las promociones.", "Admin CSY", ex });
            }
        }

        private void BuscarFechas()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT p.id, p.precio, pr.id AS idP, pr.nombre, pr.codigo, pr.unidad FROM promocion AS p INNER JOIN producto AS pr ON (p.id_producto=pr.id) WHERE p.existencias=0 AND (p.fecha_ini<=?fecha AND p.fecha_fin>=?fecha)";
                sql.Parameters.AddWithValue("?fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las promociones. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las promociones.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvProductos.Rows.Clear();
                if (cboTipoPromocion.SelectedIndex == 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvProductos.Rows.Add(new object[] { dr["id"], dr["idP"], dr["codigo"], dr["nombre"], dr["precio"], dr["cant"], dr["cant_prod"], dr["unidad"] });
                    }
                }
                else if (cboTipoPromocion.SelectedIndex == 1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvProductos.Rows.Add(new object[] { dr["id"], dr["idP"], dr["codigo"], dr["nombre"], dr["precio"], 0M, 0M, dr["unidad"] });
                    }
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar las promociones.", "Admin CSY", ex);
            }
        }

        private void cboTipoPromocion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoPromocion.SelectedIndex == 0)
            {
                dgvProductos.Columns[5].Visible = true;
            }
            else if (cboTipoPromocion.SelectedIndex == 1)
            {
                dgvProductos.Columns[5].Visible = false;
            }
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync(cboTipoPromocion.SelectedIndex);
        }

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                id = (int)dgvProductos[0, e.RowIndex].Value;
            }
            else
            {
                id = 0;
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            if ((int)e.Argument == 0)
            {
                BuscarExistencias();
            }
            else if ((int)e.Argument == 1)
            {
                BuscarFechas();
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
            FuncionesGenerales.frmEspera("Espere, cargando las promociones", this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                if ((decimal)dgvProductos[5, dgvProductos.CurrentRow.Index].Value * nudCantidad.Value <= (decimal)dgvProductos[6, dgvProductos.CurrentRow.Index].Value)
                {
                    bool existencias;
                    if (cboTipoPromocion.SelectedIndex == 0)
                        existencias = true;
                    else
                        existencias = false;
                    DataGridViewRow dr = dgvProductos.CurrentRow;
                    frm.PromocionProducto((int)dr.Cells[1].Value, dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString(), (decimal)dr.Cells[4].Value, nudCantidad.Value * (decimal)dr.Cells[5].Value, (decimal)dr.Cells[6].Value, (Unidades)Enum.Parse(typeof(Unidades), dr.Cells[7].Value.ToString()), (int)dr.Cells[0].Value, existencias);
                    this.Close();
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "La cantidad de promociones a vender excede las existencias.", "Admin CSY");
                }
            }
        }
    }
}
