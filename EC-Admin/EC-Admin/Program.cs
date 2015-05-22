using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.PrimerUso)
            {
                Application.Run(new PrimerInicio());
            }
            else
            {
                Application.Run(new Inicio());
            }
        }
    }

    class Inicio : ApplicationContext
    {
        public Inicio()
        {
            (new frmSplash()).Show();
        }
    }

    class PrimerInicio : ApplicationContext
    {
        public PrimerInicio()
        {
            (new frmPrimerUso()).Show();
        }
    }
}
