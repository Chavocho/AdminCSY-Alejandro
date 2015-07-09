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
    public partial class frmDetalleProductoDevolucion : Form
    {
        int id;
        decimal precio;

        public frmDetalleProductoDevolucion(int id, decimal precio)
        {
            InitializeComponent();
            this.id = id;
            this.precio = precio;
            this.lblPrecio.Text = precio.ToString("C2");
        }

        private void frmDetalleProductoDevolucion_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT codigo, marca, descripcion1, imagen FROM producto WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    lblCodigo.Text = dr["codigo"].ToString();
                    lblMarca.Text = dr["marca"].ToString();
                    lblDescripcion.Text = dr["descripcion1"].ToString();
                    if (dr["imagen"] != DBNull.Value)
                        pcbProducto.Image = FuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los datos del producto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los datos del producto.", "Admin CSY", ex);
            }
        }
    }
}
