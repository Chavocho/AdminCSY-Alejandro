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
    public partial class frmClientes : Form
    {
        #region Instancia
        private static frmClientes frmInstancia;
        public static frmClientes Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmClientes();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmClientes();
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

        public frmClientes()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void BuscarClientes(string p)
        {
            c = new CerrarFrmEspera(Cerrar);
            try
            {
                string sql = "SELECT id, nombre, razon_social, telefono1, telefono2, email, lada1, lada2 FROM cliente WHERE nombre LIKE '%" + p + "%' AND eliminado=0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los clientes.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los clientes.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            dgvClientes.Rows.Clear();
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
                if (dr["id"].ToString() != "0")
                {
                    dgvClientes.Rows.Add(new object[] { dr["id"], dr["nombre"], razonSocial, telefonos, correo });
                }
            }
            dgvClientes_RowEnter(dgvClientes, new DataGridViewCellEventArgs(0, 0));
        }

        private void EliminarCliente(int id)
        {
            try
            {
                Cliente.CambiarEstado(id, true);
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

        private void dgvClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
                id = (int)dgvClientes[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmNuevoCliente()).ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null && id > 0)
            {
                (new frmEditarCliente(id)).ShowDialog(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null && id > 0)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Deseas realmente eliminar a " + dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString() + "?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        EliminarCliente(id);
                        dgvClientes.Rows.Remove(dgvClientes.CurrentRow);
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha eliminado el cliente correctamente!", "Admin CSY");
                    }
                    catch (MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al eliminar el cliente.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al eliminar el cliente.", "Admin CSY", ex);
                    }
                }
            }
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                (new frmContactosCliente(id, dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString())).ShowDialog(this);
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarClientes(e.Argument.ToString());
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, buscando clientes", this);
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                try
                {
                    (new frmMapa(Cliente.DireccionCliente(id), "Ubicación de " + dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString())).ShowDialog(this);
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
