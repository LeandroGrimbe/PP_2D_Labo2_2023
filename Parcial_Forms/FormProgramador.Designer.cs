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
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoUsuario).BeginInit();
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
            pUsuario.Location = new System.Drawing.Point(724, -1);
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
            lblCerrarSesion.Location = new System.Drawing.Point(854, 59);
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
            lblTituloProgramador.Location = new System.Drawing.Point(367, 70);
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
            cbProductos.Location = new System.Drawing.Point(51, 241);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new System.Drawing.Size(378, 23);
            cbProductos.TabIndex = 98;
            // 
            // lblBuscarProductos
            // 
            lblBuscarProductos.AutoSize = true;
            lblBuscarProductos.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBuscarProductos.ForeColor = System.Drawing.Color.Black;
            lblBuscarProductos.Location = new System.Drawing.Point(31, 211);
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
            lblHistorial.Location = new System.Drawing.Point(631, 211);
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
            // FormProgramador
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Honeydew;
            ClientSize = new System.Drawing.Size(939, 711);
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
            Name = "FormProgramador";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormProgramador";
            FormClosing += FormProgramador_Closing;
            Load += FormProgramador_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pUsuario.ResumeLayout(false);
            pUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoUsuario).EndInit();
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
    }
}