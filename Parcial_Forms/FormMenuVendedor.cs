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
    public partial class FormMenuVendedor : Form
    {
        private Vendedor vendedor;
        private List<Producto> listaProductos;

        private bool cierreTotal;

        private int segundosTimer;
        private int minutosTimer;
        private int horasTimer;

        #region constructores

        public FormMenuVendedor()
        {
            InitializeComponent();
        }

        public FormMenuVendedor(Vendedor vendedor, List<Producto> listaProductos) : this()
        {
            this.vendedor = vendedor;
            this.listaProductos = listaProductos;
            this.cierreTotal = true;

            lblNombreVendedor.Text = vendedor.NombreUsuario;
        }

        private void FormMenuVendedor_Load(object sender, EventArgs e)
        {
            segundosTimer = 0;
            minutosTimer = 0;
            horasTimer = 0;
            rtbHoras.Text = rtbMinutos.Text = rtbSegundos.Text = "00";
        }

        #endregion

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
        /// Abre el form de ventas y oculta este form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonVentas_Click(object sender, EventArgs e)
        {
            FormVenta formVenta = new FormVenta(vendedor, listaProductos, horasTimer, minutosTimer, segundosTimer);

            this.Hide();

            if (formVenta.ShowDialog() == DialogResult.Cancel)
            {
                formVenta.Dispose();
                cierreTotal = false;
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        /// <summary>
        /// Abre el form de inventario y oculta este form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void botonInventario_Click(object sender, EventArgs e)
        {
            FormInventario formInventario = new FormInventario(vendedor, listaProductos, horasTimer, minutosTimer, segundosTimer);

            this.Hide();

            if (formInventario.ShowDialog() == DialogResult.Cancel)
            {
                formInventario.Dispose();
                cierreTotal = false;
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        #region Parametros de Cierre

        /// <summary>
        /// Al apretar el boton de volver al menu, se cerrara este form, y se mostrara nuevamente el form de login.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbVolver_Click(object sender, EventArgs e)
        {
            cierreTotal = false;
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// En caso de que se aprete la cruz de cierre del form, se cerrara todo el programa.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMenuVendedor_Closing(object sender, EventArgs e)
        {
            if (cierreTotal)
                Application.Exit();
        }

        #endregion
    }
}
