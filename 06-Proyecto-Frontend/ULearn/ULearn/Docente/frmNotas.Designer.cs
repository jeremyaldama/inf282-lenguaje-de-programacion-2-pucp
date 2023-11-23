namespace ULearn.Docente
{
    partial class frmNotas
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
            this.lblListaAlumnos = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboEval = new System.Windows.Forms.ComboBox();
            this.lblEval = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelCont = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListaAlumnos
            // 
            this.lblListaAlumnos.AutoSize = true;
            this.lblListaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblListaAlumnos.Location = new System.Drawing.Point(24, 18);
            this.lblListaAlumnos.Name = "lblListaAlumnos";
            this.lblListaAlumnos.Size = new System.Drawing.Size(356, 32);
            this.lblListaAlumnos.TabIndex = 2;
            this.lblListaAlumnos.Text = "Gestión de calificaciones";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.White;
            this.panelSuperior.Controls.Add(this.btnEditar);
            this.panelSuperior.Controls.Add(this.btnGuardar);
            this.panelSuperior.Controls.Add(this.cboEval);
            this.panelSuperior.Controls.Add(this.lblEval);
            this.panelSuperior.Controls.Add(this.lblListaAlumnos);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(908, 115);
            this.panelSuperior.TabIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(608, 51);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(133, 44);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(763, 51);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 44);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboEval
            // 
            this.cboEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboEval.FormattingEnabled = true;
            this.cboEval.Location = new System.Drawing.Point(129, 67);
            this.cboEval.Name = "cboEval";
            this.cboEval.Size = new System.Drawing.Size(164, 28);
            this.cboEval.TabIndex = 0;
            this.cboEval.SelectedIndexChanged += new System.EventHandler(this.cboEval_SelectedIndexChanged);
            // 
            // lblEval
            // 
            this.lblEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEval.AutoSize = true;
            this.lblEval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblEval.Location = new System.Drawing.Point(27, 70);
            this.lblEval.Name = "lblEval";
            this.lblEval.Size = new System.Drawing.Size(96, 20);
            this.lblEval.TabIndex = 1;
            this.lblEval.Text = "Evaluación";
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.panelCont);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 115);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(908, 428);
            this.panelContenido.TabIndex = 4;
            // 
            // panelCont
            // 
            this.panelCont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCont.AutoScroll = true;
            this.panelCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panelCont.Location = new System.Drawing.Point(0, 0);
            this.panelCont.Name = "panelCont";
            this.panelCont.Size = new System.Drawing.Size(908, 428);
            this.panelCont.TabIndex = 7;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 543);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblListaAlumnos;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblEval;
        private System.Windows.Forms.ComboBox cboEval;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelCont;
        private System.Windows.Forms.Button btnEditar;
    }
}