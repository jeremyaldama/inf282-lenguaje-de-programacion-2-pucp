namespace ULearn.Bibliotecario
{
    partial class frmReportePrestamosActivos
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cboBiblioteca = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnNoDevueltos = new System.Windows.Forms.Button();
            this.btnEnCurso = new System.Windows.Forms.Button();
            this.btnPendientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(739, 506);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(289, 61);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cboBiblioteca
            // 
            this.cboBiblioteca.FormattingEnabled = true;
            this.cboBiblioteca.Location = new System.Drawing.Point(509, 339);
            this.cboBiblioteca.Name = "cboBiblioteca";
            this.cboBiblioteca.Size = new System.Drawing.Size(452, 24);
            this.cboBiblioteca.TabIndex = 4;
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoEllipsis = true;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.Location = new System.Drawing.Point(12, 339);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(491, 32);
            this.lblOpcion.TabIndex = 5;
            this.lblOpcion.Text = "Biblioteca(s) de donde se buscará la información:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoEllipsis = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(14, 265);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(1025, 53);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "En siguiente reporte se listan los libros que no han sido devueltos tras haber si" +
    "do prestados junto a la información del usuario que solicitó el respectivo prést" +
    "amo\r\n";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoEllipsis = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFecha.Location = new System.Drawing.Point(14, 384);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(678, 31);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Se muestra información registrada hasta el ";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione una opción para generar el reporte:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(10, 216);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(255, 32);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Péstamos Activos";
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Image = global::ULearn.Properties.Resources.select;
            this.btnTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTodos.Location = new System.Drawing.Point(822, 49);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnTodos.Size = new System.Drawing.Size(185, 136);
            this.btnTodos.TabIndex = 9;
            this.btnTodos.Text = "Todos Activos";
            this.btnTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnNoDevueltos
            // 
            this.btnNoDevueltos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnNoDevueltos.FlatAppearance.BorderSize = 0;
            this.btnNoDevueltos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNoDevueltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoDevueltos.Image = global::ULearn.Properties.Resources.alert;
            this.btnNoDevueltos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNoDevueltos.Location = new System.Drawing.Point(573, 49);
            this.btnNoDevueltos.Name = "btnNoDevueltos";
            this.btnNoDevueltos.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnNoDevueltos.Size = new System.Drawing.Size(185, 136);
            this.btnNoDevueltos.TabIndex = 8;
            this.btnNoDevueltos.Text = "Préstamos Con Retraso";
            this.btnNoDevueltos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNoDevueltos.UseVisualStyleBackColor = false;
            this.btnNoDevueltos.Click += new System.EventHandler(this.btnNoDevueltos_Click);
            // 
            // btnEnCurso
            // 
            this.btnEnCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnEnCurso.FlatAppearance.BorderSize = 0;
            this.btnEnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnCurso.Image = global::ULearn.Properties.Resources.book__1_1;
            this.btnEnCurso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnCurso.Location = new System.Drawing.Point(80, 49);
            this.btnEnCurso.Name = "btnEnCurso";
            this.btnEnCurso.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnEnCurso.Size = new System.Drawing.Size(185, 136);
            this.btnEnCurso.TabIndex = 7;
            this.btnEnCurso.Text = "Préstamos En Curso";
            this.btnEnCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnCurso.UseVisualStyleBackColor = false;
            this.btnEnCurso.Click += new System.EventHandler(this.btnEnCurso_Click);
            // 
            // btnPendientes
            // 
            this.btnPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnPendientes.FlatAppearance.BorderSize = 0;
            this.btnPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendientes.Image = global::ULearn.Properties.Resources.wait;
            this.btnPendientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPendientes.Location = new System.Drawing.Point(320, 49);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnPendientes.Size = new System.Drawing.Size(183, 136);
            this.btnPendientes.TabIndex = 6;
            this.btnPendientes.Text = "Préstamos Pendientes";
            this.btnPendientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPendientes.UseVisualStyleBackColor = false;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);
            // 
            // frmReportePrestamosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 570);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnNoDevueltos);
            this.Controls.Add(this.btnEnCurso);
            this.Controls.Add(this.btnPendientes);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.cboBiblioteca);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmReportePrestamosActivos";
            this.Text = "frmReporteLibrosPerdidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cboBiblioteca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnPendientes;
        private System.Windows.Forms.Button btnEnCurso;
        private System.Windows.Forms.Button btnNoDevueltos;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
    }
}