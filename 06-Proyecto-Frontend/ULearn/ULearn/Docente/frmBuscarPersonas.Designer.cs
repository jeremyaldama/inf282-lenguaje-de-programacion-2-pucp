namespace ULearn.Docente
{
    partial class frmBuscarPersonas
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDocente = new System.Windows.Forms.CheckBox();
            this.cbAlumno = new System.Windows.Forms.CheckBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterios = new System.Windows.Forms.Label();
            this.panelCab = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.panelCab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(550, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 38);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(980, 55);
            this.panelSuperior.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda de Persona";
            // 
            // cbDocente
            // 
            this.cbDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDocente.AutoSize = true;
            this.cbDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbDocente.Location = new System.Drawing.Point(712, 81);
            this.cbDocente.Name = "cbDocente";
            this.cbDocente.Size = new System.Drawing.Size(106, 29);
            this.cbDocente.TabIndex = 3;
            this.cbDocente.Text = "Docente";
            this.cbDocente.UseVisualStyleBackColor = true;
            // 
            // cbAlumno
            // 
            this.cbAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlumno.AutoSize = true;
            this.cbAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbAlumno.Location = new System.Drawing.Point(824, 81);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(100, 29);
            this.cbAlumno.TabIndex = 4;
            this.cbAlumno.Text = "Alumno";
            this.cbAlumno.UseVisualStyleBackColor = true;
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panelContenido.Location = new System.Drawing.Point(34, 168);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(898, 407);
            this.panelContenido.TabIndex = 5;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(232, 84);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(298, 26);
            this.txtBusqueda.TabIndex = 6;
            // 
            // lblCriterios
            // 
            this.lblCriterios.AutoSize = true;
            this.lblCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterios.Location = new System.Drawing.Point(30, 87);
            this.lblCriterios.Name = "lblCriterios";
            this.lblCriterios.Size = new System.Drawing.Size(196, 20);
            this.lblCriterios.TabIndex = 7;
            this.lblCriterios.Text = "Nombre/Apellido o Código:";
            // 
            // panelCab
            // 
            this.panelCab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCab.Controls.Add(this.label5);
            this.panelCab.Controls.Add(this.label4);
            this.panelCab.Controls.Add(this.label3);
            this.panelCab.Controls.Add(this.label2);
            this.panelCab.Location = new System.Drawing.Point(34, 125);
            this.panelCab.Name = "panelCab";
            this.panelCab.Size = new System.Drawing.Size(898, 34);
            this.panelCab.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre y Apellidos";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(665, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Facultad";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(786, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rol";
            // 
            // frmBuscarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 603);
            this.Controls.Add(this.panelCab);
            this.Controls.Add(this.lblCriterios);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.cbAlumno);
            this.Controls.Add(this.cbDocente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmBuscarPersonas";
            this.Text = "frmBusqPersonas";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelCab.ResumeLayout(false);
            this.panelCab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDocente;
        private System.Windows.Forms.CheckBox cbAlumno;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterios;
        private System.Windows.Forms.Panel panelCab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}