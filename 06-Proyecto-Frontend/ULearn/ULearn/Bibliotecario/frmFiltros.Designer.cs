namespace ULearn.Bibliotecario
{
    partial class frmFiltros
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cboBiblioteca = new System.Windows.Forms.ComboBox();
            this.cbAnulado = new System.Windows.Forms.CheckBox();
            this.cbNoAnulados = new System.Windows.Forms.CheckBox();
            this.cboDevueltos = new System.Windows.Forms.CheckBox();
            this.cbNoDevuelto = new System.Windows.Forms.CheckBox();
            this.cbConRetraso = new System.Windows.Forms.CheckBox();
            this.cbSinRetraso = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 63);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Biblioteca del libro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intervalo de tiempo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Incluir prestamos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(330, 164);
            this.dtpDesde.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(171, 27);
            this.dtpDesde.TabIndex = 6;
            this.dtpDesde.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(330, 207);
            this.dtpHasta.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(171, 27);
            this.dtpHasta.TabIndex = 7;
            this.dtpHasta.Value = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            // 
            // cboBiblioteca
            // 
            this.cboBiblioteca.FormattingEnabled = true;
            this.cboBiblioteca.Location = new System.Drawing.Point(257, 98);
            this.cboBiblioteca.Name = "cboBiblioteca";
            this.cboBiblioteca.Size = new System.Drawing.Size(290, 24);
            this.cboBiblioteca.TabIndex = 8;
            // 
            // cbAnulado
            // 
            this.cbAnulado.AutoSize = true;
            this.cbAnulado.Checked = true;
            this.cbAnulado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnulado.Location = new System.Drawing.Point(261, 290);
            this.cbAnulado.Name = "cbAnulado";
            this.cbAnulado.Size = new System.Drawing.Size(100, 24);
            this.cbAnulado.TabIndex = 9;
            this.cbAnulado.Text = "Anulados";
            this.cbAnulado.UseVisualStyleBackColor = true;
            this.cbAnulado.CheckedChanged += new System.EventHandler(this.cbAnulado_CheckedChanged);
            // 
            // cbNoAnulados
            // 
            this.cbNoAnulados.AutoSize = true;
            this.cbNoAnulados.Checked = true;
            this.cbNoAnulados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNoAnulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNoAnulados.Location = new System.Drawing.Point(417, 290);
            this.cbNoAnulados.Name = "cbNoAnulados";
            this.cbNoAnulados.Size = new System.Drawing.Size(126, 24);
            this.cbNoAnulados.TabIndex = 10;
            this.cbNoAnulados.Text = "No Anulados";
            this.cbNoAnulados.UseVisualStyleBackColor = true;
            this.cbNoAnulados.CheckedChanged += new System.EventHandler(this.cbNoAnulados_CheckedChanged);
            // 
            // cboDevueltos
            // 
            this.cboDevueltos.AutoSize = true;
            this.cboDevueltos.Checked = true;
            this.cboDevueltos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboDevueltos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevueltos.Location = new System.Drawing.Point(261, 344);
            this.cboDevueltos.Name = "cboDevueltos";
            this.cboDevueltos.Size = new System.Drawing.Size(106, 24);
            this.cboDevueltos.TabIndex = 11;
            this.cboDevueltos.Text = "Devueltos";
            this.cboDevueltos.UseVisualStyleBackColor = true;
            // 
            // cbNoDevuelto
            // 
            this.cbNoDevuelto.AutoSize = true;
            this.cbNoDevuelto.Checked = true;
            this.cbNoDevuelto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNoDevuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNoDevuelto.Location = new System.Drawing.Point(417, 344);
            this.cbNoDevuelto.Name = "cbNoDevuelto";
            this.cbNoDevuelto.Size = new System.Drawing.Size(122, 24);
            this.cbNoDevuelto.TabIndex = 12;
            this.cbNoDevuelto.Text = "Sin devolver";
            this.cbNoDevuelto.UseVisualStyleBackColor = true;
            // 
            // cbConRetraso
            // 
            this.cbConRetraso.AutoSize = true;
            this.cbConRetraso.Checked = true;
            this.cbConRetraso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbConRetraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConRetraso.Location = new System.Drawing.Point(261, 394);
            this.cbConRetraso.Name = "cbConRetraso";
            this.cbConRetraso.Size = new System.Drawing.Size(119, 24);
            this.cbConRetraso.TabIndex = 13;
            this.cbConRetraso.Text = "Con retraso";
            this.cbConRetraso.UseVisualStyleBackColor = true;
            // 
            // cbSinRetraso
            // 
            this.cbSinRetraso.AutoSize = true;
            this.cbSinRetraso.Checked = true;
            this.cbSinRetraso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSinRetraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSinRetraso.Location = new System.Drawing.Point(417, 394);
            this.cbSinRetraso.Name = "cbSinRetraso";
            this.cbSinRetraso.Size = new System.Drawing.Size(113, 24);
            this.cbSinRetraso.TabIndex = 14;
            this.cbSinRetraso.Text = "Sin retraso";
            this.cbSinRetraso.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(402, 484);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 37);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Filtros";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAplicar.Location = new System.Drawing.Point(569, 484);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(143, 37);
            this.btnAplicar.TabIndex = 16;
            this.btnAplicar.Text = "Aplicar Filtros";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // frmFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 554);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbSinRetraso);
            this.Controls.Add(this.cbConRetraso);
            this.Controls.Add(this.cbNoDevuelto);
            this.Controls.Add(this.cboDevueltos);
            this.Controls.Add(this.cbNoAnulados);
            this.Controls.Add(this.cbAnulado);
            this.Controls.Add(this.cboBiblioteca);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmFiltros";
            this.Text = "Filtros de búsqueda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.ComboBox cboBiblioteca;
        private System.Windows.Forms.CheckBox cbAnulado;
        private System.Windows.Forms.CheckBox cbNoAnulados;
        private System.Windows.Forms.CheckBox cboDevueltos;
        private System.Windows.Forms.CheckBox cbNoDevuelto;
        private System.Windows.Forms.CheckBox cbConRetraso;
        private System.Windows.Forms.CheckBox cbSinRetraso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAplicar;
    }
}