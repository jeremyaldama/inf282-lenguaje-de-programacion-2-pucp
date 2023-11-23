namespace ULearn.Administrador
{
    partial class frmNuevoEvento
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblRegistroEvento = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnTaller = new System.Windows.Forms.Button();
            this.btnCharla = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panelSuperior.Controls.Add(this.lblRegistroEvento);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(812, 81);
            this.panelSuperior.TabIndex = 52;
            // 
            // lblRegistroEvento
            // 
            this.lblRegistroEvento.AutoSize = true;
            this.lblRegistroEvento.Font = new System.Drawing.Font("Noto Sans Cond", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegistroEvento.ForeColor = System.Drawing.Color.White;
            this.lblRegistroEvento.Location = new System.Drawing.Point(24, 18);
            this.lblRegistroEvento.Name = "lblRegistroEvento";
            this.lblRegistroEvento.Size = new System.Drawing.Size(283, 43);
            this.lblRegistroEvento.TabIndex = 0;
            this.lblRegistroEvento.Text = "Registro de Eventos";
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.btnTaller);
            this.panelContenido.Controls.Add(this.btnCharla);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 81);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(812, 480);
            this.panelContenido.TabIndex = 56;
            // 
            // btnTaller
            // 
            this.btnTaller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnTaller.BackgroundImage = global::ULearn.Properties.Resources.taller100;
            this.btnTaller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaller.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaller.Location = new System.Drawing.Point(446, 88);
            this.btnTaller.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaller.Name = "btnTaller";
            this.btnTaller.Size = new System.Drawing.Size(281, 312);
            this.btnTaller.TabIndex = 73;
            this.btnTaller.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n Nuevo Taller";
            this.btnTaller.UseVisualStyleBackColor = false;
            this.btnTaller.Click += new System.EventHandler(this.btnTaller_Click);
            // 
            // btnCharla
            // 
            this.btnCharla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCharla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnCharla.BackgroundImage = global::ULearn.Properties.Resources.conferencia_en_linea100;
            this.btnCharla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCharla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCharla.Location = new System.Drawing.Point(80, 88);
            this.btnCharla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCharla.Name = "btnCharla";
            this.btnCharla.Size = new System.Drawing.Size(281, 312);
            this.btnCharla.TabIndex = 72;
            this.btnCharla.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n  \r\n\r\n\r\n  \r\n  Nueva Charla";
            this.btnCharla.UseVisualStyleBackColor = false;
            this.btnCharla.Click += new System.EventHandler(this.btnCharla_Click);
            // 
            // frmNuevoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 561);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNuevoEvento";
            this.Text = "frmNuevoEvento";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblRegistroEvento;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnTaller;
        private System.Windows.Forms.Button btnCharla;
    }
}