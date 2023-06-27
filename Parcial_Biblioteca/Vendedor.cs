using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public class Vendedor : Usuario, IRealizarOperacion
    {
        public List<Cliente> listaClientes;

        public static int numeroOperacion;

        #region propiedades

        public override int IdUsuario
        {
            get { return this.idUsuario; }
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
        
        public Vendedor() : base()
        {
        }

        public Vendedor(int idUsuario, string nombreUsuario, string eMailUsuario, string claveUsuario, string rolUsuario) : base(idUsuario, nombreUsuario, eMailUsuario, claveUsuario, rolUsuario)
        {
            listaClientes = new List<Cliente>();
        }

        /// <summary>
        /// Genera un mensaje de bienvenida luego de loguearse con el vendedor
        /// </summary>
        /// <returns></returns> Retorna el mensaje
        public override string MensajeLogin()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Usted ha ingresado como:");
            sb.AppendLine(this.nombreUsuario);
            sb.Append("\nSera redireccionado al Menu de Ventas....");

            return sb.ToString();
        }

        /// <summary>
        /// Checkea si el cliente elegido posee dinero suficiente para realizar la venta. Si se cancela la venta se reingresa el stock del carrito a la lista de productos
        /// </summary>
        /// <param name="cliente"></param> cliente al que se le vendio
        /// <param name="carrito"></param> carrito de productos a vender
        /// <param name="productos"></param> productos disponibles
        /// <param name="montoVenta"></param> Monto total de la venta
        /// <returns></returns> retorna true si se realizo la venta, caso contrario false
        public bool FinalizarOperacion(Cliente cliente, List<Producto> carrito, List<Producto> productos, decimal montoVenta)
        {
            bool ventaConfirmada = false;

            if (cliente.CheckearSaldo(montoVenta))
            {
                cliente.DineroDisponible -= montoVenta;

                Programador.ActualizarProductosVentaBDD(carrito, productos);
                Programador.ActualizarClienteBDD(cliente);

                ventaConfirmada = true;
            }
            else
            {
                Producto.DevolverStockCarrito(carrito, productos);
                carrito.Clear();
            }

            return ventaConfirmada;
        }

        /// <summary>
        /// Instancia un producto con los datos recibidos, checkeando primero que sean validos. Si hubo algun problema con algun dato, se genera un mensaje indicando donde estuvo el error y no se agrega el producto.
        /// </summary>
        /// <param name="listaProductos"></param> lista de productos
        /// <param name="categoria"></param> categoria del nuevo producto
        /// <param name="corte"></param> corte del nuevo producto
        /// <param name="cantidad"></param> cantidad del nuevo producto
        /// <param name="precioPorKilo"></param> precio del nuevo producto
        /// <param name="detalles"></param> detalles del nuevo producto
        /// <returns></returns> retorna el mensaje de error, o bien de confirmacion del producto agregado
        public static string NuevoProducto(List<Producto> listaProductos, string categoria, string corte, string cantidad, string precioPorKilo, string detalles)
        {
            StringBuilder mensajeError = new StringBuilder();
            mensajeError.AppendLine("ERROR, se presentaron los siguientes problemas al cargar el nuevo producto:");

            int idCategoria = 0;
            string mensajeFinal = "";

            bool categoriaCorrecta = false;
            bool corteCorrecto = false;
            bool cantidadCorrecta = false;
            bool precioPorKiloCorrecto = false;
            bool detallesCorrecto = false;

            bool productoEncontrado = false;

            ECategoria categoriaProducto = ECategoria.Carne_Vacuna; //Asignacion auxiliar
            decimal cantidadProducto;
            double precio;

            if (string.IsNullOrEmpty(categoria))
            {
                mensajeError.AppendLine("-Categoria nula o vacia");
            }
            else
            {
                categoriaProducto = categoria.TransformarAEnum();
                switch (categoria)
                {
                    case "Carne_Vacuna":
                        categoriaProducto = ECategoria.Carne_Vacuna;
                        idCategoria = 1;
                        break;

                    case "Pollo":
                        categoriaProducto = ECategoria.Pollo;
                        idCategoria = 2;
                        break;

                    case "Cerdo":
                        categoriaProducto = ECategoria.Cerdo;
                        idCategoria = 3;
                        break;

                    case "Achuras":
                        categoriaProducto = ECategoria.Achuras;
                        idCategoria = 4;
                        break;
                }

                categoriaCorrecta = true;
            }

            if (string.IsNullOrEmpty(corte))
            {
                mensajeError.AppendLine("-Nombre de corte nulo o vacio");
            }
            else
            {
                corteCorrecto = true;
            }

            if (decimal.TryParse(cantidad, out cantidadProducto) && cantidadProducto > 0)
            {
                cantidadCorrecta = true;
            }
            else
            {
                mensajeError.AppendLine("-Cantidad invalida, nula, o vacia");
            }

            if (double.TryParse(precioPorKilo, out precio) && precio > 0)
            {
                precioPorKiloCorrecto = true;
            }
            else
            {
                mensajeError.AppendLine("-Precio invalido, nulo o vacio");
            }

            if (string.IsNullOrEmpty(detalles))
            {
                mensajeError.AppendLine("-Detalle de producto nulo o vacio");
            }
            else
            {
                detallesCorrecto = true;
            }

            if (categoriaCorrecta && corteCorrecto && cantidadCorrecta && precioPorKiloCorrecto && detallesCorrecto)
            {
                foreach (Producto p in listaProductos)
                {
                    if (p == corte)
                    {
                        mensajeFinal = "Producto ya existente, si desea cambiar algo utilice el menu de edicion";
                        productoEncontrado = true;
                    }
                }

                if (!productoEncontrado)
                {
                    Producto productoNuevo = new Producto(Programador.ultimoIdRegistrado+1, categoriaProducto, corte, precio, cantidadProducto, detalles);
                    listaProductos.Add(productoNuevo);
                    Programador.CrearProductoBDD(productoNuevo, idCategoria);
                    Programador.ultimoIdRegistrado++;

                    mensajeFinal = "Producto Agregado con Exito";
                }
            }
            else
                mensajeFinal = mensajeError.ToString();


            return mensajeFinal;
        }
    
        /// <summary>
        /// Recibe un producto y edita los valores indicados. Si el parametro es vacio o nulo, directamente no se hace el cambio ni se notifica, pero si el valor es invalido si se notifica. Al final se genera un mensaje con los cambios y errores realizados
        /// </summary>
        /// <param name="producto"></param> producto a modificar
        /// <param name="categoria"></param> categoria nueva
        /// <param name="cantidad"></param> cantidad nueva
        /// <param name="precioPorKilo"></param> precio nuevo
        /// <param name="detalles"></param> detalles nuevos
        /// <returns></returns> retorna el mensaje de informe
        public static string EditarProducto(Producto producto, string categoria, string cantidad, string precioPorKilo, string detalles)
        {
            bool cambioCategoria = false;
            int idCategoriaNueva = 0;
            bool cambioCantidad = false;
            bool cambioPrecio = false;
            bool cambioDetalles = false;

            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("Informe de la Edicion:\n");

            decimal cantidadProducto;
            double precio;

            if (!string.IsNullOrEmpty(categoria))
            {
                switch (categoria)
                {
                    case "Carne_Vacuna":
                        producto.Categoria = ECategoria.Carne_Vacuna;
                        idCategoriaNueva = 1;
                        break;

                    case "Pollo":
                        producto.Categoria = ECategoria.Pollo;
                        idCategoriaNueva = 2;
                        break;

                    case "Cerdo":
                        producto.Categoria = ECategoria.Cerdo;
                        idCategoriaNueva = 3;
                        break;

                    case "Achuras":
                        producto.Categoria = ECategoria.Achuras;
                        idCategoriaNueva = 4;
                        break;
                }

                cambioCategoria = true;
                mensaje.AppendLine("-Categoria cambiada con exito");
            }

            if (!string.IsNullOrEmpty(cantidad))
            {
                if (decimal.TryParse(cantidad, out cantidadProducto) && cantidadProducto > 0)
                {
                    producto.CantidadKilos = cantidadProducto;
                    cambioCantidad = true;
                    mensaje.AppendLine("-Cantidad cambiada con exito");
                }
                else
                    mensaje.AppendLine("-Cantidad ingresada invalida, no se realizo ningun cambio");
            }

            if (!string.IsNullOrEmpty(precioPorKilo))
            {
                if (double.TryParse(precioPorKilo, out precio) && precio > 0)
                {
                    producto.PrecioPorKilo = precio;
                    cambioPrecio = true;
                    mensaje.AppendLine("-Precio cambiado con exito");
                }
                else
                    mensaje.AppendLine("-Precio ingresado invalido, no se realizo ningun cambio");
            }

            if (!string.IsNullOrEmpty(detalles))
            {
                producto.Descripcion = detalles;
                cambioDetalles = true;
                mensaje.AppendLine("-Detalles cambiados con exito");
            }

            Programador.ModificarProductoBDD(producto, cambioCategoria, idCategoriaNueva, cambioCantidad, cambioPrecio, cambioDetalles);
            
            return mensaje.ToString();
        }

        /// <summary>
        /// Borro un producto de la lista de productos
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="listaProductos"></param>
        /// <returns></returns> Devuelve el id del producto eliminado
        public static int BorrarProducto(string producto, List<Producto> listaProductos)
        {
            int idProductoABorrar = 0;
            foreach(Producto p in listaProductos)
            {
                if(p == producto)
                {
                    idProductoABorrar = p.IdProducto;
                    listaProductos.Remove(p);
                    break;
                }
            }

            return idProductoABorrar;
        }
    }
}
