namespace ULearn.Bibliotecario
{
    partial class frmBusquedaPrestamos
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnInspeccionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDeudor = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pboFoto = new System.Windows.Forms.PictureBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panelSuperior.Controls.Add(this.lblSuperior);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1228, 62);
            this.panelSuperior.TabIndex = 2;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuperior.Location = new System.Drawing.Point(12, 9);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(360, 36);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "Búsqueda de Préstamos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rol:";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSubTitulo.Location = new System.Drawing.Point(32, 231);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(274, 29);
            this.lblSubTitulo.TabIndex = 14;
            this.lblSubTitulo.Text = "Préstamos Realizados";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Título,
            this.Autor,
            this.Retiro,
            this.Devolucion,
            this.Estado});
            this.dgvPrestamos.Location = new System.Drawing.Point(37, 330);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(1142, 224);
            this.dgvPrestamos.TabIndex = 15;
            this.dgvPrestamos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPrestamos_CellFormatting);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Préstamo";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 75;
            // 
            // Título
            // 
            this.Título.HeaderText = "Título de libro";
            this.Título.MinimumWidth = 6;
            this.Título.Name = "Título";
            this.Título.ReadOnly = true;
            this.Título.Width = 300;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor(es)";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 250;
            // 
            // Retiro
            // 
            this.Retiro.HeaderText = "Fecha de Retiro";
            this.Retiro.MinimumWidth = 6;
            this.Retiro.Name = "Retiro";
            this.Retiro.ReadOnly = true;
            this.Retiro.Width = 180;
            // 
            // Devolucion
            // 
            this.Devolucion.HeaderText = "Fecha de Devolución";
            this.Devolucion.MinimumWidth = 6;
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.ReadOnly = true;
            this.Devolucion.Width = 180;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoEllipsis = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(33, 265);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(855, 47);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "Seleccione uno de los prestamos de la lista:";
            // 
            // btnInspeccionar
            // 
            this.btnInspeccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnInspeccionar.Enabled = false;
            this.btnInspeccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspeccionar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnInspeccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInspeccionar.Location = new System.Drawing.Point(1002, 578);
            this.btnInspeccionar.Name = "btnInspeccionar";
            this.btnInspeccionar.Size = new System.Drawing.Size(177, 36);
            this.btnInspeccionar.TabIndex = 17;
            this.btnInspeccionar.Text = "Inspeccionar";
            this.btnInspeccionar.UseVisualStyleBackColor = false;
            this.btnInspeccionar.Click += new System.EventHandler(this.btnInspeccionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDeudor);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pboFoto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 149);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario a verificar";
            // 
            // lblDeudor
            // 
            this.lblDeudor.AutoEllipsis = true;
            this.lblDeudor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeudor.Location = new System.Drawing.Point(359, 116);
            this.lblDeudor.Name = "lblDeudor";
            this.lblDeudor.Size = new System.Drawing.Size(492, 20);
            this.lblDeudor.TabIndex = 19;
            // 
            // lblRol
            // 
            this.lblRol.AutoEllipsis = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(359, 87);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(492, 20);
            this.lblRol.TabIndex = 18;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoEllipsis = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(359, 55);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(492, 20);
            this.lblApellido.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(359, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(492, 20);
            this.lblNombre.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Deudor:";
            // 
            // pboFoto
            // 
            this.pboFoto.Image = global::ULearn.Properties.Resources.user;
            this.pboFoto.Location = new System.Drawing.Point(36, 41);
            this.pboFoto.Name = "pboFoto";
            this.pboFoto.Size = new System.Drawing.Size(99, 83);
            this.pboFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFoto.TabIndex = 13;
            this.pboFoto.TabStop = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(1002, 141);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(164, 34);
            this.btnBuscarUsuario.TabIndex = 6;
            this.btnBuscarUsuario.Text = "Buscar Usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnFiltros
            // 
            this.btnFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltros.Location = new System.Drawing.Point(926, 265);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(99, 34);
            this.btnFiltros.TabIndex = 19;
            this.btnFiltros.Text = "Filtros";
            this.btnFiltros.UseVisualStyleBackColor = false;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(1031, 265);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(135, 34);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTerminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminar.Location = new System.Drawing.Point(1002, 184);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(164, 34);
            this.btnTerminar.TabIndex = 21;
            this.btnTerminar.Text = "Limpiar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // frmBusquedaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 617);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInspeccionar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmBusquedaPrestamos";
            this.Text = "frmBusquedaPrestamos";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboFoto;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnInspeccionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDeudor;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}