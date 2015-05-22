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
    public partial class frmDomicilio : Form
    {
        #region Instancia
        private static frmDomicilio frmInstancia;
        public static frmDomicilio Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmDomicilio();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmDomicilio();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id;
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        DataTable dt;

        public frmDomicilio()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
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
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al obtener las direcciones de facturación registradas. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
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

        private void Eliminar()
        {
            try
            {
                Sucursal.CambiarEstadoDireccion(id, true);
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

        private void frmDomicilio_Load(object sender, EventArgs e)
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmNuevoDomicilio()).ShowDialog(this);
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDomicilio.CurrentRow != null)
            {
                (new frmEditarDomicilio(id)).ShowDialog(this);
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDomicilio.CurrentRow != null)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente desea eliminar este domicilio?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Eliminar();
                        tmrEspera.Enabled = true;
                        bgwBusqueda.RunWorkerAsync();
                    }
                    catch (MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al eliminar el domicilio. No se ha podido conectar a la base de datos.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al eliminar el domicilio.", "Admin CSY", ex);
                    }
                }
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarDomicilios();
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, buscando domicilios fiscales", this);
        }
    }
}
