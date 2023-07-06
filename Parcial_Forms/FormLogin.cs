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
        private List<Producto> listaProductos;

        private System.Media.SoundPlayer player;

        #region Constructores

        public FormLogin()
        {
            InitializeComponent();
            this.listaProductos = new List<Producto>();
        }

        /// <summary>
        /// Utilizo hilos para cargar todas las cosas del forms mas rapidamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Task t1 = new Task(CargaLista);
            t1.Start();

            Vendedor.numeroOperacion = 0;
            RegistroVentas.historialVentas = "";

            ParametrosIniciales();
        }

        #endregion

        #region Otras Funciones

        /// <summary>
        /// Traigo los productos cargados en la base de datos, y los agrego a la lista. Ademas, le asigno a cada producto un evento de control de stock.
        /// </summary>
        private void CargaLista()
        {
            ProductoDAO controlProductos = new ProductoDAO();
            try
            {
                controlProductos.TraerDatosBDD(this.listaProductos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (Producto p in listaProductos)
            {
                p.EventoSinStock += AvisoStock;
            }
        }

        /// <summary>
        /// Utilizo funciones propias para quitarle el fondo a los label y el boton, para asi coincidir con la imagen de fondo, y activo el reproductor de musica.
        /// </summary>
        private void ParametrosIniciales()
        {
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
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
                MessageBox.Show("Los campos no pueden estar vacios. Reintente.");
            else if (!txtUsuario.Text.ComprobarFormatoEmail())
                MessageBox.Show("Formato de email invalido. Reintente.");
            else
            {
                string mail = txtUsuario.Text;
                string clave = txtClave.Text;
                int tipoUsuario = 0;

                player.Stop();

                try
                {
                    Usuario usuario = UsuarioDAO.BuscarUsuarioBDD(ref tipoUsuario, mail, clave);

                    switch (tipoUsuario)
                    {
                        case 1:
                            MessageBox.Show(usuario.MensajeLogin());

                            FormMenuVendedor formMenuVendedor = new FormMenuVendedor((Vendedor)usuario, listaProductos);

                            this.Hide();

                            if (formMenuVendedor.ShowDialog() == DialogResult.Cancel)
                            {
                                formMenuVendedor.Dispose();
                                restablecerParametros();
                                this.Show();
                            }
                            break;

                        case 2:
                            MessageBox.Show(usuario.MensajeLogin());

                            FormDineroCliente formCliente = new FormDineroCliente((Cliente)usuario, listaProductos);

                            this.Hide();

                            if (formCliente.ShowDialog() == DialogResult.Cancel)
                            {
                                formCliente.Dispose();
                                restablecerParametros();
                                this.Show();
                            }
                            break;

                        case 3:
                            MessageBox.Show(usuario.MensajeLogin());

                            FormProgramador formProgramador = new FormProgramador((Programador)usuario, listaProductos);

                            this.Hide();

                            if (formProgramador.ShowDialog() == DialogResult.Cancel)
                            {
                                formProgramador.Dispose();
                                restablecerParametros();
                                this.Show();
                            }
                            break;

                        default:
                            throw new CuentaNoEncontradaException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    restablecerParametros();
                }
            }
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
            string mail = "";
            string clave = "";
            int idUsuario = cboTiposUsuario.SelectedIndex + 1;

            try
            {
                UsuarioDAO.AutoCompletarDatosBDD(idUsuario, ref mail, ref clave);
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }

            txtUsuario.Text = mail;
            txtClave.Text = clave;
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

        private static void AvisoStock(string mensaje)
        {
            MessageBox.Show(mensaje);
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
