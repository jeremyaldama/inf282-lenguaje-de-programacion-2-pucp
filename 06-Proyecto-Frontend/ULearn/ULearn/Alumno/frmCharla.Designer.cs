namespace ULearn.Alumno
{
    partial class frmCharla
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
            this.bttnBuscarTaller = new System.Windows.Forms.Button();
            this.lblFechaTaller = new System.Windows.Forms.Label();
            this.dgvCharla = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTaller = new System.Windows.Forms.Label();
            this.bttnIncribirseCharla = new System.Windows.Forms.Button();
            this.dtpCharla = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharla)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnBuscarTaller
            // 
            this.bttnBuscarTaller.Location = new System.Drawing.Point(392, 95);
            this.bttnBuscarTaller.Name = "bttnBuscarTaller";
            this.bttnBuscarTaller.Size = new System.Drawing.Size(84, 20);
            this.bttnBuscarTaller.TabIndex = 6;
            this.bttnBuscarTaller.Text = "Buscar";
            this.bttnBuscarTaller.UseVisualStyleBackColor = true;
            this.bttnBuscarTaller.Click += new System.EventHandler(this.bttnBuscarTaller_Click);
            // 
            // lblFechaTaller
            // 
            this.lblFechaTaller.AutoSize = true;
            this.lblFechaTaller.Location = new System.Drawing.Point(41, 102);
            this.lblFechaTaller.Name = "lblFechaTaller";
            this.lblFechaTaller.Size = new System.Drawing.Size(65, 13);
            this.lblFechaTaller.TabIndex = 5;
            this.lblFechaTaller.Text = "Fecha Inicio";
            // 
            // dgvCharla
            // 
            this.dgvCharla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvCharla.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCharla.Location = new System.Drawing.Point(38, 150);
            this.dgvCharla.Name = "dgvCharla";
            this.dgvCharla.Size = new System.Drawing.Size(624, 267);
            this.dgvCharla.TabIndex = 1;
            this.dgvCharla.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCharla_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lblTaller);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 58);
            this.panel1.TabIndex = 10;
            // 
            // lblTaller
            // 
            this.lblTaller.AutoSize = true;
            this.lblTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTaller.Location = new System.Drawing.Point(40, 22);
            this.lblTaller.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaller.Name = "lblTaller";
            this.lblTaller.Size = new System.Drawing.Size(255, 24);
            this.lblTaller.TabIndex = 2;
            this.lblTaller.Text = "CONSULTA DE CHARLAS";
            // 
            // bttnIncribirseCharla
            // 
            this.bttnIncribirseCharla.Location = new System.Drawing.Point(510, 95);
            this.bttnIncribirseCharla.Name = "bttnIncribirseCharla";
            this.bttnIncribirseCharla.Size = new System.Drawing.Size(79, 20);
            this.bttnIncribirseCharla.TabIndex = 11;
            this.bttnIncribirseCharla.Text = "Inscribirme";
            this.bttnIncribirseCharla.UseVisualStyleBackColor = true;
            this.bttnIncribirseCharla.Click += new System.EventHandler(this.bttnIncribirseCharla_Click);
            // 
            // dtpCharla
            // 
            this.dtpCharla.Location = new System.Drawing.Point(122, 96);
            this.dtpCharla.Name = "dtpCharla";
            this.dtpCharla.Size = new System.Drawing.Size(210, 20);
            this.dtpCharla.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Organizador";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hora Inicio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Hora fin";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Ponente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmCharla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.dtpCharla);
            this.Controls.Add(this.bttnIncribirseCharla);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCharla);
            this.Controls.Add(this.bttnBuscarTaller);
            this.Controls.Add(this.lblFechaTaller);
            this.Name = "frmCharla";
            this.Text = "frmCharla";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnBuscarTaller;
        private System.Windows.Forms.Label lblFechaTaller;
        private System.Windows.Forms.DataGridView dgvCharla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTaller;
        private System.Windows.Forms.Button bttnIncribirseCharla;
        private System.Windows.Forms.DateTimePicker dtpCharla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}