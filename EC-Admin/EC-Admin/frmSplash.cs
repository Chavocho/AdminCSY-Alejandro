using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin
{
    public partial class frmSplash : Form
    {
        int intentos = 0;
        int c = 0;

        public frmSplash()
        {
            InitializeComponent();
        }

        #region Paso 01

        /// <summary>
        /// Método recursivo que verifica si el servicio de MySQL se encuentra activo, en caso de estarlo, guarda el ID del proceso, en caso contrario,
        /// lo trata de iniciar e inicia la recursividad para verificar si se logro iniciar.
        /// </summary>
        private void MySQL()
        {
            try
            {
                if (intentos <= 3)
                {
                    int id = FuncionesGenerales.IDProceso("mysqld");
                    if (id <= 0)
                    {
                        FuncionesGenerales.IniciarProceso("C:\\xampp\\mysql_start.bat");
                        System.Threading.Thread.Sleep(3000);
                        intentos += 1;
                        MySQL();
                    }
                    else
                    {
                        Config.idMySQL = id;
                    }
                }
                else
                {
                    throw new Exception("No se logro iniciar el servicio de MySQL");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que verifica que la configuración de la base de datos exista en el archivo de configuración,
        /// en caso de que no exista, lo crea.
        /// </summary>
        private void ConfiguracionBaseDatos()
        {
            if (!ConfiguracionXML.ExisteConfiguracion("basedatos"))
            {
                DialogResult r = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "No tienes configurada tu conexión con la base de datos. ¿Deseas configurarla?", "Admin CSY");
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Forms.frmConfigBaseDatos(false)).ShowDialog(this);
                    ConfiguracionBaseDatos();
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "La aplicación se cerrará.", "Admin CSY");
                    Application.Exit();
                }
            }
            else
            {
                Config.servidor = ConfiguracionXML.LeerConfiguración("basedatos", "server");
                Config.baseDatos = ConfiguracionXML.LeerConfiguración("basedatos", "base");
                Config.usuario = ConfiguracionXML.LeerConfiguración("basedatos", "usuario");
                Config.pass = ConfiguracionXML.LeerConfiguración("basedatos", "pass");
            }
            VerificarConexion();
        }

        /// <summary>
        /// Método que verifica la conexión con la base de datos
        /// </summary>
        private void VerificarConexion()
        {
            try
            {
                if (!ConexionBD.Ping())
                {
                    DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "Admin CSY");
                    if (re == System.Windows.Forms.DialogResult.Yes)
                    {
                        (new Forms.frmConfigBaseDatos(true)).ShowDialog(this);
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "Admin CSY");
                if (re == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Forms.frmConfigBaseDatos(true)).ShowDialog(this);
                }
            }
            catch (Exception)
            {
                DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "Admin CSY");
                if (re == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Forms.frmConfigBaseDatos(true)).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Función que carga los datos de la sucursal
        /// </summary>
        private void ConfiguracionSucursal()
        {
            if (ConfiguracionXML.ExisteConfiguracion("sucursal"))
            {
                Config.idSucursal = int.Parse(ConfiguracionXML.LeerConfiguración("sucursal", "id"));
                Config.nombreSucursal = ConfiguracionXML.LeerConfiguración("sucursal", "nombre");
            }
        }
        #endregion

        #region Paso 02
        //Inicializamos las variables de cantidad en las clases
        private void InicializarPropiedades()
        {
            int cant = 0;
            decimal efe = 0M;
            cant = Cliente.Cantidad;
            cant = Cliente.CantidadCredito;
            cant = Cliente.CantidadSinCredito;
            cant = ClienteContacto.Cantidad;
            cant = Proveedor.Cantidad;
            cant = Proveedor.CantidadCredito;
            cant = Proveedor.CantidadSinCredito;
            cant = ProveedorContacto.Cantidad;
            cant = Puesto.Cantidad;
            cant = Sucursal.Cantidad;
            cant = Sucursal.CantidadDomicilios;
            cant = Trabajador.Cantidad;
            cant = Usuario.CantidadUsuarios;
            cant = Usuario.CantidadUsuariosAdministrador;
            cant = Usuario.CantidadUsuariosEncargado;
            cant = Usuario.CantidadUsuariosDesconocido;
            Caja.EstadoC();
            efe = Caja.TotalEfectivo;
        }
        #endregion

        #region Paso 03

        private void CorreoInterno()
        {
            if (!ConfiguracionXML.ExisteConfiguracion("correo"))
            {
                ConfiguracionXML.GuardarConfiguracion("correo", "correo_interno", "");
                ConfiguracionXML.GuardarConfiguracion("correo", "pass_interno", "");
                ConfiguracionXML.GuardarConfiguracion("correo", "puerto_interno", "");
                ConfiguracionXML.GuardarConfiguracion("correo", "host_interno", "");
                Config.correoOrigenInterno = "";
                Config.contraseñaOrigenInterno = "";
                Config.puertoInterno = "";
                Config.hostInterno = "";
            }
            else
            {
                Config.correoOrigenInterno = ConfiguracionXML.LeerConfiguración("correo", "correo_interno");
                Config.contraseñaOrigenInterno = ConfiguracionXML.LeerConfiguración("correo", "pass_interno");
                Config.puertoInterno = ConfiguracionXML.LeerConfiguración("correo", "puerto_interno");
                Config.hostInterno = ConfiguracionXML.LeerConfiguración("correo", "host_interno");
            }
        }

        #endregion

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    MySQL();
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "La aplicación no ha logrado iniciar el servicio de MySQL. La aplicación se cerrará.", "Admin CSY", ex);
                    Application.Exit();
                    return;
                }
                ConfiguracionBaseDatos();
                ConfiguracionSucursal();
                InicializarPropiedades();
                CorreoInterno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            (new frmLogin()).Show();
            this.Close();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            c += 1;
        }
    }
}
