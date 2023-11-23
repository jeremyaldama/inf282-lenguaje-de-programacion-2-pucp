namespace ULearn.Administrador
{
    partial class frmNuevaSala
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarSala = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gboInfoSala = new System.Windows.Forms.GroupBox();
            this.txtTipoSala = new System.Windows.Forms.TextBox();
            this.rbNoSistemaAudio = new System.Windows.Forms.RadioButton();
            this.rbSiSistemaAudio = new System.Windows.Forms.RadioButton();
            this.lblTipoSala = new System.Windows.Forms.Label();
            this.lblSistemaAudio = new System.Windows.Forms.Label();
            this.gboInfoEspacio = new System.Windows.Forms.GroupBox();
            this.lblIDEspacio = new System.Windows.Forms.Label();
            this.lblAforo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDEspacio = new System.Windows.Forms.TextBox();
            this.txtAforo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.gboInfoSala.SuspendLayout();
            this.gboInfoEspacio.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBuscarSala,
            this.tsbEditar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(722, 31);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 76;
            this.toolStrip1.Text = "toolStrip1";
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
            // tsbBuscarSala
            // 
            this.tsbBuscarSala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbBuscarSala.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbBuscarSala.Image = global::ULearn.Properties.Resources.search;
            this.tsbBuscarSala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarSala.Name = "tsbBuscarSala";
            this.tsbBuscarSala.Size = new System.Drawing.Size(116, 28);
            this.tsbBuscarSala.Text = "Buscar Sala";
            this.tsbBuscarSala.Click += new System.EventHandler(this.tsbBuscarSala_Click);
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
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.btnCancelar);
            this.panelContenido.Controls.Add(this.btnGuardar);
            this.panelContenido.Controls.Add(this.gboInfoSala);
            this.panelContenido.Controls.Add(this.gboInfoEspacio);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 31);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(722, 347);
            this.panelContenido.TabIndex = 77;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(524, 148);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 34);
            this.btnCancelar.TabIndex = 65;
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
            this.btnGuardar.Location = new System.Drawing.Point(385, 148);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 34);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gboInfoSala
            // 
            this.gboInfoSala.BackColor = System.Drawing.Color.White;
            this.gboInfoSala.Controls.Add(this.txtTipoSala);
            this.gboInfoSala.Controls.Add(this.rbNoSistemaAudio);
            this.gboInfoSala.Controls.Add(this.rbSiSistemaAudio);
            this.gboInfoSala.Controls.Add(this.lblTipoSala);
            this.gboInfoSala.Controls.Add(this.lblSistemaAudio);
            this.gboInfoSala.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboInfoSala.Location = new System.Drawing.Point(353, 11);
            this.gboInfoSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoSala.Name = "gboInfoSala";
            this.gboInfoSala.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoSala.Size = new System.Drawing.Size(324, 120);
            this.gboInfoSala.TabIndex = 63;
            this.gboInfoSala.TabStop = false;
            this.gboInfoSala.Text = "Información de la Sala";
            // 
            // txtTipoSala
            // 
            this.txtTipoSala.Location = new System.Drawing.Point(173, 77);
            this.txtTipoSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipoSala.Name = "txtTipoSala";
            this.txtTipoSala.Size = new System.Drawing.Size(145, 30);
            this.txtTipoSala.TabIndex = 39;
            // 
            // rbNoSistemaAudio
            // 
            this.rbNoSistemaAudio.AutoSize = true;
            this.rbNoSistemaAudio.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbNoSistemaAudio.Location = new System.Drawing.Point(254, 48);
            this.rbNoSistemaAudio.Name = "rbNoSistemaAudio";
            this.rbNoSistemaAudio.Size = new System.Drawing.Size(43, 22);
            this.rbNoSistemaAudio.TabIndex = 57;
            this.rbNoSistemaAudio.TabStop = true;
            this.rbNoSistemaAudio.Text = "No";
            this.rbNoSistemaAudio.UseVisualStyleBackColor = true;
            // 
            // rbSiSistemaAudio
            // 
            this.rbSiSistemaAudio.AutoSize = true;
            this.rbSiSistemaAudio.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbSiSistemaAudio.Location = new System.Drawing.Point(187, 48);
            this.rbSiSistemaAudio.Name = "rbSiSistemaAudio";
            this.rbSiSistemaAudio.Size = new System.Drawing.Size(38, 22);
            this.rbSiSistemaAudio.TabIndex = 56;
            this.rbSiSistemaAudio.TabStop = true;
            this.rbSiSistemaAudio.Text = "Sí";
            this.rbSiSistemaAudio.UseVisualStyleBackColor = true;
            // 
            // lblTipoSala
            // 
            this.lblTipoSala.AutoSize = true;
            this.lblTipoSala.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblTipoSala.Location = new System.Drawing.Point(13, 84);
            this.lblTipoSala.Name = "lblTipoSala";
            this.lblTipoSala.Size = new System.Drawing.Size(74, 19);
            this.lblTipoSala.TabIndex = 1;
            this.lblTipoSala.Text = "Tipo de sala:";
            // 
            // lblSistemaAudio
            // 
            this.lblSistemaAudio.AutoSize = true;
            this.lblSistemaAudio.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblSistemaAudio.Location = new System.Drawing.Point(13, 50);
            this.lblSistemaAudio.Name = "lblSistemaAudio";
            this.lblSistemaAudio.Size = new System.Drawing.Size(142, 19);
            this.lblSistemaAudio.TabIndex = 0;
            this.lblSistemaAudio.Text = "¿Tiene sistema de audio?:\r\n";
            // 
            // gboInfoEspacio
            // 
            this.gboInfoEspacio.BackColor = System.Drawing.Color.White;
            this.gboInfoEspacio.Controls.Add(this.lblIDEspacio);
            this.gboInfoEspacio.Controls.Add(this.lblAforo);
            this.gboInfoEspacio.Controls.Add(this.lblNombre);
            this.gboInfoEspacio.Controls.Add(this.txtIDEspacio);
            this.gboInfoEspacio.Controls.Add(this.txtAforo);
            this.gboInfoEspacio.Controls.Add(this.txtNombre);
            this.gboInfoEspacio.Controls.Add(this.lblInstitucion);
            this.gboInfoEspacio.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboInfoEspacio.Location = new System.Drawing.Point(12, 11);
            this.gboInfoEspacio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoEspacio.Name = "gboInfoEspacio";
            this.gboInfoEspacio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoEspacio.Size = new System.Drawing.Size(324, 171);
            this.gboInfoEspacio.TabIndex = 62;
            this.gboInfoEspacio.TabStop = false;
            this.gboInfoEspacio.Text = "Información del Espacio";
            // 
            // lblIDEspacio
            // 
            this.lblIDEspacio.AutoSize = true;
            this.lblIDEspacio.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblIDEspacio.Location = new System.Drawing.Point(12, 51);
            this.lblIDEspacio.Name = "lblIDEspacio";
            this.lblIDEspacio.Size = new System.Drawing.Size(66, 19);
            this.lblIDEspacio.TabIndex = 13;
            this.lblIDEspacio.Text = "ID Espacio:";
            // 
            // lblAforo
            // 
            this.lblAforo.AutoSize = true;
            this.lblAforo.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblAforo.Location = new System.Drawing.Point(12, 118);
            this.lblAforo.Name = "lblAforo";
            this.lblAforo.Size = new System.Drawing.Size(42, 19);
            this.lblAforo.TabIndex = 1;
            this.lblAforo.Text = "Aforo:";
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
            // txtIDEspacio
            // 
            this.txtIDEspacio.Enabled = false;
            this.txtIDEspacio.Location = new System.Drawing.Point(117, 44);
            this.txtIDEspacio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDEspacio.Name = "txtIDEspacio";
            this.txtIDEspacio.ReadOnly = true;
            this.txtIDEspacio.Size = new System.Drawing.Size(187, 30);
            this.txtIDEspacio.TabIndex = 12;
            // 
            // txtAforo
            // 
            this.txtAforo.Location = new System.Drawing.Point(117, 112);
            this.txtAforo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAforo.Name = "txtAforo";
            this.txtAforo.Size = new System.Drawing.Size(187, 30);
            this.txtAforo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 30);
            this.txtNombre.TabIndex = 4;
            // 
            // lblInstitucion
            // 
            this.lblInstitucion.AutoSize = true;
            this.lblInstitucion.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblInstitucion.Location = new System.Drawing.Point(12, 84);
            this.lblInstitucion.Name = "lblInstitucion";
            this.lblInstitucion.Size = new System.Drawing.Size(0, 19);
            this.lblInstitucion.TabIndex = 2;
            // 
            // frmNuevaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 378);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmNuevaSala";
            this.Text = "frmNuevaSala";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.gboInfoSala.ResumeLayout(false);
            this.gboInfoSala.PerformLayout();
            this.gboInfoEspacio.ResumeLayout(false);
            this.gboInfoEspacio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBuscarSala;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gboInfoSala;
        private System.Windows.Forms.TextBox txtTipoSala;
        private System.Windows.Forms.RadioButton rbNoSistemaAudio;
        private System.Windows.Forms.RadioButton rbSiSistemaAudio;
        private System.Windows.Forms.Label lblTipoSala;
        private System.Windows.Forms.Label lblSistemaAudio;
        private System.Windows.Forms.GroupBox gboInfoEspacio;
        private System.Windows.Forms.Label lblIDEspacio;
        private System.Windows.Forms.Label lblAforo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDEspacio;
        private System.Windows.Forms.TextBox txtAforo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblInstitucion;
    }
}