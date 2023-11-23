namespace ULearn.Administrador
{
    partial class frmNuevoCurso
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
            this.tspHerramientasHorarios = new System.Windows.Forms.ToolStrip();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblRegistroCursos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gboInfoCurso = new System.Windows.Forms.GroupBox();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.txtIDCurso = new System.Windows.Forms.TextBox();
            this.lblElectivo = new System.Windows.Forms.Label();
            this.rbNoElectivo = new System.Windows.Forms.RadioButton();
            this.rbSiElectivo = new System.Windows.Forms.RadioButton();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarCurso = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbCursoSemestre = new System.Windows.Forms.ToolStripButton();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContenido.SuspendLayout();
            this.tspHerramientasHorarios.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.gboInfoCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.tspHerramientasHorarios);
            this.panelContenido.Controls.Add(this.panelSuperior);
            this.panelContenido.Controls.Add(this.btnCancelar);
            this.panelContenido.Controls.Add(this.btnGuardar);
            this.panelContenido.Controls.Add(this.gboInfoCurso);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(800, 450);
            this.panelContenido.TabIndex = 62;
            // 
            // tspHerramientasHorarios
            // 
            this.tspHerramientasHorarios.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tspHerramientasHorarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBuscarCurso,
            this.tsbEliminar,
            this.tsbEditar,
            this.tsbCursoSemestre});
            this.tspHerramientasHorarios.Location = new System.Drawing.Point(0, 65);
            this.tspHerramientasHorarios.Name = "tspHerramientasHorarios";
            this.tspHerramientasHorarios.Size = new System.Drawing.Size(800, 31);
            this.tspHerramientasHorarios.Stretch = true;
            this.tspHerramientasHorarios.TabIndex = 63;
            this.tspHerramientasHorarios.Text = "toolStrip1";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panelSuperior.Controls.Add(this.lblRegistroCursos);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 65);
            this.panelSuperior.TabIndex = 62;
            // 
            // lblRegistroCursos
            // 
            this.lblRegistroCursos.AutoSize = true;
            this.lblRegistroCursos.Font = new System.Drawing.Font("Noto Sans Cond", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegistroCursos.ForeColor = System.Drawing.Color.White;
            this.lblRegistroCursos.Location = new System.Drawing.Point(21, 14);
            this.lblRegistroCursos.Name = "lblRegistroCursos";
            this.lblRegistroCursos.Size = new System.Drawing.Size(225, 37);
            this.lblRegistroCursos.TabIndex = 0;
            this.lblRegistroCursos.Text = "Registro de Cursos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(218, 405);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 34);
            this.btnCancelar.TabIndex = 57;
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
            this.btnGuardar.Location = new System.Drawing.Point(57, 405);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 34);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gboInfoCurso
            // 
            this.gboInfoCurso.BackColor = System.Drawing.Color.White;
            this.gboInfoCurso.Controls.Add(this.label2);
            this.gboInfoCurso.Controls.Add(this.lblElectivo);
            this.gboInfoCurso.Controls.Add(this.cboSemestre);
            this.gboInfoCurso.Controls.Add(this.lblIDCurso);
            this.gboInfoCurso.Controls.Add(this.rbNoElectivo);
            this.gboInfoCurso.Controls.Add(this.txtIDCurso);
            this.gboInfoCurso.Controls.Add(this.rbSiElectivo);
            this.gboInfoCurso.Controls.Add(this.lblCreditos);
            this.gboInfoCurso.Controls.Add(this.txtCreditos);
            this.gboInfoCurso.Controls.Add(this.txtCodigoCurso);
            this.gboInfoCurso.Controls.Add(this.txtNombre);
            this.gboInfoCurso.Controls.Add(this.lblCodigoCurso);
            this.gboInfoCurso.Controls.Add(this.lblNombre);
            this.gboInfoCurso.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboInfoCurso.Location = new System.Drawing.Point(12, 108);
            this.gboInfoCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoCurso.Name = "gboInfoCurso";
            this.gboInfoCurso.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoCurso.Size = new System.Drawing.Size(372, 262);
            this.gboInfoCurso.TabIndex = 55;
            this.gboInfoCurso.TabStop = false;
            this.gboInfoCurso.Text = "Información del Curso";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblIDCurso.Location = new System.Drawing.Point(12, 51);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(58, 19);
            this.lblIDCurso.TabIndex = 13;
            this.lblIDCurso.Text = "ID Curso:";
            // 
            // txtIDCurso
            // 
            this.txtIDCurso.Enabled = false;
            this.txtIDCurso.Location = new System.Drawing.Point(173, 43);
            this.txtIDCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDCurso.Name = "txtIDCurso";
            this.txtIDCurso.ReadOnly = true;
            this.txtIDCurso.Size = new System.Drawing.Size(179, 30);
            this.txtIDCurso.TabIndex = 12;
            // 
            // lblElectivo
            // 
            this.lblElectivo.AutoSize = true;
            this.lblElectivo.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblElectivo.Location = new System.Drawing.Point(13, 221);
            this.lblElectivo.Name = "lblElectivo";
            this.lblElectivo.Size = new System.Drawing.Size(76, 19);
            this.lblElectivo.TabIndex = 10;
            this.lblElectivo.Text = "¿Es electivo?:";
            // 
            // rbNoElectivo
            // 
            this.rbNoElectivo.AutoSize = true;
            this.rbNoElectivo.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbNoElectivo.Location = new System.Drawing.Point(229, 220);
            this.rbNoElectivo.Name = "rbNoElectivo";
            this.rbNoElectivo.Size = new System.Drawing.Size(43, 22);
            this.rbNoElectivo.TabIndex = 10;
            this.rbNoElectivo.TabStop = true;
            this.rbNoElectivo.Text = "No";
            this.rbNoElectivo.UseVisualStyleBackColor = true;
            // 
            // rbSiElectivo
            // 
            this.rbSiElectivo.AutoSize = true;
            this.rbSiElectivo.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbSiElectivo.Location = new System.Drawing.Point(172, 220);
            this.rbSiElectivo.Name = "rbSiElectivo";
            this.rbSiElectivo.Size = new System.Drawing.Size(38, 22);
            this.rbSiElectivo.TabIndex = 9;
            this.rbSiElectivo.TabStop = true;
            this.rbSiElectivo.Text = "Sí";
            this.rbSiElectivo.UseVisualStyleBackColor = true;
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblCreditos.Location = new System.Drawing.Point(12, 154);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(56, 19);
            this.lblCreditos.TabIndex = 9;
            this.lblCreditos.Text = "Créditos:";
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(173, 148);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(179, 30);
            this.txtCreditos.TabIndex = 7;
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.Location = new System.Drawing.Point(173, 113);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(179, 30);
            this.txtCodigoCurso.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 30);
            this.txtNombre.TabIndex = 6;
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblCodigoCurso.Location = new System.Drawing.Point(12, 120);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(101, 19);
            this.lblCodigoCurso.TabIndex = 2;
            this.lblCodigoCurso.Text = "Código del curso:";
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
            // tsbBuscarCurso
            // 
            this.tsbBuscarCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbBuscarCurso.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbBuscarCurso.Image = global::ULearn.Properties.Resources.search;
            this.tsbBuscarCurso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarCurso.Name = "tsbBuscarCurso";
            this.tsbBuscarCurso.Size = new System.Drawing.Size(128, 28);
            this.tsbBuscarCurso.Text = "Buscar Curso";
            this.tsbBuscarCurso.Click += new System.EventHandler(this.tsbBuscarCurso_Click);
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
            // tsbCursoSemestre
            // 
            this.tsbCursoSemestre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbCursoSemestre.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbCursoSemestre.Image = global::ULearn.Properties.Resources.horarios;
            this.tsbCursoSemestre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCursoSemestre.Name = "tsbCursoSemestre";
            this.tsbCursoSemestre.Size = new System.Drawing.Size(192, 28);
            this.tsbCursoSemestre.Text = "Aperturar en semestre";
            this.tsbCursoSemestre.Click += new System.EventHandler(this.tsbCursoSemestre_Click);
            // 
            // cboSemestre
            // 
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Location = new System.Drawing.Point(173, 183);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(179, 31);
            this.cboSemestre.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Semestre:";
            // 
            // frmNuevoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Name = "frmNuevoCurso";
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.tspHerramientasHorarios.ResumeLayout(false);
            this.tspHerramientasHorarios.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.gboInfoCurso.ResumeLayout(false);
            this.gboInfoCurso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gboInfoCurso;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.TextBox txtIDCurso;
        private System.Windows.Forms.Label lblElectivo;
        private System.Windows.Forms.RadioButton rbNoElectivo;
        private System.Windows.Forms.RadioButton rbSiElectivo;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStrip tspHerramientasHorarios;
        private System.Windows.Forms.ToolStripButton tsbBuscarCurso;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblRegistroCursos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbCursoSemestre;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.Label label2;
    }
}