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
    public partial class frmEditarCliente : Form
    {
        int idC = 0;
        Cliente c;
        TipoPersona t;
        List<int> idSucursal = new List<int>();

        private int idCuenta;

        public int IDCuenta
        {
            get { return idCuenta; }
            set
            {
                idCuenta = value;
                DatosCuenta();
            }
        }

        public frmEditarCliente(int id)
        {
            InitializeComponent();
            c = new Cliente(id);
            //Este evento sucede cuando se modifica la base de datos de contactos
            c.Contacto.ContactDataBaseModified += new EventHandler(Contact_Modified);
        }

        private void CargarSucursales()
        {
            try
            {
                string sql = "SELECT id, nombre FROM sucursal";
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

        private int Posicion(List<int> l, int id)
        {
            int pos = -1;
            try
            {
                for (int i = 0; i < l.Count; i++)
                {
                    if (l[i] == id)
                    {
                        pos = i;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pos;
        }

        private void MostrarDatos()
        {
            try
            {
                c.ObtenerDatos();
                cboSucursal.SelectedIndex = Posicion(idSucursal, c.Sucursal);
                IDCuenta = c.Cuenta;
                txtNombre.Text = c.Nombre;
                txtRazonSocial.Text = c.RazonSocial;
                txtRFC.Text = c.RFC;
                txtCalle.Text = c.Calle;
                txtNumExt.Text = c.NumExt;
                txtNumInt.Text = c.NumInt;
                txtColonia.Text = c.Colonia;
                txtCiudad.Text = c.Ciudad;
                txtEstado.Text = c.Estado;
                txtCP.Text = c.CP.ToString();
                txtTelefono01.Text = c.Telefono01;
                txtTelefono02.Text = c.Telefono02;
                txtLada01.Text = c.Lada01;
                txtLada02.Text = c.Lada02;
                txtCorreo.Text = c.Correo;
                t = c.Tipo;
                switch (c.Tipo)
                {
                    case TipoPersona.Credito:
                        cboTipoCredito.SelectedIndex = 1;
                        break;
                    case TipoPersona.SinCredito:
                        cboTipoCredito.SelectedIndex = 0;
                        break;
                }
                txtLimiteCredito.Text = c.LimiteCredito.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarContactos()
        {
            dgvContactos.Rows.Clear();
            ClienteContacto cc = c.Contacto;
            for (int i = 0; i < cc.IDCS.Count; i++)
            {
                string telefonos = "", correo = "";
                if (cc.TelefonoContactos01[i] != "" && cc.TelefonoContactos02[i] != "")
                {
                    if (cc.LadaContactos01[i] != "")
                    {
                        telefonos += cc.LadaContactos01[i] + " " + cc.TelefonoContactos01[i];
                    }
                    else
                    {
                        telefonos += cc.TelefonoContactos01[i];
                    }
                    if (cc.LadaContactos02[i] != "")
                    {
                        telefonos += ", " + cc.LadaContactos02[i] + " " + cc.TelefonoContactos02[i];
                    }
                    else
                    {
                        telefonos += ", " + cc.TelefonoContactos02[i];
                    }
                }
                else if (cc.TelefonoContactos01[i] != "")
                {
                    if (cc.LadaContactos01[i] != "")
                    {
                        telefonos += cc.LadaContactos01[i] + " " + cc.TelefonoContactos01[i];
                    }
                    else
                    {
                        telefonos += cc.TelefonoContactos01[i];
                    }
                }
                else if (cc.TelefonoContactos02[i] != "")
                {
                    if (cc.LadaContactos02[i] != "")
                    {
                        telefonos += cc.LadaContactos02[i] + " " + cc.TelefonoContactos02[i];
                    }
                    else
                    {
                        telefonos += cc.TelefonoContactos02[i];
                    }
                }
                if (cc.CorreoContactos[i] != "")
                {
                    correo = cc.CorreoContactos[i];
                }
                else
                {
                    correo = "Sin información";
                }
                dgvContactos.Rows.Add(new object[] { cc.IDCS[i], cc.NombreContactos[i], telefonos, correo });
            }
            dgvContactos_RowEnter(dgvContactos, new DataGridViewCellEventArgs(0, 0));
        }

        private void Editar()
        {
            try
            {
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
                c.Editar();
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
                FuncionesGenerales.ColoresError(cboSucursal);
                resultado = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(cboSucursal);
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtNombre);
                resultado = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtNombre);
            }
            if (txtRFC.Text.Trim() != "")
            {
                if (txtRFC.Text.Length < 12)
                {
                    FuncionesGenerales.ColoresError(txtRFC);
                    resultado = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtRFC);
                }
            }
            if (txtCalle.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtCalle);
                resultado = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtCalle);
            }
            if (txtNumInt.Text.Trim() != "" && txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtNumExt);
                resultado = false;
            }
            if (txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtNumExt);
                resultado = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtNumExt);
            }
            if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtTelefono01);
                resultado = false;
            }
            else
            {
                if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() != "")
                {
                    FuncionesGenerales.ColoresError(txtTelefono01);
                    resultado = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtTelefono01);
                }
            }
            if (txtCorreo.Text != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.ColoresError(txtCorreo);
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No se reconoce el correo ingresado como uno válido", "Admin CSY");
                    resultado = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtCorreo);
                }
            }
            if (cboTipoCredito.SelectedIndex == 1)
            {
                if (txtLimiteCredito.Text.Trim() == "")
                {
                    FuncionesGenerales.ColoresError(txtLimiteCredito);
                    resultado = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtLimiteCredito);
                }
            }
            return resultado;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void txtLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
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
                    Editar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado el cliente correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el cliente. No se ha podido conectar a la base de datos", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al modificar el cliente.", "Admin CSY", ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Los campos en rojo son obligatorios", "Admin CSY");
            }
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            CargarSucursales();
            MostrarDatos();
            MostrarContactos();
        }

        private void lblEDatosCliente_Click(object sender, EventArgs e)
        {
            lblEDatosCliente.ForeColor = Colores.Claro;
            lblEDatosCliente.BackColor = Colores.Obscuro;
            lblEContactos.ForeColor = Colores.Obscuro;
            lblEContactos.BackColor = Colores.Claro;
            pnlContactos.Visible = false;
            pnlDatos.Visible = true;
        }

        private void lblEContactos_Click(object sender, EventArgs e)
        {
            lblEDatosCliente.BackColor = Colores.Claro;
            lblEDatosCliente.ForeColor = Colores.Obscuro;
            lblEContactos.BackColor = Colores.Obscuro;
            lblEContactos.ForeColor = Colores.Claro;
            pnlContactos.Visible = true;
            pnlDatos.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmDatosContactoCliente(c.Contacto)).ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow != null)
            {
                (new frmDatosContactoCliente(idC, c.Contacto)).ShowDialog(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow != null)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente deseas eliminar a " + dgvContactos[1, dgvContactos.CurrentRow.Index].Value.ToString() + "?", "") == System.Windows.Forms.DialogResult.Yes)
                {
                    c.Contacto.Eliminar(idC);
                }
            }
        }

        private void dgvContactos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContactos.CurrentRow != null)
                idC = (int)dgvContactos[0, e.RowIndex].Value;
            else
                idC = 0;
        }

        private void Contact_Modified(object sender, EventArgs e)
        {
            MostrarContactos();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            QuitarDatosCuenta();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            (new frmAsignarCuenta(this)).ShowDialog(this);
        }

        private void txtTelefonos_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }
    }
}
