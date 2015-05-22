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
    public partial class frmEditarHorario : Form
    {
        Horario h;
        public frmEditarHorario(int id, string nombre)
        {
            InitializeComponent();
            h = new Horario(id);
            this.Text += nombre;
        }

        private void MostrarDatos()
        {
            try
            {
                h.ObtenerDatos();
                chbLunes.Checked = h.Lunes;
                chbMartes.Checked = h.Martes;
                chbMiercoles.Checked = h.Miercoles;
                chbJueves.Checked = h.Jueves;
                chbViernes.Checked = h.Viernes;
                chbSabado.Checked = h.Sabado;
                chbDomingo.Checked = h.Domingo;
                dtpHoraIni.Value = DateTime.Parse(dtpHoraIni.MinDate.ToString("yyyy-MM-dd") + " " + h.HoraInicio.ToString("HH:mm:ss"));
                dtpHoraFin.Value = DateTime.Parse(dtpHoraFin.MinDate.ToString("yyyy-MM-dd") + " " + h.HoraFin.ToString("HH:mm:ss"));
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

        private void Editar()
        {
            try
            {
                h.Lunes = chbLunes.Checked;
                h.Martes = chbMartes.Checked;
                h.Miercoles = chbMiercoles.Checked;
                h.Jueves = chbJueves.Checked;
                h.Viernes = chbViernes.Checked;
                h.Sabado = chbSabado.Checked;
                h.Domingo = chbDomingo.Checked;
                h.HoraInicio = dtpHoraIni.Value;
                h.HoraFin = dtpHoraFin.Value;
                h.Editar();
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

        private void chbDias_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpHoras_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Editar();
                FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado el horario correctamente!", "Admin CSY");
                this.Close();
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el horario. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el horario.", "Admin CSY", ex);
            }
        }

        private void frmEditarHorario_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarDatos();
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos. No se ha podido conectar con la base de datos. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
        }
    }
}
