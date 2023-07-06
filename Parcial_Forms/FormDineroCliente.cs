using Parcial_Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Forms
{
    public partial class FormDineroCliente : Form
    {
        private Cliente cliente;

        private List<Producto> listaProductos;

        private bool cierreTotal;

        private int segundosTimer;
        private int minutosTimer;
        private int horasTimer;

        #region Constructores
        public FormDineroCliente()
        {
            InitializeComponent();
        }

        public FormDineroCliente(Cliente cliente, List<Producto> listaProductos) : this()
        {
            this.cliente = cliente;

            this.listaProductos = listaProductos;

            this.cierreTotal = true;

            lblNombreCliente.Text = cliente.NombreUsuario;
        }

        private void FormDineroCliente_Load(object sender, EventArgs e)
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
        /// Checkea que el valor ingresado por el usuario sea valido, y si lo es se hace llamado al form de comprador, asignando dicho valor como su saldo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonDinero_Click(object sender, EventArgs e)
        {
            double dinero;
            double.TryParse(txtDinero.Text, out dinero);

            if (dinero > 0)
            {
                cliente.DineroDisponible = (decimal)dinero;
                FormComprador formComprador = new FormComprador(cliente, listaProductos, horasTimer, minutosTimer, segundosTimer);

                cierreTotal = false;
                this.Hide();

                if (formComprador.ShowDialog() == DialogResult.Cancel)
                {
                    formComprador.Dispose();
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Valor invalido, reintente...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDinero.Text = string.Empty;
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
        private void FormDineroCliente_Closing(object sender, EventArgs e)
        {
            if (cierreTotal)
                Application.Exit();
        }

        #endregion
    }
}
