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
    public partial class frmEntradaSalida : Form
    {
        MovimientoCaja mc;
        public frmEntradaSalida(MovimientoCaja mc)
        {
            InitializeComponent();
            this.mc = mc;
            switch (mc)
            {
                case MovimientoCaja.Entrada:
                    this.Text = "Entrada";
                    break;
                case MovimientoCaja.Salida:
                    this.Text = "Salida";
                    lblEEfectivo.Text = "Monto a retirar";
                    break;
            }
        }

        private void Insertar()
        {
            try
            {
                Caja c = new Caja();
                c.Descripcion = txtDescripcion.Text;
                if (mc == MovimientoCaja.Entrada)
                    c.Efectivo = decimal.Parse(txtMonto.Text);
                else
                    c.Efectivo = decimal.Parse(txtMonto.Text) * -1M;
                c.IDSucursal = Config.idSucursal;
                c.TipoMovimiento = mc;
                c.Voucher = 0M;
                c.RegistrarMovimiento();
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
            if (txtMonto.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo monto es obligatorio", "Admin CSY");
                return false;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo descripción es obligatorio", "Admin CSY");
                return false;
            }
            return true;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Insertar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha ingresado el movimiento correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al registrar el movimiento. No se ha podido conectar a la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al registrar el movimiento.", "Admin CSY", ex);
                }
            }
        }
    }
}
