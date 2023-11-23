namespace ULearn.Alumno
{
    partial class frmRegistrarReclamo
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
            this.lblValNomEvaluacion = new System.Windows.Forms.Label();
            this.lblValNomAlumno = new System.Windows.Forms.Label();
            this.lblValCodAlumno = new System.Windows.Forms.Label();
            this.txtDescp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.bttnRegistrar = new System.Windows.Forms.Button();
            this.bttnBuscarEvaluacion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValNomEvaluacion
            // 
            this.lblValNomEvaluacion.AutoSize = true;
            this.lblValNomEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValNomEvaluacion.Location = new System.Drawing.Point(159, 118);
            this.lblValNomEvaluacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValNomEvaluacion.Name = "lblValNomEvaluacion";
            this.lblValNomEvaluacion.Size = new System.Drawing.Size(58, 17);
            this.lblValNomEvaluacion.TabIndex = 35;
            this.lblValNomEvaluacion.Text = "Nombre";
            // 
            // lblValNomAlumno
            // 
            this.lblValNomAlumno.AutoSize = true;
            this.lblValNomAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValNomAlumno.Location = new System.Drawing.Point(159, 76);
            this.lblValNomAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValNomAlumno.Name = "lblValNomAlumno";
            this.lblValNomAlumno.Size = new System.Drawing.Size(58, 17);
            this.lblValNomAlumno.TabIndex = 34;
            this.lblValNomAlumno.Text = "Nombre";
            // 
            // lblValCodAlumno
            // 
            this.lblValCodAlumno.AutoSize = true;
            this.lblValCodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValCodAlumno.Location = new System.Drawing.Point(159, 38);
            this.lblValCodAlumno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValCodAlumno.Name = "lblValCodAlumno";
            this.lblValCodAlumno.Size = new System.Drawing.Size(103, 17);
            this.lblValCodAlumno.TabIndex = 33;
            this.lblValCodAlumno.Text = "Código Alumno";
            // 
            // txtDescp
            // 
            this.txtDescp.Location = new System.Drawing.Point(162, 149);
            this.txtDescp.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescp.Multiline = true;
            this.txtDescp.Name = "txtDescp";
            this.txtDescp.Size = new System.Drawing.Size(285, 39);
            this.txtDescp.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Evaluación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código Alumno";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipo.Location = new System.Drawing.Point(41, 76);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(122, 17);
            this.lblTipo.TabIndex = 29;
            this.lblTipo.Text = "Nombre Alumno";
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripción.Location = new System.Drawing.Point(41, 149);
            this.lblDescripción.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(93, 17);
            this.lblDescripción.TabIndex = 28;
            this.lblDescripción.Text = "Descripción";
            // 
            // bttnRegistrar
            // 
            this.bttnRegistrar.Location = new System.Drawing.Point(289, 219);
            this.bttnRegistrar.Name = "bttnRegistrar";
            this.bttnRegistrar.Size = new System.Drawing.Size(158, 23);
            this.bttnRegistrar.TabIndex = 36;
            this.bttnRegistrar.Text = "Registrar Reclamo";
            this.bttnRegistrar.UseVisualStyleBackColor = true;
            this.bttnRegistrar.Click += new System.EventHandler(this.bttnRegistrar_Click);
            // 
            // bttnBuscarEvaluacion
            // 
            this.bttnBuscarEvaluacion.Location = new System.Drawing.Point(337, 38);
            this.bttnBuscarEvaluacion.Name = "bttnBuscarEvaluacion";
            this.bttnBuscarEvaluacion.Size = new System.Drawing.Size(110, 23);
            this.bttnBuscarEvaluacion.TabIndex = 37;
            this.bttnBuscarEvaluacion.Text = "Buscar Evaluacion";
            this.bttnBuscarEvaluacion.UseVisualStyleBackColor = true;
            this.bttnBuscarEvaluacion.Click += new System.EventHandler(this.bttnBuscarEvaluacion_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(44, 213);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(64, 29);
            this.btnVolver.TabIndex = 38;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmRegistrarReclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 262);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.bttnBuscarEvaluacion);
            this.Controls.Add(this.bttnRegistrar);
            this.Controls.Add(this.lblValNomEvaluacion);
            this.Controls.Add(this.lblValNomAlumno);
            this.Controls.Add(this.lblValCodAlumno);
            this.Controls.Add(this.txtDescp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDescripción);
            this.Name = "frmRegistrarReclamo";
            this.Text = "frmRegistrarReclamo";
            this.Load += new System.EventHandler(this.frmRegistrarReclamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValNomEvaluacion;
        private System.Windows.Forms.Label lblValNomAlumno;
        private System.Windows.Forms.Label lblValCodAlumno;
        private System.Windows.Forms.TextBox txtDescp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Button bttnRegistrar;
        private System.Windows.Forms.Button bttnBuscarEvaluacion;
        private System.Windows.Forms.Button btnVolver;
    }
}