using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data;

namespace EC_Admin
{
    class Usuario
    {
        #region Eventos
        /// <summary>
        /// Evento que se produce cuando se ha cambiado los datos del usuario actual.
        /// </summary>
        public event EventHandler UserDataChanged;

        /// <summary>
        /// Método que se llama cuando los datos del usuario actual han cambiado, actualizandolos y lanzando el evento.
        /// </summary>
        /// <param name="e">Parametro de evento vacío</param>
        protected virtual void OnChanged(EventArgs e)
        {
            if (UserDataChanged != null)
            {
                nomUsuActual = Nombre;
                apeUsuActual = Apellidos;
                nivUsuActual = NivelUsuario;
                imgUsuActual = Imagen;
                UserDataChanged(this, e);
            }
        }
        #endregion

        #region Propiedades
        private int id;
        private int idSucusal;
        private string userName;
        private string contraseña;
        private string nombre;
        private string apellidos;
        private string correo;
        private NivelesUsuario nivel;
        private bool eliminado;
        private string numAut;
        private Image imagen;
        private byte[] huella;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;

        private static int idUsuActual;
        private static string nomUsuActual;
        private static string apeUsuActual;
        private static NivelesUsuario nivUsuActual;
        private static Image imgUsuActual;
        private static int cantUsu = -1;
        private static int cantUsusAdmin = -1;
        private static int cantUsusEnc = -1;
        private static int cantUsusDesc = -1;

