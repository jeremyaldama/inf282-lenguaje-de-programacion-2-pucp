namespace ULearn.Docente
{
    partial class frmDetalleCurso
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
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCodCurso = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelInformacion.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInformacion
            // 
            this.panelInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelInformacion.Controls.Add(this.btnVolver);
            this.panelInformacion.Controls.Add(this.lblCodCurso);
            this.panelInformacion.Controls.Add(this.lblNombre);
            this.panelInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInformacion.Location = new System.Drawing.Point(0, 0);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(928, 78);
            this.panelInformacion.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(12, 26);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(126, 32);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCodCurso
            // 
            this.lblCodCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodCurso.AutoSize = true;
            this.lblCodCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCodCurso.Location = new System.Drawing.Point(488, 27);
            this.lblCodCurso.Name = "lblCodCurso";
            this.lblCodCurso.Size = new System.Drawing.Size(111, 32);
            this.lblCodCurso.TabIndex = 1;
            this.lblCodCurso.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(622, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(205, 26);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Curso";
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panelOpciones.Controls.Add(this.btnEstadisticas);
            this.panelOpciones.Controls.Add(this.btnCalificaciones);
            this.panelOpciones.Controls.Add(this.btnReclamos);
            this.panelOpciones.Controls.Add(this.btnAlumnos);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 78);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(152, 457);
            this.panelOpciones.TabIndex = 1;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEstadisticas.Image = global::ULearn.Properties.Resources.spreadsheet_app;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 258);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(152, 86);
            this.btnEstadisticas.TabIndex = 2;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnCalificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalificaciones.FlatAppearance.BorderSize = 0;
            this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnCalificaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalificaciones.Image = global::ULearn.Properties.Resources.marking;
            this.btnCalificaciones.Location = new System.Drawing.Point(0, 172);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(152, 86);
            this.btnCalificaciones.TabIndex = 1;
            this.btnCalificaciones.Text = "Calificaciones";
            this.btnCalificaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalificaciones.UseVisualStyleBackColor = false;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // btnReclamos
            // 
            this.btnReclamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnReclamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReclamos.FlatAppearance.BorderSize = 0;
            this.btnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReclamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnReclamos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReclamos.Image = global::ULearn.Properties.Resources.reclamo;
            this.btnReclamos.Location = new System.Drawing.Point(0, 86);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(152, 86);
            this.btnReclamos.TabIndex = 3;
            this.btnReclamos.Text = "Reclamos";
            this.btnReclamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReclamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReclamos.UseVisualStyleBackColor = false;
            this.btnReclamos.Click += new System.EventHandler(this.btnReclamos_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnAlumnos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlumnos.Image = global::ULearn.Properties.Resources.student;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 0);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(152, 86);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlumnos.UseVisualStyleBackColor = false;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(152, 78);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(776, 457);
            this.panelContenido.TabIndex = 2;
            // 
            // frmDetalleCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 535);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelInformacion);
            this.Name = "frmDetalleCurso";
            this.Load += new System.EventHandler(this.frmDetalleCurso_Load);
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.Label lblCodCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelContenido;
    }
}