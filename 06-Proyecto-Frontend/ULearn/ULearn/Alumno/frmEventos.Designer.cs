namespace ULearn.Alumno
{
    partial class frmEventos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.bttnCharla = new System.Windows.Forms.Button();
            this.bttnTalleres = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.bttnCharla);
            this.panel1.Controls.Add(this.bttnTalleres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 622);
            this.panel1.TabIndex = 1;
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(141, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(799, 622);
            this.panelContenido.TabIndex = 2;
            // 
            // bttnCharla
            // 
            this.bttnCharla.FlatAppearance.BorderSize = 0;
            this.bttnCharla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCharla.Image = global::ULearn.Properties.Resources.conferencia_en_linea;
            this.bttnCharla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnCharla.Location = new System.Drawing.Point(12, 266);
            this.bttnCharla.Name = "bttnCharla";
            this.bttnCharla.Padding = new System.Windows.Forms.Padding(1);
            this.bttnCharla.Size = new System.Drawing.Size(114, 63);
            this.bttnCharla.TabIndex = 3;
            this.bttnCharla.Text = "Charla";
            this.bttnCharla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnCharla.UseVisualStyleBackColor = true;
            this.bttnCharla.Click += new System.EventHandler(this.bttnCharla_Click);
            // 
            // bttnTalleres
            // 
            this.bttnTalleres.FlatAppearance.BorderSize = 0;
            this.bttnTalleres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnTalleres.Image = global::ULearn.Properties.Resources.formacion__1_;
            this.bttnTalleres.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnTalleres.Location = new System.Drawing.Point(12, 168);
            this.bttnTalleres.Name = "bttnTalleres";
            this.bttnTalleres.Padding = new System.Windows.Forms.Padding(1);
            this.bttnTalleres.Size = new System.Drawing.Size(114, 63);
            this.bttnTalleres.TabIndex = 2;
            this.bttnTalleres.Text = "Taller";
            this.bttnTalleres.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnTalleres.UseVisualStyleBackColor = true;
            this.bttnTalleres.Click += new System.EventHandler(this.bttnTalleres_Click);
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 622);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panel1);
            this.Name = "frmEventos";
            this.Text = "formEventos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttnCharla;
        private System.Windows.Forms.Button bttnTalleres;
        private System.Windows.Forms.Panel panelContenido;
    }
}