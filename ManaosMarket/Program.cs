using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace ManaosMarket
{
    public static class Program
    {
        public static FrmPrincipal principal;

        public static bool sesionAdministrador = false;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(principal=new FrmPrincipal());
        }

        public static void ActivarMenuPrivado()
        {

            principal.ActivarMenuPrivadoPrincipal(true);
        }
    }
}
