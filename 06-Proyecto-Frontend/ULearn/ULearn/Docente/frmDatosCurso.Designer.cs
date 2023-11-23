namespace ULearn.Docente
{
    partial class frmDatosCurso
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
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblCreds = new System.Windows.Forms.Label();
            this.lblTipoHorarios = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.llblDetalle = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Font = new System.Drawing.Font("Noto Sans Cond", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodigoCurso.Location = new System.Drawing.Point(42, 45);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(60, 27);
            this.lblCodigoCurso.TabIndex = 0;
            this.lblCodigoCurso.Text = "INF---";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Noto Sans Cond", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreCurso.Location = new System.Drawing.Point(148, 45);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(146, 27);
            this.lblNombreCurso.TabIndex = 1;
            this.lblNombreCurso.Text = "NOMBRE CURSO";
            // 
            // lblCreds
            // 
            this.lblCreds.AutoSize = true;
            this.lblCreds.Font = new System.Drawing.Font("Noto Sans Cond", 10F, System.Drawing.FontStyle.Bold);
            this.lblCreds.Location = new System.Drawing.Point(435, 45);
            this.lblCreds.Name = "lblCreds";
            this.lblCreds.Size = new System.Drawing.Size(37, 27);
            this.lblCreds.TabIndex = 2;
            this.lblCreds.Text = "4.5";
            // 
            // lblTipoHorarios
            // 
            this.lblTipoHorarios.AutoSize = true;
            this.lblTipoHorarios.Font = new System.Drawing.Font("Noto Sans Cond", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoHorarios.Location = new System.Drawing.Point(534, 45);
            this.lblTipoHorarios.Name = "lblTipoHorarios";
            this.lblTipoHorarios.Size = new System.Drawing.Size(51, 27);
            this.lblTipoHorarios.TabIndex = 3;
            this.lblTipoHorarios.Text = "C,P,L";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Noto Sans Cond", 10F, System.Drawing.FontStyle.Bold);
            this.lblHorario.Location = new System.Drawing.Point(630, 45);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(55, 27);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "H101";
            // 
            // llblDetalle
            // 
            this.llblDetalle.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.llblDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblDetalle.AutoSize = true;
            this.llblDetalle.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(145)))));
            this.llblDetalle.Location = new System.Drawing.Point(719, 50);
            this.llblDetalle.Name = "llblDetalle";
            this.llblDetalle.Size = new System.Drawing.Size(88, 20);
            this.llblDetalle.TabIndex = 5;
            this.llblDetalle.TabStop = true;
            this.llblDetalle.Text = "Ver Detalle";
            this.llblDetalle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDetalle_LinkClicked);
            // 
            // frmDatosCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 123);
            this.Controls.Add(this.llblDetalle);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblTipoHorarios);
            this.Controls.Add(this.lblCreds);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.lblCodigoCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatosCurso";
            this.Text = "frmDatosCurso";
            this.Load += new System.EventHandler(this.frmDatosCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblCreds;
        private System.Windows.Forms.Label lblTipoHorarios;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.LinkLabel llblDetalle;
    }
}