using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public static class Validador
    {
        public static double ValidarDouble(string numeroAValidar)
        {
            double valor = 0;
            double.TryParse(numeroAValidar, out valor);

            return valor;
        }
    }
}
