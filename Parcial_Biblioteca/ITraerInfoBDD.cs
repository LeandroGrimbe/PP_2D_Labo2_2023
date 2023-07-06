using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public interface ITraerInfoBDD<T> where T : class
    {
        public void TraerDatosBDD(List<T> listaDatos);
    }
}
