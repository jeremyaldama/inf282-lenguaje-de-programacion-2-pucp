namespace ULearn.Bibliotecario
{
    partial class frmGestionLibrosRecursos
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
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnRecursos = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panelOpciones.Controls.Add(this.btnAutores);
            this.panelOpciones.Controls.Add(this.btnRecursos);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(116, 543);
            this.panelOpciones.TabIndex = 0;
            // 
            // btnAutores
            // 
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.Image = global::ULearn.Properties.Resources.editor__1_;
            this.btnAutores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAutores.Location = new System.Drawing.Point(12, 368);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(98, 90);
            this.btnAutores.TabIndex = 3;
            this.btnAutores.Text = "Gestionar Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.FlatAppearance.BorderSize = 0;
            this.btnRecursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecursos.Image = global::ULearn.Properties.Resources.prestamos;
            this.btnRecursos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecursos.Location = new System.Drawing.Point(12, 121);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.Size = new System.Drawing.Size(98, 92);
            this.btnRecursos.TabIndex = 2;
            this.btnRecursos.Text = "Gestionar Recursos";
            this.btnRecursos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecursos.UseVisualStyleBackColor = true;
            this.btnRecursos.Click += new System.EventHandler(this.btnRecursos_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(116, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(921, 543);
            this.panelContenido.TabIndex = 1;
            // 
            // frmGestionLibrosRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 543);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelOpciones);
            this.Name = "frmGestionLibrosRecursos";
            this.Text = "frmGestionLibrosRecursos";
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnRecursos;
        private System.Windows.Forms.Panel panelContenido;
    }
}