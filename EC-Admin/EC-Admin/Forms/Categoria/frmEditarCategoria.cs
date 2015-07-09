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
    public partial class frmEditarCategoria : Form
    {
        Categoria c;

        public frmEditarCategoria(int id)
        {
            InitializeComponent();
            c = new Categoria(id);
        }

        private void CargarDatos()
        {
            c.ObtenerDatos();
            txtNombre.Text = c.Nombre;
            txtDescripcion.Text = c.Descripcion;
        }

        private void Editar()
        {
            try
            {
                c.Nombre = txtNombre.Text;
                c.Descripcion = txtDescripcion.Text;
                c.Editar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
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
            bool resultado = true;
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtNombre);
                resultado = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtNombre);
            }
            return resultado;
        }

        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Editar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado correctamente la categoría!", "Admin CSY");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar la categoría. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar la categoría.", "Admin CSY", ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar los campos en color rojo", "Admin CSY");
            }
        }
    }
}
