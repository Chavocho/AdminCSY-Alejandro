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
    public partial class frmProveedor : Form
    {
        #region Instancia
        private static frmProveedor frmInstancia;
        public static frmProveedor Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmProveedor();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmProveedor();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmProveedor()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void BuscarProveedores(string p)
        {
            c = new CerrarFrmEspera(Cerrar);
            try
            {
                string sql = "SELECT id, nombre, razon_social, telefono1, telefono2, email, lada1, lada2 FROM proveedor WHERE nombre LIKE '%" + p + "%' AND eliminado=0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los proveedor.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los proveedor.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            dgvProveedores.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string razonSocial = "", telefonos = "", correo = "";
                if (dr["razon_social"].ToString() != "")
                {
                    razonSocial = dr["razon_social"].ToString();
                }
                else
                {
                    razonSocial = "Sin información";
                }
                if (dr["telefono1"].ToString() != "" && dr["telefono2"].ToString() != "")
                {
                    if (dr["lada1"].ToString() != "")
                    {
                        telefonos += dr["lada1"].ToString() + " " + dr["telefono1"].ToString();
                    }
                    else
                    {
                        telefonos += dr["telefono1"].ToString();
                    }
                    if (dr["lada2"].ToString() != "")
                    {
                        telefonos += ", " + dr["lada2"].ToString() + " " + dr["telefono2"].ToString();
                    }
                    else
                    {
                        telefonos += ", " + dr["telefono2"].ToString();
                    }
                }
                else if (dr["telefono1"].ToString() != "")
                {
                    if (dr["lada1"].ToString() != "")
                    {
                        telefonos += dr["lada1"].ToString() + " " + dr["telefono1"].ToString();
                    }
                    else
                    {
                        telefonos += dr["telefono1"].ToString();
                    }
                }
                else if (dr["telefono2"].ToString() != "")
                {
                    if (dr["lada2"].ToString() != "")
                    {
                        telefonos += dr["lada2"].ToString() + " " + dr["telefono2"].ToString();
                    }
                    else
                    {
                        telefonos += dr["telefono2"].ToString();
                    }
                }
                if (dr["email"].ToString() != "")
                {
                    correo = dr["email"].ToString();
                }
                else
                {
                    correo = "Sin información";
                }

                dgvProveedores.Rows.Add(new object[] { dr["id"], dr["nombre"], razonSocial, telefonos, correo });
            }
            dgvProveedores_RowEnter(dgvProveedores, new DataGridViewCellEventArgs(0, 0));
        }

        private void EliminarProveedor(int id)
        {
            try
            {
                Proveedor.CambiarEstado(id, true);
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
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
            }
        }

        private void dgvProveedores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
                id = (int)dgvProveedores[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmNuevoProveedor()).ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                (new frmEditarProveedor(id)).ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Deseas realmente eliminar a " + dgvProveedores[1, dgvProveedores.CurrentRow.Index].Value.ToString() + "?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        EliminarProveedor(id);
                        dgvProveedores.Rows.Remove(dgvProveedores.CurrentRow);
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha eliminado el proveedor correctamente!", "Admin CSY");
                    }
                    catch (MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al eliminar el proveedor.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al eliminar el proveedor.", "Admin CSY", ex);
                    }
                }
            }
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                (new frmContactosProveedor(id, dgvProveedores[1, dgvProveedores.CurrentRow.Index].Value.ToString())).ShowDialog(this);
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarProveedores(e.Argument.ToString());
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, buscando proveedores", this);
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                try
                {
                    (new frmMapa(Proveedor.DireccionProveedor(id), "Ubicación de " + dgvProveedores[1, dgvProveedores.CurrentRow.Index].Value.ToString())).ShowDialog(this);
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar la ubicación del cliente. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar la ubicación del cliente.", "Admin CSY", ex);
                }
            }
        }

    }
}
