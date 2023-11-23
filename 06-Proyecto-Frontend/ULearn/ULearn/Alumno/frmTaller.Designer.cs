namespace ULearn.Alumno
{
    partial class frmTaller
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
            this.bttnIncribirseTaller = new System.Windows.Forms.Button();
            this.bttnBuscarTaller = new System.Windows.Forms.Button();
            this.lblFechaTaller = new System.Windows.Forms.Label();
            this.dgvTalleres = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTaller = new System.Windows.Forms.Label();
            this.dtpTaller = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalleres)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnIncribirseTaller
            // 
            this.bttnIncribirseTaller.Location = new System.Drawing.Point(498, 100);
            this.bttnIncribirseTaller.Name = "bttnIncribirseTaller";
            this.bttnIncribirseTaller.Size = new System.Drawing.Size(85, 20);
            this.bttnIncribirseTaller.TabIndex = 7;
            this.bttnIncribirseTaller.Text = "Inscribirme";
            this.bttnIncribirseTaller.UseVisualStyleBackColor = true;
            this.bttnIncribirseTaller.Click += new System.EventHandler(this.bttnIncribirseTaller_Click);
            // 
            // bttnBuscarTaller
            // 
            this.bttnBuscarTaller.Location = new System.Drawing.Point(381, 100);
            this.bttnBuscarTaller.Name = "bttnBuscarTaller";
            this.bttnBuscarTaller.Size = new System.Drawing.Size(87, 20);
            this.bttnBuscarTaller.TabIndex = 6;
            this.bttnBuscarTaller.Text = "Buscar";
            this.bttnBuscarTaller.UseVisualStyleBackColor = true;
            this.bttnBuscarTaller.Click += new System.EventHandler(this.bttnBuscarTaller_Click);
            // 
            // lblFechaTaller
            // 
            this.lblFechaTaller.AutoSize = true;
            this.lblFechaTaller.Location = new System.Drawing.Point(33, 107);
            this.lblFechaTaller.Name = "lblFechaTaller";
            this.lblFechaTaller.Size = new System.Drawing.Size(65, 13);
            this.lblFechaTaller.TabIndex = 5;
            this.lblFechaTaller.Text = "Fecha Inicio";
            // 
            // dgvTalleres
            // 
            this.dgvTalleres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTalleres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvTalleres.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTalleres.Location = new System.Drawing.Point(36, 153);
            this.dgvTalleres.Name = "dgvTalleres";
            this.dgvTalleres.Size = new System.Drawing.Size(642, 272);
            this.dgvTalleres.TabIndex = 1;
            this.dgvTalleres.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTalleres_CellFormatting);
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
            this.dataGridViewTextBoxColumn6.HeaderText = "Area de Interes";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lblTaller);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 9;
            // 
            // lblTaller
            // 
            this.lblTaller.AutoSize = true;
            this.lblTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTaller.Location = new System.Drawing.Point(40, 22);
            this.lblTaller.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaller.Name = "lblTaller";
            this.lblTaller.Size = new System.Drawing.Size(264, 24);
            this.lblTaller.TabIndex = 2;
            this.lblTaller.Text = "CONSULTA DE TALLERES";
            // 
            // dtpTaller
            // 
            this.dtpTaller.Location = new System.Drawing.Point(117, 101);
            this.dtpTaller.Name = "dtpTaller";
            this.dtpTaller.Size = new System.Drawing.Size(213, 20);
            this.dtpTaller.TabIndex = 10;
            // 
            // frmTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.dtpTaller);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTalleres);
            this.Controls.Add(this.bttnIncribirseTaller);
            this.Controls.Add(this.bttnBuscarTaller);
            this.Controls.Add(this.lblFechaTaller);
            this.Name = "frmTaller";
            this.Text = "frmTaller";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalleres)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnIncribirseTaller;
        private System.Windows.Forms.Button bttnBuscarTaller;
        private System.Windows.Forms.Label lblFechaTaller;
        private System.Windows.Forms.DataGridView dgvTalleres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTaller;
        private System.Windows.Forms.DateTimePicker dtpTaller;
    }
}