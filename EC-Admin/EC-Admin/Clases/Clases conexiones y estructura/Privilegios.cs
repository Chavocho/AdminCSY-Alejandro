using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Privilegios
    {
        #region Propiedades
        private int id;
        private int idUsuario;
        private bool caja;
        private bool abrirCerrarCaja;
        private bool movimientosCaja;
        private bool configuracion;
        private bool correo;
        private bool baseDatos;
        private bool compra;
        private bool cliente;
        private bool eliminarCliente;
        private bool proveedor;
        private bool eliminarProveedor;
        private bool cotizacion;
        private bool producto;
        private bool editarProducto;
        private bool eliminarProducto;
        private bool sucursal;
        private bool trabajador;
        private bool crearTrabajador;
        private bool editarTrabajador;
        private bool eliminarTrabajador;
        private bool pagoTrabajador;
        private bool usuario;
        private bool venta;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public bool Caja
        {
            get { return caja; }
            set { caja = value; }
        }

        public bool AbrirCerrarCaja
        {
            get { return abrirCerrarCaja; }
            set { abrirCerrarCaja = value; }
        }

        public bool MovimientosCaja
        {
            get { return movimientosCaja; }
            set { movimientosCaja = value; }
        }

        public bool Configuracion
        {
            get { return configuracion; }
            set { configuracion = value; }
        }

        public bool Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public bool BaseDatos
        {
            get { return baseDatos; }
            set { baseDatos = value; }
        }

        public bool Compra
        {
            get { return compra; }
            set { compra = value; }
        }

        public bool Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public bool EliminarCliente
        {
            get { return eliminarCliente; }
            set { eliminarCliente = value; }
        }

        public bool Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        public bool EliminarProveedor
        {
            get { return eliminarProveedor; }
            set { eliminarProveedor = value; }
        }

        public bool Cotizacion
        {
            get { return cotizacion; }
            set { cotizacion = value; }
        }

        public bool Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public bool EditarProducto
        {
            get { return editarProducto; }
            set { editarProducto = value; }
        }

        public bool EliminarProducto
        {
            get { return eliminarProducto; }
            set { eliminarProducto = value; }
        }

        public bool Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }

        public bool Trabajador
        {
            get { return trabajador; }
            set { trabajador = value; }
        }

        public bool CrearTrabajador
        {
            get { return crearTrabajador; }
            set { crearTrabajador = value; }
        }

        public bool EditarTrabajador
        {
            get { return editarTrabajador; }
            set { editarTrabajador = value; }
        }

        public bool EliminarTrabajador
        {
            get { return eliminarTrabajador; }
            set { eliminarTrabajador = value; }
        }

        public bool PagoTrabajador
        {
            get { return pagoTrabajador; }
            set { pagoTrabajador = value; }
        }

        public bool Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public bool Venta
        {
            get { return venta; }
            set { venta = value; }
        }
        
        #endregion

        public Privilegios(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public Privilegios(int id, int idUsuario)
        {
            this.id = id;
            this.idUsuario = idUsuario;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM privilegios WHERE id=?id";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    caja = (bool)dr["caja"];
                    abrirCerrarCaja = (bool)dr["abrir_cerrar_caja"];
                    movimientosCaja = (bool)dr["movimientos_caja"];
                    configuracion = (bool)dr["configuracion"];
                    correo = (bool)dr["correo"];
                    baseDatos = (bool)dr["base_datos"];
                    compra = (bool)dr["compra"];
                    cliente = (bool)dr["cliente"];
                    eliminarCliente = (bool)dr["eliminar_cliente"];
                    proveedor = (bool)dr["proveedor"];
                    eliminarProveedor = (bool)dr["eliminar_proveedor"];
                    cotizacion = (bool)dr["cotizacion"];
                    producto = (bool)dr["producto"];
                    editarProducto = (bool)dr["editar_producto"];
                    eliminarProducto = (bool)dr["eliminar_producto"];
                    sucursal = (bool)dr["sucursal"];
                    trabajador = (bool)dr["trabajador"];
                    crearTrabajador = (bool)dr["crear_trabajador"];
                    editarTrabajador = (bool)dr["editar_trabajador"];
                    eliminarTrabajador = (bool)dr["eliminar_trabajador"];
                    pagoTrabajador = (bool)dr["pago_trabajador"];
                    usuario = (bool)dr["usuario"];
                    venta = (bool)dr["venta"];
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
                sql.CommandText = "INSERT INTO privilegios (id_usuario, caja, abrir_cerrar_caja, movimientos_caja, configuracion, correo, base_datos, compra, cliente, eliminar_cliente, proveedor, eliminar_proveedor, cotizacion, producto, editar_producto, eliminar_producto, sucursal, trabajador, crear_trabajador, editar_trabajador, eliminar_trabajador, pago_trabajador, usuario, venta) " +
                    "VALUES (?id_usuario, ?caja, ?abrir_cerrar_caja, ?movimientos_caja, ?configuracion, ?correo, ?base_datos, ?compra, ?cliente, ?eliminar_cliente, ?proveedor, ?eliminar_proveedor, ?cotizacion, ?producto, ?editar_producto, ?eliminar_producto, ?sucursal, ?trabajador, ?crear_trabajador, ?editar_trabajador, ?eliminar_trabajador, ?pago_trabajador, ?usuario, ?venta)";
                sql.Parameters.AddWithValue("?id_usuario", idUsuario);
                sql.Parameters.AddWithValue("?caja", caja);
                sql.Parameters.AddWithValue("?abrir_cerrar_caja", abrirCerrarCaja);
                sql.Parameters.AddWithValue("?movimientos_caja", movimientosCaja);
                sql.Parameters.AddWithValue("?configuracion", configuracion);
                sql.Parameters.AddWithValue("?correo", correo);
                sql.Parameters.AddWithValue("?base_datos", baseDatos);
                sql.Parameters.AddWithValue("?compra", compra);
                sql.Parameters.AddWithValue("?cliente", cliente);
                sql.Parameters.AddWithValue("?eliminar_cliente", eliminarCliente);
                sql.Parameters.AddWithValue("?proveedor", proveedor);
                sql.Parameters.AddWithValue("?eliminar_proveedor", eliminarProveedor);
                sql.Parameters.AddWithValue("?cotizacion", cotizacion);
                sql.Parameters.AddWithValue("?producto", producto);
                sql.Parameters.AddWithValue("?editar_producto", editarProducto);
                sql.Parameters.AddWithValue("?eliminar_producto", eliminarProducto);
                sql.Parameters.AddWithValue("?sucursal", sucursal);
                sql.Parameters.AddWithValue("?trabajador", trabajador);
                sql.Parameters.AddWithValue("?crear_trabajador", crearTrabajador);
                sql.Parameters.AddWithValue("?editar_trabajador", editarTrabajador);
                sql.Parameters.AddWithValue("?eliminar_trabajador", eliminarTrabajador);
                sql.Parameters.AddWithValue("?pago_trabajador", pagoTrabajador);
                sql.Parameters.AddWithValue("?usuario", usuario);
                sql.Parameters.AddWithValue("?venta", venta);
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
                sql.CommandText = "UPDATE privilegios SET caja=?caja, abrir_cerrar_caja=?abrir_cerrar_caja, movimientos_caja=?movimientos_caja, configuracion=?configuracion, correo=?correo, base_datos=?base_datos, compra=?compra, cliente=?cliente, eliminar_cliente=?eliminar_cliente, proveedor=?proveedor, eliminar_proveedor=?eliminar_proveedor, cotizacion=?cotizacion, " + 
                    "producto=?producto, editar_producto=?editar_producto, eliminar_producto=?eliminar_producto, sucursal=?sucursal, trabajador?=trabajador, crear_trabajador=?crear_trabajador, editar_trabajador=?editar_trabajador, eliminar_trabajador=?eliminar_trabajador, pago_trabajador=?pago_trabajador, usuario=?usuario, venta=?venta WHERE id=?id";
                sql.Parameters.AddWithValue("?caja", caja);
                sql.Parameters.AddWithValue("?abrir_cerrar_caja", abrirCerrarCaja);
                sql.Parameters.AddWithValue("?movimientos_caja", movimientosCaja);
                sql.Parameters.AddWithValue("?configuracion", configuracion);
                sql.Parameters.AddWithValue("?correo", correo);
                sql.Parameters.AddWithValue("?base_datos", baseDatos);
                sql.Parameters.AddWithValue("?compra", compra);
                sql.Parameters.AddWithValue("?cliente", cliente);
                sql.Parameters.AddWithValue("?eliminar_cliente", eliminarCliente);
                sql.Parameters.AddWithValue("?proveedor", proveedor);
                sql.Parameters.AddWithValue("?eliminar_proveedor", eliminarProveedor);
                sql.Parameters.AddWithValue("?cotizacion", cotizacion);
                sql.Parameters.AddWithValue("?producto", producto);
                sql.Parameters.AddWithValue("?editar_producto", editarProducto);
                sql.Parameters.AddWithValue("?eliminar_producto", eliminarProducto);
                sql.Parameters.AddWithValue("?sucursal", sucursal);
                sql.Parameters.AddWithValue("?trabajador", trabajador);
                sql.Parameters.AddWithValue("?crear_trabajador", crearTrabajador);
                sql.Parameters.AddWithValue("?editar_trabajador", editarTrabajador);
                sql.Parameters.AddWithValue("?eliminar_trabajador", eliminarTrabajador);
                sql.Parameters.AddWithValue("?pago_trabajador", pagoTrabajador);
                sql.Parameters.AddWithValue("?usuario", usuario);
                sql.Parameters.AddWithValue("?venta", venta);
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
