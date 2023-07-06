using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public class Cliente : Usuario, IRealizarOperacion
    {
        private decimal dineroDisponible;

        #region propiedades

        public override int IdUsuario
        {
            get { return this.idUsuario; }
        }

        public decimal DineroDisponible
        {
            get { return dineroDisponible; }
            set 
            {
                if (value > 0)
                    dineroDisponible = value;
            }
        }

        public override string NombreUsuario
        {
            get { return this.nombreUsuario; }
        }

        public override string EMailUsuario
        {
            get { return this.eMailUsuario; }
        }

        public override string ClaveUsuario
        {
            get { return this.claveUsuario; }
        }

        public override string RolUsuario
        {
            get { return this.rolUsuario; }
        }

        #endregion

        public Cliente(int idUsuario, string nombreUsuario, string eMailUsuario, string claveUsuario, string rolUsuario) : base(idUsuario, nombreUsuario, eMailUsuario, claveUsuario, rolUsuario)
        {
            this.dineroDisponible = 0;
        }

        /// <summary>
        /// Genera un mensaje de bienvenida luego de loguearse con alguno de los clientes
        /// </summary>
        /// <returns></returns> Retorna el mensaje
        public override string MensajeLogin()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Usted ha ingresado como:");
            sb.AppendLine(this.nombreUsuario);
            sb.Append("\nSera redireccionado al Menu de Compras....");

            return sb.ToString();
        }

        /// <summary>
        /// Checkea si el cliente dispone del saldo suficiente para realizar una compra
        /// </summary>
        /// <param name="precio"></param> Valor de la compra
        /// <returns></returns> Devuelve true si tiene dinero suficiente,caso contrario false
        public bool CheckearSaldo(decimal precio)
        {
            bool retorno = false;

            if (this.dineroDisponible >= precio)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Se vuelve a checkear el saldo del cliente, y si tiene dinero suficiente se realiza la compra y se le resta el costo. En caso de que no, se devuelve el stock a la lista de productos principal
        /// </summary>
        /// <param name="cliente"></param> cliente que realiza la compra
        /// <param name="carrito"></param> carrito de productos
        /// <param name="productos"></param> lista principal de productos
        /// <param name="totalCompra"></param> valor de compra
        /// <returns></returns> devuelve si se realizo o no la compra
        public bool FinalizarOperacion(Cliente cliente, List<Producto> carrito, List<Producto> productos, decimal totalCompra)
        {
            bool compraRealizada = false;

            if(cliente.CheckearSaldo(totalCompra))
            {
                cliente.DineroDisponible -= totalCompra;

                ProductoDAO.ActualizarProductosVentaBDD(carrito, productos);
                UsuarioDAO.ActualizarClienteBDD(cliente);

                compraRealizada = true;
            }
            else
            {
                Producto.DevolverStockCarrito(carrito, productos);
                carrito.Clear();
            }

            return compraRealizada;
        }
    }
}
