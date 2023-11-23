namespace ULearn.Docente
{
    partial class frmCursos
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnHorario = new System.Windows.Forms.Button();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelCursosDictados = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblTipoHorarios = new System.Windows.Forms.Label();
            this.lblCreds = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFondo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblTotal.Location = new System.Drawing.Point(451, 57);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 22);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // lblSemestre
            // 
            this.lblSemestre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblSemestre.Location = new System.Drawing.Point(636, 57);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(66, 22);
            this.lblSemestre.TabIndex = 3;
            this.lblSemestre.Text = "Semestre";
            // 
            // txtSemestre
            // 
            this.txtSemestre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSemestre.Enabled = false;
            this.txtSemestre.Location = new System.Drawing.Point(708, 57);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(100, 26);
            this.txtSemestre.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(497, 55);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 7;
            // 
            // btnHorario
            // 
            this.btnHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHorario.Location = new System.Drawing.Point(839, 52);
            this.btnHorario.Name = "btnHorario";
            this.btnHorario.Size = new System.Drawing.Size(109, 32);
            this.btnHorario.TabIndex = 8;
            this.btnHorario.Text = "Horario";
            this.btnHorario.UseVisualStyleBackColor = true;
            this.btnHorario.Click += new System.EventHandler(this.btnHorario_Click);
            // 
            // panelFondo
            // 
            this.panelFondo.Controls.Add(this.panelCursosDictados);
            this.panelFondo.Controls.Add(this.panel1);
            this.panelFondo.Controls.Add(this.panelCabecera);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(978, 748);
            this.panelFondo.TabIndex = 10;
            // 
            // panelCursosDictados
            // 
            this.panelCursosDictados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panelCursosDictados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCursosDictados.Location = new System.Drawing.Point(0, 164);
            this.panelCursosDictados.Name = "panelCursosDictados";
            this.panelCursosDictados.Size = new System.Drawing.Size(978, 584);
            this.panelCursosDictados.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lblHorario);
            this.panel1.Controls.Add(this.lblTipoHorarios);
            this.panel1.Controls.Add(this.lblCreds);
            this.panel1.Controls.Add(this.lblNombreCurso);
            this.panel1.Controls.Add(this.lblCodigoCurso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 64);
            this.panel1.TabIndex = 2;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Noto Sans Cond", 10F, System.Drawing.FontStyle.Bold);
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(648, 24);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(142, 27);
            this.lblHorario.TabIndex = 20;
            this.lblHorario.Text = "Código Horario";
            // 
            // lblTipoHorarios
            // 
            this.lblTipoHorarios.AutoSize = true;
            this.lblTipoHorarios.Font = new System.Drawing.Font("Noto Sans Cond", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoHorarios.ForeColor = System.Drawing.Color.White;
            this.lblTipoHorarios.Location = new System.Drawing.Point(492, 24);
            this.lblTipoHorarios.Name = "lblTipoHorarios";
            this.lblTipoHorarios.Size = new System.Drawing.Size(118, 27);
            this.lblTipoHorarios.TabIndex = 19;
            this.lblTipoHorarios.Text = "Tipo Horario";
            // 
            // lblCreds
            // 
            this.lblCreds.AutoSize = true;
            this.lblCreds.Font = new System.Drawing.Font("Noto Sans Cond", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreds.ForeColor = System.Drawing.Color.White;
            this.lblCreds.Location = new System.Drawing.Point(357, 24);
            this.lblCreds.Name = "lblCreds";
            this.lblCreds.Size = new System.Drawing.Size(83, 27);
            this.lblCreds.TabIndex = 18;
            this.lblCreds.Text = "Créditos";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Noto Sans Cond", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreCurso.ForeColor = System.Drawing.Color.White;
            this.lblNombreCurso.Location = new System.Drawing.Point(142, 24);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(163, 27);
            this.lblNombreCurso.TabIndex = 17;
            this.lblNombreCurso.Text = "Nombre del curso";
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Font = new System.Drawing.Font("Noto Sans Cond", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodigoCurso.ForeColor = System.Drawing.Color.White;
            this.lblCodigoCurso.Location = new System.Drawing.Point(36, 24);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(72, 27);
            this.lblCodigoCurso.TabIndex = 16;
            this.lblCodigoCurso.Text = "Código";
            // 
            // panelCabecera
            // 
            this.panelCabecera.Controls.Add(this.label1);
            this.panelCabecera.Controls.Add(this.btnHorario);
            this.panelCabecera.Controls.Add(this.txtSemestre);
            this.panelCabecera.Controls.Add(this.lblTotal);
            this.panelCabecera.Controls.Add(this.lblSemestre);
            this.panelCabecera.Controls.Add(this.txtTotal);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(978, 100);
            this.panelCabecera.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cursos Dictados";
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 748);
            this.Controls.Add(this.panelFondo);
            this.Name = "frmCursos";
            this.Text = "frmCursos";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            this.panelFondo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnHorario;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblTipoHorarios;
        private System.Windows.Forms.Label lblCreds;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.Panel panelCursosDictados;
    }
}