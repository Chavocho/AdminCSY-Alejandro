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
    public partial class frmLoginValidacion : Form
    {
        public frmLoginValidacion()
        {
            InitializeComponent();
            FuncionesGenerales.DeshabilitarBotonCerrar(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                NivelesUsuario n = Usuario.VerificarNivelUsuario(txtUsuario.Text, txtPass.Text);
                if (n == NivelesUsuario.Administrador)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "El usuario ingresado no tiene las credenciales válidas. Verifique que los datos ingresados sean los correctos o intente con otro usuario.", "Admin CSY");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al verificar los datos del usuario. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al verificar los datos del usuario.", "Admin CSY", ex);
            }
        }
    }
}
