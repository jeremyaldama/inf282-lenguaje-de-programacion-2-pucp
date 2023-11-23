namespace ULearn.Administrador
{
    partial class frmLogistica
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
            this.btnFacultad = new System.Windows.Forms.Button();
            this.btnEspacios = new System.Windows.Forms.Button();
            this.btnEncargadosBiblioteca = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelOpciones.Controls.Add(this.button1);
            this.panelOpciones.Controls.Add(this.btnFacultad);
            this.panelOpciones.Controls.Add(this.btnEspacios);
            this.panelOpciones.Controls.Add(this.btnEncargadosBiblioteca);
            this.panelOpciones.Controls.Add(this.btnEventos);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(114, 651);
            this.panelOpciones.TabIndex = 20;
            // 
            // btnFacultad
            // 
            this.btnFacultad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacultad.FlatAppearance.BorderSize = 0;
            this.btnFacultad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacultad.Image = global::ULearn.Properties.Resources.school_1_;
            this.btnFacultad.Location = new System.Drawing.Point(0, 324);
            this.btnFacultad.Name = "btnFacultad";
            this.btnFacultad.Size = new System.Drawing.Size(114, 99);
            this.btnFacultad.TabIndex = 22;
            this.btnFacultad.Text = "\r\nGestionar Facultad";
            this.btnFacultad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFacultad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFacultad.UseVisualStyleBackColor = true;
            this.btnFacultad.Click += new System.EventHandler(this.btnFacultad_Click);
            // 
            // btnEspacios
            // 
            this.btnEspacios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEspacios.FlatAppearance.BorderSize = 0;
            this.btnEspacios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspacios.Image = global::ULearn.Properties.Resources.salon;
            this.btnEspacios.Location = new System.Drawing.Point(0, 211);
            this.btnEspacios.Name = "btnEspacios";
            this.btnEspacios.Size = new System.Drawing.Size(114, 113);
            this.btnEspacios.TabIndex = 21;
            this.btnEspacios.Text = "\r\nGestionar\r\nEspacios\r\n";
            this.btnEspacios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEspacios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEspacios.UseVisualStyleBackColor = true;
            this.btnEspacios.Click += new System.EventHandler(this.btnEspacios_Click);
            // 
            // btnEncargadosBiblioteca
            // 
            this.btnEncargadosBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncargadosBiblioteca.FlatAppearance.BorderSize = 0;
            this.btnEncargadosBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncargadosBiblioteca.Image = global::ULearn.Properties.Resources.bibliotecade45;
            this.btnEncargadosBiblioteca.Location = new System.Drawing.Point(0, 112);
            this.btnEncargadosBiblioteca.Name = "btnEncargadosBiblioteca";
            this.btnEncargadosBiblioteca.Size = new System.Drawing.Size(114, 99);
            this.btnEncargadosBiblioteca.TabIndex = 20;
            this.btnEncargadosBiblioteca.Text = "\r\nGestionar\r\nBibliotecarios";
            this.btnEncargadosBiblioteca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEncargadosBiblioteca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEncargadosBiblioteca.UseVisualStyleBackColor = true;
            this.btnEncargadosBiblioteca.Click += new System.EventHandler(this.btnEncargadosBiblioteca_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Image = global::ULearn.Properties.Resources.billboard45;
            this.btnEventos.Location = new System.Drawing.Point(0, 0);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(114, 112);
            this.btnEventos.TabIndex = 19;
            this.btnEventos.Text = "\r\nGestionar\r\nEventos";
            this.btnEventos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(114, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(991, 651);
            this.panelContenido.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ULearn.Properties.Resources.school_1_;
            this.button1.Location = new System.Drawing.Point(0, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 99);
            this.button1.TabIndex = 23;
            this.button1.Text = "\r\nGestionar Semestre";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 651);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelOpciones);
            this.Name = "frmLogistica";
            this.Text = "frmLogistica";
            this.panelOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnEspacios;
        private System.Windows.Forms.Button btnEncargadosBiblioteca;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnFacultad;
        private System.Windows.Forms.Button button1;
    }
}