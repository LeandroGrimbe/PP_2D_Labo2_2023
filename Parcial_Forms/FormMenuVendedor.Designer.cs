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
            lblVolver = new System.Windows.Forms.Label();
            pbVolver = new System.Windows.Forms.PictureBox();
            lblMensajeOpcion = new System.Windows.Forms.Label();
            lblNombreVendedor = new System.Windows.Forms.Label();
            lblSaludo = new System.Windows.Forms.Label();
            pbVentas = new System.Windows.Forms.PictureBox();
            pbLogo = new System.Windows.Forms.PictureBox();
            pbInventario = new System.Windows.Forms.PictureBox();
            pbHistorial = new System.Windows.Forms.PictureBox();
            botonHistorial = new System.Windows.Forms.Button();
            botonVentas = new System.Windows.Forms.Button();
            botonInventario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pbVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHistorial).BeginInit();
            SuspendLayout();
            // 
            // lblVolver
            // 
            lblVolver.AutoSize = true;
            lblVolver.BackColor = System.Drawing.Color.Gainsboro;
            lblVolver.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            lblVolver.Location = new System.Drawing.Point(480, 6);
            lblVolver.Name = "lblVolver";
            lblVolver.Size = new System.Drawing.Size(48, 18);
            lblVolver.TabIndex = 17;
            lblVolver.Text = "Volver";
            // 
            // pbVolver
            // 
            pbVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            pbVolver.Image = Properties.Resources.Icono_volver;
            pbVolver.Location = new System.Drawing.Point(457, 5);
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
            // pbHistorial
            // 
            pbHistorial.Image = Properties.Resources.Icono_historial;
            pbHistorial.Location = new System.Drawing.Point(55, 356);
            pbHistorial.Name = "pbHistorial";
            pbHistorial.Size = new System.Drawing.Size(61, 65);
            pbHistorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbHistorial.TabIndex = 19;
            pbHistorial.TabStop = false;
            // 
            // botonHistorial
            // 
            botonHistorial.BackColor = System.Drawing.Color.Beige;
            botonHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            botonHistorial.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonHistorial.Location = new System.Drawing.Point(126, 361);
            botonHistorial.Name = "botonHistorial";
            botonHistorial.Size = new System.Drawing.Size(356, 52);
            botonHistorial.TabIndex = 22;
            botonHistorial.TabStop = false;
            botonHistorial.Text = "Administrar Historial de Ventas";
            botonHistorial.UseVisualStyleBackColor = false;
            botonHistorial.Click += botonHistorial_Click;
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
            // FormMenuVendedor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Honeydew;
            ClientSize = new System.Drawing.Size(534, 438);
            Controls.Add(botonHistorial);
            Controls.Add(botonVentas);
            Controls.Add(botonInventario);
            Controls.Add(pbHistorial);
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
            ((System.ComponentModel.ISupportInitialize)pbVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.PictureBox pbVolver;
        private System.Windows.Forms.Button botonDinero;
        private System.Windows.Forms.Label lblMensajeOpcion;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.PictureBox pbVentas;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbInventario;
        private System.Windows.Forms.PictureBox pbHistorial;
        private System.Windows.Forms.Button botonHistorial;
        private System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.Button botonInventario;
    }
}