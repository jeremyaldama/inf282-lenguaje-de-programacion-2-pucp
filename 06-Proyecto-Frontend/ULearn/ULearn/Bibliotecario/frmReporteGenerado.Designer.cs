namespace ULearn.Bibliotecario
{
    partial class frmReporteGenerado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteGenerado));
            this.panelSupReporte = new System.Windows.Forms.Panel();
            this.lblReporte = new System.Windows.Forms.Label();
            this.visorPDF = new AxAcroPDFLib.AxAcroPDF();
            this.panelSupReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSupReporte
            // 
            this.panelSupReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panelSupReporte.Controls.Add(this.lblReporte);
            this.panelSupReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupReporte.Location = new System.Drawing.Point(0, 0);
            this.panelSupReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSupReporte.Name = "panelSupReporte";
            this.panelSupReporte.Size = new System.Drawing.Size(809, 59);
            this.panelSupReporte.TabIndex = 1;
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReporte.Location = new System.Drawing.Point(31, 19);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(71, 24);
            this.lblReporte.TabIndex = 0;
            this.lblReporte.Text = "Reporte";
            // 
            // visorPDF
            // 
            this.visorPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visorPDF.Enabled = true;
            this.visorPDF.Location = new System.Drawing.Point(0, 59);
            this.visorPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visorPDF.Name = "visorPDF";
            this.visorPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("visorPDF.OcxState")));
            this.visorPDF.Size = new System.Drawing.Size(809, 507);
            this.visorPDF.TabIndex = 2;
            // 
            // frmReporteGenerado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 566);
            this.Controls.Add(this.visorPDF);
            this.Controls.Add(this.panelSupReporte);
            this.Name = "frmReporteGenerado";
            this.Text = "frmReporteGenerado";
            this.panelSupReporte.ResumeLayout(false);
            this.panelSupReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSupReporte;
        private System.Windows.Forms.Label lblReporte;
        private AxAcroPDFLib.AxAcroPDF visorPDF;
    }
}