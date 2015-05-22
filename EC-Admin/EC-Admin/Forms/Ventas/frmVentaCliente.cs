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
    public partial class frmVentaCliente : Form
    {
        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        frmPOS frm = null;
        frmCotizacion frmC = null;

        public frmVentaCliente(frmPOS frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        public frmVentaCliente(frmCotizacion frm)
        {
            InitializeComponent();
            this.frmC = frm;
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
                string sql = "SELECT id, nombre, razon_social, telefono1, telefono2, email, lada1, lada2 FROM cliente WHERE nombre LIKE '%" + p + "%' OR razon_social LIKE '%" + p + "%'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los clientes. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los clientes.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvClientes.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string telefono = "Sin información", correo = "Sin información", razonSocial = "Sin información";
                    if (dr["razon_social"].ToString() != "")
                    {
                        razonSocial = dr["razon_social"].ToString();
                    }
                    if (dr["telefono1"].ToString() != "" && dr["telefono2"].ToString() != "")
                    {
                        telefono = "";
                        if (dr["lada1"].ToString() != "")
                        {
                            telefono += dr["lada1"].ToString() + " " + dr["telefono1"].ToString();
                        }
                        else
                        {
                            telefono += dr["telefono1"].ToString();
                        }
                        if (dr["lada2"].ToString() != "")
                        {
                            telefono += ", " + dr["lada2"].ToString();
                        }
                        else
                        {
                            telefono += ", " + dr["telefono2"].ToString();
                        }
                    }
                    else if (dr["telefono1"].ToString() != "")
                    {
                        telefono = "";
                        if (dr["lada1"].ToString() != "")
                        {
                            telefono += dr["lada1"].ToString() + " " + dr["telefono1"].ToString();
                        }
                        else
                        {
                            telefono += dr["telefono1"].ToString();
                        }
                    }
                    else if (dr["telefono2"].ToString() != "")
                    {
                        telefono = "";
                        if (dr["lada2"].ToString() != "")
                        {
                            telefono += ", " + dr["lada2"].ToString();
                        }
                        else
                        {
                            telefono += ", " + dr["telefono2"].ToString();
                        }
                    }
                    if (dr["email"].ToString() != "")
                    {
                        correo = dr["email"].ToString();
                    }
                    dgvClientes.Rows.Add(new object[] { dr["id"], dr["nombre"], razonSocial, telefono, correo });
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de los clientes.", "Admin CSY", ex);
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tmrEspera.Enabled = true;
                bgwBúsqueda.RunWorkerAsync(txtBusqueda.Text);
            }
        }

        private void dgvClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
                id = (int)dgvClientes[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                if (frm != null)
                {
                    frm.AsignarCliente(id, dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString());
                }
                else if (frmC != null)
                {
                    frmC.AsignarCliente(id, dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString());
                }
                this.Close();
            }
        }

        private void bgwBúsqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Buscar(e.Argument.ToString());
        }

        private void bgwBúsqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando clientes", this);
        }

        private void frmVentaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && txtBusqueda.Focused)
            {
                dgvClientes.Focus();
            }
            else if (e.KeyCode == Keys.Up && dgvClientes.Focused)
            {
                if (dgvClientes.RowCount > 0)
                {
                    if (dgvClientes.CurrentRow.Index == 0)
                    {
                        txtBusqueda.Focus();
                    }
                }
                else
                {
                    txtBusqueda.Focus();
                }
            }
            else if (e.KeyCode == Keys.Enter && dgvClientes.Focused && dgvClientes.CurrentRow != null)
            {
                dgvClientes.Enabled = false;
                btnAceptar.PerformClick();
            }
        }
    }
}
