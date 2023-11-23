namespace ULearn.Alumno
{
    partial class frmReclamoDetalleAlumno
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
            this.llblDetalle = new System.Windows.Forms.LinkLabel();
            this.lblCodAlumno = new System.Windows.Forms.Label();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.lblFechaReclamo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llblDetalle
            // 
            this.llblDetalle.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.llblDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblDetalle.AutoSize = true;
            this.llblDetalle.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(145)))));
            this.llblDetalle.Location = new System.Drawing.Point(425, 22);
            this.llblDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblDetalle.Name = "llblDetalle";
            this.llblDetalle.Size = new System.Drawing.Size(59, 13);
            this.llblDetalle.TabIndex = 12;
            this.llblDetalle.TabStop = true;
            this.llblDetalle.Text = "Ver Detalle";
            this.llblDetalle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDetalle_LinkClicked);
            // 
            // lblCodAlumno
            // 
            this.lblCodAlumno.AutoSize = true;
            this.lblCodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodAlumno.Location = new System.Drawing.Point(271, 22);
            this.lblCodAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodAlumno.Name = "lblCodAlumno";
            this.lblCodAlumno.Size = new System.Drawing.Size(116, 17);
            this.lblCodAlumno.TabIndex = 11;
            this.lblCodAlumno.Text = "Código Alumno";
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblEvaluacion.Location = new System.Drawing.Point(153, 22);
            this.lblEvaluacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(87, 17);
            this.lblEvaluacion.TabIndex = 10;
            this.lblEvaluacion.Text = "Evaluacion";
            // 
            // lblFechaReclamo
            // 
            this.lblFechaReclamo.AutoSize = true;
            this.lblFechaReclamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechaReclamo.Location = new System.Drawing.Point(28, 22);
            this.lblFechaReclamo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaReclamo.Name = "lblFechaReclamo";
            this.lblFechaReclamo.Size = new System.Drawing.Size(104, 17);
            this.lblFechaReclamo.TabIndex = 9;
            this.lblFechaReclamo.Text = "DD/MM/YYYY";
            // 
            // frmReclamoDetalleAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 60);
            this.Controls.Add(this.llblDetalle);
            this.Controls.Add(this.lblCodAlumno);
            this.Controls.Add(this.lblEvaluacion);
            this.Controls.Add(this.lblFechaReclamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReclamoDetalleAlumno";
            this.Text = "frmReclamoDetalleAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblDetalle;
        private System.Windows.Forms.Label lblCodAlumno;
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.Label lblFechaReclamo;
    }
}