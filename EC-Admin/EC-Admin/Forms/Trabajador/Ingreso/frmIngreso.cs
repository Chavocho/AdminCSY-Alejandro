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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private bool EsEntrada(int idTrabajador)
        {
            bool entrada = false;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT es_entrada FROM registro_trabajador WHERE id_trabajador=?id_trabajador ORDER BY id DESC LIMIT 1";
                sql.Parameters.AddWithValue("?id_trabajador", idTrabajador);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    entrada = (bool)dr["es_entrada"];
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entrada;
        }

        private void BuscarSocio()
        {
            try
            {
                string sql = "SELECT t.id, t.nombre, t.apellidos, t.imagen, h.hora_ini, h.hora_fin FROM trabajador AS t INNER JOIN horario_trabajador AS h ON (t.id=h.id_trabajador) WHERE t.nomina='" + txtBusqueda.Text + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    bool esEntrada = EsEntrada((int)dr["id"]);
                    DateTime horaIni = DateTime.Parse(new DateTime().ToString("yyyy-MM-dd") + " " + dr["hora_ini"].ToString());
                    DateTime horaFin = DateTime.Parse(new DateTime().ToString("yyyy-MM-dd") + " " + dr["hora_fin"].ToString());
                    DateTime horaActual = DateTime.Parse(new DateTime().ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm") + ":00");
                    pcbImagen.Image = FuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
                    lblNombre.Text = dr["nombre"] + " " + dr["apellidos"];
                    lblHoraActual.Text = horaActual.ToString("hh:mm tt");
                    if (esEntrada)
                    {
                        lblEHoraES.Text = "Hora de entrada:";
                        lblEHoraES.Left = lblENombre.Right - lblEHoraES.Width;
                        lblHoraES.Text = horaIni.ToString("hh:mm tt");
                        //if (horaIni.Hour > 12 && horaIni.Hour <= 23)
                        //{
                            if (horaActual.TimeOfDay <= horaIni.TimeOfDay)
                            {
                                EstadoOK();
                            }
                            else
                            {
                                EstadoRetardo();
                            }
                        //}
                        //else
                        //{
                        //    if (horaActual.Hour <= 23 && horaIni.Hour >= 0)
                        //    {
                        //        EstadoOK();
                        //    }
                        //    else
                        //    {
                        //        if (horaActual.TimeOfDay <= horaIni.TimeOfDay)
                        //        {
                        //            EstadoOK();
                        //        }
                        //        else
                        //        {
                        //            EstadoRetardo();
                        //        }
                        //    }
                        //}
                    }
                    else
                    {
                        lblEHoraES.Text = "Hora de salida:";
                        lblEHoraES.Left = lblENombre.Right - lblEHoraES.Width;
                        lblHoraES.Text = horaFin.ToString("hh:mm tt");
                        if (horaFin.Hour > 12 && horaFin.Hour <= 23)
                        {
                            if (horaActual.TimeOfDay >= horaFin.TimeOfDay)
                            {
                                EstadoOK();
                            }
                            else
                            {
                                EstadoTemprano();
                            }
                        }
                        else
                        {
                            if (horaActual.Hour <= 23 && horaFin.Hour >= 0)
                            {
                                EstadoTemprano();
                            }
                            else
                            {
                                if (horaActual.TimeOfDay >= horaFin.TimeOfDay)
                                {
                                    EstadoOK();
                                }
                                else
                                {
                                    EstadoTemprano();
                                }
                            }
                        }
                    }
                    ActualizarEstado((int)dr["id"], !esEntrada);
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar información para el trabajador. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar información para el trabajador.", "Admin CSY", ex);
            }
        }

        private void EstadoOK()
        {
            lblEstatus.Text = "OK";
            lblEstatus.ForeColor = Colores.Claro;
            lblEstatus.BackColor = Colores.Exito;
        }

        private void EstadoRetardo()
        {
            lblEstatus.Text = "Retardo";
            lblEstatus.ForeColor = Colores.Claro;
            lblEstatus.BackColor = Colores.Error;
        }

        private void EstadoTemprano()
        {
            lblEstatus.Text = "Salida temprana";
            lblEstatus.ForeColor = Colores.Claro;
            lblEstatus.BackColor = Colores.Error;
        }

        private void ActualizarEstado(int idTrabajador, bool esEntrada)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO registro_trabajador (id_trabajador, fecha, es_entrada) " +
                    "VALUES (?id_trabajador, NOW(), ?es_entrada)";
                sql.Parameters.AddWithValue("?id_trabajador", idTrabajador);
                sql.Parameters.AddWithValue("?es_entrada", esEntrada);
                ConexionBD.EjecutarConsulta(sql);
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar información del trabajador. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar información del trabajador. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarSocio();
            }
        }
    }
}
