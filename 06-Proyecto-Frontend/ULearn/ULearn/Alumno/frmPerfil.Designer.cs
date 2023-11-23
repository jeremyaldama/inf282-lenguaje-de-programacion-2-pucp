namespace ULearn.Alumno
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gboxInfoPersonal = new System.Windows.Forms.GroupBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxCredenciales = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtConfContra = new System.Windows.Forms.TextBox();
            this.lblCContra = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActFoto = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNuevaCont = new System.Windows.Forms.TextBox();
            this.lblNContra = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.gboxInfoPersonal.SuspendLayout();
            this.gboxCredenciales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(183, 22);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(118, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // gboxInfoPersonal
            // 
            this.gboxInfoPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxInfoPersonal.BackColor = System.Drawing.Color.White;
            this.gboxInfoPersonal.Controls.Add(this.txtNombres);
            this.gboxInfoPersonal.Controls.Add(this.txtCodigo);
            this.gboxInfoPersonal.Controls.Add(this.lblNombre);
            this.gboxInfoPersonal.Controls.Add(this.lblCodigo);
            this.gboxInfoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gboxInfoPersonal.Location = new System.Drawing.Point(183, 18);
            this.gboxInfoPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.gboxInfoPersonal.Name = "gboxInfoPersonal";
            this.gboxInfoPersonal.Padding = new System.Windows.Forms.Padding(2);
            this.gboxInfoPersonal.Size = new System.Drawing.Size(419, 100);
            this.gboxInfoPersonal.TabIndex = 12;
            this.gboxInfoPersonal.TabStop = false;
            this.gboxInfoPersonal.Text = "Información personal";
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(183, 58);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(223, 26);
            this.txtNombres.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(25, 64);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(141, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres y Apellidos:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(25, 28);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(31, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 348);
            this.panel1.TabIndex = 14;
            // 
            // gboxCredenciales
            // 
            this.gboxCredenciales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxCredenciales.BackColor = System.Drawing.Color.White;
            this.gboxCredenciales.Controls.Add(this.btnCancelar);
            this.gboxCredenciales.Controls.Add(this.txtConfContra);
            this.gboxCredenciales.Controls.Add(this.lblCContra);
            this.gboxCredenciales.Controls.Add(this.btnGuardar);
            this.gboxCredenciales.Controls.Add(this.btnActFoto);
            this.gboxCredenciales.Controls.Add(this.btnEditar);
            this.gboxCredenciales.Controls.Add(this.txtNuevaCont);
            this.gboxCredenciales.Controls.Add(this.lblNContra);
            this.gboxCredenciales.Controls.Add(this.txtNumero);
            this.gboxCredenciales.Controls.Add(this.txtCorreo);
            this.gboxCredenciales.Controls.Add(this.lblCelular);
            this.gboxCredenciales.Controls.Add(this.lblCorreo);
            this.gboxCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gboxCredenciales.Location = new System.Drawing.Point(183, 152);
            this.gboxCredenciales.Margin = new System.Windows.Forms.Padding(2);
            this.gboxCredenciales.Name = "gboxCredenciales";
            this.gboxCredenciales.Padding = new System.Windows.Forms.Padding(2);
            this.gboxCredenciales.Size = new System.Drawing.Size(419, 296);
            this.gboxCredenciales.TabIndex = 15;
            this.gboxCredenciales.TabStop = false;
            this.gboxCredenciales.Text = "Credenciales";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(238, 258);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 25);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtConfContra
            // 
            this.txtConfContra.Enabled = false;
            this.txtConfContra.Location = new System.Drawing.Point(183, 146);
            this.txtConfContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfContra.Name = "txtConfContra";
            this.txtConfContra.PasswordChar = '*';
            this.txtConfContra.Size = new System.Drawing.Size(223, 26);
            this.txtConfContra.TabIndex = 14;
            // 
            // lblCContra
            // 
            this.lblCContra.AutoSize = true;
            this.lblCContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCContra.Location = new System.Drawing.Point(25, 152);
            this.lblCContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCContra.Name = "lblCContra";
            this.lblCContra.Size = new System.Drawing.Size(139, 17);
            this.lblCContra.TabIndex = 13;
            this.lblCContra.Text = "Repetir Contraseña: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(328, 258);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 25);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActFoto
            // 
            this.btnActFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnActFoto.FlatAppearance.BorderSize = 0;
            this.btnActFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActFoto.Location = new System.Drawing.Point(28, 196);
            this.btnActFoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnActFoto.Name = "btnActFoto";
            this.btnActFoto.Size = new System.Drawing.Size(137, 25);
            this.btnActFoto.TabIndex = 12;
            this.btnActFoto.Text = "Subir Foto";
            this.btnActFoto.UseVisualStyleBackColor = false;
            this.btnActFoto.Click += new System.EventHandler(this.btnActFoto_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(147, 258);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 25);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNuevaCont
            // 
            this.txtNuevaCont.Enabled = false;
            this.txtNuevaCont.Location = new System.Drawing.Point(183, 108);
            this.txtNuevaCont.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaCont.Name = "txtNuevaCont";
            this.txtNuevaCont.PasswordChar = '*';
            this.txtNuevaCont.Size = new System.Drawing.Size(223, 26);
            this.txtNuevaCont.TabIndex = 8;
            // 
            // lblNContra
            // 
            this.lblNContra.AutoSize = true;
            this.lblNContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNContra.Location = new System.Drawing.Point(25, 114);
            this.lblNContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNContra.Name = "lblNContra";
            this.lblNContra.Size = new System.Drawing.Size(89, 17);
            this.lblNContra.TabIndex = 7;
            this.lblNContra.Text = "Contraseña: ";
            this.lblNContra.Click += new System.EventHandler(this.lblNContra_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(183, 64);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(118, 26);
            this.txtNumero.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(183, 23);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(223, 26);
            this.txtCorreo.TabIndex = 3;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCelular.Location = new System.Drawing.Point(25, 70);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(108, 17);
            this.lblCelular.TabIndex = 1;
            this.lblCelular.Text = "Número celular:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCorreo.Location = new System.Drawing.Point(25, 28);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(128, 17);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.Location = new System.Drawing.Point(32, 18);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(121, 125);
            this.pbFoto.TabIndex = 10;
            this.pbFoto.TabStop = false;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 487);
            this.Controls.Add(this.gboxCredenciales);
            this.Controls.Add(this.gboxInfoPersonal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil";
            this.Text = "frmPerfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.gboxInfoPersonal.ResumeLayout(false);
            this.gboxInfoPersonal.PerformLayout();
            this.gboxCredenciales.ResumeLayout(false);
            this.gboxCredenciales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gboxInfoPersonal;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.GroupBox gboxCredenciales;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActFoto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNuevaCont;
        private System.Windows.Forms.Label lblNContra;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtConfContra;
        private System.Windows.Forms.Label lblCContra;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Button btnCancelar;
    }
}