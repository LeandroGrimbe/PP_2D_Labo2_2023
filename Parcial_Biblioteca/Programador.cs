using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.Design;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;

namespace Parcial_Biblioteca
{
    public class Programador : Usuario
    {
        public static int ultimoIdRegistrado;

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

        public Programador(int idUsuario, string nombreUsuario, string eMailUsuario, string claveUsuario, string rolUsuario) : base(idUsuario, nombreUsuario, eMailUsuario, claveUsuario, rolUsuario)
        {
            ultimoIdRegistrado = 0;
        }

        /// <summary>
        /// Genera un mensaje de bienvenida luego de loguearse con el programador
        /// </summary>
        /// <returns></returns> Retorna el mensaje
        public override string MensajeLogin()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Usted ha ingresado como:");
            sb.AppendLine(this.nombreUsuario);
            sb.Append("\nSera redireccionado al Menu del Programador....");

            return sb.ToString();
        }

        /// <summary>
        /// Trae de la base de datos el mail y cuenta del usuario seleccionado.
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="mail"></param>
        /// <param name="clave"></param>
        public static void AutoCompletarDatosBDD(int idUsuario, ref string mail, ref string clave)
        {
            string connectionString = "Server=.;Database=CARNICERIA_DB;Trusted_Connection=True";

            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conexion;
            command.CommandText = "SELECT u.EMAIL, u.CLAVE " +
                                  "FROM Usuarios u WHERE u.ID_USUARIO = @id";

            command.Parameters.AddWithValue("id", idUsuario);

            conexion.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                mail = reader["EMAIL"].ToString();
                clave = reader["CLAVE"].ToString();
            }
            
