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
    public partial class frmAbrirCaja : Form
    {
        public frmAbrirCaja()
        {
            InitializeComponent();
            lblEfeCaja.Text = Caja.TotalEfectivo.ToString("C2");
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal efe, tot = 0M;
            decimal.TryParse(txtEfectivo.Text, out efe);
            tot = efe + Caja.TotalEfectivo;
            lblTotal.Text = tot.ToString("C2");
        }

        private void Registrar()
        {
            decimal efe;
            decimal.TryParse(txtEfectivo.Text, out efe);
            Caja c = new Caja();
            c.Descripcion = "APERTURA DE CAJA";
            c.Efectivo = efe;
            c.IDSucursal = Config.idSucursal;
            c.TipoMovimiento = MovimientoCaja.Entrada;
            c.Voucher = 0M;
            c.RegistrarMovimiento();
            Caja.CambiarEstadoCaja(true);
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
                FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha abierto la caja correctamente!", "Admin CSY");
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al abrir la caja. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al abrir la caja.", "Admin CSY", ex);
            }
        }
    }
}
