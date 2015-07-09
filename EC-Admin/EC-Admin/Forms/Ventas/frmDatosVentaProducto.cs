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
    public partial class frmDatosVentaProducto : Form
    {
        frmPOS frm = null;
        frmNuevaCompra frmC = null;
        frmCotizacion frmCT = null;

        public frmDatosVentaProducto(frmPOS frm, string nombre, int cant, decimal descuento)
        {
            InitializeComponent();
            this.Text += nombre;
            nudCant.Value = cant;
            nudDescuento.Value = descuento;
            this.frm = frm;
            nudCant.Select();
        }

        public frmDatosVentaProducto(frmNuevaCompra frm, string nombre, int cant, decimal descuento)
        {
            InitializeComponent();
            this.frmC = frm;
            this.Text += nombre;
            nudCant.Value = cant;
            nudDescuento.Value = descuento;
            nudCant.Select();
        }

        public frmDatosVentaProducto(frmCotizacion frm, string nombre, int cant, decimal descuento)
        {
            InitializeComponent();
            this.frmCT = frm;
            this.Text += nombre;
            nudCant.Value = cant;
            nudDescuento.Value = descuento;
            nudCant.Select();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.ModificarProducto(int.Parse(nudCant.Value.ToString()), nudDescuento.Value);
            else if (frmC != null)
                frmC.ModificarProducto(int.Parse(nudCant.Value.ToString()), nudDescuento.Value);
            else if (frmCT != null)
                frmCT.ModificarProducto(int.Parse(nudCant.Value.ToString()), nudDescuento.Value);
            this.Close();
        }
    }
}
