using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Devoluciones
    {
        #region Propiedades
        private int id;
        private int idVenta;
        private decimal total;
        private decimal saldo;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;
        private Venta v;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
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

        private List<int> idProductos;
        private List<decimal> precioProductos;
        private List<int> cantidadProductos;

        public List<int> IDProductos
        {
            get { return idProductos; }
            set { idProductos = value; }
        }

        public List<decimal> PrecioProductos
        {
            get { return precioProductos; }
            set { precioProductos = value; }
        }

        public List<int> CantidadProductos
        {
            get { return cantidadProductos; }
            set { cantidadProductos = value; }
        }
        #endregion

        /// <summary>
        /// Inicializa las propiedades de la devolución detallada
        /// </summary>
        private void InicializarDetallada()
        {
            idProductos = new List<int>();
            precioProductos = new List<decimal>();
            cantidadProductos = new List<int>();
        }

        /// <summary>
        /// Inicializa la instancia de la clase Devoluciones
        /// </summary>
        /// <param name="v">Objeto de la clase Venta con los datos precargados de la venta</param>
        public Devoluciones(Venta v)
        {
            this.v = v;
            InicializarDetallada();
        }

        /// <summary>
        /// Inicializa la instancia de la clase Devoluciones
        /// </summary>
        /// <param name="id">ID de la devolución</param>
        /// <param name="v">Objeto de la clase Venta con los datos precargados de la venta</param>
        public Devoluciones(int id, Venta v)
        {
            this.id = id;
            this.v = v;
            InicializarDetallada();
        }

        /// <summary>
        /// Obtiene los datos de la devolución de la base de datos
        /// </summary>
        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM devolucion WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idVenta = (int)dr["id_venta"];
                    total = (decimal)dr["total"];
                    saldo = (decimal)dr["saldo"];
                    createUser = (int)dr["create_user"];
                    createTime = (DateTime)dr["create_time"];
                    if (dr["update_user"] != DBNull.Value)
                        updateUser = (int)dr["update_user"];
                    else
                        updateUser = 0;
                    if (dr["update_time"] != DBNull.Value)
                        updateTime = (DateTime)dr["update_user"];
                    else
                        updateTime = new DateTime();
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
        /// Obtiene los datos de la devolución detallada
        /// </summary>
        private void ObtenerDatosDetallada()
        {
            InicializarDetallada();
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM devolucion_detallada WHERE id_devolucion=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idProductos.Add((int)dr["id_producto"]);
                    precioProductos.Add((decimal)dr["precio"]);
                    cantidadProductos.Add((int)dr["cant"]);
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
        /// Inserta los datos de las propiedades en la base de datos
        /// </summary>
        public void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO devolucion (id_venta, total, saldo, create_user, create_time) " + 
                    "VALUES (?id_venta, ?total, ?saldo, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id_venta", idVenta);
                sql.Parameters.AddWithValue("?total", total);
                sql.Parameters.AddWithValue("?saldo", saldo);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                this.id = ConexionBD.EjecutarConsulta(sql);
                InsertarDetallado();
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
        /// Inserta los datos de las propiedades de la compra detallada en la base de datos
        /// </summary>
        private void InsertarDetallado()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(), sqlVenta = new MySqlCommand();
                sql.CommandText = "INSERT INTO devolucion_detallada (id_devolucion, id_producto, precio, cant) " + 
                    "VALUES (?id_devolucion, ?id_producto, ?precio, ?cant)";
                for (int i = 0; i < idProductos.Count; i++)
                {
                    sql.Parameters.AddWithValue("?id_devolucion", id);
                    sql.Parameters.AddWithValue("?id_producto", idProductos[i]);
                    sql.Parameters.AddWithValue("?precio", precioProductos[i]);
                    sql.Parameters.AddWithValue("?cant", cantidadProductos[i]);
                    ConexionBD.EjecutarConsulta(sql);
                    sql.Parameters.Clear();
                    Inventario.CambiarCantidadInventario(idProductos[i], cantidadProductos[i], Config.idSucursal);
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
        /// Obtiene el saldo restante de la devolución
        /// </summary>
        /// <param name="id">ID de la devolución</param>
        /// <returns>Saldo restante</returns>
        public static decimal SaldoDevolucion(int id)
        {
            decimal saldo = 0M;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT saldo FROM devolucion WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    saldo = (decimal)dr["saldo"];
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
            return saldo;
        }

        /// <summary>
        /// Resta el saldo de la devolución según el ID
        /// </summary>
        /// <param name="id">ID de la devolución</param>
        /// <param name="saldo">Cantidad a restar</param>
        public static void CambiarSaldo(int id, decimal saldo)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE devolucion SET saldo=saldo-?saldo, update_user=?update_user, update_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?saldo", saldo);
                sql.Parameters.AddWithValue("?update_user", Usuario.IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
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
    }
}
