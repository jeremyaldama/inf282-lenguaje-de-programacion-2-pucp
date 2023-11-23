namespace ULearn.Administrador
{
    partial class frmNuevaAula
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
            this.tsbBuscarAula = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNoPizarra = new System.Windows.Forms.RadioButton();
            this.rbSiPizarra = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gboInfoAula = new System.Windows.Forms.GroupBox();
            this.rbNoProyector = new System.Windows.Forms.RadioButton();
            this.rbSiProyector = new System.Windows.Forms.RadioButton();
            this.lblProyector = new System.Windows.Forms.Label();
            this.lblPizarraInteligente = new System.Windows.Forms.Label();
            this.gboInfoEspacio = new System.Windows.Forms.GroupBox();
            this.lblIDEspacio = new System.Windows.Forms.Label();
            this.lblAforo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDEspacio = new System.Windows.Forms.TextBox();
            this.txtAforo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboInfoAula.SuspendLayout();
            this.gboInfoEspacio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBuscarAula,
            this.tsbEditar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 77;
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
            // tsbBuscarAula
            // 
            this.tsbBuscarAula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbBuscarAula.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbBuscarAula.Image = global::ULearn.Properties.Resources.search;
            this.tsbBuscarAula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarAula.Name = "tsbBuscarAula";
            this.tsbBuscarAula.Size = new System.Drawing.Size(119, 28);
            this.tsbBuscarAula.Text = "Buscar Aula";
            this.tsbBuscarAula.Click += new System.EventHandler(this.tsbBuscarAula_Click);
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
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Controls.Add(this.btnCancelar);
            this.panelContenido.Controls.Add(this.btnGuardar);
            this.panelContenido.Controls.Add(this.gboInfoAula);
            this.panelContenido.Controls.Add(this.gboInfoEspacio);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 31);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(800, 419);
            this.panelContenido.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNoPizarra);
            this.groupBox1.Controls.Add(this.rbSiPizarra);
            this.groupBox1.Location = new System.Drawing.Point(171, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 43);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // rbNoPizarra
            // 
            this.rbNoPizarra.AutoSize = true;
            this.rbNoPizarra.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbNoPizarra.Location = new System.Drawing.Point(78, 15);
            this.rbNoPizarra.Name = "rbNoPizarra";
            this.rbNoPizarra.Size = new System.Drawing.Size(43, 22);
            this.rbNoPizarra.TabIndex = 57;
            this.rbNoPizarra.TabStop = true;
            this.rbNoPizarra.Text = "No";
            this.rbNoPizarra.UseVisualStyleBackColor = true;
            // 
            // rbSiPizarra
            // 
            this.rbSiPizarra.AutoSize = true;
            this.rbSiPizarra.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbSiPizarra.Location = new System.Drawing.Point(11, 15);
            this.rbSiPizarra.Name = "rbSiPizarra";
            this.rbSiPizarra.Size = new System.Drawing.Size(38, 22);
            this.rbSiPizarra.TabIndex = 56;
            this.rbSiPizarra.TabStop = true;
            this.rbSiPizarra.Text = "Sí";
            this.rbSiPizarra.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(524, 153);
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
            this.btnGuardar.Location = new System.Drawing.Point(385, 153);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 34);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gboInfoAula
            // 
            this.gboInfoAula.BackColor = System.Drawing.Color.White;
            this.gboInfoAula.Controls.Add(this.groupBox2);
            this.gboInfoAula.Controls.Add(this.groupBox1);
            this.gboInfoAula.Controls.Add(this.lblProyector);
            this.gboInfoAula.Controls.Add(this.lblPizarraInteligente);
            this.gboInfoAula.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboInfoAula.Location = new System.Drawing.Point(353, 11);
            this.gboInfoAula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoAula.Name = "gboInfoAula";
            this.gboInfoAula.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoAula.Size = new System.Drawing.Size(324, 137);
            this.gboInfoAula.TabIndex = 63;
            this.gboInfoAula.TabStop = false;
            this.gboInfoAula.Text = "Información del Aula";
            // 
            // rbNoProyector
            // 
            this.rbNoProyector.AutoSize = true;
            this.rbNoProyector.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbNoProyector.Location = new System.Drawing.Point(77, 15);
            this.rbNoProyector.Name = "rbNoProyector";
            this.rbNoProyector.Size = new System.Drawing.Size(43, 22);
            this.rbNoProyector.TabIndex = 55;
            this.rbNoProyector.TabStop = true;
            this.rbNoProyector.Text = "No";
            this.rbNoProyector.UseVisualStyleBackColor = true;
            // 
            // rbSiProyector
            // 
            this.rbSiProyector.AutoSize = true;
            this.rbSiProyector.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbSiProyector.Location = new System.Drawing.Point(10, 15);
            this.rbSiProyector.Name = "rbSiProyector";
            this.rbSiProyector.Size = new System.Drawing.Size(38, 22);
            this.rbSiProyector.TabIndex = 54;
            this.rbSiProyector.TabStop = true;
            this.rbSiProyector.Text = "Sí";
            this.rbSiProyector.UseVisualStyleBackColor = true;
            // 
            // lblProyector
            // 
            this.lblProyector.AutoSize = true;
            this.lblProyector.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblProyector.Location = new System.Drawing.Point(13, 95);
            this.lblProyector.Name = "lblProyector";
            this.lblProyector.Size = new System.Drawing.Size(105, 19);
            this.lblProyector.TabIndex = 1;
            this.lblProyector.Text = "¿Tiene proyector?:\r\n";
            // 
            // lblPizarraInteligente
            // 
            this.lblPizarraInteligente.AutoSize = true;
            this.lblPizarraInteligente.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblPizarraInteligente.Location = new System.Drawing.Point(13, 50);
            this.lblPizarraInteligente.Name = "lblPizarraInteligente";
            this.lblPizarraInteligente.Size = new System.Drawing.Size(149, 19);
            this.lblPizarraInteligente.TabIndex = 0;
            this.lblPizarraInteligente.Text = "¿Tiene pizarra inteligente?:\r\n";
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
            this.gboInfoEspacio.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboInfoEspacio.Location = new System.Drawing.Point(12, 11);
            this.gboInfoEspacio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoEspacio.Name = "gboInfoEspacio";
            this.gboInfoEspacio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoEspacio.Size = new System.Drawing.Size(324, 176);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNoProyector);
            this.groupBox2.Controls.Add(this.rbSiProyector);
            this.groupBox2.Location = new System.Drawing.Point(171, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 43);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // frmNuevaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmNuevaAula";
            this.Text = "frmNuevaAula";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboInfoAula.ResumeLayout(false);
            this.gboInfoAula.PerformLayout();
            this.gboInfoEspacio.ResumeLayout(false);
            this.gboInfoEspacio.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBuscarAula;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gboInfoAula;
        private System.Windows.Forms.RadioButton rbNoPizarra;
        private System.Windows.Forms.RadioButton rbSiPizarra;
        private System.Windows.Forms.RadioButton rbNoProyector;
        private System.Windows.Forms.RadioButton rbSiProyector;
        private System.Windows.Forms.Label lblProyector;
        private System.Windows.Forms.Label lblPizarraInteligente;
        private System.Windows.Forms.GroupBox gboInfoEspacio;
        private System.Windows.Forms.Label lblIDEspacio;
        private System.Windows.Forms.Label lblAforo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDEspacio;
        private System.Windows.Forms.TextBox txtAforo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}