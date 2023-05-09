namespace Parcial_Forms
{
    partial class FormInventario
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
            cbProductos = new System.Windows.Forms.ComboBox();
            lblBuscarProductos = new System.Windows.Forms.Label();
            pbBotonVolverMenu = new System.Windows.Forms.PictureBox();
            lblVolverMenu = new System.Windows.Forms.Label();
            lblTituloInventario = new System.Windows.Forms.Label();
            dgvListaProductos = new System.Windows.Forms.DataGridView();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            caracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pbLogo = new System.Windows.Forms.PictureBox();
            pbLogoUsuario = new System.Windows.Forms.PictureBox();
            lblNombreVendedor = new System.Windows.Forms.Label();
            pUsuario = new System.Windows.Forms.Panel();
            lblCerrarSesion = new System.Windows.Forms.Label();
            cbFiltros = new System.Windows.Forms.ComboBox();
            lblFiltro = new System.Windows.Forms.Label();
            lblProductos = new System.Windows.Forms.Label();
            lblCaracteristicaNuevoProducto = new System.Windows.Forms.Label();
            botonAgregarProducto = new System.Windows.Forms.Button();
            lblCategoriaProducto = new System.Windows.Forms.Label();
            cbCategoriasProducto = new System.Windows.Forms.ComboBox();
            txtCantidadNuevoProducto = new System.Windows.Forms.TextBox();
            txtPrecioNuevoProducto = new System.Windows.Forms.TextBox();
            lblCantidadNuevoProducto = new System.Windows.Forms.Label();
            lblPrecioNuevoProducto = new System.Windows.Forms.Label();
            lblNombreNuevoProducto = new System.Windows.Forms.Label();
            txtNombreNuevoProducto = new System.Windows.Forms.TextBox();
            lblNuevoProducto = new System.Windows.Forms.Label();
            pbBotonNuevoProducto = new System.Windows.Forms.PictureBox();
            pNuevoProducto = new System.Windows.Forms.Panel();
            lblDetallesNuevoProducto = new System.Windows.Forms.Label();
            txtDetallesNuevoProducto = new System.Windows.Forms.TextBox();
            lblNuevoCorte = new System.Windows.Forms.Label();
            pEditarProducto = new System.Windows.Forms.Panel();
            lblCategoriaActual = new System.Windows.Forms.Label();
            lblNuevosDetalles = new System.Windows.Forms.Label();
            lblNuevoPrecio = new System.Windows.Forms.Label();
            lblSumarCantidad = new System.Windows.Forms.Label();
            txtSumarCantidad = new System.Windows.Forms.TextBox();
            lblTotalCantidad = new System.Windows.Forms.Label();
            txtCategoriaActual = new System.Windows.Forms.TextBox();
            cbNuevaCategoria = new System.Windows.Forms.ComboBox();
            txtNuevosDetalles = new System.Windows.Forms.TextBox();
            txtNuevoPrecio = new System.Windows.Forms.TextBox();
            lblNuevaCategoria = new System.Windows.Forms.Label();
            txtTotalCantidad = new System.Windows.Forms.TextBox();
            lblEditarCorte = new System.Windows.Forms.Label();
            txtDetallesActuales = new System.Windows.Forms.TextBox();
            lblPrecioActual = new System.Windows.Forms.Label();
            lblDetallesActuales = new System.Windows.Forms.Label();
            lblCantidadActual = new System.Windows.Forms.Label();
            botonEditarProducto = new System.Windows.Forms.Button();
            txtPrecioActual = new System.Windows.Forms.TextBox();
            txtCantidadActual = new System.Windows.Forms.TextBox();
            pbBotonEditarProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbBotonVolverMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoUsuario).BeginInit();
            pUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBotonNuevoProducto).BeginInit();
            pNuevoProducto.SuspendLayout();
            pEditarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBotonEditarProducto).BeginInit();
            SuspendLayout();
            // 
            // cbProductos
            // 
            cbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new System.Drawing.Point(772, 230);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new System.Drawing.Size(378, 23);
            cbProductos.TabIndex = 92;
            cbProductos.SelectedIndexChanged += cbProductos_SelectedIndexChanged;
            // 
            // lblBuscarProductos
            // 
            lblBuscarProductos.AutoSize = true;
            lblBuscarProductos.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBuscarProductos.ForeColor = System.Drawing.Color.Black;
            lblBuscarProductos.Location = new System.Drawing.Point(752, 200);
            lblBuscarProductos.Name = "lblBuscarProductos";
            lblBuscarProductos.Size = new System.Drawing.Size(143, 18);
            lblBuscarProductos.TabIndex = 91;
            lblBuscarProductos.Text = "Buscar Producto";
            // 
            // pbBotonVolverMenu
            // 
            pbBotonVolverMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            pbBotonVolverMenu.Image = Properties.Resources.Icono_volver;
            pbBotonVolverMenu.Location = new System.Drawing.Point(111, 7);
            pbBotonVolverMenu.Name = "pbBotonVolverMenu";
            pbBotonVolverMenu.Size = new System.Drawing.Size(28, 27);
            pbBotonVolverMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbBotonVolverMenu.TabIndex = 90;
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
            lblVolverMenu.TabIndex = 89;
            lblVolverMenu.Text = "Volver al Menu";
            // 
            // lblTituloInventario
            // 
            lblTituloInventario.AutoSize = true;
            lblTituloInventario.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTituloInventario.Location = new System.Drawing.Point(724, 58);
            lblTituloInventario.Name = "lblTituloInventario";
            lblTituloInventario.Size = new System.Drawing.Size(249, 44);
            lblTituloInventario.TabIndex = 88;
            lblTituloInventario.Text = "Inventario";
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
            dgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Nombre, Tag, Stock, Precio, caracteristica });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvListaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListaProductos.EnableHeadersVisualStyles = false;
            dgvListaProductos.Location = new System.Drawing.Point(12, 273);
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
            dgvListaProductos.Size = new System.Drawing.Size(668, 458);
            dgvListaProductos.TabIndex = 87;
            dgvListaProductos.TabStop = false;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 185F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Tag
            // 
            Tag.FillWeight = 90F;
            Tag.HeaderText = "Categoria";
            Tag.Name = "Tag";
            Tag.ReadOnly = true;
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
            // caracteristica
            // 
            caracteristica.FillWeight = 110F;
            caracteristica.HeaderText = "Detalles";
            caracteristica.Name = "caracteristica";
            caracteristica.ReadOnly = true;
            caracteristica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo_carniceria;
            pbLogo.Location = new System.Drawing.Point(1, 1);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(100, 96);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 84;
            pbLogo.TabStop = false;
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
            // pUsuario
            // 
            pUsuario.BackColor = System.Drawing.Color.Gainsboro;
            pUsuario.Controls.Add(pbLogoUsuario);
            pUsuario.Controls.Add(lblNombreVendedor);
            pUsuario.Location = new System.Drawing.Point(1644, -3);
            pUsuario.Name = "pUsuario";
            pUsuario.Size = new System.Drawing.Size(182, 53);
            pUsuario.TabIndex = 86;
            // 
            // lblCerrarSesion
            // 
            lblCerrarSesion.AutoSize = true;
            lblCerrarSesion.BackColor = System.Drawing.Color.Gainsboro;
            lblCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            lblCerrarSesion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            lblCerrarSesion.Location = new System.Drawing.Point(1738, 57);
            lblCerrarSesion.Name = "lblCerrarSesion";
            lblCerrarSesion.Size = new System.Drawing.Size(78, 14);
            lblCerrarSesion.TabIndex = 85;
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
            cbFiltros.Location = new System.Drawing.Point(545, 225);
            cbFiltros.Name = "cbFiltros";
            cbFiltros.Size = new System.Drawing.Size(133, 22);
            cbFiltros.TabIndex = 96;
            cbFiltros.SelectedIndexChanged += cbFiltros_SelectedIndexChanged;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFiltro.Location = new System.Drawing.Point(371, 229);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new System.Drawing.Size(168, 14);
            lblFiltro.TabIndex = 95;
            lblFiltro.Text = "Filtrar (por categoria)";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.BackColor = System.Drawing.Color.Transparent;
            lblProductos.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblProductos.Location = new System.Drawing.Point(12, 225);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new System.Drawing.Size(197, 18);
            lblProductos.TabIndex = 94;
            lblProductos.Text = "Productos disponibles";
            // 
            // lblCaracteristicaNuevoProducto
            // 
            lblCaracteristicaNuevoProducto.Location = new System.Drawing.Point(0, 0);
            lblCaracteristicaNuevoProducto.Name = "lblCaracteristicaNuevoProducto";
            lblCaracteristicaNuevoProducto.Size = new System.Drawing.Size(100, 23);
            lblCaracteristicaNuevoProducto.TabIndex = 115;
            // 
            // botonAgregarProducto
            // 
            botonAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            botonAgregarProducto.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonAgregarProducto.Location = new System.Drawing.Point(154, 405);
            botonAgregarProducto.Name = "botonAgregarProducto";
            botonAgregarProducto.Size = new System.Drawing.Size(123, 32);
            botonAgregarProducto.TabIndex = 106;
            botonAgregarProducto.Text = "Agregar";
            botonAgregarProducto.UseVisualStyleBackColor = true;
            botonAgregarProducto.Click += botonAgregarProducto_Click;
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.AutoSize = true;
            lblCategoriaProducto.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCategoriaProducto.Location = new System.Drawing.Point(39, 61);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.Size = new System.Drawing.Size(70, 14);
            lblCategoriaProducto.TabIndex = 105;
            lblCategoriaProducto.Text = "Categoria";
            // 
            // cbCategoriasProducto
            // 
            cbCategoriasProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbCategoriasProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbCategoriasProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            cbCategoriasProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCategoriasProducto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbCategoriasProducto.FormattingEnabled = true;
            cbCategoriasProducto.Items.AddRange(new object[] { "Carne_Vacuna", "Pollo", "Cerdo", "Achuras" });
            cbCategoriasProducto.Location = new System.Drawing.Point(51, 78);
            cbCategoriasProducto.Name = "cbCategoriasProducto";
            cbCategoriasProducto.Size = new System.Drawing.Size(297, 22);
            cbCategoriasProducto.TabIndex = 104;
            // 
            // txtCantidadNuevoProducto
            // 
            txtCantidadNuevoProducto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCantidadNuevoProducto.Location = new System.Drawing.Point(51, 201);
            txtCantidadNuevoProducto.Name = "txtCantidadNuevoProducto";
            txtCantidadNuevoProducto.Size = new System.Drawing.Size(297, 22);
            txtCantidadNuevoProducto.TabIndex = 103;
            // 
            // txtPrecioNuevoProducto
            // 
            txtPrecioNuevoProducto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPrecioNuevoProducto.Location = new System.Drawing.Point(51, 265);
            txtPrecioNuevoProducto.Name = "txtPrecioNuevoProducto";
            txtPrecioNuevoProducto.Size = new System.Drawing.Size(297, 22);
            txtPrecioNuevoProducto.TabIndex = 102;
            // 
            // lblCantidadNuevoProducto
            // 
            lblCantidadNuevoProducto.AutoSize = true;
            lblCantidadNuevoProducto.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCantidadNuevoProducto.Location = new System.Drawing.Point(39, 184);
            lblCantidadNuevoProducto.Name = "lblCantidadNuevoProducto";
            lblCantidadNuevoProducto.Size = new System.Drawing.Size(63, 14);
            lblCantidadNuevoProducto.TabIndex = 100;
            lblCantidadNuevoProducto.Text = "Cantidad";
            // 
            // lblPrecioNuevoProducto
            // 
            lblPrecioNuevoProducto.AutoSize = true;
            lblPrecioNuevoProducto.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPrecioNuevoProducto.Location = new System.Drawing.Point(39, 248);
            lblPrecioNuevoProducto.Name = "lblPrecioNuevoProducto";
            lblPrecioNuevoProducto.Size = new System.Drawing.Size(98, 14);
            lblPrecioNuevoProducto.TabIndex = 99;
            lblPrecioNuevoProducto.Text = "Precio (x Kg)";
            // 
            // lblNombreNuevoProducto
            // 
            lblNombreNuevoProducto.AutoSize = true;
            lblNombreNuevoProducto.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombreNuevoProducto.Location = new System.Drawing.Point(39, 117);
            lblNombreNuevoProducto.Name = "lblNombreNuevoProducto";
            lblNombreNuevoProducto.Size = new System.Drawing.Size(91, 14);
            lblNombreNuevoProducto.TabIndex = 98;
            lblNombreNuevoProducto.Text = "Nombre Corte";
            // 
            // txtNombreNuevoProducto
            // 
            txtNombreNuevoProducto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombreNuevoProducto.Location = new System.Drawing.Point(51, 134);
            txtNombreNuevoProducto.Name = "txtNombreNuevoProducto";
            txtNombreNuevoProducto.Size = new System.Drawing.Size(297, 22);
            txtNombreNuevoProducto.TabIndex = 97;
            // 
            // lblNuevoProducto
            // 
            lblNuevoProducto.AutoSize = true;
            lblNuevoProducto.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNuevoProducto.Location = new System.Drawing.Point(1409, 223);
            lblNuevoProducto.Name = "lblNuevoProducto";
            lblNuevoProducto.Size = new System.Drawing.Size(206, 18);
            lblNuevoProducto.TabIndex = 111;
            lblNuevoProducto.Text = "Agregar nuevo Producto";
            // 
            // pbBotonNuevoProducto
            // 
            pbBotonNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            pbBotonNuevoProducto.Image = Properties.Resources.Icono_agregar;
            pbBotonNuevoProducto.Location = new System.Drawing.Point(1623, 213);
            pbBotonNuevoProducto.Name = "pbBotonNuevoProducto";
            pbBotonNuevoProducto.Size = new System.Drawing.Size(37, 34);
            pbBotonNuevoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbBotonNuevoProducto.TabIndex = 110;
            pbBotonNuevoProducto.TabStop = false;
            pbBotonNuevoProducto.Click += pbBotonNuevoProducto_Click;
            // 
            // pNuevoProducto
            // 
            pNuevoProducto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            pNuevoProducto.Controls.Add(lblDetallesNuevoProducto);
            pNuevoProducto.Controls.Add(txtDetallesNuevoProducto);
            pNuevoProducto.Controls.Add(lblNuevoCorte);
            pNuevoProducto.Controls.Add(cbCategoriasProducto);
            pNuevoProducto.Controls.Add(txtNombreNuevoProducto);
            pNuevoProducto.Controls.Add(lblNombreNuevoProducto);
            pNuevoProducto.Controls.Add(lblPrecioNuevoProducto);
            pNuevoProducto.Controls.Add(lblCaracteristicaNuevoProducto);
            pNuevoProducto.Controls.Add(lblCantidadNuevoProducto);
            pNuevoProducto.Controls.Add(botonAgregarProducto);
            pNuevoProducto.Controls.Add(txtPrecioNuevoProducto);
            pNuevoProducto.Controls.Add(lblCategoriaProducto);
            pNuevoProducto.Controls.Add(txtCantidadNuevoProducto);
            pNuevoProducto.Location = new System.Drawing.Point(1349, 271);
            pNuevoProducto.Name = "pNuevoProducto";
            pNuevoProducto.Size = new System.Drawing.Size(415, 458);
            pNuevoProducto.TabIndex = 112;
            pNuevoProducto.Tag = "";
            pNuevoProducto.Visible = false;
            // 
            // lblDetallesNuevoProducto
            // 
            lblDetallesNuevoProducto.AutoSize = true;
            lblDetallesNuevoProducto.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDetallesNuevoProducto.Location = new System.Drawing.Point(39, 313);
            lblDetallesNuevoProducto.Name = "lblDetallesNuevoProducto";
            lblDetallesNuevoProducto.Size = new System.Drawing.Size(63, 14);
            lblDetallesNuevoProducto.TabIndex = 116;
            lblDetallesNuevoProducto.Text = "Detalles";
            // 
            // txtDetallesNuevoProducto
            // 
            txtDetallesNuevoProducto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDetallesNuevoProducto.Location = new System.Drawing.Point(51, 330);
            txtDetallesNuevoProducto.Name = "txtDetallesNuevoProducto";
            txtDetallesNuevoProducto.Size = new System.Drawing.Size(297, 22);
            txtDetallesNuevoProducto.TabIndex = 117;
            // 
            // lblNuevoCorte
            // 
            lblNuevoCorte.AutoSize = true;
            lblNuevoCorte.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNuevoCorte.Location = new System.Drawing.Point(154, 22);
            lblNuevoCorte.Name = "lblNuevoCorte";
            lblNuevoCorte.Size = new System.Drawing.Size(107, 18);
            lblNuevoCorte.TabIndex = 113;
            lblNuevoCorte.Text = "Nuevo Corte";
            // 
            // pEditarProducto
            // 
            pEditarProducto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            pEditarProducto.Controls.Add(lblCategoriaActual);
            pEditarProducto.Controls.Add(lblNuevosDetalles);
            pEditarProducto.Controls.Add(lblNuevoPrecio);
            pEditarProducto.Controls.Add(lblSumarCantidad);
            pEditarProducto.Controls.Add(txtSumarCantidad);
            pEditarProducto.Controls.Add(lblTotalCantidad);
            pEditarProducto.Controls.Add(txtCategoriaActual);
            pEditarProducto.Controls.Add(cbNuevaCategoria);
            pEditarProducto.Controls.Add(txtNuevosDetalles);
            pEditarProducto.Controls.Add(txtNuevoPrecio);
            pEditarProducto.Controls.Add(lblNuevaCategoria);
            pEditarProducto.Controls.Add(txtTotalCantidad);
            pEditarProducto.Controls.Add(lblEditarCorte);
            pEditarProducto.Controls.Add(txtDetallesActuales);
            pEditarProducto.Controls.Add(lblPrecioActual);
            pEditarProducto.Controls.Add(lblDetallesActuales);
            pEditarProducto.Controls.Add(lblCantidadActual);
            pEditarProducto.Controls.Add(botonEditarProducto);
            pEditarProducto.Controls.Add(txtPrecioActual);
            pEditarProducto.Controls.Add(txtCantidadActual);
            pEditarProducto.Location = new System.Drawing.Point(718, 271);
            pEditarProducto.Name = "pEditarProducto";
            pEditarProducto.Size = new System.Drawing.Size(561, 458);
            pEditarProducto.TabIndex = 114;
            pEditarProducto.Tag = "";
            pEditarProducto.Visible = false;
            // 
            // lblCategoriaActual
            // 
            lblCategoriaActual.AutoSize = true;
            lblCategoriaActual.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCategoriaActual.Location = new System.Drawing.Point(39, 61);
            lblCategoriaActual.Name = "lblCategoriaActual";
            lblCategoriaActual.Size = new System.Drawing.Size(70, 14);
            lblCategoriaActual.TabIndex = 130;
            lblCategoriaActual.Text = "Categoria";
            // 
            // lblNuevosDetalles
            // 
            lblNuevosDetalles.AutoSize = true;
            lblNuevosDetalles.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNuevosDetalles.Location = new System.Drawing.Point(302, 313);
            lblNuevosDetalles.Name = "lblNuevosDetalles";
            lblNuevosDetalles.Size = new System.Drawing.Size(112, 14);
            lblNuevosDetalles.TabIndex = 129;
            lblNuevosDetalles.Text = "Nuevos Detalles";
            // 
            // lblNuevoPrecio
            // 
            lblNuevoPrecio.AutoSize = true;
            lblNuevoPrecio.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNuevoPrecio.Location = new System.Drawing.Point(302, 225);
            lblNuevoPrecio.Name = "lblNuevoPrecio";
            lblNuevoPrecio.Size = new System.Drawing.Size(140, 14);
            lblNuevoPrecio.TabIndex = 128;
            lblNuevoPrecio.Text = "Nuevo Precio (x Kg)";
            // 
            // lblSumarCantidad
            // 
            lblSumarCantidad.AutoSize = true;
            lblSumarCantidad.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSumarCantidad.Location = new System.Drawing.Point(302, 138);
            lblSumarCantidad.Name = "lblSumarCantidad";
            lblSumarCantidad.Size = new System.Drawing.Size(105, 14);
            lblSumarCantidad.TabIndex = 127;
            lblSumarCantidad.Text = "Sumar Cantidad";
            // 
            // txtSumarCantidad
            // 
            txtSumarCantidad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSumarCantidad.Location = new System.Drawing.Point(316, 155);
            txtSumarCantidad.Name = "txtSumarCantidad";
            txtSumarCantidad.Size = new System.Drawing.Size(98, 22);
            txtSumarCantidad.TabIndex = 126;
            txtSumarCantidad.TextChanged += txtSumarCantidad_TextChanged;
            // 
            // lblTotalCantidad
            // 
            lblTotalCantidad.AutoSize = true;
            lblTotalCantidad.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTotalCantidad.Location = new System.Drawing.Point(432, 138);
            lblTotalCantidad.Name = "lblTotalCantidad";
            lblTotalCantidad.Size = new System.Drawing.Size(105, 14);
            lblTotalCantidad.TabIndex = 125;
            lblTotalCantidad.Text = "Total Cantidad";
            // 
            // txtCategoriaActual
            // 
            txtCategoriaActual.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCategoriaActual.Location = new System.Drawing.Point(51, 78);
            txtCategoriaActual.Name = "txtCategoriaActual";
            txtCategoriaActual.ReadOnly = true;
            txtCategoriaActual.Size = new System.Drawing.Size(203, 22);
            txtCategoriaActual.TabIndex = 124;
            // 
            // cbNuevaCategoria
            // 
            cbNuevaCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbNuevaCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbNuevaCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            cbNuevaCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbNuevaCategoria.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbNuevaCategoria.FormattingEnabled = true;
            cbNuevaCategoria.Items.AddRange(new object[] { "Carne_Vacuna", "Pollo", "Cerdo", "Achuras" });
            cbNuevaCategoria.Location = new System.Drawing.Point(314, 78);
            cbNuevaCategoria.Name = "cbNuevaCategoria";
            cbNuevaCategoria.Size = new System.Drawing.Size(203, 22);
            cbNuevaCategoria.TabIndex = 120;
            // 
            // txtNuevosDetalles
            // 
            txtNuevosDetalles.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNuevosDetalles.Location = new System.Drawing.Point(314, 330);
            txtNuevosDetalles.Name = "txtNuevosDetalles";
            txtNuevosDetalles.Size = new System.Drawing.Size(203, 22);
            txtNuevosDetalles.TabIndex = 123;
            // 
            // txtNuevoPrecio
            // 
            txtNuevoPrecio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNuevoPrecio.Location = new System.Drawing.Point(314, 242);
            txtNuevoPrecio.Name = "txtNuevoPrecio";
            txtNuevoPrecio.Size = new System.Drawing.Size(203, 22);
            txtNuevoPrecio.TabIndex = 118;
            // 
            // lblNuevaCategoria
            // 
            lblNuevaCategoria.AutoSize = true;
            lblNuevaCategoria.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNuevaCategoria.Location = new System.Drawing.Point(302, 61);
            lblNuevaCategoria.Name = "lblNuevaCategoria";
            lblNuevaCategoria.Size = new System.Drawing.Size(112, 14);
            lblNuevaCategoria.TabIndex = 121;
            lblNuevaCategoria.Text = "Nueva Categoria";
            // 
            // txtTotalCantidad
            // 
            txtTotalCantidad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTotalCantidad.Location = new System.Drawing.Point(444, 155);
            txtTotalCantidad.Name = "txtTotalCantidad";
            txtTotalCantidad.Size = new System.Drawing.Size(98, 22);
            txtTotalCantidad.TabIndex = 119;
            // 
            // lblEditarCorte
            // 
            lblEditarCorte.AutoSize = true;
            lblEditarCorte.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblEditarCorte.Location = new System.Drawing.Point(226, 22);
            lblEditarCorte.Name = "lblEditarCorte";
            lblEditarCorte.Size = new System.Drawing.Size(116, 18);
            lblEditarCorte.TabIndex = 113;
            lblEditarCorte.Text = "Editar Corte";
            // 
            // txtDetallesActuales
            // 
            txtDetallesActuales.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDetallesActuales.Location = new System.Drawing.Point(51, 330);
            txtDetallesActuales.Name = "txtDetallesActuales";
            txtDetallesActuales.ReadOnly = true;
            txtDetallesActuales.Size = new System.Drawing.Size(203, 22);
            txtDetallesActuales.TabIndex = 108;
            // 
            // lblPrecioActual
            // 
            lblPrecioActual.AutoSize = true;
            lblPrecioActual.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPrecioActual.Location = new System.Drawing.Point(39, 225);
            lblPrecioActual.Name = "lblPrecioActual";
            lblPrecioActual.Size = new System.Drawing.Size(98, 14);
            lblPrecioActual.TabIndex = 99;
            lblPrecioActual.Text = "Precio (x Kg)";
            // 
            // lblDetallesActuales
            // 
            lblDetallesActuales.AutoSize = true;
            lblDetallesActuales.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDetallesActuales.Location = new System.Drawing.Point(39, 313);
            lblDetallesActuales.Name = "lblDetallesActuales";
            lblDetallesActuales.Size = new System.Drawing.Size(63, 14);
            lblDetallesActuales.TabIndex = 107;
            lblDetallesActuales.Text = "Detalles";
            // 
            // lblCantidadActual
            // 
            lblCantidadActual.AutoSize = true;
            lblCantidadActual.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCantidadActual.Location = new System.Drawing.Point(39, 138);
            lblCantidadActual.Name = "lblCantidadActual";
            lblCantidadActual.Size = new System.Drawing.Size(63, 14);
            lblCantidadActual.TabIndex = 100;
            lblCantidadActual.Text = "Cantidad";
            // 
            // botonEditarProducto
            // 
            botonEditarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            botonEditarProducto.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonEditarProducto.Location = new System.Drawing.Point(219, 405);
            botonEditarProducto.Name = "botonEditarProducto";
            botonEditarProducto.Size = new System.Drawing.Size(123, 32);
            botonEditarProducto.TabIndex = 106;
            botonEditarProducto.Text = "Editar";
            botonEditarProducto.UseVisualStyleBackColor = true;
            botonEditarProducto.Click += botonEditarProducto_Click;
            // 
            // txtPrecioActual
            // 
            txtPrecioActual.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPrecioActual.Location = new System.Drawing.Point(51, 242);
            txtPrecioActual.Name = "txtPrecioActual";
            txtPrecioActual.ReadOnly = true;
            txtPrecioActual.Size = new System.Drawing.Size(203, 22);
            txtPrecioActual.TabIndex = 102;
            // 
            // txtCantidadActual
            // 
            txtCantidadActual.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCantidadActual.Location = new System.Drawing.Point(51, 155);
            txtCantidadActual.Name = "txtCantidadActual";
            txtCantidadActual.ReadOnly = true;
            txtCantidadActual.Size = new System.Drawing.Size(203, 22);
            txtCantidadActual.TabIndex = 103;
            // 
            // pbBotonEditarProducto
            // 
            pbBotonEditarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            pbBotonEditarProducto.Image = Properties.Resources.Icono_editar;
            pbBotonEditarProducto.Location = new System.Drawing.Point(1168, 223);
            pbBotonEditarProducto.Name = "pbBotonEditarProducto";
            pbBotonEditarProducto.Size = new System.Drawing.Size(40, 34);
            pbBotonEditarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbBotonEditarProducto.TabIndex = 116;
            pbBotonEditarProducto.TabStop = false;
            pbBotonEditarProducto.Click += pbBotonEditarProducto_Click;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Honeydew;
            ClientSize = new System.Drawing.Size(1822, 766);
            Controls.Add(pbBotonEditarProducto);
            Controls.Add(pEditarProducto);
            Controls.Add(pNuevoProducto);
            Controls.Add(lblNuevoProducto);
            Controls.Add(pbBotonNuevoProducto);
            Controls.Add(cbFiltros);
            Controls.Add(lblFiltro);
            Controls.Add(lblProductos);
            Controls.Add(cbProductos);
            Controls.Add(lblBuscarProductos);
            Controls.Add(pbBotonVolverMenu);
            Controls.Add(lblVolverMenu);
            Controls.Add(lblTituloInventario);
            Controls.Add(dgvListaProductos);
            Controls.Add(pbLogo);
            Controls.Add(pUsuario);
            Controls.Add(lblCerrarSesion);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "FormInventario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormInventario";
            FormClosing += FormInventario_Closing;
            ((System.ComponentModel.ISupportInitialize)pbBotonVolverMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoUsuario).EndInit();
            pUsuario.ResumeLayout(false);
            pUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBotonNuevoProducto).EndInit();
            pNuevoProducto.ResumeLayout(false);
            pNuevoProducto.PerformLayout();
            pEditarProducto.ResumeLayout(false);
            pEditarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbBotonEditarProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label lblBuscarProductos;
        private System.Windows.Forms.PictureBox pbBotonVolverMenu;
        private System.Windows.Forms.Label lblVolverMenu;
        private System.Windows.Forms.Label lblTituloInventario;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn caracteristica;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbLogoUsuario;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Panel pUsuario;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.ComboBox cbFiltros;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblCaracteristicaNuevoProducto;
        private System.Windows.Forms.Button botonAgregarProducto;
        private System.Windows.Forms.Label lblCategoriaProducto;
        private System.Windows.Forms.ComboBox cbCategoriasProducto;
        private System.Windows.Forms.TextBox txtCantidadNuevoProducto;
        private System.Windows.Forms.TextBox txtPrecioNuevoProducto;
        private System.Windows.Forms.Label lblCategoriaNuevoProducto;
        private System.Windows.Forms.Label lblCantidadNuevoProducto;
        private System.Windows.Forms.Label lblPrecioNuevoProducto;
        private System.Windows.Forms.Label lblNombreNuevoProducto;
        private System.Windows.Forms.TextBox txtNombreNuevoProducto;
        private System.Windows.Forms.Label lblNuevoProducto;
        private System.Windows.Forms.PictureBox pbBotonNuevoProducto;
        private System.Windows.Forms.Panel pNuevoProducto;
        private System.Windows.Forms.Label lblNuevoCorte;
        private System.Windows.Forms.Panel pEditarProducto;
        private System.Windows.Forms.Label lblEditarCorte;
        private System.Windows.Forms.TextBox txtDetallesActuales;
        private System.Windows.Forms.Label lblPrecioActual;
        private System.Windows.Forms.Label lblDetallesActuales;
        private System.Windows.Forms.Label lblCantidadActual;
        private System.Windows.Forms.Button botonEditarProducto;
        private System.Windows.Forms.TextBox txtPrecioActual;
        private System.Windows.Forms.TextBox txtCantidadActual;
        private System.Windows.Forms.PictureBox pbBotonEditarProducto;
        private System.Windows.Forms.ComboBox cbNuevaCategoria;
        private System.Windows.Forms.TextBox txtNuevosDetalles;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.Label lblNuevaCategoria;
        private System.Windows.Forms.TextBox txtTotalCantidad;
        private System.Windows.Forms.TextBox txtCategoriaActual;
        private System.Windows.Forms.TextBox txtSumarCantidad;
        private System.Windows.Forms.Label lblTotalCantidad;
        private System.Windows.Forms.Label lblCategoriaActual;
        private System.Windows.Forms.Label lblNuevosDetalles;
        private System.Windows.Forms.Label lblNuevoPrecio;
        private System.Windows.Forms.Label lblSumarCantidad;
        private System.Windows.Forms.Label lblDetallesNuevoProducto;
        private System.Windows.Forms.TextBox txtDetallesNuevoProducto;
    }
}