using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public class Config
    {
        public static decimal iva = 0M;
        public static int cantMedioMayoreo = 0;
        public static int cantMayoreo = 0;

        #region Base de datos
        public static string baseDatos = "", servidor = "", usuario = "", pass = "";
        public static int idMySQL = -1;
        #endregion

        #region Correo
        public static string correoOrigenInterno = "", contraseñaOrigenInterno = "", puertoInterno = "", hostInterno = "", 
            correoOrigenExterno = "", contraseñaOrigenExterno = "", puertoExterno = "", hostExterno = "";
        #endregion

        #region Sonidos
        public static string rutaSonidoObturador = Application.StartupPath + "\\Sonidos\\obturador.wav";
        #endregion

        #region Sucursal
        public static int idSucursal = 0;
        public static string nombreSucursal = "";
        #endregion
    }
}
