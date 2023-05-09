namespace Parcial_Forms
{
    partial class FormHistorial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            pbBotonVolverMenu = new System.Windows.Forms.PictureBox();
            lblVolverMenu = new System.Windows.Forms.Label();
            lblTituloHistorial = new System.Windows.Forms.Label();
            pbLogo = new System.Windows.Forms.PictureBox();
            pUsuario = new System.Windows.Forms.Panel();
            pbLogoUsuario = new System.Windows.Forms.PictureBox();
            lblNombreVendedor = new System.Windows.Forms.Label();
            lblCerrarSesion = new System.Windows.Forms.Label();
            dgvListaOperaciones = new System.Windows.Forms.DataGridView();
            Comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbBotonVolverMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaOperaciones).BeginInit();
            SuspendLayout();
            // 
            // pbBotonVolverMenu
            // 
            pbBotonVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            pbBotonVolverMenu.Image = Properties.Resources.Icono_volver;
            pbBotonVolverMenu.Location = new System.Drawing.Point(111, 7);
            pbBotonVolverMenu.Name = "pbBotonVolverMenu";
            pbBotonVolverMenu.Size = new System.Drawing.Size(28, 27);
            pbBotonVolverMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbBotonVolverMenu.TabIndex = 94;
            pbBotonVolverMenu.TabStop = false;
            pbBotonVolverMenu.Click += pbBotonVolverMenu_Click;
            // 
            // lblVolverMenu
            // 
            lblVolverMenu.AutoSize = true;
            lblVolverMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            lblVolverMenu.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblVolverMenu.Location = new System.Drawing.Point(145, 16);
            lblVolverMenu.Name = "lblVolverMenu";
            lblVolverMenu.Size = new System.Drawing.Size(119, 15);
            lblVolverMenu.TabIndex = 93;
            lblVolverMenu.Text = "Volver al Menu";
            // 
            // lblTituloHistorial
            // 
            lblTituloHistorial.AutoSize = true;
            lblTituloHistorial.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTituloHistorial.Location = new System.Drawing.Point(203, 100);
            lblTituloHistorial.Name = "lblTituloHistorial";
            lblTituloHistorial.Size = new System.Drawing.Size(456, 44);
            lblTituloHistorial.TabIndex = 92;
            lblTituloHistorial.Text = "Historial de Ventas";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo_carniceria;
            pbLogo.Location = new System.Drawing.Point(1, 1);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(100, 96);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 91;
            pbLogo.TabStop = false;
            // 
            // pUsuario
            // 
            pUsuario.BackColor = System.Drawing.Color.Gainsboro;
            pUsuario.Controls.Add(pbLogoUsuario);
            pUsuario.Controls.Add(lblNombreVendedor);
            pUsuario.Location = new System.Drawing.Point(732, -1);
            pUsuario.Name = "pUsuario";
            pUsuario.Size = new System.Drawing.Size(182, 53);
            pUsuario.TabIndex = 96;
            // 
            // pbLogoUsuario
            // 
            pbLogoUsuario.Image = Properties.Resources.Icono_usuario;
            pbLogoUsuario.Location = new System.Drawing.Point(10, 8);
            pbLogoUsuario.Name = "pbLogoUsuario";
            pbLogoUsuario.Size = new System.Drawing.Size(36, 34);
            pbLogoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogoUsuario.TabIndex = 11;
            pbLogoUsuario.TabStop = false;
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombreVendedor.ForeColor = System.Drawing.Color.Black;
            lblNombreVendedor.Location = new System.Drawing.Point(52, 16);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new System.Drawing.Size(77, 19);
            lblNombreVendedor.TabIndex = 9;
            lblNombreVendedor.Text = "Vendedor";
            // 
            // lblCerrarSesion
            // 
            lblCerrarSesion.AutoSize = true;
            lblCerrarSesion.BackColor = System.Drawing.Color.Gainsboro;
            lblCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            lblCerrarSesion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            lblCerrarSesion.Location = new System.Drawing.Point(826, 59);
            lblCerrarSesion.Name = "lblCerrarSesion";
            lblCerrarSesion.Size = new System.Drawing.Size(78, 14);
            lblCerrarSesion.TabIndex = 95;
            lblCerrarSesion.Text = "Cerrar Sesion";
            lblCerrarSesion.Click += lblCerrarSesion_Click;
            // 
            // dgvListaOperaciones
            // 
            dgvListaOperaciones.AllowUserToAddRows = false;
            dgvListaOperaciones.AllowUserToDeleteRows = false;
            dgvListaOperaciones.AllowUserToResizeColumns = false;
            dgvListaOperaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvListaOperaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvListaOperaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaOperaciones.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvListaOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvListaOperaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dgvListaOperaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvListaOperaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvListaOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaOperaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Comprador, Productos });
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvListaOperaciones.DefaultCellStyle = dataGridViewCellStyle8;
            dgvListaOperaciones.EnableHeadersVisualStyles = false;
            dgvListaOperaciones.Location = new System.Drawing.Point(55, 204);
            dgvListaOperaciones.Name = "dgvListaOperaciones";
            dgvListaOperaciones.ReadOnly = true;
            dgvListaOperaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvListaOperaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvListaOperaciones.RowHeadersVisible = false;
            dgvListaOperaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dgvListaOperaciones.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvListaOperaciones.RowTemplate.Height = 35;
            dgvListaOperaciones.RowTemplate.ReadOnly = true;
            dgvListaOperaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgvListaOperaciones.ShowCellErrors = false;
            dgvListaOperaciones.ShowCellToolTips = false;
            dgvListaOperaciones.ShowEditingIcon = false;
            dgvListaOperaciones.ShowRowErrors = false;
            dgvListaOperaciones.Size = new System.Drawing.Size(797, 486);
            dgvListaOperaciones.TabIndex = 97;
            dgvListaOperaciones.TabStop = false;
            // 
            // Comprador
            // 
            Comprador.HeaderText = "Cliente";
            Comprador.Name = "Comprador";
            Comprador.ReadOnly = true;
            // 
            // Productos
            // 
            Productos.HeaderText = "Productos";
            Productos.Name = "Productos";
            Productos.ReadOnly = true;
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Honeydew;
            ClientSize = new System.Drawing.Size(912, 719);
            Controls.Add(dgvListaOperaciones);
            Controls.Add(pUsuario);
            Controls.Add(lblCerrarSesion);
            Controls.Add(pbBotonVolverMenu);
            Controls.Add(lblVolverMenu);
            Controls.Add(lblTituloHistorial);
            Controls.Add(pbLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "FormHistorial";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormHistorial";
            FormClosing += FormHistorial_Closing;
            ((System.ComponentModel.ISupportInitialize)pbBotonVolverMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pUsuario.ResumeLayout(false);
            pUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaOperaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbBotonVolverMenu;
        private System.Windows.Forms.Label lblVolverMenu;
        private System.Windows.Forms.Label lblTituloHistorial;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pUsuario;
        private System.Windows.Forms.PictureBox pbLogoUsuario;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.DataGridView dgvListaOperaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
    }
}