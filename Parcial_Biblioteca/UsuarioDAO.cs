using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    public class UsuarioDAO : ITraerInfoBDD<Usuario>
    {
        private static string connectionString;

        static UsuarioDAO()
        {
            connectionString = "Server=.;Database=CARNICERIA_DB;Trusted_Connection=True";
        }

        /// <summary>
        /// Trae de la base de datos todos los datos de los usuarios y los guarda en la lista
        /// </summary>
        /// <param name="listaProductos"></param>
        public void TraerDatosBDD(List<Usuario> listaUsuarios)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conexion;
            command.CommandText = "SELECT * FROM Usuarios";


            conexion.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                int idUsuario;
                int.TryParse(reader["ID_USUARIO"].ToString(), out idUsuario);

                string nombreCompleto = reader["NOMBRE_COMPLETO"].ToString();

                string emailUsuario = reader["EMAIL"].ToString();

                string claveUsuario = reader["CLAVE"].ToString();

                decimal dineroUsuario;
                decimal.TryParse(reader["DINERO"].ToString(), out dineroUsuario);

                int idRol;
                int.TryParse(reader["ID_ROL"].ToString(), out idRol);

                Usuario usuario = new Vendedor(); //Instancia Aux
                switch(idRol)
                {
                    case 1: //Vendedor
                        usuario = new Vendedor(idUsuario, nombreCompleto, emailUsuario, claveUsuario, "Vendedor");
                        break;

                    case 2: //Cliente
                        usuario = new Cliente(idUsuario, nombreCompleto, emailUsuario, claveUsuario, "Cliente");
                        ((Cliente)usuario).DineroDisponible = dineroUsuario;
                        break;

                    case 3: //Programador
                        usuario = new Programador(idUsuario, nombreCompleto, emailUsuario, claveUsuario, "Programador");
                        break;
                }

                listaUsuarios.Add(usuario);
            }

            conexion.Close();
        }

        /// <summary>
        /// Trae de la base de datos el mail y cuenta del usuario seleccionado.
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="mail"></param>
        /// <param name="clave"></param>
        public static void AutoCompletarDatosBDD(int idUsuario, ref string mail, ref string clave)
        {
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

                if (mailIngresado == mail && claveIngresada == clave)
                {
                    int idUsuario;
                    int.TryParse(reader["ID_USUARIO"].ToString(), out idUsuario);

                    string nombreCompleto = reader["NOMBRE_COMPLETO"].ToString();
                    string Rol = reader["ROL"].ToString();

                    switch (Rol)
                    {
                        case "Vendedor":
                            usuario = new Vendedor(idUsuario, nombreCompleto, mail, clave, Rol);

                            //Cierro y abro la conexion para leer los clientes del vendedor
                            conexion.Close();
                            conexion.Open();
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                if (reader["ROL"].ToString() == "Cliente" && DBNull.Value.Equals(reader["EMAIL"]) && DBNull.Value.Equals(reader["CLAVE"]))
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
        /// Actualizo en la base de datos los valores de dinero del cliente, luego de haber concretado una compra.
        /// </summary>
        /// <param name="cliente"></param>
        /// <exception cref="Exception"></exception>
        public static void ActualizarClienteBDD(Cliente cliente)
        {
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
    }
}
