using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin
{
    public partial class frmMensaje : Form
    {
        //Variable para guardar el mensaje
        private string mensaje;
        //Variable para guardar el tipo de mensaje, el cual afectará toda la apariencia del formulario
        private Mensajes m;

        //API de Windows que permite mover ventanas sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Inicializa la instancia del frmError.
        /// </summary>
        /// <param name="m">Tipo de mensaje a mostrar</param>
        /// <param name="mensaje">Mensaje a mostrar</param>
        /// <param name="titulo">Titulo de la ventana</param>
        public frmMensaje(Mensajes m, string mensaje, string titulo)
        {
            InitializeComponent();
            this.m = m;
            this.mensaje = mensaje;
            this.lblTitulo.Text = titulo;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        /// <summary>
        /// Método que módifica la interfaz de la ventana (colores, icono) dependiendo del tipo de mensaje seleccionado.
        /// </summary>
        private void CargarTema()
        {
            switch (m)
            {
                case Mensajes.Exito:
                    pcbIcono.Image = global::EC_Admin.Properties.Resources.IconoExito;
                    pnlImagen.BackColor = Colores.Exito;
                    this.ForeColor = Colores.ExitoObscuro;
                    BotonOK();
                    break;
                case Mensajes.Informativo:
                    pcbIcono.Image = global::EC_Admin.Properties.Resources.IconoInformativo;
                    pnlImagen.BackColor = Colores.Info;
                    this.ForeColor = Colores.InfoObscuro;
                    BotonOK();
                    break;
                case Mensajes.Alerta:
                    pcbIcono.Image = global::EC_Admin.Properties.Resources.IconoAlerta;
                    pnlImagen.BackColor = Colores.Alerta;
                    this.ForeColor = Colores.AlertaObscuro;
                    BotonOK();
                    break;
                case Mensajes.Error:
                    pcbIcono.Image = global::EC_Admin.Properties.Resources.IconoError;
                    pnlImagen.BackColor = Colores.Error;
                    this.ForeColor = Colores.ErrorObscuro;
                    BotonOK();
                    break;
                case Mensajes.Pregunta:
                    pcbIcono.Image = global::EC_Admin.Properties.Resources.IconoPregunta;
                    pnlImagen.BackColor = Colores.Info;
                    this.ForeColor = Colores.InfoObscuro;
                    BotonesPregunta();
                    break;
            }
        }

        /// <summary>
        /// Método que adapta el tamaño del lblMensaje de acuerdo al ancho del panel que lo contiene.
        /// </summary>
        private void MostrarMensaje()
        {
            //Creamos una variable que contendrá el mensaje que vamos a mostrar temporalmente.
            string mnsTmp = "";
            //Creamos una nueva variable de gráficos.
            Graphics e = this.CreateGraphics();
            //Separamos todas las palabras del mensaje.
            string[] palabras = mensaje.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string p in palabras)
            {
                //Calculamos el ancho de la palabra una vez que la concatenemos, esto con el fin de compararla con el ancho del panel contenedor
                float ancho = e.MeasureString(mnsTmp += " " + p, new Font("Corbel", 11, FontStyle.Bold)).Width;
                //Comparamos si el ancho de la concatenación es menor que el ancho del panel, en caso de ser así, se va concatenando la palabra
                //al lblMensaje, en caso contrario, realiza un salto de linea y vuelve a empezar la concatenación.
                if (ancho < pnlMensaje.Width)
                {
                    if (lblMensaje.Text != "")
                    {
                        lblMensaje.Text += " " + p;
                    }
                    else
                    {
                        lblMensaje.Text += p;
                    }
                }
                else
                {
                    lblMensaje.Text += "\n" + p;
                    mnsTmp = p;
                }
            }
            //Centramos el lblMensaje
            lblMensaje.Left = (pnlMensaje.Width - lblMensaje.Width) / 2;
        }

        /// <summary>
        /// Crea el botón OK para su uso en la mayoria de los formularios
        /// </summary>
        private void BotonOK()
        {
            Button btnOK = new Button();
            btnOK.Name = "btnOK";
            btnOK.BackColor = Colores.Obscuro;
            btnOK.ForeColor = Colores.Claro;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatAppearance.MouseDownBackColor = Colores.ClaroObscuro;
            btnOK.FlatAppearance.MouseOverBackColor = Colores.ObscuroClaro;
            btnOK.Size = new System.Drawing.Size(97, 30);
            btnOK.Text = "OK";
            btnOK.Location = new Point(pnlMensaje.Width - btnOK.Width - 10, pnlMensaje.Height - btnOK.Height - 10);
            btnOK.Click += new EventHandler(btnOK_Click);
            pnlMensaje.Controls.Add(btnOK);
            this.AcceptButton = btnOK;
        }

        /// <summary>
        /// Crea los botones para la respuesta en el tipo de mensaje pregunta
        /// </summary>
        private void BotonesPregunta()
        {
            Button btnSi = new Button();
            Button btnNo = new Button();
            Button btnCancelar = new Button();

            btnSi.Name = "btnSi";
            btnNo.Name = "btnNo";
            btnCancelar.Name = "btnCancelar";
            btnSi.BackColor = btnNo.BackColor = btnCancelar.BackColor = Colores.Obscuro;
            btnSi.ForeColor = btnNo.ForeColor = btnCancelar.ForeColor = Colores.Claro;
            btnSi.FlatStyle = btnNo.FlatStyle = btnCancelar.FlatStyle = FlatStyle.Flat;
            btnSi.FlatAppearance.BorderSize = btnNo.FlatAppearance.BorderSize = btnCancelar.FlatAppearance.BorderSize = 0;
            btnSi.FlatAppearance.MouseDownBackColor = btnNo.FlatAppearance.MouseDownBackColor = btnCancelar.FlatAppearance.MouseDownBackColor = Colores.ClaroObscuro;
            btnSi.FlatAppearance.MouseOverBackColor = btnNo.FlatAppearance.MouseOverBackColor = btnCancelar.FlatAppearance.MouseOverBackColor = Colores.ObscuroClaro;
            btnSi.Size = btnNo.Size = btnCancelar.Size = new System.Drawing.Size(97, 30);
            btnSi.Text = "Si";
            btnNo.Text = "No";
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(pnlMensaje.Width - btnNo.Width - 10, pnlMensaje.Height - btnNo.Height - 10);
            btnNo.Location = new Point(btnCancelar.Left - btnNo.Width - 10, btnCancelar.Top);
            btnSi.Location = new Point(btnNo.Left - btnSi.Width - 10, btnNo.Top);
            btnSi.Click += new EventHandler(btnSi_Click);
            btnNo.Click += new EventHandler(btnNo_Click);
            btnCancelar.Click += new EventHandler(btnCancelar_Click);
            pnlMensaje.Controls.Add(btnSi);
            pnlMensaje.Controls.Add(btnNo);
            pnlMensaje.Controls.Add(btnCancelar);
        }

        private void frmError_Load(object sender, EventArgs e)
        {
            CargarTema();
            MostrarMensaje();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Colores.Claro;
            lblCerrar.BackColor = Colores.ErrorObscuro;
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Colores.ErrorObscuro;
            lblCerrar.BackColor = Colores.Claro;
        }

        private void frmError_MouseDown(object sender, MouseEventArgs e)
        {
            //Usamos el API de Windows para mover el formulario en el evento MouseDown
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
