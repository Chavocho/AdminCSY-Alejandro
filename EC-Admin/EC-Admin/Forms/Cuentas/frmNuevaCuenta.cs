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
    public partial class frmNuevaCuenta : Form
    {
        public frmNuevaCuenta()
        {
            InitializeComponent();
        }

        private void Insertar()
        {
            try
            {
                Cuenta c = new Cuenta();
                c.Clabe = txtClabe.Text;
                c.Banco = txtBanco.Text;
                c.Beneficiario = txtBeneficiario.Text;
                c.Sucursal = txtSucursal.Text;
                c.NumeroCuenta = txtNumCuenta.Text;
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

        private bool VerificarDatos()
        {
            if (txtClabe.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo clabe es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtClabe);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtClabe);
            }
            if (txtBanco.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo banco es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtBanco);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtBanco);
            }
            if (txtBeneficiario.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo beneficiario es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtBeneficiario);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtBeneficiario);
            }
            /*if (txtSucursal.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo sucursal es obligatorio", "Admin CSY");

                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtSucursal);
            }*/
            /*
            if (txtNumCuenta.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo número de cuenta es obligatorio", "Admin CSY");
                return false;
            }*/
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Insertar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado la cuenta correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear la nueva cuenta. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear la nueva cuenta.", "Admin CSY", ex);
                }
            }
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }
    }
}
