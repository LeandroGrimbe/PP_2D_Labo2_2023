using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public static class MiExtension
    {
        /// <summary>
        /// Verifico si el mail ingresado por el usuario coincide con el formato tradicional de un mail.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns> True si el formato es correcto, false si no.
        public static bool ComprobarFormatoEmail(this string email)
        {
            bool emailCorrecto = false;
            string emailAux = email.Trim();

            if(emailAux.EndsWith("@gmail.com") || emailAux.EndsWith("@outlook.com") || emailAux.EndsWith("@yahoo.com"))
                emailCorrecto = true;

            return emailCorrecto;
        }

        /// <summary>
        /// A partir de la categoria recibida como una string, la transformo en su enum equivalente y lo retorno.
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns> El enum correspondiente a la categoria del producto.
        /// <exception cref="Exception"></exception>
        public static ECategoria TransformarAEnum(this string cadena)
        {
            ECategoria categoria = ECategoria.Carne_Vacuna;  //Instancia auxiliar

            switch(cadena)
            {
                case "Carne Vacuna":
                case "Carne_Vacuna":
                    categoria = ECategoria.Carne_Vacuna;
                    break;

                case "Pollo":
                    categoria = ECategoria.Pollo;
                    break;

                case "Cerdo":
                    categoria = ECategoria.Cerdo;
                    break;

                case "Achuras":
                    categoria = ECategoria.Achuras;
                    break;

                default:
                    throw new Exception("Cadena incompatible");
            }

            return categoria;
        }
    }
}
