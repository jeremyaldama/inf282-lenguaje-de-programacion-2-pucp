namespace ULearn.Administrador
{
    partial class frmAsuntosAcademicos
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
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnCarreras = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelOpciones.Controls.Add(this.btnHorarios);
            this.panelOpciones.Controls.Add(this.btnCursos);
            this.panelOpciones.Controls.Add(this.btnCarreras);
            this.panelOpciones.Controls.Add(this.btnAlumnos);
            this.panelOpciones.Controls.Add(this.btnDocentes);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(114, 680);
            this.panelOpciones.TabIndex = 15;
            // 
            // btnHorarios
            // 
            this.btnHorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorarios.FlatAppearance.BorderSize = 0;
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.Image = global::ULearn.Properties.Resources.horarios1;
            this.btnHorarios.Location = new System.Drawing.Point(0, 403);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(114, 99);
            this.btnHorarios.TabIndex = 23;
            this.btnHorarios.Text = "Gestionar\r\nHorarios";
            this.btnHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHorarios.UseVisualStyleBackColor = true;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCursos.Image = global::ULearn.Properties.Resources.cursos1;
            this.btnCursos.Location = new System.Drawing.Point(0, 304);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(114, 99);
            this.btnCursos.TabIndex = 22;
            this.btnCursos.Text = "Gestionar\r\nCursos";
            this.btnCursos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnCarreras
            // 
            this.btnCarreras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCarreras.FlatAppearance.BorderSize = 0;
            this.btnCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarreras.Image = global::ULearn.Properties.Resources.carreras1;
            this.btnCarreras.Location = new System.Drawing.Point(0, 205);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Size = new System.Drawing.Size(114, 99);
            this.btnCarreras.TabIndex = 21;
            this.btnCarreras.Text = "Gestionar\r\nCarreras\r\n";
            this.btnCarreras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCarreras.UseVisualStyleBackColor = true;
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Image = global::ULearn.Properties.Resources.alumnos_icono1;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 106);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(114, 99);
            this.btnAlumnos.TabIndex = 20;
            this.btnAlumnos.Text = "\r\nGestionar \r\nAlumnos";
            this.btnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocentes.FlatAppearance.BorderSize = 0;
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Image = global::ULearn.Properties.Resources.pizarra1;
            this.btnDocentes.Location = new System.Drawing.Point(0, 0);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(114, 106);
            this.btnDocentes.TabIndex = 19;
            this.btnDocentes.Text = "\r\nGestionar \r\nDocentes\r\n";
            this.btnDocentes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(114, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(991, 680);
            this.panelContenido.TabIndex = 17;
            // 
            // frmAsuntosAcademicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 680);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelOpciones);
            this.Name = "frmAsuntosAcademicos";
            this.Text = "frmAsuntosAcademicos";
            this.Load += new System.EventHandler(this.frmAsuntosAcademicos_Load);
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnCarreras;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Panel panelContenido;
    }
}