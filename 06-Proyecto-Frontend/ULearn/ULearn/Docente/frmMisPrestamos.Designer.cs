namespace ULearn.Docente
{
    partial class frmMisPrestamos
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
            this.panelListaPrestamos = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.lblAutores = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelListaPrestamos
            // 
            this.panelListaPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListaPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelListaPrestamos.Location = new System.Drawing.Point(20, 109);
            this.panelListaPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelListaPrestamos.Name = "panelListaPrestamos";
            this.panelListaPrestamos.Size = new System.Drawing.Size(1122, 394);
            this.panelListaPrestamos.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.lblTiempoRestante);
            this.panel1.Controls.Add(this.lblFechaPrestamo);
            this.panel1.Controls.Add(this.lblAutores);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(20, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 32);
            this.panel1.TabIndex = 2;
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTiempoRestante.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTiempoRestante.Location = new System.Drawing.Point(918, 6);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(67, 20);
            this.lblTiempoRestante.TabIndex = 9;
            this.lblTiempoRestante.Text = "Estado";
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechaPrestamo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(616, 6);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(131, 20);
            this.lblFechaPrestamo.TabIndex = 8;
            this.lblFechaPrestamo.Text = "Fecha registro";
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAutores.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAutores.Location = new System.Drawing.Point(297, 6);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(88, 20);
            this.lblAutores.TabIndex = 7;
            this.lblAutores.Text = "Autor(es)";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(23, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 20);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Título del Recurso";
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.AutoSize = true;
            this.lblPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.lblPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrestamos.ForeColor = System.Drawing.Color.Black;
            this.lblPrestamos.Location = new System.Drawing.Point(24, 9);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(295, 31);
            this.lblPrestamos.TabIndex = 1;
            this.lblPrestamos.Text = "Préstamos realizados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pulse sobre un préstamo para inspeccionar:";
            // 
            // frmMisPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrestamos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelListaPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMisPrestamos";
            this.Text = "Mis Prestamos";
            this.Load += new System.EventHandler(this.frmMisPrestamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelListaPrestamos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Label label1;
    }
}