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

namespace Parcial_Forms
{
    public partial class FormInventario : Form
    {
        private Vendedor vendedor;
        private List<Producto> listaProductos;

        private bool cierreTotal;

        public FormInventario()
        {
            InitializeComponent();
        }

        public FormInventario(Vendedor vendedor, List<Producto> listaProductos) : this()
        {
            this.vendedor = vendedor;
            this.listaProductos = listaProductos;

            this.lblNombreVendedor.Text = vendedor.NombreUsuario;

            MostrarDatos();
        }

        /// <summary>
        /// Actualiza todos los valores mostrados en el forms
        /// </summary>
        private void MostrarDatos()
        {
            dgvListaProductos.Rows.Clear();
            cbProductos.Items.Clear();

            foreach (Producto p in listaProductos)
            {
                if (p is not null)
                {
                    dgvListaProductos.Rows.Add(p.Tipo, p.Categoria, p.CantidadKilos, p.PrecioPorKilo, p.Descripcion);

                    cbProductos.Items.Add(p.Tipo);
                }
            }

            pNuevoProducto.Hide();
            cbCategoriasProducto.SelectedIndex = -1;
            txtNombreNuevoProducto.Text = string.Empty;
            txtCantidadNuevoProducto.Text = string.Empty;
            txtPrecioNuevoProducto.Text = string.Empty;
            txtDetallesNuevoProducto.Text = string.Empty;

            pEditarProducto.Hide();
            txtCantidadActual.Text = string.Empty;
            txtCantidadActual.Text = string.Empty;
            txtPrecioActual.Text = string.Empty;
            txtDetallesActuales.Text = string.Empty;
            cbNuevaCategoria.SelectedIndex = -1;
            txtSumarCantidad.Text = string.Empty;
            txtTotalCantidad.Text = string.Empty;
            txtNuevoPrecio.Text = string.Empty;
            txtNuevosDetalles.Text = string.Empty;

            cbProductos.Text = string.Empty;
            cbFiltros.SelectedIndex = 0;

            this.cierreTotal = true;
        }

        #region Botones Form

        /// <summary>
        /// Segun la categoria elegida, lista en la tabla los productos disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListaProductos.Rows.Clear();
            foreach (Producto p in listaProductos)
            {
                if (p is not null)
                {
                    if (cbFiltros.Text == "Sin Filtrar")
                        dgvListaProductos.Rows.Add(p.Tipo, p.Categoria, p.CantidadKilos, p.PrecioPorKilo, p.Descripcion);

                    else if (p.Categoria.ToString() == cbFiltros.Text)
                        dgvListaProductos.Rows.Add(p.Tipo, p.Categoria, p.CantidadKilos, p.PrecioPorKilo, p.Descripcion);
                }
            }
        }

        /// <summary>
        /// Abre el menu de nuevo producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbBotonNuevoProducto_Click(object sender, EventArgs e)
        {
            MostrarDatos();
            pNuevoProducto.Show();
        }

        /// <summary>
        /// Si hay un producto elegido en el combobox, abre el menu de edicion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbBotonEditarProducto_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedIndex != -1)
            {
                pNuevoProducto.Hide();
                pEditarProducto.Show();
            }
            else
                MessageBox.Show("Seleccione un producto");
        }

        /// <summary>
        /// Se llama al metodo de edicion de producto con los valores indicados, y luego se muestra un informe de los cambios realizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonEditarProducto_Click(object sender, EventArgs e)
        {
            foreach (Producto p in listaProductos)
            {
                if (p == cbProductos.Text)
                {
                    MessageBox.Show(Vendedor.EditarProducto(p, cbNuevaCategoria.Text, txtTotalCantidad.Text, txtNuevoPrecio.Text, txtNuevosDetalles.Text));
                    break;
                }
            }

            MostrarDatos();
        }

        /// <summary>
        /// Se llama al metodo de crear producto con los valores indicados, y luego se muestra un mensaje de si se agrego o no correctamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Vendedor.NuevoProducto(listaProductos, cbCategoriasProducto.Text, txtNombreNuevoProducto.Text, txtCantidadNuevoProducto.Text, txtPrecioNuevoProducto.Text, txtDetallesNuevoProducto.Text));
            MostrarDatos();
        }

        /// <summary>
        /// Muestra los datos del producto elegido en el menu de edicion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Producto p in listaProductos)
            {
                if (p is not null && p == cbProductos.Text)
                {
                    txtCategoriaActual.Text = p.Categoria.ToString();
                    txtCantidadActual.Text = p.CantidadKilos.ToString();
                    txtPrecioActual.Text = p.PrecioPorKilo.ToString();
                    txtDetallesActuales.Text = p.Descripcion;
                    break;
                }
            }
        }

        /// <summary>
        /// Cuando se ingrese un valor en la caja de texto de sumar cantidad, se sumara con la cantidad actual y se mostrara en la caja de texto de total cantidad. Si ingresa un valor invalido se notifica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSumarCantidad_TextChanged(object sender, EventArgs e)
        {
            decimal cantidadASumar;
            decimal cantidadActual;

            if (txtSumarCantidad.Text != string.Empty)
            {
                if (decimal.TryParse(txtSumarCantidad.Text, out cantidadASumar))
                {
                    decimal.TryParse(txtCantidadActual.Text, out cantidadActual);
                    txtTotalCantidad.Text = (cantidadActual + cantidadASumar).ToString();
                }
                else
                {
                    MessageBox.Show("Cantidad invalida");
                    txtSumarCantidad.Text = string.Empty;
                }
            }
            else
                txtTotalCantidad.Text = string.Empty;
        }

        #endregion

        #region Parametros de Cierre

        /// <summary>
        /// Al apretar el boton de volver al menu, se cerrara este form, y se mostrara nuevamente el menu principal del Vendedor.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbBotonVolverMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            cierreTotal = false;
            this.Close();
        }

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
        private void FormInventario_Closing(object sender, EventArgs e)
        {
            if (cierreTotal)
                Application.Exit();
        }

        #endregion
    }
}
