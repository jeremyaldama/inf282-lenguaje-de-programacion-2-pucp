namespace ULearn.Bibliotecario
{
    partial class frmDetallesPrestamo
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.gboPrestamo = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaRet = new System.Windows.Forms.Label();
            this.lblFechaMaxRet = new System.Windows.Forms.Label();
            this.lblFechaDev = new System.Windows.Forms.Label();
            this.lblFechaMaxDev = new System.Windows.Forms.Label();
            this.lblFechaReg = new System.Windows.Forms.Label();
            this.lblIDPrestamo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboLibro = new System.Windows.Forms.GroupBox();
            this.lblFechaPub = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAutores = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pboPortada = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gboResponsable = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            this.gboPrestamo.SuspendLayout();
            this.gboLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPortada)).BeginInit();
            this.gboResponsable.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.pnlSuperior.Controls.Add(this.lblSeccion);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(927, 68);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeccion.Location = new System.Drawing.Point(12, 18);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(251, 29);
            this.lblSeccion.TabIndex = 0;
            this.lblSeccion.Text = "Detalle de Préstamo";
            // 
            // gboPrestamo
            // 
            this.gboPrestamo.Controls.Add(this.lblEstado);
            this.gboPrestamo.Controls.Add(this.lblFechaRet);
            this.gboPrestamo.Controls.Add(this.lblFechaMaxRet);
            this.gboPrestamo.Controls.Add(this.lblFechaDev);
            this.gboPrestamo.Controls.Add(this.lblFechaMaxDev);
            this.gboPrestamo.Controls.Add(this.lblFechaReg);
            this.gboPrestamo.Controls.Add(this.lblIDPrestamo);
            this.gboPrestamo.Controls.Add(this.label9);
            this.gboPrestamo.Controls.Add(this.label8);
            this.gboPrestamo.Controls.Add(this.label7);
            this.gboPrestamo.Controls.Add(this.label6);
            this.gboPrestamo.Controls.Add(this.label5);
            this.gboPrestamo.Controls.Add(this.label4);
            this.gboPrestamo.Controls.Add(this.label2);
            this.gboPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboPrestamo.Location = new System.Drawing.Point(17, 396);
            this.gboPrestamo.Name = "gboPrestamo";
            this.gboPrestamo.Size = new System.Drawing.Size(876, 231);
            this.gboPrestamo.TabIndex = 1;
            this.gboPrestamo.TabStop = false;
            this.gboPrestamo.Text = "Información del préstamo";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoEllipsis = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(311, 190);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(347, 25);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "E";
            // 
            // lblFechaRet
            // 
            this.lblFechaRet.AutoEllipsis = true;
            this.lblFechaRet.Location = new System.Drawing.Point(655, 84);
            this.lblFechaRet.Name = "lblFechaRet";
            this.lblFechaRet.Size = new System.Drawing.Size(206, 20);
            this.lblFechaRet.TabIndex = 14;
            this.lblFechaRet.Text = "ID Préstamo:";
            // 
            // lblFechaMaxRet
            // 
            this.lblFechaMaxRet.AutoEllipsis = true;
            this.lblFechaMaxRet.Location = new System.Drawing.Point(274, 84);
            this.lblFechaMaxRet.Name = "lblFechaMaxRet";
            this.lblFechaMaxRet.Size = new System.Drawing.Size(179, 20);
            this.lblFechaMaxRet.TabIndex = 13;
            this.lblFechaMaxRet.Text = "asas";
            // 
            // lblFechaDev
            // 
            this.lblFechaDev.AutoEllipsis = true;
            this.lblFechaDev.Location = new System.Drawing.Point(655, 133);
            this.lblFechaDev.Name = "lblFechaDev";
            this.lblFechaDev.Size = new System.Drawing.Size(206, 20);
            this.lblFechaDev.TabIndex = 12;
            this.lblFechaDev.Text = "ID Préstamo:";
            // 
            // lblFechaMaxDev
            // 
            this.lblFechaMaxDev.AutoEllipsis = true;
            this.lblFechaMaxDev.Location = new System.Drawing.Point(274, 133);
            this.lblFechaMaxDev.Name = "lblFechaMaxDev";
            this.lblFechaMaxDev.Size = new System.Drawing.Size(179, 20);
            this.lblFechaMaxDev.TabIndex = 11;
            this.lblFechaMaxDev.Text = "ID Préstamo:";
            // 
            // lblFechaReg
            // 
            this.lblFechaReg.AutoEllipsis = true;
            this.lblFechaReg.Location = new System.Drawing.Point(655, 36);
            this.lblFechaReg.Name = "lblFechaReg";
            this.lblFechaReg.Size = new System.Drawing.Size(206, 20);
            this.lblFechaReg.TabIndex = 10;
            this.lblFechaReg.Text = "ID Préstamo:";
            // 
            // lblIDPrestamo
            // 
            this.lblIDPrestamo.AutoEllipsis = true;
            this.lblIDPrestamo.Location = new System.Drawing.Point(274, 36);
            this.lblIDPrestamo.Name = "lblIDPrestamo";
            this.lblIDPrestamo.Size = new System.Drawing.Size(179, 20);
            this.lblIDPrestamo.TabIndex = 9;
            this.lblIDPrestamo.Text = "ID Préstamo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(200, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha máxima de retiro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de retiro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de devolución:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha máxima de devolución:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Préstamo:";
            // 
            // gboLibro
            // 
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
            this.gboLibro.Location = new System.Drawing.Point(17, 89);
            this.gboLibro.Name = "gboLibro";
            this.gboLibro.Size = new System.Drawing.Size(876, 181);
            this.gboLibro.TabIndex = 2;
            this.gboLibro.TabStop = false;
            this.gboLibro.Text = "Información del libro";
            // 
            // lblFechaPub
            // 
            this.lblFechaPub.AutoEllipsis = true;
            this.lblFechaPub.Location = new System.Drawing.Point(247, 141);
            this.lblFechaPub.Name = "lblFechaPub";
            this.lblFechaPub.Size = new System.Drawing.Size(448, 20);
            this.lblFechaPub.TabIndex = 18;
            this.lblFechaPub.Text = "ID Préstamo:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoEllipsis = true;
            this.lblISBN.Location = new System.Drawing.Point(247, 109);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(448, 20);
            this.lblISBN.TabIndex = 17;
            this.lblISBN.Text = "ID Préstamo:";
            // 
            // lblAutores
            // 
            this.lblAutores.AutoEllipsis = true;
            this.lblAutores.Location = new System.Drawing.Point(247, 73);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(448, 20);
            this.lblAutores.TabIndex = 16;
            this.lblAutores.Text = "ID Préstamo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Location = new System.Drawing.Point(247, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(411, 20);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "ID Préstamo:";
            // 
            // pboPortada
            // 
            this.pboPortada.Image = global::ULearn.Properties.Resources.bookshelf;
            this.pboPortada.Location = new System.Drawing.Point(716, 26);
            this.pboPortada.Name = "pboPortada";
            this.pboPortada.Size = new System.Drawing.Size(145, 135);
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
            // gboResponsable
            // 
            this.gboResponsable.Controls.Add(this.lblRol);
            this.gboResponsable.Controls.Add(this.lblCorreo);
            this.gboResponsable.Controls.Add(this.lblNombre);
            this.gboResponsable.Controls.Add(this.label1);
            this.gboResponsable.Controls.Add(this.label12);
            this.gboResponsable.Controls.Add(this.label13);
            this.gboResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboResponsable.Location = new System.Drawing.Point(17, 276);
            this.gboResponsable.Name = "gboResponsable";
            this.gboResponsable.Size = new System.Drawing.Size(876, 114);
            this.gboResponsable.TabIndex = 3;
            this.gboResponsable.TabStop = false;
            this.gboResponsable.Text = "Información del usuario:";
            // 
            // lblRol
            // 
            this.lblRol.AutoEllipsis = true;
            this.lblRol.Location = new System.Drawing.Point(593, 73);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(207, 20);
            this.lblRol.TabIndex = 16;
            this.lblRol.Text = "ID Préstamo:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoEllipsis = true;
            this.lblCorreo.Location = new System.Drawing.Point(143, 73);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(340, 20);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "ID Préstamo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.Location = new System.Drawing.Point(284, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(490, 20);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "ID Préstamo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rol:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nombre del responsable:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Correo:";
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetiro.Location = new System.Drawing.Point(164, 657);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(229, 53);
            this.btnRetiro.TabIndex = 4;
            this.btnRetiro.Text = "Registrar Retiro";
            this.btnRetiro.UseVisualStyleBackColor = false;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDevolucion.Location = new System.Drawing.Point(419, 657);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(227, 53);
            this.btnDevolucion.TabIndex = 5;
            this.btnDevolucion.Text = "Registrar Devolucion";
            this.btnDevolucion.UseVisualStyleBackColor = false;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(723, 728);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(170, 33);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnular.Location = new System.Drawing.Point(666, 657);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(227, 53);
            this.btnAnular.TabIndex = 7;
            this.btnAnular.Text = "Anular préstamo";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoEllipsis = true;
            this.lblMensaje.Location = new System.Drawing.Point(14, 645);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(632, 95);
            this.lblMensaje.TabIndex = 15;
            // 
            // frmDetallesPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 773);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.gboResponsable);
            this.Controls.Add(this.gboLibro);
            this.Controls.Add(this.gboPrestamo);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.lblMensaje);
            this.Name = "frmDetallesPrestamo";
            this.Text = "frmDetallesPrestamo";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.gboPrestamo.ResumeLayout(false);
            this.gboPrestamo.PerformLayout();
            this.gboLibro.ResumeLayout(false);
            this.gboLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPortada)).EndInit();
            this.gboResponsable.ResumeLayout(false);
            this.gboResponsable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.GroupBox gboPrestamo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboLibro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gboResponsable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pboPortada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaRet;
        private System.Windows.Forms.Label lblFechaMaxRet;
        private System.Windows.Forms.Label lblFechaDev;
        private System.Windows.Forms.Label lblFechaMaxDev;
        private System.Windows.Forms.Label lblFechaReg;
        private System.Windows.Forms.Label lblIDPrestamo;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaPub;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Label lblMensaje;
    }
}