        /// <summary>
        /// Obtiene o establece el ID del usuario
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDSucusal
        {
            get { return idSucusal; }
            set { idSucusal = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre de usuario único
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        /// <summary>
        /// Obtiene o establece la contraseña del usuario
        /// </summary>
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del usuario
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece los apellidos de el usuario
        /// </summary>
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        /// <summary>
        /// Obtiene o establece el correo del usuario
        /// </summary>
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        /// <summary>
        /// Obtiene o establece el nivel del usuario
        /// </summary>
        public NivelesUsuario NivelUsuario
        {
            get { return nivel; }
            set { nivel = value; }
        }
        
        /// <summary>
        /// Obtiene o establece un valor booleano que indica si el usuario se encuentra en estado eliminado
        /// </summary>
        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        /// <summary>
        /// Obtiene o establece el número de autorización del usuario
        /// </summary>
        public string NumeroAutorizacion
        {
            get { return numAut; }
            set { numAut = value; }
        }

        /// <summary>
        /// Obtiene o establece la imagen del usuario
        /// </summary>
        public Image Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        /// <summary>
        /// Obtiene o establece el valor en binario de la huella digital del usuario
        /// </summary>
        public byte[] Huella
        {
            get { return huella; }
            set { huella = value; }
        }

        /// <summary>
        /// Obtiene el usuario creador del usuario
        /// </summary>
        public int CreateUser
        {
            get { return createUser; }
        }

        /// <summary>
        /// Obtiene la fecha de creación del usuario
        /// </summary>
        public DateTime CreateTime
        {
            get { return createTime; }
        }

        /// <summary>
        /// Obtiene el usuario que actualizó por última vez a el usuario
        /// </summary>
        public int UpdateUser
        {
            get { return updateUser; }
        }

        /// <summary>
        /// Obtiene la fecha de actualización por última vez a el usuario
        /// </summary>
        public DateTime UpdateTime
        {
            get { return updateTime; }
        }
        
        /// <summary>
        /// Obtiene el ID del usuario que actualmente tiene la sesión iniciada
        /// </summary>
        public static int IDUsuarioActual
        {
            get { return idUsuActual; }
        }
        
        /// <summary>
        /// Obtiene el nombre del usuario que actualmente tiene la sesión iniciada
        /// </summary>
        public static string NombreUsuarioActual
        {
            get { return nomUsuActual; }
        }

        /// <summary>
        /// Obtiene los apellidos del usuario que actualmente tiene la sesión iniciada
        /// </summary>
        public static string ApellidosUsuarioActual
        {
            get { return apeUsuActual; }
        }

        /// <summary>
        /// Obtiene el nivel del usuario que actualmente tiene la sesión iniciada
        /// </summary>
        public static NivelesUsuario NivelUsuarioActual
        {
            get { return nivUsuActual; }
        }
        
        /// <summary>
        /// Obtiene la imagen del usuario que actualmente tiene la sesión iniciada
        /// </summary>
        public static Image ImagenUsuarioActual
        {
            get { return imgUsuActual; }
        }

        /// <summary>
        /// Obtiene la cantidad de usuarios en total que hay en la base de datos
        /// </summary>
        public static int CantidadUsuarios
        {
            get
            {
                if (cantUsu < 0)
                    cantUsu = CantUsus();
                return cantUsu;
            }
        }

        /// <summary>
        /// Obtiene la cantidad de usuarios de nivel administrador
        /// </summary>
        public static int CantidadUsuariosAdministrador
        {
            get 
            {
                if (cantUsusAdmin < 0)
                    cantUsusAdmin = CantUsusAdmin();
                return cantUsusAdmin;
            }
        }

        /// <summary>
        /// Obtiene la cantidad de usuarios de nivel encargado
        /// </summary>
        public static int CantidadUsuariosEncargado
        {
            get
            {
                if (cantUsusEnc < 0)
                    cantUsusEnc = CantUsusEncar();
                return cantUsusEnc;
            }
        }

        /// <summary>
        /// Obtiene la cantidad de usuarios de nivel desconocido
        /// </summary>
        public static int CantidadUsuariosDesconocido
        {
            get
            {
                if (cantUsusDesc < 0)
                    cantUsusDesc = CantUsusDesc();
                return cantUsusDesc;
            }
        }
        #endregion

        #region Cantidades
        /// <summary>
        /// Método que actualiza los valores de las cantidades de los usuarios.
        /// </summary>
        private void CambioCantidadUsuarios()
        {
            cantUsu = CantUsus();
            cantUsusAdmin = CantUsusAdmin();
            cantUsusEnc = CantUsusEncar();
            cantUsusDesc = CantUsusDesc();
        }

        /// <summary>
        /// Función que obtiene la cantidad de usuarios que hay en la base de datos.
        /// </summary>
        /// <returns>Cantidad de usuarios</returns>
        private static int CantUsus()
        {
            int cant = 0;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT COUNT(id) AS c FROM usuario WHERE eliminado=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cant = int.Parse(dr["c"].ToString());
                }
            }
            catch (InvalidCastException ex)
            {
                throw ex;
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

        /// <summary>
        /// Obtiene la cantidad de usuarios de nivel administrador
        /// </summary>
        /// <returns>Cantidad de usuarios</returns>
        private static int CantUsusAdmin()
        {
            int cant = 0;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT COUNT(id) AS c FROM usuario WHERE nivel=?nivel AND eliminado=0";
                sql.Parameters.AddWithValue("?nivel", NivelesUsuario.Administrador);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cant = int.Parse(dr["c"].ToString());
                }
            }
            catch (InvalidCastException ex)
            {
                throw ex;
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

        /// <summary>
        /// Obtiene la cantidad de usuarios de nivel encargado
        /// </summary>
        /// <returns>Cantidad de usuarios</returns>
        private static int CantUsusEncar()
        {
            int cant = 0;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT COUNT(id) AS c FROM usuario WHERE nivel=?nivel AND eliminado=0";
                sql.Parameters.AddWithValue("?nivel", NivelesUsuario.Encargado);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cant = int.Parse(dr["c"].ToString());
                }
            }
            catch (InvalidCastException ex)
            {
                throw ex;
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

        /// <summary>
        /// Obtiene la cantidad de usuarios de nivel desconocido
        /// </summary>
        /// <returns>Cantidad de usuarios</returns>
        private static int CantUsusDesc()
        {
            int cant = 0;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT COUNT(id) AS c FROM usuario WHERE nivel=?nivel AND eliminado=0";
                sql.Parameters.AddWithValue("?nivel", NivelesUsuario.Desconocido);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cant = int.Parse(dr["c"].ToString());
                }
            }
            catch (InvalidCastException ex)
            {
                throw ex;
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

        /// <summary>
        /// Inicializa la instancia de la clase Usuario
        /// </summary>
        public Usuario()
        {

        }

        /// <summary>
        /// Inicializa la instancia de la clase Usuario con el ID especificado
        /// </summary>
        /// <param name="id"></param>
        public Usuario(int id)
        {
            this.ID = id;
        }

        /// <summary>
        /// Función que verifica los datos del usuario para su ingreso, y en caso de ser correctos, guarda la información del usuario.
        /// </summary>
        /// <param name="nomUsu">Nombre del usuario</param>
        /// <param name="pass">Contraseña del usuario</param>
        /// <returns>Valor booleano que indica si los datos son correctos</returns>
        public static bool VerificarIngresoUsuario(string nomUsu, string pass)
        {
            bool existe = false;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, nivel, nombre, apellidos, imagen FROM usuario WHERE username=?userName AND pass=?pass AND eliminado=0 AND sucursal_id='" + Config.idSucursal + "'";
                sql.Parameters.AddWithValue("?userName", nomUsu);
                sql.Parameters.AddWithValue("?pass", Criptografia.Cifrar(pass));
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idUsuActual = (int)dr["id"];
                    nomUsuActual = dr["nombre"].ToString();
                    apeUsuActual = dr["apellidos"].ToString();
                    nivUsuActual = (NivelesUsuario)Enum.Parse(typeof(NivelesUsuario), dr["nivel"].ToString());
                    if (dr["imagen"] != DBNull.Value)
                        imgUsuActual = FuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
                    else
                        imgUsuActual = null;
                    existe = true;
                    ObtenerPrivilegios();
                }
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return existe;
        }

        public static NivelesUsuario VerificarNivelUsuario(string nomUsu, string pass)
        {
            NivelesUsuario n = NivelesUsuario.Desconocido;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT nivel FROM usuario WHERE username=?userName AND pass=?pass AND eliminado=0";
                sql.Parameters.AddWithValue("?userName", nomUsu);
                sql.Parameters.AddWithValue("?pass", Criptografia.Cifrar(pass));
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    n = (NivelesUsuario)Enum.Parse(typeof(NivelesUsuario), dr["nivel"].ToString());
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
            return n;
        }

        /// <summary>
        /// Método que obtiene los datos del usuario y los guarda en las propiedades
        /// </summary>
        public void ObtenerDatosUsuario()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM usuario WHERE id=?id";
                sql.Parameters.AddWithValue("?id", ID);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    userName = dr["username"].ToString();
                    contraseña = Criptografia.Descifrar(dr["pass"].ToString());
                    nombre = dr["nombre"].ToString();
                    apellidos = dr["apellidos"].ToString();
                    correo = dr["email"].ToString();
                    nivel = (NivelesUsuario)Enum.Parse(typeof(NivelesUsuario), dr["nivel"].ToString());
                    eliminado = bool.Parse(dr["eliminado"].ToString());
                    numAut = dr["num_aut"].ToString();
                    if (dr["imagen"] != DBNull.Value)
                        imagen = FuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
                    else
                        imagen = null;
                    if (dr["huella"] != DBNull.Value)
                        huella = (byte[])dr["huella"];
                    else
                        huella = null;
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
        /// Método que inserta un nuevo usuario con los datos de las propiedades.
        /// </summary>
        public void InsertarUsuario()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO usuario (sucursal_id, username, pass, nivel, nombre, apellidos, email, imagen, huella, create_user, create_time) " +
                    "VALUES (?sucursal_id, ?username, ?pass, ?nivel, ?nombre, ?apellidos, ?email, ?imagen, ?huella, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?sucursal_id", idSucusal);
                sql.Parameters.AddWithValue("?username", UserName);
                sql.Parameters.AddWithValue("?pass", Criptografia.Cifrar(Contraseña));
                sql.Parameters.AddWithValue("?nivel", NivelUsuario);
                sql.Parameters.AddWithValue("?nombre", Nombre);
                sql.Parameters.AddWithValue("?apellidos", Apellidos);
                sql.Parameters.AddWithValue("?email", Correo);
                if (Imagen != null)
                    sql.Parameters.AddWithValue("?imagen", FuncionesGenerales.ImagenBytes(Imagen));
                else
                    sql.Parameters.AddWithValue("?imagen", DBNull.Value);
                if (Huella != null)
                    sql.Parameters.AddWithValue("?huella", huella);
                else
                    sql.Parameters.AddWithValue("?huella", DBNull.Value);
                if (CantidadUsuarios > 0)
                    sql.Parameters.AddWithValue("?create_user", idUsuActual);
                else
                    sql.Parameters.AddWithValue("?create_user", 1);
                ConexionBD.EjecutarConsulta(sql);
                CambioCantidadUsuarios();
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
        /// Método que edita la información de un usuario con la información de las propiedades
        /// </summary>
        public void EditarUsuario()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE usuario SET pass=?pass, nivel=?nivel, nombre=?nombre, apellidos=?apellidos, email=?email, imagen=?imagen, " + 
                    "huella=?huella, update_user=?update_user, update_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?pass", Criptografia.Cifrar(Contraseña));
                sql.Parameters.AddWithValue("?nivel", NivelUsuario);
                sql.Parameters.AddWithValue("?nombre", Nombre);
                sql.Parameters.AddWithValue("?apellidos", Apellidos);
                sql.Parameters.AddWithValue("?email", Correo);
                if (Imagen != null)
                    sql.Parameters.AddWithValue("?imagen", FuncionesGenerales.ImagenBytes(Imagen));
                else
                    sql.Parameters.AddWithValue("?imagen", DBNull.Value);
                if (Huella != null)
                    sql.Parameters.AddWithValue("?huella", Huella);
                else
                    sql.Parameters.AddWithValue("?huella", DBNull.Value);
                sql.Parameters.AddWithValue("?update_user", IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", ID);
                ConexionBD.EjecutarConsulta(sql);
                if (ID == IDUsuarioActual)
                {
                    OnChanged(EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que cambia el estado de un usuario a eliminado
        /// </summary>
        /// <param name="id">ID del usuario a eliminar</param>
        /// <param name="estado">true para eliminar, false para restablecer</param>
        public static void CambiarEstadoEliminadoUsuario(int id, bool estado)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE usuario SET eliminado=?eliminado WHERE id=?id";
                sql.Parameters.AddWithValue("?eliminado", estado);
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
        /// Método que verifica que el nombre de usuario esté disponible.
        /// </summary>
        /// <param name="nomUsu">Nombre de usuario a verificar</param>
        /// <returns>Valor booleano que indica si el usuario existe</returns>
        public static bool ExisteUsuario(string nomUsu)
        {
            bool existe = false;
            try
            {
                string sql = "SELECT id FROM usuario WHERE username='" + nomUsu + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    existe = true;
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
            return existe;
        }

        /// <summary>
        /// Método que obtiene el nombre y los apellidos de un usuario
        /// </summary>
        /// <param name="id">ID del usuario del que se desea obtener el nombre</param>
        /// <returns>Nombre y apellidos del usuario</returns>
        public static string ObtenerNombreUsuario(int id)
        {
            string nom = "Sin información";
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT nombre, apellidos FROM usuario WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    nom = dr["nombre"].ToString() + " " + dr["apellidos"].ToString();
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
            return nom;
        }

        /// <summary>
        /// Método que crea el número de autorización para el reestablecimiento de la contraseña
        /// </summary>
        /// <param name="id">ID del usuario al que se reestablecerá la contraseña</param>
        public static void CrearNumeroAutorizacion(int id, string correo)
        {
            try
            {
                string num = NumAut();
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE usuario SET num_aut=?num_aut WHERE id=?id";
                sql.Parameters.AddWithValue("?num_aut", num);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);

                Correos c = new Correos(true);
                c.CorreoOrigen = Config.correoOrigenInterno;
                c.Contraseña = Config.contraseñaOrigenInterno;
                c.CorreosDestino = correo;
                c.Host = Config.hostInterno;
                c.Puerto = int.Parse(Config.puertoInterno);
                c.Asunto = "Reestablecimiento de contraseña Admin-CSY";
                c.Cuerpo = "Ingresa el siguiente número de autorización en el programa para poder reestablecer la contraseña: " + num;
                c.EnviarCorreo();
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
        /// Método que genera un número aleatorio de seis cifras para crear el número de autorización
        /// </summary>
        /// <returns>Número de autorización</returns>
        private static string NumAut()
        {
            string num = "";
            for (int i = 0; i < 6; i++)
            {
                num += new Random().Next(0, 9).ToString();
                System.Threading.Thread.Sleep(10);
            }
            return num;
        }

        #region Privilegios
        private static bool pCaja;
        private static bool pAbrirCerrarCaja;
        private static bool pMovimientosCaja;
        private static bool pConfiguracion;
        private static bool pCorreo;
        private static bool pBaseDatos;
        private static bool pCompra;
        private static bool pCliente;
        private static bool pEliminarCliente;
        private static bool pProveedor;
        private static bool pEliminarProveedor;
        private static bool pCotizacion;
        private static bool pProducto;
        private static bool pEditarProducto;
        private static bool pEliminarProducto;
        private static bool pSucursal;
        private static bool pTrabajador;
        private static bool pCrearTrabajador;
        private static bool pEditarTrabajador;
        private static bool pEliminarTrabajador;
        private static bool pPagoTrabajador;
        private static bool pUsuario;
        private static bool pVenta;

        public static bool PCaja
        {
            get { return pCaja; }
        }

        public static bool PAbrirCerrarCaja
        {
            get { return pAbrirCerrarCaja; }
        }

        public static bool PMovimientosCaja
        {
            get { return pMovimientosCaja; }
        }

        public static bool PConfiguracion
        {
            get { return pConfiguracion; }
        }

        public static bool PCorreo
        {
            get { return pCorreo; }
        }

        public static bool PBaseDatos
        {
            get { return pBaseDatos; }
        }

        public static bool PCompra
        {
            get { return pCompra; }
        }

        public static bool PCliente
        {
            get { return pCliente; }
        }

        public static bool PEliminarCliente
        {
            get { return pEliminarCliente; }
        }

        public static bool PProveedor
        {
            get { return pProveedor; }
        }

        public static bool PEliminarProveedor
        {
            get { return pEliminarProveedor; }
        }

        public static bool PCotizacion
        {
            get { return pCotizacion; }
        }

        public static bool PProducto
        {
            get { return pProducto; }
        }

        public static bool PEditarProducto
        {
            get { return pEditarProducto; }
            set { pEditarProducto = value; }
        }

        public static bool PEliminarProducto
        {
            get { return pEliminarProducto; }
            set { pEliminarProducto = value; }
        }
        
        public static bool PSucursal
        {
            get { return pSucursal; }
        }

        public static bool PTrabajador
        {
            get { return pTrabajador; }
        }

        public static bool PCrearTrabajador
        {
            get { return pCrearTrabajador; }
        }

        public static bool PEditarTrabajador
        {
            get { return pEditarTrabajador; }
        }

        public static bool EliminarTrabajador
        {
            get { return pEliminarTrabajador; }
        }
        
        public static bool PPagoTrabajador
        {
            get { return pPagoTrabajador; }
        }

        public static bool PUsuario
        {
            get { return pUsuario; }
        }

        public static bool PVenta
        {
            get { return pVenta; }
        }

        private static void ObtenerPrivilegios()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM privilegios WHERE id_usuario=?id";
                sql.Parameters.AddWithValue("?id", idUsuActual);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    pCaja = (bool)dr["caja"];
                    pAbrirCerrarCaja = (bool)dr["abrir_cerrar_caja"];
                    pMovimientosCaja = (bool)dr["movimientos_caja"];
                    pConfiguracion = (bool)dr["configuracion"];
                    pCorreo = (bool)dr["correo"];
                    pBaseDatos = (bool)dr["base_datos"];
                    pCompra = (bool)dr["compra"];
                    pCliente = (bool)dr["cliente"];
                    pEliminarCliente = (bool)dr["eliminar_cliente"];
                    pProveedor = (bool)dr["proveedor"];
                    pEliminarProveedor = (bool)dr["eliminar_proveedor"];
                    pCotizacion = (bool)dr["cotizacion"];
                    pProducto = (bool)dr["producto"];
                    pEditarProducto = (bool)dr["editar_producto"];
                    pEliminarProducto = (bool)dr["eliminar_producto"];
                    pSucursal = (bool)dr["sucursal"];
                    pTrabajador = (bool)dr["trabajador"];
                    pCrearTrabajador = (bool)dr["crear_trabajador"];
                    pEditarTrabajador = (bool)dr["editar_trabajador"];
                    pEliminarTrabajador = (bool)dr["eliminar_trabajador"];
                    pPagoTrabajador = (bool)dr["pago_trabajador"];
                    pUsuario = (bool)dr["usuario"];
                    pVenta = (bool)dr["venta"];
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
    }
}
