﻿namespace ULearn.Alumno
{
    partial class frmHorario
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
            this.dgvHorario = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miércoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sábado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUltimoCiclo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorario
            // 
            this.dgvHorario.AllowUserToAddRows = false;
            this.dgvHorario.AllowUserToDeleteRows = false;
            this.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Lunes,
            this.Martes,
            this.Miércoles,
            this.Jueves,
            this.Viernes,
            this.Sábado,
            this.Domingo});
            this.dgvHorario.Location = new System.Drawing.Point(24, 62);
            this.dgvHorario.Name = "dgvHorario";
            this.dgvHorario.Size = new System.Drawing.Size(845, 401);
            this.dgvHorario.TabIndex = 0;
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.Width = 55;
            // 
            // Lunes
            // 
            this.Lunes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            this.Lunes.Width = 61;
            // 
            // Martes
            // 
            this.Martes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            this.Martes.Width = 64;
            // 
            // Miércoles
            // 
            this.Miércoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Miércoles.HeaderText = "Miércoles";
            this.Miércoles.Name = "Miércoles";
            this.Miércoles.Width = 77;
            // 
            // Jueves
            // 
            this.Jueves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            this.Jueves.Width = 66;
            // 
            // Viernes
            // 
            this.Viernes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            this.Viernes.Width = 67;
            // 
            // Sábado
            // 
            this.Sábado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sábado.HeaderText = "Sábado";
            this.Sábado.Name = "Sábado";
            this.Sábado.Width = 69;
            // 
            // Domingo
            // 
            this.Domingo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Domingo.HeaderText = "Domingo";
            this.Domingo.Name = "Domingo";
            this.Domingo.Width = 74;
            // 
            // lblUltimoCiclo
            // 
            this.lblUltimoCiclo.AutoSize = true;
            this.lblUltimoCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoCiclo.Location = new System.Drawing.Point(20, 22);
            this.lblUltimoCiclo.Name = "lblUltimoCiclo";
            this.lblUltimoCiclo.Size = new System.Drawing.Size(65, 20);
            this.lblUltimoCiclo.TabIndex = 2;
            this.lblUltimoCiclo.Text = "2023-2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipos de Horario:   A=Asesoria  C=Clase  D=Dirigido  L=Laboratorio  P=Práctica  E" +
    "=Examen";
            // 
            // frmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUltimoCiclo);
            this.Controls.Add(this.dgvHorario);
            this.Name = "frmHorario";
            this.Text = "frmHorario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorario;
        private System.Windows.Forms.Label lblUltimoCiclo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miércoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sábado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
    }
}