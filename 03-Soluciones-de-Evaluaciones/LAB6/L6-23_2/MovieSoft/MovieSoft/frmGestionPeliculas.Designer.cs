namespace MovieSoft
{
    partial class frmGestionPeliculas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPeliculas));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.cb3D = new System.Windows.Forms.CheckBox();
            this.cbXtreme = new System.Windows.Forms.CheckBox();
            this.pbLogoProductora = new System.Windows.Forms.PictureBox();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblCostoProduccion = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtCostoProduccion = new System.Windows.Forms.TextBox();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.cboProductora = new System.Windows.Forms.ComboBox();
            this.lblProductora = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.cbSubtitulada = new System.Windows.Forms.CheckBox();
            this.cbDoblada = new System.Windows.Forms.CheckBox();
            this.lblFormatosDisponibles = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDPelicula = new System.Windows.Forms.TextBox();
            this.lblIDPelicula = new System.Windows.Forms.Label();
            this.btnSubirPortada = new System.Windows.Forms.Button();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.ofdPortada = new System.Windows.Forms.OpenFileDialog();
            this.tsMenu.SuspendLayout();
            this.gbDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoProductora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1300, 30);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(84, 27);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 27);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::MovieSoft.Properties.Resources.Search;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 27);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::MovieSoft.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.cb3D);
            this.gbDatosGenerales.Controls.Add(this.cbXtreme);
            this.gbDatosGenerales.Controls.Add(this.pbLogoProductora);
            this.gbDatosGenerales.Controls.Add(this.lblSinopsis);
            this.gbDatosGenerales.Controls.Add(this.lblCostoProduccion);
            this.gbDatosGenerales.Controls.Add(this.txtSinopsis);
            this.gbDatosGenerales.Controls.Add(this.txtCostoProduccion);
            this.gbDatosGenerales.Controls.Add(this.dtpFechaEstreno);
            this.gbDatosGenerales.Controls.Add(this.cboProductora);
            this.gbDatosGenerales.Controls.Add(this.lblProductora);
            this.gbDatosGenerales.Controls.Add(this.panelSuperior);
            this.gbDatosGenerales.Controls.Add(this.cbSubtitulada);
            this.gbDatosGenerales.Controls.Add(this.cbDoblada);
            this.gbDatosGenerales.Controls.Add(this.lblFormatosDisponibles);
            this.gbDatosGenerales.Controls.Add(this.lblFechaEstreno);
            this.gbDatosGenerales.Controls.Add(this.cboGenero);
            this.gbDatosGenerales.Controls.Add(this.lblGenero);
            this.gbDatosGenerales.Controls.Add(this.txtNombre);
            this.gbDatosGenerales.Controls.Add(this.lblNombre);
            this.gbDatosGenerales.Controls.Add(this.txtIDPelicula);
            this.gbDatosGenerales.Controls.Add(this.lblIDPelicula);
            this.gbDatosGenerales.Controls.Add(this.btnSubirPortada);
            this.gbDatosGenerales.Controls.Add(this.pbPortada);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosGenerales.Location = new System.Drawing.Point(16, 37);
            this.gbDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatosGenerales.Size = new System.Drawing.Size(1268, 506);
            this.gbDatosGenerales.TabIndex = 1;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales de la Película";
            // 
            // cb3D
            // 
            this.cb3D.AutoSize = true;
            this.cb3D.Location = new System.Drawing.Point(1059, 267);
            this.cb3D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb3D.Name = "cb3D";
            this.cb3D.Size = new System.Drawing.Size(55, 24);
            this.cb3D.TabIndex = 22;
            this.cb3D.Text = "3D";
            this.cb3D.UseVisualStyleBackColor = true;
            // 
            // cbXtreme
            // 
            this.cbXtreme.AutoSize = true;
            this.cbXtreme.Location = new System.Drawing.Point(899, 267);
            this.cbXtreme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbXtreme.Name = "cbXtreme";
            this.cbXtreme.Size = new System.Drawing.Size(98, 24);
            this.cbXtreme.TabIndex = 21;
            this.cbXtreme.Text = "X-treme";
            this.cbXtreme.UseVisualStyleBackColor = true;
            // 
            // pbLogoProductora
            // 
            this.pbLogoProductora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogoProductora.Location = new System.Drawing.Point(988, 156);
            this.pbLogoProductora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogoProductora.Name = "pbLogoProductora";
            this.pbLogoProductora.Size = new System.Drawing.Size(263, 100);
            this.pbLogoProductora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoProductora.TabIndex = 20;
            this.pbLogoProductora.TabStop = false;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(13, 353);
            this.lblSinopsis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(87, 20);
            this.lblSinopsis.TabIndex = 19;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // lblCostoProduccion
            // 
            this.lblCostoProduccion.AutoSize = true;
            this.lblCostoProduccion.Location = new System.Drawing.Point(316, 303);
            this.lblCostoProduccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostoProduccion.Name = "lblCostoProduccion";
            this.lblCostoProduccion.Size = new System.Drawing.Size(190, 20);
            this.lblCostoProduccion.TabIndex = 18;
            this.lblCostoProduccion.Text = "Costo de Producción:";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(16, 378);
            this.txtSinopsis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(1235, 110);
            this.txtSinopsis.TabIndex = 17;
            // 
            // txtCostoProduccion
            // 
            this.txtCostoProduccion.Location = new System.Drawing.Point(544, 299);
            this.txtCostoProduccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCostoProduccion.Name = "txtCostoProduccion";
            this.txtCostoProduccion.Size = new System.Drawing.Size(228, 26);
            this.txtCostoProduccion.TabIndex = 16;
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Location = new System.Drawing.Point(545, 230);
            this.dtpFechaEstreno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(431, 26);
            this.dtpFechaEstreno.TabIndex = 9;
            // 
            // cboProductora
            // 
            this.cboProductora.FormattingEnabled = true;
            this.cboProductora.Location = new System.Drawing.Point(544, 193);
            this.cboProductora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProductora.Name = "cboProductora";
            this.cboProductora.Size = new System.Drawing.Size(432, 28);
            this.cboProductora.TabIndex = 15;
            this.cboProductora.SelectedIndexChanged += new System.EventHandler(this.cboProductora_SelectedIndexChanged);
            // 
            // lblProductora
            // 
            this.lblProductora.AutoSize = true;
            this.lblProductora.Location = new System.Drawing.Point(405, 197);
            this.lblProductora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductora.Name = "lblProductora";
            this.lblProductora.Size = new System.Drawing.Size(107, 20);
            this.lblProductora.TabIndex = 14;
            this.lblProductora.Text = "Productora:";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSuperior.Location = new System.Drawing.Point(285, 32);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(967, 40);
            this.panelSuperior.TabIndex = 13;
            // 
            // cbSubtitulada
            // 
            this.cbSubtitulada.AutoSize = true;
            this.cbSubtitulada.Location = new System.Drawing.Point(711, 267);
            this.cbSubtitulada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSubtitulada.Name = "cbSubtitulada";
            this.cbSubtitulada.Size = new System.Drawing.Size(125, 24);
            this.cbSubtitulada.TabIndex = 12;
            this.cbSubtitulada.Text = "Subtitulada";
            this.cbSubtitulada.UseVisualStyleBackColor = true;
            // 
            // cbDoblada
            // 
            this.cbDoblada.AutoSize = true;
            this.cbDoblada.Location = new System.Drawing.Point(545, 267);
            this.cbDoblada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDoblada.Name = "cbDoblada";
            this.cbDoblada.Size = new System.Drawing.Size(100, 24);
            this.cbDoblada.TabIndex = 11;
            this.cbDoblada.Text = "Doblada";
            this.cbDoblada.UseVisualStyleBackColor = true;
            this.cbDoblada.CheckedChanged += new System.EventHandler(this.cbDoblada_CheckedChanged);
            // 
            // lblFormatosDisponibles
            // 
            this.lblFormatosDisponibles.AutoSize = true;
            this.lblFormatosDisponibles.Location = new System.Drawing.Point(305, 268);
            this.lblFormatosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormatosDisponibles.Name = "lblFormatosDisponibles";
            this.lblFormatosDisponibles.Size = new System.Drawing.Size(199, 20);
            this.lblFormatosDisponibles.TabIndex = 10;
            this.lblFormatosDisponibles.Text = "Formatos Disponibles:";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(344, 235);
            this.lblFechaEstreno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(163, 20);
            this.lblFechaEstreno.TabIndex = 8;
            this.lblFechaEstreno.Text = "Fecha de Estreno:";
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(544, 156);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(432, 28);
            this.cboGenero.TabIndex = 7;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(440, 161);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(76, 20);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Género:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(544, 122);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(707, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(433, 126);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtIDPelicula
            // 
            this.txtIDPelicula.Location = new System.Drawing.Point(544, 85);
            this.txtIDPelicula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDPelicula.Name = "txtIDPelicula";
            this.txtIDPelicula.ReadOnly = true;
            this.txtIDPelicula.Size = new System.Drawing.Size(132, 26);
            this.txtIDPelicula.TabIndex = 3;
            this.txtIDPelicula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDPelicula
            // 
            this.lblIDPelicula.AutoSize = true;
            this.lblIDPelicula.Location = new System.Drawing.Point(355, 89);
            this.lblIDPelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDPelicula.Name = "lblIDPelicula";
            this.lblIDPelicula.Size = new System.Drawing.Size(154, 20);
            this.lblIDPelicula.TabIndex = 2;
            this.lblIDPelicula.Text = "ID de la Película:";
            // 
            // btnSubirPortada
            // 
            this.btnSubirPortada.BackgroundImage = global::MovieSoft.Properties.Resources.Upload;
            this.btnSubirPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirPortada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirPortada.Location = new System.Drawing.Point(227, 294);
            this.btnSubirPortada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubirPortada.Name = "btnSubirPortada";
            this.btnSubirPortada.Size = new System.Drawing.Size(51, 39);
            this.btnSubirPortada.TabIndex = 1;
            this.btnSubirPortada.UseVisualStyleBackColor = true;
            this.btnSubirPortada.Click += new System.EventHandler(this.btnSubirPortada_Click);
            // 
            // pbPortada
            // 
            this.pbPortada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPortada.Location = new System.Drawing.Point(16, 32);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(261, 301);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // ofdPortada
            // 
            this.ofdPortada.FileName = "ofdPortada";
            // 
            // frmGestionPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 558);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmGestionPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Gestión de Películas";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoProductora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.Button btnSubirPortada;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.OpenFileDialog ofdPortada;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDPelicula;
        private System.Windows.Forms.Label lblIDPelicula;
        private System.Windows.Forms.CheckBox cbSubtitulada;
        private System.Windows.Forms.CheckBox cbDoblada;
        private System.Windows.Forms.Label lblFormatosDisponibles;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.ComboBox cboProductora;
        private System.Windows.Forms.Label lblProductora;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblCostoProduccion;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtCostoProduccion;
        private System.Windows.Forms.PictureBox pbLogoProductora;
        private System.Windows.Forms.CheckBox cbXtreme;
        private System.Windows.Forms.CheckBox cb3D;
    }
}

