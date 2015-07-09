using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EC_Admin.Forms
{
    public partial class frmDetalleTraspaso : Form
    {
        Traspaso t;
        public frmDetalleTraspaso(int id)
        {
            InitializeComponent();
            t = new Traspaso(id);
        }

        private void Cargar()
        {
            try
            {
                t.ObtenerDatos();
                lblSucursalOrigen.Text = Sucursal.NombreSucursal(t.IDSucursalOrigen);
                lblSucursalDestino.Text = Sucursal.NombreSucursal(t.IDSucursalDestino);
                lblSucursalPeticion.Text = Sucursal.NombreSucursal(t.IDSucursalSolicito);
                lblDescripcion.Text = t.Descripcion;
                switch (t.Estado)
                {
                    case EstadoTraspaso.Recibida:
                        lblEstado.Text = "Recibida en destino";
                        pnlDetallada.Height = this.Height - pnlTraspaso.Height;
                        break;
                    case EstadoTraspaso.Aceptada:
                        lblEstado.Text = "Aceptada";
                        break;
                    case EstadoTraspaso.Espera:
                        lblEstado.Text = "En espera de aprobación";
                        break;
                    case EstadoTraspaso.Rechazada:
                        lblEstado.Text = "Rechazada";
                        pnlDetallada.Height = this.Height - pnlTraspaso.Height;
                        break;
                }
                CargarDetallada();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarDetallada()
        {
            try
            {
                int y = 10;
                int saltoPeque = 25;
                int totProd = 0, prodDif = 0;
                int posCod = 10;
                int posNom = 150;
                int posMar = 350;
                int posDes = (pnlDetallada.Width / 3) - 100;
                int posCan = (pnlDetallada.Width / 3) * 2 + 100;
                int posTot = (pnlDetallada.Width / 3);

                Label lblECodProd = new Label();
                Label lblENombreProd = new Label();
                Label lblEMarca = new Label();
                Label lblEDescripcion = new Label();
                Label lblECantProd = new Label();

                //Añadimos los labels de titulo
                LabelTitulo(ref lblECodProd, "Código", posCod, y);
                LabelTitulo(ref lblENombreProd, "Nombre", posNom, y);
                LabelTitulo(ref lblEMarca, "Marca", posMar, y);
                LabelTitulo(ref lblEDescripcion, "Descripción", posDes, y);
                LabelTitulo(ref lblECantProd, "Cantidad", posCan, y);
                pnlDetallada.Controls.Add(lblECodProd);
                pnlDetallada.Controls.Add(lblENombreProd);
                pnlDetallada.Controls.Add(lblEMarca);
                pnlDetallada.Controls.Add(lblEDescripcion);
                pnlDetallada.Controls.Add(lblECantProd);
                y += saltoPeque;

                Label lblCodProd;
                Label lblNombreProd;
                Label lblMarcaProd;
                Label lblDescripcionProd;
                Label lblCantProd;
                MySqlCommand sql;

                for (int i = 0; i < t.IDProductos.Count; i++)
                {
                    sql = new MySqlCommand();
                    sql.CommandText = "SELECT nombre, marca, codigo, descripcion FROM producto WHERE id=?id";
                    sql.Parameters.AddWithValue("?id", t.IDProductos[i]);
                    DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                    DataRow dr;
                    if (dt.Rows.Count > 0)
                        dr = dt.Rows[0];
                    else
                        return;
                    lblCodProd = new Label();
                    lblNombreProd = new Label();
                    lblMarcaProd = new Label();
                    lblDescripcionProd = new Label();
                    lblCantProd = new Label();

                    string codProd = dr["codigo"].ToString(), nomProd = dr["nombre"].ToString(), marca = dr["marca"].ToString(), descripcion = dr["descripcion"].ToString();
                    LabelDetalles(ref lblCodProd, codProd, posCod, y);
                    LabelDetalles(ref lblNombreProd, nomProd, posNom, y);
                    LabelDetalles(ref lblMarcaProd, marca, posMar, y);
                    LabelDetalles(ref lblDescripcionProd, descripcion, posDes, y);
                    LabelDetalles(ref lblCantProd, t.CantProductos[i].ToString(), posCan, y);
                    
                    pnlDetallada.Controls.Add(lblCodProd);
                    pnlDetallada.Controls.Add(lblNombreProd);
                    pnlDetallada.Controls.Add(lblMarcaProd);
                    pnlDetallada.Controls.Add(lblDescripcion);
                    pnlDetallada.Controls.Add(lblCantProd);
                    y += (saltoPeque * 2);

                    totProd += t.CantProductos[i];
                    prodDif += 1;
                }
                Label lblTotalProds = new Label();
                LabelTitulo(ref lblTotalProds, "Total de productos: " + totProd.ToString() + "\nProductos diferentes: " + prodDif.ToString(), posTot, y);
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

        private void frmDetalleTraspaso_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (t.Estado)
            {
                case EstadoTraspaso.Aceptada:
                    Traspaso.CambiarEstado(t.ID, EstadoTraspaso.Recibida, (new frmDescripcion()).Descripcion());
                    break;
                case EstadoTraspaso.Espera:
                    if (t.IDSucursalSolicito == t.IDSucursalOrigen && t.IDSucursalDestino == Config.idSucursal)
                    {
                        Traspaso.CambiarEstado(t.ID, EstadoTraspaso.Recibida, (new frmDescripcion()).Descripcion());
                    }
                    else if (t.IDSucursalSolicito == t.IDSucursalDestino && t.IDSucursalOrigen == Config.idSucursal)
                    {
                        Traspaso.CambiarEstado(t.ID, EstadoTraspaso.Aceptada, (new frmDescripcion()).Descripcion());
                    }
                    else
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al realizar el traspaso. No se reconoce ninguna de las sucursales cómo válidas para hacer la operación.", "Admin CSY", new Exception("Ninguna de las sucursales de la transacción es válida."));
                    }
                    break;
            }
        }

    }
}
