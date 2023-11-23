namespace ULearn.Alumno
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnBusquedaPersonas = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnHistorialAcademico = new System.Windows.Forms.Button();
            this.btnHorario = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.panelIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panelSuperior.Controls.Add(this.lblCiclo);
            this.panelSuperior.Controls.Add(this.lblBienvenido);
            this.panelSuperior.Controls.Add(this.pbCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1040, 62);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblBienvenido.Location = new System.Drawing.Point(11, 23);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(426, 24);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "BIENVENIDO: APELLIDO NOMBRE CODIGO";
            this.lblBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCerrar.Image = global::ULearn.Properties.Resources.arrow1;
            this.pbCerrar.Location = new System.Drawing.Point(981, 0);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(59, 62);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelIzquierdo.Controls.Add(this.btnSalir);
            this.panelIzquierdo.Controls.Add(this.btnReclamos);
            this.panelIzquierdo.Controls.Add(this.btnEventos);
            this.panelIzquierdo.Controls.Add(this.btnBusquedaPersonas);
            this.panelIzquierdo.Controls.Add(this.btnPrestamos);
            this.panelIzquierdo.Controls.Add(this.btnHistorialAcademico);
            this.panelIzquierdo.Controls.Add(this.btnHorario);
            this.panelIzquierdo.Controls.Add(this.btnPerfil);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 62);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(138, 581);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::ULearn.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(0, 527);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 54);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReclamos
            // 
            this.btnReclamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReclamos.FlatAppearance.BorderSize = 0;
            this.btnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReclamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclamos.Image = global::ULearn.Properties.Resources.reclamo;
            this.btnReclamos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReclamos.Location = new System.Drawing.Point(0, 433);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(138, 60);
            this.btnReclamos.TabIndex = 4;
            this.btnReclamos.Text = "Reclamos";
            this.btnReclamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReclamos.UseVisualStyleBackColor = true;
            this.btnReclamos.Click += new System.EventHandler(this.btnReclamos_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.Image = global::ULearn.Properties.Resources.calendario__1_;
            this.btnEventos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEventos.Location = new System.Drawing.Point(0, 365);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(138, 68);
            this.btnEventos.TabIndex = 5;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnBusquedaPersonas
            // 
            this.btnBusquedaPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBusquedaPersonas.FlatAppearance.BorderSize = 0;
            this.btnBusquedaPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaPersonas.Image = global::ULearn.Properties.Resources.search;
            this.btnBusquedaPersonas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusquedaPersonas.Location = new System.Drawing.Point(0, 295);
            this.btnBusquedaPersonas.Name = "btnBusquedaPersonas";
            this.btnBusquedaPersonas.Size = new System.Drawing.Size(138, 70);
            this.btnBusquedaPersonas.TabIndex = 3;
            this.btnBusquedaPersonas.Text = "Cursos/Personas";
            this.btnBusquedaPersonas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusquedaPersonas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBusquedaPersonas.UseVisualStyleBackColor = true;
            this.btnBusquedaPersonas.Click += new System.EventHandler(this.btnBusquedaPersonas_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.Image = global::ULearn.Properties.Resources.prestamos;
            this.btnPrestamos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrestamos.Location = new System.Drawing.Point(0, 228);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(138, 67);
            this.btnPrestamos.TabIndex = 2;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnHistorialAcademico
            // 
            this.btnHistorialAcademico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialAcademico.FlatAppearance.BorderSize = 0;
            this.btnHistorialAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialAcademico.Image = global::ULearn.Properties.Resources.historialAcademico;
            this.btnHistorialAcademico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHistorialAcademico.Location = new System.Drawing.Point(0, 144);
            this.btnHistorialAcademico.Name = "btnHistorialAcademico";
            this.btnHistorialAcademico.Padding = new System.Windows.Forms.Padding(1);
            this.btnHistorialAcademico.Size = new System.Drawing.Size(138, 84);
            this.btnHistorialAcademico.TabIndex = 1;
            this.btnHistorialAcademico.Text = "Historial Academico";
            this.btnHistorialAcademico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorialAcademico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHistorialAcademico.UseVisualStyleBackColor = true;
            this.btnHistorialAcademico.Click += new System.EventHandler(this.btnHistorialAcademico_Click);
            // 
            // btnHorario
            // 
            this.btnHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHorario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorario.FlatAppearance.BorderSize = 0;
            this.btnHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario.Image = global::ULearn.Properties.Resources.horario;
            this.btnHorario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHorario.Location = new System.Drawing.Point(0, 76);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(138, 68);
            this.btnHorario.TabIndex = 1;
            this.btnHorario.Text = "Horario";
            this.btnHorario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHorario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHorario.UseVisualStyleBackColor = true;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
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
            this.btnPerfil.Size = new System.Drawing.Size(138, 76);
            this.btnPerfil.TabIndex = 0;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContenido.Location = new System.Drawing.Point(135, 62);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(905, 581);
            this.panelContenido.TabIndex = 2;
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCiclo.Location = new System.Drawing.Point(831, 23);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(69, 24);
            this.lblCiclo.TabIndex = 2;
            this.lblCiclo.Text = "Ciclo: ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 643);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "GestionAlumnos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.panelIzquierdo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Button btnBusquedaPersonas;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnHistorialAcademico;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label lblCiclo;
    }
}