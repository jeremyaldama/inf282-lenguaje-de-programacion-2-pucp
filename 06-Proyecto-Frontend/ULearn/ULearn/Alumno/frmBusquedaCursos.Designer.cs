namespace ULearn.Alumno
{
    partial class frmBusquedaCursos
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttnLimpiar = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Controls.Add(this.bttnLimpiar);
            this.panelSuperior.Controls.Add(this.bttnBuscar);
            this.panelSuperior.Controls.Add(this.txtNombreCurso);
            this.panelSuperior.Controls.Add(this.lblNombre);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(825, 100);
            this.panelSuperior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUSQUEDA DE CURSOS";
            // 
            // bttnLimpiar
            // 
            this.bttnLimpiar.Location = new System.Drawing.Point(488, 56);
            this.bttnLimpiar.Name = "bttnLimpiar";
            this.bttnLimpiar.Size = new System.Drawing.Size(100, 23);
            this.bttnLimpiar.TabIndex = 3;
            this.bttnLimpiar.Text = "Limpiar";
            this.bttnLimpiar.UseVisualStyleBackColor = true;
            this.bttnLimpiar.Click += new System.EventHandler(this.bttnLimpiar_Click);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Location = new System.Drawing.Point(357, 55);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(94, 23);
            this.bttnBuscar.TabIndex = 2;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(137, 58);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(160, 20);
            this.txtNombreCurso.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(65, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // panelContenido
            // 
            this.panelContenido.Location = new System.Drawing.Point(0, 129);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(825, 321);
            this.panelContenido.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCreditos);
            this.panel1.Controls.Add(this.lblNombreCurso);
            this.panel1.Controls.Add(this.lblCodigoCurso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 34);
            this.panel1.TabIndex = 2;
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCurso.Location = new System.Drawing.Point(42, 13);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(82, 13);
            this.lblCodigoCurso.TabIndex = 0;
            this.lblCodigoCurso.Text = "Codigo Curso";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.Location = new System.Drawing.Point(197, 13);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(86, 13);
            this.lblNombreCurso.TabIndex = 1;
            this.lblNombreCurso.Text = "Nombre Curso";
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.Location = new System.Drawing.Point(421, 13);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(53, 13);
            this.lblCreditos.TabIndex = 2;
            this.lblCreditos.Text = "Creditos";
            // 
            // frmBusquedaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmBusquedaCursos";
            this.Text = "frmBusquedaCursos";
            this.Load += new System.EventHandler(this.frmBusquedaCursos_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button bttnLimpiar;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblCodigoCurso;
    }
}