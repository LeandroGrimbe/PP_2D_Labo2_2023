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

                    File.WriteAllText("producto.json", jsonString);

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
