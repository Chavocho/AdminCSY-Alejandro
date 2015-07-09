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
    public partial class frmNuevaPromocion : Form
    {
        int id = -1;
        decimal cant;

        public frmNuevaPromocion()
        {
            InitializeComponent();
            chbExistencias.Checked = true;
        }

        public void AsignarProducto(int id, string nombre, string marca, decimal cant)
        {
            this.id = id;
            this.cant = cant;
            txtExistencias.Text = cant.ToString("0");
            lblProducto.Text = nombre;
            lblMarca.Text = marca;
        }

        private void Insertar()
        {
            try
            {
                Promociones p = new Promociones();
                p.IDProducto = id;
                p.Existencias = chbExistencias.Checked;
                p.Cantidad = int.Parse(txtCant.Text);
                if (chbExistencias.Checked)
                {
                    p.FechaInicio = new DateTime();
                    p.FechaFin = new DateTime();
                    p.CantidadProducto = int.Parse(txtExistencias.Text);
                }
                else
                {
                    p.FechaInicio = dtpFechaIni.Value;
                    p.FechaFin = dtpFechaFin.Value;
                    p.CantidadProducto = 0;
                }
                p.Precio = decimal.Parse(txtPrecio.Text);
                p.Insertar();
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

        private bool VerificarCampos()
        {
            bool res = true;
            if (id <= 0)
            {
                FuncionesGenerales.ColoresError(lblProducto);
                FuncionesGenerales.ColoresError(lblEProducto);
                FuncionesGenerales.ColoresError(lblMarca);
                FuncionesGenerales.ColoresError(lblEMarca);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(lblProducto);
                FuncionesGenerales.ColoresBien(lblEProducto);
                FuncionesGenerales.ColoresBien(lblMarca);
                FuncionesGenerales.ColoresBien(lblEMarca);
            }
            if (txtPrecio.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtPrecio);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtPrecio);
            }
            if (txtCant.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtCant);
                res = false;
            }
            else
            {
                if (int.Parse(txtCant.Text) <= 0)
                {
                    FuncionesGenerales.ColoresError(txtCant);
                    res = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtCant);
                }
            }
            if (chbExistencias.Checked)
            {
                if (txtExistencias.Text.Trim() == "")
                {
                    FuncionesGenerales.ColoresError(txtExistencias);
                    res = false;
                }
                else
                {
                    if (decimal.Parse(txtExistencias.Text) > cant)
                    {
                        FuncionesGenerales.ColoresError(txtExistencias);
                        res = false;
                    }
                    else
                    {
                        FuncionesGenerales.ColoresBien(txtExistencias);
                    }
                }
            }
            return res;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaIni.Value > dtpFechaFin.Value)
                dtpFechaIni.Value = dtpFechaFin.Value;
            if (dtpFechaFin.Value < dtpFechaIni.Value)
                dtpFechaFin.Value = dtpFechaIni.Value;
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            (new frmProductoPromocion(this)).ShowDialog(this);
        }

        private void chbExistencias_CheckedChanged(object sender, EventArgs e)
        {
            if (chbExistencias.Checked)
            {
                dtpFechaIni.Enabled = false;
                dtpFechaFin.Enabled = false;
                txtExistencias.Enabled = true;
            }
            else
            {
                dtpFechaIni.Enabled = true;
                dtpFechaFin.Enabled = true;
                txtExistencias.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                try
                {
                    Insertar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se agrego correctamente la promoción!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al insertar la promoción. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al insertar la promoción.", "Admin CSY", ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Los campos en rojo son obligatorios.", "Admin CSY");
            }
        }

    }
}
