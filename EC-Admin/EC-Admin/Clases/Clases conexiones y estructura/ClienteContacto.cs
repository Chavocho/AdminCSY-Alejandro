using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EC_Admin
{
    public class ClienteContacto : PersonaContacto
    {
        #region Eventos
        public event EventHandler ContactDataBaseModified;

        protected virtual void OnContactDataBaseModified(EventArgs e)
        {
            if (ContactDataBaseModified != null)
            {
                Cant();
                ObtenerContactos();
                ContactDataBaseModified(this, e);
            }
        }
        #endregion

        #region Propiedades
        private int id;
        private int idP;
        private string nombre;
        private string apellidos;
        private string telefono01;
        private string telefono02;
        private string ext;
        private string celular;
        private string lada01;
        private string lada02;
        private string correo;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;
        private static int cant = -1;


        private List<int> idCS = new List<int>();
        private List<string> nombreContactos = new List<string>();
        private List<string> apellidoContactos = new List<string>();
        private List<string> telefonoContactos01 = new List<string>();
        private List<string> telefonoContactos02 = new List<string>();
        private List<string> extensionContactos = new List<string>();
        private List<string> celularContactos = new List<string>();
        private List<string> ladaContactos01 = new List<string>();
        private List<string> ladaContactos02 = new List<string>();
        private List<string> correoContactos = new List<string>();
        private List<int> createUserContactos = new List<int>();
        private List<DateTime> createTimeContactos = new List<DateTime>();
        private List<int> updateUserContactos = new List<int>();
        private List<DateTime> updateTimeContactos = new List<DateTime>();

        public override int ID
        {
            get { return id; }
            set { id = value; }
        }

        public override int IDPersona
        {
            get { return idP; }
        }

        public override string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public override string Telefono01
        {
            get { return telefono01; }
            set { telefono01 = value; }
        }

        public override string Telefono02
        {
            get { return telefono02; }
            set { telefono02 = value; }
        }

        public override string Extension
        {
            get { return ext; }
            set { ext = value; }
        }

        public override string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public override string Lada01
        {
            get { return lada01; }
            set { lada01 = value; }
        }

        public override string Lada02
        {
            get { return lada02; }
            set { lada02 = value; }
        }

        public override string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public override int CreateUser
        {
            get { return createUser; }
        }

        public override DateTime CreateTime
        {
            get { return createTime; }
        }

        public override int UpdateUser
        {
            get { return updateUser; }
        }

        public override DateTime UpdateTime
        {
            get { return updateTime; }
        }

        public override List<int> IDCS
        {
            get { return idCS; }
        }

        public override List<string> NombreContactos
        {
            get { return nombreContactos; }
        }

        public override List<string> ApellidoContactos
        {
            get { return apellidoContactos; }
        }

        public override List<string> TelefonoContactos01
        {
            get { return telefonoContactos01; }
        }

        public override List<string> TelefonoContactos02
        {
            get { return telefonoContactos02; }
        }

        public override List<string> ExtensionContactos
        {
            get { return extensionContactos; }
        }

        public override List<string> CelularContactos
        {
            get { return celularContactos; }
        }

        public override List<string> LadaContactos01
        {
            get { return ladaContactos01; }
        }

        public override List<string> LadaContactos02
        {
            get { return ladaContactos02; }
        }

        public override List<string> CorreoContactos
        {
            get { return correoContactos; }
        }

        public override List<int> CreateUserContactos
        {
            get { return createUserContactos; }
        }

        public override List<DateTime> CreateTimeContactos
        {
            get { return createTimeContactos; }
        }

        public override List<int> UpdateUserContactos
        {
            get { return updateUserContactos; }
        }

        public override List<DateTime> UpdateTimeContactos
        {
            get { return updateTimeContactos; }
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

        private static void Cant()
        {
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM contacto_cliente";
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

        /// <summary>
        /// Inicializa la instancia de clase de ClienteContacto y obtiene los contactos asociados al cliente
        /// </summary>
        /// <param name="idPersona">ID del cliente</param>
        public ClienteContacto(int idPersona)
        {
            this.idP = idPersona;
            ObtenerContactos();
        }

        /// <summary>
        /// Método que limpia las listas con los datos de todos los contactos de determinado cliente
        /// </summary>
        private void LimpiarListas()
        {
            idCS = new List<int>();
            nombreContactos = new List<string>();
            apellidoContactos = new List<string>();
            telefonoContactos01 = new List<string>();
            telefonoContactos02 = new List<string>();
            extensionContactos = new List<string>();
            celularContactos = new List<string>();
            ladaContactos01 = new List<string>();
            ladaContactos02 = new List<string>();
            correoContactos = new List<string>();
            createUserContactos = new List<int>();
            createTimeContactos = new List<DateTime>();
            updateUserContactos = new List<int>();
            updateTimeContactos = new List<DateTime>();
        }

        /// <summary>
        /// Método que reinicializa las propiedades para su reutilización
        /// </summary>
        private void LimpiarPropiedades()
        {
            this.id = 0;
            this.nombre = "";
            this.apellidos = "";
            this.telefono01 = "";
            this.telefono02 = "";
            this.ext = "";
            this.celular = "";
            this.lada01 = "";
            this.lada02 = "";
            this.correo = "";
            this.createUser = 0;
            this.createTime = new DateTime();
            this.updateUser = 0;
            this.updateTime = new DateTime();
        }

        /// <summary>
        /// Obtiene los datos de un contacto con determinado ID
        /// </summary>
        public override void ObtenerDatosContacto()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM contacto_cliente WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idP = (int)dr["id_cliente"];
                    nombre = dr["nombre"].ToString();
                    apellidos = dr["apellidos"].ToString();
                    telefono01 = dr["telefono1"].ToString();
                    telefono02 = dr["telefono2"].ToString();
                    ext = dr["extension"].ToString();
                    celular = dr["celular"].ToString();
                    lada01 = dr["lada1"].ToString();
                    lada02 = dr["lada2"].ToString();
                    correo = dr["email"].ToString();
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene todos los contactos asociados con determinado cliente
        /// </summary>
        protected override void ObtenerContactos()
        {
            if (idP == 0)
                return;
            try
            {
                LimpiarListas();
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM contacto_cliente WHERE id_cliente=?id_cliente";
                sql.Parameters.AddWithValue("?id_cliente", idP);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idCS.Add((int)dr["id"]);
                    nombreContactos.Add(dr["nombre"].ToString());
                    apellidoContactos.Add(dr["apellidos"].ToString());
                    telefonoContactos01.Add(dr["telefono1"].ToString());
                    telefonoContactos02.Add(dr["telefono2"].ToString());
                    extensionContactos.Add(dr["extension"].ToString());
                    celularContactos.Add(dr["celular"].ToString());
                    ladaContactos01.Add(dr["lada1"].ToString());
                    ladaContactos02.Add(dr["lada2"].ToString());
                    correoContactos.Add(dr["email"].ToString());
                    createUserContactos.Add((int)dr["create_user"]);
                    createTimeContactos.Add((DateTime)dr["create_time"]);
                    if (dr["update_user"] != DBNull.Value)
                        updateUserContactos.Add((int)dr["update_user"]);
                    else
                        updateUserContactos.Add(0);
                    if (dr["update_time"] != DBNull.Value)
                        updateTimeContactos.Add((DateTime)dr["update_time"]);
                    else
                        updateTimeContactos.Add(new DateTime());
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
        /// Inserta un nuevo contacto con los de las propiedades
        /// </summary>
        public override void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO contacto_cliente (id_cliente, nombre, apellidos, telefono1, telefono2, extension, celular, lada1, lada2, email, create_user, create_time) " +
                    "VALUES (?id_cliente, ?nombre, ?apellidos, ?telefono1, ?telefono2, ?extension, ?celular, ?lada1, ?lada2, ?email, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id_cliente", idP);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?apellidos", apellidos);
                sql.Parameters.AddWithValue("?telefono1", telefono01);
                sql.Parameters.AddWithValue("?telefono2", telefono02);
                sql.Parameters.AddWithValue("?extension", ext);
                sql.Parameters.AddWithValue("?celular", celular);
                sql.Parameters.AddWithValue("?lada1", lada01);
                sql.Parameters.AddWithValue("?lada2", lada02);
                sql.Parameters.AddWithValue("?email", correo);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                ConexionBD.EjecutarConsulta(sql);
                OnContactDataBaseModified(new EventArgs());
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
        /// Edita un contacto con las propiedades según su ID
        /// </summary>
        public override void Editar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE contacto_cliente SET nombre=?nombre, apellidos=?apellidos, telefono1=?telefono1, telefono2=?telefono2, " +
                    "extension=?extension, celular=?celular, lada1=?lada1, lada2=?lada2, email=?email, update_user=?update_user, update_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?apellidos", apellidos);
                sql.Parameters.AddWithValue("?telefono1", telefono01);
                sql.Parameters.AddWithValue("?telefono2", telefono02);
                sql.Parameters.AddWithValue("?extension", ext);
                sql.Parameters.AddWithValue("?celular", celular);
                sql.Parameters.AddWithValue("?lada1", lada01);
                sql.Parameters.AddWithValue("?lada2", lada02);
                sql.Parameters.AddWithValue("?email", correo);
                sql.Parameters.AddWithValue("?update_user", updateUser);
                ConexionBD.EjecutarConsulta(sql);
                OnContactDataBaseModified(new EventArgs());
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
        /// Elimina permanentemente un contacto según su ID
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(int id)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "DELETE FROM contacto_cliente WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
                OnContactDataBaseModified(new EventArgs());
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
