namespace ULearn.Docente
{
    partial class frmReporteCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCurso));
            this.panelSupReporte = new System.Windows.Forms.Panel();
            this.lblReporte = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visorPDF = new AxAcroPDFLib.AxAcroPDF();
            this.panelSupReporte.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSupReporte
            // 
            this.panelSupReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panelSupReporte.Controls.Add(this.lblReporte);
            this.panelSupReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupReporte.Location = new System.Drawing.Point(0, 0);
            this.panelSupReporte.Name = "panelSupReporte";
            this.panelSupReporte.Size = new System.Drawing.Size(1052, 74);
            this.panelSupReporte.TabIndex = 0;
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReporte.Location = new System.Drawing.Point(35, 24);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(238, 29);
            this.lblReporte.TabIndex = 0;
            this.lblReporte.Text = "Reporte de Desempeño ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.visorPDF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 518);
            this.panel1.TabIndex = 1;
            // 
            // visorPDF
            // 
            this.visorPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visorPDF.Enabled = true;
            this.visorPDF.Location = new System.Drawing.Point(0, 0);
            this.visorPDF.Name = "visorPDF";
            this.visorPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("visorPDF.OcxState")));
            this.visorPDF.Size = new System.Drawing.Size(1052, 518);
            this.visorPDF.TabIndex = 0;
            // 
            // frmReporteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSupReporte);
            this.Name = "frmReporteCurso";
            this.Text = "Reporte de Curso";
            this.panelSupReporte.ResumeLayout(false);
            this.panelSupReporte.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSupReporte;
        private System.Windows.Forms.Panel panel1;
        private AxAcroPDFLib.AxAcroPDF visorPDF;
        private System.Windows.Forms.Label lblReporte;
    }
}