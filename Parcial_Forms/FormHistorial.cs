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
    public partial class FormHistorial : Form
    {
        private Vendedor vendedor;

        private bool cierreTotal;

        public FormHistorial()
        {
            InitializeComponent();
        }

        public FormHistorial(Vendedor vendedor) : this()
        {
            this.vendedor = vendedor;

            this.cierreTotal = true;

            lblNombreVendedor.Text = this.vendedor.NombreUsuario;

            CargarOperaciones();
        }

        /// <summary>
        /// Muestra en el datagridview todas las operaciones realizadas durante la ejecucion del programa
        /// </summary>
        private void CargarOperaciones()
        {
            foreach (var a in Vendedor.historialOperaciones)
            {
                dgvListaOperaciones.Rows.Add(a.Value, a.Key);
            }
        }

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
        private void FormHistorial_Closing(object sender, EventArgs e)
        {
            if (cierreTotal)
                Application.Exit();
        }

        #endregion
    }
}
