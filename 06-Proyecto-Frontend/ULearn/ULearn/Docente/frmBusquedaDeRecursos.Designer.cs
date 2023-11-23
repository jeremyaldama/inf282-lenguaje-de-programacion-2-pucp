namespace ULearn.Docente
{
    partial class frmBusquedaDeRecursos
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.cboBiblioteca = new System.Windows.Forms.ComboBox();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.cboNoDisponible = new System.Windows.Forms.CheckBox();
            this.cboDisponible = new System.Windows.Forms.CheckBox();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.cboDigital = new System.Windows.Forms.CheckBox();
            this.cboLibro = new System.Windows.Forms.CheckBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(458, 51);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(680, 22);
            this.txtBusqueda.TabIndex = 3;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(14, 51);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(380, 20);
            this.lblDatos.TabIndex = 4;
            this.lblDatos.Text = "Ingrese el título del recurso o el nombre del autor:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(1036, 104);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 30);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.lblTítulo);
            this.panelBusqueda.Controls.Add(this.cboBiblioteca);
            this.panelBusqueda.Controls.Add(this.lblBiblioteca);
            this.panelBusqueda.Controls.Add(this.cboNoDisponible);
            this.panelBusqueda.Controls.Add(this.cboDisponible);
            this.panelBusqueda.Controls.Add(this.lblDisponible);
            this.panelBusqueda.Controls.Add(this.cboDigital);
            this.panelBusqueda.Controls.Add(this.cboLibro);
            this.panelBusqueda.Controls.Add(this.lblTipo);
            this.panelBusqueda.Controls.Add(this.btnBuscar);
            this.panelBusqueda.Controls.Add(this.txtBusqueda);
            this.panelBusqueda.Controls.Add(this.lblDatos);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(1167, 155);
            this.panelBusqueda.TabIndex = 7;
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTítulo.Location = new System.Drawing.Point(12, 0);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblTítulo.Size = new System.Drawing.Size(303, 42);
            this.lblTítulo.TabIndex = 19;
            this.lblTítulo.Text = "Catálogo de recursos";
            // 
            // cboBiblioteca
            // 
            this.cboBiblioteca.FormattingEnabled = true;
            this.cboBiblioteca.Location = new System.Drawing.Point(124, 87);
            this.cboBiblioteca.Name = "cboBiblioteca";
            this.cboBiblioteca.Size = new System.Drawing.Size(270, 24);
            this.cboBiblioteca.TabIndex = 18;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.Location = new System.Drawing.Point(14, 91);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(88, 20);
            this.lblBiblioteca.TabIndex = 12;
            this.lblBiblioteca.Text = "Biblioteca:";
            // 
            // cboNoDisponible
            // 
            this.cboNoDisponible.AutoSize = true;
            this.cboNoDisponible.Checked = true;
            this.cboNoDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboNoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNoDisponible.Location = new System.Drawing.Point(921, 124);
            this.cboNoDisponible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNoDisponible.Name = "cboNoDisponible";
            this.cboNoDisponible.Size = new System.Drawing.Size(50, 22);
            this.cboNoDisponible.TabIndex = 11;
            this.cboNoDisponible.Text = "No";
            this.cboNoDisponible.UseVisualStyleBackColor = true;
            // 
            // cboDisponible
            // 
            this.cboDisponible.AutoSize = true;
            this.cboDisponible.Checked = true;
            this.cboDisponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDisponible.Location = new System.Drawing.Point(921, 93);
            this.cboDisponible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDisponible.Name = "cboDisponible";
            this.cboDisponible.Size = new System.Drawing.Size(43, 22);
            this.cboDisponible.TabIndex = 10;
            this.cboDisponible.Text = "Sí";
            this.cboDisponible.UseVisualStyleBackColor = true;
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.Location = new System.Drawing.Point(736, 93);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(161, 20);
            this.lblDisponible.TabIndex = 9;
            this.lblDisponible.Text = "Recurso Disponible:";
            // 
            // cboDigital
            // 
            this.cboDigital.AutoSize = true;
            this.cboDigital.Checked = true;
            this.cboDigital.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDigital.Location = new System.Drawing.Point(593, 124);
            this.cboDigital.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDigital.Name = "cboDigital";
            this.cboDigital.Size = new System.Drawing.Size(128, 22);
            this.cboDigital.TabIndex = 8;
            this.cboDigital.Text = "Recurso digital";
            this.cboDigital.UseVisualStyleBackColor = true;
            // 
            // cboLibro
            // 
            this.cboLibro.AutoSize = true;
            this.cboLibro.Checked = true;
            this.cboLibro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLibro.Location = new System.Drawing.Point(593, 91);
            this.cboLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLibro.Name = "cboLibro";
            this.cboLibro.Size = new System.Drawing.Size(63, 22);
            this.cboLibro.TabIndex = 7;
            this.cboLibro.Text = "Libro";
            this.cboLibro.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(418, 91);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(131, 20);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo de recurso:";
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 155);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1167, 371);
            this.panelContenido.TabIndex = 8;
            // 
            // frmBusquedaDeRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 526);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBusqueda);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBusquedaDeRecursos";
            this.Text = "Buscar Recursos";
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.CheckBox cboLibro;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.CheckBox cboNoDisponible;
        private System.Windows.Forms.CheckBox cboDisponible;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.CheckBox cboDigital;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.ComboBox cboBiblioteca;
        private System.Windows.Forms.Label lblTítulo;
    }
}