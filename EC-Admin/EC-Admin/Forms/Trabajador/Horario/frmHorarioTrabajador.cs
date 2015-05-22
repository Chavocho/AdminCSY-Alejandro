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
    public partial class frmHorarioTrabajador : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmHorarioTrabajador()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            txtBusqueda.Enabled = true;
            FuncionesGenerales.frmEsperaClose();
            tmrEspera.Enabled = false;
        }

        private void Buscar(string p)
        {
            try
            {
                string sql = "SELECT h.*, t.id AS tid, t.nombre, t.apellidos FROM horario_trabajador AS h RIGHT JOIN trabajador AS t ON (h.id_trabajador=t.id) WHERE t.nombre LIKE '%" + p + "%' OR t.apellidos LIKE '%" + p + "%'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar a los trabajadores. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar a los trabajadores.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            dgvProductos.Rows.Clear();
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    bool existe, lunes, martes, miercoles, jueves, viernes, sabado, domingo;
                    DateTime horaIni, horaFin;
                    string horario;
                    string dias;
                    if (dr["id"] != DBNull.Value)
                    {
                        dias = "";
                        horario = "";
                        existe = true;
                        lunes = (bool)dr["lunes"];
                        martes = (bool)dr["martes"];
                        miercoles = (bool)dr["miercoles"];
                        jueves = (bool)dr["jueves"];
                        viernes = (bool)dr["viernes"];
                        sabado = (bool)dr["sabado"];
                        domingo = (bool)dr["domingo"];
                        horaIni = DateTime.Parse(new DateTime().ToString("yyyy-MM-dd") + " " + (dr["hora_ini"]).ToString());
                        horaFin = DateTime.Parse(new DateTime().ToString("yyyy-MM-dd") + " " + (dr["hora_fin"]).ToString());
                        horario = horaIni.ToString("hh:mm tt") + " - " + horaFin.ToString("hh:mm tt");
                        if (lunes == true && martes == true && miercoles == true && jueves == true && viernes == true && sabado == true && domingo == true)
                        {
                            dias = "Todos los días";
                        }
                        else if (lunes == true && martes == true && miercoles == true && jueves == true && viernes == true && sabado == false && domingo == false)
                        {
                            dias = "Días entre semana";
                        }
                        else if (lunes == true && martes == true && miercoles == true && jueves == true && viernes == true && sabado == true && domingo == false)
                        {
                            dias = "Días entre semana, sáb.";
                        }
                        else if (lunes == true && martes == true && miercoles == true && jueves == true && viernes == true && sabado == false && domingo == true)
                        {
                            dias = "Días entre semana, dom.";
                        }
                        else if (lunes == false && martes == false && miercoles == false && jueves == false && viernes == false && sabado == true && domingo == true)
                        {
                            dias = "Fines de semana";
                        }
                        else
                        {
                            if (lunes)
                            {
                                dias += "Lun., ";
                            }
                            if (martes)
                            {
                                dias += "Mar., ";
                            }
                            if (miercoles)
                            {
                                dias += "Mié., ";
                            }
                            if (jueves)
                            {
                                dias += "Jue., ";
                            }
                            if (viernes)
                            {
                                dias += "Vie., ";
                            }
                            if (sabado)
                            {
                                dias += "Sáb., ";
                            }
                            if (domingo)
                            {
                                dias += "Dom., ";
                            }
                            dias = dias.Substring(0, dias.Length - 2);
                        }
                        dgvProductos.Rows.Add(new object[] { dr["tid"], existe, dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), dias, horario });
                    }
                    else
                    {
                        existe = false;
                        dias = "Sin información";
                        horario = "Sin información";
                        dgvProductos.Rows.Add(new object[] { dr["tid"], existe, dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), dias, horario });
                    }
                }
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los trabajadores.", "Admin CSY", ex);
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBusqueda.Enabled = false;
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
            }
        }

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                id = (int)dgvProductos[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && id > 0)
            {
                if ((bool)dgvProductos[1, dgvProductos.CurrentRow.Index].Value == false)
                {
                    (new frmNuevoHorario(id, dgvProductos[2, dgvProductos.CurrentRow.Index].Value.ToString())).ShowDialog(this);
                }
                else
                {
                    DialogResult r = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "El trabajador seleccionado ya tiene asignado un horario, ¿desea modificarlo?", "Admin CSY");
                    if (r == System.Windows.Forms.DialogResult.Yes)
                    {
                        btnEditar.PerformClick();
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && id > 0)
            {
                if ((bool)dgvProductos[1, dgvProductos.CurrentRow.Index].Value == true)
                {
                    (new frmEditarHorario(id, dgvProductos[2, dgvProductos.CurrentRow.Index].Value.ToString())).ShowDialog(this);
                }
                else
                {
                    DialogResult r = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "El trabajador seleccionado no tiene asignado un horario, ¿desea crearlo?", "Admin CSY");
                    if (r == System.Windows.Forms.DialogResult.Yes)
                    {
                        btnNuevo.PerformClick();
                    }
                }
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Buscar(e.Argument.ToString());
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, búscando trabajadores", this);
        }
    }
}
