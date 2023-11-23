namespace ULearn.Docente
{
    partial class frmReclamos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabReclamos = new System.Windows.Forms.TabControl();
            this.tabpageAtender = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabReclamos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListaAlumnos
            // 
            this.lblListaAlumnos.AutoSize = true;
            this.lblListaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblListaAlumnos.Location = new System.Drawing.Point(12, 9);
            this.lblListaAlumnos.Name = "lblListaAlumnos";
            this.lblListaAlumnos.Size = new System.Drawing.Size(319, 32);
            this.lblListaAlumnos.TabIndex = 1;
            this.lblListaAlumnos.Text = "Reclamos Registrados";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblListaAlumnos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabReclamos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 394);
            this.panel2.TabIndex = 4;
            // 
            // tabReclamos
            // 
            this.tabReclamos.Controls.Add(this.tabpageAtender);
            this.tabReclamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReclamos.Location = new System.Drawing.Point(0, 0);
            this.tabReclamos.Name = "tabReclamos";
            this.tabReclamos.SelectedIndex = 0;
            this.tabReclamos.Size = new System.Drawing.Size(800, 394);
            this.tabReclamos.TabIndex = 3;
            // 
            // tabpageAtender
            // 
            this.tabpageAtender.AutoScroll = true;
            this.tabpageAtender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tabpageAtender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tabpageAtender.Location = new System.Drawing.Point(4, 29);
            this.tabpageAtender.Name = "tabpageAtender";
            this.tabpageAtender.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAtender.Size = new System.Drawing.Size(792, 361);
            this.tabpageAtender.TabIndex = 0;
            this.tabpageAtender.Text = "Por atender";
            // 
            // frmReclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReclamos";
            this.Text = "frmReclamos";
            this.Load += new System.EventHandler(this.frmReclamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabReclamos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListaAlumnos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabReclamos;
        private System.Windows.Forms.TabPage tabpageAtender;
    }
}