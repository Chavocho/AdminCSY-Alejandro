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
    public partial class frmVentaProducto : Form
    {
        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        frmPOS frm = null;
        frmCotizacion frmC = null;

        public frmVentaProducto(frmPOS frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        public frmVentaProducto(frmCotizacion frm)
        {
            InitializeComponent();
            this.frmC = frm;
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
                string sql = "SELECT p.id, p.nombre, p.codigo, i.precio, i.cant, p.unidad FROM producto AS p INNER JOIN inventario AS i ON (p.id=i.id_producto)" +
                    "WHERE (p.nombre LIKE '%" + p + "%' OR p.codigo='" + p + "') AND i.cant>0 AND p.eliminado=0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los productos. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los productos.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvProductos.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvProductos.Rows.Add(new object[] { dr["id"], dr["nombre"], dr["codigo"], dr["precio"], dr["cant"], dr["unidad"] });
                }
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, 0));
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
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
            }
        }

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                id = (int)dgvProductos[0, e.RowIndex].Value;
            else
                id = 0;
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
            FuncionesGenerales.frmEspera("Espere, buscando productos", this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                DataGridViewRow dr = dgvProductos.CurrentRow;
                if (frm != null)
                {
                    frm.AgregarProducto((int)dr.Cells[0].Value, dr.Cells[2].Value.ToString(), dr.Cells[1].Value.ToString(), (int)nudCant.Value, nudDescuento.Value, (Unidades)Enum.Parse(typeof(Unidades), dr.Cells[5].Value.ToString()), false);
                }
                else if (frmC != null)
                {
                    frmC.AgregarProducto((int)dr.Cells[0].Value, dr.Cells[2].Value.ToString(), dr.Cells[1].Value.ToString(), nudCant.Value, nudDescuento.Value, (Unidades)Enum.Parse(typeof(Unidades), dr.Cells[5].Value.ToString()));
                }
                this.Close();
            }
        }

        private void frmVentaProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && txtBusqueda.Focused)
            {
                dgvProductos.Focus();
            }
            else if (e.KeyCode == Keys.Up && dgvProductos.Focused)
            {
                if (dgvProductos.RowCount > 0)
                {
                    if (dgvProductos.CurrentRow.Index == 0)
                    {
                        txtBusqueda.Focus();
                    }
                }
                else
                {
                    txtBusqueda.Focus();
                }
            }
            else if (e.KeyCode == Keys.Enter && dgvProductos.Focused && dgvProductos.CurrentRow != null)
            {
                dgvProductos.Enabled = false;
                btnAceptar.PerformClick();
            }
        }

    }
}
