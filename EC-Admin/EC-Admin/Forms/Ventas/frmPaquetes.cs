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
    public partial class frmPaquetes : Form
    {
        int idP;
        frmPOS frm;

        public frmPaquetes(frmPOS frm, int idP)
        {
            InitializeComponent();
            this.frm = frm;
            this.idP = idP;
        }

        private void CargarPaquetes()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM paquete WHERE id_producto=?id_producto";
                sql.Parameters.AddWithValue("?id_producto", idP);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvPaquetes.Rows.Add(new object[] { dr["id"], dr["precio"], dr["cant"] });
                }
                dgvPaquetes[1, 0].Selected = true;
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

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.CurrentRow != null)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Deseas asignar este paquete?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    frm.PaqueteProducto((decimal)dgvPaquetes[1, dgvPaquetes.CurrentRow.Index].Value, decimal.Parse(dgvPaquetes[2, dgvPaquetes.CurrentRow.Index].Value.ToString()));
                    this.Close();
                }
            }
        }

        private void frmPaquetes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPaquetes();
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los paquetes. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los paquetes.", "Admin CSY", ex);
            }
        }
    }
}
