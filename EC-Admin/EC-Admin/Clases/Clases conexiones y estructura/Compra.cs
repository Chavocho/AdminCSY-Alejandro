using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Compra
    {
        #region Propiedades Compra
        private int id;
        private int idP;
        private int idS;
        private int idC;
        private bool cancelada = false;
        private decimal subtotal;
        private decimal impuesto;
        private decimal descuento;
        private decimal total;
        private bool remision;
        private string folioRemision;
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

        public int IDProveedor
        {
            get { return idP; }
            set { idP = value; }
        }

        public int IDSucursal
        {
            get { return idS; }
            set { idS = value; }
        }

        public int IDComprador
        {
            get { return idC; }
            set { idC = value; }
        }

        public bool Cancelada
        {
            get { return cancelada; }
            set { cancelada = value; }
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

        public bool Remision
        {
            get { return remision; }
            set { remision = value; }
        }

        public string FolioRemision
        {
            get { return folioRemision; }
            set { folioRemision = value; }
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

        #region Propiedades Compra Detallada
        private List<int> idPs;
        private List<int> cantidad;
        private List<decimal> precio;
        private List<decimal> descuentoP;
        private List<Unidades> unidad;

        public List<int> IDProductos
        {
            get { return idPs; }
            set { idPs = value; }
        }

        public List<int> Cantidad
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
        /// Inicializa la instancia de la clase Compra
        /// </summary>
        public Compra()
        {
            InicializarCompraDetallada();
        }

        /// <summary>
        /// Inicializa la instancia de la clase Compra con el ID asociado
        /// </summary>
        /// <param name="id">ID de la Compra</param>
        public Compra(int id)
        {
            InicializarCompraDetallada();
            this.id = id;
        }

        #region Compra
        /// <summary>
        /// Método que obtiene los datos de una compra y los guarda en sus propiedades
        /// </summary>
        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM compra WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idP = (int)dr["id_proveedor"];
                    idS = (int)dr["id_sucursal"];
                    idC = (int)dr["id_comprador"];
                    cancelada = (bool)dr["cancelada"];
                    subtotal = (decimal)dr["subtotal"];
                    impuesto = (decimal)dr["impuesto"];
                    descuento = (decimal)dr["descuento"];
                    total = (decimal)dr["total"];
                    tipo = (TipoPago)Enum.Parse(typeof(TipoPago), dr["tipo_pago"].ToString());
                    remision = (bool)dr["remision"];
                    factura = (bool)dr["factura"];
                    folioRemision = dr["folio_remision"].ToString();
                    folioFactura = dr["folio_factura"].ToString();
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
                }
                ObtenerDatosDetallada();
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
        /// Método que inserta los datos de las propiedades en la base de datos
        /// </summary>
        public void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO compra (id_proveedor, id_sucursal, id_comprador, subtotal, impuesto, descuento, total, tipo_pago, remision, factura, folio_remision, folio_factura, create_user, create_time) " +
                    "VALUES (?id_proveedor, ?id_sucursal, ?id_comprador, ?subtotal, ?impuesto, ?descuento, ?total, ?tipo_pago, ?remision, ?factura, ?folio_remision, ?folio_factura, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id_proveedor", IDProveedor);
                sql.Parameters.AddWithValue("?id_sucursal", Config.idSucursal);
                sql.Parameters.AddWithValue("?id_comprador", IDComprador);
                sql.Parameters.AddWithValue("?subtotal", Subtotal);
                sql.Parameters.AddWithValue("?impuesto", Impuesto);
                sql.Parameters.AddWithValue("?descuento", Descuento);
                sql.Parameters.AddWithValue("?total", Total);
                sql.Parameters.AddWithValue("?tipo_pago", Tipo);
                sql.Parameters.AddWithValue("?remision", Remision);
                sql.Parameters.AddWithValue("?factura", Factura);
                sql.Parameters.AddWithValue("?folio_remision", FolioRemision);
                sql.Parameters.AddWithValue("?folio_factura", FolioFactura);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                this.id = ConexionBD.EjecutarConsulta(sql);
                RegistrarMovimientoIngreso();
                InsertarDetallada();
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
        /// Método que registra el movimiento de la compra en Caja
        /// </summary>
        private void RegistrarMovimientoIngreso()
        {
            try
            {
                Caja c = new Caja();
                c.Descripcion = "COMPRA DE PRODUCTOS CON FOLIO: " + this.id.ToString();
                c.Efectivo = decimal.Negate(this.total);
                c.IDSucursal = this.idS;
                c.TipoMovimiento = MovimientoCaja.Salida;
                c.Voucher = 0M;
                c.RegistrarMovimiento();
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
        /// Método que registra el movimiento de cancelación en caja
        /// </summary>
        /// <param name="id">ID de la compra</param>
        /// <param name="idSucursal">ID de la sucursal</param>
        /// <param name="total">Total de la compra</param>
        private static void RegistrarMovimientoCancelacion(int id, int idSucursal, decimal total)
        {
            try
            {
                Caja c = new Caja();
                c.Descripcion = "CANCELACIÓN DE COMPRA DE PRODUCTOS CON FOLIO: " + id.ToString();
                c.Efectivo = total;
                c.IDSucursal = idSucursal;
                c.TipoMovimiento = MovimientoCaja.Salida;
                c.Voucher = 0M;
                c.RegistrarMovimiento();
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
        /// Método que cancela una compra y resta los productos de inventario
        /// </summary>
        /// <param name="id"></param>
        public static void CancelarCompra(int id)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE compra SET cancelada=?cancelada, cancel_user=?cancel_user, cancel_time=NOW() WHERE id=?id";
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

        #region Compra detallada
        /// <summary>
        /// Método que inicializa las propiedades de la compra detallada
        /// </summary>
        private void InicializarCompraDetallada()
        {
            idPs = new List<int>();
            cantidad = new List<int>();
            unidad = new List<Unidades>();
            precio = new List<decimal>();
            descuentoP = new List<decimal>();
        }

        /// <summary>
        /// Método que obtiene los datos de la compra detallada
        /// </summary>
        private void ObtenerDatosDetallada()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM compra_detallada WHERE id_compra=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idPs.Add((int)dr["id_producto"]);
                    cantidad.Add((int)dr["cant"]);
                    unidad.Add((Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString()));
                    precio.Add((decimal)dr["precio"]);
                    descuentoP.Add((decimal)dr["descuento"]);
                }
            }
            catch (MySqlException ex)
            {
                InicializarCompraDetallada();
                throw ex;
            }
            catch (Exception ex)
            {
                InicializarCompraDetallada();
                throw ex;
            }
        }

        /// <summary>
        /// Método que unserta los datos de la compra detallada en la base de datos
        /// </summary>
        private void InsertarDetallada()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                for (int i = 0; i < idPs.Count; i++)
                {
                    sql.CommandText = "INSERT INTO compra_detallada (id_compra, id_producto, cant, unidad, precio, descuento) " +
                        "VALUES (?id_compra, ?id_producto, ?cant, ?unidad, ?precio, ?descuento)";
                    sql.Parameters.AddWithValue("?id_compra", id);
                    sql.Parameters.AddWithValue("?id_producto", idPs[i]);
                    sql.Parameters.AddWithValue("?cant", cantidad[i]);
                    sql.Parameters.AddWithValue("?unidad", unidad[i]);
                    sql.Parameters.AddWithValue("?precio", precio[i]);
                    sql.Parameters.AddWithValue("?descuento", descuentoP[i]);
                    ConexionBD.EjecutarConsulta(sql);
                    sql.Parameters.Clear();
                    Inventario.CambiarCantidadInventario(idPs[i], cantidad[i], Config.idSucursal);
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
                Compra c = new Compra(id);
                c.ObtenerDatos();
                for (int i = 0; i < c.IDProductos.Count; i++)
                {
                    Inventario.CambiarCantidadInventario(c.IDProductos[i], c.Cantidad[i] * -1, Config.idSucursal);
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
