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
    public partial class frmDevolucionCantidadProductos : Form
    {
        int cant;
        bool cerroBien = false;

        public frmDevolucionCantidadProductos()
        {
            InitializeComponent();
        }

        private bool VerificarDatos()
        {
            if (nudCantidad.Value > cant)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No puedes agregar más productos a la devolución qué los que hay en la venta.", "Admin CSY");
                return false;
            }
            return true;
        }

        public int Cantidad(int cantidad)
        {
            cant = cantidad;
            if (!this.Visible)
                this.ShowDialog();
            this.Close();
            return (int)nudCantidad.Value;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                cerroBien = true;
                Cantidad(cant);
            }
        }

        private void frmDevolucionCantidadProductos_Load(object sender, EventArgs e)
        {
            nudCantidad.Value = cant;
        }

        private void frmDevolucionCantidadProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerroBien)
            {
                nudCantidad.Minimum = 0M;
                nudCantidad.Value = 0M;
            }
        }
    }
}
