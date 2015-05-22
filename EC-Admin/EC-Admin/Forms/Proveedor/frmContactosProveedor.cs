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
    public partial class frmContactosProveedor : Form
    {
        int id = 0;
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        ProveedorContacto p;

        public frmContactosProveedor(int id, string nombre)
        {
            InitializeComponent();
            this.Text = "Contactos de " + nombre;
            this.id = id;
            try
            {
                p = new ProveedorContacto(id);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener los contactos. La ventana se cerrará", "Admin CSY", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al obtener los contactos. La ventana se cerrará", "Admin CSY", ex);
                this.Close();
            }
        }

        private void LlenarPanel()
        {
            pnlContactos.Controls.Clear();
            Label lblENombre;
            Label lblNombre;
            Label lblETelefono;
            Label lblTelefono;
            Label lblECorreo;
            Label lblCorreo;
            int tabIndex = 0;
            try
            {
                Graphics e = this.CreateGraphics();
                int y = 10;
                int salto = (int)(e.MeasureString("Algo", new Font("Corbel", 13, FontStyle.Bold)).Height) + 5;
                int lNom = 10;
                int lTel = (pnlContactos.Width / 3) + 50;
                int lCor = (pnlContactos.Width / 3) * 2;

                lblENombre = new Label();
                lblETelefono = new Label();
                lblECorreo = new Label();

                PropiedadesLabelEtiqueta(ref lblENombre, "lblENombre", "Nombre", new Point(lNom, y), tabIndex);
                tabIndex++;
                PropiedadesLabelEtiqueta(ref lblETelefono, "lblETelefono", "Teléfono", new Point(lTel, y), tabIndex);
                tabIndex++;
                PropiedadesLabelEtiqueta(ref lblECorreo, "lblECorreo", "Correo", new Point(lCor, y), tabIndex);
                tabIndex++;

                //Agregamos los controles al panel
                pnlContactos.Controls.Add(lblENombre);
                pnlContactos.Controls.Add(lblETelefono);
                pnlContactos.Controls.Add(lblECorreo);
                y += salto;
                for (int i = 0; i < p.IDCS.Count; i++)
                {
                    lblNombre = new Label();
                    lblTelefono = new Label();
                    lblCorreo = new Label();

                    string correo = "Sin información";
                    if (p.CorreoContactos[i] != "")
                        correo = p.CorreoContactos[i];
                    //Asignamos sus propiedades usando el método PropiedadesLabel
                    PropiedadesLabel(ref lblNombre, "lblNombre" + i.ToString("000"), p.NombreContactos[i], new Point(lNom, y), tabIndex);
                    tabIndex++;
                    PropiedadesLabel(ref lblTelefono, "lblTelefono" + i.ToString("000"), Telefonos(i), new Point(lTel, y), tabIndex);
                    tabIndex++;
                    PropiedadesLabel(ref lblCorreo, "lblCorreo" + i.ToString("000"), correo, new Point(lCor, y), tabIndex);
                    tabIndex++;

                    //Agregamos los controles al panel
                    pnlContactos.Controls.Add(lblNombre);
                    pnlContactos.Controls.Add(lblTelefono);
                    pnlContactos.Controls.Add(lblCorreo);
                    y += salto;
                }

            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al mostrar la información de los productos.", "Admin CSY", ex);
            }
        }

        private void PropiedadesLabelEtiqueta(ref Label lbl, string name, string texto, Point location, int tabIndex)
        {
            try
            {
                lbl.Name = name;
                lbl.AutoSize = true;
                lbl.Font = new Font("Corbel", 13, FontStyle.Bold);
                lbl.Text = texto;
                lbl.Location = location;
                lbl.TabIndex = tabIndex;
            }
            catch
            {
            }
        }

        private void PropiedadesLabel(ref Label lbl, string name, string texto, Point location, int tabIndex)
        {
            try
            {
                lbl.Name = name;
                lbl.AutoSize = true;
                lbl.Font = new Font("Corbel", 11, FontStyle.Regular);
                lbl.Text = texto;
                lbl.Location = location;
                lbl.TabIndex = tabIndex;
            }
            catch
            {
            }
        }

        private string Telefonos(int pos)
        {
            string tel = "";
            try
            {
                if (p.TelefonoContactos01[pos] != "" && p.TelefonoContactos02[pos] != "")
                {
                    if (p.LadaContactos01[pos] != "")
                    {
                        tel += p.LadaContactos01[pos] + " " + p.TelefonoContactos01[pos];
                    }
                    else
                    {
                        tel += p.TelefonoContactos01[pos];
                    }
                    if (p.LadaContactos02[pos] != "")
                    {
                        tel += ", " + p.LadaContactos02[pos] + " " + p.TelefonoContactos02[pos];
                    }
                    else
                    {
                        tel += ", " + p.TelefonoContactos02[pos];
                    }
                }
                else if (p.TelefonoContactos01[pos] != "")
                {
                    if (p.LadaContactos01[pos] != "")
                    {
                        tel += p.LadaContactos01[pos] + " " + p.TelefonoContactos01[pos];
                    }
                    else
                    {
                        tel += p.TelefonoContactos01[pos];
                    }
                }
                else if (p.TelefonoContactos02[pos] != "")
                {
                    if (p.LadaContactos02[pos] != "")
                    {
                        tel += p.LadaContactos02[pos] + " " + p.TelefonoContactos02[pos];
                    }
                    else
                    {
                        tel += p.TelefonoContactos02[pos];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tel;
        }

        private void frmContactosProveedor_Load(object sender, EventArgs e)
        {
            LlenarPanel();
        }

    }
}
