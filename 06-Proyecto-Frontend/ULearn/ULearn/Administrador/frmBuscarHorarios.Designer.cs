namespace ULearn.Administrador
{
    partial class frmBuscarHorarios
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
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vacantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matriculados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoTolerancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContenido.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.panelSuperior);
            this.panelContenido.Controls.Add(this.btnSeleccionar);
            this.panelContenido.Controls.Add(this.txtBusqueda);
            this.panelContenido.Controls.Add(this.btnBuscar);
            this.panelContenido.Controls.Add(this.lblBusqueda);
            this.panelContenido.Controls.Add(this.dgvHorarios);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1163, 450);
            this.panelContenido.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1163, 65);
            this.panelSuperior.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda de Horarios";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Noto Sans Cond", 8F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionar.Location = new System.Drawing.Point(1034, 390);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(111, 30);
            this.btnSeleccionar.TabIndex = 30;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusqueda.Location = new System.Drawing.Point(263, 92);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(773, 30);
            this.txtBusqueda.TabIndex = 29;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Noto Sans Cond", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(1055, 92);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 30);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.lblBusqueda.Location = new System.Drawing.Point(28, 99);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(211, 16);
            this.lblBusqueda.TabIndex = 27;
            this.lblBusqueda.Text = "Ingrese el código del horario:";
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Curso,
            this.Dia,
            this.horaInicio,
            this.HoraFin,
            this.Vacantes,
            this.Matriculados,
            this.TiempoTolerancia,
            this.TipoHorario});
            this.dgvHorarios.Location = new System.Drawing.Point(16, 143);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.RowHeadersWidth = 51;
            this.dgvHorarios.RowTemplate.Height = 24;
            this.dgvHorarios.Size = new System.Drawing.Size(1129, 226);
            this.dgvHorarios.TabIndex = 26;
            this.dgvHorarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHorarios_CellFormatting);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Horario";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 75;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.MinimumWidth = 6;
            this.Curso.Name = "Curso";
            this.Curso.Width = 125;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            this.Dia.Width = 125;
            // 
            // horaInicio
            // 
            this.horaInicio.HeaderText = "Hora de Inicio";
            this.horaInicio.MinimumWidth = 6;
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.Width = 125;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora de Fin";
            this.HoraFin.MinimumWidth = 6;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 125;
            // 
            // Vacantes
            // 
            this.Vacantes.HeaderText = "Vacantes";
            this.Vacantes.MinimumWidth = 6;
            this.Vacantes.Name = "Vacantes";
            this.Vacantes.Width = 125;
            // 
            // Matriculados
            // 
            this.Matriculados.HeaderText = "Matriculados";
            this.Matriculados.MinimumWidth = 6;
            this.Matriculados.Name = "Matriculados";
            this.Matriculados.Width = 125;
            // 
            // TiempoTolerancia
            // 
            this.TiempoTolerancia.HeaderText = "Tiempo de Tolerancia";
            this.TiempoTolerancia.MinimumWidth = 6;
            this.TiempoTolerancia.Name = "TiempoTolerancia";
            this.TiempoTolerancia.Width = 125;
            // 
            // TipoHorario
            // 
            this.TipoHorario.HeaderText = "Tipo de Horario";
            this.TipoHorario.MinimumWidth = 6;
            this.TipoHorario.Name = "TipoHorario";
            this.TipoHorario.Width = 125;
            // 
            // frmBuscarHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1163, 450);
            this.Controls.Add(this.panelContenido);
            this.Name = "frmBuscarHorarios";
            this.Text = "formGestionarHorarios";
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matriculados;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoTolerancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoHorario;
    }
}