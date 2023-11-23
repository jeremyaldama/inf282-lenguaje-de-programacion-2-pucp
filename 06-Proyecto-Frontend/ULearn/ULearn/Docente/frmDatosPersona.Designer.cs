namespace ULearn.Docente
{
    partial class frmDatosPersona
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
            this.llblNombreApellido = new System.Windows.Forms.LinkLabel();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFacultad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llblNombreApellido
            // 
            this.llblNombreApellido.AutoSize = true;
            this.llblNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblNombreApellido.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.llblNombreApellido.Location = new System.Drawing.Point(169, 32);
            this.llblNombreApellido.Name = "llblNombreApellido";
            this.llblNombreApellido.Size = new System.Drawing.Size(163, 22);
            this.llblNombreApellido.TabIndex = 0;
            this.llblNombreApellido.TabStop = true;
            this.llblNombreApellido.Text = "Apellido, Nombre";
            this.llblNombreApellido.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNombreApellido_LinkClicked);
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPersona.Location = new System.Drawing.Point(790, 32);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(85, 25);
            this.lblTipoPersona.TabIndex = 1;
            this.lblTipoPersona.Text = "Alumno";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(36, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 25);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "C1111";
            // 
            // lblFacultad
            // 
            this.lblFacultad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFacultad.AutoSize = true;
            this.lblFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultad.Location = new System.Drawing.Point(628, 32);
            this.lblFacultad.Name = "lblFacultad";
            this.lblFacultad.Size = new System.Drawing.Size(95, 25);
            this.lblFacultad.TabIndex = 3;
            this.lblFacultad.Text = "Facultad";
            // 
            // frmDatosPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 88);
            this.Controls.Add(this.lblFacultad);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTipoPersona);
            this.Controls.Add(this.llblNombreApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatosPersona";
            this.Text = "frmDatosPersona";
            this.Load += new System.EventHandler(this.frmDatosPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblNombreApellido;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFacultad;
    }
}