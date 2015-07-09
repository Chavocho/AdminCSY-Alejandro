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
    public partial class frmCompraProducto : Form
    {
        int id;
        frmNuevaCompra frm;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmCompraProducto(frmNuevaCompra frm)
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
                string sql = "SELECT p.id, p.nombre, p.codigo, p.costo, i.cant, p.unidad FROM producto AS p INNER JOIN inventario AS i ON (p.id=i.id_producto) WHERE p.nombre LIKE '%" + p + "%' OR p.codigo='" + p + "' AND id_sucursal='" + Config.idSucursal + "'";
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
                    Unidades u = (Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString());
                    string unidad = "";
                    switch (u)
                    {
                        case Unidades.Gramo:
                            unidad = "Gramo";
                            break;
                        case Unidades.Kilogramo:
                            unidad = "Kilogramo";
                            break;
                        case Unidades.Mililitro:
                            unidad = "Mililitro";
                            break;
                        case Unidades.Litro:
                            unidad = "Litro";
                            break;
                        case Unidades.Pieza:
                            unidad = "Pieza";
                            break;
                    }
                    dgvProductos.Rows.Add(new object[] { dr["id"], dr["nombre"], dr["codigo"], dr["costo"], dr["cant"], unidad });
                }
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los productos.", "Admin CSY", ex);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && id > 0)
            {
                int i = dgvProductos.CurrentRow.Index;
                decimal desc;
                decimal.TryParse(txtDescuento.Text, out desc);
                Unidades u = (Unidades)Enum.Parse(typeof(Unidades), dgvProductos[5, i].Value.ToString());

                frm.AgregarProducto(id, dgvProductos[2, i].Value.ToString(), dgvProductos[1, i].Value.ToString(), (decimal)dgvProductos[3, i].Value, (int)nudCant.Value, desc, u);
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
            FuncionesGenerales.frmEspera("Espere, cargando los productos", this);
        }
    }
}
