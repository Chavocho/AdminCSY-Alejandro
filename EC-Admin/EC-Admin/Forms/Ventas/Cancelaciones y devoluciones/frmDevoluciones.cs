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
    public partial class frmDevoluciones : Form
    {
        decimal total, cantidad;
        bool dragSalioDGV01 = false, dragSalioDGV02 = false, dragEntroDGV01= false, dragEntroDGV02 = false;
        int id, rowIndexFromMouseDown;
        Venta v;

        public frmDevoluciones(int id)
        {
            InitializeComponent();
            this.id = id;
            v = new Venta(id);
        }

        private void CargarDatos()
        {
            try
            {
                v.RecuperarVenta();
                for (int i = 0; i < v.IDProductos.Count; i++)
                {
                    dgvProductos01.Rows.Add(new object[] { v.IDProductos[i], Producto.CodigoProducto(v.IDProductos[i]), Producto.NombreProducto(v.IDProductos[i]), v.Precio[i], v.Cantidad[i], v.Promocion[i] });
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener los datos de la venta. No se ha podido conectar a la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener los datos de la venta.", "Admin CSY", ex);
            }
        }

        private void GuardarDevolucion()
        {
            Devoluciones d = new Devoluciones(v);
            d.IDVenta = id;
            d.Saldo = total;
            d.Total = total;
            foreach (DataGridViewRow dr in dgvProductos02.Rows)
            {
                d.IDProductos.Add((int)dr.Cells[0].Value);
                d.CantidadProductos.Add((int)dr.Cells[4].Value);
                d.PrecioProductos.Add((decimal)dr.Cells[3].Value);
            }
            d.Insertar();
        }

        private void CalcularTotales()
        {
            foreach (DataGridViewRow dr in dgvProductos02.Rows)
            {
                total += (decimal)dr.Cells[3].Value * (int)dr.Cells[4].Value;
                cantidad += (int)dr.Cells[4].Value;
            }
            lblCantDif.Text = dgvProductos02.RowCount.ToString();
            lblCantTot.Text = cantidad.ToString("0");
            lblTotal.Text = total.ToString("C2");
        }

        private void MovimientoCaja()
        {
            Caja c = new Caja();
            c.Descripcion = "DEVOLUCIÓN DE PRODUCTOS DE VENTA CON FOLIO: " + v.IDVenta.ToString();
            c.Efectivo = total;
            c.IDSucursal = Config.idSucursal;
            c.TipoMovimiento = EC_Admin.MovimientoCaja.Salida;
            c.Voucher = 0M;
            c.RegistrarMovimiento();
        }

        #region DragAndDrop

        private void dgvProductos01_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dgvProductos01.CurrentRow != null)
                {
                    DragDropEffects dropEffect = dgvProductos01.DoDragDrop(dgvProductos01.CurrentRow, DragDropEffects.Move);
                }
            }
        }

        private void dgvProductos01_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvProductos01.HitTest(e.X, e.Y).RowIndex;
            if (Control.ModifierKeys != Keys.Shift && Control.ModifierKeys != Keys.Control)
            {
                if (dgvProductos01.SelectedRows.Count == 1 && rowIndexFromMouseDown >= 0)
                {
                    dgvProductos01.Rows[rowIndexFromMouseDown].Selected = true;
                    dgvProductos02.ClearSelection();
                }
            }
        }

        private void dgvProductos01_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvProductos01_DragDrop(object sender, DragEventArgs e)
        {
            if (!dragEntroDGV01)
                return;
            bool entro = false;
            if (e.Effect == DragDropEffects.Move)
            {
                if (dgvProductos02.CurrentRow != null)
                {
                    foreach (DataGridViewRow dgvr in dgvProductos01.Rows)
                    {
                        if (dgvr.Cells[0].Value.ToString() == dgvProductos02.CurrentRow.Cells[0].Value.ToString())
                        {
                            dgvr.Cells[4].Value = (int)dgvr.Cells[4].Value + (int)dgvProductos02.CurrentRow.Cells[4].Value;
                            dgvProductos02.Rows.RemoveAt(rowIndexFromMouseDown);
                            entro = true;
                            break;
                        }
                    }
                    if (!entro)
                    {
                        DataGridViewRow dr = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
                        dgvProductos02.Rows.RemoveAt(rowIndexFromMouseDown);
                        dgvProductos01.Rows.Add(dr);
                    }
                }
                CalcularTotales();
            }
            dragEntroDGV02 = false;
        }

        private void dgvProductos01_DragEnter(object sender, DragEventArgs e)
        {
            if (dragSalioDGV02)
            {
                dragEntroDGV01 = true;
                dragSalioDGV02 = false;
            }
        }

        private void dgvProductos01_DragLeave(object sender, EventArgs e)
        {
            dragSalioDGV01 = true;
        }
    
        private void dgvProductos02_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dgvProductos02.CurrentRow != null)
                {
                    DragDropEffects dropEffect = dgvProductos02.DoDragDrop(dgvProductos02.CurrentRow, DragDropEffects.Move);
                }
            }

        }

        private void dgvProductos02_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvProductos02.HitTest(e.X, e.Y).RowIndex;
            if (Control.ModifierKeys != Keys.Shift && Control.ModifierKeys != Keys.Control)
            {
                if (dgvProductos02.SelectedRows.Count == 1 && rowIndexFromMouseDown >= 0)
                {
                    dgvProductos02.Rows[rowIndexFromMouseDown].Selected = true;
                    dgvProductos02.ClearSelection();
                }
            }
        }

        private void dgvProductos02_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvProductos02_DragDrop(object sender, DragEventArgs e)
        {
            bool entro = false;
            if (!dragEntroDGV02)
                return;
            if (e.Effect == DragDropEffects.Move)
            {
                if (rowIndexFromMouseDown >= 0)
                {
                    int cant = (int)dgvProductos01.CurrentRow.Cells[4].Value;
                    int nuevaCant = (new frmDevolucionCantidadProductos()).Cantidad(cant);
                    foreach (DataGridViewRow dgvr in dgvProductos02.Rows)
                    {
                        if (dgvr.Cells[0].Value.ToString() == dgvProductos01.CurrentRow.Cells[0].ToString())
                        {
                            if (nuevaCant == cant)
                            {
                                dgvProductos01.Rows.RemoveAt(rowIndexFromMouseDown);
                            }
                            else if (nuevaCant < cant)
                            {
                                dgvProductos01[4, rowIndexFromMouseDown].Value = cant - nuevaCant;
                            }
                            dgvr.Cells[4].Value = (int)dgvr.Cells[4].Value + nuevaCant;
                            entro = true;
                            break;
                        }
                    }
                    if (!entro)
                    {
                        DataGridViewRow dr = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
                        if (nuevaCant == cant)
                        {
                            dgvProductos01.Rows.RemoveAt(rowIndexFromMouseDown);
                            dgvProductos02.Rows.Add(dr);
                        }
                        else if (nuevaCant < cant && nuevaCant > 0)
                        {
                            dgvProductos01[4, rowIndexFromMouseDown].Value = cant - nuevaCant;
                            dgvProductos02.Rows.Add(new object[] { dr.Cells[0].Value, dr.Cells[1].Value, dr.Cells[2].Value, dr.Cells[3].Value, nuevaCant, dr.Cells[5].Value });
                        }
                    }
                }
                CalcularTotales();
            }
            dragEntroDGV01 = false;
        }

        private void dgvProductos02_DragEnter(object sender, DragEventArgs e)
        {
            if (dragSalioDGV01)
            {
                dragEntroDGV02 = true;
                dragSalioDGV01 = false;
            }
        }
    
        private void dgvProductos02_DragLeave(object sender, EventArgs e)
        {
            dragSalioDGV02 = true;
        }
    
        #endregion

        private void dgvProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvProductos01.CurrentRow != null)
            {
                (new frmDetalleProductoDevolucion(id, (decimal)dgvProductos01[3, dgvProductos01.CurrentRow.Index].Value)).ShowDialog(this);
            }
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvProductos02.RowCount > 0)
            {
                GuardarDevolucion();
                MovimientoCaja();
                FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se han regresado los productos correctamente!", "Admin CSY");
                this.Close();
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un producto para realizar la devolución.", "Admin CSY");
            }
        }
    }
}
