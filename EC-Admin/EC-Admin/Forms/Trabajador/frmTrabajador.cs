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
    public partial class frmTrabajador : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        #region Instancia
        private static frmTrabajador frmInstancia;
        public static frmTrabajador Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmTrabajador();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmTrabajador();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmTrabajador()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            txtBusqueda.Enabled = true;
            txtBusqueda.Select();
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(string p)
        {
            try
            {
                string sql = "SELECT t.id, t.nombre, t.apellidos, p.nombre AS puesto, t.telefono, t.celular, t.email FROM trabajador AS t INNER JOIN puesto AS p ON (t.puesto=p.id) WHERE (t.nombre LIKE '%" + p + "%' OR t.apellidos LIKE '%" + p + "%') AND t.eliminado=0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error genérico al buscar a los trabajadores.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error genérico al buscar a los trabajadores.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvTrabajadores.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string telefono = "", correo = "Sin información";
                    if (dr["telefono"].ToString() != "" && dr["celular"].ToString() == "")
                    {
                        telefono += dr["telefono"].ToString() + ", " + dr["celular"].ToString();
                    }
                    else if (dr["telefono"].ToString() != "")
                    {
                        telefono += dr["telefono"].ToString();
                    }
                    else if (dr["celular"].ToString() != "")
                    {
                        telefono += dr["celular"].ToString();
                    }
                    if (dr["email"].ToString() != "")
                    {
                        correo = dr["email"].ToString();
                    }
                    dgvTrabajadores.Rows.Add(new object[] { dr["id"], dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), dr["puesto"].ToString(), telefono, correo });
                }
                dgvTrabajadores_RowEnter(dgvTrabajadores, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ha ocurrido un error genérico al mostrar los datos de los trabajadores.", "Admin CSY", ex);
            }
        }

        private void CambiarEstado()
        {
            try
            {
                Trabajador.CambiarEstado(id, true);
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

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tmrEspera.Enabled = true;
                txtBusqueda.Enabled = false;
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
            }
        }

        private void dgvTrabajadores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTrabajadores.CurrentRow != null)
                id = (int)dgvTrabajadores[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Puesto.Cantidad <= 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "Necesitas registrar al menos un puesto para poder crear un trabajador", "Admin CSY");
                return;
            }
            (new frmNuevoTrabajador()).ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTrabajadores.CurrentRow != null && id > 0)
            {
                (new frmEditarTrabajador(id)).ShowDialog(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTrabajadores.CurrentRow != null && id > 0)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente deseas dar de baja a " + dgvTrabajadores[1, dgvTrabajadores.CurrentRow.Index].Value.ToString() + "?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        CambiarEstado();
                        dgvTrabajadores.Rows.Remove(dgvTrabajadores.CurrentRow);
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha dado de baja correctamente al trabajador!", "Admin CSY");
                    }
                    catch (MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al dar de baja al trabajador. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al dar de baja al trabajador. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                    }
                }
            }
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            (new frmPuesto()).ShowDialog(this);
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
            FuncionesGenerales.frmEspera("Espere, buscando trabajadores", this);
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            (new frmHorarioTrabajador()).ShowDialog(this);
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            (new frmIngreso()).Show(this);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            (new frmPagosPendientes()).Show();
        }
    }
}
