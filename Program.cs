using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());
           // Application.Run(new Farmacia.Views.Form_CLIENTES());
            // Application.Run(new Farmacia.Views.Form_Laboratoria());
            // Application.Run(new Farmacia.Views.Form_Proveedor());
            // Application.Run(new Farmacia.Views.Form_Receta());
            // Application.Run(new Farmacia.Views.Form_SubCategoria());
            // Application.Run(new Farmacia.Views.Form_Sucursal());
            // Application.Run(new Farmacia.Views.Form_Usuario());
            // Application.Run(new Farmacia.Views.Form_Login());
            // Application.Run(new Farmacia.Views.Form_MenuPrincipal());
            // Application.Run(new Farmacia.Views.Form_Conexion());
        }
    }
}
