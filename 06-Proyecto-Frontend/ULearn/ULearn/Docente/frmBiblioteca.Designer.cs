namespace ULearn.Docente
{
    partial class frmBiblioteca
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
            this.tspHerramientasBib = new System.Windows.Forms.ToolStrip();
            this.btnBuscarRecurso = new System.Windows.Forms.ToolStripButton();
            this.btnPrestamos = new System.Windows.Forms.ToolStripButton();
            this.btnAyuda = new System.Windows.Forms.ToolStripButton();
            this.lblSistemaBiblioteca = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            this.tspHerramientasBib.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panelSuperior.Controls.Add(this.tspHerramientasBib);
            this.panelSuperior.Controls.Add(this.lblSistemaBiblioteca);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1185, 95);
            this.panelSuperior.TabIndex = 0;
            // 
            // tspHerramientasBib
            // 
            this.tspHerramientasBib.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tspHerramientasBib.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscarRecurso,
            this.btnPrestamos,
            this.btnAyuda});
            this.tspHerramientasBib.Location = new System.Drawing.Point(0, 0);
            this.tspHerramientasBib.Name = "tspHerramientasBib";
            this.tspHerramientasBib.Size = new System.Drawing.Size(1185, 31);
            this.tspHerramientasBib.Stretch = true;
            this.tspHerramientasBib.TabIndex = 1;
            this.tspHerramientasBib.Text = "toolStrip1";
            // 
            // btnBuscarRecurso
            // 
            this.btnBuscarRecurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarRecurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.btnBuscarRecurso.Image = global::ULearn.Properties.Resources.search1;
            this.btnBuscarRecurso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscarRecurso.Name = "btnBuscarRecurso";
            this.btnBuscarRecurso.Size = new System.Drawing.Size(185, 28);
            this.btnBuscarRecurso.Text = "Catálogo de Recursos";
            this.btnBuscarRecurso.Click += new System.EventHandler(this.btnBuscarRecurso_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.btnPrestamos.Image = global::ULearn.Properties.Resources.bookshelf;
            this.btnPrestamos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(137, 28);
            this.btnPrestamos.Text = "Mis Préstamos";
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = global::ULearn.Properties.Resources.support;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(79, 28);
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.ToolTipText = "Ayuda";
            // 
            // lblSistemaBiblioteca
            // 
            this.lblSistemaBiblioteca.AutoSize = true;
            this.lblSistemaBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblSistemaBiblioteca.ForeColor = System.Drawing.Color.White;
            this.lblSistemaBiblioteca.Location = new System.Drawing.Point(19, 44);
            this.lblSistemaBiblioteca.Name = "lblSistemaBiblioteca";
            this.lblSistemaBiblioteca.Size = new System.Drawing.Size(295, 31);
            this.lblSistemaBiblioteca.TabIndex = 0;
            this.lblSistemaBiblioteca.Text = "Sistema de Biblioteca";
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 95);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1185, 573);
            this.panelContenido.TabIndex = 1;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 668);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBiblioteca";
            this.Text = "frmBiblioteca";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.tspHerramientasBib.ResumeLayout(false);
            this.tspHerramientasBib.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblSistemaBiblioteca;
        private System.Windows.Forms.ToolStrip tspHerramientasBib;
        private System.Windows.Forms.ToolStripButton btnBuscarRecurso;
        private System.Windows.Forms.ToolStripButton btnPrestamos;
        private System.Windows.Forms.ToolStripButton btnAyuda;
    }
}