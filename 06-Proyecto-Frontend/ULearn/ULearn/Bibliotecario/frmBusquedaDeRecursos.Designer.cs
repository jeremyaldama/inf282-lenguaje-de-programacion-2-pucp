namespace ULearn.Bibliotecario
{
    partial class frmBusquedaRecursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtTituloAutor = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboLibro = new System.Windows.Forms.CheckBox();
            this.cboDigital = new System.Windows.Forms.CheckBox();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.cboNoDisponible = new System.Windows.Forms.CheckBox();
            this.cboDisponible = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblBib = new System.Windows.Forms.Label();
            this.cboBiblioteca = new System.Windows.Forms.ComboBox();
            this.IDRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biblioteca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panelSuperior.Controls.Add(this.lblSuperior);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1150, 62);
            this.panelSuperior.TabIndex = 1;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuperior.Location = new System.Drawing.Point(12, 9);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(346, 36);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "Búsqueda de Recursos";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(23, 81);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(291, 20);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Ingrese el título o el nombre del autor:";
            // 
            // txtTituloAutor
            // 
            this.txtTituloAutor.Location = new System.Drawing.Point(373, 81);
            this.txtTituloAutor.Name = "txtTituloAutor";
            this.txtTituloAutor.Size = new System.Drawing.Size(765, 22);
            this.txtTituloAutor.TabIndex = 5;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(657, 121);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(131, 20);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo de recurso:";
            // 
            // cboLibro
            // 
            this.cboLibro.AutoSize = true;
            this.cboLibro.Checked = true;
            this.cboLibro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLibro.Location = new System.Drawing.Point(811, 121);
            this.cboLibro.Name = "cboLibro";
            this.cboLibro.Size = new System.Drawing.Size(63, 22);
            this.cboLibro.TabIndex = 7;
            this.cboLibro.Text = "Libro";
            this.cboLibro.UseVisualStyleBackColor = true;
            // 
            // cboDigital
            // 
            this.cboDigital.AutoSize = true;
            this.cboDigital.Checked = true;
            this.cboDigital.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDigital.Location = new System.Drawing.Point(811, 151);
            this.cboDigital.Name = "cboDigital";
            this.cboDigital.Size = new System.Drawing.Size(131, 22);
            this.cboDigital.TabIndex = 8;
            this.cboDigital.Text = "Recurso Digital";
            this.cboDigital.UseVisualStyleBackColor = true;
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.Location = new System.Drawing.Point(458, 125);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(93, 20);
            this.lblDisponible.TabIndex = 9;
            this.lblDisponible.Text = "Disponible:";
            // 
            // cboNoDisponible
            // 
            this.cboNoDisponible.AutoSize = true;
            this.cboNoDisponible.Checked = true;
            this.cboNoDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboNoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNoDisponible.Location = new System.Drawing.Point(569, 151);
            this.cboNoDisponible.Name = "cboNoDisponible";
            this.cboNoDisponible.Size = new System.Drawing.Size(50, 22);
            this.cboNoDisponible.TabIndex = 11;
            this.cboNoDisponible.Text = "No";
            this.cboNoDisponible.UseVisualStyleBackColor = true;
            // 
            // cboDisponible
            // 
            this.cboDisponible.AutoSize = true;
            this.cboDisponible.Checked = true;
            this.cboDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDisponible.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboDisponible.Location = new System.Drawing.Point(569, 123);
            this.cboDisponible.Name = "cboDisponible";
            this.cboDisponible.Size = new System.Drawing.Size(43, 22);
            this.cboDisponible.TabIndex = 10;
            this.cboDisponible.Text = "Sí";
            this.cboDisponible.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1017, 477);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 33);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Location = new System.Drawing.Point(1017, 151);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 35);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRecurso,
            this.Titulo,
            this.NombreAutor,
            this.TipoRecurso,
            this.Biblioteca,
            this.Disponible});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecursos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecursos.Location = new System.Drawing.Point(12, 204);
            this.dgvRecursos.Name = "dgvRecursos";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRecursos.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRecursos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRecursos.RowTemplate.Height = 30;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(1126, 262);
            this.dgvRecursos.TabIndex = 14;
            this.dgvRecursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecursos_CellClick);
            this.dgvRecursos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecursos_CellFormatting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSeleccionar.Location = new System.Drawing.Point(881, 477);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(121, 33);
            this.btnSeleccionar.TabIndex = 15;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblBib
            // 
            this.lblBib.AutoSize = true;
            this.lblBib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBib.Location = new System.Drawing.Point(23, 123);
            this.lblBib.Name = "lblBib";
            this.lblBib.Size = new System.Drawing.Size(88, 20);
            this.lblBib.TabIndex = 16;
            this.lblBib.Text = "Biblioteca:";
            // 
            // cboBiblioteca
            // 
            this.cboBiblioteca.FormattingEnabled = true;
            this.cboBiblioteca.Location = new System.Drawing.Point(117, 121);
            this.cboBiblioteca.Name = "cboBiblioteca";
            this.cboBiblioteca.Size = new System.Drawing.Size(294, 24);
            this.cboBiblioteca.TabIndex = 17;
            // 
            // IDRecurso
            // 
            this.IDRecurso.HeaderText = "ID";
            this.IDRecurso.MinimumWidth = 6;
            this.IDRecurso.Name = "IDRecurso";
            this.IDRecurso.ReadOnly = true;
            this.IDRecurso.Width = 50;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 300;
            // 
            // NombreAutor
            // 
            this.NombreAutor.HeaderText = "Autor";
            this.NombreAutor.MinimumWidth = 6;
            this.NombreAutor.Name = "NombreAutor";
            this.NombreAutor.ReadOnly = true;
            this.NombreAutor.Width = 250;
            // 
            // TipoRecurso
            // 
            this.TipoRecurso.HeaderText = "Tipo";
            this.TipoRecurso.MinimumWidth = 6;
            this.TipoRecurso.Name = "TipoRecurso";
            this.TipoRecurso.ReadOnly = true;
            // 
            // Biblioteca
            // 
            this.Biblioteca.HeaderText = "Biblioteca";
            this.Biblioteca.MinimumWidth = 6;
            this.Biblioteca.Name = "Biblioteca";
            this.Biblioteca.ReadOnly = true;
            this.Biblioteca.Width = 300;
            // 
            // Disponible
            // 
            this.Disponible.HeaderText = "¿Disponible?";
            this.Disponible.MinimumWidth = 6;
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
            this.Disponible.Width = 120;
            // 
            // frmBusquedaRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 517);
            this.Controls.Add(this.cboBiblioteca);
            this.Controls.Add(this.lblBib);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvRecursos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cboNoDisponible);
            this.Controls.Add(this.cboDisponible);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.cboDigital);
            this.Controls.Add(this.cboLibro);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTituloAutor);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmBusquedaRecursos";
            this.Text = "frmBusquedaRecursos";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtTituloAutor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.CheckBox cboLibro;
        private System.Windows.Forms.CheckBox cboDigital;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.CheckBox cboNoDisponible;
        private System.Windows.Forms.CheckBox cboDisponible;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblBib;
        private System.Windows.Forms.ComboBox cboBiblioteca;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biblioteca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponible;
    }
}