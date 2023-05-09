using Parcial_Biblioteca;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Forms
{
    public partial class FormLogin : Form
    {

        private Usuario cliente1;
        private Usuario cliente2;
        private Usuario vendedor;

        private List<Producto> listaProductos;

        private System.Media.SoundPlayer player;

        #region Constructores

        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Inicializo los atributos con los parametros, utilizo funciones propias para quitarle el fondo a los label y el boton, para asi coincidir con la imagen de fondo, y activo el reproductor de musica.
        /// 
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <param name="vendedor"></param>
        public FormLogin(Usuario cliente1, Usuario cliente2, Usuario vendedor, List<Producto> listaProductos) : this()
        {
            this.cliente1 = cliente1;
            this.cliente2 = cliente2;
            this.vendedor = vendedor;

            this.listaProductos = listaProductos;

            configFondolbl(lblUsuario);
            configFondolbl(lblClave);
            configFondolbl(lblTipoUsuario);
            configFondolbl(lblOlvidoDeContraseña);
            configFondoButton(botonIniciarSesion);
            configFondoLogo(pbLogo);

            player = new System.Media.SoundPlayer();
            player.SoundLocation = "cancion.wav";
            player.PlayLooping();

        }

        #endregion

        #region "BotonesInicioSesion"

        /// <summary> 
        /// Verifica los textbox de datos con los datos precargados de usuarios. Si coinciden con los datos del Vendedor, abre el form de Menu de Vendedor. En caso de ser los datos de alguno de los clientes, abre el form de Compra.
        /// Al cerrarse, ya sea el form del Menu de Vendedor o el de Compra, se hace llamado a una funcion para restablecer todo los parametros del form Login.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == vendedor.EMailUsuario && txtClave.Text == vendedor.ClaveUsuario)
            {
                player.Stop();

                MessageBox.Show(vendedor.MensajeLogin());

                FormMenuVendedor formMenuVendedor = new FormMenuVendedor((Vendedor)vendedor, listaProductos);

                this.Hide();

                if (formMenuVendedor.ShowDialog() == DialogResult.Cancel)
                {
                    formMenuVendedor.Dispose();
                    restablecerParametros();
                    this.Show();
                }
            }
            else if (txtUsuario.Text == cliente1.EMailUsuario && txtClave.Text == cliente1.ClaveUsuario || txtUsuario.Text == cliente2.EMailUsuario && txtClave.Text == cliente2.ClaveUsuario)
            {
                player.Stop();

                FormDineroCliente formCliente;

                if (txtUsuario.Text == cliente1.EMailUsuario)
                {
                    MessageBox.Show(cliente1.MensajeLogin());
                    formCliente = new FormDineroCliente((Cliente)cliente1, listaProductos);
                }
                else
                {
                    MessageBox.Show(cliente2.MensajeLogin());
                    formCliente = new FormDineroCliente((Cliente)cliente2, listaProductos);
                }

                this.Hide();

                if (formCliente.ShowDialog() == DialogResult.Cancel)
                {
                    formCliente.Dispose();
                    restablecerParametros();
                    this.Show();
                }
            }
            else if (txtUsuario.Text == string.Empty || txtClave.Text == string.Empty)
                MessageBox.Show("Los campos no pueden estar vacios. Reintente.");
            else
                MessageBox.Show("Usuario o contraseña no valido/a. Reintente.");
        }

        /// <summary> 
        /// Restablece todos los campos de datos para dejarlos vacios, para asi poder volver a utilizarlos.
        /// 
        /// </summary>
        private void restablecerParametros()
        {
            this.Show();

            txtUsuario.Text = String.Empty;
            txtClave.Text = String.Empty;
            cboTiposUsuario.Text = String.Empty;

            player.PlayLooping();
            pbMusicaOff.Visible = false;
            pbMusicaOn.Visible = true;

            cboTiposUsuario.SelectedIndex = -1;
        }

        /// <summary>
        /// Compara la opcion elegida en la combobox con los roles de los usuarios, y segun cual sea autocompletara los datos de inicio de sesion de ese usuario.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboTiposUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTiposUsuario.Text == vendedor.RolUsuario)
            {
                txtUsuario.Text = vendedor.EMailUsuario;
                txtClave.Text = vendedor.ClaveUsuario;
            }
            else if (cboTiposUsuario.Text == cliente1.RolUsuario)
            {
                txtUsuario.Text = cliente1.EMailUsuario;
                txtClave.Text = cliente1.ClaveUsuario;
            }
            else if (cboTiposUsuario.Text == cliente2.RolUsuario)
            {
                txtUsuario.Text = cliente2.EMailUsuario;
                txtClave.Text = cliente2.ClaveUsuario;
            }
        }

        /// <summary>
        /// Imprime un mensaje al apretar la opcion de olvido de contraseña.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOlvidoDeContraseña_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias, vuelva prontos");
        }

        #endregion

        #region "BotonesMusica"

        /// <summary>
        /// Prende la musica del form.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMusicaOff_Click(object sender, EventArgs e)
        {
            pbMusicaOff.Visible = false;
            pbMusicaOn.Visible = true;
            player.PlayLooping();
        }

        /// <summary>
        /// Apaga la musica del form.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMusicaOn_Click(object sender, EventArgs e)
        {
            pbMusicaOn.Visible = false;
            pbMusicaOff.Visible = true;
            player.Stop();
        }

        #endregion

        #region "Configs del fondo"

        /// <summary>
        /// Une la imagen y el logo para que asi coincidan en el color de fondo.
        /// 
        /// </summary>
        /// <param name="label"></param>
        private void configFondoLogo(System.Windows.Forms.PictureBox logo)
        {
            var pos = this.PointToScreen(logo.Location);
            pos = pbFondo.PointToClient(pos);
            logo.Parent = pbFondo;
            logo.Location = pos;
            logo.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Une la imagen y el label para que asi coincidan en el color de fondo.
        /// 
        /// </summary>
        /// <param name="label"></param>
        private void configFondolbl(System.Windows.Forms.Label label)
        {
            var pos = this.PointToScreen(label.Location);
            pos = pbFondo.PointToClient(pos);
            label.Parent = pbFondo;
            label.Location = pos;
            label.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Une la imagen y el boton para que asi coincidan en el color de fondo.
        /// 
        /// </summary>
        /// <param name="boton"></param>
        private void configFondoButton(Button boton)
        {
            var pos = this.PointToScreen(boton.Location);
            pos = pbFondo.PointToClient(pos);
            boton.Parent = pbFondo;
            boton.Location = pos;
            boton.BackColor = Color.Transparent;
        }

        #endregion
    }
}
