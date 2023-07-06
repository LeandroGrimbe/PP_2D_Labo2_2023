using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public class ProductoDAO : ITraerInfoBDD<Producto>
    {
        public static int ultimoIdRegistrado;
        private static string connectionString;

        static ProductoDAO()
        {
            ultimoIdRegistrado = 0;
            connectionString = "Server=.;Database=CARNICERIA_DB;Trusted_Connection=True";
        }

        /// <summary>
        /// Trae de la base de datos todos los datos de los productos iniciales y los guarda en la lista
        /// </summary>
        /// <param name="listaProductos"></param>
        public void TraerDatosBDD(List<Producto> listaProductos)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conexion;
            command.CommandText = "SELECT * FROM Productos";

            conexion.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                int idProducto;
                int.TryParse(reader["ID_PRODUCTO"].ToString(), out idProducto);

                string nombreProducto = reader["NOMBRE"].ToString();

                bool productoExistente = false;
                foreach (Producto p in listaProductos)
                {
                    if (p.IdProducto == idProducto || p.Tipo == nombreProducto)
                    {
                        productoExistente = true;
                    }
                }

                if (!productoExistente)
                {
                    int idCategoria;
                    int.TryParse(reader["ID_CATEGORIA"].ToString(), out idCategoria);
                    ECategoria categoria = idCategoria.TransformarAEnum();

                    string descripcionProducto = reader["DESCRIPCION"].ToString();

                    decimal precioProducto;
                    decimal.TryParse(reader["PRECIO_KG"].ToString(), out precioProducto);

                    decimal cantidadProducto;
                    decimal.TryParse(reader["CANTIDAD_KG"].ToString(), out cantidadProducto);

                    Producto producto = new Producto(idProducto, categoria, nombreProducto, (double)precioProducto, cantidadProducto, descripcionProducto);
                    listaProductos.Add(producto);

                    ultimoIdRegistrado++;
                }
            }

            conexion.Close();
        }

        /// <summary>
        /// Actualizo en la base de datos los valores de cantidad de los productos, luego de concretada una venta
        /// </summary>
        /// <param name="carrito"></param>
        /// <param name="listaProductos"></param>
        /// <exception cref="Exception"></exception>
        public static void ActualizarProductosVentaBDD(List<Producto> carrito, List<Producto> listaProductos)
        {
            SqlConnection conexion = new SqlConnection(connectionString);

            StringBuilder sb = new StringBuilder();

            foreach (Producto pVenta in carrito)
            {
                foreach (Producto producto in listaProductos)
                {
                    if (pVenta is not null && producto is not null && pVenta.IdProducto == producto.IdProducto)
                    {
                        sb.Append(" UPDATE Productos SET CANTIDAD_KG = ");
                        sb.AppendLine(((int)producto.CantidadKilos).ToString());
                        sb.Append(" WHERE ID_PRODUCTO = ");
                        sb.Append(producto.IdProducto.ToString());
                        sb.AppendLine(" ");

                        break;
                    }
                }
            }

            string consulta = sb.ToString();
            SqlCommand command = new SqlCommand(consulta, conexion);

            conexion.Open();

            int filasAfectadas = command.ExecuteNonQuery();
            if (filasAfectadas <= 0)
            {
                throw new Exception("ERROR al realizar los cambios en la base de datos");
            }

            conexion.Close();
        }

        /// <summary>
        /// Agrego un nuevo producto a la base de datos
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="idCategoria"></param>
        /// <exception cref="Exception"></exception>
        public static void CrearProductoBDD(Producto producto, int idCategoria)
        {
            string consulta = "INSERT INTO Productos VALUES (@nombre, @idcat, @precio, @cantidad, @descripcion)";

            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(consulta, conexion);

            command.Parameters.AddWithValue("nombre", producto.Tipo);
            command.Parameters.AddWithValue("idcat", idCategoria);
            command.Parameters.AddWithValue("precio", producto.PrecioPorKilo);
            command.Parameters.AddWithValue("cantidad", producto.CantidadKilos);
            command.Parameters.AddWithValue("descripcion", producto.Descripcion);

            conexion.Open();

            int filasAfectadas = command.ExecuteNonQuery();
            if (filasAfectadas <= 0)
            {
                throw new Exception("ERROR al realizar los cambios en la base de datos");
            }

            conexion.Close();
        }

        /// <summary>
        /// Modifico de la base de datos el producto elegido, segun los valores que se deseaban modificar.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cambioCategoria"></param>
        /// <param name="idCategoriaNueva"></param>
        /// <param name="cambioCantidad"></param>
        /// <param name="cambioPrecio"></param>
        /// <param name="cambioDetalles"></param>
        /// <exception cref="Exception"></exception>
        public static void ModificarProductoBDD(Producto producto, bool cambioCategoria, int idCategoriaNueva, bool cambioCantidad, bool cambioPrecio, bool cambioDetalles)
        {
            SqlConnection conexion = new SqlConnection(connectionString);

            StringBuilder sb = new StringBuilder();
            sb.Append(" UPDATE Productos SET ");

            if (cambioCategoria)
            {
                sb.Append(" ID_CATEGORIA = ");
                sb.Append(idCategoriaNueva);
                sb.Append(" , ");
            }

            if (cambioCantidad)
            {
                sb.Append(" CANTIDAD_KG = ");
                sb.Append(producto.CantidadKilos);
                sb.Append(" , ");
            }

            if (cambioPrecio)
            {
                sb.Append(" PRECIO_KG = ");
                sb.Append(producto.PrecioPorKilo);
                sb.Append(" , ");
            }

            if (cambioDetalles)
            {
                sb.Append(" DESCRIPCION = '");
                sb.Append(producto.Descripcion);
                sb.Append("' , ");
            }

            int lastIndex = sb.Length - 2;
            sb.Remove(lastIndex, 2); //Borro la ultima coma del string para que no rompa el comando

            sb.Append(" WHERE ID_PRODUCTO = ");
            sb.Append(producto.IdProducto.ToString());
            sb.AppendLine(" ");


            string consulta = sb.ToString();
            SqlCommand command = new SqlCommand(consulta, conexion);

            conexion.Open();

            int filasAfectadas = command.ExecuteNonQuery();
            if (filasAfectadas <= 0)
            {
                throw new Exception("ERROR al realizar los cambios en la base de datos");
            }

            conexion.Close();
        }

        /// <summary>
        /// Borro de la base de datos el producto con id recibido
        /// </summary>
        /// <param name="idProducto"></param>
        /// <exception cref="Exception"></exception>
        public static void BorrarProductoBDD(int idProducto)
        {
            SqlConnection conexion = new SqlConnection(connectionString);

            string consulta = " DELETE FROM Productos WHERE ID_PRODUCTO = " + idProducto + " ";

            SqlCommand command = new SqlCommand(consulta, conexion);

            conexion.Open();

            int filasAfectadas = command.ExecuteNonQuery();
            if (filasAfectadas <= 0)
            {
                throw new Exception("ERROR al realizar los cambios en la base de datos");
            }

            conexion.Close();
        }
    }
}
