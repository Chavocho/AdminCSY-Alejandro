using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EC_Admin.Forms
{
    public partial class frmSucursal : Form
    {
        #region Instancia
        private static frmSucursal frmInstancia;
        public static frmSucursal Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmSucursal();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmSucursal();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id = 0;
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        DataTable dt = new DataTable();
        public frmSucursal()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void BuscarSucursales()
        {
            try
            {
                string sql = "SELECT id, nombre, rfc, calle, numero_ext, numero_int, telefono1, telefono2 FROM sucursal WHERE eliminado=0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al conectar con la base de datos para cargar las sucursales.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error genérico al cargar las sucursales.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            dgvSucursal.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string telefonos = "", direccion = dr["calle"].ToString() + " Ext. " + dr["numero_ext"].ToString();
                if (dr["telefono1"].ToString() != "" && dr["telefono2"].ToString() != "")
                {
                    telefonos += dr["telefono1"].ToString();
                    telefonos += ", " + dr["telefono2"].ToString();
                }
                else if (dr["telefono1"].ToString() != "")
                {
                    telefonos += dr["telefono1"].ToString();
                }
                else if (dr["telefono2"].ToString() != "")
                {
                    telefonos += dr["telefono2"].ToString();
                }

                if (dr["numero_int"].ToString() != "")
                    direccion += " Int. " + dr["numero_int"].ToString();
                dgvSucursal.Rows.Add(new object[] { dr["id"], dr["nombre"], dr["rfc"], telefonos, direccion });
            }
            dgvSucursal_RowEnter(dgvSucursal, new DataGridViewCellEventArgs(0, 0));
        }

        private void EliminarSucursal()
        {
            try
            {
                Sucursal.CambiarEstado(id, true);
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

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            tmrEspera.Enabled = true;
            bgwBusqueda.RunWorkerAsync();
        }

        private void dgvSucursal_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSucursal.CurrentRow != null)
                id = (int)dgvSucursal[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmNuevaSucursal()).ShowDialog(this);
            bgwBusqueda.RunWorkerAsync();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.CurrentRow != null)
            {
                (new frmEditarSucursal(id)).ShowDialog(this);
                bgwBusqueda.RunWorkerAsync();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.CurrentRow != null)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Deseas eliminar la sucursal con nombre " + dgvSucursal[1, dgvSucursal.CurrentRow.Index].Value.ToString() + "?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        EliminarSucursal();
                    }
                    catch (MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al eliminar la sucursal. No se pudo conectar a la base de datos.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al eliminar la sucursal.", "Admin CSY", ex);
                    }
                }
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarSucursales();
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando sucursales", this);
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            (new frmAsignarSucursal()).ShowDialog(this);
        }
    }
}
