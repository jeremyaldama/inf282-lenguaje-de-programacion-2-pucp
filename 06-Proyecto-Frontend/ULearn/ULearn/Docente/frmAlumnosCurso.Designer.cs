namespace ULearn.Docente
{
    partial class frmAlumnosCurso
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
            this.lblListaAlumnos = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblListaAlumnos
            // 
            this.lblListaAlumnos.AutoSize = true;
            this.lblListaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblListaAlumnos.Location = new System.Drawing.Point(44, 28);
            this.lblListaAlumnos.Name = "lblListaAlumnos";
            this.lblListaAlumnos.Size = new System.Drawing.Size(245, 32);
            this.lblListaAlumnos.TabIndex = 0;
            this.lblListaAlumnos.Text = "Lista de alumnos";
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panelContenido.Location = new System.Drawing.Point(51, 89);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(697, 349);
            this.panelContenido.TabIndex = 6;
            // 
            // frmAlumnosCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.lblListaAlumnos);
            this.Name = "frmAlumnosCurso";
            this.Text = "frmAlumnosCurso";
            this.Load += new System.EventHandler(this.frmAlumnosCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaAlumnos;
        private System.Windows.Forms.Panel panelContenido;
    }
}