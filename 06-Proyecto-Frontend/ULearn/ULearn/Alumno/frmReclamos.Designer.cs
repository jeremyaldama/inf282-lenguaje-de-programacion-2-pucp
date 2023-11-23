namespace ULearn.Alumno
{
    partial class frmReclamos
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
            this.panelReclamo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblListaAlumnos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnBuscarReclamos = new System.Windows.Forms.Button();
            this.bttnRegistrarReclamo = new System.Windows.Forms.Button();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.lblCodAlumno = new System.Windows.Forms.Label();
            this.lblFechaReclamo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReclamo
            // 
            this.panelReclamo.Location = new System.Drawing.Point(0, 160);
            this.panelReclamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelReclamo.Name = "panelReclamo";
            this.panelReclamo.Size = new System.Drawing.Size(1002, 480);
            this.panelReclamo.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblListaAlumnos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 55);
            this.panel1.TabIndex = 4;
            // 
            // lblListaAlumnos
            // 
            this.lblListaAlumnos.AutoSize = true;
            this.lblListaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblListaAlumnos.Location = new System.Drawing.Point(12, 9);
            this.lblListaAlumnos.Name = "lblListaAlumnos";
            this.lblListaAlumnos.Size = new System.Drawing.Size(319, 32);
            this.lblListaAlumnos.TabIndex = 1;
            this.lblListaAlumnos.Text = "Reclamos Registrados";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bttnBuscarReclamos);
            this.panel2.Controls.Add(this.bttnRegistrarReclamo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 55);
            this.panel2.TabIndex = 11;
            // 
            // bttnBuscarReclamos
            // 
            this.bttnBuscarReclamos.Location = new System.Drawing.Point(596, 11);
            this.bttnBuscarReclamos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnBuscarReclamos.Name = "bttnBuscarReclamos";
            this.bttnBuscarReclamos.Size = new System.Drawing.Size(174, 35);
            this.bttnBuscarReclamos.TabIndex = 12;
            this.bttnBuscarReclamos.Text = "Buscar Reclamos";
            this.bttnBuscarReclamos.UseVisualStyleBackColor = true;
            this.bttnBuscarReclamos.Click += new System.EventHandler(this.bttnBuscarReclamos_Click_1);
            // 
            // bttnRegistrarReclamo
            // 
            this.bttnRegistrarReclamo.Location = new System.Drawing.Point(778, 11);
            this.bttnRegistrarReclamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnRegistrarReclamo.Name = "bttnRegistrarReclamo";
            this.bttnRegistrarReclamo.Size = new System.Drawing.Size(206, 35);
            this.bttnRegistrarReclamo.TabIndex = 11;
            this.bttnRegistrarReclamo.Text = "Registrar Reclamo";
            this.bttnRegistrarReclamo.UseVisualStyleBackColor = true;
            this.bttnRegistrarReclamo.Click += new System.EventHandler(this.bttnRegistrarReclamo_Click);
            // 
            // panelLabels
            // 
            this.panelLabels.Controls.Add(this.lblEvaluacion);
            this.panelLabels.Controls.Add(this.lblCodAlumno);
            this.panelLabels.Controls.Add(this.lblFechaReclamo);
            this.panelLabels.Location = new System.Drawing.Point(0, 111);
            this.panelLabels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(1002, 54);
            this.panelLabels.TabIndex = 0;
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblEvaluacion.Location = new System.Drawing.Point(218, 18);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(118, 25);
            this.lblEvaluacion.TabIndex = 12;
            this.lblEvaluacion.Text = "Evaluacion";
            // 
            // lblCodAlumno
            // 
            this.lblCodAlumno.AutoSize = true;
            this.lblCodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodAlumno.Location = new System.Drawing.Point(398, 18);
            this.lblCodAlumno.Name = "lblCodAlumno";
            this.lblCodAlumno.Size = new System.Drawing.Size(160, 25);
            this.lblCodAlumno.TabIndex = 13;
            this.lblCodAlumno.Text = "Código Alumno";
            // 
            // lblFechaReclamo
            // 
            this.lblFechaReclamo.AutoSize = true;
            this.lblFechaReclamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechaReclamo.Location = new System.Drawing.Point(60, 18);
            this.lblFechaReclamo.Name = "lblFechaReclamo";
            this.lblFechaReclamo.Size = new System.Drawing.Size(72, 25);
            this.lblFechaReclamo.TabIndex = 11;
            this.lblFechaReclamo.Text = "Fecha";
            // 
            // frmReclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 957);
            this.Controls.Add(this.panelLabels);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelReclamo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReclamos";
            this.Text = "FormReclamos";
            this.Load += new System.EventHandler(this.frmReclamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelReclamo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblListaAlumnos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttnRegistrarReclamo;
        private System.Windows.Forms.Button bttnBuscarReclamos;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.Label lblCodAlumno;
        private System.Windows.Forms.Label lblFechaReclamo;
    }
}