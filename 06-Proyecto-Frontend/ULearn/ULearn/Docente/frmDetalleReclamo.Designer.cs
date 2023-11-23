namespace ULearn.Docente
{
    partial class frmDetalleReclamo
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
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbProcede = new System.Windows.Forms.RadioButton();
            this.rbNoProcede = new System.Windows.Forms.RadioButton();
            this.txtDescp = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEdicionNota = new System.Windows.Forms.DataGridView();
            this.CodAlum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblValCodAlumno = new System.Windows.Forms.Label();
            this.lblValNomAlumno = new System.Windows.Forms.Label();
            this.lblValNomEvaluacion = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdicionNota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripción.Location = new System.Drawing.Point(64, 257);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(125, 25);
            this.lblDescripción.TabIndex = 0;
            this.lblDescripción.Text = "Descripción";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipo.Location = new System.Drawing.Point(64, 145);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(166, 25);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Nombre Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(64, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(64, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Evaluación";
            // 
            // rbProcede
            // 
            this.rbProcede.AutoSize = true;
            this.rbProcede.Location = new System.Drawing.Point(246, 412);
            this.rbProcede.Name = "rbProcede";
            this.rbProcede.Size = new System.Drawing.Size(93, 24);
            this.rbProcede.TabIndex = 4;
            this.rbProcede.TabStop = true;
            this.rbProcede.Text = "Procede";
            this.rbProcede.UseVisualStyleBackColor = true;
            // 
            // rbNoProcede
            // 
            this.rbNoProcede.AutoSize = true;
            this.rbNoProcede.Location = new System.Drawing.Point(345, 411);
            this.rbNoProcede.Name = "rbNoProcede";
            this.rbNoProcede.Size = new System.Drawing.Size(116, 24);
            this.rbNoProcede.TabIndex = 5;
            this.rbNoProcede.TabStop = true;
            this.rbNoProcede.Text = "No procede";
            this.rbNoProcede.UseVisualStyleBackColor = true;
            // 
            // txtDescp
            // 
            this.txtDescp.Location = new System.Drawing.Point(246, 257);
            this.txtDescp.Multiline = true;
            this.txtDescp.Name = "txtDescp";
            this.txtDescp.Size = new System.Drawing.Size(425, 58);
            this.txtDescp.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(64, 411);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(79, 25);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(569, 625);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 45);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(36, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 45);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(64, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Edición Nota";
            // 
            // dgvEdicionNota
            // 
            this.dgvEdicionNota.AllowUserToAddRows = false;
            this.dgvEdicionNota.AllowUserToDeleteRows = false;
            this.dgvEdicionNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEdicionNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdicionNota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodAlum,
            this.nombreEval,
            this.Calificacion});
            this.dgvEdicionNota.Location = new System.Drawing.Point(69, 490);
            this.dgvEdicionNota.Name = "dgvEdicionNota";
            this.dgvEdicionNota.RowHeadersWidth = 62;
            this.dgvEdicionNota.RowTemplate.Height = 28;
            this.dgvEdicionNota.Size = new System.Drawing.Size(602, 114);
            this.dgvEdicionNota.TabIndex = 11;
            // 
            // CodAlum
            // 
            this.CodAlum.HeaderText = "Código alumno";
            this.CodAlum.MinimumWidth = 8;
            this.CodAlum.Name = "CodAlum";
            this.CodAlum.ReadOnly = true;
            this.CodAlum.Width = 200;
            // 
            // nombreEval
            // 
            this.nombreEval.HeaderText = "Evaluación";
            this.nombreEval.MinimumWidth = 8;
            this.nombreEval.Name = "nombreEval";
            this.nombreEval.ReadOnly = true;
            this.nombreEval.Width = 200;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificación";
            this.Calificacion.MaxInputLength = 2;
            this.Calificacion.MinimumWidth = 8;
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.Width = 250;
            // 
            // lblValCodAlumno
            // 
            this.lblValCodAlumno.AutoSize = true;
            this.lblValCodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValCodAlumno.Location = new System.Drawing.Point(241, 86);
            this.lblValCodAlumno.Name = "lblValCodAlumno";
            this.lblValCodAlumno.Size = new System.Drawing.Size(147, 25);
            this.lblValCodAlumno.TabIndex = 12;
            this.lblValCodAlumno.Text = "Código Alumno";
            // 
            // lblValNomAlumno
            // 
            this.lblValNomAlumno.AutoSize = true;
            this.lblValNomAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValNomAlumno.Location = new System.Drawing.Point(241, 145);
            this.lblValNomAlumno.Name = "lblValNomAlumno";
            this.lblValNomAlumno.Size = new System.Drawing.Size(81, 25);
            this.lblValNomAlumno.TabIndex = 13;
            this.lblValNomAlumno.Text = "Nombre";
            // 
            // lblValNomEvaluacion
            // 
            this.lblValNomEvaluacion.AutoSize = true;
            this.lblValNomEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValNomEvaluacion.Location = new System.Drawing.Point(241, 209);
            this.lblValNomEvaluacion.Name = "lblValNomEvaluacion";
            this.lblValNomEvaluacion.Size = new System.Drawing.Size(81, 25);
            this.lblValNomEvaluacion.TabIndex = 14;
            this.lblValNomEvaluacion.Text = "Nombre";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(246, 329);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(425, 76);
            this.txtRespuesta.TabIndex = 15;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblRespuesta.Location = new System.Drawing.Point(64, 328);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(114, 25);
            this.lblRespuesta.TabIndex = 16;
            this.lblRespuesta.Text = "Respuesta";
            // 
            // frmDetalleReclamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 700);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.lblValNomEvaluacion);
            this.Controls.Add(this.lblValNomAlumno);
            this.Controls.Add(this.lblValCodAlumno);
            this.Controls.Add(this.dgvEdicionNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtDescp);
            this.Controls.Add(this.rbNoProcede);
            this.Controls.Add(this.rbProcede);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDescripción);
            this.Name = "frmDetalleReclamo";
            this.Text = "frmDetalleReclamo";
            this.Load += new System.EventHandler(this.frmDetalleReclamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdicionNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbProcede;
        private System.Windows.Forms.RadioButton rbNoProcede;
        private System.Windows.Forms.TextBox txtDescp;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEdicionNota;
        private System.Windows.Forms.Label lblValCodAlumno;
        private System.Windows.Forms.Label lblValNomAlumno;
        private System.Windows.Forms.Label lblValNomEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodAlum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label lblRespuesta;
    }
}