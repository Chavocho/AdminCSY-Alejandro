using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    public class Paquete
    {
        #region Propiedades
        private int id;
        private int idProducto;
        private int cant;
        private decimal precio;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public int CantidadPaquetes
        {
            get { return cant; }
            set { cant = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        #endregion

        #region Cantidades
        public static int Cant(int idProducto)
        {
            int cant = 0;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT COUNT(id) AS c FROM paquete WHERE id_producto=?id_producto";
                sql.Parameters.AddWithValue("?id_producto", idProducto);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cant = int.Parse(dr["c"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cant;
        }
        #endregion

        public Paquete()
        {
            
        }

        public Paquete(int id)
        {
            this.ID = id;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM paquete WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idProducto = (int)dr["id_producto"];
                    cant = (int)dr["cant"];
                    precio = (decimal)dr["precio"];
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
                sql.CommandText = "INSERT INTO paquete (id_producto, cant, precio) VALUES (?id_producto, ?cant, ?precio)";
                sql.Parameters.AddWithValue("?id_producto", idProducto);
                sql.Parameters.AddWithValue("?cant", cant);
                sql.Parameters.AddWithValue("?precio", precio);
                this.id = ConexionBD.EjecutarConsulta(sql);
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
                sql.CommandText = "UPDATE paquete SET cant=?cant, precio=?precio WHERE id=?id";
                sql.Parameters.AddWithValue("?cant", cant);
                sql.Parameters.AddWithValue("?precio", precio);
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

        public static void Eliminar(int id)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "DELETE FROM paquete WHERE id=?id";
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
