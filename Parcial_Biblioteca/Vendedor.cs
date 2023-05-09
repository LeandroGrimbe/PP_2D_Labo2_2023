using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public class Vendedor : Usuario
    {
        private string[] listaClientes;

        public static Dictionary<string, string> historialOperaciones;
        public static int numeroOperacion;

        #region propiedades

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

        public string[] ListaClientes
        {
            get { return this.listaClientes; }
        }

        #endregion 

        public Vendedor() : base()
        {
            listaClientes = new string[4];
        }

        /// <summary>
        /// Instancia un vendedor y hardcodea sus datos
        /// </summary>
        /// <returns></returns> Retorna el vendedor instanciado
        public static Usuario CrearVendedor()
        {
            Vendedor vendedor = new Vendedor();

            vendedor.nombreUsuario = "Federico Perez";
            vendedor.eMailUsuario = "perezfederico03@gmail.com";
            vendedor.claveUsuario = "MilangaDePollo306";
            vendedor.rolUsuario = "Vendedor";

            vendedor.listaClientes[0] = "Martin Cauteruccio";
            vendedor.listaClientes[1] = "Sofia Fernandez";
            vendedor.listaClientes[2] = "Leandro Gomez";
            vendedor.listaClientes[3] = "Agustina Caceres";

            return vendedor;
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
        /// Genera un mensaje luego de confirmarse la venta
        /// </summary>
        /// <param name="cliente"></param> cliente al que se le vendio
        /// <returns></returns> retorna el mensaje
        public static string RealizarVenta(string cliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Venta realizada correctamente al cliente: ");
            sb.AppendLine(cliente);
            sb.AppendLine("Generando Factura...");

            return sb.ToString();
        }

        /// <summary>
        /// Luego de confirmarse la venta, se guarda el cliente y la lista de los productos que compro en un diccionario. Ademas se incrementa el numero de operacion
        /// </summary>
        /// <param name="productosVendidos"></param> lista de productos vendidos
        /// <param name="cliente"></param> cliente al que se le vendio
        public static void RegistrarNuevaVenta(string productosVendidos, string cliente)
        {
            Vendedor.historialOperaciones.Add(productosVendidos, cliente);
            Vendedor.numeroOperacion++;
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
                switch (categoria)
                {
                    case "Carne_Vacuna":
                        categoriaProducto = ECategoria.Carne_Vacuna;
                        break;

                    case "Pollo":
                        categoriaProducto = ECategoria.Pollo;
                        break;

                    case "Cerdo":
                        categoriaProducto = ECategoria.Cerdo;
                        break;

                    case "Achuras":
                        categoriaProducto = ECategoria.Achuras;
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
                    Producto productoNuevo = new Producto(categoriaProducto, corte, precio, cantidadProducto, detalles);
                    listaProductos.Add(productoNuevo);

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
                        break;

                    case "Pollo":
                        producto.Categoria = ECategoria.Pollo;
                        break;

                    case "Cerdo":
                        producto.Categoria = ECategoria.Cerdo;
                        break;

                    case "Achuras":
                        producto.Categoria = ECategoria.Achuras;
                        break;
                }

                mensaje.AppendLine("-Categoria cambiada con exito");
            }

            if (!string.IsNullOrEmpty(cantidad))
            {
                if (decimal.TryParse(cantidad, out cantidadProducto) && cantidadProducto > 0)
                {
                    producto.CantidadKilos = cantidadProducto;
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
                    mensaje.AppendLine("-Precio cambiado con exito");
                }
                else
                    mensaje.AppendLine("-Precio ingresado invalido, no se realizo ningun cambio");
            }

            if (!string.IsNullOrEmpty(detalles))
            {
                producto.Descripcion = detalles;
                mensaje.AppendLine("-Detalles cambiados con exito");
            }

            return mensaje.ToString();
        }
    }
}