            conexion.Close();
        }

        /// <summary>
        /// Busca en la base de datos si alguna cuenta coincide con los datos brindados por el usuario
        /// </summary>
        /// <param name="tipoUsuario"></param>
        /// <param name="mailIngresado"></param>
        /// <param name="claveIngresada"></param>
        /// <returns></returns> Se retorna el usuario que coincida con esos datos, si es que se encontro
        public static Usuario BuscarUsuarioBDD(ref int tipoUsuario, string mailIngresado, string claveIngresada)
        {
            Usuario usuario = new Vendedor(); //Instancia Auxiliar

            string connectionString = "Server=.;Database=CARNICERIA_DB;Trusted_Connection=True";
            
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conexion;
            command.CommandText = "SELECT u.ID_USUARIO, u.NOMBRE_COMPLETO, u.EMAIL, u.CLAVE, u.DINERO, r.NOMBRE AS ROL " +
                                  "FROM Usuarios u " +
                                  "INNER JOIN Roles r ON u.ID_ROL = r.ID_ROL";

            conexion.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string mail = reader["EMAIL"].ToString();
                string clave = reader["CLAVE"].ToString();

                if(mailIngresado == mail && claveIngresada == clave)
                {
                    int idUsuario; 
                    int.TryParse(reader["ID_USUARIO"].ToString(), out idUsuario);

                    string nombreCompleto = reader["NOMBRE_COMPLETO"].ToString();
                    string Rol = reader["ROL"].ToString();

                    switch(Rol)
                    {
                        case "Vendedor":
                            usuario = new Vendedor(idUsuario, nombreCompleto, mail, clave, Rol);

                            //Cierro y abro la conexion para leer los clientes del vendedor
                            conexion.Close();
                            conexion.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                if(reader["ROL"].ToString() == "Cliente" && DBNull.Value.Equals(reader["EMAIL"]) && DBNull.Value.Equals(reader["CLAVE"]))
                                {
                                    int idCliente;
                                    int.TryParse(reader["ID_USUARIO"].ToString(), out idCliente);

                                    string nombreCliente = reader["NOMBRE_COMPLETO"].ToString();

                                    decimal dineroParseado;
                                    decimal.TryParse(reader["DINERO"].ToString(), out dineroParseado);

                                    Cliente cliente = new Cliente(idCliente, nombreCliente, null, null, "Cliente");
                                    cliente.DineroDisponible = dineroParseado;

                                    ((Vendedor)usuario).listaClientes.Add(cliente);
                                }
                            }

                            tipoUsuario = 1;
                            break;

                        case "Cliente":
                            usuario = new Cliente(idUsuario, nombreCompleto, mail, clave, Rol);

                            tipoUsuario = 2;
                            break;

                        case "Programador":
                            usuario = new Programador(idUsuario, nombreCompleto, mail, clave, Rol);

                            tipoUsuario = 3;
                            break;
                    }
                    break;
                }
            }

            conexion.Close();

            return usuario;
        }

        /// <summary>
        /// Trae de la base de datos los productos iniciales y los guarda en la lista
        /// </summary>
        /// <param name="listaProductos"></param>
        public static void CargarProductosBDD(List<Producto> listaProductos)
        {
            string connectionString = "Server=.;Database=CARNICERIA_DB;Trusted_Connection=True";

            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conexion;
            command.CommandText = "SELECT p.ID_PRODUCTO, p.NOMBRE, c.NOMBRE AS CATEGORIA, p.PRECIO_KG, p.CANTIDAD_KG, p.DESCRIPCION " +
                                  "FROM Productos p " +
                                  "INNER JOIN Categorias_De_Producto c ON c.ID_CATEGORIA = p.ID_CATEGORIA";

            conexion.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                int idProducto;
                int.TryParse(reader["ID_PRODUCTO"].ToString(), out idProducto);

                string nombreProducto = reader["NOMBRE"].ToString();

                bool productoExistente = false;
                foreach(Producto p in listaProductos)
                {
                    if(p.IdProducto == idProducto || p.Tipo == nombreProducto)
                    {
                        productoExistente = true;
                    }
                }

                if (!productoExistente)
                {
                    string categoriaProducto = reader["CATEGORIA"].ToString();
                    ECategoria categoria = categoriaProducto.TransformarAEnum();

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
            string connectionString = "Server=.;Database=CARNICERIA_DB;Trusted_Connection=True";
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
        /// Actualizo en la base de datos los valores de dinero del cliente, luego de haber concretado una compra.
        /// </summary>
        /// <param name="cliente"></param>
        /// <exception cref="Exception"></exception>
        public static void ActualizarClienteBDD(Cliente cliente)
        {
            string connectionString = "Server=.;Database=CARNICERIA_DB;Trusted_Connection=True";
            SqlConnection conexion = new SqlConnection(connectionString);

            StringBuilder sb = new StringBuilder();
            sb.Append(" UPDATE Usuarios SET DINERO = ");
            sb.AppendLine(((int)cliente.DineroDisponible).ToString());
            sb.Append(" WHERE ID_USUARIO = ");
            sb.Append(cliente.IdUsuario.ToString());
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
            string connectionString = "Server=.;Database=CARNICERIA_DB;Trusted_Connection=True";
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
            string connectionString = "Server=.;Database=CARNICERIA_DB;Trusted_Connection=True";
            SqlConnection conexion = new SqlConnection(connectionString);

            StringBuilder sb = new StringBuilder(); 
            sb.Append(" UPDATE Productos SET ");
            
            if(cambioCategoria)
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
            sb.Remove(lastIndex, 2);

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
        /// Agrego un nuevo producto a la base de datos
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="idCategoria"></param>
        /// <exception cref="Exception"></exception>
        public static void CrearProductoBDD(Producto producto, int idCategoria)
        {
            string connectionString = "Server=.;Database=CARNICERIA_DB;Trusted_Connection=True";
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
        /// Serializo el producto recibido por JSON
        /// </summary>
        /// <param name="productoElegido"></param>
        /// <param name="listaProductos"></param>
        /// <param name="jsonString"></param>
        /// <returns></returns> Si se logro retorna true
        public bool SerializarProductoJSON(string productoElegido, List<Producto> listaProductos, ref string jsonString)
        {
            bool serializacionRealizada = false;
            foreach (Producto p in listaProductos)
            {
                if (p is not null && p == productoElegido)
                {
                    var options = new JsonSerializerOptions { WriteIndented = true };
                    jsonString = JsonSerializer.Serialize(p, options);

                    serializacionRealizada = true;
                    break;
                }
            }

            return serializacionRealizada;
        }

        /// <summary>
        /// Deserializo un ya serializado producto, por medio de JSON
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns> devuelve los datos deserializados
        public string DeSerializarProductoJSON(string jsonString)
        {
            Producto productoDeSerealizado = JsonSerializer.Deserialize<Producto>(jsonString);

            StringBuilder sb = new StringBuilder();
            sb.Append("ID: ");
            sb.AppendLine(productoDeSerealizado.IdProducto.ToString());
            sb.Append("Nombre: ");
            sb.AppendLine(productoDeSerealizado.Tipo);
            sb.Append("Categoria: ");
            sb.AppendLine(productoDeSerealizado.Categoria.ToString());
            sb.Append("Precio x kilo: ");
            sb.AppendLine(productoDeSerealizado.PrecioPorKilo.ToString());
            sb.Append("Cantidad de kilos: ");
            sb.AppendLine(productoDeSerealizado.CantidadKilos.ToString());
            sb.Append("Descripcion: ");
            sb.AppendLine(productoDeSerealizado.Descripcion);

            return sb.ToString();
        }

        /// <summary>
        /// Serializo el producto recibido por XML
        /// </summary>
        /// <param name="productoElegido"></param>
        /// <param name="listaProductos"></param>
        /// <returns></returns>
        public bool SerializarProductoXML(string productoElegido, List<Producto> listaProductos)
        {
            bool serializacionRealizada = false;
            foreach (Producto p in listaProductos)
            {
                if (p is not null && p == productoElegido)
                {
                    using (StreamWriter streamWriter = new StreamWriter("producto.xml"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Producto));

                        serializer.Serialize(streamWriter, p);
                    }

                    serializacionRealizada = true;
                    break;
                }
            }

            return serializacionRealizada;
        }

        /// <summary>
        /// Deserializo un ya serializado producto, por medio de XML
        /// </summary>
        /// <returns></returns>
        public string DeSerializarProductoXML()
        {
            StringBuilder sb = new StringBuilder();

            using (StreamReader streamReader = new StreamReader("producto.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Producto));

                Producto productoDeSerealizado = xmlSerializer.Deserialize(streamReader) as Producto;

                sb.Append("ID: ");
                sb.AppendLine(productoDeSerealizado.IdProducto.ToString());
                sb.Append("Nombre: ");
                sb.AppendLine(productoDeSerealizado.Tipo);
                sb.Append("Categoria: ");
                sb.AppendLine(productoDeSerealizado.Categoria.ToString());
                sb.Append("Precio x kilo: ");
                sb.AppendLine(productoDeSerealizado.PrecioPorKilo.ToString());
                sb.Append("Cantidad de kilos: ");
                sb.AppendLine(productoDeSerealizado.CantidadKilos.ToString());
                sb.Append("Descripcion: ");
                sb.AppendLine(productoDeSerealizado.Descripcion);
            }

            return sb.ToString();
        }
    }
}
