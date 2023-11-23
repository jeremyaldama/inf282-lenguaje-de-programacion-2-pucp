namespace ULearn.Docente
{
    partial class frmResumenDatosRecurso
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblCampoTipo = new System.Windows.Forms.Label();
            this.lblCampoDisponible = new System.Windows.Forms.Label();
            this.pboPortada = new System.Windows.Forms.PictureBox();
            this.lblCampoBib = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pboPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(231, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoEllipsis = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblAutor.Location = new System.Drawing.Point(232, 59);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(463, 27);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor";
            // 
            // lblCampoTipo
            // 
            this.lblCampoTipo.AutoSize = true;
            this.lblCampoTipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoTipo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCampoTipo.Location = new System.Drawing.Point(232, 86);
            this.lblCampoTipo.Name = "lblCampoTipo";
            this.lblCampoTipo.Size = new System.Drawing.Size(129, 18);
            this.lblCampoTipo.TabIndex = 3;
            this.lblCampoTipo.Text = "Tipo de recurso: ";
            // 
            // lblCampoDisponible
            // 
            this.lblCampoDisponible.AutoSize = true;
            this.lblCampoDisponible.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoDisponible.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCampoDisponible.Location = new System.Drawing.Point(232, 132);
            this.lblCampoDisponible.Name = "lblCampoDisponible";
            this.lblCampoDisponible.Size = new System.Drawing.Size(94, 18);
            this.lblCampoDisponible.TabIndex = 4;
            this.lblCampoDisponible.Text = "Disponible: ";
            // 
            // pboPortada
            // 
            this.pboPortada.Image = global::ULearn.Properties.Resources.book1;
            this.pboPortada.Location = new System.Drawing.Point(59, 22);
            this.pboPortada.Name = "pboPortada";
            this.pboPortada.Size = new System.Drawing.Size(129, 128);
            this.pboPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboPortada.TabIndex = 1;
            this.pboPortada.TabStop = false;
            this.pboPortada.Click += new System.EventHandler(this.pboPortada_Click);
            // 
            // lblCampoBib
            // 
            this.lblCampoBib.AutoSize = true;
            this.lblCampoBib.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoBib.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCampoBib.Location = new System.Drawing.Point(232, 110);
            this.lblCampoBib.Name = "lblCampoBib";
            this.lblCampoBib.Size = new System.Drawing.Size(87, 18);
            this.lblCampoBib.TabIndex = 5;
            this.lblCampoBib.Text = "Biblioteca:";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDisponible.Location = new System.Drawing.Point(378, 132);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(94, 18);
            this.lblDisponible.TabIndex = 6;
            this.lblDisponible.Text = "Disponible: ";
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblBiblioteca.Location = new System.Drawing.Point(378, 110);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(94, 18);
            this.lblBiblioteca.TabIndex = 7;
            this.lblBiblioteca.Text = "Disponible: ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTipo.Location = new System.Drawing.Point(378, 86);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(94, 18);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Disponible: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 10);
            this.panel1.TabIndex = 9;
            // 
            // frmResumenDatosRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 183);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblBiblioteca);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblCampoBib);
            this.Controls.Add(this.lblCampoDisponible);
            this.Controls.Add(this.lblCampoTipo);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.pboPortada);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResumenDatosRecurso";
            this.Text = "frmResumenDatosRecurso";
            this.Click += new System.EventHandler(this.frmResumenDatosRecurso_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pboPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pboPortada;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblCampoTipo;
        private System.Windows.Forms.Label lblCampoDisponible;
        private System.Windows.Forms.Label lblCampoBib;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Panel panel1;
    }
}