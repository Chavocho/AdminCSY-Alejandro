using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    abstract public class PersonaContacto
    {
        #region Propiedades

        abstract public int ID
        {
            get;
            set;
        }

        abstract public int IDPersona
        {
            get;
        }

        abstract public string Nombre
        {
            get;
            set;
        }

        abstract public string Apellidos
        {
            get;
            set;
        }

        abstract public string Telefono01
        {
            get;
            set;
        }

        abstract public string Telefono02
        {
            get;
            set;
        }

        abstract public string Extension
        {
            get;
            set;
        }

        abstract public string Celular
        {
            get;
            set;
        }

        abstract public string Lada01
        {
            get;
            set;
        }

        abstract public string Lada02
        {
            get;
            set;
        }

        abstract public string Correo
        {
            get;
            set;
        }

        abstract public int CreateUser
        {
            get;
        }

        abstract public DateTime CreateTime
        {
            get;
        }

        abstract public int UpdateUser
        {
            get;
        }

        abstract public DateTime UpdateTime
        {
            get;
        }

        abstract public List<int> IDCS
        {
            get;
        }

        abstract public List<string> NombreContactos
        {
            get;
        }

        abstract public List<string> ApellidoContactos
        {
            get;
        }

        abstract public List<string> TelefonoContactos01
        {
            get;
        }

        abstract public List<string> TelefonoContactos02
        {
            get;
        }

        abstract public List<string> ExtensionContactos
        {
            get;
        }

        abstract public List<string> CelularContactos
        {
            get;
        }

        abstract public List<string> LadaContactos01
        {
            get;
        }

        abstract public List<string> LadaContactos02
        {
            get;
        }

        abstract public List<string> CorreoContactos
        {
            get;
        }

        abstract public List<int> CreateUserContactos
        {
            get;
        }

        abstract public List<DateTime> CreateTimeContactos
        {
            get;
        }

        abstract public List<int> UpdateUserContactos
        {
            get;
        }

        abstract public List<DateTime> UpdateTimeContactos
        {
            get;
        }
        #endregion

        abstract public void ObtenerDatosContacto();
        abstract protected void ObtenerContactos();
        abstract public void Insertar();
        abstract public void Editar();
    }
}
