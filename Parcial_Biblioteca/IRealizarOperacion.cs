using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public interface IRealizarOperacion
    {
        public bool FinalizarOperacion(Cliente cliente, List<Producto> carrito, List<Producto> productos, decimal totalCompra);
    }
}
