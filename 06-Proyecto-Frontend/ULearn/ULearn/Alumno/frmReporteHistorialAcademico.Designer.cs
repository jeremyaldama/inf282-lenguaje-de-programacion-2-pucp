namespace ULearn.Alumno
{
    partial class frmReporteHistorialAcademico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteHistorialAcademico));
            this.PDFHistorial = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.PDFHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // PDFHistorial
            // 
            this.PDFHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDFHistorial.Enabled = true;
            this.PDFHistorial.Location = new System.Drawing.Point(0, 0);
            this.PDFHistorial.Name = "PDFHistorial";
            this.PDFHistorial.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFHistorial.OcxState")));
            this.PDFHistorial.Size = new System.Drawing.Size(800, 450);
            this.PDFHistorial.TabIndex = 0;
            // 
            // frmReporteHistorialAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PDFHistorial);
            this.Name = "frmReporteHistorialAcademico";
            this.Text = "Reporte de Historial Académico";
            ((System.ComponentModel.ISupportInitialize)(this.PDFHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF PDFHistorial;
    }
}