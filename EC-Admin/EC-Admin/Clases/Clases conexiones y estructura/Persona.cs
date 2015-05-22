using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    abstract public class Persona
    {
        #region Propiedades
        abstract public int ID
        {
            get;
            set;
        }

        abstract public int Sucursal
        {
            get;
            set;
        }

        abstract public int Cuenta
        {
            get;
            set;
        }

        abstract public string Nombre
        {
            get;
            set;
        }

        abstract public string RazonSocial
        {
            get;
            set;
        }

        abstract public string RFC
        {
            get;
            set;
        }

        abstract public string Calle
        {
            get;
            set;
        }

        abstract public string NumExt
        {
            get;
            set;
        }

        abstract public string NumInt
        {
            get;
            set;
        }

        abstract public string Colonia
        {
            get;
            set;
        }

        abstract public string Ciudad
        {
            get;
            set;
        }

        abstract public string Estado
        {
            get;
            set;
        }

        abstract public string CP
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

        abstract public string Correo
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

        abstract public TipoPersona Tipo
        {
            get;
            set;
        }

        abstract public bool Eliminado
        {
            get;
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

        abstract public int DeleteUser
        {
            get;
        }

        abstract public DateTime DeleteTime
        {
            get;
        }
        #endregion

        abstract public void ObtenerDatos();
        abstract public void Insertar();
        abstract public void Editar();
    }
}
