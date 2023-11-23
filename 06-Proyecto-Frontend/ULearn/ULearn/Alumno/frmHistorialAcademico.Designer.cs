namespace ULearn.Alumno
{
    partial class frmHistorialAcademico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblTotalCre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFaltantesCur = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCumplidosCre = new System.Windows.Forms.TextBox();
            this.lblFaltantesCre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRequeridosCre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAprobadosCur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalCur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRequeridosCur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requisitos de Egreso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cursos por semestre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Seleccionar semestre:";
            // 
            // cboSemestre
            // 
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Location = new System.Drawing.Point(301, 181);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(121, 21);
            this.cboSemestre.TabIndex = 18;
            this.cboSemestre.Text = "Todos";
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenido.Location = new System.Drawing.Point(15, 208);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(848, 348);
            this.panelContenido.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(450, 179);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.AutoSize = true;
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(720, 166);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Padding = new System.Windows.Forms.Padding(5);
            this.btnReporte.Size = new System.Drawing.Size(143, 36);
            this.btnReporte.TabIndex = 22;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblTotalCre
            // 
            this.lblTotalCre.Enabled = false;
            this.lblTotalCre.Location = new System.Drawing.Point(567, 60);
            this.lblTotalCre.Name = "lblTotalCre";
            this.lblTotalCre.Size = new System.Drawing.Size(65, 20);
            this.lblTotalCre.TabIndex = 18;
            this.lblTotalCre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(576, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Total";
            // 
            // lblFaltantesCur
            // 
            this.lblFaltantesCur.Enabled = false;
            this.lblFaltantesCur.Location = new System.Drawing.Point(332, 60);
            this.lblFaltantesCur.Name = "lblFaltantesCur";
            this.lblFaltantesCur.Size = new System.Drawing.Size(65, 20);
            this.lblFaltantesCur.TabIndex = 16;
            this.lblFaltantesCur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(336, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Faltantes";
            // 
            // lblCumplidosCre
            // 
            this.lblCumplidosCre.Enabled = false;
            this.lblCumplidosCre.Location = new System.Drawing.Point(648, 60);
            this.lblCumplidosCre.Name = "lblCumplidosCre";
            this.lblCumplidosCre.Size = new System.Drawing.Size(65, 20);
            this.lblCumplidosCre.TabIndex = 13;
            this.lblCumplidosCre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFaltantesCre
            // 
            this.lblFaltantesCre.Enabled = false;
            this.lblFaltantesCre.Location = new System.Drawing.Point(731, 60);
            this.lblFaltantesCre.Name = "lblFaltantesCre";
            this.lblFaltantesCre.Size = new System.Drawing.Size(65, 20);
            this.lblFaltantesCre.TabIndex = 14;
            this.lblFaltantesCre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cursos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Requeridos";
            // 
            // lblRequeridosCre
            // 
            this.lblRequeridosCre.Enabled = false;
            this.lblRequeridosCre.Location = new System.Drawing.Point(484, 60);
            this.lblRequeridosCre.Name = "lblRequeridosCre";
            this.lblRequeridosCre.Size = new System.Drawing.Size(65, 20);
            this.lblRequeridosCre.TabIndex = 12;
            this.lblRequeridosCre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // lblAprobadosCur
            // 
            this.lblAprobadosCur.Enabled = false;
            this.lblAprobadosCur.Location = new System.Drawing.Point(233, 60);
            this.lblAprobadosCur.Name = "lblAprobadosCur";
            this.lblAprobadosCur.Size = new System.Drawing.Size(65, 20);
            this.lblAprobadosCur.TabIndex = 11;
            this.lblAprobadosCur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aprobados";
            // 
            // lblTotalCur
            // 
            this.lblTotalCur.Enabled = false;
            this.lblTotalCur.Location = new System.Drawing.Point(146, 60);
            this.lblTotalCur.Name = "lblTotalCur";
            this.lblTotalCur.Size = new System.Drawing.Size(65, 20);
            this.lblTotalCur.TabIndex = 10;
            this.lblTotalCur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(613, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Créditos";
            // 
            // lblRequeridosCur
            // 
            this.lblRequeridosCur.Enabled = false;
            this.lblRequeridosCur.Location = new System.Drawing.Point(59, 60);
            this.lblRequeridosCur.Name = "lblRequeridosCur";
            this.lblRequeridosCur.Size = new System.Drawing.Size(65, 20);
            this.lblRequeridosCur.TabIndex = 9;
            this.lblRequeridosCur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Requeridos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(728, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Faltantes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(645, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Aprobados";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTotalCre);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblFaltantesCur);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblCumplidosCre);
            this.panel1.Controls.Add(this.lblFaltantesCre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblRequeridosCre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblAprobadosCur);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTotalCur);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblRequeridosCur);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(15, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 100);
            this.panel1.TabIndex = 23;
            // 
            // frmHistorialAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.cboSemestre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "frmHistorialAcademico";
            this.Text = "frmHistorialAcademico";
            this.Load += new System.EventHandler(this.frmHistorialAcademico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox lblTotalCre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox lblFaltantesCur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox lblCumplidosCre;
        private System.Windows.Forms.TextBox lblFaltantesCre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblRequeridosCre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblAprobadosCur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblTotalCur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lblRequeridosCur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}