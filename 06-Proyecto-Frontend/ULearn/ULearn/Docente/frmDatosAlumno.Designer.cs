namespace ULearn.Docente
{
    partial class frmDatosAlumno
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
            this.lblFacultad = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.LinkLabel();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFacultad
            // 
            this.lblFacultad.AutoSize = true;
            this.lblFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.lblFacultad.Location = new System.Drawing.Point(458, 32);
            this.lblFacultad.Name = "lblFacultad";
            this.lblFacultad.Size = new System.Drawing.Size(87, 22);
            this.lblFacultad.TabIndex = 6;
            this.lblFacultad.Text = "Facultad";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(23, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 25);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "C1111";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.lblNombreApellido.Location = new System.Drawing.Point(151, 30);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(163, 22);
            this.lblNombreApellido.TabIndex = 4;
            this.lblNombreApellido.TabStop = true;
            this.lblNombreApellido.Text = "Apellido, Nombre";
            this.lblNombreApellido.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNombreApellido_LinkClicked);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.Location = new System.Drawing.Point(627, 30);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(173, 22);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "a1111@gmail.com";
            // 
            // frmDatosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 73);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblFacultad);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombreApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatosAlumno";
            this.Text = "frmDatosAlumno";
            this.Load += new System.EventHandler(this.frmDatosAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFacultad;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.LinkLabel lblNombreApellido;
        private System.Windows.Forms.Label lblCorreo;
    }
}