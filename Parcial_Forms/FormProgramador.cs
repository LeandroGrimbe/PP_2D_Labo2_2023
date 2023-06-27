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

        private bool cierreTotal;
        private bool productoSerializadoJSON;
        private bool productoSerializadoXML;

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
        }

        #endregion

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

        private void FormProgramador_Load(object sender, EventArgs e)
        {
            cierreTotal = true;
            productoSerializadoJSON = false;
            productoSerializadoXML = false;

            lblNombreProgramador.Text = usuario.NombreUsuario;

            foreach (Producto p in listaProductos)
            {
                if (p is not null)
                    cbProductos.Items.Add(p.Tipo);
            }

            rtbHistorial.Text = RegistroVentas.historialVentas;
        }

        /// <summary>
        /// Guardo el historial de ventas en un txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonGenerarHistorial_Click(object sender, EventArgs e)
        {
            if (Vendedor.numeroOperacion > 1)
            {
                StreamWriter streamWriter = null;
                try
                {
                    File.AppendAllText("HistorialVentas.txt", RegistroVentas.historialVentas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron operaciones a guardar, reintente");
            }
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
