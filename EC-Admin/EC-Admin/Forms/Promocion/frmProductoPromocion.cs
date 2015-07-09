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
    public partial class frmProductoPromocion : Form
    {
        int id;
        frmNuevaPromocion frmN = null;
        frmEditarPromocion frmE = null;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmProductoPromocion(frmNuevaPromocion frm)
        {
            InitializeComponent();
            this.frmN = frm;
            c = new CerrarFrmEspera(Cerrar);
        }

        public frmProductoPromocion(frmEditarPromocion frm)
        {
            InitializeComponent();
            this.frmE = frm;
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
                string sql = "SELECT id, nombre, marca, costo, precio, cant FROM producto WHERE nombre LIKE '%" + p + "%' OR marca LIKE '%" + p + "%'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los productos. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los productos.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvPromociones.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvPromociones.Rows.Add(new object[] { dr["id"], dr["nombre"], dr["marca"], dr["costo"], dr["precio"], dr["cant"] });
                }
                dgvPromociones_RowEnter(dgvPromociones, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvPromociones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPromociones.CurrentRow != null)
            {
                id = (int)dgvPromociones[0, e.RowIndex].Value;
            }
            else
            {
                id = 0;
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
            FuncionesGenerales.frmEspera("Espere, cargando los productos", this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                if (frmN != null)
                {
                    frmN.AsignarProducto(id, dgvPromociones[1, dgvPromociones.CurrentRow.Index].Value.ToString(), dgvPromociones[2, dgvPromociones.CurrentRow.Index].Value.ToString(), (decimal)dgvPromociones[5, dgvPromociones.CurrentRow.Index].Value);
                }
                else if (frmE != null)
                {
                    frmE.AsignarProducto(id, dgvPromociones[1, dgvPromociones.CurrentRow.Index].Value.ToString(), dgvPromociones[2, dgvPromociones.CurrentRow.Index].Value.ToString(), (decimal)dgvPromociones[5, dgvPromociones.CurrentRow.Index].Value);
                }
                this.Close();
            }
        }
    }
}
