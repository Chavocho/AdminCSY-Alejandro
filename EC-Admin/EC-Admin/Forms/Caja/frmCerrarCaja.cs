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
    public partial class frmCerrarCaja : Form
    {
        public frmCerrarCaja()
        {
            InitializeComponent();
            lblEfeCaja.Text = Caja.TotalEfectivo.ToString("C2");
            lblVouchers.Text = Caja.TotalVouchers.ToString("C2");
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal efe, tot = 0M;
            decimal.TryParse(txtEfectivo.Text, out efe);
            tot = Caja.TotalEfectivo - efe;
            lblTotal.Text = tot.ToString("C2");
        }

        private void Registrar()
        {
            decimal efe;
            decimal.TryParse(txtEfectivo.Text, out efe);
            Caja c = new Caja();
            c.Descripcion = "CIERRE DE CAJA";
            c.Efectivo = decimal.Negate(efe);
            c.IDSucursal = Config.idSucursal;
            c.TipoMovimiento = MovimientoCaja.Entrada;
            c.Voucher = decimal.Negate(Caja.TotalVouchers);
            c.RegistrarMovimiento();
            Caja.CambiarEstadoCaja(false);
        }

        private void Imprimir()
        {
            try
            {
                Ticket t = new Ticket();
                t.ImprimirCaja(true);
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket. No se ha podido conectar a la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket.", "Admin CSY", ex);
            }
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Registrar();
                FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha cerrado la caja correctamente!", "Admin CSY");
                if (FuncionesGenerales.ImprimirTicket(this, "¿Deseas imprimir el ticket de corte de caja?"))
                {
                    Imprimir();
                }
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cerrar la caja. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cerrar la caja.", "Admin CSY", ex);
            }
        }
    }
}
