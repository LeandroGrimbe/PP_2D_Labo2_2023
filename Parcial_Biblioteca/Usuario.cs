using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public abstract class Usuario
    {
        protected int idUsuario;
        protected string nombreUsuario;
        protected string eMailUsuario;
        protected string claveUsuario;
        protected string rolUsuario;

        #region propiedades

        public abstract int IdUsuario
        {
            get;
        }

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

        #endregion

        public Usuario()
        {
        }

        public Usuario(int idUsuario, string nombreUsuario, string eMailUsuario, string claveUsuario, string rolUsuario)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.eMailUsuario = eMailUsuario;
            this.rolUsuario = rolUsuario;
            this.claveUsuario = claveUsuario;
        }

        public abstract string MensajeLogin();
    }
}
