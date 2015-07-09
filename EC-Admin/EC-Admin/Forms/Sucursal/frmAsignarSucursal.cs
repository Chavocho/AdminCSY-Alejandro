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
    public partial class frmAsignarSucursal : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmAsignarSucursal()
        {
            InitializeComponent();
            c = new CerrarFrmEspera(Cerrar);
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar()
        {
            try
            {
                string sql = "SELECT id, nombre, rfc, calle, numero_ext, numero_int, telefono1, telefono2 FROM sucursal";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las sucursales. No se ha podido conectar con la base de datos. La ventana se cerrará.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las sucursales. La ventana se cerrará.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvSucursal.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string telefonos = "", direccion = dr["calle"].ToString() + " Ext. " + dr["numero_ext"].ToString();
                    if (dr["telefono1"].ToString() != "" && dr["telefono2"].ToString() != "")
                    {
                        telefonos += dr["telefono1"].ToString();
                        telefonos += ", " + dr["telefono2"].ToString();
                    }
                    else if (dr["telefono1"].ToString() != "")
                    {
                        telefonos += dr["telefono1"].ToString();
                    }
                    else if (dr["telefono2"].ToString() != "")
                    {
                        telefonos += dr["telefono2"].ToString();
                    }

                    if (dr["numero_int"].ToString() != "")
                        direccion += " Int. " + dr["numero_int"].ToString();
                    dgvSucursal.Rows.Add(new object[] { dr["id"], dr["nombre"], dr["rfc"], direccion, telefonos });
                }
                dgvSucursal_RowEnter(dgvSucursal, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                if (dgvSucursal.RowCount == 0)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de las sucursales. La ventana se cerrará.", "Admin CSY", ex);
                    this.Close();
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de las sucursales.", "Admin CSY", ex);
                }
            }
        }

        private void CambioSucursal()
        {
            try
            {
                ConfiguracionXML.GuardarConfiguracion("sucursal", "id", id.ToString());
                ConfiguracionXML.GuardarConfiguracion("sucursal", "nombre", dgvSucursal[1, dgvSucursal.CurrentRow.Index].Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Buscar();
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
            if (dgvSucursal.RowCount <= 0)
            {
                this.Close();
            }
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando sucursales", this);
        }

        private void frmAsignarSucursal_Load(object sender, EventArgs e)
        {
            bgwBusqueda.RunWorkerAsync();
            tmrEspera.Enabled = true;
        }

        private void dgvSucursal_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSucursal.CurrentRow != null)
                id = (int)dgvSucursal[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Deseas asignar la sucursal con nombre \"" + dgvSucursal[1, dgvSucursal.CurrentRow.Index].Value.ToString() + "\"?", "Admin CSY") == DialogResult.Yes)
            {
                try
                {
                    CambioSucursal();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha cambiado la sucursal correctamente!. La aplicación se cerrará.", "Admin CSY");
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error asignar la sucursal.", "Admin CSY", ex);
                }
            }
        }
    }
}
