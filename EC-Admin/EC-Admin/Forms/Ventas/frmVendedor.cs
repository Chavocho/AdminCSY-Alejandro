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
    public partial class frmVendedor : Form
    {
        int id = 0, idActual = 0;
        frmPOS frm = null;
        frmNuevaCompra frmC = null;
        frmCotizacion frmCT = null;

        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmVendedor(frmPOS frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.lblENombre.Visible = this.lblNombre.Visible = false;
        }

        public frmVendedor(frmPOS frm, int id, string nombre)
        {
            InitializeComponent();
            this.frm = frm;
            this.id = idActual;
            this.lblNombre.Text = nombre;
        }

        public frmVendedor(frmNuevaCompra frm)
        {
            InitializeComponent();
            this.frmC = frm;
            this.lblENombre.Visible = this.lblNombre.Visible = false;
        }

        public frmVendedor(frmNuevaCompra frm, int id, string nombre)
        {
            InitializeComponent();
            this.frmC = frm;
            this.id = idActual;
            this.lblNombre.Text = nombre;
            lblENombre.Text = "Comprador actual:";
        }

        public frmVendedor(frmCotizacion frm)
        {
            InitializeComponent();
            this.frmCT = frm;
            this.lblENombre.Visible = this.lblNombre.Visible = false;
        }

        public frmVendedor(frmCotizacion frm, int id, string nombre)
        {
            InitializeComponent();
            this.frmCT = frm;
            this.id = idActual;
            this.lblNombre.Text = nombre;
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
                string sql = "SELECT t.id, t.nombre, t.apellidos, p.nombre AS puesto FROM trabajador AS t INNER JOIN puesto AS p ON (t.puesto=p.id) WHERE (t.nombre LIKE '%" + p + "%' OR t.apellidos LIKE '%" + p + "%') OR p.nombre LIKE '%" + p + "%'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los trabajadores. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los trabajadores.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvTrabajadores.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvTrabajadores.Rows.Add(new object[] { dr["id"], dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), dr["puesto"] });
                }
                dgvTrabajadores_RowEnter(dgvTrabajadores, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de los trabajadores.", "Admin CSY", ex);
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
            }
        }

        private void dgvTrabajadores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTrabajadores.CurrentRow != null)
                id = (int)dgvTrabajadores[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvTrabajadores.CurrentRow == null && idActual > 0)
            {
                if (frm != null)
                {
                    frm.AsignarVendedor(idActual, dgvTrabajadores[1, dgvTrabajadores.CurrentRow.Index].Value.ToString());
                }
                else if (frmC != null)
                {
                    frmC.AsignarComprador(idActual, dgvTrabajadores[1, dgvTrabajadores.CurrentRow.Index].Value.ToString());
                }
                else if (frmCT != null)
                {
                    frmCT.AsignarVendedor(idActual, dgvTrabajadores[1, dgvTrabajadores.CurrentRow.Index].Value.ToString());
                }
                this.Close();
            }
            else if (dgvTrabajadores.CurrentRow != null && id > 0)
            {
                if (frm != null)
                {
                    frm.AsignarVendedor(id, dgvTrabajadores[1, dgvTrabajadores.CurrentRow.Index].Value.ToString());
                }
                else if (frmC != null)
                {
                    frmC.AsignarComprador(id, dgvTrabajadores[1, dgvTrabajadores.CurrentRow.Index].Value.ToString());
                }
                else if (frmCT != null)
                {
                    frmCT.AsignarVendedor(id, dgvTrabajadores[1, dgvTrabajadores.CurrentRow.Index].Value.ToString());
                }
                this.Close();
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
            FuncionesGenerales.frmEspera("Espere, cargando trabajadores", this);
        }

        private void frmVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && txtBusqueda.Focused)
            {
                dgvTrabajadores.Focus();
            }
            else if (e.KeyCode == Keys.Up && dgvTrabajadores.Focused)
            {
                if (dgvTrabajadores.CurrentRow != null)
                {
                    if (dgvTrabajadores.CurrentRow.Index == 0)
                    {
                        txtBusqueda.Focus();
                    }
                }
                else
                {
                    txtBusqueda.Focus();
                }
            }
            else if (e.KeyCode == Keys.Enter && dgvTrabajadores.Focused && dgvTrabajadores.CurrentRow != null)
            {
                dgvTrabajadores.Enabled = false;
                btnAceptar.PerformClick();
            }
        }
    }
}
