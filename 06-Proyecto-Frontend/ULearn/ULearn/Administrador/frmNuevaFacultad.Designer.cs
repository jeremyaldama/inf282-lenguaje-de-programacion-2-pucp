namespace ULearn.Administrador
{
    partial class frmNuevaFacultad
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
            this.lblRegistroFacultad = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gboInfoFacultad = new System.Windows.Forms.GroupBox();
            this.lblIDFacultad = new System.Windows.Forms.Label();
            this.txtIDFacultad = new System.Windows.Forms.TextBox();
            this.lblInscritos = new System.Windows.Forms.Label();
            this.txtInscritos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAnexo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarFacultad = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.panelContenido.SuspendLayout();
            this.tspHerramientasCarreras.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.gboInfoFacultad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContenido.Controls.Add(this.tspHerramientasCarreras);
            this.panelContenido.Controls.Add(this.panelSuperior);
            this.panelContenido.Controls.Add(this.btnCancelar);
            this.panelContenido.Controls.Add(this.btnGuardar);
            this.panelContenido.Controls.Add(this.gboInfoFacultad);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(800, 450);
            this.panelContenido.TabIndex = 1;
            // 
            // tspHerramientasCarreras
            // 
            this.tspHerramientasCarreras.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tspHerramientasCarreras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBuscarFacultad,
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
            this.panelSuperior.Controls.Add(this.lblRegistroFacultad);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 65);
            this.panelSuperior.TabIndex = 64;
            // 
            // lblRegistroFacultad
            // 
            this.lblRegistroFacultad.AutoSize = true;
            this.lblRegistroFacultad.Font = new System.Drawing.Font("Noto Sans Cond", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegistroFacultad.ForeColor = System.Drawing.Color.White;
            this.lblRegistroFacultad.Location = new System.Drawing.Point(21, 14);
            this.lblRegistroFacultad.Name = "lblRegistroFacultad";
            this.lblRegistroFacultad.Size = new System.Drawing.Size(273, 37);
            this.lblRegistroFacultad.TabIndex = 0;
            this.lblRegistroFacultad.Text = "Registro de Facultades";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(281, 331);
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
            this.btnGuardar.Location = new System.Drawing.Point(120, 331);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 34);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gboInfoFacultad
            // 
            this.gboInfoFacultad.BackColor = System.Drawing.Color.White;
            this.gboInfoFacultad.Controls.Add(this.txtAnexo);
            this.gboInfoFacultad.Controls.Add(this.lblIDFacultad);
            this.gboInfoFacultad.Controls.Add(this.txtIDFacultad);
            this.gboInfoFacultad.Controls.Add(this.lblInscritos);
            this.gboInfoFacultad.Controls.Add(this.txtInscritos);
            this.gboInfoFacultad.Controls.Add(this.txtNombre);
            this.gboInfoFacultad.Controls.Add(this.lblAnexo);
            this.gboInfoFacultad.Controls.Add(this.lblNombre);
            this.gboInfoFacultad.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboInfoFacultad.Location = new System.Drawing.Point(12, 107);
            this.gboInfoFacultad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoFacultad.Name = "gboInfoFacultad";
            this.gboInfoFacultad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoFacultad.Size = new System.Drawing.Size(505, 201);
            this.gboInfoFacultad.TabIndex = 61;
            this.gboInfoFacultad.TabStop = false;
            this.gboInfoFacultad.Text = "Información de la Facultad";
            // 
            // lblIDFacultad
            // 
            this.lblIDFacultad.AutoSize = true;
            this.lblIDFacultad.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblIDFacultad.Location = new System.Drawing.Point(12, 51);
            this.lblIDFacultad.Name = "lblIDFacultad";
            this.lblIDFacultad.Size = new System.Drawing.Size(71, 19);
            this.lblIDFacultad.TabIndex = 13;
            this.lblIDFacultad.Text = "ID Facultad:";
            // 
            // txtIDFacultad
            // 
            this.txtIDFacultad.Enabled = false;
            this.txtIDFacultad.Location = new System.Drawing.Point(173, 43);
            this.txtIDFacultad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDFacultad.Name = "txtIDFacultad";
            this.txtIDFacultad.ReadOnly = true;
            this.txtIDFacultad.Size = new System.Drawing.Size(304, 30);
            this.txtIDFacultad.TabIndex = 12;
            // 
            // lblInscritos
            // 
            this.lblInscritos.AutoSize = true;
            this.lblInscritos.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblInscritos.Location = new System.Drawing.Point(13, 154);
            this.lblInscritos.Name = "lblInscritos";
            this.lblInscritos.Size = new System.Drawing.Size(57, 19);
            this.lblInscritos.TabIndex = 9;
            this.lblInscritos.Text = "Inscritos:";
            // 
            // txtInscritos
            // 
            this.txtInscritos.Location = new System.Drawing.Point(173, 147);
            this.txtInscritos.Name = "txtInscritos";
            this.txtInscritos.Size = new System.Drawing.Size(153, 30);
            this.txtInscritos.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(304, 30);
            this.txtNombre.TabIndex = 19;
            // 
            // lblAnexo
            // 
            this.lblAnexo.AutoSize = true;
            this.lblAnexo.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblAnexo.Location = new System.Drawing.Point(12, 118);
            this.lblAnexo.Name = "lblAnexo";
            this.lblAnexo.Size = new System.Drawing.Size(45, 19);
            this.lblAnexo.TabIndex = 1;
            this.lblAnexo.Text = "Anexo:";
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
            // txtAnexo
            // 
            this.txtAnexo.Location = new System.Drawing.Point(173, 111);
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(304, 30);
            this.txtAnexo.TabIndex = 68;
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
            // tsbBuscarFacultad
            // 
            this.tsbBuscarFacultad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbBuscarFacultad.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbBuscarFacultad.Image = global::ULearn.Properties.Resources.search;
            this.tsbBuscarFacultad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarFacultad.Name = "tsbBuscarFacultad";
            this.tsbBuscarFacultad.Size = new System.Drawing.Size(146, 28);
            this.tsbBuscarFacultad.Text = "Buscar Facultad";
            this.tsbBuscarFacultad.Click += new System.EventHandler(this.tsbBuscarFacultad_Click);
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
            // frmNuevaFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Name = "frmNuevaFacultad";
            this.Text = "frmNuevaFacultad";
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.tspHerramientasCarreras.ResumeLayout(false);
            this.tspHerramientasCarreras.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.gboInfoFacultad.ResumeLayout(false);
            this.gboInfoFacultad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.ToolStrip tspHerramientasCarreras;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBuscarFacultad;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblRegistroFacultad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gboInfoFacultad;
        private System.Windows.Forms.Label lblIDFacultad;
        private System.Windows.Forms.TextBox txtIDFacultad;
        private System.Windows.Forms.Label lblInscritos;
        private System.Windows.Forms.TextBox txtInscritos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAnexo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtAnexo;
    }
}