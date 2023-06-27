namespace Parcial_Forms
{
    partial class FormFactura
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
            pbFactura = new System.Windows.Forms.PictureBox();
            lblVenta = new System.Windows.Forms.Label();
            txtFecha = new System.Windows.Forms.TextBox();
            txtNroVenta = new System.Windows.Forms.TextBox();
            dgvProductos = new System.Windows.Forms.DataGridView();
            Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtCliente = new System.Windows.Forms.TextBox();
            txtMetodoPago = new System.Windows.Forms.TextBox();
            txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)pbFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // pbFactura
            // 
            pbFactura.Image = Properties.Resources.factura;
            pbFactura.Location = new System.Drawing.Point(1, 1);
            pbFactura.Name = "pbFactura";
            pbFactura.Size = new System.Drawing.Size(578, 790);
            pbFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbFactura.TabIndex = 0;
            pbFactura.TabStop = false;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Location = new System.Drawing.Point(392, 48);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new System.Drawing.Size(59, 15);
            lblVenta.TabIndex = 7;
            lblVenta.Text = "Venta Nro";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = System.Drawing.Color.WhiteSmoke;
            txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFecha.Location = new System.Drawing.Point(392, 72);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new System.Drawing.Size(140, 16);
            txtFecha.TabIndex = 6;
            // 
            // txtNroVenta
            // 
            txtNroVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            txtNroVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtNroVenta.Location = new System.Drawing.Point(457, 48);
            txtNroVenta.Name = "txtNroVenta";
            txtNroVenta.ReadOnly = true;
            txtNroVenta.Size = new System.Drawing.Size(47, 16);
            txtNroVenta.TabIndex = 5;
            txtNroVenta.TabStop = false;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.ColumnHeadersVisible = false;
            dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Producto, cantidad, Precio, Total });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new System.Drawing.Point(44, 276);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new System.Drawing.Size(491, 315);
            dgvProductos.TabIndex = 8;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Producto.FillWeight = 330F;
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cantidad
            // 
            cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            cantidad.FillWeight = 95F;
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Precio.FillWeight = 95F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Total
            // 
            Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Total.FillWeight = 105F;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtCliente
            // 
            txtCliente.BackColor = System.Drawing.SystemColors.Control;
            txtCliente.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            txtCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            txtCliente.Location = new System.Drawing.Point(120, 166);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new System.Drawing.Size(116, 24);
            txtCliente.TabIndex = 9;
            // 
            // txtMetodoPago
            // 
            txtMetodoPago.BackColor = System.Drawing.SystemColors.Control;
            txtMetodoPago.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            txtMetodoPago.ForeColor = System.Drawing.SystemColors.Highlight;
            txtMetodoPago.Location = new System.Drawing.Point(44, 655);
            txtMetodoPago.Name = "txtMetodoPago";
            txtMetodoPago.ReadOnly = true;
            txtMetodoPago.Size = new System.Drawing.Size(159, 24);
            txtMetodoPago.TabIndex = 10;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = System.Drawing.SystemColors.Control;
            txtTotal.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            txtTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            txtTotal.Location = new System.Drawing.Point(417, 637);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new System.Drawing.Size(115, 24);
            txtTotal.TabIndex = 11;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(577, 787);
            Controls.Add(txtTotal);
            Controls.Add(txtMetodoPago);
            Controls.Add(txtCliente);
            Controls.Add(dgvProductos);
            Controls.Add(lblVenta);
            Controls.Add(txtFecha);
            Controls.Add(txtNroVenta);
            Controls.Add(pbFactura);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "FormFactura";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormFactura";
            ((System.ComponentModel.ISupportInitialize)pbFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbFactura;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNroVenta;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.TextBox txtTotal;
    }
}