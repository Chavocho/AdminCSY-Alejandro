using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Puesto
    {
        #region Propiedades
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string departamento;

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        private int createUser;

        public int CreateUser
        {
            get { return createUser; }
            set { createUser = value; }
        }
        private DateTime createTime;

        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        private int updateUser;

        public int UpdateUser
        {
            get { return updateUser; }
            set { updateUser = value; }
        }
        private DateTime updateTime;

        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }

        private static int cant = -1;

        public static int Cantidad
        {
            get
            {
                try
                {
                    if (cant < 0)
                        Cant();
                    return cant;
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
        #endregion

        #region Cantidades

        /// <summary>
        /// Método que obtiene la cantidad de puestos en la base de datos
        /// </summary>
        private static void Cant()
        {
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM puesto;";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cant = int.Parse(dr["c"].ToString());
                    else
                        cant = 0;
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
        /// Inicializa la instancia de la clase Puesto
        /// </summary>
        public Puesto()
        {

        }

        /// <summary>
        /// Inicializa la instancia de la clase Puesto
        /// </summary>
        /// <param name="id">ID del puesto</param>
        public Puesto(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Método para obtener los datos de un puesto según su ID
        /// </summary>
        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM puesto WHERE id=?id;";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    nombre = dr["nombre"].ToString();
                    departamento = dr["departamento"].ToString();
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
        /// Método que inserta un puesto con los datos de las propiedades
        /// </summary>
        public void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO puesto (nombre, departamento, create_user, create_time) " +
                    "VALUES (?nombre, ?departamento, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?departamento", departamento);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                ConexionBD.EjecutarConsulta(sql);
                Cant();
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
        /// Método que edita un puesto de con los datos de las propiedades
        /// </summary>
        public void Editar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE puesto SET nombre=?nombre, departamento=?departamento, " + 
                    "update_user=?update_user, update_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?departamento", departamento);
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
