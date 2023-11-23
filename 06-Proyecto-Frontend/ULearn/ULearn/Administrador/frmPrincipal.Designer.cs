namespace ULearn.Administrador
{
    partial class frmPrincipal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnLogistica = new System.Windows.Forms.Button();
            this.btnAcademico = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.btnCerrarSesion);
            this.panel2.Controls.Add(this.btnLogistica);
            this.panel2.Controls.Add(this.btnAcademico);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 618);
            this.panel2.TabIndex = 5;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panelSuperior.Controls.Add(this.lblNombre);
            this.panelSuperior.Controls.Add(this.lblAdministrador);
            this.panelSuperior.Controls.Add(this.pictureBox2);
            this.panelSuperior.Controls.Add(this.pbCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1237, 79);
            this.panelSuperior.TabIndex = 6;
            this.panelSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperior_Paint);
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelContenido.Location = new System.Drawing.Point(114, 79);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1123, 539);
            this.panelContenido.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::ULearn.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCerrar.Image = global::ULearn.Properties.Resources.arrow;
            this.pbCerrar.Location = new System.Drawing.Point(1152, 0);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(85, 79);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 1;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = global::ULearn.Properties.Resources.exit1;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 337);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(114, 99);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "\r\nCerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnLogistica
            // 
            this.btnLogistica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogistica.FlatAppearance.BorderSize = 0;
            this.btnLogistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogistica.Image = global::ULearn.Properties.Resources.gestion_de_equipos;
            this.btnLogistica.Location = new System.Drawing.Point(0, 213);
            this.btnLogistica.Name = "btnLogistica";
            this.btnLogistica.Size = new System.Drawing.Size(114, 124);
            this.btnLogistica.TabIndex = 8;
            this.btnLogistica.Text = "\r\nGestionar logística";
            this.btnLogistica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogistica.UseVisualStyleBackColor = true;
            this.btnLogistica.Click += new System.EventHandler(this.btnLogistica_Click);
            // 
            // btnAcademico
            // 
            this.btnAcademico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcademico.FlatAppearance.BorderSize = 0;
            this.btnAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcademico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAcademico.Image = global::ULearn.Properties.Resources.academic45;
            this.btnAcademico.Location = new System.Drawing.Point(0, 79);
            this.btnAcademico.Margin = new System.Windows.Forms.Padding(1);
            this.btnAcademico.Name = "btnAcademico";
            this.btnAcademico.Size = new System.Drawing.Size(114, 134);
            this.btnAcademico.TabIndex = 7;
            this.btnAcademico.Text = "\r\nGestionar\r\n asuntos\r\n académicos";
            this.btnAcademico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAcademico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAcademico.UseVisualStyleBackColor = true;
            this.btnAcademico.Click += new System.EventHandler(this.btnAcademico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 79);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdministrador.Location = new System.Drawing.Point(134, 29);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(241, 29);
            this.lblAdministrador.TabIndex = 3;
            this.lblAdministrador.Text = "ADMINISTRADOR -";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(381, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 29);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "label1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1237, 618);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.panel2.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogistica;
        private System.Windows.Forms.Button btnAcademico;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Label lblNombre;
    }
}