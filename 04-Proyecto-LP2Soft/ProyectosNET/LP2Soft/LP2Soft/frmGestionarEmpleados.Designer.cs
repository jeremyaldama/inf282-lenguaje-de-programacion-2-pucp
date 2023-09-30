namespace LP2Soft
{
    partial class frmGestionarEmpleados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarEmpleados));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.toolStripSeparator,
            this.btnModificar,
            this.btnBuscar,
            this.btnEliminar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(676, 27);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 24);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 24);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 24);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 24);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 24);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 24);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(211, 22);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestión de Empleados";
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDEmpleado.Location = new System.Drawing.Point(193, 91);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(31, 20);
            this.lblIDEmpleado.TabIndex = 1;
            this.lblIDEmpleado.Text = "ID:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(180, 134);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(43, 20);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(72, 201);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(136, 20);
            this.lblApellidoPaterno.TabIndex = 5;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(144, 165);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(153, 357);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(59, 20);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(164, 313);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(49, 20);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Área:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(31, 270);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(172, 20);
            this.lblFechaNacimiento.TabIndex = 7;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(144, 236);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(69, 20);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Género:";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDEmpleado.Enabled = false;
            this.txtIDEmpleado.Location = new System.Drawing.Point(243, 89);
            this.txtIDEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(75, 22);
            this.txtIDEmpleado.TabIndex = 10;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(243, 132);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(181, 22);
            this.txtDNI.TabIndex = 11;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(243, 165);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(368, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(243, 201);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(368, 22);
            this.txtApellidoPaterno.TabIndex = 13;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(243, 236);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(106, 24);
            this.rbMasculino.TabIndex = 14;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Tag = "";
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(365, 236);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(103, 24);
            this.rbFemenino.TabIndex = 15;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Tag = "";
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(243, 270);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(368, 27);
            this.dtpFechaNacimiento.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sueldo:";
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(243, 313);
            this.cboArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(367, 24);
            this.cboArea.TabIndex = 18;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(243, 357);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(368, 22);
            this.txtCargo.TabIndex = 19;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(243, 391);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(368, 22);
            this.txtSueldo.TabIndex = 20;
            // 
            // frmGestionarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 464);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtIDEmpleado);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblIDEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tsMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestionarEmpleados";
            this.Text = "Formulario de Gestión de Empleados";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSueldo;
    }
}

