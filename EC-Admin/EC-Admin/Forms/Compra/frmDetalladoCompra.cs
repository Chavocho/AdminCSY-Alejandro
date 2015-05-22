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
    public partial class frmDetalladoCompra : Form
    {
        int id;
        List<int> idP = new List<int>();
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmDetalladoCompra(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Cargar()
        {
            try
            {
                Compra c = new Compra(id);
                c.ObtenerDatos();
                lblFecha.Text = c.CreateTime.ToString("dd") + " de " + c.CreateTime.ToString("MMMM") + " del " + c.CreateTime.ToString("yyyy") + " " + c.CreateTime.ToString("hh:mm tt");
                switch (c.Tipo)
                {
                    case TipoPago.Efectivo:
                        lblTipoPago.Text = "Efectivo";
                        break;
                    case TipoPago.Cheque:
                        lblTipoPago.Text = "Cheque";
                        break;
                    case TipoPago.Crédito:
                        lblTipoPago.Text = "Tarjeta de crédito";
                        break;
                    case TipoPago.Débito:
                        lblTipoPago.Text = "Tarjeta de débito";
                        break;
                    case TipoPago.Transferencia:
                        lblTipoPago.Text = "Transferencia";
                        break;
                }
                if (c.Remision)
                {
                    lblRemision.Text = "Si";
                    lblFactura.Text = "No";
                    lblFolioRemision.Text = c.FolioRemision;
                }
                else if (c.Factura)
                {
                    lblFactura.Text = "Si";
                    lblRemision.Text = "No";
                    lblFolioFactura.Text = c.FolioFactura;
                }
                lblSubtotal.Text = c.Subtotal.ToString("C2");
                lblImpuesto.Text = c.Impuesto.ToString("C2");
                lblDescuento.Text = c.Descuento.ToString("C2");
                lblTotal.Text = c.Total.ToString("C2");
                CargarDetallada(c);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar las compras. No se ha podido conectar con la base de datos. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                Cerrar();
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar las compras. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
        }

        private void CargarDetallada(Compra c)
        {
            try
            {
                int y = 10;
                int saltoPeque = 25;
                int saltoGrande = 115;
                int posPcb = 10;
                int posNom = 120;
                int posCan = (pnlDetallada.Width / 3) * 2 - 100;
                int posCos = (pnlDetallada.Width / 3) * 2;
                int posDes = (pnlDetallada.Width / 3) * 2 + 100;
                int posUni = (pnlDetallada.Width / 3) * 2 + 230;

                Label lblENombreProd = new Label();
                Label lblECantProd = new Label();
                Label lblECostoProd = new Label();
                Label lblEDescuentoProd = new Label();
                Label lblEUnidadProd = new Label();

                //Añadimos los labels de titulo
                LabelTitulo(ref lblENombreProd, "Nombre", posNom, y);
                LabelTitulo(ref lblECantProd, "Cantidad", posCan, y);
                LabelTitulo(ref lblECostoProd, "Costo", posCos, y);
                LabelTitulo(ref lblEDescuentoProd, "Descuento", posDes, y);
                LabelTitulo(ref lblEUnidadProd, "Unidad", posUni, y);
                pnlDetallada.Controls.Add(lblENombreProd);
                pnlDetallada.Controls.Add(lblECantProd);
                pnlDetallada.Controls.Add(lblECostoProd);
                pnlDetallada.Controls.Add(lblEDescuentoProd);
                pnlDetallada.Controls.Add(lblEUnidadProd);
                y += saltoPeque;

                Label lblNombreProd;
                Label lblCantProd;
                Label lblCostoProd;
                Label lblDescuentoProd;
                Label lblUnidadProd;
                PictureBox pcbImagen;
                for (int i = 0; i < c.IDProductos.Count; i++)
                {
                    lblNombreProd = new Label();
                    lblCantProd = new Label();
                    lblCostoProd = new Label();
                    lblDescuentoProd = new Label();
                    lblUnidadProd = new Label();
                    pcbImagen = new PictureBox();

                    Image img = Producto.Imagen01Producto(c.IDProductos[i]);
                    string nomProd = Producto.NombreProducto(c.IDProductos[i]); 
                    LabelDetalles(ref lblNombreProd, nomProd, posNom, y);
                    LabelDetalles(ref lblCantProd, c.Cantidad[i].ToString("0.00"), posCan, y);
                    LabelDetalles(ref lblCostoProd, c.Precio[i].ToString("C2"), posCos, y);
                    LabelDetalles(ref lblDescuentoProd, c.DescuentoProducto[i].ToString("C2"), posDes, y);
                    switch (c.Unidad[i])
                    {
                        case Unidades.Gramo:
                            LabelDetalles(ref lblUnidadProd, "Gramo", posUni, y);
                            break;
                        case Unidades.Kilogramo:
                            LabelDetalles(ref lblUnidadProd, "Kilogramo", posUni, y);
                            break;
                        case Unidades.Mililitro:
                            LabelDetalles(ref lblUnidadProd, "Mililitro", posUni, y);
                            break;
                        case Unidades.Litro:
                            LabelDetalles(ref lblUnidadProd, "Litro", posUni, y);
                            break;
                        case Unidades.Pieza:
                            LabelDetalles(ref lblUnidadProd, "Pieza", posUni, y);
                            break;
                    }

                    if (img != null)
                    {
                        PictureBoxDetalles(ref pcbImagen, img, posPcb, y);
                        pnlDetallada.Controls.Add(pcbImagen);
                        pnlDetallada.Controls.Add(lblNombreProd);
                        pnlDetallada.Controls.Add(lblCantProd);
                        pnlDetallada.Controls.Add(lblCostoProd);
                        pnlDetallada.Controls.Add(lblDescuentoProd);
                        pnlDetallada.Controls.Add(lblUnidadProd);
                        y += saltoGrande;
                    }
                    else
                    {
                        pnlDetallada.Controls.Add(lblNombreProd);
                        pnlDetallada.Controls.Add(lblCantProd);
                        pnlDetallada.Controls.Add(lblCostoProd);
                        pnlDetallada.Controls.Add(lblDescuentoProd);
                        pnlDetallada.Controls.Add(lblUnidadProd);
                        y += (saltoPeque * 2);
                    }
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de la compra.", "Admin CSY", ex);
            }
        }

        private void LabelTitulo(ref Label lbl, string text, int x, int y)
        {
            LabelTitulo(ref lbl, text, new Point(x, y));
        }

        private void LabelTitulo(ref Label lbl, string text, Point loc)
        {
            lbl.Font = new Font("Corbel", 13F, FontStyle.Bold);
            lbl.ForeColor = Colores.Obscuro;
            lbl.Location = loc;
            lbl.Text = text;
        }

        private void LabelDetalles(ref Label lbl, string text, int x, int y)
        {
            LabelDetalles(ref lbl, text, new Point(x, y));
        }

        private void LabelDetalles(ref Label lbl, string text, Point loc)
        {
            lbl.Font = new Font("Corbel", 13F, FontStyle.Regular);
            lbl.ForeColor = Colores.ObscuroClaro;
            lbl.Location = loc;
            lbl.Text = text;
        }

        private void PictureBoxDetalles(ref PictureBox pcb, Image img, int x, int y)
        {
            PictureBoxDetalles(ref pcb, img, new Point(x, y));
        }

        private void PictureBoxDetalles(ref PictureBox pcb, Image img, Point loc)
        {
            pcb.SizeMode = PictureBoxSizeMode.Zoom;
            pcb.BackColor = Colores.ObscuroClaro;
            pcb.Image = img;
            pcb.Location = loc;
            pcb.Size = new Size(100, 100);
        }

        private void frmDetalladoCompra_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
