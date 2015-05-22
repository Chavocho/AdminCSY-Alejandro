using EC_Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    /// <summary>
    /// Permite crear un delegado que te permite mostrar el mensaje de error cuando se manda a llamar desde un hilo.
    /// </summary>
    /// <param name="mensaje">Mensaje personalizado a mostrar.</param>
    /// <param name="ex">Excepción que ocurrió.</param>
    public delegate DialogResult DelegadoMensajes(IWin32Window frm, Mensajes m, string mensaje, string titulo, Exception ex);

    public delegate void CerrarFrmEspera();
}
