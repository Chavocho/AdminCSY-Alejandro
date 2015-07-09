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
    public partial class frmConfigGeneral : Form
    {
        #region Instancia
        private static frmConfigGeneral frmInstancia;
        public static frmConfigGeneral Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmConfigGeneral();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmConfigGeneral();
                return frmInstancia;

            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmConfigGeneral()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            if (ConfiguracionXML.ExisteConfiguracion("POS"))
            {
                txtCantMedioMayoreo.Text = ConfiguracionXML.LeerConfiguración("POS", "cant_medio_mayoreo");
                txtCantMayoreo.Text = ConfiguracionXML.LeerConfiguración("POS", "cant_mayoreo");
                txtIVA.Text = ConfiguracionXML.LeerConfiguración("POS", "IVA");
            }
        }

        private void Guardar()
        {
            ConfiguracionXML.GuardarConfiguracion("POS", "cant_medio_mayoreo", txtCantMedioMayoreo.Text);
            ConfiguracionXML.GuardarConfiguracion("POS", "cant_mayoreo", txtCantMayoreo.Text);
            ConfiguracionXML.GuardarConfiguracion("POS", "IVA", txtIVA.Text);
            Config.cantMedioMayoreo = int.Parse(txtCantMedioMayoreo.Text);
            Config.cantMayoreo = int.Parse(txtCantMayoreo.Text);
            Config.iva = decimal.Parse(txtIVA.Text);
        }

        private bool VerificarCampos()
        {
            bool res = true;
            if (int.Parse(txtCantMedioMayoreo.Text) <= 0 && int.Parse(txtCantMayoreo.Text) <= 0)
            {
                FuncionesGenerales.ColoresError(txtCantMayoreo);
                FuncionesGenerales.ColoresError(txtCantMedioMayoreo);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtCantMayoreo);
                FuncionesGenerales.ColoresBien(txtCantMedioMayoreo);
                if (txtCantMayoreo.Text.Trim() == "")
                {
                    txtCantMayoreo.Text = "0";
                }
                if (txtCantMedioMayoreo.Text.Trim() == "")
                {
                    txtCantMedioMayoreo.Text = "0";
                }
            }
            if (txtIVA.Text.Trim() == "")
            {
                txtIVA.Text = "0";
            }
            return res;
        }

        private void frmConfigGeneral_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar la configuración", "Admin CSY", ex);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarCampos())
                {
                    Guardar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha guardado correctamente la configuración!", "Admin CSY");
                    this.Close();
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "¡Los campos en rojo son obligatorios!", "Admin CSY");
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar la configuración", "Admin CSY", ex);
            }
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void txtNumerosDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }
    }
}
