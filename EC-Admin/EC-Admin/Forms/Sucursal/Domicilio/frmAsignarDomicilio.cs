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
    public partial class frmAsignarDomicilio : Form
    {
        int id;
        DataTable dt;
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        frmNuevaSucursal frmN = null;
        frmEditarSucursal frmE = null;

        public frmAsignarDomicilio(frmNuevaSucursal frm)
        {
            InitializeComponent();
            this.frmN = frm;
        }

        public frmAsignarDomicilio(frmEditarSucursal frm)
        {
            InitializeComponent();
            this.frmE = frm;
        }

        private void BuscarDomicilios()
        {
            try
            {
                string sql = "SELECT * FROM direccion WHERE eliminado=0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al obtener las direcciones de facturación registradas. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error genérico al obtener las direcciones de facturación registradas.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            dgvDomicilio.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string dir = dr["calle"].ToString() + " Ext. " + dr["num_ext"].ToString();
                if (dr["num_int"].ToString() != "")
                    dir += " Int. " + dr["num_int"].ToString();
                dgvDomicilio.Rows.Add(new object[] { dr["id"], dir, dr["cp"], dr["colonia"], dr["ciudad"], dr["estado"] });
            }
            dgvDomicilio_RowEnter(dgvDomicilio, new DataGridViewCellEventArgs(0, 0));
        }

        private void frmAsignarDomicilio_Load(object sender, EventArgs e)
        {
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync();
        }

        private void dgvDomicilio_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDomicilio.CurrentRow != null)
                id = (int)dgvDomicilio[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarDomicilios();
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, buscando domicilios fiscales", this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDomicilio.CurrentRow != null)
            {
                if (frmN != null)
                    frmN.IDDireccion = id;
                else if (frmE != null)
                    frmE.IDDireccion = id;
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmNuevoDomicilio()).ShowDialog(this);
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync();
        }
    }
}
