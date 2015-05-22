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
    public partial class frmCompraProveedor : Form
    {
        int id;
        frmNuevaCompra frm;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmCompraProveedor(frmNuevaCompra frm)
        {
            InitializeComponent();
            this.frm = frm;
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
                string sql = "SELECT id, nombre, razon_social, telefono1, telefono2, email, lada1, lada2 FROM proveedor WHERE nombre LIKE '%" + p + "%' OR razon_social LIKE '%" + p + "%'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar a los proveedores.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar a los proveedores.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvProveedores.Rows.Clear();
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
                    dgvProveedores.Rows.Add(new object[] { dr["id"], dr["nombre"], razonSocial, telefono, correo });
                }
                dgvProveedores_RowEnter(dgvProveedores, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los proveedores.", "Admin CSY", ex);
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
                tmrEspera.Enabled = true;
            }
        }

        private void frmCompraProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && txtBusqueda.Focused)
            {
                dgvProveedores.Focus();
            }
            else if (e.KeyCode == Keys.Up && dgvProveedores.Focused)
            {
                if (dgvProveedores.RowCount > 0)
                {
                    if (dgvProveedores.CurrentRow.Index == 0)
                    {
                        txtBusqueda.Focus();
                    }
                }
                else
                {
                    txtBusqueda.Focus();
                }
            }
            else if (e.KeyCode == Keys.Enter && dgvProveedores.Focused && dgvProveedores.CurrentRow != null)
            {
                dgvProveedores.Enabled = false;
                btnAceptar.PerformClick();
            }
        }

        private void dgvProveedores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
                id = (int)dgvProveedores[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                frm.AsignarProveedor(id, dgvProveedores[1, dgvProveedores.CurrentRow.Index].Value.ToString());
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
            FuncionesGenerales.frmEspera("Espere, cargando proveedores", this);
        }
    }
}
