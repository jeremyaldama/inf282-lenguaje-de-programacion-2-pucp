namespace ULearn.Docente
{
    partial class frmRegNota
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.cbFalto = new System.Windows.Forms.CheckBox();
            this.lblGuardado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.Location = new System.Drawing.Point(44, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 33);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Cod";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(187, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 33);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "nombre";
            // 
            // txtNota
            // 
            this.txtNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(709, 44);
            this.txtNota.MaxLength = 2;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(72, 30);
            this.txtNota.TabIndex = 2;
            this.txtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // cbFalto
            // 
            this.cbFalto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFalto.AutoSize = true;
            this.cbFalto.Location = new System.Drawing.Point(589, 47);
            this.cbFalto.Name = "cbFalto";
            this.cbFalto.Size = new System.Drawing.Size(71, 24);
            this.cbFalto.TabIndex = 3;
            this.cbFalto.Text = "Falta";
            this.cbFalto.UseVisualStyleBackColor = true;
            this.cbFalto.CheckedChanged += new System.EventHandler(this.cbFalto_CheckedChanged);
            // 
            // lblGuardado
            // 
            this.lblGuardado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuardado.AutoSize = true;
            this.lblGuardado.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.lblGuardado.ForeColor = System.Drawing.Color.Red;
            this.lblGuardado.Location = new System.Drawing.Point(408, 47);
            this.lblGuardado.Name = "lblGuardado";
            this.lblGuardado.Size = new System.Drawing.Size(149, 24);
            this.lblGuardado.TabIndex = 4;
            this.lblGuardado.Text = "Registro Exitoso";
            // 
            // frmRegNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(812, 100);
            this.Controls.Add(this.lblGuardado);
            this.Controls.Add(this.cbFalto);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegNota";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.CheckBox cbFalto;
        private System.Windows.Forms.Label lblGuardado;
    }
}