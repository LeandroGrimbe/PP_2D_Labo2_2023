namespace Parcial_Forms
{
    partial class FormProgramador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            pbLogo = new System.Windows.Forms.PictureBox();
            pUsuario = new System.Windows.Forms.Panel();
            pbLogoUsuario = new System.Windows.Forms.PictureBox();
            lblNombreProgramador = new System.Windows.Forms.Label();
            lblCerrarSesion = new System.Windows.Forms.Label();
            lblTituloProgramador = new System.Windows.Forms.Label();
            cbProductos = new System.Windows.Forms.ComboBox();
            lblBuscarProductos = new System.Windows.Forms.Label();
            botonSerializarJSON = new System.Windows.Forms.Button();
            botonDeSerializarJSON = new System.Windows.Forms.Button();
            botonSerializarXML = new System.Windows.Forms.Button();
            botonDeSerializarXML = new System.Windows.Forms.Button();
            lblSalidaSerializado = new System.Windows.Forms.Label();
            rtbSalidaSerializado = new System.Windows.Forms.RichTextBox();
            botonGenerarHistorial = new System.Windows.Forms.Button();
            lblHistorial = new System.Windows.Forms.Label();
            rtbHistorial = new System.Windows.Forms.RichTextBox();
            lvlVistaPreviaHistorial = new System.Windows.Forms.Label();
            pTimer = new System.Windows.Forms.Panel();
            rtbSegundos = new System.Windows.Forms.RichTextBox();
            rtbMinutos = new System.Windows.Forms.RichTextBox();
            rtbHoras = new System.Windows.Forms.RichTextBox();
            lblTimer = new System.Windows.Forms.Label();
            timerTiempoSesion = new System.Windows.Forms.Timer(components);
            lblListado = new System.Windows.Forms.Label();
            lblProductos = new System.Windows.Forms.Label();
            lblUsuarios = new System.Windows.Forms.Label();
            dgvListaProductos = new System.Windows.Forms.DataGridView();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoUsuario).BeginInit();
            pTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo_carniceria;
            pbLogo.Location = new System.Drawing.Point(-1, -1);
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
            pUsuario.Controls.Add(lblNombreProgramador);
            pUsuario.Location = new System.Drawing.Point(1277, -1);
            pUsuario.Name = "pUsuario";
            pUsuario.Size = new System.Drawing.Size(218, 53);
            pUsuario.TabIndex = 95;
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
            // lblNombreProgramador
            // 
            lblNombreProgramador.AutoSize = true;
            lblNombreProgramador.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombreProgramador.ForeColor = System.Drawing.Color.Black;
            lblNombreProgramador.Location = new System.Drawing.Point(52, 16);
            lblNombreProgramador.Name = "lblNombreProgramador";
            lblNombreProgramador.Size = new System.Drawing.Size(63, 19);
            lblNombreProgramador.TabIndex = 9;
            lblNombreProgramador.Text = "Usuario";
            // 
            // lblCerrarSesion
            // 
            lblCerrarSesion.AutoSize = true;
            lblCerrarSesion.BackColor = System.Drawing.Color.Gainsboro;
            lblCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            lblCerrarSesion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            lblCerrarSesion.Location = new System.Drawing.Point(1407, 59);
            lblCerrarSesion.Name = "lblCerrarSesion";
            lblCerrarSesion.Size = new System.Drawing.Size(78, 14);
            lblCerrarSesion.TabIndex = 94;
            lblCerrarSesion.Text = "Cerrar Sesion";
            lblCerrarSesion.Click += lblCerrarSesion_Click;
            // 
            // lblTituloProgramador
            // 
            lblTituloProgramador.AutoSize = true;
            lblTituloProgramador.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTituloProgramador.Location = new System.Drawing.Point(604, 88);
            lblTituloProgramador.Name = "lblTituloProgramador";
            lblTituloProgramador.Size = new System.Drawing.Size(226, 44);
            lblTituloProgramador.TabIndex = 96;
            lblTituloProgramador.Text = "Funciones";
            // 
            // cbProductos
            // 
            cbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new System.Drawing.Point(51, 221);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new System.Drawing.Size(378, 23);
            cbProductos.TabIndex = 98;
            // 
            // lblBuscarProductos
            // 
            lblBuscarProductos.AutoSize = true;
            lblBuscarProductos.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBuscarProductos.ForeColor = System.Drawing.Color.Black;
            lblBuscarProductos.Location = new System.Drawing.Point(30, 189);
            lblBuscarProductos.Name = "lblBuscarProductos";
            lblBuscarProductos.Size = new System.Drawing.Size(143, 18);
            lblBuscarProductos.TabIndex = 97;
            lblBuscarProductos.Text = "Buscar Producto";
            // 
            // botonSerializarJSON
            // 
            botonSerializarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            botonSerializarJSON.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonSerializarJSON.Location = new System.Drawing.Point(51, 299);
            botonSerializarJSON.Name = "botonSerializarJSON";
            botonSerializarJSON.Size = new System.Drawing.Size(150, 32);
            botonSerializarJSON.TabIndex = 107;
            botonSerializarJSON.Text = "Serializar JSON";
            botonSerializarJSON.UseVisualStyleBackColor = true;
            botonSerializarJSON.Click += botonSerializarJSON_Click;
            // 
            // botonDeSerializarJSON
            // 
            botonDeSerializarJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            botonDeSerializarJSON.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonDeSerializarJSON.Location = new System.Drawing.Point(51, 353);
            botonDeSerializarJSON.Name = "botonDeSerializarJSON";
            botonDeSerializarJSON.Size = new System.Drawing.Size(150, 32);
            botonDeSerializarJSON.TabIndex = 108;
            botonDeSerializarJSON.Text = "DeSerializar JSON";
            botonDeSerializarJSON.UseVisualStyleBackColor = true;
            botonDeSerializarJSON.Click += botonDeSerializarJSON_Click;
            // 
            // botonSerializarXML
            // 
            botonSerializarXML.Cursor = System.Windows.Forms.Cursors.Hand;
            botonSerializarXML.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonSerializarXML.Location = new System.Drawing.Point(279, 299);
            botonSerializarXML.Name = "botonSerializarXML";
            botonSerializarXML.Size = new System.Drawing.Size(150, 32);
            botonSerializarXML.TabIndex = 109;
            botonSerializarXML.Text = "Serializar XML";
            botonSerializarXML.UseVisualStyleBackColor = true;
            botonSerializarXML.Click += botonSerializarXML_Click;
            // 
            // botonDeSerializarXML
            // 
            botonDeSerializarXML.Cursor = System.Windows.Forms.Cursors.Hand;
            botonDeSerializarXML.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonDeSerializarXML.Location = new System.Drawing.Point(279, 353);
            botonDeSerializarXML.Name = "botonDeSerializarXML";
            botonDeSerializarXML.Size = new System.Drawing.Size(150, 32);
            botonDeSerializarXML.TabIndex = 110;
            botonDeSerializarXML.Text = "DeSerializar XML";
            botonDeSerializarXML.UseVisualStyleBackColor = true;
            botonDeSerializarXML.Click += botonDeSerializarXML_Click;
            // 
            // lblSalidaSerializado
            // 
            lblSalidaSerializado.AutoSize = true;
            lblSalidaSerializado.Font = new System.Drawing.Font("Sitka Text", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSalidaSerializado.Location = new System.Drawing.Point(205, 423);
            lblSalidaSerializado.Name = "lblSalidaSerializado";
            lblSalidaSerializado.Size = new System.Drawing.Size(66, 28);
            lblSalidaSerializado.TabIndex = 111;
            lblSalidaSerializado.Text = "Salida";
            // 
            // rtbSalidaSerializado
            // 
            rtbSalidaSerializado.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rtbSalidaSerializado.Location = new System.Drawing.Point(51, 466);
            rtbSalidaSerializado.Name = "rtbSalidaSerializado";
            rtbSalidaSerializado.ReadOnly = true;
            rtbSalidaSerializado.Size = new System.Drawing.Size(378, 195);
            rtbSalidaSerializado.TabIndex = 112;
            rtbSalidaSerializado.Text = "";
            // 
            // botonGenerarHistorial
            // 
            botonGenerarHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            botonGenerarHistorial.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            botonGenerarHistorial.Location = new System.Drawing.Point(643, 629);
            botonGenerarHistorial.Name = "botonGenerarHistorial";
            botonGenerarHistorial.Size = new System.Drawing.Size(150, 32);
            botonGenerarHistorial.TabIndex = 113;
            botonGenerarHistorial.Text = "Generar TXT";
            botonGenerarHistorial.UseVisualStyleBackColor = true;
            botonGenerarHistorial.Click += botonGenerarHistorial_Click;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHistorial.ForeColor = System.Drawing.Color.Black;
            lblHistorial.Location = new System.Drawing.Point(630, 189);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new System.Drawing.Size(179, 18);
            lblHistorial.TabIndex = 114;
            lblHistorial.Text = "Historial de ventas";
            // 
            // rtbHistorial
            // 
            rtbHistorial.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            rtbHistorial.Location = new System.Drawing.Point(568, 272);
            rtbHistorial.Name = "rtbHistorial";
            rtbHistorial.ReadOnly = true;
            rtbHistorial.Size = new System.Drawing.Size(300, 335);
            rtbHistorial.TabIndex = 115;
            rtbHistorial.Text = "";
            // 
            // lvlVistaPreviaHistorial
            // 
            lvlVistaPreviaHistorial.AutoSize = true;
            lvlVistaPreviaHistorial.Font = new System.Drawing.Font("Sitka Text", 11.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lvlVistaPreviaHistorial.Location = new System.Drawing.Point(670, 248);
            lvlVistaPreviaHistorial.Name = "lvlVistaPreviaHistorial";
            lvlVistaPreviaHistorial.Size = new System.Drawing.Size(95, 21);
            lvlVistaPreviaHistorial.TabIndex = 116;
            lvlVistaPreviaHistorial.Text = "Vista Previa";
            // 
            // pTimer
            // 
            pTimer.BackColor = System.Drawing.Color.White;
            pTimer.Controls.Add(rtbSegundos);
            pTimer.Controls.Add(rtbMinutos);
            pTimer.Controls.Add(rtbHoras);
            pTimer.Controls.Add(lblTimer);
            pTimer.Location = new System.Drawing.Point(1141, -1);
            pTimer.Name = "pTimer";
            pTimer.Size = new System.Drawing.Size(120, 53);
            pTimer.TabIndex = 117;
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
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblListado.ForeColor = System.Drawing.Color.Black;
            lblListado.Location = new System.Drawing.Point(1141, 189);
            lblListado.Name = "lblListado";
            lblListado.Size = new System.Drawing.Size(80, 18);
            lblListado.TabIndex = 118;
            lblListado.Text = "Listados";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new System.Drawing.Font("Sitka Text", 11.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProductos.Location = new System.Drawing.Point(921, 219);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new System.Drawing.Size(80, 21);
            lblProductos.TabIndex = 121;
            lblProductos.Text = "Productos";
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new System.Drawing.Font("Sitka Text", 11.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUsuarios.Location = new System.Drawing.Point(921, 454);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new System.Drawing.Size(72, 21);
            lblUsuarios.TabIndex = 122;
            lblUsuarios.Text = "Usuarios";
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
            dgvListaProductos.Location = new System.Drawing.Point(921, 248);
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
            dgvListaProductos.Size = new System.Drawing.Size(552, 179);
            dgvListaProductos.TabIndex = 123;
            dgvListaProductos.TabStop = false;
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
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AllowUserToDeleteRows = false;
            dgvListaUsuarios.AllowUserToResizeColumns = false;
            dgvListaUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgvListaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvListaUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dgvListaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvListaUsuarios.DefaultCellStyle = dataGridViewCellStyle8;
            dgvListaUsuarios.EnableHeadersVisualStyles = false;
            dgvListaUsuarios.Location = new System.Drawing.Point(921, 482);
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvListaUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvListaUsuarios.RowHeadersVisible = false;
            dgvListaUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dgvListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvListaUsuarios.RowTemplate.Height = 35;
            dgvListaUsuarios.RowTemplate.ReadOnly = true;
            dgvListaUsuarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgvListaUsuarios.ShowCellErrors = false;
            dgvListaUsuarios.ShowCellToolTips = false;
            dgvListaUsuarios.ShowEditingIcon = false;
            dgvListaUsuarios.ShowRowErrors = false;
            dgvListaUsuarios.Size = new System.Drawing.Size(552, 179);
            dgvListaUsuarios.TabIndex = 124;
            dgvListaUsuarios.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 130F;
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 90F;
            dataGridViewTextBoxColumn2.HeaderText = "Email";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 65F;
            dataGridViewTextBoxColumn3.HeaderText = "Clave";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.FillWeight = 70F;
            dataGridViewTextBoxColumn4.HeaderText = "Dinero";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.FillWeight = 70F;
            dataGridViewTextBoxColumn5.HeaderText = "Rol";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormProgramador
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Honeydew;
            ClientSize = new System.Drawing.Size(1495, 711);
            Controls.Add(dgvListaUsuarios);
            Controls.Add(dgvListaProductos);
            Controls.Add(lblUsuarios);
            Controls.Add(lblProductos);
            Controls.Add(lblListado);
            Controls.Add(pTimer);
            Controls.Add(lvlVistaPreviaHistorial);
            Controls.Add(rtbHistorial);
            Controls.Add(lblHistorial);
            Controls.Add(botonGenerarHistorial);
            Controls.Add(rtbSalidaSerializado);
            Controls.Add(lblSalidaSerializado);
            Controls.Add(botonDeSerializarXML);
            Controls.Add(botonSerializarXML);
            Controls.Add(botonDeSerializarJSON);
            Controls.Add(botonSerializarJSON);
            Controls.Add(cbProductos);
            Controls.Add(lblBuscarProductos);
            Controls.Add(lblTituloProgramador);
            Controls.Add(pUsuario);
            Controls.Add(lblCerrarSesion);
            Controls.Add(pbLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "FormProgramador";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormProgramador";
            FormClosing += FormProgramador_Closing;
            Load += FormProgramador_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pUsuario.ResumeLayout(false);
            pUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoUsuario).EndInit();
            pTimer.ResumeLayout(false);
            pTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pUsuario;
        private System.Windows.Forms.PictureBox pbLogoUsuario;
        private System.Windows.Forms.Label lblNombreProgramador;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Label lblTituloProgramador;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label lblBuscarProductos;
        private System.Windows.Forms.Button botonSerializarJSON;
        private System.Windows.Forms.Button botonDeSerializarJSON;
        private System.Windows.Forms.Button botonSerializarXML;
        private System.Windows.Forms.Button botonDeSerializarXML;
        private System.Windows.Forms.Label lblSalidaSerializado;
        private System.Windows.Forms.RichTextBox rtbSalidaSerializado;
        private System.Windows.Forms.Button botonGenerarHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.RichTextBox rtbHistorial;
        private System.Windows.Forms.Label lvlVistaPreviaHistorial;
        private System.Windows.Forms.Panel pTimer;
        private System.Windows.Forms.RichTextBox rtbSegundos;
        private System.Windows.Forms.RichTextBox rtbMinutos;
        private System.Windows.Forms.RichTextBox rtbHoras;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timerTiempoSesion;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}