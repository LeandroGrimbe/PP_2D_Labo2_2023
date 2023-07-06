namespace Parcial_Forms
{
    partial class FormMenuVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblVolver = new System.Windows.Forms.Label();
            pbVolver = new System.Windows.Forms.PictureBox();
            lblMensajeOpcion = new System.Windows.Forms.Label();
            lblNombreVendedor = new System.Windows.Forms.Label();
            lblSaludo = new System.Windows.Forms.Label();
            pbVentas = new System.Windows.Forms.PictureBox();
            pbLogo = new System.Windows.Forms.PictureBox();
            pbInventario = new System.Windows.Forms.PictureBox();
            botonVentas = new System.Windows.Forms.Button();
            botonInventario = new System.Windows.Forms.Button();
            pTimer = new System.Windows.Forms.Panel();
            rtbSegundos = new System.Windows.Forms.RichTextBox();
            rtbMinutos = new System.Windows.Forms.RichTextBox();
            rtbHoras = new System.Windows.Forms.RichTextBox();
            lblTimer = new System.Windows.Forms.Label();
            timerTiempoSesion = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInventario).BeginInit();
            pTimer.SuspendLayout();
            SuspendLayout();
            // 
            // lblVolver
            // 
            lblVolver.AutoSize = true;
            lblVolver.BackColor = System.Drawing.Color.Gainsboro;
            lblVolver.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            lblVolver.Location = new System.Drawing.Point(131, 4);
            lblVolver.Name = "lblVolver";
            lblVolver.Size = new System.Drawing.Size(48, 18);
            lblVolver.TabIndex = 17;
            lblVolver.Text = "Volver";
            // 
            // pbVolver
            // 
            pbVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            pbVolver.Image = Properties.Resources.Icono_volver;
            pbVolver.Location = new System.Drawing.Point(108, 3);
            pbVolver.Name = "pbVolver";
            pbVolver.Size = new System.Drawing.Size(19, 19);
            pbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbVolver.TabIndex = 16;
            pbVolver.TabStop = false;
            pbVolver.Click += pbVolver_Click;
            // 
            // lblMensajeOpcion
            // 
            lblMensajeOpcion.AutoSize = true;
            lblMensajeOpcion.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMensajeOpcion.Location = new System.Drawing.Point(95, 173);
            lblMensajeOpcion.Name = "lblMensajeOpcion";
            lblMensajeOpcion.Size = new System.Drawing.Size(327, 15);
            lblMensajeOpcion.TabIndex = 13;
            lblMensajeOpcion.Text = "Seleccione la accion que desea realizar:";
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.BackColor = System.Drawing.Color.Transparent;
            lblNombreVendedor.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombreVendedor.Location = new System.Drawing.Point(179, 99);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new System.Drawing.Size(178, 23);
            lblNombreVendedor.TabIndex = 12;
            lblNombreVendedor.Text = "nombreVendedor";
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = System.Drawing.Color.Transparent;
            lblSaludo.Font = new System.Drawing.Font("Unispace", 23.9999962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSaludo.Location = new System.Drawing.Point(150, 60);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new System.Drawing.Size(237, 39);
            lblSaludo.TabIndex = 11;
            lblSaludo.Text = "Bienvenido!";
            // 
            // pbVentas
            // 
            pbVentas.Image = Properties.Resources.Icono_ventas;
            pbVentas.Location = new System.Drawing.Point(55, 206);
            pbVentas.Name = "pbVentas";
            pbVentas.Size = new System.Drawing.Size(61, 65);
            pbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbVentas.TabIndex = 10;
            pbVentas.TabStop = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo_carniceria;
            pbLogo.Location = new System.Drawing.Point(2, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(100, 96);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 9;
            pbLogo.TabStop = false;
            // 
            // pbInventario
            // 
            pbInventario.Image = Properties.Resources.icono_stock;
            pbInventario.Location = new System.Drawing.Point(55, 281);
            pbInventario.Name = "pbInventario";
            pbInventario.Size = new System.Drawing.Size(61, 65);
            pbInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbInventario.TabIndex = 18;
            pbInventario.TabStop = false;
            // 
            // botonVentas
            // 
            botonVentas.BackColor = System.Drawing.Color.Beige;
            botonVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            botonVentas.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonVentas.ForeColor = System.Drawing.SystemColors.ControlText;
            botonVentas.Location = new System.Drawing.Point(126, 214);
            botonVentas.Name = "botonVentas";
            botonVentas.Size = new System.Drawing.Size(356, 52);
            botonVentas.TabIndex = 20;
            botonVentas.TabStop = false;
            botonVentas.Text = "Administrar Ventas";
            botonVentas.UseVisualStyleBackColor = false;
            botonVentas.Click += botonVentas_Click;
            // 
            // botonInventario
            // 
            botonInventario.BackColor = System.Drawing.Color.Beige;
            botonInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            botonInventario.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonInventario.Location = new System.Drawing.Point(126, 286);
            botonInventario.Name = "botonInventario";
            botonInventario.Size = new System.Drawing.Size(356, 52);
            botonInventario.TabIndex = 21;
            botonInventario.TabStop = false;
            botonInventario.Text = "Administrar Inventario";
            botonInventario.UseVisualStyleBackColor = false;
            botonInventario.Click += botonInventario_Click;
            // 
            // pTimer
            // 
            pTimer.BackColor = System.Drawing.Color.White;
            pTimer.Controls.Add(rtbSegundos);
            pTimer.Controls.Add(rtbMinutos);
            pTimer.Controls.Add(rtbHoras);
            pTimer.Controls.Add(lblTimer);
            pTimer.Location = new System.Drawing.Point(418, -1);
            pTimer.Name = "pTimer";
            pTimer.Size = new System.Drawing.Size(120, 53);
            pTimer.TabIndex = 88;
            // 
            // rtbSegundos
            // 
            rtbSegundos.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rtbSegundos.Location = new System.Drawing.Point(82, 18);
            rtbSegundos.Name = "rtbSegundos";
            rtbSegundos.ReadOnly = true;
            rtbSegundos.Size = new System.Drawing.Size(39, 35);
            rtbSegundos.TabIndex = 90;
            rtbSegundos.Text = "";
            // 
            // rtbMinutos
            // 
            rtbMinutos.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rtbMinutos.Location = new System.Drawing.Point(41, 18);
            rtbMinutos.Name = "rtbMinutos";
            rtbMinutos.ReadOnly = true;
            rtbMinutos.Size = new System.Drawing.Size(39, 35);
            rtbMinutos.TabIndex = 89;
            rtbMinutos.Text = "";
            // 
            // rtbHoras
            // 
            rtbHoras.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rtbHoras.Location = new System.Drawing.Point(0, 18);
            rtbHoras.Name = "rtbHoras";
            rtbHoras.ReadOnly = true;
            rtbHoras.Size = new System.Drawing.Size(39, 35);
            rtbHoras.TabIndex = 88;
            rtbHoras.Text = "";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblTimer.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTimer.ForeColor = System.Drawing.Color.Cornsilk;
            lblTimer.Location = new System.Drawing.Point(0, -4);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new System.Drawing.Size(121, 23);
            lblTimer.TabIndex = 88;
            lblTimer.Text = "Tiempo en sesion";
            // 
            // timerTiempoSesion
            // 
            timerTiempoSesion.Enabled = true;
            timerTiempoSesion.Interval = 1000;
            timerTiempoSesion.Tick += timerTiempoSesion_Tick;
            // 
            // FormMenuVendedor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Honeydew;
            ClientSize = new System.Drawing.Size(536, 363);
            Controls.Add(pTimer);
            Controls.Add(botonVentas);
            Controls.Add(botonInventario);
            Controls.Add(pbInventario);
            Controls.Add(lblVolver);
            Controls.Add(pbVolver);
            Controls.Add(lblMensajeOpcion);
            Controls.Add(lblNombreVendedor);
            Controls.Add(lblSaludo);
            Controls.Add(pbVentas);
            Controls.Add(pbLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "FormMenuVendedor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormMenuVendedor";
            FormClosing += FormMenuVendedor_Closing;
            Load += FormMenuVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)pbVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInventario).EndInit();
            pTimer.ResumeLayout(false);
            pTimer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.PictureBox pbVolver;
        private System.Windows.Forms.Label lblMensajeOpcion;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.PictureBox pbVentas;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbInventario;
        private System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.Button botonInventario;
        private System.Windows.Forms.Panel pTimer;
        private System.Windows.Forms.RichTextBox rtbSegundos;
        private System.Windows.Forms.RichTextBox rtbMinutos;
        private System.Windows.Forms.RichTextBox rtbHoras;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timerTiempoSesion;
    }
}