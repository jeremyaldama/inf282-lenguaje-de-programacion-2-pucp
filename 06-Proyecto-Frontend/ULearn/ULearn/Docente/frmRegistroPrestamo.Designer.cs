namespace ULearn.Docente
{
    partial class frmRegistroPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroPrestamo));
            this.lblTítulo = new System.Windows.Forms.Label();
            this.gboLibro = new System.Windows.Forms.GroupBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.lblCopias = new System.Windows.Forms.Label();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaPub = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAutores = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pboPortada = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gbPrestamo = new System.Windows.Forms.GroupBox();
            this.lblFechaMaxDev = new System.Windows.Forms.Label();
            this.lblFechaMaxRet = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDias = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gboLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPortada)).BeginInit();
            this.gbPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTítulo.Location = new System.Drawing.Point(12, -1);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblTítulo.Size = new System.Drawing.Size(319, 42);
            this.lblTítulo.TabIndex = 20;
            this.lblTítulo.Text = "Registro de préstamos";
            // 
            // gboLibro
            // 
            this.gboLibro.Controls.Add(this.lblPaginas);
            this.gboLibro.Controls.Add(this.lblCopias);
            this.gboLibro.Controls.Add(this.lblBiblioteca);
            this.gboLibro.Controls.Add(this.label4);
            this.gboLibro.Controls.Add(this.label3);
            this.gboLibro.Controls.Add(this.label2);
            this.gboLibro.Controls.Add(this.lblFechaPub);
            this.gboLibro.Controls.Add(this.lblISBN);
            this.gboLibro.Controls.Add(this.lblAutores);
            this.gboLibro.Controls.Add(this.lblTitulo);
            this.gboLibro.Controls.Add(this.pboPortada);
            this.gboLibro.Controls.Add(this.label14);
            this.gboLibro.Controls.Add(this.label15);
            this.gboLibro.Controls.Add(this.label17);
            this.gboLibro.Controls.Add(this.label18);
            this.gboLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboLibro.Location = new System.Drawing.Point(18, 44);
            this.gboLibro.Name = "gboLibro";
            this.gboLibro.Size = new System.Drawing.Size(1123, 215);
            this.gboLibro.TabIndex = 21;
            this.gboLibro.TabStop = false;
            this.gboLibro.Text = "Información del libro";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoEllipsis = true;
            this.lblPaginas.Location = new System.Drawing.Point(704, 141);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(151, 20);
            this.lblPaginas.TabIndex = 24;
            this.lblPaginas.Text = "124";
            // 
            // lblCopias
            // 
            this.lblCopias.AutoEllipsis = true;
            this.lblCopias.Location = new System.Drawing.Point(704, 109);
            this.lblCopias.Name = "lblCopias";
            this.lblCopias.Size = new System.Drawing.Size(151, 20);
            this.lblCopias.TabIndex = 23;
            this.lblCopias.Text = "ID Préstamo:";
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoEllipsis = true;
            this.lblBiblioteca.Location = new System.Drawing.Point(247, 174);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(636, 20);
            this.lblBiblioteca.TabIndex = 22;
            this.lblBiblioteca.Text = "ID Préstamo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Biblioteca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Número de Páginas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Número de Copias:";
            // 
            // lblFechaPub
            // 
            this.lblFechaPub.AutoEllipsis = true;
            this.lblFechaPub.Location = new System.Drawing.Point(247, 141);
            this.lblFechaPub.Name = "lblFechaPub";
            this.lblFechaPub.Size = new System.Drawing.Size(227, 20);
            this.lblFechaPub.TabIndex = 18;
            this.lblFechaPub.Text = "ID Préstamo:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoEllipsis = true;
            this.lblISBN.Location = new System.Drawing.Point(247, 109);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(227, 20);
            this.lblISBN.TabIndex = 17;
            this.lblISBN.Text = "ID Préstamo:";
            // 
            // lblAutores
            // 
            this.lblAutores.AutoEllipsis = true;
            this.lblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.Location = new System.Drawing.Point(247, 73);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(636, 20);
            this.lblAutores.TabIndex = 16;
            this.lblAutores.Text = "ID Préstamo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(247, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(636, 20);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "ID Préstamo:";
            // 
            // pboPortada
            // 
            this.pboPortada.Image = global::ULearn.Properties.Resources.bookshelf;
            this.pboPortada.Location = new System.Drawing.Point(922, 26);
            this.pboPortada.Name = "pboPortada";
            this.pboPortada.Size = new System.Drawing.Size(160, 149);
            this.pboPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboPortada.TabIndex = 5;
            this.pboPortada.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Fecha de publicación:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(164, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "ISBN:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(162, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Título:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(133, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Autor(es):";
            // 
            // gbPrestamo
            // 
            this.gbPrestamo.Controls.Add(this.lblFechaMaxDev);
            this.gbPrestamo.Controls.Add(this.lblFechaMaxRet);
            this.gbPrestamo.Controls.Add(this.label8);
            this.gbPrestamo.Controls.Add(this.label7);
            this.gbPrestamo.Controls.Add(this.label6);
            this.gbPrestamo.Controls.Add(this.cboDias);
            this.gbPrestamo.Controls.Add(this.label5);
            this.gbPrestamo.Controls.Add(this.lblFechaRegistro);
            this.gbPrestamo.Controls.Add(this.label1);
            this.gbPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrestamo.Location = new System.Drawing.Point(18, 275);
            this.gbPrestamo.Name = "gbPrestamo";
            this.gbPrestamo.Size = new System.Drawing.Size(1148, 224);
            this.gbPrestamo.TabIndex = 22;
            this.gbPrestamo.TabStop = false;
            this.gbPrestamo.Text = "Información del préstamo";
            // 
            // lblFechaMaxDev
            // 
            this.lblFechaMaxDev.AutoSize = true;
            this.lblFechaMaxDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMaxDev.Location = new System.Drawing.Point(927, 101);
            this.lblFechaMaxDev.Name = "lblFechaMaxDev";
            this.lblFechaMaxDev.Size = new System.Drawing.Size(107, 20);
            this.lblFechaMaxDev.TabIndex = 13;
            this.lblFechaMaxDev.Text = "dd/mm/yyyy";
            // 
            // lblFechaMaxRet
            // 
            this.lblFechaMaxRet.AutoSize = true;
            this.lblFechaMaxRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMaxRet.Location = new System.Drawing.Point(296, 101);
            this.lblFechaMaxRet.Name = "lblFechaMaxRet";
            this.lblFechaMaxRet.Size = new System.Drawing.Size(107, 20);
            this.lblFechaMaxRet.TabIndex = 12;
            this.lblFechaMaxRet.Text = "dd/mm/yyyy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha máxima de retiro:";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1117, 49);
            this.label7.TabIndex = 10;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha máxima de devolución:";
            // 
            // cboDias
            // 
            this.cboDias.FormattingEnabled = true;
            this.cboDias.Location = new System.Drawing.Point(931, 41);
            this.cboDias.Name = "cboDias";
            this.cboDias.Size = new System.Drawing.Size(105, 28);
            this.cboDias.TabIndex = 8;
            this.cboDias.SelectedIndexChanged += new System.EventHandler(this.cboDias_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccione la cantidad de días que desea el recurso:";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(296, 44);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(97, 20);
            this.lblFechaRegistro.TabIndex = 6;
            this.lblFechaRegistro.Text = "dd/mm/yyyy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de registro:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(855, 505);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(286, 41);
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Text = "Registrar solicitud";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Silver;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.Location = new System.Drawing.Point(662, 505);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(169, 41);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmRegistroPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 558);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbPrestamo);
            this.Controls.Add(this.gboLibro);
            this.Controls.Add(this.lblTítulo);
            this.Name = "frmRegistroPrestamo";
            this.Text = "frmRegistroPrestamo";
            this.gboLibro.ResumeLayout(false);
            this.gboLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPortada)).EndInit();
            this.gbPrestamo.ResumeLayout(false);
            this.gbPrestamo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.GroupBox gboLibro;
        private System.Windows.Forms.Label lblFechaPub;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pboPortada;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gbPrestamo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label lblCopias;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDias;
        private System.Windows.Forms.Label lblFechaMaxDev;
        private System.Windows.Forms.Label lblFechaMaxRet;
        private System.Windows.Forms.Label label8;
    }
}