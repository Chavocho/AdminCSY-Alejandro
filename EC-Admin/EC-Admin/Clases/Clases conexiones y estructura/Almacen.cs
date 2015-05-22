using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Almacen
    {
        #region Propiedades
        private int id;
        private int idTrabajador;
        private int numAlm;
        private string descripcion;
        private int idSucursal;
        private static int cant = -1;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDTrabajador
        {
            get { return idTrabajador; }
            set { idTrabajador = value; }
        }

        public int NumeroAlmacen
        {
            get { return numAlm; }
            set { numAlm = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int IDSucursal
        {
            get { return idSucursal; }
            set { idSucursal = value; }
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
                string sql = "SELECT COUNT(id) AS c FROM almacen";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cant = int.Parse(dr["c"].ToString());
                    else
                        cant = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public Almacen()
        {

        }

        public Almacen(int id)
        {
            this.ID = id;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM almacen WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idTrabajador = (int)dr["id_trabajador"];
                    numAlm = (int)dr["num_alm"];
                    descripcion = dr["descripcion"].ToString();
                    idSucursal = (int)dr["sucursal_id"];
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
                sql.CommandText = "INSERT INTO almacen (id_trabajador, num_alm, descripcion, sucursal_id) VALUES (?id_trabajador, ?num_alm, ?descripcion, ?id_sucursal)";
                sql.Parameters.AddWithValue("?id_trabajador", idTrabajador);
                sql.Parameters.AddWithValue("?num_alm", numAlm);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
                sql.Parameters.AddWithValue("?id_sucursal", Config.idSucursal);
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
                sql.CommandText = "UPDATE almacen SET id_trabajador=?id_trabajador, num_alm=?num_alm, descripcion=?descripcion, sucursal_id=?id_sucursal WHERE id=?id";
                sql.Parameters.AddWithValue("?id_trabajador", idTrabajador);
                sql.Parameters.AddWithValue("?num_alm", numAlm);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
                sql.Parameters.AddWithValue("?id_sucursal", Config.idSucursal);
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
