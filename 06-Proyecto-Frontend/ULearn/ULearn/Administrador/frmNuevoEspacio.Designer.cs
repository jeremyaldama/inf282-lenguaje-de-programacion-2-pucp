namespace ULearn.Administrador
{
    partial class frmNuevoEspacio
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
            this.lblRegistroHorario = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnAula = new System.Windows.Forms.Button();
            this.btnSala = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panelSuperior.Controls.Add(this.lblRegistroHorario);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(812, 81);
            this.panelSuperior.TabIndex = 51;
            // 
            // lblRegistroHorario
            // 
            this.lblRegistroHorario.AutoSize = true;
            this.lblRegistroHorario.Font = new System.Drawing.Font("Noto Sans Cond", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegistroHorario.ForeColor = System.Drawing.Color.White;
            this.lblRegistroHorario.Location = new System.Drawing.Point(24, 18);
            this.lblRegistroHorario.Name = "lblRegistroHorario";
            this.lblRegistroHorario.Size = new System.Drawing.Size(291, 43);
            this.lblRegistroHorario.TabIndex = 0;
            this.lblRegistroHorario.Text = "Registro de Espacios";
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Controls.Add(this.btnAula);
            this.panelContenido.Controls.Add(this.btnSala);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 81);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(812, 480);
            this.panelContenido.TabIndex = 55;
            // 
            // btnAula
            // 
            this.btnAula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnAula.BackgroundImage = global::ULearn.Properties.Resources.aula;
            this.btnAula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAula.Location = new System.Drawing.Point(444, 86);
            this.btnAula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAula.Name = "btnAula";
            this.btnAula.Size = new System.Drawing.Size(281, 312);
            this.btnAula.TabIndex = 74;
            this.btnAula.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n Nueva Aula";
            this.btnAula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAula.UseVisualStyleBackColor = false;
            this.btnAula.Click += new System.EventHandler(this.btnAula_Click);
            // 
            // btnSala
            // 
            this.btnSala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnSala.BackgroundImage = global::ULearn.Properties.Resources.sala;
            this.btnSala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSala.Location = new System.Drawing.Point(84, 86);
            this.btnSala.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSala.Name = "btnSala";
            this.btnSala.Size = new System.Drawing.Size(281, 312);
            this.btnSala.TabIndex = 73;
            this.btnSala.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nNueva Sala";
            this.btnSala.UseVisualStyleBackColor = false;
            this.btnSala.Click += new System.EventHandler(this.btnSala_Click);
            // 
            // frmNuevoEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(812, 561);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNuevoEspacio";
            this.Text = "frmNuevoEspacio";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblRegistroHorario;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnAula;
        private System.Windows.Forms.Button btnSala;
    }
}