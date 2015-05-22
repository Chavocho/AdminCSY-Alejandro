using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EC_Admin
{
    class Sucursal
    {
        #region Propiedades
        private int id;
        private string nombre;
        private string calle;
        private string numExt;
        private string numInt;
        private int cp;
        private string colonia;
        private string estado;
        private string ciudad;
        private string telefono01;
        private string telefono02;
        private string fax;
        private string correo;
        private System.Drawing.Image logotipo;
        private string web;
        private string rfc;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;

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

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public string NumExt
        {
            get { return numExt; }
            set { numExt = value; }
        }

        public string NumInt
        {
            get { return numInt; }
            set { numInt = value; }
        }

        public int CP
        {
            get { return cp; }
            set { cp = value; }
        }

        public string Colonia
        {
            get { return colonia; }
            set { colonia = value; }
        }
        
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Telefono01
        {
            get { return telefono01; }
            set { telefono01 = value; }
        }

        public string Telefono02
        {
            get { return telefono02; }
            set { telefono02 = value; }
        }

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public System.Drawing.Image Logotipo
        {
            get { return logotipo; }
            set { logotipo = value; }
        }

        public string Web
        {
            get { return web; }
            set { web = value; }
        }

        public string RFC
        {
            get { return rfc; }
            set { rfc = value; }
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
        private static int cant = -1;

        public static int Cantidad
        {
            get { return cant; }
        }
        
        #endregion

        public Sucursal()
        {

        }

        public Sucursal(int id)
        {
            this.ID = id;
        }

        private static void Cant()
        {
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM sucursal WHERE eliminado=0;";
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

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM sucursal WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idDireccion = (int)dr["id_domicilio"];
                    nombre = dr["nombre"].ToString();
                    calle = dr["calle"].ToString();
                    numExt = dr["numero_ext"].ToString();
                    numInt = dr["numero_int"].ToString();
                    cp = (int)dr["cp"];
                    colonia = dr["colonia"].ToString();
                    estado = dr["estado"].ToString();
                    ciudad = dr["ciudad"].ToString();
                    telefono01 = dr["telefono1"].ToString();
                    telefono02 = dr["telefono2"].ToString();
                    fax = dr["fax"].ToString();
                    correo = dr["email"].ToString();
                    if (dr["logotipo"] != DBNull.Value)
                        logotipo = FuncionesGenerales.BytesImagen((byte[])dr["logotipo"]);
                    else
                        logotipo = null;
                    web = dr["web"].ToString();
                    rfc = dr["rfc"].ToString();
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

        public void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO sucursal (id_domicilio, nombre, calle, numero_ext, numero_int, cp, colonia, estado, ciudad, telefono1, telefono2, fax, email, logotipo, web, rfc, create_user, create_time) " +
                    "VALUES (?id_domicilio, ?nombre, ?calle, ?numero_ext, ?numero_int, ?cp, ?colonia, ?estado, ?ciudad, ?telefono1, ?telefono2, ?fax, ?email, ?logotipo, ?web, ?rfc, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id_domicilio", idDireccion);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?calle", calle);
                sql.Parameters.AddWithValue("?numero_ext", numExt);
                sql.Parameters.AddWithValue("?numero_int", numInt);
                sql.Parameters.AddWithValue("?cp", cp);
                sql.Parameters.AddWithValue("?colonia", colonia);
                sql.Parameters.AddWithValue("?estado", estado);
                sql.Parameters.AddWithValue("?ciudad", ciudad);
                sql.Parameters.AddWithValue("?telefono1", telefono01);
                sql.Parameters.AddWithValue("?telefono2", telefono02);
                sql.Parameters.AddWithValue("?fax", fax);
                sql.Parameters.AddWithValue("?email", correo);
                if (logotipo != null)
                    sql.Parameters.AddWithValue("?logotipo", FuncionesGenerales.ImagenBytes(logotipo));
                else
                    sql.Parameters.AddWithValue("?logotipo", DBNull.Value);
                sql.Parameters.AddWithValue("?web", web);
                sql.Parameters.AddWithValue("?rfc", rfc);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                this.ID = ConexionBD.EjecutarConsulta(sql);
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
                sql.CommandText = "UPDATE sucursal SET id_domicilio=?id_domicilio, nombre=?nombre, calle=?calle, numero_ext=?numero_ext, numero_int=?numero_int, cp=?cp, colonia=?colonia, " + 
                    "estado=?estado, ciudad=?ciudad, telefono1=?telefono1, telefono2=?telefono2, fax=?fax, email=?email, logotipo=?logotipo, web=?web, rfc=?rfc, update_user=?update_user, update_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?id_domicilio", idDireccion);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?calle", calle);
                sql.Parameters.AddWithValue("?numero_ext", numExt);
                sql.Parameters.AddWithValue("?numero_int", numInt);
                sql.Parameters.AddWithValue("?cp", cp);
                sql.Parameters.AddWithValue("?colonia", colonia);
                sql.Parameters.AddWithValue("?estado", estado);
                sql.Parameters.AddWithValue("?ciudad", ciudad);
                sql.Parameters.AddWithValue("?telefono1", telefono01);
                sql.Parameters.AddWithValue("?telefono2", telefono02);
                sql.Parameters.AddWithValue("?fax", fax);
                sql.Parameters.AddWithValue("?email", correo);
                if (logotipo != null)
                    sql.Parameters.AddWithValue("?logotipo", FuncionesGenerales.ImagenBytes(logotipo));
                else
                    sql.Parameters.AddWithValue("?logotipo", DBNull.Value);
                sql.Parameters.AddWithValue("?web", web);
                sql.Parameters.AddWithValue("?rfc", rfc);
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

        public static void CambiarEstado(int id, bool estado)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE sucursal SET eliminado=?estado WHERE id=?id";
                sql.Parameters.AddWithValue("?estado", estado);
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

        public static string NombreSucursal(int id)
        {
            string nombre = "";
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT nombre FROM sucursal WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    nombre = dr["nombre"].ToString();
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
            return nombre;
        }

        #region Direcciones
        private int idDireccion;
        private string calleFiscal;
        private string numExtFiscal;
        private string numIntFiscal;
        private string cpFiscal;
        private string coloniaFiscal;
        private string ciudadFiscal;
        private string estadoFiscal;
        private bool eliminado;
        private static int cantDomicilios = -1;

        public int IDDireccion
        {
            get { return idDireccion; }
            set { idDireccion = value; }
        }

        public string CalleFiscal
        {
            get { return calleFiscal; }
            set { calleFiscal = value; }
        }

        public string NumeroExteriorFiscal
        {
            get { return numExtFiscal; }
            set { numExtFiscal = value; }
        }

        public string NumeroInteriorFiscal
        {
            get { return numIntFiscal; }
            set { numIntFiscal = value; }
        }

        public string CPFiscal
        {
            get { return cpFiscal; }
            set { cpFiscal = value; }
        }

        public string ColoniaFiscal
        {
            get { return coloniaFiscal; }
            set { coloniaFiscal = value; }
        }

        public string CiudadFiscal
        {
            get { return ciudadFiscal; }
            set { ciudadFiscal = value; }
        }

        public string EstadoFiscal
        {
            get { return estadoFiscal; }
            set { estadoFiscal = value; }
        }

        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        public static int CantidadDomicilios
        {
            get
            {
                try
                {
                    if (cantDomicilios < 0)
                        CantDomicilios();
                }
                catch (MySqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return cantDomicilios;
            }
        }

        private static void CantDomicilios()
        {
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM direccion WHERE eliminado=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cantDomicilios = int.Parse(dr["c"].ToString());
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

        public void ObtenerDatosDireccion()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM direccion WHERE id=?id";
                sql.Parameters.AddWithValue("?id", idDireccion);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    calleFiscal = dr["calle"].ToString();
                    numExtFiscal = dr["num_ext"].ToString();
                    numIntFiscal = dr["num_int"].ToString();
                    cpFiscal = dr["cp"].ToString();
                    coloniaFiscal = dr["colonia"].ToString();
                    ciudadFiscal = dr["ciudad"].ToString();
                    estadoFiscal = dr["estado"].ToString();
                    eliminado = (bool)dr["eliminado"];
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

        public void InsertarDireccion()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO direccion (calle, num_ext, num_int, cp, colonia, ciudad, estado) " +
                    "VALUES (?calle, ?num_ext, ?num_int, ?cp, ?colonia, ?ciudad, ?estado)";
                sql.Parameters.AddWithValue("?calle", calleFiscal);
                sql.Parameters.AddWithValue("?num_ext", numExtFiscal);
                sql.Parameters.AddWithValue("?num_int", numIntFiscal);
                sql.Parameters.AddWithValue("?cp", cpFiscal);
                sql.Parameters.AddWithValue("?colonia", coloniaFiscal);
                sql.Parameters.AddWithValue("?ciudad", ciudadFiscal);
                sql.Parameters.AddWithValue("?estado", estadoFiscal);
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

        public void EditarDireccion()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE direccion SET calle=?calle, num_ext=?num_ext, num_int=?num_int, cp=?cp, " + 
                    "colonia=?colonia, ciudad=?ciudad, estado=?estado WHERE id=?id";
                sql.Parameters.AddWithValue("?calle", calleFiscal);
                sql.Parameters.AddWithValue("?num_ext", numExtFiscal);
                sql.Parameters.AddWithValue("?num_int", numIntFiscal);
                sql.Parameters.AddWithValue("?cp", cpFiscal);
                sql.Parameters.AddWithValue("?colonia", coloniaFiscal);
                sql.Parameters.AddWithValue("?ciudad", ciudadFiscal);
                sql.Parameters.AddWithValue("?estado", estadoFiscal);
                sql.Parameters.AddWithValue("?id", idDireccion);
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

        public static void CambiarEstadoDireccion(int id, bool estado)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE direccion SET eliminado=?estado WHERE id=?id";
                sql.Parameters.AddWithValue("?estado", estado);
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
        #endregion
    }
}
