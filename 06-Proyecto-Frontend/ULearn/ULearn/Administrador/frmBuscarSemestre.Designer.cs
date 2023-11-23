namespace ULearn.Administrador
{
    partial class frmBuscarSemestre
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSemestres = new System.Windows.Forms.DataGridView();
            this.IDSemestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemestres)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1065, 65);
            this.panelSuperior.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda de Semestres";
            // 
            // dgvSemestres
            // 
            this.dgvSemestres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSemestres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemestres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSemestre,
            this.Semestre,
            this.FechaInicio,
            this.FechaFin,
            this.Regular});
            this.dgvSemestres.Location = new System.Drawing.Point(18, 137);
            this.dgvSemestres.Name = "dgvSemestres";
            this.dgvSemestres.RowHeadersWidth = 51;
            this.dgvSemestres.RowTemplate.Height = 24;
            this.dgvSemestres.Size = new System.Drawing.Size(837, 180);
            this.dgvSemestres.TabIndex = 33;
            this.dgvSemestres.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSemestres_CellFormatting);
            // 
            // IDSemestre
            // 
            this.IDSemestre.HeaderText = "ID Semestre";
            this.IDSemestre.MinimumWidth = 6;
            this.IDSemestre.Name = "IDSemestre";
            this.IDSemestre.Width = 75;
            // 
            // Semestre
            // 
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.MinimumWidth = 6;
            this.Semestre.Name = "Semestre";
            this.Semestre.Width = 125;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha de Inicio";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Width = 200;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha de Fin";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Width = 200;
            // 
            // Regular
            // 
            this.Regular.HeaderText = "¿Es regular? ";
            this.Regular.MinimumWidth = 6;
            this.Regular.Name = "Regular";
            this.Regular.Width = 125;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusqueda.Location = new System.Drawing.Point(278, 84);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(455, 30);
            this.txtBusqueda.TabIndex = 32;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Noto Sans Cond", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(765, 84);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 30);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Noto Sans Cond", 8F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionar.Location = new System.Drawing.Point(744, 336);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(111, 30);
            this.btnSeleccionar.TabIndex = 30;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.lblBusqueda.Location = new System.Drawing.Point(15, 91);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(230, 16);
            this.lblBusqueda.TabIndex = 29;
            this.lblBusqueda.Text = "Ingrese el nombre del semestre:";
            // 
            // frmBuscarSemestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.dgvSemestres);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.panelSuperior);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmBuscarSemestre";
            this.Text = "Form1";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemestres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSemestres;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSemestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regular;
    }
}