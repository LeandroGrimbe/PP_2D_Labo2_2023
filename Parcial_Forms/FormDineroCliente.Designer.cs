namespace Parcial_Forms
{
    partial class FormDineroCliente
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
            pbLogo = new System.Windows.Forms.PictureBox();
            lblSaludo = new System.Windows.Forms.Label();
            lblNombreCliente = new System.Windows.Forms.Label();
            lblMensajeDinero = new System.Windows.Forms.Label();
            pbDinero = new System.Windows.Forms.PictureBox();
            txtDinero = new System.Windows.Forms.TextBox();
            botonDinero = new System.Windows.Forms.Button();
            pbVolver = new System.Windows.Forms.PictureBox();
            lblVolver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDinero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVolver).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo_carniceria;
            pbLogo.Location = new System.Drawing.Point(0, 1);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(100, 96);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = System.Drawing.Color.Transparent;
            lblSaludo.Font = new System.Drawing.Font("Unispace", 23.9999962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSaludo.Location = new System.Drawing.Point(148, 58);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new System.Drawing.Size(237, 39);
            lblSaludo.TabIndex = 2;
            lblSaludo.Text = "Bienvenido!";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            lblNombreCliente.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombreCliente.Location = new System.Drawing.Point(177, 97);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new System.Drawing.Size(166, 23);
            lblNombreCliente.TabIndex = 3;
            lblNombreCliente.Text = "nombreCliente";
            // 
            // lblMensajeDinero
            // 
            lblMensajeDinero.AutoSize = true;
            lblMensajeDinero.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMensajeDinero.Location = new System.Drawing.Point(89, 190);
            lblMensajeDinero.Name = "lblMensajeDinero";
            lblMensajeDinero.Size = new System.Drawing.Size(343, 15);
            lblMensajeDinero.TabIndex = 4;
            lblMensajeDinero.Text = "Ingrese el monto maximo que desea gastar: ";
            // 
            // pbDinero
            // 
            pbDinero.Image = Properties.Resources.logo_dinero;
            pbDinero.Location = new System.Drawing.Point(134, 218);
            pbDinero.Name = "pbDinero";
            pbDinero.Size = new System.Drawing.Size(61, 65);
            pbDinero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbDinero.TabIndex = 1;
            pbDinero.TabStop = false;
            // 
            // txtDinero
            // 
            txtDinero.BackColor = System.Drawing.SystemColors.ActiveBorder;
            txtDinero.ForeColor = System.Drawing.SystemColors.MenuText;
            txtDinero.Location = new System.Drawing.Point(214, 244);
            txtDinero.Name = "txtDinero";
            txtDinero.Size = new System.Drawing.Size(161, 23);
            txtDinero.TabIndex = 5;
            // 
            // botonDinero
            // 
            botonDinero.BackColor = System.Drawing.Color.White;
            botonDinero.Cursor = System.Windows.Forms.Cursors.Hand;
            botonDinero.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonDinero.Location = new System.Drawing.Point(214, 285);
            botonDinero.Name = "botonDinero";
            botonDinero.Size = new System.Drawing.Size(91, 31);
            botonDinero.TabIndex = 6;
            botonDinero.Text = "Continuar";
            botonDinero.UseVisualStyleBackColor = false;
            botonDinero.Click += botonDinero_Click;
            // 
            // pbVolver
            // 
            pbVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            pbVolver.Image = Properties.Resources.Icono_volver;
            pbVolver.Location = new System.Drawing.Point(442, 8);
            pbVolver.Name = "pbVolver";
            pbVolver.Size = new System.Drawing.Size(19, 19);
            pbVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbVolver.TabIndex = 7;
            pbVolver.TabStop = false;
            pbVolver.Click += pbVolver_Click;
            // 
            // lblVolver
            // 
            lblVolver.AutoSize = true;
            lblVolver.BackColor = System.Drawing.Color.Gainsboro;
            lblVolver.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            lblVolver.Location = new System.Drawing.Point(465, 9);
            lblVolver.Name = "lblVolver";
            lblVolver.Size = new System.Drawing.Size(48, 18);
            lblVolver.TabIndex = 8;
            lblVolver.Text = "Volver";
            // 
            // FormDineroCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Cornsilk;
            ClientSize = new System.Drawing.Size(516, 328);
            Controls.Add(lblVolver);
            Controls.Add(pbVolver);
            Controls.Add(botonDinero);
            Controls.Add(txtDinero);
            Controls.Add(lblMensajeDinero);
            Controls.Add(lblNombreCliente);
            Controls.Add(lblSaludo);
            Controls.Add(pbDinero);
            Controls.Add(pbLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "FormDineroCliente";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Carniceria Carlitos";
            FormClosing += FormDineroCliente_Closing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDinero).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVolver).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblMensajeDinero;
        private System.Windows.Forms.PictureBox pbDinero;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Button botonDinero;
        private System.Windows.Forms.PictureBox pbVolver;
        private System.Windows.Forms.Label lblVolver;
    }
}