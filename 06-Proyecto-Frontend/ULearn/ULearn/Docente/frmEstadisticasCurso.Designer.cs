namespace ULearn.Docente
{
    partial class frmEstadisticasCurso
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
            this.lblMatriculados = new System.Windows.Forms.Label();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblValMat = new System.Windows.Forms.Label();
            this.lblValAp = new System.Windows.Forms.Label();
            this.lblValMedia = new System.Windows.Forms.Label();
            this.lblEval = new System.Windows.Forms.Label();
            this.cboEval = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValAsist = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValMedEval = new System.Windows.Forms.Label();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatriculados
            // 
            this.lblMatriculados.AutoSize = true;
            this.lblMatriculados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriculados.Location = new System.Drawing.Point(21, 69);
            this.lblMatriculados.Name = "lblMatriculados";
            this.lblMatriculados.Size = new System.Drawing.Size(237, 22);
            this.lblMatriculados.TabIndex = 0;
            this.lblMatriculados.Text = "Cantidad de matriculados";
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprobados.Location = new System.Drawing.Point(294, 69);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(218, 22);
            this.lblAprobados.TabIndex = 1;
            this.lblAprobados.Text = "Cantidad de aprobados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Media Horario";
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = global::ULearn.Properties.Resources.spreadsheet_app1;
            this.btnReporte.Location = new System.Drawing.Point(712, 22);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(145, 124);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Generar \r\nReporte Curso";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblValMat
            // 
            this.lblValMat.AutoSize = true;
            this.lblValMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblValMat.Location = new System.Drawing.Point(121, 44);
            this.lblValMat.Name = "lblValMat";
            this.lblValMat.Size = new System.Drawing.Size(19, 20);
            this.lblValMat.TabIndex = 4;
            this.lblValMat.Text = "[]";
            // 
            // lblValAp
            // 
            this.lblValAp.AutoSize = true;
            this.lblValAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblValAp.Location = new System.Drawing.Point(391, 44);
            this.lblValAp.Name = "lblValAp";
            this.lblValAp.Size = new System.Drawing.Size(19, 20);
            this.lblValAp.TabIndex = 5;
            this.lblValAp.Text = "[]";
            // 
            // lblValMedia
            // 
            this.lblValMedia.AutoSize = true;
            this.lblValMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblValMedia.Location = new System.Drawing.Point(593, 44);
            this.lblValMedia.Name = "lblValMedia";
            this.lblValMedia.Size = new System.Drawing.Size(19, 20);
            this.lblValMedia.TabIndex = 6;
            this.lblValMedia.Text = "[]";
            // 
            // lblEval
            // 
            this.lblEval.AutoSize = true;
            this.lblEval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEval.Location = new System.Drawing.Point(21, 178);
            this.lblEval.Name = "lblEval";
            this.lblEval.Size = new System.Drawing.Size(108, 22);
            this.lblEval.TabIndex = 7;
            this.lblEval.Text = "Evaluación";
            // 
            // cboEval
            // 
            this.cboEval.FormattingEnabled = true;
            this.cboEval.Location = new System.Drawing.Point(146, 177);
            this.cboEval.Name = "cboEval";
            this.cboEval.Size = new System.Drawing.Size(164, 28);
            this.cboEval.TabIndex = 8;
            this.cboEval.SelectedIndexChanged += new System.EventHandler(this.cboEval_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(374, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Asistentes";
            // 
            // lblValAsist
            // 
            this.lblValAsist.AutoSize = true;
            this.lblValAsist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblValAsist.Location = new System.Drawing.Point(401, 184);
            this.lblValAsist.Name = "lblValAsist";
            this.lblValAsist.Size = new System.Drawing.Size(19, 20);
            this.lblValAsist.TabIndex = 11;
            this.lblValAsist.Text = "[]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(481, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Media evaluación";
            // 
            // lblValMedEval
            // 
            this.lblValMedEval.AutoSize = true;
            this.lblValMedEval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblValMedEval.Location = new System.Drawing.Point(536, 184);
            this.lblValMedEval.Name = "lblValMedEval";
            this.lblValMedEval.Size = new System.Drawing.Size(19, 20);
            this.lblValMedEval.TabIndex = 13;
            this.lblValMedEval.Text = "[]";
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.valorNota});
            this.dgvNotas.Location = new System.Drawing.Point(45, 238);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowHeadersWidth = 62;
            this.dgvNotas.RowTemplate.Height = 28;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(787, 287);
            this.dgvNotas.TabIndex = 14;
            this.dgvNotas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNota_CellFormatting);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 200;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 350;
            // 
            // valorNota
            // 
            this.valorNota.HeaderText = "Nota";
            this.valorNota.MinimumWidth = 8;
            this.valorNota.Name = "valorNota";
            this.valorNota.ReadOnly = true;
            this.valorNota.Width = 200;
            // 
            // frmEstadisticasCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 525);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.lblValMedEval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValAsist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEval);
            this.Controls.Add(this.lblEval);
            this.Controls.Add(this.lblValMedia);
            this.Controls.Add(this.lblValAp);
            this.Controls.Add(this.lblValMat);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.lblMatriculados);
            this.Name = "frmEstadisticasCurso";
            this.Text = "frmEstadisticasCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatriculados;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblValMat;
        private System.Windows.Forms.Label lblValAp;
        private System.Windows.Forms.Label lblValMedia;
        private System.Windows.Forms.Label lblEval;
        private System.Windows.Forms.ComboBox cboEval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValAsist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValMedEval;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorNota;
    }
}