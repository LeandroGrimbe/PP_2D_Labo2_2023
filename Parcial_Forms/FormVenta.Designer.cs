namespace Parcial_Forms
{
    partial class FormVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            pbLogo = new System.Windows.Forms.PictureBox();
            pUsuario = new System.Windows.Forms.Panel();
            pbLogoUsuario = new System.Windows.Forms.PictureBox();
            lblNombreVendedor = new System.Windows.Forms.Label();
            lblCerrarSesion = new System.Windows.Forms.Label();
            cbFiltros = new System.Windows.Forms.ComboBox();
            lblFiltro = new System.Windows.Forms.Label();
            lblProductos = new System.Windows.Forms.Label();
            lblTituloVentas = new System.Windows.Forms.Label();
            dgvListaProductos = new System.Windows.Forms.DataGridView();
            txtSubtotalCarrito = new System.Windows.Forms.TextBox();
            lblSubtotalCarrito = new System.Windows.Forms.Label();
            botonFinalizarVenta = new System.Windows.Forms.Button();
            lblVaciarCarrito = new System.Windows.Forms.Label();
            pbVaciarCarrito = new System.Windows.Forms.PictureBox();
            lblCarrito = new System.Windows.Forms.Label();
            pbCarrito = new System.Windows.Forms.PictureBox();
            dgvCarrito = new System.Windows.Forms.DataGridView();
            NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PrecioPorKilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pbBotonVolverMenu = new System.Windows.Forms.PictureBox();
            lblVolverMenu = new System.Windows.Forms.Label();
            txtPrecioProducto = new System.Windows.Forms.TextBox();
            lblPrecioProducto = new System.Windows.Forms.Label();
            txtCantidadProductoElegido = new System.Windows.Forms.TextBox();
            botonAgregarProducto = new System.Windows.Forms.Button();
            lblCantidadAVender = new System.Windows.Forms.Label();
            lblCantidadProductoElegido = new System.Windows.Forms.Label();
            nudListaProductos = new System.Windows.Forms.NumericUpDown();
            cbProductos = new System.Windows.Forms.ComboBox();
            lblBuscarProductos = new System.Windows.Forms.Label();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVaciarCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBotonVolverMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudListaProductos).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo_carniceria;
            pbLogo.Location = new System.Drawing.Point(1, 1);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(100, 96);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 10;
            pbLogo.TabStop = false;
            // 
            // pUsuario
            // 
            pUsuario.BackColor = System.Drawing.Color.Gainsboro;
            pUsuario.Controls.Add(pbLogoUsuario);
            pUsuario.Controls.Add(lblNombreVendedor);
            pUsuario.Location = new System.Drawing.Point(1184, 0);
            pUsuario.Name = "pUsuario";
            pUsuario.Size = new System.Drawing.Size(182, 53);
            pUsuario.TabIndex = 31;
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
            lblCerrarSesion.Location = new System.Drawing.Point(1278, 60);
            lblCerrarSesion.Name = "lblCerrarSesion";
            lblCerrarSesion.Size = new System.Drawing.Size(78, 14);
            lblCerrarSesion.TabIndex = 30;
            lblCerrarSesion.Text = "Cerrar Sesion";
            lblCerrarSesion.Click += lblCerrarSesion_Click;
            // 
            // cbFiltros
            // 
            cbFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            cbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFiltros.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbFiltros.FormattingEnabled = true;
            cbFiltros.Items.AddRange(new object[] { "Sin Filtrar", "Carne_Vacuna", "Pollo", "Cerdo", "Achuras" });
            cbFiltros.Location = new System.Drawing.Point(545, 149);
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new System.Drawing.Size(133, 22);
            cbFiltros.TabIndex = 48;
            cbFiltros.SelectedIndexChanged += cbFiltros_SelectedIndexChanged;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFiltro.Location = new System.Drawing.Point(371, 153);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new System.Drawing.Size(168, 14);
            lblFiltro.TabIndex = 47;
            lblFiltro.Text = "Filtrar (por categoria)";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.BackColor = System.Drawing.Color.Transparent;
            lblProductos.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblProductos.Location = new System.Drawing.Point(12, 149);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new System.Drawing.Size(197, 18);
            lblProductos.TabIndex = 38;
            lblProductos.Text = "Productos disponibles";
            // 
            // lblTituloVentas
            // 
            lblTituloVentas.AutoSize = true;
            lblTituloVentas.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTituloVentas.Location = new System.Drawing.Point(535, 37);
            lblTituloVentas.Name = "lblTituloVentas";
            lblTituloVentas.Size = new System.Drawing.Size(157, 44);
            lblTituloVentas.TabIndex = 35;
            lblTituloVentas.Text = "Ventas";
            // 
            // dgvListaProductos
            // 
            dgvListaProductos.AllowUserToAddRows = false;
            dgvListaProductos.AllowUserToDeleteRows = false;
            dgvListaProductos.AllowUserToResizeColumns = false;
            dgvListaProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvListaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvListaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dgvListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Nombre, Categoria, Stock, Precio, Detalles });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvListaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListaProductos.EnableHeadersVisualStyles = false;
            dgvListaProductos.Location = new System.Drawing.Point(12, 181);
            dgvListaProductos.Name = "dgvListaProductos";
            dgvListaProductos.ReadOnly = true;
            dgvListaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListaProductos.RowHeadersVisible = false;
            dgvListaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dgvListaProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvListaProductos.RowTemplate.Height = 35;
            dgvListaProductos.RowTemplate.ReadOnly = true;
            dgvListaProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgvListaProductos.ShowCellErrors = false;
            dgvListaProductos.ShowCellToolTips = false;
            dgvListaProductos.ShowEditingIcon = false;
            dgvListaProductos.ShowRowErrors = false;
            dgvListaProductos.Size = new System.Drawing.Size(668, 389);
            dgvListaProductos.TabIndex = 34;
            dgvListaProductos.TabStop = false;
            // 
            // txtSubtotalCarrito
            // 
            txtSubtotalCarrito.Location = new System.Drawing.Point(1263, 634);
            txtSubtotalCarrito.Name = "txtSubtotalCarrito";
            txtSubtotalCarrito.ReadOnly = true;
            txtSubtotalCarrito.Size = new System.Drawing.Size(93, 23);
            txtSubtotalCarrito.TabIndex = 75;
            // 
            // lblSubtotalCarrito
            // 
            lblSubtotalCarrito.AutoSize = true;
            lblSubtotalCarrito.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSubtotalCarrito.ForeColor = System.Drawing.Color.Black;
            lblSubtotalCarrito.Location = new System.Drawing.Point(1194, 634);
            lblSubtotalCarrito.Name = "lblSubtotalCarrito";
            lblSubtotalCarrito.Size = new System.Drawing.Size(63, 19);
            lblSubtotalCarrito.TabIndex = 74;
            lblSubtotalCarrito.Text = "Subtotal";
            // 
            // botonFinalizarVenta
            // 
            botonFinalizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            botonFinalizarVenta.Font = new System.Drawing.Font("Sitka Text", 11.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonFinalizarVenta.Location = new System.Drawing.Point(1233, 692);
            botonFinalizarVenta.Name = "botonFinalizarVenta";
            botonFinalizarVenta.Size = new System.Drawing.Size(120, 63);
            botonFinalizarVenta.TabIndex = 73;
            botonFinalizarVenta.Text = "Finalizar Venta";
            botonFinalizarVenta.UseVisualStyleBackColor = true;
            botonFinalizarVenta.Click += botonFinalizarVenta_Click;
            // 
            // lblVaciarCarrito
            // 
            lblVaciarCarrito.AutoSize = true;
            lblVaciarCarrito.Font = new System.Drawing.Font("Sitka Text", 11.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblVaciarCarrito.ForeColor = System.Drawing.Color.Black;
            lblVaciarCarrito.Location = new System.Drawing.Point(1019, 636);
            lblVaciarCarrito.Name = "lblVaciarCarrito";
            lblVaciarCarrito.Size = new System.Drawing.Size(109, 21);
            lblVaciarCarrito.TabIndex = 72;
            lblVaciarCarrito.Text = "Vaciar Carrito";
            // 
            // pbVaciarCarrito
            // 
            pbVaciarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            pbVaciarCarrito.Image = Properties.Resources.icono_cesto;
            pbVaciarCarrito.Location = new System.Drawing.Point(973, 630);
            pbVaciarCarrito.Name = "pbVaciarCarrito";
            pbVaciarCarrito.Size = new System.Drawing.Size(43, 33);
            pbVaciarCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbVaciarCarrito.TabIndex = 71;
            pbVaciarCarrito.TabStop = false;
            pbVaciarCarrito.Click += pbVaciarCarrito_Click;
            // 
            // lblCarrito
            // 
            lblCarrito.AutoSize = true;
            lblCarrito.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCarrito.ForeColor = System.Drawing.Color.OrangeRed;
            lblCarrito.Location = new System.Drawing.Point(1033, 147);
            lblCarrito.Name = "lblCarrito";
            lblCarrito.Size = new System.Drawing.Size(95, 35);
            lblCarrito.TabIndex = 70;
            lblCarrito.Text = "Carrito";
            // 
            // pbCarrito
            // 
            pbCarrito.Image = Properties.Resources.icono_carrito;
            pbCarrito.Location = new System.Drawing.Point(974, 142);
            pbCarrito.Name = "pbCarrito";
            pbCarrito.Size = new System.Drawing.Size(53, 43);
            pbCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbCarrito.TabIndex = 69;
            pbCarrito.TabStop = false;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AllowUserToResizeColumns = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { NombreProducto, Cantidad, PrecioPorKilo, PrecioTotal });
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle7;
            dgvCarrito.Location = new System.Drawing.Point(965, 191);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new System.Drawing.Size(391, 426);
            dgvCarrito.TabIndex = 68;
            // 
            // NombreProducto
            // 
            NombreProducto.FillWeight = 150F;
            NombreProducto.HeaderText = "Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 70F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // PrecioPorKilo
            // 
            PrecioPorKilo.FillWeight = 95F;
            PrecioPorKilo.HeaderText = "Precio (x KG)";
            PrecioPorKilo.Name = "PrecioPorKilo";
            PrecioPorKilo.ReadOnly = true;
            // 
            // PrecioTotal
            // 
            PrecioTotal.HeaderText = "Precio Total";
            PrecioTotal.Name = "PrecioTotal";
            PrecioTotal.ReadOnly = true;
            // 
            // pbBotonVolverMenu
            // 
            pbBotonVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            pbBotonVolverMenu.Image = Properties.Resources.Icono_volver;
            pbBotonVolverMenu.Location = new System.Drawing.Point(111, 7);
            pbBotonVolverMenu.Name = "pbBotonVolverMenu";
            pbBotonVolverMenu.Size = new System.Drawing.Size(28, 27);
            pbBotonVolverMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbBotonVolverMenu.TabIndex = 77;
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
            lblVolverMenu.TabIndex = 76;
            lblVolverMenu.Text = "Volver al Menu";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new System.Drawing.Point(235, 715);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.ReadOnly = true;
            txtPrecioProducto.Size = new System.Drawing.Size(122, 23);
            txtPrecioProducto.TabIndex = 86;
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPrecioProducto.ForeColor = System.Drawing.Color.Black;
            lblPrecioProducto.Location = new System.Drawing.Point(245, 688);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new System.Drawing.Size(95, 15);
            lblPrecioProducto.TabIndex = 85;
            lblPrecioProducto.Text = "Precio x Kg";
            // 
            // txtCantidadProductoElegido
            // 
            txtCantidadProductoElegido.Location = new System.Drawing.Point(76, 715);
            txtCantidadProductoElegido.Name = "txtCantidadProductoElegido";
            txtCantidadProductoElegido.ReadOnly = true;
            txtCantidadProductoElegido.Size = new System.Drawing.Size(122, 23);
            txtCantidadProductoElegido.TabIndex = 84;
            // 
            // botonAgregarProducto
            // 
            botonAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            botonAgregarProducto.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonAgregarProducto.Location = new System.Drawing.Point(539, 697);
            botonAgregarProducto.Name = "botonAgregarProducto";
            botonAgregarProducto.Size = new System.Drawing.Size(91, 53);
            botonAgregarProducto.TabIndex = 83;
            botonAgregarProducto.Text = "Agregar al Carrito";
            botonAgregarProducto.UseVisualStyleBackColor = true;
            botonAgregarProducto.Click += botonAgregarProducto_Click;
            // 
            // lblCantidadAVender
            // 
            lblCantidadAVender.AutoSize = true;
            lblCantidadAVender.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCantidadAVender.ForeColor = System.Drawing.Color.Black;
            lblCantidadAVender.Location = new System.Drawing.Point(502, 624);
            lblCantidadAVender.Name = "lblCantidadAVender";
            lblCantidadAVender.Size = new System.Drawing.Size(143, 15);
            lblCantidadAVender.TabIndex = 82;
            lblCantidadAVender.Text = "Cantidad a Vender";
            // 
            // lblCantidadProductoElegido
            // 
            lblCantidadProductoElegido.AutoSize = true;
            lblCantidadProductoElegido.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCantidadProductoElegido.ForeColor = System.Drawing.Color.Black;
            lblCantidadProductoElegido.Location = new System.Drawing.Point(56, 688);
            lblCantidadProductoElegido.Name = "lblCantidadProductoElegido";
            lblCantidadProductoElegido.Size = new System.Drawing.Size(159, 15);
            lblCantidadProductoElegido.TabIndex = 81;
            lblCantidadProductoElegido.Text = "Cantidad Disponible";
            // 
            // nudListaProductos
            // 
            nudListaProductos.Location = new System.Drawing.Point(523, 652);
            nudListaProductos.Name = "nudListaProductos";
            nudListaProductos.Size = new System.Drawing.Size(122, 23);
            nudListaProductos.TabIndex = 80;
            // 
            // cbProductos
            // 
            cbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new System.Drawing.Point(56, 650);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new System.Drawing.Size(378, 23);
            cbProductos.TabIndex = 79;
            cbProductos.SelectedIndexChanged += cbProductos_SelectedIndexChanged;
            // 
            // lblBuscarProductos
            // 
            lblBuscarProductos.AutoSize = true;
            lblBuscarProductos.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBuscarProductos.ForeColor = System.Drawing.Color.Black;
            lblBuscarProductos.Location = new System.Drawing.Point(44, 611);
            lblBuscarProductos.Name = "lblBuscarProductos";
            lblBuscarProductos.Size = new System.Drawing.Size(143, 18);
            lblBuscarProductos.TabIndex = 78;
            lblBuscarProductos.Text = "Buscar Producto";
            // 
            // Nombre
            // 
            Nombre.FillWeight = 185F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.FillWeight = 90F;
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.FillWeight = 65F;
            Stock.HeaderText = "Cantidad Disponible";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.FillWeight = 70F;
            Precio.HeaderText = "Precio (x Kg)";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Detalles
            // 
            Detalles.FillWeight = 110F;
            Detalles.HeaderText = "Detalles";
            Detalles.Name = "Detalles";
            Detalles.ReadOnly = true;
            Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Honeydew;
            ClientSize = new System.Drawing.Size(1365, 762);
            Controls.Add(txtPrecioProducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(txtCantidadProductoElegido);
            Controls.Add(botonAgregarProducto);
            Controls.Add(lblCantidadAVender);
            Controls.Add(lblCantidadProductoElegido);
            Controls.Add(nudListaProductos);
            Controls.Add(cbProductos);
            Controls.Add(lblBuscarProductos);
            Controls.Add(pbBotonVolverMenu);
            Controls.Add(lblVolverMenu);
            Controls.Add(txtSubtotalCarrito);
            Controls.Add(lblSubtotalCarrito);
            Controls.Add(botonFinalizarVenta);
            Controls.Add(lblVaciarCarrito);
            Controls.Add(pbVaciarCarrito);
            Controls.Add(lblCarrito);
            Controls.Add(pbCarrito);
            Controls.Add(dgvCarrito);
            Controls.Add(cbFiltros);
            Controls.Add(lblFiltro);
            Controls.Add(lblProductos);
            Controls.Add(lblTituloVentas);
            Controls.Add(dgvListaProductos);
            Controls.Add(pUsuario);
            Controls.Add(lblCerrarSesion);
            Controls.Add(pbLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "FormVenta";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormVenta";
            FormClosing += FormVenta_Closing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pUsuario.ResumeLayout(false);
            pUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVaciarCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBotonVolverMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudListaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pUsuario;
        private System.Windows.Forms.PictureBox pbLogoUsuario;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.ComboBox cbFiltros;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblTituloVentas;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.TextBox txtSubtotalCarrito;
        private System.Windows.Forms.Label lblSubtotalCarrito;
        private System.Windows.Forms.Button botonFinalizarVenta;
        private System.Windows.Forms.Label lblVaciarCarrito;
        private System.Windows.Forms.PictureBox pbVaciarCarrito;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.PictureBox pbCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPorKilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.PictureBox pbBotonVolverMenu;
        private System.Windows.Forms.Label lblVolverMenu;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.TextBox txtCantidadProductoElegido;
        private System.Windows.Forms.Button botonAgregarProducto;
        private System.Windows.Forms.Label lblCantidadAVender;
        private System.Windows.Forms.Label lblCantidadProductoElegido;
        private System.Windows.Forms.NumericUpDown nudListaProductos;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label lblBuscarProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
    }
}