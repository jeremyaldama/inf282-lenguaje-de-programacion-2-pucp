namespace ULearn.Bibliotecario
{
    partial class frmAutoresLibro
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
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.bntQuitar = new System.Windows.Forms.Button();
            this.bntAgregar = new System.Windows.Forms.Button();
            this.gbAutorSeleccionado = new System.Windows.Forms.GroupBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.bntGuardar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            this.gbAutorSeleccionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panelSuperior.Controls.Add(this.lblSuperior);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(749, 62);
            this.panelSuperior.TabIndex = 1;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuperior.Location = new System.Drawing.Point(12, 9);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(242, 36);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "Lista de autores";
            // 
            // dgvAutor
            // 
            this.dgvAutor.AllowUserToAddRows = false;
            this.dgvAutor.AllowUserToDeleteRows = false;
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Nacionalidad});
            this.dgvAutor.Location = new System.Drawing.Point(18, 129);
            this.dgvAutor.MultiSelect = false;
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.ReadOnly = true;
            this.dgvAutor.RowHeadersWidth = 51;
            this.dgvAutor.RowTemplate.Height = 24;
            this.dgvAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutor.Size = new System.Drawing.Size(700, 169);
            this.dgvAutor.TabIndex = 6;
            this.dgvAutor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutor_CellDoubleClick);
            this.dgvAutor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAutor_CellFormatting);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.MinimumWidth = 6;
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            this.Nacionalidad.Width = 200;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(13, 85);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 25);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Autores del libro";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(403, 576);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(119, 32);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // bntQuitar
            // 
            this.bntQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(200)))), ((int)(((byte)(168)))));
            this.bntQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntQuitar.Location = new System.Drawing.Point(439, 161);
            this.bntQuitar.Name = "bntQuitar";
            this.bntQuitar.Size = new System.Drawing.Size(119, 35);
            this.bntQuitar.TabIndex = 17;
            this.bntQuitar.Text = "Quitar";
            this.bntQuitar.UseVisualStyleBackColor = false;
            this.bntQuitar.Click += new System.EventHandler(this.bntQuitar_Click);
            // 
            // bntAgregar
            // 
            this.bntAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(200)))), ((int)(((byte)(168)))));
            this.bntAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAgregar.Location = new System.Drawing.Point(573, 161);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(119, 35);
            this.bntAgregar.TabIndex = 19;
            this.bntAgregar.Text = "Agregar";
            this.bntAgregar.UseVisualStyleBackColor = false;
            this.bntAgregar.Click += new System.EventHandler(this.bntAgregar_Click);
            // 
            // gbAutorSeleccionado
            // 
            this.gbAutorSeleccionado.Controls.Add(this.bntBuscar);
            this.gbAutorSeleccionado.Controls.Add(this.txtNacionalidad);
            this.gbAutorSeleccionado.Controls.Add(this.txtNombre);
            this.gbAutorSeleccionado.Controls.Add(this.txtID);
            this.gbAutorSeleccionado.Controls.Add(this.lblNacionalidad);
            this.gbAutorSeleccionado.Controls.Add(this.lblNombre);
            this.gbAutorSeleccionado.Controls.Add(this.lblID);
            this.gbAutorSeleccionado.Controls.Add(this.bntQuitar);
            this.gbAutorSeleccionado.Controls.Add(this.bntAgregar);
            this.gbAutorSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAutorSeleccionado.Location = new System.Drawing.Point(18, 335);
            this.gbAutorSeleccionado.Name = "gbAutorSeleccionado";
            this.gbAutorSeleccionado.Size = new System.Drawing.Size(700, 220);
            this.gbAutorSeleccionado.TabIndex = 20;
            this.gbAutorSeleccionado.TabStop = false;
            this.gbAutorSeleccionado.Text = "Autor Seleccionado";
            // 
            // bntBuscar
            // 
            this.bntBuscar.BackgroundImage = global::ULearn.Properties.Resources.search;
            this.bntBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntBuscar.Location = new System.Drawing.Point(342, 35);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(39, 27);
            this.bntBuscar.TabIndex = 26;
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Enabled = false;
            this.txtNacionalidad.Location = new System.Drawing.Point(185, 113);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.ReadOnly = true;
            this.txtNacionalidad.Size = new System.Drawing.Size(254, 27);
            this.txtNacionalidad.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(185, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(486, 27);
            this.txtNombre.TabIndex = 24;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(185, 35);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(128, 27);
            this.txtID.TabIndex = 23;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(35, 116);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(110, 20);
            this.lblNacionalidad.TabIndex = 22;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(35, 38);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 20);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID:";
            // 
            // bntGuardar
            // 
            this.bntGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.bntGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntGuardar.Location = new System.Drawing.Point(539, 576);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(179, 32);
            this.bntGuardar.TabIndex = 21;
            this.bntGuardar.Text = "Guardar y salir";
            this.bntGuardar.UseVisualStyleBackColor = false;
            this.bntGuardar.Click += new System.EventHandler(this.bntGuardar_Click);
            // 
            // frmAutoresLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(749, 620);
            this.Controls.Add(this.bntGuardar);
            this.Controls.Add(this.gbAutorSeleccionado);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvAutor);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmAutoresLibro";
            this.Text = "frmAutoresLibro";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            this.gbAutorSeleccionado.ResumeLayout(false);
            this.gbAutorSeleccionado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.DataGridView dgvAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button bntQuitar;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.GroupBox gbAutorSeleccionado;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.Button bntGuardar;
    }
}