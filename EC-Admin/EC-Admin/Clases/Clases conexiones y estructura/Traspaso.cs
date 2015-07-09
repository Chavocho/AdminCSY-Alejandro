using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EC_Admin
{
    class Traspaso
    {
        #region Propiedades
        private int id;
        private int idSucursalSolicito;
        private int idSucursalOrigen;
        private int idSucursalDestino;
        private string descripcion;
        private EstadoTraspaso estado;
        private int createUser;
        private DateTime createTime;
        private int acceptUser;
        private DateTime acceptTime;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDSucursalSolicito
        {
            get { return idSucursalSolicito; }
            set { idSucursalSolicito = value; }
        }

        public int IDSucursalOrigen
        {
            get { return idSucursalOrigen; }
            set { idSucursalOrigen = value; }
        }

        public int IDSucursalDestino
        {
            get { return idSucursalDestino; }
            set { idSucursalDestino = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public EstadoTraspaso Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int CreateUser
        {
            get { return createUser; }
        }

        public DateTime CreateTime
        {
            get { return createTime; }
        }

        public int AcceptUser
        {
            get { return acceptUser; }
        }

        public DateTime AcceptTime
        {
            get { return acceptTime; }
        }

        private List<int> idProductos;
        private List<int> cantProductos;

        public List<int> IDProductos
        {
            get { return idProductos; }
            set { idProductos = value; }
        }

        public List<int> CantProductos
        {
            get { return cantProductos; }
            set { cantProductos = value; }
        }
        #endregion

        public Traspaso()
        {
            InicializarDetallada();
        }

        public Traspaso(int id)
        {
            this.id = id;
            InicializarDetallada();
        }

        private void InicializarDetallada()
        {
            idProductos = new List<int>();
            cantProductos = new List<int>();
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM traspaso WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idSucursalSolicito = (int)dr["id_sucursal_solicito"];
                    idSucursalOrigen = (int)dr["id_sucursal_origen"];
                    idSucursalDestino = (int)dr["id_sucursal_destino"];
                    descripcion = dr["descripcion"].ToString();
                    estado = (EstadoTraspaso)Enum.Parse(typeof(EstadoTraspaso), dr["estado"].ToString());
                    createUser = (int)dr["create_user"];
                    createTime = (DateTime)dr["create_time"];
                    if (dr["accept_user"] != DBNull.Value)
                        acceptUser = (int)dr["accept_user"];
                    else
                        acceptUser = 0;
                    if (dr["accept_time"] != DBNull.Value)
                        acceptTime = (DateTime)dr["accept_time"];
                    else
                        acceptTime = new DateTime();
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

        private void ObtenerDatosDetallada()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM traspaso_detallado WHERE id_traspaso=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idProductos.Add((int)dr["id_producto"]);
                    cantProductos.Add((int)dr["cant"]);
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
                sql.CommandText = "INSERT INTO traspaso (id_sucursal_solicito, id_sucursal_origen, id_sucursal_destino, descripcion, estado, create_user, create_time) " +
                    "VALUES (?id_sucursal_solicito, ?id_sucursal_origen, ?id_sucursal_destino, ?descripcion, ?estado, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id_sucursal_solicito", idSucursalSolicito);
                sql.Parameters.AddWithValue("?id_sucursal_origen", idSucursalOrigen);
                sql.Parameters.AddWithValue("?id_sucursal_destino", idSucursalDestino);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
                sql.Parameters.AddWithValue("?estado", estado);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
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

        public static void CambiarEstado(int id, EstadoTraspaso e, string descripcion)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE traspaso SET estado=?estado, descripcion=?descripcion WHERE id=?id";
                sql.Parameters.AddWithValue("?estado", e);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
                if (e == EstadoTraspaso.Recibida)
                {
                    Traspaso t = new Traspaso(id);
                    t.ObtenerDatos();
                    InsertarProductos(t);
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

        private static void InsertarProductos(Traspaso t)
        {
            try
            {
                for (int i = 0; i < t.idProductos.Count; i++)
                {
                    //Suma los productos a la sucursal de destino
                    Inventario.CambiarCantidadInventario(t.idProductos[i], t.cantProductos[i], t.idSucursalDestino);
                    //Resta los productos a la sucursal de origen
                    Inventario.CambiarCantidadInventario(t.idProductos[i], t.cantProductos[i] * -1, t.idSucursalOrigen);
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
    }
}
