using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace EC_Admin
{
    class Trabajador
    {
        #region Propiedadaes
        private int id;
        private int idSucursal;
        private string nombre;
        private string apellidos;
        private int puesto;
        private string nomina;
        private decimal sueldo;
        private string telefono;
        private string celular;
        private string correo;
        private string direccion;
        private string ciudad;
        private string estado;
        private int cp;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Image imagen;
        private byte[] huella;
        private bool eliminado;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;
        private static int cant = -1;

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

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public int Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public string Nomina
        {
            get { return nomina; }
            set { nomina = value; }
        }
        
        public decimal Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int CP
        {
            get { return cp; }
            set { cp = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public Image Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public byte[] Huella
        {
            get { return huella; }
            set { huella = value; }
        }
        
        public bool Eliminado
        {
            get { return eliminado; }
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
        private static void Cant()
        {
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM trabajador WHERE eliminado=0";
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

        public Trabajador()
        {

        }

        public Trabajador(int id)
        {
            this.ID = id;
        }

        /// <summary>
        /// Función que obtiene los datos de un trabajador
        /// </summary>
        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM trabajador WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idSucursal = (int)dr["sucursal_id"];
                    nombre = dr["nombre"].ToString();
                    apellidos = dr["apellidos"].ToString();
                    puesto = (int)dr["puesto"];
                    nomina = dr["nomina"].ToString();
                    sueldo = (decimal)dr["sueldo"];
                    telefono = dr["telefono"].ToString();
                    celular = dr["celular"].ToString();
                    correo = dr["email"].ToString();
                    direccion = dr["direccion"].ToString();
                    ciudad = dr["ciudad"].ToString();
                    estado = dr["estado"].ToString();
                    cp = (int)dr["cp"];
                    fechaInicio = (DateTime)dr["fecha_inicio"];
                    if (dr["fecha_fin"] != DBNull.Value)
                        fechaFin = (DateTime)dr["fecha_fin"];
                    else
                        fechaFin = new DateTime();
                    if (dr["imagen"] != DBNull.Value)
                        imagen = FuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
                    else
                        imagen = null;
                    if (dr["huella"] != DBNull.Value)
                        huella = (byte[])dr["huella"];
                    else
                        huella = null;
                    eliminado = (bool)dr["eliminado"];
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
        /// Método que inserta un nuevo trabajador con los datos de las propiedades
        /// </summary>
        public void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO trabajador (sucursal_id, nombre, apellidos, puesto, sueldo, telefono, celular, email, direccion, ciudad, estado, cp, fecha_inicio, imagen, huella, create_user, create_time) " +
                    "VALUES (?sucursal_id, ?nombre, ?apellidos, ?puesto, ?sueldo, ?telefono, ?celular, ?email, ?direccion, ?ciudad, ?estado, ?cp, ?fecha_inicio, ?imagen, ?huella, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?sucursal_id", idSucursal);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?apellidos", apellidos);
                sql.Parameters.AddWithValue("?puesto", puesto);
                sql.Parameters.AddWithValue("?sueldo", sueldo);
                sql.Parameters.AddWithValue("?telefono", telefono);
                sql.Parameters.AddWithValue("?celular", celular);
                sql.Parameters.AddWithValue("?email", correo);
                sql.Parameters.AddWithValue("?direccion", direccion);
                sql.Parameters.AddWithValue("?ciudad", ciudad);
                sql.Parameters.AddWithValue("?estado", estado);
                sql.Parameters.AddWithValue("?cp", cp);
                sql.Parameters.AddWithValue("?fecha_inicio", fechaInicio);
                if (imagen != null)
                    sql.Parameters.AddWithValue("?imagen", FuncionesGenerales.ImagenBytes(imagen));
                else
                    sql.Parameters.AddWithValue("?imagen", DBNull.Value);
                sql.Parameters.AddWithValue("?huella", huella);
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
        /// Método que edita un trabajador con los datos de las propiedades según su ID
        /// </summary>
        public void Editar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE trabajador SET sucursal_id=?sucursal_id, nombre=?nombre, apellidos=?apellidos, puesto=?puesto, nomina=?nomina, sueldo=?sueldo, telefono=?telefono, celular=?celular, " + 
                    "email=?email, direccion=?direccion, ciudad=?ciudad, estado=?estado, cp=?cp, imagen=?imagen, huella=?huella, update_user=?update_user, update_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?sucursal_id", idSucursal);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?apellidos", apellidos);
                sql.Parameters.AddWithValue("?puesto", puesto);
                sql.Parameters.AddWithValue("?nomina", nomina);
                sql.Parameters.AddWithValue("?sueldo", sueldo);
                sql.Parameters.AddWithValue("?telefono", telefono);
                sql.Parameters.AddWithValue("?celular", celular);
                sql.Parameters.AddWithValue("?email", correo);
                sql.Parameters.AddWithValue("?direccion", direccion);
                sql.Parameters.AddWithValue("?ciudad", ciudad);
                sql.Parameters.AddWithValue("?estado", estado);
                sql.Parameters.AddWithValue("?cp", cp);
                if (imagen != null)
                    sql.Parameters.AddWithValue("?imagen", FuncionesGenerales.ImagenBytes(imagen));
                else
                    sql.Parameters.AddWithValue("?imagen", DBNull.Value);
                sql.Parameters.AddWithValue("?huella", huella);
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

        /// <summary>
        /// Método que cambia el estado de un trabajador
        /// </summary>
        /// <param name="id">ID del trabajador a cambiar su estado</param>
        /// <param name="eliminar">Valor booleano que indica si se mostrará el trabajador en las búsquedas o no</param>
        public static void CambiarEstado(int id, bool eliminar)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE trabajador SET eliminado=?eliminado, fecha_fin=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?eliminado", eliminar);
                sql.Parameters.AddWithValue("?id", id);
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

        public static string NombreTrabajador(int id)
        {
            string nom = "";
            try
            {
                string sql = "SELECT nombre, apellidos FROM trabajador WHERE id='" + id + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    nom = dr["nombre"].ToString() + " " + dr["apellidos"].ToString();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return nom;
        }

        //#region Puesto
        //private int idP;
        //private string nombreP;
        //private string departamentoP;
        //private int createUserP;
        //private DateTime createTimeP;
        //private int updateUserP;
        //private DateTime updateTimeP;
        //private static int cantP = -1;

        //public int IDPuesto
        //{
        //    get { return idP; }
        //    set { idP = value; }
        //}

        //public string NombrePuesto
        //{
        //    get { return nombreP; }
        //    set { nombreP = value; }
        //}

        //public string DepartamentoPuesto
        //{
        //    get { return departamentoP; }
        //    set { departamentoP = value; }
        //}

        //public int CreateUserPuesto
        //{
        //    get { return createUserP; }
        //}

        //public DateTime CreateTimePuesto
        //{
        //    get { return createTimeP; }
        //    set { createTimeP = value; }
        //}

        //public int UpdateUserPuesto
        //{
        //    get { return updateUserP; }
        //    set { updateUserP = value; }
        //}

        //public DateTime UpdateTimePuesto
        //{
        //    get { return updateTimeP; }
        //    set { updateTimeP = value; }
        //}

        //public static int CantidadPuesto
        //{
        //    get
        //    {
        //        try
        //        {
        //            if (cantP < 0)
        //                CantPuesto();
        //            return cantP;
        //        }
        //        catch (MySqlException ex)
        //        {
        //            throw ex;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //    }
        //}

        //private static void CantPuesto()
        //{
        //    try
        //    {
        //        string sql = "SELECT COUNT(id) AS c FROM puesto";
        //        DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            cantP = int.Parse(dr["c"].ToString());
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw ex;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void ObtenerDatosPuesto()
        //{
        //    try
        //    {
        //        MySqlCommand sql = new MySqlCommand();
        //        sql.CommandText = "SELECT * FROM puesto WHERE id=?id";
        //        sql.Parameters.AddWithValue("?id", idP);
        //        DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            nombreP = dr["nombre"].ToString();
        //            departamentoP = dr["departamento"].ToString();
        //            createUserP = (int)dr["create_user"];
        //            createTimeP = (DateTime)dr["create_time"];
        //            if (dr["update_user"] != DBNull.Value)
        //                updateUserP = (int)dr["update_user"];
        //            else
        //                updateUserP = 0;
        //            if (dr["update_time"] != DBNull.Value)
        //                updateTimeP = (DateTime)dr["update_time"];
        //            else
        //                updateTimeP = new DateTime();
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw ex;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void InsertarPuesto()
        //{
        //    try
        //    {
        //        MySqlCommand sql = new MySqlCommand();
        //        sql.CommandText = "INSERT INTO puesto (nombre, departamento, create_user, create_time) " +
        //            "VALUES (?nombre, ?departamento, ?create_user, NOW())";
        //        sql.Parameters.AddWithValue("?nombre", nombreP);
        //        sql.Parameters.AddWithValue("?departamento", departamentoP);
        //        sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
        //        ConexionBD.EjecutarConsulta(sql);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw ex;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void EditarPuesto()
        //{
        //    try
        //    {
        //        MySqlCommand sql = new MySqlCommand();
        //        sql.CommandText = "UPDATE puesto SET nombre=?nombre, departamento=?departamento, update_user=?update_user, update_time=NOW() WHERE id=?id";
        //        sql.Parameters.AddWithValue("?nombre", nombreP);
        //        sql.Parameters.AddWithValue("?departamento", departamentoP);
        //        sql.Parameters.AddWithValue("?update_user", Usuario.IDUsuarioActual);
        //        sql.Parameters.AddWithValue("?id", idP);
        //        ConexionBD.EjecutarConsulta(sql);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw ex;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //#endregion
    }
}
