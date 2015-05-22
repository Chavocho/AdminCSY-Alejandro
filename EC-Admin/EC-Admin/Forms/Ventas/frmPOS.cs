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
    public partial class frmPOS : Form
    {
        #region Instancia
        private static frmPOS frmInstancia;
        public static frmPOS Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmPOS();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmPOS();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        delegate void ImagenProducto(Image img);

        int id;
        decimal subtotal = 0M, impuesto = 0M, descuento = 0M, total = 0M, cantTot = 0M;

        Venta v;
        private int idCliente;
        private int idVendedor = -1;

        /// <summary>
        /// Inicializa la instancia de la clase frmPOS
        /// </summary>
        public frmPOS()
        {
            InitializeComponent();
            v = new Venta();
        }

        private void VerificarVisible()
        {
            if (!Instancia.Visible)
                Instancia.Show();
            else
                Instancia.Select();
        }

        #region Venta

        /// <summary>
        /// Inicia una nueva venta, y verifica si el formulario es visible, en caso de no serlo, lo muestra primero
        /// y después inicia la nueva venta
        /// </summary>
        public void NuevaVenta()
        {
            VerificarVisible();
            if (v.Abierta)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La venta no se ha finalizado, ¿desea crear una nueva?\n(Puedes guardar la venta actual para continuarla posteriormente)", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    v.IDVendedor = idVendedor;
                    v.NuevaVenta();
                    ControlesHabilitados();
                    AsignarCliente(0, "Público en general");
                    lblFolio.Text = v.IDVenta.ToString();
                    lblSubtotal.Text = lblImpuesto.Text = lblDescuento.Text = lblTotal.Text = "$0.00";
                    lblCantDif.Text = lblCantTot.Text = "0";
                    dgvProductos.Rows.Clear();
                    CalcularTotales();
                }
            }
            else
            {
                v.IDVendedor = idVendedor;
                v.NuevaVenta();
                ControlesHabilitados();
                AsignarCliente(0, "Público en general");
                lblFolio.Text = v.IDVenta.ToString();
                lblSubtotal.Text = lblImpuesto.Text = lblDescuento.Text = lblTotal.Text = "$0.00";
                lblCantDif.Text = lblCantTot.Text = "0";
                dgvProductos.Rows.Clear();
                CalcularTotales();
            }
        }

        /// <summary>
        /// Recupera una venta que no haya sido completada antes
        /// </summary>
        /// <param name="id">ID de la venta</param>
        public void RecuperarVenta(int id)
        {
            try
            {
                VerificarVisible();
                v.IDVenta = id;
                lblFolio.Text = id.ToString();
                v.RecuperarVenta();
                ControlesHabilitados();
                idCliente = v.IDCliente;
                lblCliente.Text = Cliente.NombreCliente(idCliente);
                idVendedor = v.IDVendedor;
                lblVendedor.Text = Trabajador.NombreTrabajador(idVendedor);
                for (int i = 0; i < v.IDProductos.Count; i++)
                {
                    AgregarProducto(v.IDProductos[i], CodigoProducto(v.IDProductos[i]), Producto.NombreProducto(v.IDProductos[i]), v.Cantidad[i], v.DescuentoProducto[i], v.Unidad[i]);
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

        /// <summary>
        /// Control que cambia la propiedad Enable a false en determinados controles del formulario cuando se termina una venta
        /// </summary>
        private void ControlesInhabilitados()
        {
            lblECliente.Enabled = false;
            lblCliente.Enabled = false;
            lblEFolio.Enabled = false;
            lblFolio.Enabled = false;
            lblEVendedor.Enabled = false;
            lblVendedor.Enabled = false;
            btnClientes.Enabled = false;
            btnProductos.Enabled = false;
            btnCobrar.Enabled = false;
            btnGuardar.Enabled = false;
            btnVendedor.Enabled = false;
            txtBusqueda.Enabled = false;
            grbTotales.Enabled = false;
        }

        /// <summary>
        /// Control que cambia la propiedad Enable a true en determinados controles del formulario cuando se inicia una venta
        /// </summary>
        private void ControlesHabilitados()
        {
            dgvProductos.Enabled = true;
            lblECliente.Visible = true;
            lblCliente.Visible = true;
            lblEFolio.Visible = true;
            lblFolio.Visible = true;
            lblEVendedor.Visible = true;
            lblVendedor.Visible = true;
            btnClientes.Visible = true;
            btnProductos.Visible = true;
            btnCobrar.Visible = true;
            btnGuardar.Visible = true;
            btnVendedor.Visible = true;
            txtBusqueda.Enabled = true;
            grbTotales.Visible = true;

            lblECliente.Enabled = true;
            lblCliente.Enabled = true;
            lblEFolio.Enabled = true;
            lblFolio.Enabled = true;
            lblEVendedor.Enabled = true;
            lblVendedor.Enabled = true;
            btnClientes.Enabled = true;
            btnProductos.Enabled = true;
            btnCobrar.Enabled = true;
            btnGuardar.Enabled = true;
            btnVendedor.Enabled = true;
            txtBusqueda.Enabled = true;
            grbTotales.Enabled = true;
            idCliente = 0;
            lblCliente.Text = "";
        }

        public void GuardarVenta(bool abierta, TipoPago t)
        {
            try
            {
                v.IDCliente = idCliente;
                v.IDVendedor = idVendedor;
                v.IDSucursal = Config.idSucursal;
                v.Cancelada = false;
                v.Abierta = abierta;
                v.Subtotal = subtotal;
                v.Impuesto = impuesto;
                v.Descuento = descuento;
                v.Total = total;
                v.Tipo = t;
                foreach (DataGridViewRow dr in dgvProductos.Rows)
                {
                    v.IDProductos.Add((int)dr.Cells[0].Value);
                    v.Precio.Add((decimal)dr.Cells[3].Value);
                    v.Cantidad.Add((decimal)dr.Cells[4].Value);
                    v.DescuentoProducto.Add((decimal)dr.Cells[5].Value);
                    v.Unidad.Add((Unidades)Enum.Parse(typeof(Unidades), dr.Cells[6].Value.ToString()));
                }
                v.DatosVenta();
                if (abierta == false)
                {
                    ControlesInhabilitados();
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

        public void VentaCotizacion(Cotizacion c)
        {
            try
            {
                VerificarVisible();
                ControlesHabilitados();
                v.NuevaVenta();
                lblFolio.Text = v.IDVenta.ToString();
                v.Abierta = true;
                v.Descuento = c.Descuento;
                v.IDCliente = c.IDCliente;
                lblCliente.Text = Cliente.NombreCliente(c.IDCliente);
                v.IDSucursal = c.IDSucursal;
                v.IDVendedor = c.IDVendedor;
                lblVendedor.Text = Trabajador.NombreTrabajador(c.IDVendedor);
                v.Impuesto = c.Impuesto;
                v.Subtotal = c.Subtotal;
                v.Total = c.Total;
                for (int i = 0; i < c.IDProductos.Count; i++)
                {
                    AgregarProducto(c.IDProductos[i], CodigoProducto(c.IDProductos[i]), Producto.NombreProducto(c.IDProductos[i]), c.Cantidad[i], c.DescuentoProducto[i], c.Unidad[i]);
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al importar la cotización.", "Admin CSY", ex);
            }
        }

        #endregion

        #region Productos

        /// <summary>
        /// Método que agrega un producto a la venta
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <param name="nombre">Nombre del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="cant">Cantidad del producto</param>
        /// <param name="desc">Descuento aplicado al producto</param>
        public void AgregarProducto(int id, string codProd, string nombre, decimal cant, decimal desc, Unidades u)
        {
            if (!VerificarProducto(id, cant))
            {
                decimal precio = PrecioProducto(id, cant);
                dgvProductos.Rows.Add(new object[] { id, codProd, nombre, precio, cant, desc, u });
                if (dgvProductos.RowCount == 1)
                {
                    dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, 0));
                    dgvProductos_CellClick(dgvProductos, new DataGridViewCellEventArgs(0, 0));
                }
            }
        }

        /// <summary>
        /// Método que verifica la existencia del producto en la venta, en caso de estar registrado, suma la cantidad
        /// dada al producto
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <param name="cant">Cantidad a añadir al producto</param>
        private bool VerificarProducto(int id, decimal cant)
        {
            bool existe = false;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                if (dr.Cells[0].Value.ToString() == id.ToString())
                {
                    dr.Cells[4].Value = ((decimal)dr.Cells[4].Value + cant);
                    dr.Cells[3].Value = PrecioProducto(id, (decimal)dr.Cells[4].Value);
                    existe = true;
                    if (cant < 0 && (decimal)dr.Cells[4].Value <= 0)
                        QuitarProducto(dr);
                    CalcularTotales();
                    break;
                }
            }
            return existe;
        }

        private decimal PrecioProducto(int id, decimal cant)
        {
            decimal precio = 0M;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT precio, precio_mediomayoreo, precio_mayoreo, cant_mediomayoreo, cant_mayoreo FROM producto WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    decimal cantMedioMayoreo = (decimal)dr["cant_mediomayoreo"], cantMayoreo = (decimal)dr["cant_mayoreo"],
                        precioP = (decimal)dr["precio"], precioMedioMayoreo = (decimal)dr["precio_mediomayoreo"], precioMayoreo = (decimal)dr["precio_mayoreo"];
                    if (cantMedioMayoreo > 0 && cantMayoreo > 0)
                    {
                        if (cant < cantMedioMayoreo)
                        {
                            precio = precioP;
                        }
                        else if (cant >= cantMedioMayoreo && cant < cantMayoreo)
                        {
                            precio = precioMedioMayoreo;
                        }
                        else if (cant >= cantMayoreo)
                        {
                            precio = precioMayoreo;
                        }
                    }
                    else if (cantMedioMayoreo > 0)
                    {
                        if (cant >= cantMedioMayoreo)
                        {
                            precio = precioMedioMayoreo;
                        }
                        else
                        {
                            precio = precioP;
                        }
                    }
                    else if (cantMayoreo > 0)
                    {
                        if (cant >= cantMayoreo)
                        {
                            precio = precioMayoreo;
                        }
                        else
                        {
                            precio = precioP;
                        }
                    }
                    else
                    {
                        precio = precioP;
                    }
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
            return precio;
        }

        public void ModificarProducto(decimal cant, decimal desc)
        {
            dgvProductos[4, dgvProductos.CurrentRow.Index].Value = cant;
            dgvProductos[5, dgvProductos.CurrentRow.Index].Value = desc;
            CalcularTotales();
        }

        private void QuitarProducto()
        {
            if (dgvProductos.CurrentRow != null)
            {
                int ind = dgvProductos.CurrentRow.Index;
                dgvProductos.Rows.Remove(dgvProductos.CurrentRow);
                CambioImagen(ind);
                CalcularTotales();
            }
        }

        private void QuitarProducto(DataGridViewRow dr)
        {
            int ind = dr.Index;
            dgvProductos.Rows.Remove(dr);
            CambioImagen(ind);
            CalcularTotales();
        }

        private void CambioImagen(int ind)
        {
            if (ind <= dgvProductos.RowCount - 1)
            {
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, ind));
                dgvProductos_CellClick(dgvProductos, new DataGridViewCellEventArgs(0, ind));
            }
            else if (ind > dgvProductos.RowCount - 1)
            {
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, dgvProductos.RowCount - 1));
                dgvProductos_CellClick(dgvProductos, new DataGridViewCellEventArgs(0, dgvProductos.RowCount - 1));
            }
        }

        private void BusquedaProducto(string codProd, decimal cant)
        {
            try
            {
                string sql = "SELECT id, nombre, codigo, precio, unidad FROM producto WHERE codigo='" + codProd + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    AgregarProducto((int)dr["id"], dr["codigo"].ToString(), dr["nombre"].ToString(), cant, 0M, (Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString()));
                    break;
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar el producto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar el producto.", "Admin CSY", ex);
            }
        }

        private string CodigoProducto(int id)
        {
            string cod = "";
            try
            {
                string sql = "SELECT codigo FROM producto WHERE id='" + id + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cod = dr["codigo"].ToString();
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
            return cod;
        }

        private void Imagen(Image img)
        {
            pcbProducto.Image = img;
        }

        #endregion

        #region Métodos DataGrid y demás

        private void CalcularTotales()
        {
            subtotal = 0M;
            impuesto = 0M;
            descuento = 0M;
            total = 0M;
            cantTot = 0M;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                subtotal += ((decimal)dr.Cells[3].Value * (decimal)dr.Cells[4].Value);
                cantTot += (decimal)dr.Cells[4].Value;
                descuento += (decimal)dr.Cells[3].Value * (((decimal)dr.Cells[5].Value) * ((decimal)dr.Cells[4].Value));
            }
            impuesto = subtotal * Config.iva;
            total = subtotal + impuesto - descuento;

            lblSubtotal.Text = subtotal.ToString("C2");
            lblImpuesto.Text = impuesto.ToString("C2");
            lblDescuento.Text = descuento.ToString("C2");
            lblTotal.Text = total.ToString("C2");
            lblCantDif.Text = dgvProductos.RowCount.ToString();
            lblCantTot.Text = cantTot.ToString();
        }

        #endregion

        #region Clientes

        public void AsignarCliente(int id, string nombre)
        {
            this.idCliente = id;
            this.lblCliente.Text = nombre;
            
        }

        #endregion

        #region Vendedor
        
        public void AsignarVendedor(int id, string nombre)
        {
            this.idVendedor = id;
            this.lblVendedor.Text = nombre;
        }

        #endregion

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            NuevaVenta();
            txtBusqueda.Select();
        }

        private void btnRecuperarVenta_Click(object sender, EventArgs e)
        {
            (new frmRecuperarVenta(this)).ShowDialog(this);
            txtBusqueda.Select();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (btnClientes.Visible || btnClientes.Enabled)
                (new frmVentaCliente(this)).ShowDialog(this);
            txtBusqueda.Select();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (btnProductos.Visible || btnProductos.Enabled)
                (new frmVentaProducto(this)).ShowDialog(this);
            txtBusqueda.Select();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (idVendedor <= 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "¡Debes asignar al trabajador que atiende ésta venta!", "Admin CSY");
                return;
            }
            if (btnCobrar.Visible || btnCobrar.Enabled)
                (new frmCobrar(this, v.IDVenta, total)).ShowDialog(this);
            txtBusqueda.Select();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            if (btnVendedor.Visible || btnVendedor.Enabled)
            {
                (new frmVendedor(this, idVendedor, lblVendedor.Text)).ShowDialog(this);
                txtBusqueda.Select();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Visible || btnGuardar.Enabled)
                {
                    GuardarVenta(true, TipoPago.Efectivo);
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha guardado correctamente la venta!", "Admin CSY");
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar la venta. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar la venta.", "Admin CSY", ex);
            }
        }

        private void frmPOS_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvProductos.CurrentRow != null && btnProductos.Visible && btnProductos.Enabled)
            {
                if (e.Control)
                {
                    if (e.KeyCode == Keys.Oemplus)
                    {
                        VerificarProducto(id, 1);
                    }
                    else if (e.KeyCode == Keys.OemMinus)
                    {
                        VerificarProducto(id, -1);
                    }
                    else if (e.KeyCode == Keys.Delete)
                    {
                        QuitarProducto();
                    }
                    return;
                }
            }
            if (e.KeyCode == Keys.F1)
            {
                btnNuevaVenta.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnRecuperarVenta.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnClientes.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnProductos.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnCobrar.PerformClick();
            }
            else if (e.KeyCode == Keys.F11)
            {
                btnVendedor.PerformClick();
            }
            else if (e.KeyCode == Keys.F12)
            {
                btnGuardar.PerformClick();
            }
        }

        private void bgwImagen_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pcbProducto.InvokeRequired)
            {
                try
                {
                    ImagenProducto i = new ImagenProducto(Imagen);
                    this.Invoke(i, Producto.Imagen01Producto(id));
                }
                catch
                {
                }
            }
        }

        private void dgvProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                (new frmDatosVentaProducto(this, dgvProductos[2, dgvProductos.CurrentRow.Index].Value.ToString(), (decimal)dgvProductos[4, dgvProductos.CurrentRow.Index].Value, ((decimal)dgvProductos[5, dgvProductos.CurrentRow.Index].Value) * 100M)).ShowDialog(this);
        }

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                id = (int)dgvProductos[0, e.RowIndex].Value;
                dgvProductos.Rows[e.RowIndex].Selected = true;
            }
            else
                id = 0;
            txtBusqueda.Select();
        }

        /// <summary>
        /// Método al que llama el evento CellClick del dgvProductos y que ejecuta la búsqueda de imagen del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                if (!bgwImagen.IsBusy)
                    bgwImagen.RunWorkerAsync();
            txtBusqueda.Select();
        }

        private void dgvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularTotales();
        }

        private void dgvProductos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotales();
            if (dgvProductos.RowCount == 0)
            {
                pcbProducto.Image = null;
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string[] datos = txtBusqueda.Text.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
                if (datos.Length > 1)
                {
                    BusquedaProducto(datos[1].ToString(), decimal.Parse(datos[0], System.Globalization.NumberStyles.Currency));
                }
                else
                {
                    BusquedaProducto(datos[0].ToString(), 1);
                }
                txtBusqueda.Text = "";
            }
        }
    }
}
