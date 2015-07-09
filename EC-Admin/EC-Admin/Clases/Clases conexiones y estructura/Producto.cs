using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EC_Admin
{
    class Producto
    {
        #region Propiedades
        private int id;
        private int idProveedor;
        private int idCategoria;
        private string nombre;
        private string marca;
        private string codigo;
        private string descripcion01;
        private decimal costo;
        private Unidades unidad;
        private Image imagen01;
        private Image imagen02;
        private Image imagen03;
        private bool eliminado;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;
        private int deleteUser;
        private DateTime deleteTime;
        private static int cantP = -1;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        public int IDCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descripcion01
        {
            get { return descripcion01; }
            set { descripcion01 = value; }
        }

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public Unidades Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        public Image Imagen01
        {
            get { return imagen01; }
            set { imagen01 = value; }
        }

        public Image Imagen02
        {
            get { return imagen02; }
            set { imagen02 = value; }
        }

        public Image Imagen03
        {
            get { return imagen03; }
            set { imagen03 = value; }
        }

        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
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

        public int DeleteUser
        {
            get { return deleteUser; }
        }

        public DateTime DeleteTime
        {
            get { return deleteTime; }
        }

        public static int CantidadP
        {
            get
            {
                if (cantP < 0)
                    CantP();
                return cantP;
            }
        }
        #endregion

        #region Cantidad
        private static void CantP()
        {
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM producto WHERE eliminado=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cantP = int.Parse(dr["c"].ToString());
                    else
                        cantP = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public Producto()
        {

        }

        public Producto(int id)
        {
            this.ID = id;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM producto WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idProveedor = (int)dr["proveedor_id"];
                    idCategoria = (int)dr["categoria"];
                    nombre = dr["nombre"].ToString();
                    marca = dr["marca"].ToString();
                    codigo = dr["codigo"].ToString();
                    descripcion01 = dr["descripcion1"].ToString();
                    costo = (decimal)dr["costo"];
                    unidad = (Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString());
                    if (dr["imagen01"] != DBNull.Value)
                        imagen01 = FuncionesGenerales.BytesImagen((byte[])dr["imagen01"]);
                    else
                        imagen01 = null;
                    if (dr["imagen02"] != DBNull.Value)
                        imagen02 = FuncionesGenerales.BytesImagen((byte[])dr["imagen02"]);
                    else
                        imagen02 = null;
                    if (dr["imagen03"] != DBNull.Value)
                        imagen03 = FuncionesGenerales.BytesImagen((byte[])dr["imagen03"]);
                    else
                        imagen03 = null;
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
                    if (dr["delete_user"] != DBNull.Value)
                        deleteUser = (int)dr["delete_user"];
                    else
                        deleteUser = 0;
                    if (dr["delete_time"] != DBNull.Value)
                        deleteTime = (DateTime)dr["delete_time"];
                    else
                        deleteTime = new DateTime();
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
                sql.CommandText = "INSERT INTO producto (proveedor_id, categoria, nombre, marca, codigo, descripcion1, costo, unidad, imagen01, imagen02, imagen03, create_user, create_time) " +
                    "VALUES (?proveedor_id, ?categoria, ?nombre, ?marca, ?codigo, ?descripcion1, ?costo, ?unidad, ?imagen01, ?imagen02, ?imagen03, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?proveedor_id", idProveedor);
                sql.Parameters.AddWithValue("?categoria", idCategoria);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?marca", marca);
                sql.Parameters.AddWithValue("?codigo", codigo);
                sql.Parameters.AddWithValue("?descripcion1", descripcion01);
                sql.Parameters.AddWithValue("?costo", costo);
                sql.Parameters.AddWithValue("?unidad", unidad);
                sql.Parameters.AddWithValue("?imagen01", FuncionesGenerales.ImagenBytes(imagen01));
                sql.Parameters.AddWithValue("?imagen02", FuncionesGenerales.ImagenBytes(imagen02));
                sql.Parameters.AddWithValue("?imagen03", FuncionesGenerales.ImagenBytes(imagen03));
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                this.id = ConexionBD.EjecutarConsulta(sql);
                CantP();
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
                sql.CommandText = "UPDATE producto SET proveedor_id=?proveedor_id, categoria=?categoria, nombre=?nombre, marca=?marca, codigo=?codigo, descripcion1=?descripcion1, costo=?costo, " +
                    "unidad=?unidad, imagen01=?imagen01, imagen02=?imagen02, imagen03=?imagen03, update_user=?update_user, update_time=NOW() WHERE id=?id"; 
                sql.Parameters.AddWithValue("?proveedor_id", idProveedor);
                sql.Parameters.AddWithValue("?categoria", idCategoria);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?marca", marca);
                sql.Parameters.AddWithValue("?codigo", codigo);
                sql.Parameters.AddWithValue("?descripcion1", descripcion01);
                sql.Parameters.AddWithValue("?costo", costo);
                sql.Parameters.AddWithValue("?unidad", unidad);
                sql.Parameters.AddWithValue("?imagen01", FuncionesGenerales.ImagenBytes(imagen01));
                sql.Parameters.AddWithValue("?imagen02", FuncionesGenerales.ImagenBytes(imagen02));
                sql.Parameters.AddWithValue("?imagen03", FuncionesGenerales.ImagenBytes(imagen03));
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
                sql.CommandText = "UPDATE producto SET eliminado=?estado, delete_user=?delete_user, delete_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?estado", estado);
                sql.Parameters.AddWithValue("?delete_user", Usuario.IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
                CantP();
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

        public static string NombreProducto(int id)
        {
            string nom = "";
            try
            {
                string sql = "SELECT nombre FROM producto WHERE id='" + id + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    nom = dr["nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nom;
        }

        public static string CodigoProducto(int id)
        {
            string cod = "";
            try
            {
                string sql = "SELECT codigo FROM producto WHERE id='" + id + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cod = dr["codigo"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cod;
        }

        public static decimal CantidadProducto(int id)
        {
            decimal cant = 0;
            try
            {
                string sql = "SELECT cant FROM producto WHERE id='" + id + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cant = (decimal)dr["cant"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cant;
        }

        public static Image Imagen01Producto(int id)
        {
            Image img = null;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT imagen01 FROM producto WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["imagen01"] != DBNull.Value)
                        img = FuncionesGenerales.BytesImagen((byte[])dr["imagen01"]);
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
            return img;
        }

        public static Image Imagen02Producto(int id)
        {
            Image img = null;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT imagen02 FROM producto WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["imagen02"] != DBNull.Value)
                        img = FuncionesGenerales.BytesImagen((byte[])dr["imagen02"]);
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
            return img;
        }

        public static Image Imagen03Producto(int id)
        {
            Image img = null;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT imagen03 FROM producto WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["imagen03"] != DBNull.Value)
                        img = FuncionesGenerales.BytesImagen((byte[])dr["imagen03"]);
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
            return img;
        }

        public static bool ExisteCodigo(string codigo)
        {
            bool existe = false;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id FROM producto WHERE codigo=?codigo";
                sql.Parameters.AddWithValue("?codigo", codigo);
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

        public static bool ExisteCodigo(string codigo, int id)
        {
            bool existe = false;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id FROM producto WHERE codigo=?codigo AND id=?id";
                sql.Parameters.AddWithValue("?codigo", codigo);
                sql.Parameters.AddWithValue("?id", id);
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

    }
}
