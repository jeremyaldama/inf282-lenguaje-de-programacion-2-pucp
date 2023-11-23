namespace ULearn.Bibliotecario
{
    partial class frmReportes
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
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btnReporteLibros = new System.Windows.Forms.Button();
            this.btnReportePrestamos = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.PanelLateral.Controls.Add(this.btnReporteLibros);
            this.PanelLateral.Controls.Add(this.btnReportePrestamos);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(146, 617);
            this.PanelLateral.TabIndex = 6;
            // 
            // btnReporteLibros
            // 
            this.btnReporteLibros.FlatAppearance.BorderSize = 0;
            this.btnReporteLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteLibros.Image = global::ULearn.Properties.Resources.hourglass;
            this.btnReporteLibros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporteLibros.Location = new System.Drawing.Point(12, 116);
            this.btnReporteLibros.Name = "btnReporteLibros";
            this.btnReporteLibros.Size = new System.Drawing.Size(128, 111);
            this.btnReporteLibros.TabIndex = 4;
            this.btnReporteLibros.Text = "Préstamos Activos";
            this.btnReporteLibros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporteLibros.UseVisualStyleBackColor = true;
            this.btnReporteLibros.Click += new System.EventHandler(this.btnReporteLibros_Click);
            // 
            // btnReportePrestamos
            // 
            this.btnReportePrestamos.FlatAppearance.BorderSize = 0;
            this.btnReportePrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePrestamos.Image = global::ULearn.Properties.Resources.task;
            this.btnReportePrestamos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportePrestamos.Location = new System.Drawing.Point(12, 390);
            this.btnReportePrestamos.Name = "btnReportePrestamos";
            this.btnReportePrestamos.Size = new System.Drawing.Size(128, 117);
            this.btnReportePrestamos.TabIndex = 5;
            this.btnReportePrestamos.Text = "Préstamos Finalizados";
            this.btnReportePrestamos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportePrestamos.UseVisualStyleBackColor = true;
            this.btnReportePrestamos.Click += new System.EventHandler(this.btnReportePrestamos_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(146, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1082, 617);
            this.panelContenido.TabIndex = 7;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1228, 617);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.PanelLateral);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.PanelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReporteLibros;
        private System.Windows.Forms.Button btnReportePrestamos;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Panel panelContenido;
    }
}