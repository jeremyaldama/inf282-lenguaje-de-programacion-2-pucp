namespace ULearn
{
    partial class frmBusquedaEvaluacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.bttnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCurso,
            this.Evaluacion,
            this.Nota});
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // NombreCurso
            // 
            this.NombreCurso.HeaderText = "Nombre Curso";
            this.NombreCurso.Name = "NombreCurso";
            this.NombreCurso.Width = 200;
            // 
            // Evaluacion
            // 
            this.Evaluacion.HeaderText = "Evaluacion";
            this.Evaluacion.Name = "Evaluacion";
            this.Evaluacion.Width = 200;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(12, 30);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(201, 13);
            this.lblBusqueda.TabIndex = 1;
            this.lblBusqueda.Text = "Seleccione la evaluacion para el reclamo";
            // 
            // bttnSeleccionar
            // 
            this.bttnSeleccionar.Location = new System.Drawing.Point(429, 30);
            this.bttnSeleccionar.Name = "bttnSeleccionar";
            this.bttnSeleccionar.Size = new System.Drawing.Size(128, 23);
            this.bttnSeleccionar.TabIndex = 2;
            this.bttnSeleccionar.Text = "Seleccionar";
            this.bttnSeleccionar.UseVisualStyleBackColor = true;
            this.bttnSeleccionar.Click += new System.EventHandler(this.bttnSeleccionar_Click);
            // 
            // frmBusquedaEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 262);
            this.Controls.Add(this.bttnSeleccionar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBusquedaEvaluacion";
            this.Text = "frmBusquedaEvaluacion";
            this.Load += new System.EventHandler(this.frmBusquedaEvaluacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.Button bttnSeleccionar;
    }
}