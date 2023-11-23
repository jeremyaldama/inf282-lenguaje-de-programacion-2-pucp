namespace ULearn.Alumno
{
    partial class frmDatosCursoAlumno
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
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Location = new System.Drawing.Point(56, 19);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(70, 13);
            this.lblCodigoCurso.TabIndex = 0;
            this.lblCodigoCurso.Text = "Codigo Curso";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Location = new System.Drawing.Point(211, 19);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(74, 13);
            this.lblNombreCurso.TabIndex = 1;
            this.lblNombreCurso.Text = "Nombre Curso";
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Location = new System.Drawing.Point(436, 19);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(45, 13);
            this.lblCreditos.TabIndex = 2;
            this.lblCreditos.Text = "Creditos";
            // 
            // frmDatosCursoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 41);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.lblCodigoCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatosCursoAlumno";
            this.Text = "frmDatosCursoAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblCreditos;
    }
}