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
    public partial class frmNuevaCategoria : Form
    {
        public frmNuevaCategoria()
        {
            InitializeComponent();
        }

        private void Insertar()
        {
            try
            {
                Categoria c = new Categoria();
                c.Nombre = txtNombre.Text;
                c.Descripcion = txtDescripcion.Text;
                c.Insertar();
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
                FuncionesGenerales.ColoresError(ref txtNombre);
                resultado = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(ref txtNombre);
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(ref txtDescripcion);
                resultado = false; ;
            }
            else
            {
                FuncionesGenerales.ColoresBien(ref txtDescripcion);
            }
            return resultado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Insertar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado correctamente la categoría!", "Admin CSY");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear la categoría. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear la categoría.", "Admin CSY", ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar los campos en color rojo", "Admin CSY");
            }
        }
    }
}
