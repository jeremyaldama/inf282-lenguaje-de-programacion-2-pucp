namespace ULearn.Bibliotecario
{
    partial class frmReportePrestamosFinalizados
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.cboBiblioteca = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.rb7dias = new System.Windows.Forms.RadioButton();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.rbPersonalizado = new System.Windows.Forms.RadioButton();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnDevueltos = new System.Windows.Forms.Button();
            this.btnAnulados = new System.Windows.Forms.Button();
            this.btnConRetraso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 218);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(313, 32);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Péstamos Finalizados";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Seleccione una opción para generar el reporte:";
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoEllipsis = true;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.Location = new System.Drawing.Point(8, 341);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(457, 32);
            this.lblOpcion.TabIndex = 16;
            this.lblOpcion.Text = "Biblioteca(s) de donde se buscará la información:";
            // 
            // cboBiblioteca
            // 
            this.cboBiblioteca.FormattingEnabled = true;
            this.cboBiblioteca.Location = new System.Drawing.Point(501, 343);
            this.cboBiblioteca.Name = "cboBiblioteca";
            this.cboBiblioteca.Size = new System.Drawing.Size(452, 24);
            this.cboBiblioteca.TabIndex = 15;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(742, 507);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(289, 61);
            this.btnGenerar.TabIndex = 14;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoEllipsis = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(10, 267);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(1030, 53);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "En siguiente reporte se listan los libros que no han sido devueltos tras haber si" +
    "do prestados junto a la información del usuario que solicitó el respectivo prést" +
    "amo\r\n";
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoEllipsis = true;
            this.lblIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalo.Location = new System.Drawing.Point(10, 393);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(627, 32);
            this.lblIntervalo.TabIndex = 23;
            this.lblIntervalo.Text = "Seleccione el intervalo de tiempo en el que se realizará la búsqueda:";
            // 
            // rb7dias
            // 
            this.rb7dias.AutoSize = true;
            this.rb7dias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb7dias.Location = new System.Drawing.Point(38, 429);
            this.rb7dias.Name = "rb7dias";
            this.rb7dias.Size = new System.Drawing.Size(143, 26);
            this.rb7dias.TabIndex = 24;
            this.rb7dias.TabStop = true;
            this.rb7dias.Text = "Últimos 7 días";
            this.rb7dias.UseVisualStyleBackColor = true;
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMes.Location = new System.Drawing.Point(207, 429);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(105, 26);
            this.rbMes.TabIndex = 25;
            this.rbMes.TabStop = true;
            this.rbMes.Text = "Este mes";
            this.rbMes.UseVisualStyleBackColor = true;
            // 
            // rbPersonalizado
            // 
            this.rbPersonalizado.AutoSize = true;
            this.rbPersonalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersonalizado.Location = new System.Drawing.Point(342, 429);
            this.rbPersonalizado.Name = "rbPersonalizado";
            this.rbPersonalizado.Size = new System.Drawing.Size(144, 26);
            this.rbPersonalizado.TabIndex = 26;
            this.rbPersonalizado.TabStop = true;
            this.rbPersonalizado.Text = "Personalizado";
            this.rbPersonalizado.UseVisualStyleBackColor = true;
            this.rbPersonalizado.CheckedChanged += new System.EventHandler(this.rbPersonalizado_CheckedChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(119, 480);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(171, 27);
            this.dtpDesde.TabIndex = 27;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(394, 480);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(171, 27);
            this.dtpHasta.TabIndex = 28;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(319, 487);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(50, 20);
            this.lblHasta.TabIndex = 29;
            this.lblHasta.Text = "hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(34, 485);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(58, 20);
            this.lblDesde.TabIndex = 30;
            this.lblDesde.Text = "Desde";
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Image = global::ULearn.Properties.Resources.select;
            this.btnTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTodos.Location = new System.Drawing.Point(803, 51);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnTodos.Size = new System.Drawing.Size(178, 136);
            this.btnTodos.TabIndex = 20;
            this.btnTodos.Text = "Todos Finalizados";
            this.btnTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnDevueltos
            // 
            this.btnDevueltos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnDevueltos.FlatAppearance.BorderSize = 0;
            this.btnDevueltos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevueltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevueltos.Image = global::ULearn.Properties.Resources.return_goods;
            this.btnDevueltos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDevueltos.Location = new System.Drawing.Point(56, 51);
            this.btnDevueltos.Name = "btnDevueltos";
            this.btnDevueltos.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnDevueltos.Size = new System.Drawing.Size(185, 136);
            this.btnDevueltos.TabIndex = 19;
            this.btnDevueltos.Text = "Préstamos Devueltos";
            this.btnDevueltos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDevueltos.UseVisualStyleBackColor = false;
            this.btnDevueltos.Click += new System.EventHandler(this.btnDevueltos_Click);
            // 
            // btnAnulados
            // 
            this.btnAnulados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnAnulados.FlatAppearance.BorderSize = 0;
            this.btnAnulados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulados.Image = global::ULearn.Properties.Resources.error;
            this.btnAnulados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnulados.Location = new System.Drawing.Point(551, 51);
            this.btnAnulados.Name = "btnAnulados";
            this.btnAnulados.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnAnulados.Size = new System.Drawing.Size(185, 136);
            this.btnAnulados.TabIndex = 18;
            this.btnAnulados.Text = "Préstamos Anulados";
            this.btnAnulados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnulados.UseVisualStyleBackColor = false;
            this.btnAnulados.Click += new System.EventHandler(this.btnAnulados_Click);
            // 
            // btnConRetraso
            // 
            this.btnConRetraso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.btnConRetraso.FlatAppearance.BorderSize = 0;
            this.btnConRetraso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConRetraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConRetraso.Image = global::ULearn.Properties.Resources.alert;
            this.btnConRetraso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConRetraso.Location = new System.Drawing.Point(301, 51);
            this.btnConRetraso.Name = "btnConRetraso";
            this.btnConRetraso.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.btnConRetraso.Size = new System.Drawing.Size(185, 136);
            this.btnConRetraso.TabIndex = 17;
            this.btnConRetraso.Text = "Préstamos Devueltos Tarde";
            this.btnConRetraso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConRetraso.UseVisualStyleBackColor = false;
            this.btnConRetraso.Click += new System.EventHandler(this.btnConRetraso_Click);
            // 
            // frmReportePrestamosFinalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 570);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.rbPersonalizado);
            this.Controls.Add(this.rbMes);
            this.Controls.Add(this.rb7dias);
            this.Controls.Add(this.lblIntervalo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnDevueltos);
            this.Controls.Add(this.btnAnulados);
            this.Controls.Add(this.btnConRetraso);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.cboBiblioteca);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "frmReportePrestamosFinalizados";
            this.Text = "frmReportePrestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnDevueltos;
        private System.Windows.Forms.Button btnAnulados;
        private System.Windows.Forms.Button btnConRetraso;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.ComboBox cboBiblioteca;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.RadioButton rb7dias;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.RadioButton rbPersonalizado;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
    }
}