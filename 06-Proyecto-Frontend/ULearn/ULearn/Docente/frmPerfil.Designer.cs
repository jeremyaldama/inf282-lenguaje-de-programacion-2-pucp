namespace ULearn.Docente
{
    partial class frmPerfil
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
            this.pboFoto = new System.Windows.Forms.PictureBox();
            this.gboxInfoPersonal = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxCredenciales = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActCont = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNuevaCont = new System.Windows.Forms.TextBox();
            this.lblNContra = new System.Windows.Forms.Label();
            this.txtContActual = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).BeginInit();
            this.gboxInfoPersonal.SuspendLayout();
            this.gboxCredenciales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboFoto
            // 
            this.pboFoto.Location = new System.Drawing.Point(41, 31);
            this.pboFoto.Name = "pboFoto";
            this.pboFoto.Size = new System.Drawing.Size(182, 193);
            this.pboFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboFoto.TabIndex = 0;
            this.pboFoto.TabStop = false;
            // 
            // gboxInfoPersonal
            // 
            this.gboxInfoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxInfoPersonal.Controls.Add(this.txtTipo);
            this.gboxInfoPersonal.Controls.Add(this.txtNombres);
            this.gboxInfoPersonal.Controls.Add(this.txtCodigo);
            this.gboxInfoPersonal.Controls.Add(this.lblTipo);
            this.gboxInfoPersonal.Controls.Add(this.lblNombre);
            this.gboxInfoPersonal.Controls.Add(this.lblCodigo);
            this.gboxInfoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gboxInfoPersonal.Location = new System.Drawing.Point(274, 31);
            this.gboxInfoPersonal.Name = "gboxInfoPersonal";
            this.gboxInfoPersonal.Size = new System.Drawing.Size(629, 212);
            this.gboxInfoPersonal.TabIndex = 2;
            this.gboxInfoPersonal.TabStop = false;
            this.gboxInfoPersonal.Text = "Información personal";
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(240, 148);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(175, 35);
            this.txtTipo.TabIndex = 5;
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(240, 90);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(287, 35);
            this.txtNombres.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(240, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(175, 35);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipo.Location = new System.Drawing.Point(38, 156);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(135, 25);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo Docente:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(38, 98);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(197, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres y Apellidos:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(38, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(39, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 536);
            this.panel1.TabIndex = 3;
            // 
            // gboxCredenciales
            // 
            this.gboxCredenciales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxCredenciales.Controls.Add(this.btnCancelar);
            this.gboxCredenciales.Controls.Add(this.btnSubirFoto);
            this.gboxCredenciales.Controls.Add(this.btnGuardar);
            this.gboxCredenciales.Controls.Add(this.btnActCont);
            this.gboxCredenciales.Controls.Add(this.btnEditar);
            this.gboxCredenciales.Controls.Add(this.txtNuevaCont);
            this.gboxCredenciales.Controls.Add(this.lblNContra);
            this.gboxCredenciales.Controls.Add(this.txtContActual);
            this.gboxCredenciales.Controls.Add(this.lblContra);
            this.gboxCredenciales.Controls.Add(this.txtNumero);
            this.gboxCredenciales.Controls.Add(this.txtCorreo);
            this.gboxCredenciales.Controls.Add(this.lblCelular);
            this.gboxCredenciales.Controls.Add(this.lblCorreo);
            this.gboxCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gboxCredenciales.Location = new System.Drawing.Point(274, 249);
            this.gboxCredenciales.Name = "gboxCredenciales";
            this.gboxCredenciales.Size = new System.Drawing.Size(629, 456);
            this.gboxCredenciales.TabIndex = 6;
            this.gboxCredenciales.TabStop = false;
            this.gboxCredenciales.Text = "Credenciales";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(285, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 39);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubirFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnSubirFoto.FlatAppearance.BorderSize = 0;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.btnSubirFoto.Location = new System.Drawing.Point(42, 316);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(145, 39);
            this.btnSubirFoto.TabIndex = 13;
            this.btnSubirFoto.Text = "Subir foto";
            this.btnSubirFoto.UseVisualStyleBackColor = false;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(511, 396);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 39);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActCont
            // 
            this.btnActCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnActCont.FlatAppearance.BorderSize = 0;
            this.btnActCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.btnActCont.Location = new System.Drawing.Point(43, 396);
            this.btnActCont.Name = "btnActCont";
            this.btnActCont.Size = new System.Drawing.Size(205, 39);
            this.btnActCont.TabIndex = 12;
            this.btnActCont.Text = "Actualizar contraseña";
            this.btnActCont.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(411, 396);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 39);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNuevaCont
            // 
            this.txtNuevaCont.Enabled = false;
            this.txtNuevaCont.Location = new System.Drawing.Point(240, 224);
            this.txtNuevaCont.Name = "txtNuevaCont";
            this.txtNuevaCont.PasswordChar = '*';
            this.txtNuevaCont.Size = new System.Drawing.Size(287, 35);
            this.txtNuevaCont.TabIndex = 8;
            // 
            // lblNContra
            // 
            this.lblNContra.AutoSize = true;
            this.lblNContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNContra.Location = new System.Drawing.Point(37, 232);
            this.lblNContra.Name = "lblNContra";
            this.lblNContra.Size = new System.Drawing.Size(191, 25);
            this.lblNContra.TabIndex = 7;
            this.lblNContra.Text = "Repetir Contraseña: ";
            // 
            // txtContActual
            // 
            this.txtContActual.Enabled = false;
            this.txtContActual.Location = new System.Drawing.Point(240, 167);
            this.txtContActual.Name = "txtContActual";
            this.txtContActual.PasswordChar = '*';
            this.txtContActual.Size = new System.Drawing.Size(287, 35);
            this.txtContActual.TabIndex = 6;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblContra.Location = new System.Drawing.Point(37, 175);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(182, 25);
            this.lblContra.TabIndex = 5;
            this.lblContra.Text = "Nueva Contraseña:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(240, 100);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(287, 35);
            this.txtNumero.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(240, 36);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(287, 35);
            this.txtCorreo.TabIndex = 3;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCelular.Location = new System.Drawing.Point(38, 108);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(149, 25);
            this.lblCelular.TabIndex = 1;
            this.lblCelular.Text = "Número celular:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCorreo.Location = new System.Drawing.Point(38, 43);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(177, 25);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 750);
            this.Controls.Add(this.gboxCredenciales);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gboxInfoPersonal);
            this.Controls.Add(this.pboFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil";
            this.Text = "frmPerfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).EndInit();
            this.gboxInfoPersonal.ResumeLayout(false);
            this.gboxInfoPersonal.PerformLayout();
            this.gboxCredenciales.ResumeLayout(false);
            this.gboxCredenciales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboFoto;
        private System.Windows.Forms.GroupBox gboxInfoPersonal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gboxCredenciales;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNContra;
        private System.Windows.Forms.TextBox txtContActual;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtNuevaCont;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActCont;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.Button btnCancelar;
    }
}