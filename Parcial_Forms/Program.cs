using Parcial_Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Usuario cliente1 = Cliente.CrearCliente(1);
            Usuario cliente2 = Cliente.CrearCliente(2);
            Usuario vendedor = Vendedor.CrearVendedor();

            List<Producto> listaProductos = Producto.ProductosIniciales();

            Vendedor.numeroOperacion = 1;
            Vendedor.historialOperaciones = new Dictionary<string, string>();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin(cliente1, cliente2, vendedor, listaProductos));
        }
    }
}
