namespace ULearn.Administrador
{
    partial class frmNuevaCarrera
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
            this.tspHerramientasCarreras = new System.Windows.Forms.ToolStrip();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblRegistroCarrera = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gboInfoCarrera = new System.Windows.Forms.GroupBox();
            this.lblIDCarrera = new System.Windows.Forms.Label();
            this.txtIDCarrera = new System.Windows.Forms.TextBox();
            this.dtpUltimoCambioMalla = new System.Windows.Forms.DateTimePicker();
            this.rbNoAcreditada = new System.Windows.Forms.RadioButton();
            this.rbSiAcreditada = new System.Windows.Forms.RadioButton();
            this.lblCréditos = new System.Windows.Forms.Label();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAcreditada = new System.Windows.Forms.Label();
            this.lblUltimoCambioMalla = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cboFacultad = new System.Windows.Forms.ComboBox();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarCarrera = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.lblFacultad = new System.Windows.Forms.Label();
            this.panelContenido.SuspendLayout();
            this.tspHerramientasCarreras.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.gboInfoCarrera.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.tspHerramientasCarreras);
            this.panelContenido.Controls.Add(this.panelSuperior);
            this.panelContenido.Controls.Add(this.btnCancelar);
            this.panelContenido.Controls.Add(this.btnGuardar);
            this.panelContenido.Controls.Add(this.gboInfoCarrera);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(800, 450);
            this.panelContenido.TabIndex = 0;
            // 
            // tspHerramientasCarreras
            // 
            this.tspHerramientasCarreras.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tspHerramientasCarreras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBuscarCarrera,
            this.tsbEliminar,
            this.tsbEditar});
            this.tspHerramientasCarreras.Location = new System.Drawing.Point(0, 65);
            this.tspHerramientasCarreras.Name = "tspHerramientasCarreras";
            this.tspHerramientasCarreras.Size = new System.Drawing.Size(800, 31);
            this.tspHerramientasCarreras.Stretch = true;
            this.tspHerramientasCarreras.TabIndex = 65;
            this.tspHerramientasCarreras.Text = "toolStrip1";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panelSuperior.Controls.Add(this.lblRegistroCarrera);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 65);
            this.panelSuperior.TabIndex = 64;
            // 
            // lblRegistroCarrera
            // 
            this.lblRegistroCarrera.AutoSize = true;
            this.lblRegistroCarrera.Font = new System.Drawing.Font("Noto Sans Cond", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegistroCarrera.ForeColor = System.Drawing.Color.White;
            this.lblRegistroCarrera.Location = new System.Drawing.Point(21, 14);
            this.lblRegistroCarrera.Name = "lblRegistroCarrera";
            this.lblRegistroCarrera.Size = new System.Drawing.Size(246, 37);
            this.lblRegistroCarrera.TabIndex = 0;
            this.lblRegistroCarrera.Text = "Registro de Carreras";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(282, 390);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 34);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(121, 390);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 34);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gboInfoCarrera
            // 
            this.gboInfoCarrera.BackColor = System.Drawing.Color.White;
            this.gboInfoCarrera.Controls.Add(this.lblFacultad);
            this.gboInfoCarrera.Controls.Add(this.cboFacultad);
            this.gboInfoCarrera.Controls.Add(this.lblIDCarrera);
            this.gboInfoCarrera.Controls.Add(this.txtIDCarrera);
            this.gboInfoCarrera.Controls.Add(this.dtpUltimoCambioMalla);
            this.gboInfoCarrera.Controls.Add(this.rbNoAcreditada);
            this.gboInfoCarrera.Controls.Add(this.rbSiAcreditada);
            this.gboInfoCarrera.Controls.Add(this.lblCréditos);
            this.gboInfoCarrera.Controls.Add(this.txtCreditos);
            this.gboInfoCarrera.Controls.Add(this.txtNombre);
            this.gboInfoCarrera.Controls.Add(this.lblAcreditada);
            this.gboInfoCarrera.Controls.Add(this.lblUltimoCambioMalla);
            this.gboInfoCarrera.Controls.Add(this.lblNombre);
            this.gboInfoCarrera.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboInfoCarrera.Location = new System.Drawing.Point(12, 107);
            this.gboInfoCarrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoCarrera.Name = "gboInfoCarrera";
            this.gboInfoCarrera.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoCarrera.Size = new System.Drawing.Size(505, 263);
            this.gboInfoCarrera.TabIndex = 61;
            this.gboInfoCarrera.TabStop = false;
            this.gboInfoCarrera.Text = "Información de la Carrera";
            // 
            // lblIDCarrera
            // 
            this.lblIDCarrera.AutoSize = true;
            this.lblIDCarrera.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblIDCarrera.Location = new System.Drawing.Point(12, 51);
            this.lblIDCarrera.Name = "lblIDCarrera";
            this.lblIDCarrera.Size = new System.Drawing.Size(67, 19);
            this.lblIDCarrera.TabIndex = 13;
            this.lblIDCarrera.Text = "ID Carrera:";
            // 
            // txtIDCarrera
            // 
            this.txtIDCarrera.Enabled = false;
            this.txtIDCarrera.Location = new System.Drawing.Point(173, 43);
            this.txtIDCarrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDCarrera.Name = "txtIDCarrera";
            this.txtIDCarrera.ReadOnly = true;
            this.txtIDCarrera.Size = new System.Drawing.Size(304, 30);
            this.txtIDCarrera.TabIndex = 12;
            // 
            // dtpUltimoCambioMalla
            // 
            this.dtpUltimoCambioMalla.CalendarFont = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.dtpUltimoCambioMalla.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.dtpUltimoCambioMalla.Location = new System.Drawing.Point(173, 111);
            this.dtpUltimoCambioMalla.Name = "dtpUltimoCambioMalla";
            this.dtpUltimoCambioMalla.Size = new System.Drawing.Size(304, 25);
            this.dtpUltimoCambioMalla.TabIndex = 28;
            // 
            // rbNoAcreditada
            // 
            this.rbNoAcreditada.AutoSize = true;
            this.rbNoAcreditada.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbNoAcreditada.Location = new System.Drawing.Point(270, 224);
            this.rbNoAcreditada.Name = "rbNoAcreditada";
            this.rbNoAcreditada.Size = new System.Drawing.Size(43, 22);
            this.rbNoAcreditada.TabIndex = 10;
            this.rbNoAcreditada.TabStop = true;
            this.rbNoAcreditada.Text = "No";
            this.rbNoAcreditada.UseVisualStyleBackColor = true;
            // 
            // rbSiAcreditada
            // 
            this.rbSiAcreditada.AutoSize = true;
            this.rbSiAcreditada.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbSiAcreditada.Location = new System.Drawing.Point(173, 224);
            this.rbSiAcreditada.Name = "rbSiAcreditada";
            this.rbSiAcreditada.Size = new System.Drawing.Size(38, 22);
            this.rbSiAcreditada.TabIndex = 9;
            this.rbSiAcreditada.TabStop = true;
            this.rbSiAcreditada.Text = "Sí";
            this.rbSiAcreditada.UseVisualStyleBackColor = true;
            // 
            // lblCréditos
            // 
            this.lblCréditos.AutoSize = true;
            this.lblCréditos.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblCréditos.Location = new System.Drawing.Point(13, 149);
            this.lblCréditos.Name = "lblCréditos";
            this.lblCréditos.Size = new System.Drawing.Size(56, 19);
            this.lblCréditos.TabIndex = 9;
            this.lblCréditos.Text = "Créditos:";
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(173, 142);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(304, 30);
            this.txtCreditos.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(304, 30);
            this.txtNombre.TabIndex = 19;
            // 
            // lblAcreditada
            // 
            this.lblAcreditada.AutoSize = true;
            this.lblAcreditada.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblAcreditada.Location = new System.Drawing.Point(13, 224);
            this.lblAcreditada.Name = "lblAcreditada";
            this.lblAcreditada.Size = new System.Drawing.Size(101, 19);
            this.lblAcreditada.TabIndex = 2;
            this.lblAcreditada.Text = "¿Está acreditada?:";
            // 
            // lblUltimoCambioMalla
            // 
            this.lblUltimoCambioMalla.AutoSize = true;
            this.lblUltimoCambioMalla.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblUltimoCambioMalla.Location = new System.Drawing.Point(12, 118);
            this.lblUltimoCambioMalla.Name = "lblUltimoCambioMalla";
            this.lblUltimoCambioMalla.Size = new System.Drawing.Size(138, 19);
            this.lblUltimoCambioMalla.TabIndex = 1;
            this.lblUltimoCambioMalla.Text = "Último cambio de malla:\r\n";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblNombre.Location = new System.Drawing.Point(12, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // cboFacultad
            // 
            this.cboFacultad.FormattingEnabled = true;
            this.cboFacultad.Location = new System.Drawing.Point(173, 178);
            this.cboFacultad.Name = "cboFacultad";
            this.cboFacultad.Size = new System.Drawing.Size(304, 31);
            this.cboFacultad.TabIndex = 66;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbNuevo.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbNuevo.Image = global::ULearn.Properties.Resources.new_document;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(82, 28);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBuscarCarrera
            // 
            this.tsbBuscarCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbBuscarCarrera.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbBuscarCarrera.Image = global::ULearn.Properties.Resources.search;
            this.tsbBuscarCarrera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarCarrera.Name = "tsbBuscarCarrera";
            this.tsbBuscarCarrera.Size = new System.Drawing.Size(139, 28);
            this.tsbBuscarCarrera.Text = "Buscar Carrera";
            this.tsbBuscarCarrera.Click += new System.EventHandler(this.tsbBuscarCarrera_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbEliminar.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbEliminar.Image = global::ULearn.Properties.Resources.delete;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(94, 28);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbEditar.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbEditar.Image = global::ULearn.Properties.Resources.edit;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(77, 28);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // lblFacultad
            // 
            this.lblFacultad.AutoSize = true;
            this.lblFacultad.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblFacultad.Location = new System.Drawing.Point(13, 185);
            this.lblFacultad.Name = "lblFacultad";
            this.lblFacultad.Size = new System.Drawing.Size(59, 19);
            this.lblFacultad.TabIndex = 67;
            this.lblFacultad.Text = "Facultad: ";
            // 
            // frmNuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Name = "frmNuevaCarrera";
            this.Text = "frmNuevaCarrera";
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.tspHerramientasCarreras.ResumeLayout(false);
            this.tspHerramientasCarreras.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.gboInfoCarrera.ResumeLayout(false);
            this.gboInfoCarrera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.ToolStrip tspHerramientasCarreras;
        private System.Windows.Forms.ToolStripButton tsbBuscarCarrera;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblRegistroCarrera;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gboInfoCarrera;
        private System.Windows.Forms.Label lblIDCarrera;
        private System.Windows.Forms.TextBox txtIDCarrera;
        private System.Windows.Forms.DateTimePicker dtpUltimoCambioMalla;
        private System.Windows.Forms.RadioButton rbNoAcreditada;
        private System.Windows.Forms.RadioButton rbSiAcreditada;
        private System.Windows.Forms.Label lblCréditos;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAcreditada;
        private System.Windows.Forms.Label lblUltimoCambioMalla;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ComboBox cboFacultad;
        private System.Windows.Forms.Label lblFacultad;
    }
}