namespace ULearn.Administrador
{
    partial class frmNuevoSemestre
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
            this.lblRegistroHorario = new System.Windows.Forms.Label();
            this.tspHerramientasHorarios = new System.Windows.Forms.ToolStrip();
            this.gboInfoSemestre = new System.Windows.Forms.GroupBox();
            this.txtIDSemestre = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.rbNoRegular = new System.Windows.Forms.RadioButton();
            this.rbSiRegular = new System.Windows.Forms.RadioButton();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblIDSemestre = new System.Windows.Forms.Label();
            this.lblRegular = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarSemestre = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelSuperior.SuspendLayout();
            this.tspHerramientasHorarios.SuspendLayout();
            this.gboInfoSemestre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panelSuperior.Controls.Add(this.lblRegistroHorario);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 65);
            this.panelSuperior.TabIndex = 51;
            // 
            // lblRegistroHorario
            // 
            this.lblRegistroHorario.AutoSize = true;
            this.lblRegistroHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegistroHorario.ForeColor = System.Drawing.Color.White;
            this.lblRegistroHorario.Location = new System.Drawing.Point(21, 14);
            this.lblRegistroHorario.Name = "lblRegistroHorario";
            this.lblRegistroHorario.Size = new System.Drawing.Size(311, 31);
            this.lblRegistroHorario.TabIndex = 0;
            this.lblRegistroHorario.Text = "Registro de Semestres";
            // 
            // tspHerramientasHorarios
            // 
            this.tspHerramientasHorarios.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tspHerramientasHorarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBuscarSemestre,
            this.tsbEliminar,
            this.tsbEditar});
            this.tspHerramientasHorarios.Location = new System.Drawing.Point(0, 65);
            this.tspHerramientasHorarios.Name = "tspHerramientasHorarios";
            this.tspHerramientasHorarios.Size = new System.Drawing.Size(800, 31);
            this.tspHerramientasHorarios.Stretch = true;
            this.tspHerramientasHorarios.TabIndex = 58;
            this.tspHerramientasHorarios.Text = "toolStrip1";
            // 
            // gboInfoSemestre
            // 
            this.gboInfoSemestre.BackColor = System.Drawing.Color.Transparent;
            this.gboInfoSemestre.Controls.Add(this.txtNombre);
            this.gboInfoSemestre.Controls.Add(this.label1);
            this.gboInfoSemestre.Controls.Add(this.lblFechaFin);
            this.gboInfoSemestre.Controls.Add(this.rbNoRegular);
            this.gboInfoSemestre.Controls.Add(this.lblIDSemestre);
            this.gboInfoSemestre.Controls.Add(this.rbSiRegular);
            this.gboInfoSemestre.Controls.Add(this.lblRegular);
            this.gboInfoSemestre.Controls.Add(this.dtpFechaFin);
            this.gboInfoSemestre.Controls.Add(this.lblFechaInicio);
            this.gboInfoSemestre.Controls.Add(this.dtpFechaInicio);
            this.gboInfoSemestre.Controls.Add(this.txtIDSemestre);
            this.gboInfoSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gboInfoSemestre.Location = new System.Drawing.Point(27, 112);
            this.gboInfoSemestre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoSemestre.Name = "gboInfoSemestre";
            this.gboInfoSemestre.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoSemestre.Size = new System.Drawing.Size(455, 240);
            this.gboInfoSemestre.TabIndex = 59;
            this.gboInfoSemestre.TabStop = false;
            this.gboInfoSemestre.Text = "Información del Semestre";
            // 
            // txtIDSemestre
            // 
            this.txtIDSemestre.Enabled = false;
            this.txtIDSemestre.Location = new System.Drawing.Point(173, 43);
            this.txtIDSemestre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDSemestre.Name = "txtIDSemestre";
            this.txtIDSemestre.ReadOnly = true;
            this.txtIDSemestre.Size = new System.Drawing.Size(215, 26);
            this.txtIDSemestre.TabIndex = 12;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(173, 112);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(215, 24);
            this.dtpFechaInicio.TabIndex = 14;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(173, 147);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(215, 24);
            this.dtpFechaFin.TabIndex = 15;
            // 
            // rbNoRegular
            // 
            this.rbNoRegular.AutoSize = true;
            this.rbNoRegular.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbNoRegular.Location = new System.Drawing.Point(235, 180);
            this.rbNoRegular.Name = "rbNoRegular";
            this.rbNoRegular.Size = new System.Drawing.Size(43, 22);
            this.rbNoRegular.TabIndex = 58;
            this.rbNoRegular.TabStop = true;
            this.rbNoRegular.Text = "No";
            this.rbNoRegular.UseVisualStyleBackColor = true;
            // 
            // rbSiRegular
            // 
            this.rbSiRegular.AutoSize = true;
            this.rbSiRegular.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbSiRegular.Location = new System.Drawing.Point(173, 180);
            this.rbSiRegular.Name = "rbSiRegular";
            this.rbSiRegular.Size = new System.Drawing.Size(38, 22);
            this.rbSiRegular.TabIndex = 57;
            this.rbSiRegular.TabStop = true;
            this.rbSiRegular.Text = "Sí";
            this.rbSiRegular.UseVisualStyleBackColor = true;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblFechaFin.Location = new System.Drawing.Point(18, 147);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(77, 19);
            this.lblFechaFin.TabIndex = 62;
            this.lblFechaFin.Text = "Fecha de Fin:";
            // 
            // lblIDSemestre
            // 
            this.lblIDSemestre.AutoSize = true;
            this.lblIDSemestre.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblIDSemestre.Location = new System.Drawing.Point(18, 47);
            this.lblIDSemestre.Name = "lblIDSemestre";
            this.lblIDSemestre.Size = new System.Drawing.Size(76, 19);
            this.lblIDSemestre.TabIndex = 63;
            this.lblIDSemestre.Text = "ID Semestre:";
            // 
            // lblRegular
            // 
            this.lblRegular.AutoSize = true;
            this.lblRegular.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblRegular.Location = new System.Drawing.Point(18, 180);
            this.lblRegular.Name = "lblRegular";
            this.lblRegular.Size = new System.Drawing.Size(75, 19);
            this.lblRegular.TabIndex = 61;
            this.lblRegular.Text = "¿Es regular? ";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblFechaInicio.Location = new System.Drawing.Point(18, 112);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(90, 19);
            this.lblFechaInicio.TabIndex = 60;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(274, 371);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 34);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(113, 371);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 34);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tsbNuevo.Image = global::ULearn.Properties.Resources.new_document;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(79, 28);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBuscarSemestre
            // 
            this.tsbBuscarSemestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbBuscarSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tsbBuscarSemestre.Image = global::ULearn.Properties.Resources.search;
            this.tsbBuscarSemestre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarSemestre.Name = "tsbBuscarSemestre";
            this.tsbBuscarSemestre.Size = new System.Drawing.Size(151, 28);
            this.tsbBuscarSemestre.Text = "Buscar Semestre";
            this.tsbBuscarSemestre.Click += new System.EventHandler(this.tsbBuscarSemestre_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tsbEliminar.Image = global::ULearn.Properties.Resources.delete;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(89, 28);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tsbEditar.Image = global::ULearn.Properties.Resources.edit;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(74, 28);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(215, 26);
            this.txtNombre.TabIndex = 62;
            // 
            // frmNuevoSemestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gboInfoSemestre);
            this.Controls.Add(this.tspHerramientasHorarios);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmNuevoSemestre";
            this.Text = "frmNuevoSemestre";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.tspHerramientasHorarios.ResumeLayout(false);
            this.tspHerramientasHorarios.PerformLayout();
            this.gboInfoSemestre.ResumeLayout(false);
            this.gboInfoSemestre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblRegistroHorario;
        private System.Windows.Forms.ToolStrip tspHerramientasHorarios;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBuscarSemestre;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.GroupBox gboInfoSemestre;
        private System.Windows.Forms.TextBox txtIDSemestre;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.RadioButton rbNoRegular;
        private System.Windows.Forms.RadioButton rbSiRegular;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblIDSemestre;
        private System.Windows.Forms.Label lblRegular;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}