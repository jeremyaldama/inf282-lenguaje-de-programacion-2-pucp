namespace ULearn.Bibliotecario
{
    partial class frmNuevoLibro
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
            this.lblCopias = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtCopias = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCopias
            // 
            this.lblCopias.AutoSize = true;
            this.lblCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopias.Location = new System.Drawing.Point(33, 24);
            this.lblCopias.Name = "lblCopias";
            this.lblCopias.Size = new System.Drawing.Size(134, 18);
            this.lblCopias.TabIndex = 0;
            this.lblCopias.Text = "Número de copias:";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.Location = new System.Drawing.Point(33, 68);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(141, 18);
            this.lblPaginas.TabIndex = 1;
            this.lblPaginas.Text = "Número de páginas:";
            // 
            // txtCopias
            // 
            this.txtCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopias.Location = new System.Drawing.Point(191, 24);
            this.txtCopias.Name = "txtCopias";
            this.txtCopias.Size = new System.Drawing.Size(81, 24);
            this.txtCopias.TabIndex = 3;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginas.Location = new System.Drawing.Point(191, 68);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(81, 24);
            this.txtPaginas.TabIndex = 4;
            // 
            // frmNuevoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 123);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.txtCopias);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.lblCopias);
            this.Name = "frmNuevoLibro";
            this.Text = "frmNuevoLibro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopias;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txtCopias;
        private System.Windows.Forms.TextBox txtPaginas;
    }
}