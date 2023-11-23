namespace ULearn.Bibliotecario
{
    partial class frmNuevoDigital
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
            this.txtRepositorio = new System.Windows.Forms.TextBox();
            this.lblRepositorio = new System.Windows.Forms.Label();
            this.lblDescargable = new System.Windows.Forms.Label();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRepositorio
            // 
            this.txtRepositorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepositorio.Location = new System.Drawing.Point(97, 12);
            this.txtRepositorio.Name = "txtRepositorio";
            this.txtRepositorio.Size = new System.Drawing.Size(231, 24);
            this.txtRepositorio.TabIndex = 11;
            // 
            // lblRepositorio
            // 
            this.lblRepositorio.AutoSize = true;
            this.lblRepositorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepositorio.Location = new System.Drawing.Point(2, 15);
            this.lblRepositorio.Name = "lblRepositorio";
            this.lblRepositorio.Size = new System.Drawing.Size(89, 18);
            this.lblRepositorio.TabIndex = 8;
            this.lblRepositorio.Text = "Repositorio:";
            // 
            // lblDescargable
            // 
            this.lblDescargable.AutoSize = true;
            this.lblDescargable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescargable.Location = new System.Drawing.Point(346, 15);
            this.lblDescargable.Name = "lblDescargable";
            this.lblDescargable.Size = new System.Drawing.Size(95, 18);
            this.lblDescargable.TabIndex = 6;
            this.lblDescargable.Text = "Descargable:";
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSi.Location = new System.Drawing.Point(447, 13);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(42, 22);
            this.rbSi.TabIndex = 12;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Sí";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(492, 13);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(49, 22);
            this.rbNo.TabIndex = 13;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(49, 49);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(42, 18);
            this.lblURL.TabIndex = 14;
            this.lblURL.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(97, 46);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(444, 24);
            this.txtURL.TabIndex = 15;
            // 
            // frmNuevoDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(583, 90);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbSi);
            this.Controls.Add(this.txtRepositorio);
            this.Controls.Add(this.lblRepositorio);
            this.Controls.Add(this.lblDescargable);
            this.Name = "frmNuevoDigital";
            this.Text = "NuevoDigital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRepositorio;
        private System.Windows.Forms.Label lblRepositorio;
        private System.Windows.Forms.Label lblDescargable;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
    }
}