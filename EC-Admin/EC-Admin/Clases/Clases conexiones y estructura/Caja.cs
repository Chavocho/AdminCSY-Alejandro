using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    public class Caja
    {
        #region Propiedades Caja
        private int id;
        private int idSucursal;
        private decimal efectivo;
        private decimal voucher;
        private string descripcion;
        private MovimientoCaja tipoMovimiento;
        private int create_user;
        private DateTime createTime;
        private static bool estadoCaja;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDSucursal
        {
            get { return idSucursal; }
            set { idSucursal = value; }
        }

        public decimal Efectivo
        {
            get { return efectivo; }
            set { efectivo = value; }
        }

        public decimal Voucher
        {
            get { return voucher; }
            set { voucher = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public MovimientoCaja TipoMovimiento
        {
            get { return tipoMovimiento; }
            set { tipoMovimiento = value; }
        }

        public int CreateUser
        {
            get { return create_user; }
        }

        public DateTime CreateTime
        {
            get { return createTime; }
        }

        public static bool EstadoCaja
        {
            get { return estadoCaja; }
        }
        #endregion

        #region Totales Caja
        private static decimal totalEfe = -1;
        private static decimal totalVou = -1;

        /// <summary>
        /// Obtiene el total del efectivo que hay actualmente en caja
        /// </summary>
        public static decimal TotalEfectivo
        {
            get
            {
                if (totalEfe < 0)
                    Totales();
                return totalEfe;
            }
        }

        /// <summary>
        /// Obtiene el total de los vouchers que hay actualmente en caja
        /// </summary>
        public static decimal TotalVouchers
        {
            get
            {
                if (totalVou < 0)
                    Totales();
                return totalVou;
            }
        }
        
        /// <summary>
        /// Método que obtiene los totales de caja
        /// </summary>
        private static void Totales()
        {
            try
            {
                string sql = "SELECT SUM(efectivo) AS e, SUM(voucher) AS v FROM caja WHERE id_sucursal='" + Config.idSucursal.ToString() + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["e"] != DBNull.Value)
                        totalEfe = (decimal)dr["e"];
                    else
                        totalEfe = 0M;

                    if (dr["v"] != DBNull.Value)
                        totalVou = (decimal)dr["v"];
                    else
                        totalVou = 0M;
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

        /// <summary>
        /// Inicializa la instancia de la clase Caja
        /// </summary>
        public Caja()
        {

        }

        /// <summary>
        /// Método que actualiza el estado de la caja
        /// </summary>
        public static void EstadoC()
        {
            try
            {
                string sql = "SELECT estado FROM estado_caja";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["estado"] != DBNull.Value)
                        {
                            estadoCaja = (bool)dr["estado"];
                        }
                    }
                }
                else
                {
                    estadoCaja = false;
                    sql = "INSERT INTO estado_caja (estado) VALUES (FALSE)";
                    ConexionBD.EjecutarConsulta(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que cambia el estado de la caja
        /// </summary>
        /// <param name="estado">True para abierta, False para cerrada</param>
        public static void CambiarEstadoCaja(bool estado)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE estado_caja SET estado=?estado";
                sql.Parameters.AddWithValue("?estado", estado);
                ConexionBD.EjecutarConsulta(sql);
                estadoCaja = estado;
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
        /// Método que inserta un nuevo movimiento en la base de datos con los datos de las propiedades
        /// </summary>
        public void RegistrarMovimiento()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO caja (id_sucursal, efectivo, voucher, descripcion, tipo_movimiento, create_user, create_time) " +
                    "VALUES (?id_sucursal, ?efectivo, ?voucher, ?descripcion, ?tipo_movimiento, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id_sucursal", idSucursal);
                sql.Parameters.AddWithValue("?efectivo", efectivo);
                sql.Parameters.AddWithValue("?voucher", voucher);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
                sql.Parameters.AddWithValue("?tipo_movimiento", tipoMovimiento);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                ConexionBD.EjecutarConsulta(sql);
                Totales();
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
