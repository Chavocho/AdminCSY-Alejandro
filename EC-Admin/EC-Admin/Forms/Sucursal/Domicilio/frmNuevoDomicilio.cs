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
    public partial class frmNuevoDomicilio : Form
    {
        public frmNuevoDomicilio()
        {
            InitializeComponent();
        }

        private void Insertar()
        {
            try
            {
                Sucursal s = new Sucursal();
                s.CalleFiscal = txtCalle.Text;
                s.NumeroExteriorFiscal = txtNumExt.Text;
                s.NumeroInteriorFiscal = txtNumInt.Text;
                s.CPFiscal = txtCP.Text;
                s.ColoniaFiscal = txtColonia.Text;
                s.CiudadFiscal = txtCiudad.Text;
                s.EstadoFiscal = txtEstado.Text;
                s.InsertarDireccion();
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
            if (txtCalle.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo calle es obligatorio", "Admin CSY");
                return false;
            }
            if (txtNumInt.Text != "" && txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Se debe ingresar el campo número exterior antes que el número interior", "Admin CSY");
                return false;
            }
            if (txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo número exterior es obligatorio", "Admin CSY");
                return false;
            }
            if (txtCP.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo código postal es obligatorio", "Admin CSY");
                return false;
            }
            if (txtColonia.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo colonia es obligatorio", "Admin CSY");
                return false;
            }
            if (txtCiudad.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo ciudad es obligatorio", "Admin CSY");
                return false;
            }
            if (txtEstado.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo estado es obligatorio", "Admin CSY");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Insertar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el domicilio fiscal correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el domicilio. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear el domicilio.", "Admin CSY", ex);
                }
            }
        }
    }
}
