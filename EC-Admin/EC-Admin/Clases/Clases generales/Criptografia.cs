using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Criptografia
    {
        private static string clave = "Tres tristes tigres tragaban trigo en un trigal";

        /// <summary>
        /// Función que cifra una cadena para una mayor seguridad
        /// </summary>
        /// <param name="cadena">Cadena a cifrar</param>
        /// <returns>Cadena original cifrada</returns>
        /// <exception cref="System.ObjectDisposedException">Excepción que se produce cuando se realiza una operación en un objeto desechado</exception>
        /// <exception cref="System.InvalidOperationException">Excepción que se produce cuando una llamada a un método no es válida para el estado actual del objeto.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.Text.EncoderFallbackException">La excepción que se produce cuando se produce un error en la operación de reserva de codificador.</exception>
        /// <exception cref="System.Security.Cryptography.CryptographicException">Excepción que se produce cuando se produce un error durante una operación criptográfica.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de un programa.</exception>
        public static string Cifrar(string cadena)
        {
            byte[] llave = null; //Arreglo donde guardaremos la llave para el cifrado 3DES.
            byte[] arreglo = null; //Arreglo donde guardaremos la cadena descifrada.
            byte[] resultado = null;
            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5;
            try
            {
                md5 = new MD5CryptoServiceProvider();
                arreglo = UTF8Encoding.UTF8.GetBytes(cadena);
                llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
                md5.Clear();

                //Ciframos utilizando el Algoritmo 3DES.
                TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
                tripledes.Key = llave;
                tripledes.Mode = CipherMode.ECB;
                tripledes.Padding = PaddingMode.PKCS7;
                ICryptoTransform convertir = tripledes.CreateEncryptor(); // Iniciamos la conversión de la cadena
                resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length); //Arreglo de bytes donde guardaremos la cadena cifrada.
                tripledes.Clear();
            }
            catch (ObjectDisposedException ex)
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
            catch (EncoderFallbackException ex)
            {
                throw ex;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToBase64String(resultado, 0, resultado.Length); // Convertimos la cadena y la regresamos.
        }

        /// <summary>
        /// Función que descifra una cadena cifrada
        /// </summary>
        /// <param name="cadena">Cadena cifrada</param>
        /// <returns>Cadena con su valor original</returns>
        /// <exception cref="System.FormatException">Excepción que se produce cuando el formato de un argumento no cumple las especificaciones de los parámetros del método invocado.</exception>
        /// <exception cref="System.Text.EncoderFallbackException">La excepción que se produce cuando se produce un error en la operación de reserva de codificador.</exception>
        /// <exception cref="System.Text.DecoderFallbackException">Excepción que se produce cuando una operación de retroceso del descodificador (decoder fallback) no se realiza correctamente.</exception>
        /// <exception cref="System.Security.Cryptography.CryptographicException">Excepción que se produce cuando se produce un error durante una operación criptográfica.</exception>
        /// <exception cref="System.ObjectDisposedException">Excepción que se produce cuando se realiza una operación en un objeto desechado</exception>
        /// <exception cref="System.InvalidOperationException">Excepción que se produce cuando una llamada a un método no es válida para el estado actual del objeto.</exception>
        /// <exception cref="System.ArgumentNullException">Excepción que se produce cuando se pasa una referencia nula a un método que no la acepta como argumento válido.</exception>
        /// <exception cref="System.ArgumentException">Excepción que se produce cuando no es válido uno de los argumentos proporcionados para un método.</exception>
        /// <exception cref="System.Exception">Representa los errores que se producen durante la ejecución de un programa.</exception>
        public static string Descifrar(string cadena)
        {
            byte[] llave = null;
            byte[] arreglo = null; // Arreglo donde guardaremos la cadena descovertida.
            byte[] resultado = null;
            string cadena_descifrada = null;
            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5;
            try
            {
                md5 = new MD5CryptoServiceProvider();
                arreglo = Convert.FromBase64String(cadena);
                llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
                md5.Clear();

                //Ciframos utilizando el Algoritmo 3DES.
                TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
                tripledes.Key = llave;
                tripledes.Mode = CipherMode.ECB;
                tripledes.Padding = PaddingMode.PKCS7;
                ICryptoTransform convertir = tripledes.CreateDecryptor();
                resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length);
                tripledes.Clear();
                cadena_descifrada = UTF8Encoding.UTF8.GetString(resultado); // Obtenemos la cadena
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            catch (EncoderFallbackException ex)
            {
                throw ex;
            }
            catch (DecoderFallbackException ex)
            {
                throw ex;
            }
            catch (CryptographicException ex)
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
            return cadena_descifrada; // Devolvemos la cadena
        }
    }
}
