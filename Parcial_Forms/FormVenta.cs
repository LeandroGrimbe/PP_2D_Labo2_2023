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
    public partial class FormVenta : Form
    {
        private Vendedor vendedor;

        private List<Producto> listaProductos;
        private List<Producto> listaCarrito;

        private bool cierreTotal;

        public FormVenta()
        {
            InitializeComponent();
        }

        public FormVenta(Vendedor vendedor, List<Producto> listaProductos) : this()
        {
            this.listaProductos = listaProductos;
            this.listaCarrito = new List<Producto>();

            this.vendedor = vendedor;

            nudListaProductos.DecimalPlaces = 2;
            nudListaProductos.Increment = 0.1M;
            lblNombreVendedor.Text = vendedor.NombreUsuario;
            txtSubtotalCarrito.Text = "0";

            MostrarDatos();
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
        /// Muestra la cantidad y precio del producto seleccionado, segun se vaya cambiando en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Producto p in listaProductos)
            {
                if (p == cbProductos.Text)
                {
                    nudListaProductos.Value = 0;
                    nudListaProductos.Maximum = p.CantidadKilos;
                    txtPrecioProducto.Text = p.PrecioPorKilo.ToString();
                    txtCantidadProductoElegido.Text = p.CantidadKilos.ToString();
                }
            }
        }

        /// <summary>
        /// Agrega al carrito el producto seleccionado, con la cantidad seleccionada y se actualizan los valores. Si la cantidad es menor o igual a 0 no se realiza ningun cambio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedIndex != -1)
            {
                foreach (Producto p in listaProductos)
                {
                    if (p == cbProductos.Text)
                    {
                        Producto.AgregarAlCarrito(listaCarrito, p, nudListaProductos.Value);
                        ActualizarSubtotal(p, nudListaProductos.Value);

                        MostrarDatos();

                        break;
                    }
                }
            }
            else
                MessageBox.Show("Producto invalido, reintente...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Si hay al menos 1 producto en el carrito, se hace llamado al form de resumen de venta. Caso contrario se notifica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonFinalizarVenta_Click(object sender, EventArgs e)
        {
            decimal subtotalAux;
            decimal.TryParse(txtSubtotalCarrito.Text, out subtotalAux);

            if (listaCarrito.Count != 0 && subtotalAux > 0)
            {
                FormResumenOperacion formResumenOperacion = new FormResumenOperacion(vendedor, subtotalAux, listaCarrito, listaProductos);

                this.Hide();
                cierreTotal = false;

                if (formResumenOperacion.ShowDialog() == DialogResult.Yes)
                {
                    MostrarDatos();
                    txtSubtotalCarrito.Text = "0";

                    this.Show();
                }
                else
                    this.Close();
            }
            else
                MessageBox.Show("Carrito Vacio, Ingrese un producto antes de continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            MostrarDatos();
        }

        /// <summary>
        /// Vacia el carrito de ventas y devuelve el stock a la lista de productos principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbVaciarCarrito_Click(object sender, EventArgs e)
        {
            Producto.DevolverStockCarrito(listaCarrito, listaProductos);
            listaCarrito.Clear();

            txtSubtotalCarrito.Text = "0";
            MostrarDatos();
        }

        #endregion

        #region Otras Funciones

        /// <summary>
        /// Actualiza el subtotal de la venta segun se va agregando un producto al carrito
        /// </summary>
        /// <param name="p"></param>
        /// <param name="cantidad"></param>
        private void ActualizarSubtotal(Producto p, decimal cantidad)
        {
            decimal subtotalAux;
            if (decimal.TryParse(txtSubtotalCarrito.Text, out subtotalAux))
                txtSubtotalCarrito.Text = (subtotalAux + ((decimal)p.PrecioPorKilo * cantidad)).ToString();
        }

        /// <summary>
        /// Actualiza los datos del form
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

                    if (p.CantidadKilos > 0)
                        cbProductos.Items.Add(p.Tipo);
                }
            }

            dgvCarrito.Rows.Clear();
            foreach (Producto p in listaCarrito)
            {
                if (p is not null)
                {
                    dgvCarrito.Rows.Add(p.Tipo, p.CantidadKilos, p.PrecioPorKilo, (decimal)p.PrecioPorKilo * p.CantidadKilos);
                }
            }

            cbProductos.Text = string.Empty;
            txtCantidadProductoElegido.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;

            nudListaProductos.Maximum = 0;
            cbFiltros.SelectedIndex = 0;

            this.cierreTotal = true;
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
        private void FormVenta_Closing(object sender, EventArgs e)
        {
            if (cierreTotal)
                Application.Exit();
        }

        #endregion
    }
}
