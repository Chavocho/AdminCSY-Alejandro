using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    public enum NivelesUsuario
    {
        Administrador = 0,
        Encargado = 1,
        Desconocido = 2
    }

    public enum TipoPago
    {
        Efectivo = 0,
        Cheque = 1,
        Crédito = 2,
        Débito = 3,
        Transferencia = 4
    }

    public enum Mensajes
    {
        Exito = 0,
        Informativo = 1,
        Alerta = 2,
        Error = 3,
        Pregunta = 4
    }

    public enum TipoPersona
    {
        Credito = 0,
        SinCredito = 1
    }

    public enum Unidades
    {
        Gramo = 0,
        Kilogramo = 1,
        Mililitro = 2,
        Litro = 3,
        Pieza = 4
    }

    public enum MovimientoCaja
    {
        Entrada = 0,
        Salida = 1
    }

    public enum EstadoVenta
    {
        Abierta = 0,
        Cerrada = 1,
        Credito = 2
    }
}
