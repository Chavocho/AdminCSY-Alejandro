using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace EC_Admin
{
    class ConexionBD
    {
        static MySqlConnection conexion;

        /// <summary>
        /// Función que pasa los parametros de conexión MySQL y la abre.
        /// </summary>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        /// <returns>Clase MySqlConnection con la información de la conexión</returns>
        public static void AbrirConexion()
        {
            conexion = new MySqlConnection();
            try
            {
                conexion.ConnectionString = @"Server=" + Config.servidor + ";Port=3306;Database=" + Config.baseDatos + ";Uid=" + Config.usuario + ";Pwd=" + Config.pass;
                conexion.Open();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //return conexion;
        }

        /// <summary>
        /// Función que cierra la conexión con la base de datos.
        /// </summary>
        /// <param name="conexion">Objeto usado para establecer la conexión.</param>
        public static void CerrarConexion()
        {
            if (conexion != null)
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
        }

        /// <summary>
        /// Método que verifica la conexión a la base de datos
        /// </summary>
        /// <returns></returns>
        public static bool Ping()
        {
            bool ping;
            AbrirConexion();
            ping = conexion.Ping();
            CerrarConexion();
            return ping;
        }

        /// <summary>
        /// Función que ejecuta una consulta a base de un string
        /// </summary>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        /// <param name="consulta">Consulta SQLite que puede ser INSERT, UPDATE, DELETE</param>
        /// <returns>En caso de ser consulta INSERT, regresa el último ID ingresado</returns>
        public static int EjecutarConsulta(string consulta)
        {
            int id = 0;
            try
            {
                using (conexion)
                {
                    AbrirConexion();
                    MySqlCommand sql = new MySqlCommand();
                    sql.Connection = conexion;
                    sql.CommandText = consulta;
                    sql.CommandType = CommandType.Text;
                    sql.ExecuteNonQuery();
                    id = (int)sql.LastInsertedId;
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
            finally
            {
                CerrarConexion();
            }
            return id;
        }

        /// <summary>
        /// Función que ejecuta una consulta a base de un comando
        /// </summary>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        /// <param name="comando">Comando SQLite que se va a ejecutar</param>
        /// <returns>En caso de ser consulta INSERT, regresa el último ID ingresado</returns>
        public static int EjecutarConsulta(MySqlCommand comando)
        {
            int id = 0;
            try
            {
                using (conexion)
                {
                    AbrirConexion();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                    id = (int)comando.LastInsertedId;
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
            finally
            {
                CerrarConexion();
            }
            return id;
        }

        /// <summary>
        /// Función que ejecuta una consulta SELECT
        /// </summary>
        /// <param name="consulta">Cadena que contiene la consulta</param>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        /// <returns>DataTable con el resultado de la consulta</returns>
        public static DataTable EjecutarConsultaSelect(string consulta)
        {
            DataTable dt = new DataTable();
            try
            {
                AbrirConexion();
                using (conexion)
                {
                    MySqlCommand sql = new MySqlCommand();
                    sql.Connection = conexion;
                    sql.CommandText = consulta;
                    sql.CommandType = CommandType.Text;
                    using (MySqlDataReader res = sql.ExecuteReader())
                    {
                        dt.Load(res);
                        res.Close();
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
            finally
            {
                CerrarConexion();
            }
            return dt;
        }

        /// <summary>
        /// Función que ejecuta una consulta SELECT
        /// </summary>
        /// <param name="comando">Comando que contiene la consulta</param>
        /// <exception cref="MySql.Data.MySqlClient.MySqlException">Excepción que se lanza cuando ocurre un error con la conexión a la base de datos o con la ejecución de la consulta</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        /// <returns>DataTable que contiene el resultado de la consulta</returns>
        public static DataTable EjecutarConsultaSelect(MySqlCommand comando)
        {
            DataTable dt = new DataTable();
            try
            {
                using (conexion)
                {
                    AbrirConexion();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    using (MySqlDataReader res = comando.ExecuteReader())
                    {
                        dt.Load(res);
                        res.Close();
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
            finally
            {
                CerrarConexion();
            }
            return dt;
        }
    }
}
