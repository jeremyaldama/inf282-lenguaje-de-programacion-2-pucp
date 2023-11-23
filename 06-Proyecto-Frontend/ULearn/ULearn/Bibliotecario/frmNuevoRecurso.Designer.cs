namespace ULearn.Bibliotecario
{
    partial class frmNuevoRecurso
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
            this.lblSuperior = new System.Windows.Forms.Label();
            this.tspGestión = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblIDRecurso = new System.Windows.Forms.Label();
            this.txtIDRecurso = new System.Windows.Forms.TextBox();
            this.btnBusqAutor = new System.Windows.Forms.Button();
            this.lblFechaPub = new System.Windows.Forms.Label();
            this.dtpPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblTipo = new System.Windows.Forms.Label();
            this.rbLibro = new System.Windows.Forms.RadioButton();
            this.rbDigital = new System.Windows.Forms.RadioButton();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.cboBiblioteca = new System.Windows.Forms.ComboBox();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.lblAutores = new System.Windows.Forms.Label();
            this.rbNoDisponible = new System.Windows.Forms.RadioButton();
            this.rbDisponible = new System.Windows.Forms.RadioButton();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.panelTipo = new System.Windows.Forms.Panel();
            this.lblPortada = new System.Windows.Forms.Label();
            this.btnPortada = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminarPortada = new System.Windows.Forms.Button();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.panelSuperior.SuspendLayout();
            this.tspGestión.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panelSuperior.Controls.Add(this.lblSuperior);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1085, 62);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuperior.Location = new System.Drawing.Point(12, 9);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(313, 36);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "Gestión de Recursos";
            // 
            // tspGestión
            // 
            this.tspGestión.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tspGestión.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspGestión.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnBuscar,
            this.btnEliminar,
            this.btnEditar});
            this.tspGestión.Location = new System.Drawing.Point(0, 62);
            this.tspGestión.Name = "tspGestión";
            this.tspGestión.Size = new System.Drawing.Size(1085, 27);
            this.tspGestión.TabIndex = 1;
            this.tspGestión.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ULearn.Properties.Resources.new_document;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 24);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ULearn.Properties.Resources.search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 24);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::ULearn.Properties.Resources.delete;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 24);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::ULearn.Properties.Resources.edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 24);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(115, 67);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(555, 28);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 73);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(48, 18);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(16, 108);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(73, 18);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor(es):";
            // 
            // lblIDRecurso
            // 
            this.lblIDRecurso.AutoSize = true;
            this.lblIDRecurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDRecurso.Location = new System.Drawing.Point(17, 39);
            this.lblIDRecurso.Name = "lblIDRecurso";
            this.lblIDRecurso.Size = new System.Drawing.Size(87, 18);
            this.lblIDRecurso.TabIndex = 6;
            this.lblIDRecurso.Text = "ID Recurso:";
            // 
            // txtIDRecurso
            // 
            this.txtIDRecurso.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDRecurso.Enabled = false;
            this.txtIDRecurso.Location = new System.Drawing.Point(115, 33);
            this.txtIDRecurso.Name = "txtIDRecurso";
            this.txtIDRecurso.Size = new System.Drawing.Size(136, 28);
            this.txtIDRecurso.TabIndex = 7;
            // 
            // btnBusqAutor
            // 
            this.btnBusqAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqAutor.Location = new System.Drawing.Point(557, 107);
            this.btnBusqAutor.Name = "btnBusqAutor";
            this.btnBusqAutor.Size = new System.Drawing.Size(113, 30);
            this.btnBusqAutor.TabIndex = 8;
            this.btnBusqAutor.Text = "Ver más";
            this.btnBusqAutor.UseVisualStyleBackColor = true;
            this.btnBusqAutor.Click += new System.EventHandler(this.btnBusqAutor_Click);
            // 
            // lblFechaPub
            // 
            this.lblFechaPub.AutoSize = true;
            this.lblFechaPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPub.Location = new System.Drawing.Point(389, 211);
            this.lblFechaPub.Name = "lblFechaPub";
            this.lblFechaPub.Size = new System.Drawing.Size(151, 18);
            this.lblFechaPub.TabIndex = 9;
            this.lblFechaPub.Text = "Fecha de publicación:";
            // 
            // dtpPublicacion
            // 
            this.dtpPublicacion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublicacion.Location = new System.Drawing.Point(557, 205);
            this.dtpPublicacion.Name = "dtpPublicacion";
            this.dtpPublicacion.Size = new System.Drawing.Size(146, 28);
            this.dtpPublicacion.TabIndex = 10;
            this.dtpPublicacion.Value = new System.DateTime(2023, 10, 5, 0, 0, 0, 0);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(16, 49);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(116, 18);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo de recurso:";
            // 
            // rbLibro
            // 
            this.rbLibro.AutoSize = true;
            this.rbLibro.Location = new System.Drawing.Point(182, 44);
            this.rbLibro.Name = "rbLibro";
            this.rbLibro.Size = new System.Drawing.Size(71, 26);
            this.rbLibro.TabIndex = 12;
            this.rbLibro.Text = "Libro";
            this.rbLibro.UseVisualStyleBackColor = true;
            this.rbLibro.CheckedChanged += new System.EventHandler(this.rbLibro_CheckedChanged);
            // 
            // rbDigital
            // 
            this.rbDigital.AutoSize = true;
            this.rbDigital.Location = new System.Drawing.Point(270, 44);
            this.rbDigital.Name = "rbDigital";
            this.rbDigital.Size = new System.Drawing.Size(153, 26);
            this.rbDigital.TabIndex = 13;
            this.rbDigital.Text = "Recurso Digital";
            this.rbDigital.UseVisualStyleBackColor = true;
            this.rbDigital.CheckedChanged += new System.EventHandler(this.rbDigital_CheckedChanged);
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.txtISBN);
            this.gbInformacion.Controls.Add(this.lblISBN);
            this.gbInformacion.Controls.Add(this.cboBiblioteca);
            this.gbInformacion.Controls.Add(this.lblBiblioteca);
            this.gbInformacion.Controls.Add(this.lblAutores);
            this.gbInformacion.Controls.Add(this.rbNoDisponible);
            this.gbInformacion.Controls.Add(this.rbDisponible);
            this.gbInformacion.Controls.Add(this.lblDisponible);
            this.gbInformacion.Controls.Add(this.txtTitulo);
            this.gbInformacion.Controls.Add(this.lblTitulo);
            this.gbInformacion.Controls.Add(this.lblAutor);
            this.gbInformacion.Controls.Add(this.dtpPublicacion);
            this.gbInformacion.Controls.Add(this.lblIDRecurso);
            this.gbInformacion.Controls.Add(this.lblFechaPub);
            this.gbInformacion.Controls.Add(this.txtIDRecurso);
            this.gbInformacion.Controls.Add(this.btnBusqAutor);
            this.gbInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacion.Location = new System.Drawing.Point(18, 110);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(747, 249);
            this.gbInformacion.TabIndex = 14;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Información general";
            // 
            // cboBiblioteca
            // 
            this.cboBiblioteca.FormattingEnabled = true;
            this.cboBiblioteca.Location = new System.Drawing.Point(115, 164);
            this.cboBiblioteca.Name = "cboBiblioteca";
            this.cboBiblioteca.Size = new System.Drawing.Size(308, 30);
            this.cboBiblioteca.TabIndex = 17;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.Location = new System.Drawing.Point(17, 170);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(76, 18);
            this.lblBiblioteca.TabIndex = 16;
            this.lblBiblioteca.Text = "Biblioteca:";
            // 
            // lblAutores
            // 
            this.lblAutores.AutoEllipsis = true;
            this.lblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.Location = new System.Drawing.Point(115, 107);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(404, 51);
            this.lblAutores.TabIndex = 15;
            this.lblAutores.Text = "Autores...";
            // 
            // rbNoDisponible
            // 
            this.rbNoDisponible.AutoSize = true;
            this.rbNoDisponible.BackColor = System.Drawing.SystemColors.Window;
            this.rbNoDisponible.Enabled = false;
            this.rbNoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoDisponible.Location = new System.Drawing.Point(619, 164);
            this.rbNoDisponible.Name = "rbNoDisponible";
            this.rbNoDisponible.Size = new System.Drawing.Size(51, 24);
            this.rbNoDisponible.TabIndex = 14;
            this.rbNoDisponible.TabStop = true;
            this.rbNoDisponible.Text = "No";
            this.rbNoDisponible.UseVisualStyleBackColor = false;
            this.rbNoDisponible.CheckedChanged += new System.EventHandler(this.rbNoDisponible_CheckedChanged);
            // 
            // rbDisponible
            // 
            this.rbDisponible.AutoSize = true;
            this.rbDisponible.Enabled = false;
            this.rbDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDisponible.Location = new System.Drawing.Point(557, 164);
            this.rbDisponible.Name = "rbDisponible";
            this.rbDisponible.Size = new System.Drawing.Size(45, 24);
            this.rbDisponible.TabIndex = 13;
            this.rbDisponible.TabStop = true;
            this.rbDisponible.Text = "Sí";
            this.rbDisponible.UseVisualStyleBackColor = true;
            this.rbDisponible.CheckedChanged += new System.EventHandler(this.rbDisponible_CheckedChanged);
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.Location = new System.Drawing.Point(459, 170);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(81, 18);
            this.lblDisponible.TabIndex = 12;
            this.lblDisponible.Text = "Disponible:";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.panelTipo);
            this.gbTipo.Controls.Add(this.lblTipo);
            this.gbTipo.Controls.Add(this.rbLibro);
            this.gbTipo.Controls.Add(this.rbDigital);
            this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipo.Location = new System.Drawing.Point(18, 365);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(747, 228);
            this.gbTipo.TabIndex = 15;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo de recurso";
            // 
            // panelTipo
            // 
            this.panelTipo.Location = new System.Drawing.Point(6, 81);
            this.panelTipo.Name = "panelTipo";
            this.panelTipo.Size = new System.Drawing.Size(735, 137);
            this.panelTipo.TabIndex = 14;
            // 
            // lblPortada
            // 
            this.lblPortada.AutoSize = true;
            this.lblPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortada.Location = new System.Drawing.Point(805, 110);
            this.lblPortada.Name = "lblPortada";
            this.lblPortada.Size = new System.Drawing.Size(72, 20);
            this.lblPortada.TabIndex = 17;
            this.lblPortada.Text = "Portada:";
            // 
            // btnPortada
            // 
            this.btnPortada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPortada.Location = new System.Drawing.Point(897, 361);
            this.btnPortada.Name = "btnPortada";
            this.btnPortada.Size = new System.Drawing.Size(129, 30);
            this.btnPortada.TabIndex = 18;
            this.btnPortada.Text = "Subir portada";
            this.btnPortada.UseVisualStyleBackColor = false;
            this.btnPortada.Click += new System.EventHandler(this.btnPortada_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(943, 544);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 39);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(809, 544);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarPortada
            // 
            this.btnEliminarPortada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPortada.Location = new System.Drawing.Point(897, 402);
            this.btnEliminarPortada.Name = "btnEliminarPortada";
            this.btnEliminarPortada.Size = new System.Drawing.Size(129, 30);
            this.btnEliminarPortada.TabIndex = 21;
            this.btnEliminarPortada.Text = "Eliminar portada";
            this.btnEliminarPortada.UseVisualStyleBackColor = true;
            this.btnEliminarPortada.Click += new System.EventHandler(this.btnEliminarPortada_Click);
            // 
            // pbPortada
            // 
            this.pbPortada.BackColor = System.Drawing.SystemColors.Control;
            this.pbPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPortada.Location = new System.Drawing.Point(809, 133);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(217, 204);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 16;
            this.pbPortada.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoEllipsis = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMensaje.Location = new System.Drawing.Point(809, 446);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(252, 86);
            this.lblMensaje.TabIndex = 22;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(16, 211);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(46, 18);
            this.lblISBN.TabIndex = 18;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(115, 205);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(222, 28);
            this.txtISBN.TabIndex = 19;
            // 
            // frmNuevoRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1085, 605);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnEliminarPortada);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPortada);
            this.Controls.Add(this.lblPortada);
            this.Controls.Add(this.pbPortada);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.tspGestión);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmNuevoRecurso";
            this.Text = "frmNuevoRecurso";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.tspGestión.ResumeLayout(false);
            this.tspGestión.PerformLayout();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.ToolStrip tspGestión;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblIDRecurso;
        private System.Windows.Forms.TextBox txtIDRecurso;
        private System.Windows.Forms.Button btnBusqAutor;
        private System.Windows.Forms.Label lblFechaPub;
        private System.Windows.Forms.DateTimePicker dtpPublicacion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.RadioButton rbLibro;
        private System.Windows.Forms.RadioButton rbDigital;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label lblPortada;
        private System.Windows.Forms.Button btnPortada;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminarPortada;
        private System.Windows.Forms.RadioButton rbNoDisponible;
        private System.Windows.Forms.RadioButton rbDisponible;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.ComboBox cboBiblioteca;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Panel panelTipo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
    }
}