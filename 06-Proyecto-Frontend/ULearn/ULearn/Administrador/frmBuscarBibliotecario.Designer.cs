namespace ULearn.Administrador
{
    partial class frmBuscarBibliotecarios
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
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvBibliotecarios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaContratacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContenido.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.panelSuperior);
            this.panelContenido.Controls.Add(this.btnSeleccionar);
            this.panelContenido.Controls.Add(this.txtBusqueda);
            this.panelContenido.Controls.Add(this.lblBusqueda);
            this.panelContenido.Controls.Add(this.btnBuscar);
            this.panelContenido.Controls.Add(this.dgvBibliotecarios);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1364, 450);
            this.panelContenido.TabIndex = 0;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1364, 65);
            this.panelSuperior.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda de Encargados de Biblioteca";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Noto Sans Cond", 8F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionar.Location = new System.Drawing.Point(1234, 399);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(111, 30);
            this.btnSeleccionar.TabIndex = 41;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusqueda.Location = new System.Drawing.Point(462, 79);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(774, 30);
            this.txtBusqueda.TabIndex = 40;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.lblBusqueda.Location = new System.Drawing.Point(11, 86);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(392, 16);
            this.lblBusqueda.TabIndex = 44;
            this.lblBusqueda.Text = "Ingrese el nombre/usuario del encargado de biblioteca:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Noto Sans Cond", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(1255, 79);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 30);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvBibliotecarios
            // 
            this.dgvBibliotecarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBibliotecarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.Genero,
            this.FechaNacimiento,
            this.usuario,
            this.password,
            this.CorreoElectronico,
            this.HoraEntrada,
            this.HoraSalida,
            this.fechaContratacion,
            this.TituloTrabajo});
            this.dgvBibliotecarios.Location = new System.Drawing.Point(12, 136);
            this.dgvBibliotecarios.Name = "dgvBibliotecarios";
            this.dgvBibliotecarios.RowHeadersWidth = 51;
            this.dgvBibliotecarios.RowTemplate.Height = 24;
            this.dgvBibliotecarios.Size = new System.Drawing.Size(1333, 238);
            this.dgvBibliotecarios.TabIndex = 43;
            this.dgvBibliotecarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBibliotecarios_CellFormatting);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ApellidoPaterno.MinimumWidth = 6;
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.Width = 125;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Apellido Materno";
            this.ApellidoMaterno.MinimumWidth = 6;
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.Width = 125;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Género";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.Width = 125;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.MinimumWidth = 6;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Width = 125;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.Width = 125;
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Width = 125;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.HeaderText = "Correo Electrónico";
            this.CorreoElectronico.MinimumWidth = 6;
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.Width = 125;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.HeaderText = "Hora de Entrada";
            this.HoraEntrada.MinimumWidth = 6;
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.Width = 125;
            // 
            // HoraSalida
            // 
            this.HoraSalida.HeaderText = "Hora de Salida";
            this.HoraSalida.MinimumWidth = 6;
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.Width = 125;
            // 
            // fechaContratacion
            // 
            this.fechaContratacion.HeaderText = "Fecha de Contratación";
            this.fechaContratacion.MinimumWidth = 6;
            this.fechaContratacion.Name = "fechaContratacion";
            this.fechaContratacion.Width = 125;
            // 
            // TituloTrabajo
            // 
            this.TituloTrabajo.HeaderText = "Título de Trabajo";
            this.TituloTrabajo.MinimumWidth = 6;
            this.TituloTrabajo.Name = "TituloTrabajo";
            this.TituloTrabajo.Width = 125;
            // 
            // frmBuscarBibliotecarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1364, 450);
            this.Controls.Add(this.panelContenido);
            this.Name = "frmBuscarBibliotecarios";
            this.Text = "frmGestionarBibliotecarios";
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBibliotecarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaContratacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloTrabajo;
    }
}