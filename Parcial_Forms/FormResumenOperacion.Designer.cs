namespace Parcial_Forms
{
    partial class FormResumenOperacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            pbLogo = new System.Windows.Forms.PictureBox();
            lblProductosVenta = new System.Windows.Forms.Label();
            dgvProductosVenta = new System.Windows.Forms.DataGridView();
            NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtSaldoCliente = new System.Windows.Forms.TextBox();
            lblSaldoCliente = new System.Windows.Forms.Label();
            botonCancelar = new System.Windows.Forms.Button();
            botonConfirmar = new System.Windows.Forms.Button();
            txtTotal = new System.Windows.Forms.TextBox();
            txtSubtotal = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            lblSubtotal = new System.Windows.Forms.Label();
            cbMetodoPago = new System.Windows.Forms.ComboBox();
            lblMetodoPago = new System.Windows.Forms.Label();
            lblNombreCliente = new System.Windows.Forms.Label();
            lblDatosVenta = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            cbClientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosVenta).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo_carniceria;
            pbLogo.Location = new System.Drawing.Point(3, 2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(100, 96);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lblProductosVenta
            // 
            lblProductosVenta.AutoSize = true;
            lblProductosVenta.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProductosVenta.Location = new System.Drawing.Point(726, 157);
            lblProductosVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProductosVenta.Name = "lblProductosVenta";
            lblProductosVenta.Size = new System.Drawing.Size(207, 22);
            lblProductosVenta.TabIndex = 46;
            lblProductosVenta.Text = "Productos del pedido";
            // 
            // dgvProductosVenta
            // 
            dgvProductosVenta.AllowUserToAddRows = false;
            dgvProductosVenta.AllowUserToDeleteRows = false;
            dgvProductosVenta.AllowUserToResizeColumns = false;
            dgvProductosVenta.AllowUserToResizeRows = false;
            dgvProductosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductosVenta.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvProductosVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvProductosVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dgvProductosVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvProductosVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { NombreProducto, Cantidad, PrecioProducto, PrecioTotal });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvProductosVenta.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductosVenta.EnableHeadersVisualStyles = false;
            dgvProductosVenta.Location = new System.Drawing.Point(575, 193);
            dgvProductosVenta.Name = "dgvProductosVenta";
            dgvProductosVenta.ReadOnly = true;
            dgvProductosVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dgvProductosVenta.RowHeadersVisible = false;
            dgvProductosVenta.RowHeadersWidth = 50;
            dgvProductosVenta.RowTemplate.Height = 25;
            dgvProductosVenta.ShowCellErrors = false;
            dgvProductosVenta.ShowCellToolTips = false;
            dgvProductosVenta.ShowEditingIcon = false;
            dgvProductosVenta.Size = new System.Drawing.Size(505, 374);
            dgvProductosVenta.TabIndex = 45;
            // 
            // NombreProducto
            // 
            NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            NombreProducto.HeaderText = "Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.FillWeight = 86.29829F;
            Cantidad.HeaderText = "Cantidad (KG)";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PrecioProducto
            // 
            PrecioProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            PrecioProducto.FillWeight = 86.29829F;
            PrecioProducto.HeaderText = "Precio (x KG)";
            PrecioProducto.Name = "PrecioProducto";
            PrecioProducto.ReadOnly = true;
            PrecioProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PrecioTotal
            // 
            PrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            PrecioTotal.HeaderText = "Total";
            PrecioTotal.Name = "PrecioTotal";
            PrecioTotal.ReadOnly = true;
            PrecioTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtSaldoCliente
            // 
            txtSaldoCliente.BackColor = System.Drawing.SystemColors.Control;
            txtSaldoCliente.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSaldoCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            txtSaldoCliente.Location = new System.Drawing.Point(139, 267);
            txtSaldoCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSaldoCliente.Name = "txtSaldoCliente";
            txtSaldoCliente.ReadOnly = true;
            txtSaldoCliente.Size = new System.Drawing.Size(319, 28);
            txtSaldoCliente.TabIndex = 44;
            // 
            // lblSaldoCliente
            // 
            lblSaldoCliente.AutoSize = true;
            lblSaldoCliente.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSaldoCliente.Location = new System.Drawing.Point(126, 243);
            lblSaldoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSaldoCliente.Name = "lblSaldoCliente";
            lblSaldoCliente.Size = new System.Drawing.Size(165, 22);
            lblSaldoCliente.TabIndex = 43;
            lblSaldoCliente.Text = "Saldo Disponible";
            // 
            // botonCancelar
            // 
            botonCancelar.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            botonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            botonCancelar.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonCancelar.Location = new System.Drawing.Point(575, 697);
            botonCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new System.Drawing.Size(215, 48);
            botonCancelar.TabIndex = 42;
            botonCancelar.Text = "Cancelar Compra";
            botonCancelar.UseVisualStyleBackColor = false;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // botonConfirmar
            // 
            botonConfirmar.BackColor = System.Drawing.Color.Chartreuse;
            botonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            botonConfirmar.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonConfirmar.Location = new System.Drawing.Point(290, 697);
            botonConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            botonConfirmar.Name = "botonConfirmar";
            botonConfirmar.Size = new System.Drawing.Size(215, 48);
            botonConfirmar.TabIndex = 41;
            botonConfirmar.Text = "Confirmar Compra";
            botonConfirmar.UseVisualStyleBackColor = false;
            botonConfirmar.Click += botonConfirmar_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = System.Drawing.SystemColors.Control;
            txtTotal.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            txtTotal.Location = new System.Drawing.Point(138, 628);
            txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new System.Drawing.Size(320, 28);
            txtTotal.TabIndex = 40;
            // 
            // txtSubtotal
            // 
            txtSubtotal.BackColor = System.Drawing.SystemColors.Control;
            txtSubtotal.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSubtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            txtSubtotal.Location = new System.Drawing.Point(138, 351);
            txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(320, 28);
            txtSubtotal.TabIndex = 39;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTotal.Location = new System.Drawing.Point(126, 603);
            lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(59, 22);
            lblTotal.TabIndex = 38;
            lblTotal.Text = "Total";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSubtotal.Location = new System.Drawing.Point(126, 327);
            lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new System.Drawing.Size(86, 22);
            lblSubtotal.TabIndex = 37;
            lblSubtotal.Text = "Subtotal";
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbMetodoPago.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Tarjeta de Credito (5% recargo)", "Tarjeta de Debito", "Efectivo" });
            cbMetodoPago.Location = new System.Drawing.Point(138, 434);
            cbMetodoPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new System.Drawing.Size(320, 31);
            cbMetodoPago.TabIndex = 36;
            cbMetodoPago.SelectedIndexChanged += cbMetodoPago_SelectedIndexChanged;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMetodoPago.Location = new System.Drawing.Point(126, 410);
            lblMetodoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new System.Drawing.Size(157, 22);
            lblMetodoPago.TabIndex = 35;
            lblMetodoPago.Text = "Metodo de Pago";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombreCliente.Location = new System.Drawing.Point(126, 158);
            lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new System.Drawing.Size(180, 22);
            lblNombreCliente.TabIndex = 29;
            lblNombreCliente.Text = "Nombre Completo";
            // 
            // lblDatosVenta
            // 
            lblDatosVenta.AutoSize = true;
            lblDatosVenta.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDatosVenta.Location = new System.Drawing.Point(113, 107);
            lblDatosVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDatosVenta.Name = "lblDatosVenta";
            lblDatosVenta.Size = new System.Drawing.Size(187, 23);
            lblDatosVenta.TabIndex = 28;
            lblDatosVenta.Text = "Datos de compra:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Unispace", 20.2499981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(406, 32);
            lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(255, 33);
            lblTitulo.TabIndex = 47;
            lblTitulo.Text = "Orden de Compra";
            // 
            // cbClientes
            // 
            cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbClientes.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new System.Drawing.Point(138, 193);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new System.Drawing.Size(320, 31);
            cbClientes.TabIndex = 48;
            // 
            // FormResumenOperacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FloralWhite;
            ClientSize = new System.Drawing.Size(1131, 772);
            Controls.Add(cbClientes);
            Controls.Add(lblTitulo);
            Controls.Add(lblProductosVenta);
            Controls.Add(dgvProductosVenta);
            Controls.Add(txtSaldoCliente);
            Controls.Add(lblSaldoCliente);
            Controls.Add(botonCancelar);
            Controls.Add(botonConfirmar);
            Controls.Add(txtTotal);
            Controls.Add(txtSubtotal);
            Controls.Add(lblTotal);
            Controls.Add(lblSubtotal);
            Controls.Add(cbMetodoPago);
            Controls.Add(lblMetodoPago);
            Controls.Add(lblNombreCliente);
            Controls.Add(lblDatosVenta);
            Controls.Add(pbLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "FormResumenOperacion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormResumenOperacion";
            FormClosing += FormResumenOperacion_Closing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblProductosVenta;
        private System.Windows.Forms.DataGridView dgvProductosVenta;
        private System.Windows.Forms.TextBox txtSaldoCliente;
        private System.Windows.Forms.Label lblSaldoCliente;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblDatosVenta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
    }
}