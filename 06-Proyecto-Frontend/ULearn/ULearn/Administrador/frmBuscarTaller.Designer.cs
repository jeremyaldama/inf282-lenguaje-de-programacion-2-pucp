namespace ULearn.Administrador
{
    partial class frmBuscarTaller
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
            this.dgvTaller = new System.Windows.Forms.DataGridView();
            this.IDTaller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEspacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organizador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsGratuito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscritos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaller)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panelContenido.Controls.Add(this.dgvTaller);
            this.panelContenido.Controls.Add(this.txtBusqueda);
            this.panelContenido.Controls.Add(this.btnBuscar);
            this.panelContenido.Controls.Add(this.panelSuperior);
            this.panelContenido.Controls.Add(this.btnSeleccionar);
            this.panelContenido.Controls.Add(this.lblBusqueda);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1077, 450);
            this.panelContenido.TabIndex = 16;
            // 
            // dgvTaller
            // 
            this.dgvTaller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTaller,
            this.Nombre,
            this.IDEspacio,
            this.Organizador,
            this.Fecha,
            this.HoraInicio,
            this.HoraFin,
            this.EsGratuito,
            this.Inscritos,
            this.AreaInteres});
            this.dgvTaller.Location = new System.Drawing.Point(33, 134);
            this.dgvTaller.Name = "dgvTaller";
            this.dgvTaller.RowHeadersWidth = 51;
            this.dgvTaller.RowTemplate.Height = 24;
            this.dgvTaller.Size = new System.Drawing.Size(997, 226);
            this.dgvTaller.TabIndex = 30;
            this.dgvTaller.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTaller_CellFormatting);
            // 
            // IDTaller
            // 
            this.IDTaller.Frozen = true;
            this.IDTaller.HeaderText = "ID Taller";
            this.IDTaller.MinimumWidth = 6;
            this.IDTaller.Name = "IDTaller";
            this.IDTaller.Width = 75;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // IDEspacio
            // 
            this.IDEspacio.Frozen = true;
            this.IDEspacio.HeaderText = "Nombre Espacio";
            this.IDEspacio.MinimumWidth = 6;
            this.IDEspacio.Name = "IDEspacio";
            this.IDEspacio.Width = 125;
            // 
            // Organizador
            // 
            this.Organizador.Frozen = true;
            this.Organizador.HeaderText = "Organizador";
            this.Organizador.MinimumWidth = 6;
            this.Organizador.Name = "Organizador";
            this.Organizador.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.Frozen = true;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // HoraInicio
            // 
            this.HoraInicio.Frozen = true;
            this.HoraInicio.HeaderText = "Hora de Inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Width = 125;
            // 
            // HoraFin
            // 
            this.HoraFin.Frozen = true;
            this.HoraFin.HeaderText = "Hora de Fin";
            this.HoraFin.MinimumWidth = 6;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 125;
            // 
            // EsGratuito
            // 
            this.EsGratuito.Frozen = true;
            this.EsGratuito.HeaderText = "Es Gratuito";
            this.EsGratuito.MinimumWidth = 6;
            this.EsGratuito.Name = "EsGratuito";
            this.EsGratuito.Width = 125;
            // 
            // Inscritos
            // 
            this.Inscritos.Frozen = true;
            this.Inscritos.HeaderText = "Inscritos";
            this.Inscritos.MinimumWidth = 6;
            this.Inscritos.Name = "Inscritos";
            this.Inscritos.Width = 125;
            // 
            // AreaInteres
            // 
            this.AreaInteres.HeaderText = "Área de Interés";
            this.AreaInteres.MinimumWidth = 6;
            this.AreaInteres.Name = "AreaInteres";
            this.AreaInteres.Width = 125;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusqueda.Location = new System.Drawing.Point(269, 83);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(646, 30);
            this.txtBusqueda.TabIndex = 27;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Noto Sans Cond", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(940, 83);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 30);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1077, 65);
            this.panelSuperior.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda de Talleres";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Noto Sans Cond", 8F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionar.Location = new System.Drawing.Point(919, 380);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(111, 30);
            this.btnSeleccionar.TabIndex = 24;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.lblBusqueda.Location = new System.Drawing.Point(30, 90);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(201, 32);
            this.lblBusqueda.TabIndex = 20;
            this.lblBusqueda.Text = "Ingrese el nombre del taller:\r\n\r\n";
            // 
            // frmBuscarTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.panelContenido);
            this.Name = "frmBuscarTaller";
            this.Text = "frmBuscarTaller";
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaller)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridView dgvTaller;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTaller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEspacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsGratuito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscritos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaInteres;
    }
}