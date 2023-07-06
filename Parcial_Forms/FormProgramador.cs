using Parcial_Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;

namespace Parcial_Forms
{
    public partial class FormProgramador : Form
    {
        private Programador usuario;

        private List<Producto> listaProductos;
        private List<Usuario> listaUsuarios;

        private bool cierreTotal;
        private bool productoSerializadoJSON;
        private bool productoSerializadoXML;

        private int segundosTimer;
        private int minutosTimer;
        private int horasTimer;

        private string jsonString;

        #region Constructores

        public FormProgramador()
        {
            InitializeComponent();
        }

        public FormProgramador(Programador usuario, List<Producto> listaProductos) : this()
        {
            this.usuario = usuario;
            this.listaProductos = listaProductos;
            this.listaUsuarios = new List<Usuario>();
        }

        private void FormProgramador_Load(object sender, EventArgs e)
        {
            Task t1 = Task.Run(CargarDatosTablas);

            cierreTotal = true;
            productoSerializadoJSON = false;
            productoSerializadoXML = false;

            lblNombreProgramador.Text = usuario.NombreUsuario;

            foreach (Producto p in listaProductos)
            {
                if (p.CantidadKilos > 0)
                    cbProductos.Items.Add(p.Tipo);

                dgvListaProductos.Rows.Add(p.Tipo, p.Categoria, p.CantidadKilos, p.PrecioPorKilo, p.Descripcion);
            }

            foreach (Usuario u in listaUsuarios)
            {
                string dineroUsuario = " ";
                if (u.RolUsuario == "Cliente")
                {
                    dineroUsuario = ((Cliente)u).DineroDisponible.ToString();
                }

                dgvListaUsuarios.Rows.Add(u.NombreUsuario, u.EMailUsuario, u.ClaveUsuario, dineroUsuario, u.RolUsuario);
            }

            segundosTimer = 0;
            minutosTimer = 0;
            horasTimer = 0;
            rtbHoras.Text = rtbMinutos.Text = rtbSegundos.Text = "00";

            rtbHistorial.Text = RegistroVentas.historialVentas;

        }

        #endregion

        /// <summary>
        /// Actualiza el timer segundo a segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTiempoSesion_Tick(object sender, EventArgs e)
        {
            if (segundosTimer < 59)
            {
                segundosTimer++;
                if (segundosTimer < 10)
                {
                    rtbSegundos.Text = "0" + segundosTimer.ToString();
                }
                else
                {
                    rtbSegundos.Text = segundosTimer.ToString();
                }
            }
            else
            {
                segundosTimer = 0;
                rtbSegundos.Text = "00";

                if (minutosTimer < 59)
                {
                    minutosTimer++;
                    if (minutosTimer < 10)
                    {
                        rtbMinutos.Text = "0" + minutosTimer.ToString();
                    }
                    else
                    {
                        rtbMinutos.Text = minutosTimer.ToString();
                    }
                }
                else
                {
                    minutosTimer = 0;
                    rtbMinutos.Text = "00";

                    horasTimer++;
                    if (horasTimer < 10)
                    {
                        rtbHoras.Text = "0" + horasTimer.ToString();
                    }
                    else
                    {
                        rtbHoras.Text = horasTimer.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// Carga la tabla de usuarios con datos traidos de la base de datos
        /// </summary>
        private void CargarDatosTablas()
        {
            UsuarioDAO controlUsuarios = new UsuarioDAO();
            try
            {
                controlUsuarios.TraerDatosBDD(listaUsuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Serializacion

        /// <summary>
        /// Serializa por JSON el producto seleccionado en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonSerializarJSON_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedIndex != -1)
            {
                productoSerializadoJSON = usuario.SerializarProductoJSON(cbProductos.Text, listaProductos, ref jsonString);
                if (productoSerializadoJSON)
                    MessageBox.Show("Producto serializado con exito");
                else
                    MessageBox.Show("Error al serializar, reintente");

                rtbSalidaSerializado.Text = jsonString;
            }
            else
            {
                MessageBox.Show("Primero seleccione un producto");
            }
        }

        /// <summary>
        /// Deserializa el producto previamente serializado por JSON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonDeSerializarJSON_Click(object sender, EventArgs e)
        {
            if (productoSerializadoJSON)
            {
                rtbSalidaSerializado.Text = usuario.DeSerializarProductoJSON(jsonString);
            }
            else
            {
                MessageBox.Show("Primero serialice por JSON un producto");
            }
        }

        /// <summary>
        /// Serializa por XML el producto seleccionado en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonSerializarXML_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedIndex != -1)
            {
                productoSerializadoXML = usuario.SerializarProductoXML(cbProductos.Text, listaProductos);
                if (productoSerializadoXML)
                    MessageBox.Show("Producto serializado correctamente en el archivo: producto.xml");
                else
                    MessageBox.Show("Error al serializar el producto. Reintente");
            }
            else
            {
                MessageBox.Show("Primero seleccione un producto");
            }
        }

        /// <summary>
        /// Deserializa el producto previamente serializado por XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonDeSerializarXML_Click(object sender, EventArgs e)
        {
            if (productoSerializadoXML)
            {
                rtbSalidaSerializado.Text = usuario.DeSerializarProductoXML();
            }
            else
            {
                MessageBox.Show("Primero serialice por XML un producto");
            }
        }

        /// <summary>
        /// Guardo el historial de ventas en un txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonGenerarHistorial_Click(object sender, EventArgs e)
        {
            if (Vendedor.numeroOperacion > 0)
            {
                try
                {
                    File.AppendAllText("HistorialVentas.txt", RegistroVentas.historialVentas);
                    MessageBox.Show("Historial guardado con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("No se encontraron operaciones a guardar, reintente");
        }

        #endregion

        #region Parametros de Cierre

        /// <summary>
        /// En caso de que se aprete la opcion de cierre de sesion en el form, solo se cerrara el form, y se retornara al form login.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            cierreTotal = false;
            this.Close();
        }

        /// <summary>
        /// En caso de que se aprete la cruz de cierre del form, se cerrara todo el programa.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProgramador_Closing(object sender, EventArgs e)
        {
            if (cierreTotal)
                Application.Exit();
        }

        #endregion
    }
}
