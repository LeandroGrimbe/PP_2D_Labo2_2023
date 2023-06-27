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
    public partial class FormComprador : Form
    {
        private Cliente cliente;

        private List<Producto> listaProductos;
        private List<Producto> listaCarrito;

        private bool cierreTotal;

        #region Constructores

        public FormComprador()
        {
            InitializeComponent();
        }

        public FormComprador(Cliente cliente, List<Producto> listaProductos) : this()
        {
            this.cliente = cliente;
            this.listaProductos = listaProductos;
            this.listaCarrito = new List<Producto>();
        }

        private void FormComprador_Load(object sender, EventArgs e)
        {
            lblNombreCliente.Text = cliente.NombreUsuario;

            nudProducto1.DecimalPlaces = 2;
            nudProducto1.Increment = 0.1M;
            nudProducto2.DecimalPlaces = 2;
            nudProducto2.Increment = 0.1M;
            nudProducto3.DecimalPlaces = 2;
            nudProducto3.Increment = 0.1M;
            nudProducto4.DecimalPlaces = 2;
            nudProducto4.Increment = 0.1M;
            nudProducto5.DecimalPlaces = 2;
            nudProducto5.Increment = 0.1M;
            nudListaProductos.DecimalPlaces = 2;
            nudListaProductos.Increment = 0.1M;

            Task t1 = new Task(ParametrosIniciales);
            t1.Start();

            configFondoLogo(pbProducto1, pbIconoSinStock1);
            configFondoLogo(pbProducto2, pbIconoSinStock2);
            configFondoLogo(pbProducto3, pbIconoSinStock3);
            configFondoLogo(pbProducto4, pbIconoSinStock4);
            configFondoLogo(pbProducto5, pbIconoSinStock5);

            txtSubtotalCarrito.Text = "0";
        }

        #endregion

        #region Botones Form

        /// <summary>
        /// Agrega al carrito la cantidad indicada del producto 1, y actualiza los valores de los productos mostrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarProducto1_Click(object sender, EventArgs e)
        {
            Producto.AgregarAlCarrito(listaCarrito, listaProductos[0], nudProducto1.Value);
            ActualizarSubtotal(listaProductos[0], nudProducto1.Value);
            ParametrosIniciales();
        }

        /// <summary>
        /// Agrega al carrito la cantidad indicada del producto 2, y actualiza los valores de los productos mostrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarProducto2_Click(object sender, EventArgs e)
        {
            Producto.AgregarAlCarrito(listaCarrito, listaProductos[1], nudProducto2.Value);
            ActualizarSubtotal(listaProductos[1], nudProducto2.Value);
            ParametrosIniciales();
        }

        /// <summary>
        /// Agrega al carrito la cantidad indicada del producto 3, y actualiza los valores de los productos mostrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarProducto3_Click(object sender, EventArgs e)
        {
            Producto.AgregarAlCarrito(listaCarrito, listaProductos[2], nudProducto3.Value);
            ActualizarSubtotal(listaProductos[2], nudProducto3.Value);
            ParametrosIniciales();
        }

        /// <summary>
        /// Agrega al carrito la cantidad indicada del producto 4, y actualiza los valores de los productos mostrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarProducto4_Click(object sender, EventArgs e)
        {
            Producto.AgregarAlCarrito(listaCarrito, listaProductos[3], nudProducto4.Value);
            ActualizarSubtotal(listaProductos[3], nudProducto4.Value);
            ParametrosIniciales();
        }

        /// <summary>
        /// Agrega al carrito la cantidad indicada del producto 5, y actualiza los valores de los productos mostrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonAgregarProducto5_Click(object sender, EventArgs e)
        {
            Producto.AgregarAlCarrito(listaCarrito, listaProductos[4], nudProducto5.Value);
            ActualizarSubtotal(listaProductos[4], nudProducto5.Value);
            ParametrosIniciales();
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

                        ParametrosIniciales();

                        break;
                    }
                }
            }
            else
                MessageBox.Show("Producto invalido, reintente...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Vacia el carrito de compras y devuelve el stock a la lista de productos principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbVaciarCarrito_Click(object sender, EventArgs e)
        {
            Producto.DevolverStockCarrito(listaCarrito, listaProductos);
            listaCarrito.Clear();

            txtSubtotalCarrito.Text = "0";
            ParametrosIniciales();
        }

        /// <summary>
        /// Si hay al menos 1 producto en el carrito, y el cliente tiene dinero suficiente, se hace llamado al form de resumen de venta. Caso contrario se notifica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonFinalizarCompra_Click(object sender, EventArgs e)
        {
            decimal subtotalAux;
            decimal.TryParse(txtSubtotalCarrito.Text, out subtotalAux);

            if (listaCarrito.Count != 0 && subtotalAux > 0)
            {
                if (cliente.CheckearSaldo(subtotalAux))
                {
                    FormResumenOperacion formResumenOperacion = new FormResumenOperacion(cliente, subtotalAux, listaCarrito, listaProductos);

                    this.Hide();
                    cierreTotal = false;

                    if (formResumenOperacion.ShowDialog() == DialogResult.Yes)
                    {
                        ParametrosIniciales();
                        txtSubtotalCarrito.Text = "0";

                        this.Show();
                    }
                    else
                        this.Close();
                }
                else
                    MessageBox.Show("Saldo Insuficiente, revise el carrito y reintente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Carrito Vacio, Ingrese un producto antes de continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ParametrosIniciales();
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
                    nudListaProductos.Maximum = p.CantidadKilos;
                    txtPrecioProducto.Text = p.PrecioPorKilo.ToString();
                    txtCantidadProductoElegido.Text = p.CantidadKilos.ToString();
                }
            }
        }

        #endregion

        #region Otras funciones

        /// <summary>
        /// Actualiza todos los valores mostrados en el forms
        /// </summary>
        private void ParametrosIniciales()
        {
            lblSaldoCliente.Text = "Saldo: " + cliente.DineroDisponible;

            dgvCarrito.Rows.Clear();
            foreach (Producto p in listaCarrito)
            {
                if (p is not null)
                {
                    dgvCarrito.Rows.Add(p.Tipo, p.CantidadKilos, p.PrecioPorKilo, (decimal)p.PrecioPorKilo * p.CantidadKilos);
                }
            }

            cbProductos.Items.Clear();
            foreach (Producto p in listaProductos)
            {
                if (p is not null && p.CantidadKilos > 0)
                    cbProductos.Items.Add(p.Tipo);
            }

            lblProducto1.Text = listaProductos[0].MostrarDatos();
            lblProducto2.Text = listaProductos[1].MostrarDatos();
            lblProducto3.Text = listaProductos[2].MostrarDatos();
            lblProducto4.Text = listaProductos[3].MostrarDatos();
            lblProducto5.Text = listaProductos[4].MostrarDatos();

            if (listaProductos[0].CantidadKilos < 1)
                pbIconoSinStock1.Show();
            else
                pbIconoSinStock1.Hide();

            if (listaProductos[1].CantidadKilos < 1)
                pbIconoSinStock2.Show();
            else
                pbIconoSinStock2.Hide();

            if (listaProductos[2].CantidadKilos < 1)
                pbIconoSinStock3.Show();
            else
                pbIconoSinStock3.Hide();

            if (listaProductos[3].CantidadKilos < 1)
                pbIconoSinStock4.Show();
            else
                pbIconoSinStock4.Hide();

            if (listaProductos[4].CantidadKilos < 1)
                pbIconoSinStock5.Show();
            else
                pbIconoSinStock5.Hide();

            lblCantidad1.Text = "(stock: " + listaProductos[0].CantidadKilos.ToString() + ")";
            lblCantidad2.Text = "(stock: " + listaProductos[1].CantidadKilos.ToString() + ")";
            lblCantidad3.Text = "(stock: " + listaProductos[2].CantidadKilos.ToString() + ")";
            lblCantidad4.Text = "(stock: " + listaProductos[3].CantidadKilos.ToString() + ")";
            lblCantidad5.Text = "(stock: " + listaProductos[4].CantidadKilos.ToString() + ")";

            nudProducto1.Maximum = listaProductos[0].CantidadKilos;
            nudProducto2.Maximum = listaProductos[1].CantidadKilos;
            nudProducto3.Maximum = listaProductos[2].CantidadKilos;
            nudProducto4.Maximum = listaProductos[3].CantidadKilos;
            nudProducto5.Maximum = listaProductos[4].CantidadKilos;

            nudProducto1.Value = 0;
            nudProducto2.Value = 0;
            nudProducto3.Value = 0;
            nudProducto4.Value = 0;
            nudProducto5.Value = 0;

            nudListaProductos.Maximum = 0;
            cbProductos.SelectedIndex = -1;
            cbProductos.Text = string.Empty;
            txtCantidadProductoElegido.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;

            this.cierreTotal = true;
        }

        /// <summary>
        /// Actualiza el subtotal de la compra segun se va agregando un producto al carrito
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
        /// Une la imagen del producto y el icono de sin stock para que asi coincidan en el color de fondo.
        /// 
        /// </summary>
        /// <param name="label"></param>
        private void configFondoLogo(PictureBox producto, PictureBox icono)
        {
            var pos = this.PointToScreen(icono.Location);
            pos = producto.PointToClient(pos);
            icono.Parent = producto;
            icono.Location = pos;
            icono.BackColor = Color.Transparent;

            icono.Hide();
        }

        #endregion

        #region Parametros de Cierre

        /// <summary>
        /// En caso de que se aprete la opcion de cierre de sesion en el form, solo se cerrara el form.
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
        private void FormComprador_Closing(object sender, EventArgs e)
        {
            if (cierreTotal)
                Application.Exit();
        }

        #endregion
    }
}
