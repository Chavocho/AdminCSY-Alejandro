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
    public partial class frmVentasDiarias : Form
    {
        #region Instancia
        private static frmVentasDiarias frmInstancia;
        public static frmVentasDiarias Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmVentasDiarias();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmVentasDiarias();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id;
        DataTable dt = new DataTable();
        DataTable dtd = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        List<int> idTrabajadores = new List<int>();
        List<string> codProductos = new List<string>();
        List<string> nombreProductos = new List<string>();
        List<decimal> cantProductos = new List<decimal>();
        List<decimal> precioProductos = new List<decimal>();
        List<decimal> descuentoProductos = new List<decimal>();
        List<Unidades> unidadesProductos = new List<Unidades>();

        public frmVentasDiarias()
        {
            InitializeComponent();
        }

        private void CerrarVenta()
        {
            tmrEsperaVenta.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void CerrarDetallada()
        {
            tmrEsperaDetallada.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void CargarTrabajadores()
        {
            try
            {
                string sql = "SELECT id, nombre, apellidos FROM trabajador";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idTrabajadores.Add((int)dr["id"]);
                    cboVendedor.Items.Add(dr["nombre"].ToString() + " " + dr["apellidos"].ToString());
                }
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

        private void BuscarVentas(DateTime fechaIni, bool trabajador, int idTrabajador = 0)
        {
            c = new CerrarFrmEspera(CerrarVenta);
            try
            {
                MySqlCommand sql = new MySqlCommand();
                if (trabajador)
                {
                    sql.CommandText = "SELECT * FROM venta WHERE id_vendedor=?id_vendedor AND DATE_FORMAT(create_time, '%Y-%m-%d')=?fecha_ini AND abierta=0";
                    sql.Parameters.AddWithValue("?id_vendedor", idTrabajador);
                }
                else
                {
                    sql.CommandText = "SELECT * FROM venta WHERE DATE_FORMAT(create_time, '%Y-%m-%d')=?fecha_ini AND abierta=0";
                }
                sql.Parameters.AddWithValue("?fecha_ini", fechaIni.ToString("yyyy-MM-dd"));
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas.", "Admin CSY", ex });
            }
        }

        private void BuscarVentaDetallada(int id)
        {
            c = new CerrarFrmEspera(CerrarDetallada);
            try
            {
                codProductos.Clear();
                nombreProductos.Clear();
                cantProductos.Clear();
                precioProductos.Clear();
                descuentoProductos.Clear();
                unidadesProductos.Clear();

                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT v.*, p.nombre, p.codigo FROM venta_detallada AS v INNER JOIN producto AS p ON (v.id_producto=p.id) WHERE v.id_venta=?id_venta AND v.id_sucursal='" + Config.idSucursal + "'";
                sql.Parameters.AddWithValue("?id_venta", id);
                dtd = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dtd.Rows)
                {
                    codProductos.Add(dr["codigo"].ToString());
                    nombreProductos.Add(dr["nombre"].ToString());
                    cantProductos.Add((int)dr["cant"]);
                    precioProductos.Add((decimal)dr["precio"]);
                    descuentoProductos.Add((decimal)dr["descuento"]);
                    unidadesProductos.Add((Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString()));
                }
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas.", "Admin CSY", ex });
            }
        }

        private void LlenarDataTable()
        {
            try
            {
                dgvVentas.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    TipoPago t = (TipoPago)Enum.Parse(typeof(TipoPago), dr["tipo_pago"].ToString());
                    string tipoPago = "", tipoFolio = "", folio = "";
                    switch (t)
                    {
                        case TipoPago.Efectivo:
                            tipoPago = "Efectivo";
                            break;
                        case TipoPago.Cheque:
                            tipoPago = "Cheque";
                            break;
                        case TipoPago.Crédito:
                            tipoPago = "Crédito";
                            break;
                        case TipoPago.Débito:
                            tipoPago = "Débito";
                            break;
                        case TipoPago.Transferencia:
                            tipoPago = "Transferencia";
                            break;
                    }
                    tipoFolio = "Remisión";
                    folio = dr["id"].ToString();
                    dgvVentas.Rows.Add(new object[] { dr["id"], dr["id_vendedor"], dr["id_cliente"], dr["total"], tipoPago, dr["create_time"], tipoFolio, folio});
                }
                dgvVentas_RowEnter(dgvVentas, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de las ventas.", "Admin CSY", ex);
                throw ex;
            }
        }

        private void LlenarProductos()
        {
            try
            {
                pnlProductos.Controls.Clear();

                Graphics g = this.CreateGraphics();
                int y = 10;
                int i = 0;
                int salto = (int)g.MeasureString("A", new Font("Corbel", 13F, FontStyle.Bold)).Height + 5;
                int posCod = 10;
                int posNom = 175;
                int posCant = (pnlProductos.Width / 3) * 2;
                int posPrecio = (pnlProductos.Width / 3) * 2 + 100;
                int posDesc = (pnlProductos.Width / 3) * 2 + 200;
                int posUnidad = (pnlProductos.Width / 3) * 2 + 300;

                Label lblECodProd = new Label();
                Label lblENomProd = new Label();
                Label lblECantProd = new Label();
                Label lblEPrecioProd = new Label();
                Label lblEDescProd = new Label();
                Label lblEUnidadProd = new Label();

                Label lblCodProd;
                Label lblNomProd;
                Label lblCantProd;
                Label lblPrecioProd;
                Label lblDescProd;
                Label lblUnidadProd;

                lblECodProd.Name = "lblECodProd";
                lblENomProd.Name = "lblENomProd";
                lblECantProd.Name = "lblECantProd";
                lblEPrecioProd.Name = "lblEPrecioProd";
                lblEDescProd.Name = "lblEDescProd";
                lblEUnidadProd.Name = "lblEUnidadProd";

                lblECodProd.Text = "Código";
                lblENomProd.Text = "Nombre";
                lblECantProd.Text = "Cantidad";
                lblEPrecioProd.Text = "Precio";
                lblEDescProd.Text = "Descuento";
                lblEUnidadProd.Text = "Unidad";

                lblECodProd.Location = new Point(posCod, y);
                lblENomProd.Location = new Point(posNom, y);
                lblECantProd.Location = new Point(posCant, y);
                lblEPrecioProd.Location = new Point(posPrecio, y);
                lblEDescProd.Location = new Point(posDesc, y);
                lblEUnidadProd.Location = new Point(posUnidad, y);

                lblECodProd.Font = lblENomProd.Font = lblECantProd.Font = lblEPrecioProd.Font = lblEDescProd.Font = lblEUnidadProd.Font = new Font("Corbel", 13F, FontStyle.Bold);

                pnlProductos.Controls.Add(lblECodProd);
                pnlProductos.Controls.Add(lblENomProd);
                pnlProductos.Controls.Add(lblECantProd);
                pnlProductos.Controls.Add(lblEPrecioProd);
                pnlProductos.Controls.Add(lblEDescProd);
                pnlProductos.Controls.Add(lblEUnidadProd);

                y += salto;

                foreach (DataRow dr in dtd.Rows)
                {
                    i += 1;

                    Unidades u = (Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString());

                    lblCodProd = new Label();
                    lblNomProd = new Label();
                    lblCantProd = new Label();
                    lblPrecioProd = new Label();
                    lblDescProd = new Label();
                    lblUnidadProd = new Label();

                    lblCodProd.Name = "lblCodProd" + i.ToString("0000");
                    lblNomProd.Name = "lblNomProd" + i.ToString("0000");
                    lblCantProd.Name = "lblCantProd" + i.ToString("0000");
                    lblPrecioProd.Name = "lblPrecioProd" + i.ToString("0000");
                    lblDescProd.Name = "lblDescProd" + i.ToString("0000");
                    lblUnidadProd.Name = "lblUnidadProd" + i.ToString("0000");

                    lblCodProd.Text = dr["codigo"].ToString();
                    lblNomProd.Text = dr["nombre"].ToString();
                    lblCantProd.Text = dr["cant"].ToString();
                    lblPrecioProd.Text = dr["precio"].ToString();
                    lblDescProd.Text = dr["descuento"].ToString();
                    switch (u)
                    {
                        case Unidades.Gramo:
                            lblUnidadProd.Text = "Gramo";
                            break;
                        case Unidades.Kilogramo:
                            lblUnidadProd.Text = "Kilogramo";
                            break;
                        case Unidades.Mililitro:
                            lblUnidadProd.Text = "Mililitro";
                            break;
                        case Unidades.Litro:
                            lblUnidadProd.Text = "Litro";
                            break;
                        case Unidades.Pieza:
                            lblUnidadProd.Text = "Pieza";
                            break;
                    }

                    lblCodProd.Font = lblNomProd.Font = lblCantProd.Font = lblPrecioProd.Font = lblDescProd.Font = lblUnidadProd.Font = new Font("Corbel", 13F, FontStyle.Regular);

                    lblCodProd.Location = new Point(posCod, y);
                    lblNomProd.Location = new Point(posNom, y);
                    lblCantProd.Location = new Point(posCant, y);
                    lblPrecioProd.Location = new Point(posPrecio, y);
                    lblDescProd.Location = new Point(posDesc, y);
                    lblUnidadProd.Location = new Point(posUnidad, y);

                    pnlProductos.Controls.Add(lblCodProd);
                    pnlProductos.Controls.Add(lblNomProd);
                    pnlProductos.Controls.Add(lblCantProd);
                    pnlProductos.Controls.Add(lblPrecioProd);
                    pnlProductos.Controls.Add(lblDescProd);
                    pnlProductos.Controls.Add(lblUnidadProd);

                    y += salto;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CalcularTotales()
        {
            try
            {
                decimal tot = 0M, efe = 0M, vou = 0M;
                foreach (DataGridViewRow dr in dgvVentas.Rows)
                {
                    tot += (decimal)dr.Cells[3].Value;
                    if (dr.Cells[4].Value.ToString() == "Efectivo")
                    {
                        efe += (decimal)dr.Cells[3].Value;
                    }
                    else if (dr.Cells[4].Value.ToString() == "Crédito" || dr.Cells[4].Value.ToString() == "Débito")
                    {
                        vou += (decimal)dr.Cells[3].Value;
                    }
                }
                lblTotal.Text = tot.ToString("C2");
                lblVentas.Text = dgvVentas.RowCount.ToString();
                lblEfectivo.Text = efe.ToString("C2");
                lblVouchers.Text = vou.ToString("C2");
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al calcular los totales.", "Admin CSY", ex);
            }
        }

        private void dgvVentas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvVentas.CurrentRow != null)
                {
                    id = (int)dgvVentas[0, e.RowIndex].Value;
                    lblVendedor.Text = Trabajador.NombreTrabajador((int)dgvVentas[1, e.RowIndex].Value);
                    lblCliente.Text = Cliente.NombreCliente((int)dgvVentas[2, e.RowIndex].Value);
                    if (!bgwBusquedaDetallada.IsBusy)
                    {
                        tmrEsperaDetallada.Enabled = true;
                        bgwBusquedaDetallada.RunWorkerAsync(id);
                    }
                }
                else
                {
                    id = 0;
                    lblVendedor.Text = "";
                    lblCliente.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!bgwBusquedaVentas.IsBusy)
            {
                tmrEsperaVenta.Enabled = true;
                bgwBusquedaVentas.RunWorkerAsync(new object[] { dtpFechaInicio.Value, chbTrabajador.Checked, idTrabajadores[cboVendedor.SelectedIndex] });
            }
        }

        private void bgwBusquedaVentas_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] a = (object[])e.Argument;
            BuscarVentas((DateTime)a[0], (bool)a[1], (int)a[2]);
        }

        private void bgwBusquedaVentas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CerrarVenta();
            LlenarDataTable();
            CalcularTotales();
        }

        private void tmrEsperaVenta_Tick(object sender, EventArgs e)
        {
            tmrEsperaVenta.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando ventas", this);
        }

        private void bgwBusquedaDetallada_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarVentaDetallada((int)e.Argument);
        }

        private void bgwBusquedaDetallada_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CerrarDetallada();
            LlenarProductos();
        }

        private void tmrEsperaDetallada_Tick(object sender, EventArgs e)
        {
            tmrEsperaDetallada.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando los productos de la venta", this);
        }

        private void frmVentasDiarias_Load(object sender, EventArgs e)
        {
            try
            {
                CargarTrabajadores();
                cboVendedor.SelectedIndex = 0;
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargas los trabajadores. No se ha podido conectar a la base de datos. La búsqueda por trabajador estará desactivada.", "Admin CSY", ex);
                chbTrabajador.Enabled = false;
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargas los trabajadores. La búsqueda por trabajador estará desactivada.", "Admin CSY", ex);
                chbTrabajador.Enabled = false;
            }
        }
    }
}
