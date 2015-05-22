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
    public partial class frmCobrar : Form
    {
        int id;
        frmPOS frm;
        decimal total;
        TipoPago t;

        public frmCobrar(frmPOS frm, int id, decimal total)
        {
            InitializeComponent();
            this.frm = frm;
            this.id = id;
            this.total = total;
            lblTotal.Text = total.ToString("C2");
            cboTipoPago.SelectedIndex = 0;
            CalcularCambio();
        }

        private void CalcularCambio()
        {
            decimal efectivo, cambio;
            decimal.TryParse(txtEfectivo.Text, out efectivo);
            cambio = total - efectivo;
            if (cambio > 0)
            {
                lblECambio.Text = "Falta:";
                lblECambio.Location = new Point(30, 121);
                lblCambio.BackColor = Colores.Error;
                lblCambio.Text = cambio.ToString("C2");
            }
            else
            {
                lblECambio.Text = "Cambio:";
                lblECambio.Location = new Point(10, 121);
                lblCambio.BackColor = Colores.Exito;
                lblCambio.Text = (cambio * -1).ToString("C2");
            }
        }

        private void QuitarEfectivo()
        {
            lblEEfectivo.Enabled = false;
            txtEfectivo.Enabled = false;
            txtEfectivo.Text = "0.00";
            lblCambio.Text = "$0.00";
            lblCambio.BackColor = Colores.Exito;
            lblECambio.Text = "Cambio:";
            lblECambio.Location = new Point(206, 102);
        }

        private void MovimientoCaja()
        {
            try
            {
                decimal efe;
                decimal.TryParse(txtEfectivo.Text, out efe);
                Caja c = new Caja();
                c.Descripcion = "VENTA MOSTRADOR";
                c.Efectivo = efe;
                if (cboTipoPago.SelectedIndex == 1 || cboTipoPago.SelectedIndex == 2)
                {
                    c.Voucher = total;
                }
                else
                {
                    c.Voucher = 0M;
                }
                c.TipoMovimiento = EC_Admin.MovimientoCaja.Entrada;
                c.IDSucursal = Config.idSucursal;
                c.RegistrarMovimiento();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ImprimirTicket()
        {
            try
            {
                Ticket t = new Ticket();
                t.TicketVenta(id);
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket.", "Admin CSY", ex);
            }
        }

        private void frmCobrar_Load(object sender, EventArgs e)
        {
            txtEfectivo.Select();
        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoPago.SelectedIndex)
            {
                case 0:
                    lblEEfectivo.Enabled = true;
                    txtEfectivo.Enabled = true;
                    txtDatos.Visible = lblEDatos.Visible = false;
                    CalcularCambio();
                    t = TipoPago.Efectivo;
                    break;
                //case 1:
                //    QuitarEfectivo();
                //    lblEDatos.Text = "Núm. de cheque";
                //    txtDatos.Visible = lblEDatos.Visible = true;
                //    break;
                case 1:
                    QuitarEfectivo();
                    lblEDatos.Text = "Núm. de tarjeta";
                    txtDatos.Visible = lblEDatos.Visible = true;
                    t = TipoPago.Crédito;
                    break;
                case 2:
                    QuitarEfectivo();
                    lblEDatos.Text = "Núm. de tarjeta";
                    txtDatos.Visible = lblEDatos.Visible = true;
                    t = TipoPago.Débito;
                    break;
                //case 4:
                //    QuitarEfectivo();
                //    txtDatos.Visible = lblEDatos.Visible = false;
                //    break;
            }
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (lblCambio.BackColor == Colores.Exito)
            {
                try
                {
                    if (txtDatos.Visible)
                    {
                        if (txtDatos.Text.Trim() == "")
                        {
                            FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el número de la tarjeta", "Admin CSY");
                            return;
                        }
                    }
                    frm.GuardarVenta(false, t);
                    MovimientoCaja();
                    if (FuncionesGenerales.ImprimirTicket(this, "¿Desea imprimir el ticket de ésta venta?"))
                    {
                        ImprimirTicket();
                    }
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha guardado los datos de la venta correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar los datos de la venta. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar los datos de la venta.", "Admin CSY", ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El efectivo debe ser mayor o igual al total", "Admin CSY");
            }
        }
    }
}
