using MySql.Data.MySqlClient;
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
    public partial class frmNuevoProveedor : Form
    {
        TipoPersona t;
        List<int> idSucursal = new List<int>();

        int idCuenta = 0;

        public int IDCuenta
        {
            get { return idCuenta; }
            set
            {
                idCuenta = value;
                DatosCuenta();
            }
        }
        
        public frmNuevoProveedor()
        {
            InitializeComponent();
        }
        private void CargarSucursales()
        {
            try
            {
                string sql = "SELECT id, nombre FROM sucursal WHERE eliminado=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idSucursal.Add((int)dr["id"]);
                    cboSucursal.Items.Add(dr["nombre"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DatosCuenta()
        {
            try
            {
                Cuenta c = new Cuenta(idCuenta);
                c.ObtenerDatos();
                lblCNumCuenta.Text = c.NumeroCuenta;
                lblCBanco.Text = c.Banco;
                lblCBeneficiario.Text = c.Beneficiario;
                lblCSucursal.Text = c.Sucursal;
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de la cuenta. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de la cuenta.", "Admin CSY", ex);
            }
        }

        private void QuitarDatosCuenta()
        {
            idCuenta = 0;
            lblCNumCuenta.Text = "---";
            lblCBanco.Text = "---";
            lblCBeneficiario.Text = "---";
            lblCSucursal.Text = "---";
        }

        private void InsertarProveedor()
        {
            try
            {
                Proveedor p = new Proveedor();
                p.Sucursal = idSucursal[cboSucursal.SelectedIndex];
                p.Cuenta = idCuenta;
                p.Nombre = txtNombre.Text;
                p.RazonSocial = txtRazonSocial.Text;
                p.RFC = txtRFC.Text;
                p.Calle = txtCalle.Text;
                p.NumExt = txtNumExt.Text;
                p.NumInt = txtNumInt.Text;
                p.Colonia = txtColonia.Text;
                p.Ciudad = txtCiudad.Text;
                p.Estado = txtEstado.Text;
                p.CP = txtCP.Text;
                p.Telefono01 = txtTelefono01.Text;
                p.Telefono02 = txtTelefono02.Text;
                p.Lada01 = txtLada01.Text;
                p.Lada02 = txtLada02.Text;
                p.Correo = txtCorreo.Text;
                p.Tipo = t;
                if (txtLimiteCredito.Text.Trim() != "")
                    p.LimiteCredito = decimal.Parse(txtLimiteCredito.Text);
                else
                    p.LimiteCredito = 0M;
                p.Insertar();
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

        private bool VerificarDatos()
        {
            if (cboSucursal.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo sucursal es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(cboSucursal);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(cboSucursal);
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtNombre);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtNombre);
            }

            /*
            if (txtRFC.Text.Trim() != "")
            {
                if (txtRFC.Text.Length < 12)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo RFC debe tener entre 12 o 13 caracteres", "Admin CSY");
                    return false;
                }
            }*/

            if (txtCalle.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo calle es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtCalle);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtCalle);
            }
            if (txtNumInt.Text.Trim() != "" && txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo número exterior debe ser ingresado antes que el número interior", "Admin CSY");
                FuncionesGenerales.ColoresError(txtNumExt);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtNumExt);
            }
            if (txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo número exterior es obligatorio", "Admin CSY");
                FuncionesGenerales.ColoresError(txtNumExt);
                return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtNumExt);
            }
            if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un teléfono", "Admin CSY");
                FuncionesGenerales.ColoresError(txtTelefono01);
                return false;
            }
            else if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() != "")
            {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el primer teléfono antes que el segundo", "Admin CSY");
                    FuncionesGenerales.ColoresError(txtTelefono01);
                    return false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtTelefono01);
                FuncionesGenerales.ColoresBien(txtTelefono02);
            }
            if (txtCorreo.Text != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No se reconoce el correo ingresado como uno válido", "Admin CSY");
                    FuncionesGenerales.ColoresError(txtCorreo);
                    return false;
                }
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtCorreo);
            }
            if (cboTipoCredito.SelectedIndex == 1)
            {
                if (txtLimiteCredito.Text.Trim() == "")
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo límite de crédito es obligatorio", "Admin CSY");
                    FuncionesGenerales.ColoresError(txtLimiteCredito);
                    return false;
                }
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtLimiteCredito);
            }

            return true;
        }

        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void cboTipoCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoCredito.SelectedIndex)
            {
                case 0:
                    lblELimiteCredito.Visible = txtLimiteCredito.Visible = false;
                    t = TipoPersona.SinCredito;
                    break;
                case 1:
                    lblELimiteCredito.Visible = txtLimiteCredito.Visible = true;
                    t = TipoPersona.Credito;
                    break;
            }
            txtLimiteCredito.Text = "0.00";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    InsertarProveedor();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el proveedor correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el proveedor. No se ha podido conectar a la base de datos", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear el proveedor.", "Admin CSY", ex);
                }
            }
        }

        private void frmNuevoProveedor_Load(object sender, EventArgs e)
        {
            CargarSucursales();
            cboTipoCredito.SelectedIndex = 0;
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            (new frmAsignarCuenta(this)).ShowDialog(this);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            QuitarDatosCuenta();
        }

        private void txtTelefonos_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

    }
}
