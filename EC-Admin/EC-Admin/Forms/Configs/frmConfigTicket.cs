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
    public partial class frmConfigTicket : Form
    {
        #region Instancia
        private static frmConfigTicket frmInstancia;
        public static frmConfigTicket Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmConfigTicket();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmConfigTicket();
                return frmInstancia;

            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        string impresora, impresoraTickets;

        public frmConfigTicket()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            try
            {
                if (!ConfiguracionXML.ExisteConfiguracion("ticket"))
                    return;
                txtLineaSuperior01.Text = ConfiguracionXML.LeerConfiguración("ticket", "lineaSup01");
                txtLineaSuperior02.Text = ConfiguracionXML.LeerConfiguración("ticket", "lineaSup02");
                txtLineaSuperior03.Text = ConfiguracionXML.LeerConfiguración("ticket", "lineaSup03");
                txtLineaSuperior04.Text = ConfiguracionXML.LeerConfiguración("ticket", "lineaSup04");
                txtLineaSuperior05.Text = ConfiguracionXML.LeerConfiguración("ticket", "lineaSup05");
                txtLineaSuperior06.Text = ConfiguracionXML.LeerConfiguración("ticket", "lineaSup06");
                txtLineaSuperior07.Text = ConfiguracionXML.LeerConfiguración("ticket", "lineaSup07");
                txtLineaInferior01.Text = ConfiguracionXML.LeerConfiguración("ticket", "lineaInf01");
                txtLineaInferior02.Text = ConfiguracionXML.LeerConfiguración("ticket", "lineaInf02");
                txtLineaInferior03.Text = ConfiguracionXML.LeerConfiguración("ticket", "lineaInf03");
                for (int i = 0; i < cboImpresoras.Items.Count; i++)
                {
                    if (cboImpresoras.Items[i].ToString() == ConfiguracionXML.LeerConfiguración("ticket", "impresora"))
                    {
                        cboImpresoras.SelectedIndex = i;
                        break;
                    }
                }
                if (ConfiguracionXML.ExisteConfiguracion("ticket", "impresora_tickets"))
                {
                    for (int i = 0; i < cboImpresoraCodigo.Items.Count; i++)
                    {
                        if (cboImpresoraCodigo.Items[i].ToString() == ConfiguracionXML.LeerConfiguración("ticket", "impresora_tickets"))
                        {
                            cboImpresoraCodigo.SelectedIndex = i;
                            break;
                        }
                    }
                }

                chbImprimir.Checked = bool.Parse(ConfiguracionXML.LeerConfiguración("ticket", "imprimir"));
                chbPreguntar.Checked = bool.Parse(ConfiguracionXML.LeerConfiguración("ticket", "preguntar"));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar la configuración del ticket", "Admin CSY", ex);
            }
        }

        private void GuardarDatos()
        {
            try
            {
                ConfiguracionXML.GuardarConfiguracion("ticket", "lineaSup01", txtLineaSuperior01.Text);
                ConfiguracionXML.GuardarConfiguracion("ticket", "lineaSup02", txtLineaSuperior02.Text);
                ConfiguracionXML.GuardarConfiguracion("ticket", "lineaSup03", txtLineaSuperior03.Text);
                ConfiguracionXML.GuardarConfiguracion("ticket", "lineaSup04", txtLineaSuperior04.Text);
                ConfiguracionXML.GuardarConfiguracion("ticket", "lineaSup05", txtLineaSuperior05.Text);
                ConfiguracionXML.GuardarConfiguracion("ticket", "lineaSup06", txtLineaSuperior06.Text);
                ConfiguracionXML.GuardarConfiguracion("ticket", "lineaSup07", txtLineaSuperior07.Text);
                ConfiguracionXML.GuardarConfiguracion("ticket", "lineaInf01", txtLineaInferior01.Text);
                ConfiguracionXML.GuardarConfiguracion("ticket", "lineaInf02", txtLineaInferior02.Text);
                ConfiguracionXML.GuardarConfiguracion("ticket", "lineaInf03", txtLineaInferior03.Text);
                ConfiguracionXML.GuardarConfiguracion("ticket", "impresora", impresora);
                ConfiguracionXML.GuardarConfiguracion("ticket", "impresora_tickets", impresoraTickets);
                ConfiguracionXML.GuardarConfiguracion("ticket", "imprimir", chbImprimir.Checked.ToString());
                ConfiguracionXML.GuardarConfiguracion("ticket", "preguntar", chbPreguntar.Checked.ToString());
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar la configuración del ticket", "Admin CSY", ex);
            }
        }

        private void frmConfigTicket_Load(object sender, EventArgs e)
        {
            foreach (String imp in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpresoras.Items.Add(imp);
                cboImpresoraCodigo.Items.Add(imp);
            }
            CargarDatos();
        }

        private void cboImpresoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            impresora = cboImpresoras.Items[cboImpresoras.SelectedIndex].ToString();
        }

        private void cboImpresoraCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            impresoraTickets = cboImpresoraCodigo.Items[cboImpresoraCodigo.SelectedIndex].ToString();
        }
    
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboImpresoras.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "¡Debes seleccionar una impresora!", "Admin CSY");
                return;
            }
            GuardarDatos();
            FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha guardado correctamente la información!", "Admin CSY");
            this.Close();
        }
}
}
