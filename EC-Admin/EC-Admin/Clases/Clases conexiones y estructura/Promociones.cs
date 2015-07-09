using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Promociones
    {
        #region Propiedades
        private int id;
        private int idProducto;
        private bool existencias;
        private DateTime fechaIni;
        private DateTime fechaFin;
        private int cantidad;
        private int cantidadProducto;
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

        public bool Existencias
        {
            get { return existencias; }
            set { existencias = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaIni; }
            set { fechaIni = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public int CantidadProducto
        {
            get { return cantidadProducto; }
            set { cantidadProducto = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        #endregion

        #region Cantidades
        public static int CantidadPromociones(int idProducto)
        {
            int cant = 0;
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM promocion WHERE id_producto='" + idProducto + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cant = int.Parse(dr["c"].ToString());
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
            return cant;
        }
        #endregion

        public Promociones()
        {

        }

        public Promociones(int id)
        {
            this.id = id;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM promocion WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idProducto = (int)dr["id_producto"];
                    existencias = (bool)dr["existencias"];
                    if (dr["fecha_ini"] != DBNull.Value)
                        fechaIni = (DateTime)dr["fecha_ini"];
                    else
                        fechaIni = new DateTime();
                    if (dr["fecha_fin"] != DBNull.Value)
                        fechaFin = (DateTime)dr["fecha_fin"];
                    else
                        fechaFin = new DateTime();
                    cantidad = (int)dr["cant"];
                    cantidadProducto = (int)dr["cant_prod"];
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
                sql.CommandText = "INSERT INTO promocion (id_producto, existencias, fecha_ini, fecha_fin, cant, cant_prod, precio) " +
                    "VALUES (?id_producto, ?existencias, ?fecha_ini, ?fecha_fin, ?cant, ?cant_prod, ?precio)";
                sql.Parameters.AddWithValue("?id_producto", idProducto);
                sql.Parameters.AddWithValue("?existencias", existencias);
                if (fechaIni != new DateTime())
                    sql.Parameters.AddWithValue("?fecha_ini", fechaIni);
                else
                    sql.Parameters.AddWithValue("?fecha_ini", DBNull.Value);
                if (fechaFin != new DateTime())
                    sql.Parameters.AddWithValue("?fecha_fin", fechaFin);
                else
                    sql.Parameters.AddWithValue("?fecha_fin", DBNull.Value);
                sql.Parameters.AddWithValue("?cant", cantidad);
                sql.Parameters.AddWithValue("?cant_prod", cantidadProducto);
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
                sql.CommandText = "UPDATE promocion SET id_producto=?id_producto, existencias=?existencias, fecha_ini=?fecha_ini, " + 
                    "fecha_fin=?fecha_fin, cant=?cant, cant_prod=?cant_prod, precio=?precio WHERE id=?id";
                sql.Parameters.AddWithValue("?id_producto", idProducto);
                sql.Parameters.AddWithValue("?existencias", existencias);
                if (fechaIni != new DateTime())
                    sql.Parameters.AddWithValue("?fecha_ini", fechaIni);
                else
                    sql.Parameters.AddWithValue("?fecha_ini", DBNull.Value);
                if (fechaFin != new DateTime())
                    sql.Parameters.AddWithValue("?fecha_fin", fechaFin);
                else
                    sql.Parameters.AddWithValue("?fecha_fin", DBNull.Value);
                sql.Parameters.AddWithValue("?cant", cantidad);
                sql.Parameters.AddWithValue("?cant_prod", cantidadProducto);
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
                sql.CommandText = "DELETE FROM promocion WHERE id=?id";
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

        public static void CambiarExistencias(int idPromo, int cant)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE promocion SET cant_prod=cant_prod+'" + cant + "' WHERE id=?id";
                sql.Parameters.AddWithValue("?id", idPromo);
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
