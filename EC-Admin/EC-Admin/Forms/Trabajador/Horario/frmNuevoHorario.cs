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
    public partial class frmNuevoHorario : Form
    {
        int idT;
        public frmNuevoHorario(int idT, string nombre)
        {
            InitializeComponent();
            this.idT = idT;
            this.Text += nombre;
        }

        private void Insertar()
        {
            try
            {
                Horario h = new Horario();
                h.IDTrabajor = idT;
                h.Lunes = chbLunes.Checked;
                h.Martes = chbMartes.Checked;
                h.Miercoles = chbMiercoles.Checked;
                h.Jueves = chbJueves.Checked;
                h.Viernes = chbViernes.Checked;
                h.Sabado = chbSabado.Checked;
                h.Domingo = chbDomingo.Checked;
                h.HoraInicio = dtpHoraIni.Value;
                h.HoraFin = dtpHoraFin.Value;
                h.Insertar();
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

        private void CalcularHoras()
        {
            int span;
            int dias = 0;
            decimal horas = 0M;
            if (dtpHoraIni.Value < dtpHoraFin.Value)
            {
                span = dtpHoraFin.Value.TimeOfDay.Hours - dtpHoraIni.Value.TimeOfDay.Hours;
            }
            else
            {
                span = dtpHoraIni.Value.TimeOfDay.Hours - dtpHoraFin.Value.TimeOfDay.Hours;
            }

            if (chbLunes.Checked)
            {
                dias += 1;
            }
            if (chbMartes.Checked)
            {
                dias += 1;
            }
            if (chbMiercoles.Checked)
            {
                dias += 1;
            }
            if (chbJueves.Checked)
            {
                dias += 1;
            }
            if (chbViernes.Checked)
            {
                dias += 1;
            }
            if (chbSabado.Checked)
            {
                dias += 1;
            }
            if (chbDomingo.Checked)
            {
                dias += 1;
            }
            horas = span * dias;
            if (horas < 0)
                horas = horas * -1;
            lblHoras.Text = horas.ToString("0.00");
        }

        private void dtpHoras_ValueChanged(object sender, EventArgs e)
        {
            //CalcularHoras();
        }

        private void chbDias_CheckedChanged(object sender, EventArgs e)
        {
            //CalcularHoras();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Insertar();
                FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha asignado el horario correctamente!", "Admin CSY");
                this.Close();
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al asignar el horario. No se ha podido conectar a la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al asignar el horario.", "Admin CSY", ex);
            }
        }
    }
}
