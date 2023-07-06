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
    public partial class FormFactura : Form
    {
        private List<Producto> carrito;

        private string cliente;
        private string metodoPago;

        private double total;

        public FormFactura()
        {
            InitializeComponent();
        }

        public FormFactura(string cliente, List<Producto> carrito1, string metodoPago) : this()
        {
            this.cliente = cliente;
            this.carrito = new List<Producto>(carrito1);
            this.metodoPago = metodoPago;

            total = 0;
            Vendedor.numeroOperacion++;

            CargaDatos();
            listarProductos();
        }

        /// <summary>
        /// Muestro en la factura los datos de la venta
        /// </summary>
        private void CargaDatos()
        {
            txtNroVenta.Text = Vendedor.numeroOperacion.ToString();
            txtFecha.Text = DateTime.UtcNow.ToString("d");
            txtCliente.Text = cliente;
            txtMetodoPago.Text = metodoPago;
        }

        /// <summary>
        /// Lista los productos del carrito en la factura, con su precio y cantidad.
        /// 
        /// </summary>
        private void listarProductos()
        {
            double multiplicadorMetodoPago = 1;
            if (metodoPago == "Tarjeta de Credito (5% recargo)")
            {
                multiplicadorMetodoPago = 1.05;
            }

            StringBuilder productos = new StringBuilder();

            foreach (Producto p in carrito)
            {
                dgvProductos.Rows.Add(p.Tipo, p.CantidadKilos, p.PrecioPorKilo * multiplicadorMetodoPago, p.PrecioPorKilo * (double)p.CantidadKilos * multiplicadorMetodoPago);
                total += p.PrecioPorKilo * (double)p.CantidadKilos * multiplicadorMetodoPago;
            }

            RegistroVentas venta = new RegistroVentas(DateTime.UtcNow, cliente, carrito, (decimal)total);
            RegistroVentas.AgregarVentaAlHistorial(venta);

            txtTotal.Text = total.ToString();
        }
    }
}
