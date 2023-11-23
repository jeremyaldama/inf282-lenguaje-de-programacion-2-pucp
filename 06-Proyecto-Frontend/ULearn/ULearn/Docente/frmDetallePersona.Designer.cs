namespace ULearn.Docente
{
    partial class frmDetallePersona
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gboContacto = new System.Windows.Forms.GroupBox();
            this.txtNumeroCelular = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.gboAcademico = new System.Windows.Forms.GroupBox();
            this.btnHistorialAcademico = new System.Windows.Forms.Button();
            this.txtNivelAcademico = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboPersonal = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gboContacto.SuspendLayout();
            this.gboAcademico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.gboContacto);
            this.panel1.Controls.Add(this.gboAcademico);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.gboPersonal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 800);
            this.panel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.btnVolver.Location = new System.Drawing.Point(43, 33);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 39);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gboContacto
            // 
            this.gboContacto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboContacto.Controls.Add(this.txtNumeroCelular);
            this.gboContacto.Controls.Add(this.txtCorreoElectronico);
            this.gboContacto.Controls.Add(this.lblCelular);
            this.gboContacto.Controls.Add(this.lblCorreo);
            this.gboContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gboContacto.Location = new System.Drawing.Point(297, 319);
            this.gboContacto.Name = "gboContacto";
            this.gboContacto.Size = new System.Drawing.Size(669, 181);
            this.gboContacto.TabIndex = 16;
            this.gboContacto.TabStop = false;
            this.gboContacto.Text = "Contacto";
            // 
            // txtNumeroCelular
            // 
            this.txtNumeroCelular.Enabled = false;
            this.txtNumeroCelular.Location = new System.Drawing.Point(240, 100);
            this.txtNumeroCelular.Name = "txtNumeroCelular";
            this.txtNumeroCelular.Size = new System.Drawing.Size(287, 35);
            this.txtNumeroCelular.TabIndex = 4;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Enabled = false;
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(240, 36);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(391, 30);
            this.txtCorreoElectronico.TabIndex = 3;
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
            // gboAcademico
            // 
            this.gboAcademico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboAcademico.Controls.Add(this.btnHistorialAcademico);
            this.gboAcademico.Controls.Add(this.txtNivelAcademico);
            this.gboAcademico.Controls.Add(this.txtEspecialidad);
            this.gboAcademico.Controls.Add(this.lblNivel);
            this.gboAcademico.Controls.Add(this.lblCarrera);
            this.gboAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gboAcademico.Location = new System.Drawing.Point(297, 518);
            this.gboAcademico.Name = "gboAcademico";
            this.gboAcademico.Size = new System.Drawing.Size(669, 231);
            this.gboAcademico.TabIndex = 17;
            this.gboAcademico.TabStop = false;
            this.gboAcademico.Text = "Información Académica";
            // 
            // btnHistorialAcademico
            // 
            this.btnHistorialAcademico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorialAcademico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnHistorialAcademico.FlatAppearance.BorderSize = 0;
            this.btnHistorialAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.btnHistorialAcademico.Location = new System.Drawing.Point(427, 177);
            this.btnHistorialAcademico.Name = "btnHistorialAcademico";
            this.btnHistorialAcademico.Size = new System.Drawing.Size(236, 39);
            this.btnHistorialAcademico.TabIndex = 13;
            this.btnHistorialAcademico.Text = "Reporte Historial Académico";
            this.btnHistorialAcademico.UseVisualStyleBackColor = false;
            this.btnHistorialAcademico.Click += new System.EventHandler(this.btnHistorialAcademico_Click);
            // 
            // txtNivelAcademico
            // 
            this.txtNivelAcademico.Enabled = false;
            this.txtNivelAcademico.Location = new System.Drawing.Point(240, 100);
            this.txtNivelAcademico.Name = "txtNivelAcademico";
            this.txtNivelAcademico.Size = new System.Drawing.Size(287, 35);
            this.txtNivelAcademico.TabIndex = 4;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Enabled = false;
            this.txtEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(240, 36);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(391, 30);
            this.txtEspecialidad.TabIndex = 3;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNivel.Location = new System.Drawing.Point(38, 108);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(61, 25);
            this.lblNivel.TabIndex = 1;
            this.lblNivel.Text = "Nivel:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarrera.Location = new System.Drawing.Point(38, 43);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(129, 25);
            this.lblCarrera.TabIndex = 0;
            this.lblCarrera.Text = "Especialidad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(89, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 181);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // gboPersonal
            // 
            this.gboPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboPersonal.Controls.Add(this.txtTipo);
            this.gboPersonal.Controls.Add(this.txtNombres);
            this.gboPersonal.Controls.Add(this.txtCodigo);
            this.gboPersonal.Controls.Add(this.lblCondicion);
            this.gboPersonal.Controls.Add(this.lblNombre);
            this.gboPersonal.Controls.Add(this.lblCodigo);
            this.gboPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gboPersonal.Location = new System.Drawing.Point(297, 89);
            this.gboPersonal.Name = "gboPersonal";
            this.gboPersonal.Size = new System.Drawing.Size(669, 214);
            this.gboPersonal.TabIndex = 18;
            this.gboPersonal.TabStop = false;
            this.gboPersonal.Text = "Información personal";
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(240, 154);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(175, 35);
            this.txtTipo.TabIndex = 5;
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombres.Enabled = false;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(240, 96);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(391, 30);
            this.txtNombres.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(240, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(175, 35);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCondicion.Location = new System.Drawing.Point(38, 162);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(57, 25);
            this.lblCondicion.TabIndex = 2;
            this.lblCondicion.Text = "Tipo:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(38, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(197, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres y Apellidos:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigo.Location = new System.Drawing.Point(38, 49);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panel2.Location = new System.Drawing.Point(89, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 529);
            this.panel2.TabIndex = 15;
            // 
            // frmDetallePersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.panel1);
            this.Name = "frmDetallePersona";
            this.Text = "frmDetallePersona";
            this.Load += new System.EventHandler(this.frmDetallePersona_Load);
            this.panel1.ResumeLayout(false);
            this.gboContacto.ResumeLayout(false);
            this.gboContacto.PerformLayout();
            this.gboAcademico.ResumeLayout(false);
            this.gboAcademico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboPersonal.ResumeLayout(false);
            this.gboPersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gboContacto;
        private System.Windows.Forms.TextBox txtNumeroCelular;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.GroupBox gboAcademico;
        private System.Windows.Forms.Button btnHistorialAcademico;
        private System.Windows.Forms.TextBox txtNivelAcademico;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gboPersonal;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel panel2;
    }
}