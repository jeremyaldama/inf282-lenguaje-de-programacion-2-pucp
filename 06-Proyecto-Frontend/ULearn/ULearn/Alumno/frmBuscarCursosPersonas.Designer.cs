namespace ULearn.Alumno
{
    partial class frmBuscarCursosPersonas
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.bttnBusquedaCursos = new System.Windows.Forms.Button();
            this.bttnBusquedaPersonas = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panelLateral.Controls.Add(this.bttnBusquedaCursos);
            this.panelLateral.Controls.Add(this.bttnBusquedaPersonas);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(138, 609);
            this.panelLateral.TabIndex = 0;
            // 
            // bttnBusquedaCursos
            // 
            this.bttnBusquedaCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnBusquedaCursos.FlatAppearance.BorderSize = 0;
            this.bttnBusquedaCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBusquedaCursos.Image = global::ULearn.Properties.Resources.prestamos;
            this.bttnBusquedaCursos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnBusquedaCursos.Location = new System.Drawing.Point(12, 250);
            this.bttnBusquedaCursos.Name = "bttnBusquedaCursos";
            this.bttnBusquedaCursos.Size = new System.Drawing.Size(114, 56);
            this.bttnBusquedaCursos.TabIndex = 2;
            this.bttnBusquedaCursos.Text = "Cursos";
            this.bttnBusquedaCursos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnBusquedaCursos.UseVisualStyleBackColor = true;
            this.bttnBusquedaCursos.Click += new System.EventHandler(this.bttnBusquedaCursos_Click);
            // 
            // bttnBusquedaPersonas
            // 
            this.bttnBusquedaPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnBusquedaPersonas.FlatAppearance.BorderSize = 0;
            this.bttnBusquedaPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBusquedaPersonas.Image = global::ULearn.Properties.Resources.user;
            this.bttnBusquedaPersonas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnBusquedaPersonas.Location = new System.Drawing.Point(12, 154);
            this.bttnBusquedaPersonas.Name = "bttnBusquedaPersonas";
            this.bttnBusquedaPersonas.Size = new System.Drawing.Size(114, 56);
            this.bttnBusquedaPersonas.TabIndex = 1;
            this.bttnBusquedaPersonas.Text = "Personas";
            this.bttnBusquedaPersonas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnBusquedaPersonas.UseVisualStyleBackColor = true;
            this.bttnBusquedaPersonas.Click += new System.EventHandler(this.bttnBusquedaPersonas_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(138, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(772, 609);
            this.panelContenido.TabIndex = 1;
            // 
            // frmBuscarCursosPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 609);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelLateral);
            this.Name = "frmBuscarCursosPersonas";
            this.Text = "FormCursosPersonasSearch";
            this.Load += new System.EventHandler(this.FormCursosPersonasSearch_Load);
            this.panelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button bttnBusquedaCursos;
        private System.Windows.Forms.Button bttnBusquedaPersonas;
    }
}