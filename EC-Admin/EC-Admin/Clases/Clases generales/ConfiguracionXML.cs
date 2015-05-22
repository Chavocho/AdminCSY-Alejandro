using System;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class ConfiguracionXML
    {
        /// <summary>
        /// Función que lee el valor del atributo dado del archivo de configuración XML
        /// </summary>
        /// <param name="nodoPrincipal">Sub Nodo principal del cual se leera la información</param>
        /// <param name="nodoSecundario">Nodo secundario que se encuentra dentro del nodo principal del cual se
        /// desea leer su valor</param>
        /// <exception cref="System.Xml.XmlException">Devuelve información detallada sobre la última excepción.</exception>
        /// <exception cref="System.IO.PathTooLongException">Excepción que se produce cuando una ruta de acceso o un nombre de archivo supera la longitud máxima definida por el sistema.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">Excepción que se produce cuando no encuentra parte de un archivo o directorio.</exception>
        /// <exception cref="System.IO.FileNotFoundException">Excepción que se produce cuando se produce un error al intentar tener acceso a un archivo que no existe en el disco.</exception>
        /// <exception cref="System.IO.IOException">Excepción que es lanzada cuando se produce un error de E/S.</exception>
        /// <exception cref="System.NotSupportedException">Excepción que se produce cuando no se admite un método invocado o cuando se intenta leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Excepción que se produce cuando el sistema operativo deniega el acceso a causa de un error de E/S o de un error de seguridad de un tipo concreto.</exception>
        /// <exception cref="System.Security.SecurityException">La excepción que se produce cuando se detecta un error de seguridad.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        /// <returns>Valor guardado en el nodo</returns>
        public static string LeerConfiguración(string nodoPrincipal, string nodoSecundario)
        {
            string dato = "";
            ExisteArchivoConfiguracion(true);
            try
            {
                //Declaramos la ruta del archivo (debería ser global en la clase)
                string ruta = Application.StartupPath + "\\ArchivosConfiguracion\\configuracion.chev";
                //Creamos un objeto del tipo XmlDocument para leer el archivo
                XmlDocument xml = new XmlDocument();
                xml.Load(ruta);
                //Obtenemos el nodo principal (el de <configuraciones>) y a partir de ese sacaremos los datos
                XmlNodeList nodo = xml.GetElementsByTagName("configuraciones");
                //Obtenemos el primer nodo (el recibido del parametro) a partir del nodo principal
                XmlNodeList nodoPrin = ((XmlElement)nodo[0]).GetElementsByTagName(nodoPrincipal);
                //Hacemos una iteración en el primer nodo para buscar dentro de el el nodo que buscamos
                foreach (XmlElement nodoInt in nodoPrin)
                {
                    //Obtenemos el segundo nodo a partir del primer nodo para tener acceso a su información
                    XmlNodeList nodoSec = nodoInt.GetElementsByTagName(nodoSecundario);
                    dato = Criptografia.Descifrar(nodoSec[0].InnerText);
                }
            }
            catch (XmlException ex)
            {
                throw ex;
            }
            catch (PathTooLongException ex)
            {
                throw ex;
            }
            catch (DirectoryNotFoundException ex)
            {
                throw ex;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw ex;
            }
            catch (System.Security.SecurityException ex)
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
            return dato;
        }

        /// <summary>
        /// Función que guarda determinada configuración
        /// </summary>
        /// <param name="nodoPrincipal">Nombre del nodo que contiene el grupo de configuración</param>
        /// <param name="nodoSecundario">Nombre del nodo tiene determinada configuración</param>
        /// <param name="valor">Valor de la configuración</param>
        /// /// <exception cref="System.Xml.XmlException">Devuelve información detallada sobre la última excepción.</exception>
        /// <exception cref="System.IO.PathTooLongException">Excepción que se produce cuando una ruta de acceso o un nombre de archivo supera la longitud máxima definida por el sistema.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">Excepción que se produce cuando no encuentra parte de un archivo o directorio.</exception>
        /// <exception cref="System.IO.FileNotFoundException">Excepción que se produce cuando se produce un error al intentar tener acceso a un archivo que no existe en el disco.</exception>
        /// <exception cref="System.IO.IOException">Excepción que es lanzada cuando se produce un error de E/S.</exception>
        /// <exception cref="System.InvalidOperationException">Excepción que se produce cuando una llamada a un método no es válida para el estado actual del objeto.</exception>
        /// <exception cref="System.NotSupportedException">Excepción que se produce cuando no se admite un método invocado o cuando se intenta leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Excepción que se produce cuando el sistema operativo deniega el acceso a causa de un error de E/S o de un error de seguridad de un tipo concreto.</exception>
        /// <exception cref="System.Security.SecurityException">La excepción que se produce cuando se detecta un error de seguridad.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        public static void GuardarConfiguracion(string nodoPrincipal, string nodoSecundario, string valor)
        {
            string ruta = Application.StartupPath + "\\ArchivosConfiguracion\\configuracion.chev";
            ExisteArchivoConfiguracion(true);
            try
            {
                if (ExisteConfiguracion(nodoPrincipal))
                {
                    if (ExisteConfiguracion(nodoPrincipal, nodoSecundario))
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.Load(ruta);
                        XmlNode nodoPrimario = xml.DocumentElement;
                        foreach (XmlNode nodo1 in nodoPrimario)
                            if (nodo1.Name == nodoPrincipal)
                                foreach (XmlNode nodo2 in nodo1)
                                    if (nodo2.Name == nodoSecundario)
                                        nodo2.InnerText = Criptografia.Cifrar(valor);
                        xml.Save(ruta);
                    }
                    else
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.Load(ruta);
                        XmlNode nodoPrimario = xml.DocumentElement;
                        foreach (XmlNode nodo1 in nodoPrimario)
                            if (nodo1.Name == nodoPrincipal)
                            {
                                XmlNode nodo2 = xml.CreateNode(XmlNodeType.Element, nodoSecundario, null);
                                nodo2.InnerText = Criptografia.Cifrar(valor);
                                nodo1.AppendChild(nodo2);
                            }
                        xml.Save(ruta);
                    }
                }
                else
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(ruta);
                    XmlNode nodoPrimario = xml.DocumentElement;
                    XmlNode nodo1 = xml.CreateNode(XmlNodeType.Element, nodoPrincipal, null);
                    nodoPrimario.AppendChild(nodo1);
                    xml.Save(ruta);
                    GuardarConfiguracion(nodoPrincipal, nodoSecundario, valor);
                }
            }
            catch (XmlException ex)
            {
                throw ex;
            }
            catch (PathTooLongException ex)
            {
                throw ex;
            }
            catch (DirectoryNotFoundException ex)
            {
                throw ex;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw ex;
            }
            catch (System.Security.SecurityException ex)
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

        /// <summary>
        /// Función que verifica que exista determinada configuración
        /// </summary>
        /// <param name="nodoPrincipal">Nombre de el grupo de configuración</param>
        /// <exception cref="System.Xml.XPath.XPathException">Proporciona la excepción que se produce cuando aparece un error al procesar una expresión Xpath.</exception>
        /// <exception cref="System.Xml.XmlException">Devuelve información detallada sobre la última excepción.</exception>
        /// <exception cref="System.IO.PathTooLongException">Excepción que se produce cuando una ruta de acceso o un nombre de archivo supera la longitud máxima definida por el sistema.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">Excepción que se produce cuando no encuentra parte de un archivo o directorio.</exception>
        /// <exception cref="System.IO.FileNotFoundException">Excepción que se produce cuando se produce un error al intentar tener acceso a un archivo que no existe en el disco.</exception>
        /// <exception cref="System.IO.IOException">Excepción que es lanzada cuando se produce un error de E/S.</exception>
        /// <exception cref="System.NotSupportedException">Excepción que se produce cuando no se admite un método invocado o cuando se intenta leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Excepción que se produce cuando el sistema operativo deniega el acceso a causa de un error de E/S o de un error de seguridad de un tipo concreto.</exception>
        /// <exception cref="System.Security.SecurityException">La excepción que se produce cuando se detecta un error de seguridad.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        /// <returns>Valor booleano que indica si la configuración ingresada existe.</returns>
        public static bool ExisteConfiguracion(string nodoPrincipal)
        {
            bool existe = false;
            ExisteArchivoConfiguracion(true);
            try
            {
                string ruta = Application.StartupPath + "\\ArchivosConfiguracion\\configuracion.chev";
                XmlDocument xml = new XmlDocument();
                xml.Load(ruta);
                if (xml.SelectSingleNode("//" + nodoPrincipal) != null)
                    existe = true;
                else
                    existe = false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                throw ex;
            }
            catch (XmlException ex)
            {
                throw ex;
            }
            catch (PathTooLongException ex)
            {
                throw ex;
            }
            catch (DirectoryNotFoundException ex)
            {
                throw ex;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw ex;
            }
            catch (System.Security.SecurityException ex)
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
            return existe;
        }

        /// <summary>
        /// Función que verifica que exista determinada configuración
        /// </summary>
        /// <param name="nodoPrincipal">Nombre de el grupo de configuración</param>
        /// <param name="nodoSecundario">Nombre de la configuración especifica</param>
        /// <exception cref="System.Xml.XPath.XPathException">Proporciona la excepción que se produce cuando aparece un error al procesar una expresión Xpath.</exception>
        /// <exception cref="System.Xml.XmlException">Devuelve información detallada sobre la última excepción.</exception>
        /// <exception cref="System.IO.PathTooLongException">Excepción que se produce cuando una ruta de acceso o un nombre de archivo supera la longitud máxima definida por el sistema.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">Excepción que se produce cuando no encuentra parte de un archivo o directorio.</exception>
        /// <exception cref="System.IO.FileNotFoundException">Excepción que se produce cuando se produce un error al intentar tener acceso a un archivo que no existe en el disco.</exception>
        /// <exception cref="System.IO.IOException">Excepción que es lanzada cuando se produce un error de E/S.</exception>
        /// <exception cref="System.NotSupportedException">Excepción que se produce cuando no se admite un método invocado o cuando se intenta leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Excepción que se produce cuando el sistema operativo deniega el acceso a causa de un error de E/S o de un error de seguridad de un tipo concreto.</exception>
        /// <exception cref="System.Security.SecurityException">La excepción que se produce cuando se detecta un error de seguridad.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        /// <returns>Valor booleano que indica si la configuración ingresada existe.</returns>
        public static bool ExisteConfiguracion(string nodoPrincipal, string nodoSecundario)
        {
            bool existe = false;
            ExisteArchivoConfiguracion(true);
            try
            {
                string ruta = Application.StartupPath + "\\ArchivosConfiguracion\\configuracion.chev";
                XmlDocument xml = new XmlDocument();
                xml.Load(ruta);
                if (xml.SelectSingleNode("//" + nodoPrincipal + "//" + nodoSecundario) != null)
                    existe = true;
                else
                    existe = false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                throw ex;
            }
            catch (XmlException ex)
            {
                throw ex;
            }
            catch (PathTooLongException ex)
            {
                throw ex;
            }
            catch (DirectoryNotFoundException ex)
            {
                throw ex;
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (NotSupportedException ex)
            {
                throw ex;
            }
            catch (UnauthorizedAccessException ex)
            {
                throw ex;
            }
            catch (System.Security.SecurityException ex)
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
            return existe;
        }

        /// <summary>
        /// Función que, primero verifica que exista el archivo de configuración, y en caso de no existir,
        /// lo crea con los nodos principales
        /// <exception cref="System.Text.EncoderFallbackException">La excepción que se produce cuando se produce un error en la operación de reserva de codificador.</exception>
        /// <exception cref="System.IO.PathTooLongException">Excepción que se produce cuando una ruta de acceso o un nombre de archivo supera la longitud máxima definida por el sistema.</exception>
        /// <exception cref="System.IO.DirectoryNotFoundException">Excepción que se produce cuando no encuentra parte de un archivo o directorio.</exception>
        /// <exception cref="System.IO.FileNotFoundException">Excepción que se produce cuando se produce un error al intentar tener acceso a un archivo que no existe en el disco.</exception>
        /// <exception cref="System.IO.IOException">Excepción que es lanzada cuando se produce un error de E/S.</exception>
        /// <exception cref="System.NotSupportedException">Excepción que se produce cuando no se admite un método invocado o cuando se intenta leer, buscar o escribir en una secuencia que no admite la funcionalidad invocada.</exception>
        /// <exception cref="System.UnauthorizedAccessException">Excepción que se produce cuando el sistema operativo deniega el acceso a causa de un error de E/S o de un error de seguridad de un tipo concreto.</exception>
        /// <exception cref="System.Security.SecurityException">La excepción que se produce cuando se detecta un error de seguridad.</exception>
        /// <exception cref="System.InvalidOperationException">Excepción que se produce cuando una llamada a un método no es válida para el estado actual del objeto.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de una aplicación.</exception>
        /// </summary>
        public static void ExisteArchivoConfiguracion(bool crear)
        {
            string ruta = Application.StartupPath + "\\ArchivosConfiguracion";
            if (!File.Exists(ruta + "\\configuracion.chev"))
            {
                Directory.CreateDirectory(ruta);
                try
                {
                    XmlTextWriter xtw = new XmlTextWriter(ruta + "\\configuracion.chev", Encoding.UTF8);
                    xtw.WriteStartDocument(false);
                    xtw.WriteStartElement("configuraciones");
                    xtw.WriteEndElement();
                    xtw.WriteEndDocument();
                    xtw.Close();
                    xtw.Dispose();
                }
                catch (System.Text.EncoderFallbackException ex)
                {
                    throw ex;
                }
                catch (PathTooLongException ex)
                {
                    throw ex;
                }
                catch (DirectoryNotFoundException ex)
                {
                    throw ex;
                }
                catch (FileNotFoundException ex)
                {
                    throw ex;
                }
                catch (IOException ex)
                {
                    throw ex;
                }
                catch (NotSupportedException ex)
                {
                    throw ex;
                }
                catch (UnauthorizedAccessException ex)
                {
                    throw ex;
                }
                catch (System.Security.SecurityException ex)
                {
                    throw ex;
                }
                catch (InvalidOperationException ex)
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

        /// <summary>
        /// Función que verifica que el archivo de configuración exista
        /// </summary>
        /// <returns>Valor booleano que indica si el archivo existe</returns>
        public static bool ExisteArchivoConfiguracion()
        {
            bool existe;
            string ruta = Application.StartupPath + "\\ArchivosConfiguracion";
            if (File.Exists(ruta + "\\configuracion.chev"))
                existe = true;
            else
                existe = false;
            return existe;
        }
    }
}
