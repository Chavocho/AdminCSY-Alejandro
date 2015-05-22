using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Categoria
    {
        #region Propiedades
        private int id;
        private string nombre;
        private string descripcion;
        private static int cant = -1;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public static int Cantidad
        {
            get
            {
                if (cant < 0)
                    Cant();
                return cant;
            }
        }
        #endregion

        #region Cantidad
        private static void Cant()
        {
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM categoria;";
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

        public Categoria()
        {

        }

        public Categoria(int id)
        {
            this.ID = id;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM categoria WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    nombre = dr["nombre"].ToString();
                    descripcion = dr["descripcion"].ToString();
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

        public void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO categoria (nombre, descripcion) VALUES (?nombre, ?descripcion)";
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
                this.id = ConexionBD.EjecutarConsulta(sql);
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

        public void Editar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE categoria SET nombre=?nombre, descripcion=?descripcion WHERE id=?id";
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
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
