namespace ULearn.Administrador
{
    partial class frmNuevaCharla
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
            this.tsbBuscarCharla = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gboInfoCharla = new System.Windows.Forms.GroupBox();
            this.txtPonente = new System.Windows.Forms.TextBox();
            this.lblPonente = new System.Windows.Forms.Label();
            this.gboInfoEspacio = new System.Windows.Forms.GroupBox();
            this.lblGratuito = new System.Windows.Forms.Label();
            this.lblInscritos = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboEspacio = new System.Windows.Forms.ComboBox();
            this.lblEspacio = new System.Windows.Forms.Label();
            this.txtInscritos = new System.Windows.Forms.TextBox();
            this.rbNoGratuito = new System.Windows.Forms.RadioButton();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.rbSiGratuito = new System.Windows.Forms.RadioButton();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.lblIDEvento = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblOrganizador = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDEvento = new System.Windows.Forms.TextBox();
            this.txtOrganizador = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.gboInfoCharla.SuspendLayout();
            this.gboInfoEspacio.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBuscarCharla,
            this.tsbEditar,
            this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 62;
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
            // tsbBuscarCharla
            // 
            this.tsbBuscarCharla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbBuscarCharla.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbBuscarCharla.Image = global::ULearn.Properties.Resources.search;
            this.tsbBuscarCharla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarCharla.Name = "tsbBuscarCharla";
            this.tsbBuscarCharla.Size = new System.Drawing.Size(132, 28);
            this.tsbBuscarCharla.Text = "Buscar Charla";
            this.tsbBuscarCharla.Click += new System.EventHandler(this.tsbBuscarCharla_Click);
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
            this.panelContenido.Controls.Add(this.gboInfoCharla);
            this.panelContenido.Controls.Add(this.gboInfoEspacio);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 31);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(800, 419);
            this.panelContenido.TabIndex = 63;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(594, 130);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 34);
            this.btnCancelar.TabIndex = 73;
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
            this.btnGuardar.Location = new System.Drawing.Point(455, 130);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 34);
            this.btnGuardar.TabIndex = 72;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gboInfoCharla
            // 
            this.gboInfoCharla.BackColor = System.Drawing.Color.White;
            this.gboInfoCharla.Controls.Add(this.txtPonente);
            this.gboInfoCharla.Controls.Add(this.lblPonente);
            this.gboInfoCharla.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboInfoCharla.Location = new System.Drawing.Point(418, 11);
            this.gboInfoCharla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoCharla.Name = "gboInfoCharla";
            this.gboInfoCharla.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoCharla.Size = new System.Drawing.Size(324, 103);
            this.gboInfoCharla.TabIndex = 71;
            this.gboInfoCharla.TabStop = false;
            this.gboInfoCharla.Text = "Información de la Charla";
            // 
            // txtPonente
            // 
            this.txtPonente.Location = new System.Drawing.Point(113, 44);
            this.txtPonente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPonente.Name = "txtPonente";
            this.txtPonente.Size = new System.Drawing.Size(195, 30);
            this.txtPonente.TabIndex = 58;
            // 
            // lblPonente
            // 
            this.lblPonente.AutoSize = true;
            this.lblPonente.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblPonente.Location = new System.Drawing.Point(13, 50);
            this.lblPonente.Name = "lblPonente";
            this.lblPonente.Size = new System.Drawing.Size(56, 19);
            this.lblPonente.TabIndex = 0;
            this.lblPonente.Text = "Ponente:";
            // 
            // gboInfoEspacio
            // 
            this.gboInfoEspacio.BackColor = System.Drawing.Color.White;
            this.gboInfoEspacio.Controls.Add(this.lblGratuito);
            this.gboInfoEspacio.Controls.Add(this.lblInscritos);
            this.gboInfoEspacio.Controls.Add(this.dtpFecha);
            this.gboInfoEspacio.Controls.Add(this.lblFecha);
            this.gboInfoEspacio.Controls.Add(this.cboEspacio);
            this.gboInfoEspacio.Controls.Add(this.lblEspacio);
            this.gboInfoEspacio.Controls.Add(this.txtInscritos);
            this.gboInfoEspacio.Controls.Add(this.rbNoGratuito);
            this.gboInfoEspacio.Controls.Add(this.txtHoraInicio);
            this.gboInfoEspacio.Controls.Add(this.rbSiGratuito);
            this.gboInfoEspacio.Controls.Add(this.txtHoraFin);
            this.gboInfoEspacio.Controls.Add(this.lblIDEvento);
            this.gboInfoEspacio.Controls.Add(this.lblHoraInicio);
            this.gboInfoEspacio.Controls.Add(this.lblHoraFin);
            this.gboInfoEspacio.Controls.Add(this.lblOrganizador);
            this.gboInfoEspacio.Controls.Add(this.lblNombre);
            this.gboInfoEspacio.Controls.Add(this.txtIDEvento);
            this.gboInfoEspacio.Controls.Add(this.txtOrganizador);
            this.gboInfoEspacio.Controls.Add(this.txtNombre);
            this.gboInfoEspacio.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboInfoEspacio.Location = new System.Drawing.Point(12, 11);
            this.gboInfoEspacio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoEspacio.Name = "gboInfoEspacio";
            this.gboInfoEspacio.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoEspacio.Size = new System.Drawing.Size(389, 411);
            this.gboInfoEspacio.TabIndex = 70;
            this.gboInfoEspacio.TabStop = false;
            this.gboInfoEspacio.Text = "Información del Evento";
            // 
            // lblGratuito
            // 
            this.lblGratuito.AutoSize = true;
            this.lblGratuito.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblGratuito.Location = new System.Drawing.Point(12, 325);
            this.lblGratuito.Name = "lblGratuito";
            this.lblGratuito.Size = new System.Drawing.Size(79, 19);
            this.lblGratuito.TabIndex = 46;
            this.lblGratuito.Text = "¿Es gratuito?:";
            // 
            // lblInscritos
            // 
            this.lblInscritos.AutoSize = true;
            this.lblInscritos.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblInscritos.Location = new System.Drawing.Point(12, 291);
            this.lblInscritos.Name = "lblInscritos";
            this.lblInscritos.Size = new System.Drawing.Size(122, 19);
            this.lblInscritos.TabIndex = 45;
            this.lblInscritos.Text = "Cantidad de inscritos:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.dtpFecha.Location = new System.Drawing.Point(172, 183);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(195, 30);
            this.dtpFecha.TabIndex = 57;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblFecha.Location = new System.Drawing.Point(12, 189);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(42, 19);
            this.lblFecha.TabIndex = 56;
            this.lblFecha.Text = "Fecha:";
            // 
            // cboEspacio
            // 
            this.cboEspacio.FormattingEnabled = true;
            this.cboEspacio.Location = new System.Drawing.Point(172, 112);
            this.cboEspacio.Name = "cboEspacio";
            this.cboEspacio.Size = new System.Drawing.Size(195, 31);
            this.cboEspacio.TabIndex = 38;
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblEspacio.Location = new System.Drawing.Point(12, 119);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(48, 19);
            this.lblEspacio.TabIndex = 2;
            this.lblEspacio.Text = "Espacio";
            // 
            // txtInscritos
            // 
            this.txtInscritos.Location = new System.Drawing.Point(172, 286);
            this.txtInscritos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInscritos.Name = "txtInscritos";
            this.txtInscritos.ReadOnly = true;
            this.txtInscritos.Size = new System.Drawing.Size(195, 30);
            this.txtInscritos.TabIndex = 41;
            // 
            // rbNoGratuito
            // 
            this.rbNoGratuito.AutoSize = true;
            this.rbNoGratuito.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbNoGratuito.Location = new System.Drawing.Point(234, 325);
            this.rbNoGratuito.Name = "rbNoGratuito";
            this.rbNoGratuito.Size = new System.Drawing.Size(43, 22);
            this.rbNoGratuito.TabIndex = 55;
            this.rbNoGratuito.TabStop = true;
            this.rbNoGratuito.Text = "No";
            this.rbNoGratuito.UseVisualStyleBackColor = true;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(172, 218);
            this.txtHoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(195, 30);
            this.txtHoraInicio.TabIndex = 39;
            // 
            // rbSiGratuito
            // 
            this.rbSiGratuito.AutoSize = true;
            this.rbSiGratuito.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbSiGratuito.Location = new System.Drawing.Point(172, 325);
            this.rbSiGratuito.Name = "rbSiGratuito";
            this.rbSiGratuito.Size = new System.Drawing.Size(38, 22);
            this.rbSiGratuito.TabIndex = 54;
            this.rbSiGratuito.TabStop = true;
            this.rbSiGratuito.Text = "Sí";
            this.rbSiGratuito.UseVisualStyleBackColor = true;
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(172, 252);
            this.txtHoraFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(195, 30);
            this.txtHoraFin.TabIndex = 40;
            // 
            // lblIDEvento
            // 
            this.lblIDEvento.AutoSize = true;
            this.lblIDEvento.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblIDEvento.Location = new System.Drawing.Point(12, 51);
            this.lblIDEvento.Name = "lblIDEvento";
            this.lblIDEvento.Size = new System.Drawing.Size(63, 19);
            this.lblIDEvento.TabIndex = 13;
            this.lblIDEvento.Text = "ID Evento:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblHoraInicio.Location = new System.Drawing.Point(12, 223);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(85, 19);
            this.lblHoraInicio.TabIndex = 43;
            this.lblHoraInicio.Text = "Hora de inicio:";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblHoraFin.Location = new System.Drawing.Point(12, 257);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(71, 19);
            this.lblHoraFin.TabIndex = 44;
            this.lblHoraFin.Text = "Hora de fin:";
            // 
            // lblOrganizador
            // 
            this.lblOrganizador.AutoSize = true;
            this.lblOrganizador.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblOrganizador.Location = new System.Drawing.Point(12, 152);
            this.lblOrganizador.Name = "lblOrganizador";
            this.lblOrganizador.Size = new System.Drawing.Size(79, 19);
            this.lblOrganizador.TabIndex = 1;
            this.lblOrganizador.Text = "Organizador:";
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
            // txtIDEvento
            // 
            this.txtIDEvento.Enabled = false;
            this.txtIDEvento.Location = new System.Drawing.Point(172, 43);
            this.txtIDEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDEvento.Name = "txtIDEvento";
            this.txtIDEvento.ReadOnly = true;
            this.txtIDEvento.Size = new System.Drawing.Size(195, 30);
            this.txtIDEvento.TabIndex = 12;
            // 
            // txtOrganizador
            // 
            this.txtOrganizador.Location = new System.Drawing.Point(172, 148);
            this.txtOrganizador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrganizador.Name = "txtOrganizador";
            this.txtOrganizador.Size = new System.Drawing.Size(195, 30);
            this.txtOrganizador.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 77);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 30);
            this.txtNombre.TabIndex = 4;
            // 
            // frmNuevaCharla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmNuevaCharla";
            this.Text = "frmNuevaCharla";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.gboInfoCharla.ResumeLayout(false);
            this.gboInfoCharla.PerformLayout();
            this.gboInfoEspacio.ResumeLayout(false);
            this.gboInfoEspacio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBuscarCharla;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gboInfoCharla;
        private System.Windows.Forms.TextBox txtPonente;
        private System.Windows.Forms.Label lblPonente;
        private System.Windows.Forms.GroupBox gboInfoEspacio;
        private System.Windows.Forms.Label lblGratuito;
        private System.Windows.Forms.Label lblInscritos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cboEspacio;
        private System.Windows.Forms.Label lblEspacio;
        private System.Windows.Forms.RadioButton rbNoGratuito;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.RadioButton rbSiGratuito;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.Label lblIDEvento;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblOrganizador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDEvento;
        private System.Windows.Forms.TextBox txtOrganizador;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtInscritos;
    }
}