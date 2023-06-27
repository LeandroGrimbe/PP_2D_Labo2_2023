using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public delegate void DelegadoAviso(string mensaje);

    public class Producto
    {
        public event DelegadoAviso EventoSinStock;

        private int idProducto;
        private ECategoria categoria;
        private string tipo;
        private decimal cantidadKilos;
        private double precioPorKilo;
        private string descripcion;

        #region propiedades

        public int IdProducto
        {
            get { return idProducto; }
            set
            {
                if (value > 0)
                    idProducto = value;
            }
        }

        public ECategoria Categoria
        {
            get { return categoria; } set { categoria = value; }
        }

        public string Tipo
        {
            get { return tipo; } set {  tipo = value; }
        }

        public double PrecioPorKilo
        {
            get { return precioPorKilo; }
            set
            {
                if(value > 0)
                    precioPorKilo = value;
            }
        }

        public decimal CantidadKilos
        {
            get { return cantidadKilos; } 
            set 
            { 
                if(value >= 0)
                    cantidadKilos = value; 
                if (value == 0)
                {
                    EventoSinStock.Invoke("Sin Stock del producto: " + this.tipo);
                }
            }
        }

        public string Descripcion
        {
            get { return descripcion; } set { descripcion = value; }
        }

        #endregion

        public Producto()
        {
        }

        public Producto(int idProducto, ECategoria categoria, string tipo, double precioPorKilo, decimal cantidadKilos, string descripcion)
        {
            this.idProducto = idProducto;
            this.categoria = categoria;
            this.tipo = tipo;
            this.precioPorKilo = precioPorKilo;
            this.cantidadKilos = cantidadKilos;
            this.descripcion = descripcion;
        }

        /// <summary>
        /// Genera un string con los datos del producto, para mostrar en el form de compra
        /// </summary>
        /// <returns></returns> Retorna el string de datos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.tipo);
            sb.AppendLine(this.descripcion);
            sb.AppendLine("x Kg");
            sb.AppendLine("\n");
            sb.Append('$');
            sb.AppendLine(this.precioPorKilo.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Agrega el producto recibido a la lista del carrito. Si el producto ya existe, incrementa su cantidad a comprar
        /// </summary>
        /// <param name="listaCarrito"></param> lista de carrito
        /// <param name="producto"></param> producto a agregar
        /// <param name="cantidadElegida"></param> cantidad a comprar
        public static void AgregarAlCarrito(List<Producto> listaCarrito, Producto producto, decimal cantidadElegida)
        {
            if (cantidadElegida > 0)
            {
                bool productoYaEnCarrito = false;

                foreach (Producto p in listaCarrito)
                {
                    if (p == producto)
                    {
                        p.CantidadKilos += cantidadElegida;
                        productoYaEnCarrito = true;
                    }
                }

                if (!productoYaEnCarrito)
                {
                    Producto productoAux = new Producto(producto.idProducto, producto.categoria, producto.tipo, producto.precioPorKilo, cantidadElegida, producto.descripcion);
                    listaCarrito.Add(productoAux);
                }

                producto.CantidadKilos -= cantidadElegida;
            }
        }

        /// <summary>
        /// Devuelve el stock de los productos quitado de la lista de productos principal, en caso de vaciar el carrito, o bien cancelar la operacion
        /// </summary>
        /// <param name="listaCarrito"></param> lista de carrito
        /// <param name="listaProductos"></param> lista de productos
        public static void DevolverStockCarrito(List<Producto> listaCarrito, List<Producto> listaProductos)
        {
            foreach (Producto p in listaCarrito)
            {
                foreach (Producto producto in listaProductos)
                {
                    if (p == producto)
                    {
                        producto.CantidadKilos += p.CantidadKilos;
                        break;
                    }
                }
            }
        }

        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return producto1.tipo == producto2.tipo;
        }

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        public static bool operator ==(Producto producto, string nombreProducto)
        {
            return producto.tipo == nombreProducto;
        }

        public static bool operator !=(Producto producto1, string nombreProducto)
        {
            return !(producto1 == nombreProducto);
        }

        public override bool Equals(object obj)
        {
            if (obj is Producto producto)
            {
                return this == producto;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.tipo.GetHashCode();
        }
    }
}