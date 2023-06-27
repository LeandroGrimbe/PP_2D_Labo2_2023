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
        private Cliente clienteSeleccionado;

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
                foreach (Cliente c in ((Vendedor)usuario).listaClientes)
                {
                    if (c is not null)
                        cbClientes.Items.Add(c.NombreUsuario);
                }
                cbClientes.SelectedIndex = -1;

                lblTitulo.Text = "Venta";
                lblDatosVenta.Text = "Datos de Venta";
                botonCancelar.Text = "Cancelar Venta";
                botonConfirmar.Text = "Confirmar Venta";
                this.BackColor = Color.Honeydew;
            }

            cbMetodoPago.SelectedIndex = -1;

            txtSubtotal.Text = subtotal.ToString();
            txtTotal.Text = subtotal.ToString();

            foreach (Producto p in listaCarrito)
            {
                if (p is not null)
                    dgvProductosVenta.Rows.Add(p.Tipo, p.CantidadKilos, p.PrecioPorKilo, (decimal)p.PrecioPorKilo * p.CantidadKilos);
            }
        }

        /// <summary>
        /// Segun el cliente seleccionado en el combobox, se actualiza el campo de saldo disponible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usuario is Vendedor)
            {
                foreach (Cliente c in ((Vendedor)usuario).listaClientes)
                {
                    if (c.NombreUsuario == cbClientes.Text)
                    {
                        clienteSeleccionado = c;
                        txtSaldoCliente.Text = c.DineroDisponible.ToString();
                        break;
                    }
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

                try
                {
                    if (usuario is Cliente)
                    {
                        if (((Cliente)usuario).FinalizarOperacion((Cliente)usuario, listaCarrito, listaProductos, total))
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
                            MessageBox.Show("Saldo Insuficiente, Compra cancelada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cierreTotal = false;
                            this.Close();
                            this.DialogResult = DialogResult.Yes;
                        }
                    }
                    else if (usuario is Vendedor)
                    {
                        if (cbClientes.SelectedIndex != -1)
                        {
                            if (((Vendedor)usuario).FinalizarOperacion(clienteSeleccionado, listaCarrito, listaProductos, total))
                            {
                                MessageBox.Show("Venta realizada con exito a " + clienteSeleccionado.NombreUsuario + "\nGenerando factura de Venta...", "Venta", MessageBoxButtons.OK);

                                this.Hide();
                                cierreTotal = false;

                                FormFactura formFactura = new FormFactura(clienteSeleccionado.NombreUsuario, listaCarrito, cbMetodoPago.Text);
                                if (formFactura.ShowDialog() == DialogResult.Cancel)
                                {
                                    listaCarrito.Clear();
                                    this.Close();
                                    this.DialogResult = MessageBox.Show("Desea realizar otra Venta?", "Cierre", MessageBoxButtons.YesNo);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Saldo Insuficiente, venta cancelada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cierreTotal = false;
                                this.Close();
                                this.DialogResult = DialogResult.Yes;
                            }
                        }
                        else
                            MessageBox.Show("Cliente vacio o invalido. Reintente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            MessageBox.Show("Cancelando Operacion....", "Operacion Cancelada", MessageBoxButtons.OK);

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
