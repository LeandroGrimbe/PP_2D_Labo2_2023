using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public abstract class Usuario
    {
        protected string nombreUsuario;
        protected string eMailUsuario;
        protected string claveUsuario;
        protected string rolUsuario;

        public abstract string NombreUsuario
        {
            get;
        }
        public abstract string EMailUsuario
        {
            get;
        }
        public abstract string ClaveUsuario
        {
            get;
        }
        public abstract string RolUsuario
        {
            get;
        }

        public Usuario()
        {
        }

        public abstract string MensajeLogin();
    }
}
