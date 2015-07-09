using System;
using System.Data;
using System.Security.Cryptography;
using System.Xml;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using System.Media;
using System.Diagnostics;

namespace EC_Admin
{
    class FuncionesGenerales
    {
        static frmEspera frm;

        #region Variables
        const int SWP_NOSIZE = 0x1;
        const int SWP_NOMOVE = 0x2;
        const int SWP_NOACTIVATE = 0x10;
        const int wFlags = SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE;
        const int HWND_TOPMOST = -1;
        const int HWND_NOTOPMOST = -2;
        #endregion

        /// <summary>
        /// Función que valida que un TextBox solo sea númerico
        /// </summary>
        /// <param name="sender">TextBox al que se le desea hacer la validación</param>
        /// <param name="e">Variable de evento</param>
        /// <param name="soloEnteros">Valor booleano que indica si solo pueden entrar números enteros al campo</param>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de un programa.</exception>
        public static void VerificarEsNumero(ref object sender, ref KeyPressEventArgs e, bool soloEnteros)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                if (soloEnteros && e.KeyChar == '.')
                {
                    e.Handled = true;
                }
                if (txt.Text == "" && e.KeyChar == '.' && !soloEnteros)
                {
                    txt.Text = "0" + e.KeyChar;
                    txt.SelectionStart = txt.Text.Length;
                }
                if (txt.Text.Contains(".") && e.KeyChar == '.' && !soloEnteros)
                {
                    e.Handled = true;
                    return;
                }
                else if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que recibe una cadena de parametro y verifica que sea un correo electrónico valido.
        /// </summary>
        /// <param name="correo">Cadena de la cual se desea verificar sea un correo valido</param>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">Excepción que se produce cuando el tiempo de ejecución de un método de coincidencia de expresión regular supera su intervalo de tiempo de espera.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de un programa.</exception>
        /// <returns>Valor booleano que indica si es un correo valido</returns>
        public static bool EsCorreoValido(string correo)
        {
            bool valido = false;
            try
            {
                Regex reg = new Regex("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@" +
                                        "(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
                Match m = reg.Match(correo);
                valido = m.Success;
            }
            catch (RegexMatchTimeoutException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return valido;
        }

        /// <summary>
        /// Función que compara que dos imagenes sean iguales
        /// </summary>
        /// <param name="img01">Primer imagen a comparar</param>
        /// <param name="img02">Segunda imagen a comparar</param>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de un programa.</exception>
        /// <returns>Valor booleano que indica si las dos imagenes son iguales</returns>
        public static bool CompararImagenes(Bitmap img01, Bitmap img02)
        {
            bool sonIguales = true;
            try
            {
                string pxl01;
                string pxl02;
                if (img01 != null && img02 != null)
                {
                    if (img01.Width == img02.Width && img01.Height == img02.Height)
                    {
                        for (int i = 0; i < img01.Width; i++)
                        {
                            for (int j = 0; j < img01.Height; j++)
                            {
                                pxl01 = img01.GetPixel(i, j).ToString();
                                pxl02 = img02.GetPixel(i, j).ToString();
                                if (pxl01 != pxl02)
                                {
                                    sonIguales = false;
                                    break;
                                }
                            }
                            if (sonIguales == false)
                                break;
                        }
                    }
                    else
                        sonIguales = false;
                }
                else
                    sonIguales = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sonIguales;
        }

        /// <summary>
        /// Función que convierte una imagen a un arreglo de bytes
        /// </summary>
        /// <param name="img">Imagen en formato .jpeg que se convertirá a bytes</param>
        /// <exception cref="System.Runtime.InteropServices.ExternalException">El tipo de excepción base para todas las excepciones de interoperabilidad COM y excepciones de control de excepciones estructurado (SEH).</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de un programa.</exception>
        /// <returns>Arreglo de bytes que contienen la imagen</returns>
        public static byte[] ImagenBytes(Image img)
        {
            byte[] bimg = null;
            if (img == null)
                return bimg;
            try
            {
                MemoryStream m = new MemoryStream();
                img.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                bimg = m.ToArray();
            }
            catch (System.Runtime.InteropServices.ExternalException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bimg;
        }

        /// <summary>
        /// Función que convierte un arreglo de bytes a imagen
        /// </summary>
        /// <param name="bimg">Arreglo de bytes que se convertirán en una imagen</param>
        /// <exception cref="System.IO.IOException">Excepción que es lanzada cuando se produce un error de E/S.</exception>
        /// <exception cref="System.ObjectDisposedException">Excepción que se produce cuando se realiza una operación en un objeto desechado.</exception>
        /// <exception cref="System.NotSupportedException">Excepción que se produce cuando no se admite un método invocado o cuando se intenta leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Excepción que se produce cuando el valor de un argumento se encuentra fuera del intervalo de valores permitido definido por el método invocado.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de un programa.</exception>
        /// <returns>Imagen en formato .jpeg</returns>
        public static Image BytesImagen(byte[] bimg)
        {
            Image img = null;
            try
            {
                MemoryStream m = new MemoryStream(bimg);
                m.Write(bimg, 0, bimg.Length);
                img = Image.FromStream(m, true);
            }
            catch (System.IO.IOException ex)
            {
                throw ex;
            }
            catch (ObjectDisposedException ex)
            {
                throw ex;
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.Message, "GymCSY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return img;
        }

        /// <summary>
        /// Función que redimensiona una imagen a una resolución dada sin recorte
        /// </summary>
        /// <param name="imgPhoto">Imagen a redimensionar</param>
        /// <param name="size">Tamaño al que se desea redimensionar la imagen</param>
        /// <returns>Imagen redimensionada</returns>
        public static Image RedimensionarImagen(Image imgPhoto, Size size)
        {
            return RedimensionarImagen(imgPhoto, size.Width, size.Height);
        }

        /// <summary>
        /// Función que redimensiona una imagen a una resolución dada sin recorte
        /// </summary>
        /// <param name="imgPhoto">Imagen a redimensionar</param>
        /// <param name="Width">Ancho al que se desea redimensionar</param>
        /// <param name="Height">Alto al que se desea redimensionar</param>
        /// <returns>Imagen redimensionada</returns>
        public static Image RedimensionarImagen(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Red);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        /// <summary>
        /// Función que muestra un MessageBox con un mensaje de error y el mensaje de la excepción.
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar</param>
        /// <param name="ex">Excepción que ocurrió</param>
        public static System.Windows.Forms.DialogResult Mensaje(IWin32Window frm, Mensajes m, string mensaje, string titulo, Exception ex = null)
        {
            //return (new frmMensaje(m, mensaje, titulo)).ShowDialog(frm);
            if (m != Mensajes.Error)
                return (new frmMensaje(m, mensaje, titulo)).ShowDialog(frm);
            else
                return MessageBox.Show(ex.ToString());

        }

        /// <summary>
        /// Función que muestra el formulario de espera.
        /// </summary>
        /// <param name="mensaje">Mensaje que se mostrará en el formulario</param>
        /// <param name="f">Formulario dueño del formulario de búsqueda</param>
        public static void frmEspera(string mensaje, IWin32Window f)
        {
            frm = new frmEspera(mensaje);
            frm.AllowTransparency = false;
            frm.ShowDialog(f);
        }

        /// <summary>
        /// Función que cierra el formulario de búsqueda.
        /// </summary>
        public static void frmEsperaClose()
        {
            if (frm != null)
            {
                if (!frm.IsDisposed)
                {
                    if (frm.Visible)
                    {
                        frm.Close();
                    }
                }
            }
            frm = null;
        }

        /// <summary>
        /// Método que hace un efecto de toma de fotografía
        /// </summary>
        /// <param name="pcb">PictureBox que contiene la imagen</param>
        public static void EfectoFoto(ref PictureBox pcb)
        {
            const int duracion = 50;
            Image img = pcb.Image;
            pcb.Image = null;
            System.Threading.Thread.Sleep(duracion);
            Application.DoEvents();
            pcb.BackColor = Colores.Obscuro;
            System.Threading.Thread.Sleep(duracion);
            Application.DoEvents();
            pcb.BackColor = Colores.ClaroObscuro;
            System.Threading.Thread.Sleep(duracion);
            Application.DoEvents();
            pcb.BackColor = Colores.ObscuroClaro;
            System.Threading.Thread.Sleep(duracion);
            Application.DoEvents();
            pcb.Image = img;
            if (File.Exists(Config.rutaSonidoObturador))
            {
                SoundPlayer p = new SoundPlayer(Config.rutaSonidoObturador);
                p.Play();
            }
        }

        public static bool HayInternet()
        {
            bool hay = false;
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com.mx");
                hay = true;
            }
            catch
            {
            }
            return hay;
        }

        public static int IDProceso(string nombreProceso)
        {
            int id = -1;
            try
            {
                Process[] pr = Process.GetProcesses();
                foreach (Process p in pr)
                {
                    if (p.ProcessName.Contains(nombreProceso))
                    {
                        id = p.Id;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
        }

        public static void IniciarProceso(string rutaArchivo, string argumentos = "")
        {
            try
            {
                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo(rutaArchivo);
                psi.Arguments = argumentos;
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo = psi;
                p.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ExisteProceso(int id)
        {
            try
            {
                Process[] pr = Process.GetProcesses();
                foreach (Process p in pr)
                {
                    if (p.Id == id)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public static bool ImprimirTicket(IWin32Window frm, string mensaje)
        {
            if (ConfiguracionXML.ExisteConfiguracion("ticket"))
            {
                if (bool.Parse(ConfiguracionXML.LeerConfiguración("ticket", "imprimir")))
                {
                    if (bool.Parse(ConfiguracionXML.LeerConfiguración("ticket", "preguntar")))
                    {
                        if (Mensaje(frm, Mensajes.Pregunta, mensaje, "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void ColoresError(Control ctr)
        {
            ctr.BackColor = Colores.Error;
            ctr.ForeColor = Colores.Claro;
        }

        public static void ColoresBien(Control ctr)
        {
            if (ctr.GetType() == typeof(TextBox) || ctr.GetType() == typeof(Label))
            {
                ctr.BackColor = Colores.Claro;
                ctr.ForeColor = Colores.Obscuro;
            }
            else if (ctr.GetType() == typeof(ComboBox))
            {
                ctr.BackColor = Colores.ClaroObscuro;
                ctr.ForeColor = Colores.Obscuro;
            }
        }

        public static void DataGridViewUp(DataGridView dgv)
        {
            if (dgv.CurrentRow.Index > 0)
                dgv[1, dgv.CurrentRow.Index - 1].Selected = true;
        }

        public static void DataGridViewDown(DataGridView dgv)
        {
            if (dgv.CurrentRow.Index < dgv.RowCount - 1)
                dgv[1, dgv.CurrentRow.Index + 1].Selected = true;
        }

        #region Siempre Encima
        [DllImport("user32.DLL")]
        private extern static void SetWindowPos(
            int hWnd, int hWndInsertAfter,
            int X, int Y,
            int cx, int cy,
            int wFlags);

        /// <summary>
        /// Función que muestra una ventana encima de las otras.
        /// </summary>
        /// <param name="handle">Código de identificación de la ventana</param>
        public static void SiempreEncima(int handle)
        {
            SetWindowPos(handle, HWND_TOPMOST, 0, 0, 0, 0, wFlags);
        }

        /// <summary>
        /// Función que muestra una en un modo normal de visualización en el orden Z.
        /// </summary>
        /// <param name="handle">Código de identificación de la ventana</param>
        public static void NoSiempreEncima(int handle)
        {
            SetWindowPos(handle, HWND_NOTOPMOST, 0, 0, 0, 0, wFlags);
        }
        #endregion

        #region DesactivarBotonCerrar
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr HWNDValue, bool isRevert);

        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr tMenu, int targetItem, int targetStatus);

        internal const int SC_CLOSE = 0xF060;           //close button's code in Windows API
        internal const int MF_ENABLED = 0x00000000;     //enabled button status
        internal const int MF_GRAYED = 0x1;             //disabled button status (enabled = false)
        internal const int MF_DISABLED = 0x00000002;    //disabled button status

        /// <summary>
        /// Función que deshabilita el botón cerrar de un formulario
        /// </summary>
        /// <param name="f">Formulario al que se deshabilitará el botón cerrar</param>
        public static void DeshabilitarBotonCerrar(IWin32Window f)
        {
            EnableMenuItem(GetSystemMenu(f.Handle, false), SC_CLOSE, MF_GRAYED);
        }

        /// <summary>
        /// Función que habilita el botón cerrar de un formulario
        /// </summary>
        /// <param name="f">Formulario al que se habilitará el botón cerrar</param>
        public static void HabilitarBotonCerrar(IWin32Window f)
        {
            EnableMenuItem(GetSystemMenu(f.Handle, false), SC_CLOSE, MF_ENABLED);
        }
        #endregion

        #region Numeros
        /// <summary>
        /// Función que convierte un número a su representación númerica
        /// </summary>
        /// <param name="num">Número a convertir</param>
        /// <exception cref="System.FormatException">Excepción que se produce cuando el formato de un argumento no cumple las especificaciones de los parámetros del método invocado.</exception>
        /// <exception cref="System.OverflowException">Excepción que se produce cuando una operación aritmética, de conversión de tipo o de conversión de otra naturaleza en un contexto comprobado, da como resultado una sobrecarga.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de un programa.</exception>
        /// <returns>Representación en texto del número</returns>
        public static string ConvertirNumeroLetra(string num)
        {
            string res = "", dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
                entero = Convert.ToInt64(Math.Truncate(nro));
                decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
                if (decimales > 0)
                {
                    dec = " CON " + decimales.ToString() + "/100";
                }
                res = ConvertirATexto(Convert.ToDouble(entero)) + " PESOS " + dec + " M.N.";
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return res;
        }

        private static string ConvertirATexto(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + ConvertirATexto(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + ConvertirATexto(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = ConvertirATexto(Math.Truncate(value / 10) * 10) + " Y " + ConvertirATexto(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + ConvertirATexto(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = ConvertirATexto(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = ConvertirATexto(Math.Truncate(value / 100) * 100) + " " + ConvertirATexto(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + ConvertirATexto(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = ConvertirATexto(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + ConvertirATexto(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + ConvertirATexto(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = ConvertirATexto(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + ConvertirATexto(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + ConvertirATexto(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = ConvertirATexto(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + ConvertirATexto(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }
        #endregion
    }
}
