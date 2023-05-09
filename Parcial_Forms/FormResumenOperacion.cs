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
    public partial class FormResumenOperacion : Form
    {
        private Usuario usuario;

        private decimal subtotal;

        private List<Producto> listaCarrito;
        private List<Producto> listaProductos;

        private bool cierreTotal;

        public FormResumenOperacion()
        {
            InitializeComponent();
        }

        public FormResumenOperacion(Usuario usuario, decimal subtotal, List<Producto> listaCarrito, List<Producto> listaProductos) : this()
        {
            this.usuario = usuario;
            this.subtotal = subtotal;

            this.listaCarrito = listaCarrito;
            this.listaProductos = listaProductos;

            this.cierreTotal = true;

            CargasDatosForm();
        }

        /// <summary>
        /// Modifica parametros visuales del form segun el usuario que ingrese, y actualiza los valores
        /// </summary>
        private void CargasDatosForm()
        {
            if (usuario is Cliente)
            {
                cbClientes.Items.Add(usuario.NombreUsuario);
                cbClientes.SelectedIndex = 0;
                txtSaldoCliente.Text = ((Cliente)usuario).DineroDisponible.ToString();
                this.BackColor = Color.FloralWhite;
            }
            else if (usuario is Vendedor)
            {
                cbClientes.DataSource = ((Vendedor)usuario).ListaClientes;
                lblTitulo.Text = "Venta";
                lblDatosVenta.Text = "Datos de Venta";
                botonCancelar.Text = "Cancelar Venta";
                botonConfirmar.Text = "Confirmar Venta";
                lblSaldoCliente.Hide();
                txtSaldoCliente.Hide();
                this.BackColor = Color.Honeydew;
            }

            cbMetodoPago.SelectedIndex = -1;

            txtSubtotal.Text = subtotal.ToString();
            txtTotal.Text = subtotal.ToString();

            foreach (Producto p in listaCarrito)
            {
                if (p is not null)
                {
                    dgvProductosVenta.Rows.Add(p.Tipo, p.CantidadKilos, p.PrecioPorKilo, (decimal)p.PrecioPorKilo * p.CantidadKilos);
                }
            }
        }

        /// <summary>
        /// Si se elige el metodo de pago credito, el precio total se incrementa un 5%
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMetodoPago.SelectedIndex == 0)
                txtTotal.Text = (subtotal * (decimal)1.05).ToString();
            else
                txtTotal.Text = subtotal.ToString();
        }

        /// <summary>
        /// Segun el usuario actual, se llama a la funcion comprar o vender, y si se realizo la operacion correctamente se hace llamado al form de factura. Se checkea que no haya datos sin completar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            if (cbMetodoPago.SelectedIndex != -1)
            {
                decimal total;
                decimal.TryParse(txtTotal.Text, out total);

                if (usuario is Cliente)
                {
                    if (Cliente.RealizarCompra((Cliente)usuario, listaCarrito, listaProductos, total))
                    {
                        MessageBox.Show("Compra realizada con exito. Generando factura de compra...", "Compra", MessageBoxButtons.OK);

                        this.Hide();
                        cierreTotal = false;

                        FormFactura formFactura = new FormFactura(usuario.NombreUsuario, listaCarrito, cbMetodoPago.Text);
                        if (formFactura.ShowDialog() == DialogResult.Cancel)
                        {
                            listaCarrito.Clear();
                            this.Close();
                            this.DialogResult = MessageBox.Show("Desea realizar otra compra?", "Cierre", MessageBoxButtons.YesNo);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Saldo Insuficiente, venta cancelada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cierreTotal = false;
                        this.Close();
                    }
                }
                else if (usuario is Vendedor)
                {
                    if (cbClientes.SelectedIndex != -1)
                    {
                        string mensajeVenta = Vendedor.RealizarVenta(cbClientes.Text);

                        MessageBox.Show(mensajeVenta, "Venta", MessageBoxButtons.OK);

                        this.Hide();
                        cierreTotal = false;

                        FormFactura formFactura = new FormFactura(cbClientes.Text, listaCarrito, cbMetodoPago.Text);
                        if (formFactura.ShowDialog() == DialogResult.Cancel)
                        {
                            listaCarrito.Clear();
                            this.Close();
                            this.DialogResult = MessageBox.Show("Desea realizar otra Venta?", "Cierre", MessageBoxButtons.YesNo);
                        }
                    }
                    else
                        MessageBox.Show("Cliente vacio o invalido. Reintente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Metodo de pago vacio o invalido. Reintente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Se cancela la operacion, se retorna el stock a la lista principal, y se vuelve al form anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelando Operacion....", "Compra Cancelada", MessageBoxButtons.OK);

            Producto.DevolverStockCarrito(listaCarrito, listaProductos);
            listaCarrito.Clear();

            cierreTotal = false;

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        #region Parametros de Cierre

        /// <summary>
        /// En caso de que se aprete la cruz de cierre del form, se cerrara todo el programa.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormResumenOperacion_Closing(object sender, EventArgs e)
        {
            if (cierreTotal)
                Application.Exit();
        }

        #endregion
    }
}
