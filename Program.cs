using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Views
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
            //Application.Run(new Form_Categoria());
            //Application.Run(new Form_Inventario());
            //Application.Run(new Form_Lote());
            //Application.Run(new Form_Presentacion());
            //Application.Run(new Form_Producto());
            Application.Run(new Form_Venta());
        }
    }
}
