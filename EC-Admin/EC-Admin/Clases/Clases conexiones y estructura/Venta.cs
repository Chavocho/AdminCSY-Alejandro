using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Venta
    {
        #region Propiedades Venta
        private int id;
        private int idC;
        private int idS;
        private int idV;
        private bool cancelada;
        private bool abierta = false;
        private decimal subtotal;
        private decimal impuesto;
        private decimal descuento;
        private decimal total;
        private bool factura;
        private string folioFactura;
        private TipoPago tipo;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;
        private int cancelUser;
        private DateTime cancelTime;

        public int IDVenta
        {
            get { return id; }
            set { id = value; }
        }

        public int IDCliente
        {
            get { return idC; }
            set { idC = value; }
        }

        public int IDSucursal
        {
            get { return idS; }
            set { idS = value; }
        }

        public int IDVendedor
        {
            get { return idV; }
            set { idV = value; }
        }

        public bool Cancelada
        {
            get { return cancelada; }
            set { cancelada = value; }
        }

        public bool Abierta
        {
            get { return abierta; }
            set { abierta = value; }
        }

        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public decimal Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }

        public decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public bool Factura
        {
            get { return factura; }
            set { factura = value; }
        }

        public string FolioFactura
        {
            get { return folioFactura; }
            set { folioFactura = value; }
        }

        public TipoPago Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int CreateUser
        {
            get { return createUser; }
        }

        public DateTime CreateTime
        {
            get { return createTime; }
        }

        public int UpdateUser
        {
            get { return updateUser; }
        }

        public DateTime UpdateTime
        {
            get { return updateTime; }
        }

        public int CancelUser
        {
            get { return cancelUser; }
        }

        public DateTime CancelTime
        {
            get { return cancelTime; }
        }
        #endregion
         
        #region Propiedades Venta Detallada
        private List<int> idP;
        private List<decimal> cantidad;
        private List<decimal> precio;
        private List<decimal> descuentoP;
        private List<Unidades> unidad;

        public List<int> IDProductos
        {
            get { return idP; }
            set { idP = value; }
        }

        public List<decimal> Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public List<decimal> Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public List<decimal> DescuentoProducto
        {
            get { return descuentoP; }
            set { descuentoP = value; }
        }

        public List<Unidades> Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        #endregion

        /// <summary>
        /// Inicializa la instancia de la clase Venta
        /// </summary>
        public Venta()
        {
            InicializarVentaDetallada();
        }

        /// <summary>
        /// Inicializa la instancia de la clase Venta
        /// </summary>
        /// <param name="idVenta">ID de la venta</param>
        public Venta(int idVenta)
        {
            this.id = idVenta;
            InicializarVenta();
            InicializarVentaDetallada();
        }

        #region Métodos Venta
        /// <summary>
        /// Método que inicializa las propiedades de la clase Venta
        /// </summary>
        private void InicializarVenta()
        {
            idC = 0;
            idV = 0;
            cancelada = false;
            abierta = true;
            subtotal = 0;
            impuesto = 0;
            descuento = 0;
            total = 0;
        }

        /// <summary>
        /// Inserta una nueva venta y asigna el ID de la venta
        /// </summary>
        public void NuevaVenta()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO venta (id_vendedor, tipo_pago, create_user, create_time) VALUES (?id_vendedor, ?tipo_pago, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id_vendedor", idV);
                sql.Parameters.AddWithValue("?tipo_pago", TipoPago.Efectivo);   
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                id = ConexionBD.EjecutarConsulta(sql);
                InicializarVenta();
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
        /// Recupera los datos de la venta
        /// </summary>
        public void RecuperarVenta()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM venta WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idC = (int)dr["id_cliente"];
                    idS = (int)dr["id_sucursal"];
                    idV = (int)dr["id_vendedor"];
                    cancelada = (bool)dr["cancelada"];
                    abierta = (bool)dr["abierta"];
                    subtotal = (decimal)dr["subtotal"];
                    impuesto = (decimal)dr["impuesto"];
                    descuento = (decimal)dr["descuento"];
                    total = (decimal)dr["total"];
                    factura = (bool)dr["factura"];
                    folioFactura = dr["folio_factura"].ToString();
                    tipo = (TipoPago)Enum.Parse(typeof(TipoPago), dr["tipo_pago"].ToString());
                    createUser = (int)dr["create_user"];
                    createTime = (DateTime)dr["create_time"];
                    if (dr["update_user"] != DBNull.Value)
                        updateUser = (int)dr["update_user"];
                    else
                        updateUser = 0;
                    if (dr["update_time"] != DBNull.Value)
                        updateTime = (DateTime)dr["update_time"];
                    else
                        updateTime = new DateTime();
                    if (dr["cancel_user"] != DBNull.Value)
                        cancelUser = (int)dr["cancel_user"];
                    else
                        cancelUser = 0;
                    if (dr["cancel_time"] != DBNull.Value)
                        cancelTime = (DateTime)dr["cancel_time"];
                    else
                        cancelTime = new DateTime();
                    RecuperarVentaDetallada();
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
        /// Inserta todos los datos de una venta
        /// </summary>
        public void DatosVenta()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE venta SET id_cliente=?id_cliente, id_sucursal=?id_sucursal, id_vendedor=?id_vendedor, abierta=?abierta, subtotal=?subtotal, impuesto=?impuesto, " + 
                    "descuento=?descuento, total=?total, factura=?factura, folio_factura=?folio_factura, tipo_pago=?tipo_pago, update_user=?update_user, update_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?id_cliente", idC);
                sql.Parameters.AddWithValue("?id_sucursal", idS);
                sql.Parameters.AddWithValue("?id_vendedor", idV);
                sql.Parameters.AddWithValue("?abierta", abierta);
                sql.Parameters.AddWithValue("?subtotal", subtotal);
                sql.Parameters.AddWithValue("?impuesto", impuesto);
                sql.Parameters.AddWithValue("?descuento", descuento);
                sql.Parameters.AddWithValue("?total", total);
                sql.Parameters.AddWithValue("?factura", factura);
                sql.Parameters.AddWithValue("?folio_factura", folioFactura);
                sql.Parameters.AddWithValue("?tipo_pago", tipo);
                sql.Parameters.AddWithValue("?update_user", Usuario.IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
                InsertarProductos();
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

        private static void CancelarVenta(int id)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE venta SET cancelada=?cancelada, cancel_user=?cancel_user, cancel_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?cancelada", true);
                sql.Parameters.AddWithValue("?cancel_user", Usuario.IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
                CancelarDetallada(id);
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
        #endregion

        #region Métodos Venta Detallada
        /// <summary>
        /// Inicializa las propiedades que esten relacionadas con la venta detallada
        /// </summary>
        private void InicializarVentaDetallada()
        {
            idP = new List<int>();
            cantidad = new List<decimal>();
            precio = new List<decimal>();
            descuentoP = new List<decimal>();
            unidad = new List<Unidades>();
        }

        /// <summary>
        /// Inserta los productos de la venta en la base de datos, y en caso de estar ya, los actualiza
        /// </summary>
        private void InsertarProductos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                for (int i = 0; i < idP.Count; i++)
                {
                    sql.CommandText = "INSERT INTO venta_detallada (id_venta, id_producto, cant, precio, descuento, unidad) " +
                    "VALUES (?id_venta, ?id_producto, ?cant, ?precio, ?descuento, ?unidad) " +
                    "ON DUPLICATE KEY UPDATE cant=?cant, precio=?precio, descuento=?descuento, unidad=?unidad;";
                    sql.Parameters.AddWithValue("?id_venta", id);
                    sql.Parameters.AddWithValue("?id_producto", idP[i]);
                    sql.Parameters.AddWithValue("?cant", cantidad[i]);
                    sql.Parameters.AddWithValue("?precio", precio[i]);
                    sql.Parameters.AddWithValue("?descuento", descuentoP[i]);
                    sql.Parameters.AddWithValue("?unidad", unidad[i]);
                    ConexionBD.EjecutarConsulta(sql);
                    sql.Parameters.Clear();
                    if (this.abierta == false)
                    {
                        Producto.CambiarCantidadInventario(idP[i], decimal.Negate(cantidad[i]));
                    }
                }
                InicializarVentaDetallada();
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
        /// Recupera los datos de los productos de la venta detallada
        /// </summary>
        private void RecuperarVentaDetallada()
        {
            InicializarVentaDetallada();
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM venta_detallada WHERE id_venta=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idP.Add((int)dr["id_producto"]);
                    cantidad.Add((decimal)dr["cant"]);
                    precio.Add((decimal)dr["precio"]);
                    descuentoP.Add((decimal)dr["descuento"]);
                    unidad.Add((Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString()));
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

        private static void CancelarDetallada(int id)
        {
            try
            {
                Venta v = new Venta(id);
                v.RecuperarVenta();
                for (int i = 0; i < v.IDProductos.Count; i++)
                {
                    Producto.CambiarCantidadInventario(v.IDProductos[i], decimal.Negate(v.Cantidad[i]));
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
        #endregion
    }
}
