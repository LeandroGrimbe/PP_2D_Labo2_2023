using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public class RegistroVentas
    {
        private DateTime fechaOperacion;
        private string nombreCliente;
        private List<Producto> productosOperacion;
        private decimal importeOperacion;

        public static string historialVentas;

        #region propiedades

        public DateTime FechaOperacion
        {
            get { return fechaOperacion; }
        }

        public string NombreCliente
        {
            get { return nombreCliente; }
        }

        public List<Producto> ProductosOperacion
        {
            get { return productosOperacion; }
        }

        public decimal ImporteOperacion
        {
            get { return importeOperacion; }
        }

        #endregion

        public RegistroVentas() 
        {
        }

        public RegistroVentas(DateTime fechaOperacion, string nombreCliente, List<Producto> productosOperacion, decimal importeOperacion)
        {
            this.fechaOperacion = fechaOperacion;
            this.nombreCliente = nombreCliente;
            this.productosOperacion = productosOperacion;
            this.importeOperacion = importeOperacion;
        }

        /// <summary>
        /// Luego de concretar una operacion, guardo sus datos para colocar en el historial de ventas.
        /// </summary>
        /// <param name="venta"></param>
        public static void AgregarVentaAlHistorial(RegistroVentas venta)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Fecha Operacion:");
            sb.AppendLine(venta.fechaOperacion.ToString("d"));
            sb.AppendLine();
            sb.AppendLine("Nombre Cliente: ");
            sb.AppendLine(venta.nombreCliente);
            sb.AppendLine();
            sb.AppendLine("Productos vendidos: ");

            foreach(Producto p in venta.productosOperacion)
            {
                sb.Append(p.Tipo);
                sb.Append("  ");
                sb.Append(p.CantidadKilos);
                sb.AppendLine(" KG");
            }

            sb.AppendLine();
            sb.AppendLine("Importe total: ");
            sb.AppendLine(venta.importeOperacion.ToString());
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            
            historialVentas += sb.ToString();
        }
    }
}
