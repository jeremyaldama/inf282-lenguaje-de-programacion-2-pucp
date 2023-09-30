namespace LP2Soft
{
    partial class frmPrincipal
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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGestionarOrdenesVenta = new System.Windows.Forms.Button();
            this.btnGestionarEmpleados = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(47)))), ((int)(((byte)(102)))));
            this.panelSuperior.Controls.Add(this.pbCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(914, 74);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // pbCerrar
            // 
            this.pbCerrar.ErrorImage = global::LP2Soft.Properties.Resources.close_window_xxl;
            this.pbCerrar.Image = global::LP2Soft.Properties.Resources.close_window_xxl;
            this.pbCerrar.Location = new System.Drawing.Point(846, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(56, 50);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(178)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.btnGestionarOrdenesVenta);
            this.panel1.Controls.Add(this.btnGestionarEmpleados);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 382);
            this.panel1.TabIndex = 1;
            // 
            // btnGestionarOrdenesVenta
            // 
            this.btnGestionarOrdenesVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarOrdenesVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarOrdenesVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarOrdenesVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGestionarOrdenesVenta.Image = global::LP2Soft.Properties.Resources.order_25x25;
            this.btnGestionarOrdenesVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarOrdenesVenta.Location = new System.Drawing.Point(0, 173);
            this.btnGestionarOrdenesVenta.Name = "btnGestionarOrdenesVenta";
            this.btnGestionarOrdenesVenta.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGestionarOrdenesVenta.Size = new System.Drawing.Size(299, 76);
            this.btnGestionarOrdenesVenta.TabIndex = 2;
            this.btnGestionarOrdenesVenta.Text = "Gestionar Órdenes de Venta";
            this.btnGestionarOrdenesVenta.UseVisualStyleBackColor = true;
            this.btnGestionarOrdenesVenta.Click += new System.EventHandler(this.btnGestionarOrdenesVenta_Click);
            // 
            // btnGestionarEmpleados
            // 
            this.btnGestionarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarEmpleados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGestionarEmpleados.Image = global::LP2Soft.Properties.Resources.workers_xxl_25x25;
            this.btnGestionarEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionarEmpleados.Location = new System.Drawing.Point(0, 97);
            this.btnGestionarEmpleados.Name = "btnGestionarEmpleados";
            this.btnGestionarEmpleados.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGestionarEmpleados.Size = new System.Drawing.Size(299, 76);
            this.btnGestionarEmpleados.TabIndex = 1;
            this.btnGestionarEmpleados.Text = "Gestionar Empleados";
            this.btnGestionarEmpleados.UseVisualStyleBackColor = true;
            this.btnGestionarEmpleados.Click += new System.EventHandler(this.btnGestionarEmpleados_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::LP2Soft.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(299, 97);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelContenido
            // 
            this.panelContenido.AutoSize = true;
            this.panelContenido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(299, 74);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(615, 382);
            this.panelContenido.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 456);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnGestionarEmpleados;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Button btnGestionarOrdenesVenta;
    }
}