namespace ULearn.Docente
{
    partial class frmEventos
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
            this.lblBuscarEventos = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gboFiltros = new System.Windows.Forms.GroupBox();
            this.cbCharla = new System.Windows.Forms.CheckBox();
            this.cbTaller = new System.Windows.Forms.CheckBox();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.gboFiltros.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelSuperior.Controls.Add(this.lblBuscarEventos);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1102, 49);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblBuscarEventos
            // 
            this.lblBuscarEventos.AutoSize = true;
            this.lblBuscarEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblBuscarEventos.Location = new System.Drawing.Point(15, 0);
            this.lblBuscarEventos.Name = "lblBuscarEventos";
            this.lblBuscarEventos.Size = new System.Drawing.Size(254, 37);
            this.lblBuscarEventos.TabIndex = 0;
            this.lblBuscarEventos.Text = "Buscar Eventos";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dtpDesde.Location = new System.Drawing.Point(81, 51);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(362, 26);
            this.dtpDesde.TabIndex = 1;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFechaInicial.Location = new System.Drawing.Point(6, 52);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(75, 25);
            this.lblFechaInicial.TabIndex = 3;
            this.lblFechaInicial.Text = "Desde:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.btnFiltrar.Location = new System.Drawing.Point(90, 494);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(122, 35);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Aplicar filtros";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // gboFiltros
            // 
            this.gboFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboFiltros.Controls.Add(this.cbCharla);
            this.gboFiltros.Controls.Add(this.cbTaller);
            this.gboFiltros.Controls.Add(this.lblTipoEvento);
            this.gboFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.gboFiltros.Controls.Add(this.dtpDesde);
            this.gboFiltros.Controls.Add(this.btnFiltrar);
            this.gboFiltros.Controls.Add(this.lblFechaInicial);
            this.gboFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gboFiltros.Location = new System.Drawing.Point(12, 71);
            this.gboFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboFiltros.Name = "gboFiltros";
            this.gboFiltros.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboFiltros.Size = new System.Drawing.Size(470, 618);
            this.gboFiltros.TabIndex = 7;
            this.gboFiltros.TabStop = false;
            this.gboFiltros.Text = "Filtros";
            // 
            // cbCharla
            // 
            this.cbCharla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCharla.AutoSize = true;
            this.cbCharla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbCharla.Location = new System.Drawing.Point(183, 114);
            this.cbCharla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCharla.Name = "cbCharla";
            this.cbCharla.Size = new System.Drawing.Size(96, 29);
            this.cbCharla.TabIndex = 9;
            this.cbCharla.Text = "Charla";
            this.cbCharla.UseVisualStyleBackColor = true;
            // 
            // cbTaller
            // 
            this.cbTaller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTaller.AutoSize = true;
            this.cbTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTaller.Location = new System.Drawing.Point(90, 114);
            this.cbTaller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTaller.Name = "cbTaller";
            this.cbTaller.Size = new System.Drawing.Size(87, 29);
            this.cbTaller.TabIndex = 8;
            this.cbTaller.Text = "Taller";
            this.cbTaller.UseVisualStyleBackColor = true;
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipoEvento.Location = new System.Drawing.Point(6, 114);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(57, 25);
            this.lblTipoEvento.TabIndex = 7;
            this.lblTipoEvento.Text = "Tipo:";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(250, 494);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(122, 35);
            this.btnLimpiarFiltros.TabIndex = 6;
            this.btnLimpiarFiltros.Text = "Limpiar filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panelContenido.Controls.Add(this.lblMensaje);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContenido.Location = new System.Drawing.Point(487, 49);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(615, 649);
            this.panelContenido.TabIndex = 8;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMensaje.Location = new System.Drawing.Point(0, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(341, 26);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Por favor, aplique filtros de interés";
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 698);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.gboFiltros);
            this.Controls.Add(this.panelSuperior);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEventos";
            this.Text = "frmEventos";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.gboFiltros.ResumeLayout(false);
            this.gboFiltros.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox gboFiltros;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.CheckBox cbCharla;
        private System.Windows.Forms.CheckBox cbTaller;
        private System.Windows.Forms.Label lblBuscarEventos;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblMensaje;
    }
}