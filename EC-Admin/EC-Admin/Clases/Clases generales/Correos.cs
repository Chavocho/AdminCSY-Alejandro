using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Correos
    {
        bool esInterno;
        MailMessage email;
        SmtpClient smtp;
        Thread hiloCorreo;

        #region Propiedades
        private string correosDestino;
        private string correoOrigen;
        private string contraseña;
        private string asunto;
        private string cuerpo;
        private string host;
        private int puerto;

        public string CorreoOrigen
        {
            get { return correoOrigen; }
            set { correoOrigen = value; }
        }

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        /// <summary>
        /// Destinatarios a los que se enviará el correo, deben ir separado por coma y/o espacio.
        /// </summary>
        public string CorreosDestino
        {
            get { return correosDestino; }
            set { correosDestino = value; }
        }

        public string Asunto
        {
            get { return asunto; }
            set { asunto = value; }
        }

        public string Cuerpo
        {
            get { return cuerpo; }
            set { cuerpo = value; }
        }

        private string[] adjuntos;

        public string[] Adjuntos
        {
            get { return adjuntos; }
            set { adjuntos = value; }
        }

        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        public int Puerto
        {
            get { return puerto; }
            set { puerto = value; }
        }
        #endregion

        /// <summary>
        /// Inicializa la instancia de la clase CCorreos
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        public Correos(bool esInterno)
        {
            try
            {
                this.esInterno = esInterno;
                hiloCorreo = new Thread(new ThreadStart(Correo));
            }
            catch (ArgumentNullException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Envia el correo con los datos de las propiedades definidas
        /// </summary>
        /// <exception cref="System.Threading.ThreadStateException">Excepción que se produce cuando un Thread es un ThreadState que no es válido para la llamada de método.</exception>
        /// <exception cref="System.OutOfMemoryException">Excepción que se produce cuando no hay suficiente memoria para continuar con la ejecución de un programa.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        public void EnviarCorreo()
        {
            try
            {
                hiloCorreo.Start();
            }
            catch (ThreadStateException ex)
            {
                throw ex;
            }
            catch (OutOfMemoryException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Función que ejecutará el hilo
        /// </summary>
        /// <param name="argumento">Arreglo con la información que necesita la función para poderse ejecutar</param>
        /// <exception cref="System.Net.Mail.SmtpFailedRecipientsException">Esta API es compatible con la infraestructura de .NET Framework y no está diseñada para utilizarse directamente desde el código.
        /// La excepción que se produce cuando se envía un correo electrónico utilizando un SmtpClient y no se puede enviar a todos los destinatarios.</exception>
        /// <exception cref="System.Net.Mail.SmtpException">Representa la excepción que se produce cuando el objeto SmtpClient no puede completar una operación Send o una operación SendAsync.</exception>
        /// <exception cref="System.FormatException">Excepción que se produce cuando el formato de un argumento no cumple las especificaciones de los parámetros del método invocado.</exception>
        /// <exception cref="System.ObjectDisposedException">Excepción que se produce cuando se realiza una operación en un objeto desechado.</exception>
        /// <exception cref="System.InvalidOperationException">Excepción que se produce cuando una llamada a un método no es válida para el estado actual del objeto.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Excepción que se produce cuando el valor de un argumento se encuentra fuera del intervalo de valores permitido definido por el método invocado.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        /* Información que guarda el parametro en sus diferentes posiciones
            0: Correo Origen
            1: Contraseña correo origen
            2: Correos destino, separados por comas
            3: Asunto
            4: Cuerpo
            5: Adjuntos
        */
        private void Correo()
        {
            try
            {
                if (ConfiguracionXML.ExisteConfiguracion("correo"))
                {
                    email = new MailMessage();
                    smtp = new SmtpClient();
                    string[] destinatarios = correosDestino.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    smtp.Credentials = new NetworkCredential(@correoOrigen, @contraseña);
                    smtp.Host = host;
                    smtp.Port = puerto;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    for (int i = 0; i < destinatarios.Length; i++)
                        email.To.Add(new MailAddress(destinatarios[i]));
                    if (!esInterno)
                    {
                        email.From = new MailAddress(Config.correoOrigenExterno, "Admin CSY", Encoding.UTF8);
                    }
                    else
                    {
                        email.From = new MailAddress(Config.correoOrigenInterno, "Admin CSY", Encoding.UTF8);
                    }
                    email.Subject = asunto;
                    email.Body = cuerpo;
                    email.IsBodyHtml = false;
                    if (adjuntos != null)
                        for (int i = 0; i < adjuntos.Length; i++)
                            email.Attachments.Add(new Attachment(adjuntos[i]));
                    smtp.Send(email);
                    email.Dispose();
                    smtp.Dispose();
                }
            }
            catch (SmtpFailedRecipientsException ex)
            {
                throw ex;
            }
            catch (SmtpException ex)
            {
                throw ex;
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (ObjectDisposedException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
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
            }
        }
    }
}
