namespace ULearn.Docente
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelLateral.Controls.Add(this.btnCerrarSesion);
            this.panelLateral.Controls.Add(this.btnEventos);
            this.panelLateral.Controls.Add(this.btnPersonas);
            this.panelLateral.Controls.Add(this.btnBiblioteca);
            this.panelLateral.Controls.Add(this.btnCursos);
            this.panelLateral.Controls.Add(this.btnPerfil);
            this.panelLateral.Controls.Add(this.pbLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 62);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(96, 513);
            this.panelLateral.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.Image = global::ULearn.Properties.Resources.exit1;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 441);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(96, 72);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnEventos.Image = global::ULearn.Properties.Resources.billboard;
            this.btnEventos.Location = new System.Drawing.Point(0, 247);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(96, 72);
            this.btnEventos.TabIndex = 5;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonas.FlatAppearance.BorderSize = 0;
            this.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnPersonas.Image = global::ULearn.Properties.Resources.search;
            this.btnPersonas.Location = new System.Drawing.Point(0, 189);
            this.btnPersonas.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(96, 58);
            this.btnPersonas.TabIndex = 4;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPersonas.UseVisualStyleBackColor = false;
            this.btnPersonas.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiblioteca.FlatAppearance.BorderSize = 0;
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnBiblioteca.Image = global::ULearn.Properties.Resources.prestamos;
            this.btnBiblioteca.Location = new System.Drawing.Point(0, 125);
            this.btnBiblioteca.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(96, 64);
            this.btnBiblioteca.TabIndex = 3;
            this.btnBiblioteca.Text = "Biblioteca";
            this.btnBiblioteca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBiblioteca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBiblioteca.UseVisualStyleBackColor = false;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnCursos.Image = global::ULearn.Properties.Resources.horario;
            this.btnCursos.Location = new System.Drawing.Point(0, 61);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(96, 64);
            this.btnCursos.TabIndex = 2;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnPerfil.Image = global::ULearn.Properties.Resources.user;
            this.btnPerfil.Location = new System.Drawing.Point(0, 0);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(96, 61);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(96, 58);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContenido.Location = new System.Drawing.Point(90, 62);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(947, 513);
            this.panelContenido.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panelSuperior.Controls.Add(this.lblBienvenido);
            this.panelSuperior.Controls.Add(this.pbCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1037, 62);
            this.panelSuperior.TabIndex = 1;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblBienvenido.Location = new System.Drawing.Point(11, 20);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(426, 24);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "BIENVENIDO: APELLIDO NOMBRE CODIGO";
            // 
            // pbCerrar
            // 
            this.pbCerrar.BackgroundImage = global::ULearn.Properties.Resources.arrow;
            this.pbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCerrar.Location = new System.Drawing.Point(978, 0);
            this.pbCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(59, 62);
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1037, 575);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblBienvenido;
    }
}