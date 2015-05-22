using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin.Forms
{
    public partial class frmDatosContactoCliente : Form
    {
        ClienteContacto c;
        bool editar = false;

        public frmDatosContactoCliente(ClienteContacto c)
        {
            InitializeComponent();
            this.c = c;
        }

        public frmDatosContactoCliente(int id, ClienteContacto c)
        {
            InitializeComponent();
            this.c = c;
            c.ID = id;
            editar = true;
        }

        private void ObtenerDatosContacto()
        {
            try
            {
                c.ObtenerDatosContacto();
                txtNombre.Text = c.Nombre;
                txtApellidos.Text = c.Apellidos;
                txtLada01.Text = c.Lada01;
                txtTelefono01.Text = c.Telefono01;
                txtLada02.Text = c.Lada02;
                txtTelefono02.Text = c.Telefono02;
                txtExt.Text = c.Extension;
                txtCelular.Text = c.Celular;
                txtCorreo.Text = c.Correo;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Insertar()
        {
            try
            {
                c.Nombre = txtNombre.Text;
                c.Apellidos = txtApellidos.Text;
                c.Lada01 = txtLada01.Text;
                c.Lada02 = txtLada02.Text;
                c.Telefono01 = txtTelefono01.Text;
                c.Telefono02 = txtTelefono02.Text;
                c.Extension = txtExt.Text;
                c.Celular = txtCelular.Text;
                c.Correo = txtCorreo.Text;
                c.Insertar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Editar()
        {
            try
            {
                c.Nombre = txtNombre.Text;
                c.Apellidos = txtApellidos.Text;
                c.Lada01 = txtLada01.Text;
                c.Lada02 = txtLada02.Text;
                c.Telefono01 = txtTelefono01.Text;
                c.Telefono02 = txtTelefono02.Text;
                c.Extension = txtExt.Text;
                c.Celular = txtCelular.Text;
                c.Correo = txtCorreo.Text;
                c.Editar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerificarDatos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio", "Admin CSY");
                return false;
            }
            if (txtApellidos.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo apellidos es obligatorio", "Admin CSY");
                return false;
            }
            if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un teléfono", "Admin CSY");
                return false;
            }
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No se reconoce el correo ingresado como uno válido", "Admin CSY");
                    return false;
                }
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                if (!editar)
                {
                    try
                    {
                        Insertar();
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado correctamente el contacto!", "Admin CSY");
                        this.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el contacto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear el contacto.", "Admin CSY", ex);
                    }
                }
                else
                {
                    try
                    {
                        Editar();
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado correctamente el contacto!", "Admin CSY");
                        this.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el contacto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al modificar el contacto.", "Admin CSY", ex);
                    }
                }
            }
        }

        private void frmDatosContactoCliente_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                try
                {
                    ObtenerDatosContacto();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener los datos del contacto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al obtener los datos del contacto.", "Admin CSY", ex);
                }
            }
        }
    }
}
