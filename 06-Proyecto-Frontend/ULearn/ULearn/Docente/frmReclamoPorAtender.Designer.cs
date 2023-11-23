namespace ULearn.Docente
{
    partial class frmReclamoPorAtender
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
            this.lblFechaReclamo = new System.Windows.Forms.Label();
            this.lblCodAlumno = new System.Windows.Forms.Label();
            this.llblDetalle = new System.Windows.Forms.LinkLabel();
            this.lblAtendido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFechaReclamo
            // 
            this.lblFechaReclamo.AutoSize = true;
            this.lblFechaReclamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechaReclamo.Location = new System.Drawing.Point(39, 35);
            this.lblFechaReclamo.Name = "lblFechaReclamo";
            this.lblFechaReclamo.Size = new System.Drawing.Size(148, 25);
            this.lblFechaReclamo.TabIndex = 5;
            this.lblFechaReclamo.Text = "DD/MM/YYYY";
            // 
            // lblCodAlumno
            // 
            this.lblCodAlumno.AutoSize = true;
            this.lblCodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodAlumno.Location = new System.Drawing.Point(245, 35);
            this.lblCodAlumno.Name = "lblCodAlumno";
            this.lblCodAlumno.Size = new System.Drawing.Size(160, 25);
            this.lblCodAlumno.TabIndex = 7;
            this.lblCodAlumno.Text = "Código Alumno";
            // 
            // llblDetalle
            // 
            this.llblDetalle.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.llblDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblDetalle.AutoSize = true;
            this.llblDetalle.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(145)))));
            this.llblDetalle.Location = new System.Drawing.Point(634, 35);
            this.llblDetalle.Name = "llblDetalle";
            this.llblDetalle.Size = new System.Drawing.Size(88, 20);
            this.llblDetalle.TabIndex = 8;
            this.llblDetalle.TabStop = true;
            this.llblDetalle.Text = "Ver Detalle";
            this.llblDetalle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDetalle_LinkClicked);
            // 
            // lblAtendido
            // 
            this.lblAtendido.AutoSize = true;
            this.lblAtendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAtendido.Location = new System.Drawing.Point(434, 35);
            this.lblAtendido.Name = "lblAtendido";
            this.lblAtendido.Size = new System.Drawing.Size(160, 25);
            this.lblAtendido.TabIndex = 9;
            this.lblAtendido.Text = "Código Alumno";
            // 
            // frmReclamoPorAtender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 92);
            this.Controls.Add(this.lblAtendido);
            this.Controls.Add(this.llblDetalle);
            this.Controls.Add(this.lblCodAlumno);
            this.Controls.Add(this.lblFechaReclamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReclamoPorAtender";
            this.Text = "frmReclamoPorAtender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaReclamo;
        private System.Windows.Forms.Label lblCodAlumno;
        private System.Windows.Forms.LinkLabel llblDetalle;
        private System.Windows.Forms.Label lblAtendido;
    }
}