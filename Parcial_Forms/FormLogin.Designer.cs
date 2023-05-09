namespace Parcial_Forms
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogo = new System.Windows.Forms.PictureBox();
            pFondo2 = new System.Windows.Forms.Panel();
            txtUsuario = new System.Windows.Forms.TextBox();
            txtClave = new System.Windows.Forms.TextBox();
            lblUsuario = new System.Windows.Forms.Label();
            lblClave = new System.Windows.Forms.Label();
            botonIniciarSesion = new System.Windows.Forms.Button();
            cboTiposUsuario = new System.Windows.Forms.ComboBox();
            lblTipoUsuario = new System.Windows.Forms.Label();
            pbMusicaOn = new System.Windows.Forms.PictureBox();
            pbMusicaOff = new System.Windows.Forms.PictureBox();
            pbFondo = new System.Windows.Forms.PictureBox();
            lblOlvidoDeContraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMusicaOn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMusicaOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFondo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo_carniceria;
            pbLogo.Location = new System.Drawing.Point(73, 24);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(232, 205);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pFondo2
            // 
            pFondo2.BackColor = System.Drawing.SystemColors.ScrollBar;
            pFondo2.Location = new System.Drawing.Point(-3, 579);
            pFondo2.Name = "pFondo2";
            pFondo2.Size = new System.Drawing.Size(397, 35);
            pFondo2.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = System.Drawing.Color.DarkGray;
            txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            txtUsuario.Location = new System.Drawing.Point(34, 278);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtUsuario.Size = new System.Drawing.Size(308, 27);
            txtUsuario.TabIndex = 4;
            // 
            // txtClave
            // 
            txtClave.BackColor = System.Drawing.Color.DarkGray;
            txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtClave.ForeColor = System.Drawing.SystemColors.WindowText;
            txtClave.Location = new System.Drawing.Point(34, 353);
            txtClave.Name = "txtClave";
            txtClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtClave.Size = new System.Drawing.Size(308, 27);
            txtClave.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = System.Drawing.Color.Transparent;
            lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUsuario.ForeColor = System.Drawing.Color.DarkTurquoise;
            lblUsuario.Location = new System.Drawing.Point(30, 255);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(66, 21);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.BackColor = System.Drawing.Color.Transparent;
            lblClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblClave.ForeColor = System.Drawing.Color.DarkTurquoise;
            lblClave.Location = new System.Drawing.Point(29, 329);
            lblClave.Name = "lblClave";
            lblClave.Size = new System.Drawing.Size(103, 21);
            lblClave.TabIndex = 7;
            lblClave.Text = "Contraseña";
            // 
            // botonIniciarSesion
            // 
            botonIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            botonIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            botonIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botonIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonIniciarSesion.ForeColor = System.Drawing.Color.DarkTurquoise;
            botonIniciarSesion.Location = new System.Drawing.Point(34, 481);
            botonIniciarSesion.Name = "botonIniciarSesion";
            botonIniciarSesion.Size = new System.Drawing.Size(308, 45);
            botonIniciarSesion.TabIndex = 8;
            botonIniciarSesion.Text = "Iniciar Sesion";
            botonIniciarSesion.UseVisualStyleBackColor = false;
            botonIniciarSesion.Click += botonIniciarSesion_Click;
            // 
            // cboTiposUsuario
            // 
            cboTiposUsuario.BackColor = System.Drawing.Color.DarkGray;
            cboTiposUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            cboTiposUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTiposUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboTiposUsuario.FormattingEnabled = true;
            cboTiposUsuario.Items.AddRange(new object[] { "Vendedor", "Cliente1", "Cliente2" });
            cboTiposUsuario.Location = new System.Drawing.Point(147, 397);
            cboTiposUsuario.Name = "cboTiposUsuario";
            cboTiposUsuario.Size = new System.Drawing.Size(91, 25);
            cboTiposUsuario.TabIndex = 9;
            cboTiposUsuario.SelectedIndexChanged += cboTiposUsuario_SelectedIndexChanged;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            lblTipoUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTipoUsuario.ForeColor = System.Drawing.Color.DarkTurquoise;
            lblTipoUsuario.Location = new System.Drawing.Point(34, 399);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new System.Drawing.Size(107, 17);
            lblTipoUsuario.TabIndex = 10;
            lblTipoUsuario.Text = "Autocompletar";
            // 
            // pbMusicaOn
            // 
            pbMusicaOn.BackColor = System.Drawing.Color.LightSteelBlue;
            pbMusicaOn.Cursor = System.Windows.Forms.Cursors.Hand;
            pbMusicaOn.Image = Properties.Resources.Icono_musica_prendida;
            pbMusicaOn.Location = new System.Drawing.Point(344, 12);
            pbMusicaOn.Name = "pbMusicaOn";
            pbMusicaOn.Size = new System.Drawing.Size(27, 24);
            pbMusicaOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbMusicaOn.TabIndex = 12;
            pbMusicaOn.TabStop = false;
            pbMusicaOn.Click += pbMusicaOn_Click;
            // 
            // pbMusicaOff
            // 
            pbMusicaOff.BackColor = System.Drawing.Color.LightSteelBlue;
            pbMusicaOff.Cursor = System.Windows.Forms.Cursors.Hand;
            pbMusicaOff.Image = Properties.Resources.Icono_musica_apagada;
            pbMusicaOff.Location = new System.Drawing.Point(344, 12);
            pbMusicaOff.Name = "pbMusicaOff";
            pbMusicaOff.Size = new System.Drawing.Size(27, 24);
            pbMusicaOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbMusicaOff.TabIndex = 13;
            pbMusicaOff.TabStop = false;
            pbMusicaOff.Visible = false;
            pbMusicaOff.Click += pbMusicaOff_Click;
            // 
            // pbFondo
            // 
            pbFondo.Image = Properties.Resources.Fondo_menu_login;
            pbFondo.Location = new System.Drawing.Point(-279, -16);
            pbFondo.Name = "pbFondo";
            pbFondo.Size = new System.Drawing.Size(948, 614);
            pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbFondo.TabIndex = 14;
            pbFondo.TabStop = false;
            // 
            // lblOlvidoDeContraseña
            // 
            lblOlvidoDeContraseña.AutoSize = true;
            lblOlvidoDeContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            lblOlvidoDeContraseña.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblOlvidoDeContraseña.ForeColor = System.Drawing.Color.Coral;
            lblOlvidoDeContraseña.Location = new System.Drawing.Point(120, 536);
            lblOlvidoDeContraseña.Name = "lblOlvidoDeContraseña";
            lblOlvidoDeContraseña.Size = new System.Drawing.Size(137, 16);
            lblOlvidoDeContraseña.TabIndex = 15;
            lblOlvidoDeContraseña.Text = "¿Olvido su contraseña?";
            lblOlvidoDeContraseña.Click += lblOlvidoDeContraseña_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DarkSlateGray;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(383, 592);
            Controls.Add(lblOlvidoDeContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(pbMusicaOn);
            Controls.Add(pbMusicaOff);
            Controls.Add(lblTipoUsuario);
            Controls.Add(cboTiposUsuario);
            Controls.Add(botonIniciarSesion);
            Controls.Add(lblClave);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(pFondo2);
            Controls.Add(pbLogo);
            Controls.Add(pbFondo);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "FormLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "INICIO DE SESION";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMusicaOn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMusicaOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFondo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pFondo2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button botonIniciarSesion;
        private System.Windows.Forms.ComboBox cboTiposUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.PictureBox pbMusicaOn;
        private System.Windows.Forms.PictureBox pbMusicaOff;
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.Label lblOlvidoDeContraseña;
    }
}
