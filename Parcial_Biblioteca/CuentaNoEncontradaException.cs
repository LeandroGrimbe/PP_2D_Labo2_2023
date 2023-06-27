using System;

namespace Parcial_Biblioteca
{
    public class CuentaNoEncontradaException : Exception
    {
        public CuentaNoEncontradaException() : base("Ninguna cuenta registrada corresponde a los datos ingresados. Reintente....")
        {
        }
    }
}