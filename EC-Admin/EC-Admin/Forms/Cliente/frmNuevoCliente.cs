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
    public partial class frmNuevoCliente : Form
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
        
        public frmNuevoCliente()
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

        private void InsertarCliente()
        {
            try
            {
                Cliente c = new Cliente();
                c.Sucursal = idSucursal[cboSucursal.SelectedIndex];
                c.Cuenta = idCuenta;
                c.Nombre = txtNombre.Text;
                c.RazonSocial = txtRazonSocial.Text;
                c.RFC = txtRFC.Text;
                c.Calle = txtCalle.Text;
                c.NumExt = txtNumExt.Text;
                c.NumInt = txtNumInt.Text;
                c.Colonia = txtColonia.Text;
                c.Ciudad = txtCiudad.Text;
                c.Estado = txtEstado.Text;
                c.CP = txtCP.Text;
                c.Telefono01 = txtTelefono01.Text;
                c.Telefono02 = txtTelefono02.Text;
                c.Lada01 = txtLada01.Text;
                c.Lada02 = txtLada02.Text;
                c.Correo = txtCorreo.Text;
                c.Tipo = t;
                c.LimiteCredito = decimal.Parse(txtLimiteCredito.Text);
                c.Insertar();
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
            bool resultado = true;
            if (cboSucursal.SelectedIndex < 0)
            {
                FuncionesGenerales.ColoresError(ref cboSucursal);
                resultado = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(ref cboSucursal);
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(ref txtNombre);
                resultado = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(ref txtNombre);
            }
            if (txtRFC.Text.Trim() != "")
            {
                if (txtRFC.Text.Length < 12)
                {
                    FuncionesGenerales.ColoresError(ref txtRFC);
                    resultado = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(ref txtRFC);
                }
            }
            if (txtCalle.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(ref txtCalle);
                resultado = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(ref txtCalle);
            }
            if (txtNumInt.Text.Trim() != "" && txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(ref txtNumExt);
                resultado = false;
            }
            if (txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(ref txtNumExt);
                resultado = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(ref txtNumExt);
            }
            if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(ref txtTelefono01);
                resultado = false;
            }
            else
            {
                if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() != "")
                {
                    FuncionesGenerales.ColoresError(ref txtTelefono01);
                    resultado = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(ref txtTelefono01);
                }
            }
            if (txtCorreo.Text != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.ColoresError(ref txtCorreo);
                    resultado = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(ref txtCorreo);
                }
            }
            if (cboTipoCredito.SelectedIndex == 1)
            {
                if (txtLimiteCredito.Text.Trim() == "")
                {
                    FuncionesGenerales.ColoresError(ref txtLimiteCredito);
                    resultado = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(ref txtLimiteCredito);
                }
            }
            return resultado;
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
                    InsertarCliente();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el cliente con éxito!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el cliente. No se ha podido conectar a la base de datos", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear el cliente.", "Admin CSY", ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Los campos en rojo son obligatorios", "Admin CSY");
            }
        }

        private void frmNuevoCliente_Load(object sender, EventArgs e)
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
