namespace ULearn.Administrador
{
    partial class frmNuevoAlumno
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscarAlumno = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gboAcademica = new System.Windows.Forms.GroupBox();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.gboCredenciales = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gboInfoPersonal = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblRegistroCursos = new System.Windows.Forms.Label();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gboAcademica.SuspendLayout();
            this.gboCredenciales.SuspendLayout();
            this.gboInfoPersonal.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Controls.Add(this.pictureBox1);
            this.panelContenido.Controls.Add(this.panel1);
            this.panelContenido.Controls.Add(this.btnCancelar);
            this.panelContenido.Controls.Add(this.toolStrip1);
            this.panelContenido.Controls.Add(this.btnGuardar);
            this.panelContenido.Controls.Add(this.gboAcademica);
            this.panelContenido.Controls.Add(this.gboCredenciales);
            this.panelContenido.Controls.Add(this.gboInfoPersonal);
            this.panelContenido.Controls.Add(this.panelSuperior);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1004, 600);
            this.panelContenido.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(31, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 164);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(125)))), ((int)(((byte)(143)))));
            this.panel1.Location = new System.Drawing.Point(31, 286);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 326);
            this.panel1.TabIndex = 81;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(816, 261);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 34);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBuscarAlumno,
            this.tsbEliminar,
            this.tsbEditar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 65);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 31);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 78;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbNuevo.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbNuevo.Image = global::ULearn.Properties.Resources.new_document;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(82, 28);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBuscarAlumno
            // 
            this.tsbBuscarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbBuscarAlumno.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbBuscarAlumno.Image = global::ULearn.Properties.Resources.search;
            this.tsbBuscarAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscarAlumno.Name = "tsbBuscarAlumno";
            this.tsbBuscarAlumno.Size = new System.Drawing.Size(143, 28);
            this.tsbBuscarAlumno.Text = "Buscar Alumno";
            this.tsbBuscarAlumno.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbEliminar.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbEliminar.Image = global::ULearn.Properties.Resources.delete;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(94, 28);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbEditar.Font = new System.Drawing.Font("Noto Sans", 8.999999F);
            this.tsbEditar.Image = global::ULearn.Properties.Resources.edit;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(77, 28);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(665, 261);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 34);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gboAcademica
            // 
            this.gboAcademica.BackColor = System.Drawing.Color.White;
            this.gboAcademica.Controls.Add(this.lblCarrera);
            this.gboAcademica.Controls.Add(this.cboCarrera);
            this.gboAcademica.Controls.Add(this.txtCodigoAlumno);
            this.gboAcademica.Controls.Add(this.lblCodigoAlumno);
            this.gboAcademica.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboAcademica.Location = new System.Drawing.Point(616, 116);
            this.gboAcademica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboAcademica.Name = "gboAcademica";
            this.gboAcademica.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboAcademica.Size = new System.Drawing.Size(372, 137);
            this.gboAcademica.TabIndex = 75;
            this.gboAcademica.TabStop = false;
            this.gboAcademica.Text = "Información Académica";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(173, 41);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(179, 30);
            this.txtCodigoAlumno.TabIndex = 59;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblCodigoAlumno.Location = new System.Drawing.Point(12, 51);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(113, 19);
            this.lblCodigoAlumno.TabIndex = 13;
            this.lblCodigoAlumno.Text = "Código del alumno:";
            // 
            // gboCredenciales
            // 
            this.gboCredenciales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gboCredenciales.BackColor = System.Drawing.Color.White;
            this.gboCredenciales.Controls.Add(this.txtPassword);
            this.gboCredenciales.Controls.Add(this.txtCorreoElectronico);
            this.gboCredenciales.Controls.Add(this.txtUsuario);
            this.gboCredenciales.Controls.Add(this.lblCorreoElectronico);
            this.gboCredenciales.Controls.Add(this.lblPassword);
            this.gboCredenciales.Controls.Add(this.lblUsuario);
            this.gboCredenciales.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboCredenciales.Location = new System.Drawing.Point(221, 376);
            this.gboCredenciales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboCredenciales.Name = "gboCredenciales";
            this.gboCredenciales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboCredenciales.Size = new System.Drawing.Size(372, 214);
            this.gboCredenciales.TabIndex = 76;
            this.gboCredenciales.TabStop = false;
            this.gboCredenciales.Text = "Credenciales";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(178, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 30);
            this.txtPassword.TabIndex = 7;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(178, 110);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(179, 30);
            this.txtCorreoElectronico.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(178, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(179, 30);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblCorreoElectronico.Location = new System.Drawing.Point(17, 117);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(110, 19);
            this.lblCorreoElectronico.TabIndex = 2;
            this.lblCorreoElectronico.Text = "Correo electrónico:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblPassword.Location = new System.Drawing.Point(17, 83);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(72, 19);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblUsuario.Location = new System.Drawing.Point(17, 49);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // gboInfoPersonal
            // 
            this.gboInfoPersonal.BackColor = System.Drawing.Color.White;
            this.gboInfoPersonal.Controls.Add(this.dtpFechaNacimiento);
            this.gboInfoPersonal.Controls.Add(this.txtApellidoPaterno);
            this.gboInfoPersonal.Controls.Add(this.lblIDUsuario);
            this.gboInfoPersonal.Controls.Add(this.txtIDUsuario);
            this.gboInfoPersonal.Controls.Add(this.lblGenero);
            this.gboInfoPersonal.Controls.Add(this.rbFemenino);
            this.gboInfoPersonal.Controls.Add(this.rbMasculino);
            this.gboInfoPersonal.Controls.Add(this.lblFechaNacimiento);
            this.gboInfoPersonal.Controls.Add(this.txtApellidoMaterno);
            this.gboInfoPersonal.Controls.Add(this.txtNombre);
            this.gboInfoPersonal.Controls.Add(this.lblApellidoMaterno);
            this.gboInfoPersonal.Controls.Add(this.lblApellidoPaterno);
            this.gboInfoPersonal.Controls.Add(this.label1);
            this.gboInfoPersonal.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.gboInfoPersonal.Location = new System.Drawing.Point(221, 116);
            this.gboInfoPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoPersonal.Name = "gboInfoPersonal";
            this.gboInfoPersonal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboInfoPersonal.Size = new System.Drawing.Size(372, 256);
            this.gboInfoPersonal.TabIndex = 74;
            this.gboInfoPersonal.TabStop = false;
            this.gboInfoPersonal.Text = "Información Personal";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(173, 180);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(179, 25);
            this.dtpFechaNacimiento.TabIndex = 29;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(173, 111);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(179, 30);
            this.txtApellidoPaterno.TabIndex = 7;
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblIDUsuario.Location = new System.Drawing.Point(12, 51);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(69, 19);
            this.lblIDUsuario.TabIndex = 13;
            this.lblIDUsuario.Text = "ID Alumno:";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Enabled = false;
            this.txtIDUsuario.Location = new System.Drawing.Point(173, 43);
            this.txtIDUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.ReadOnly = true;
            this.txtIDUsuario.Size = new System.Drawing.Size(179, 30);
            this.txtIDUsuario.TabIndex = 12;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblGenero.Location = new System.Drawing.Point(12, 213);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(51, 19);
            this.lblGenero.TabIndex = 10;
            this.lblGenero.Text = "Género:";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbFemenino.Location = new System.Drawing.Point(273, 211);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(79, 22);
            this.rbFemenino.TabIndex = 10;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Noto Sans Cond", 7.8F);
            this.rbMasculino.Location = new System.Drawing.Point(173, 211);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(81, 22);
            this.rbMasculino.TabIndex = 9;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 186);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(120, 19);
            this.lblFechaNacimiento.TabIndex = 9;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(173, 145);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(179, 30);
            this.txtApellidoMaterno.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 30);
            this.txtNombre.TabIndex = 6;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblApellidoMaterno.Location = new System.Drawing.Point(12, 152);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(104, 19);
            this.lblApellidoMaterno.TabIndex = 2;
            this.lblApellidoMaterno.Text = "Apellido materno:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblApellidoPaterno.Location = new System.Drawing.Point(12, 118);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(100, 19);
            this.lblApellidoPaterno.TabIndex = 1;
            this.lblApellidoPaterno.Text = "Apellido paterno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(137)))), ((int)(((byte)(127)))));
            this.panelSuperior.Controls.Add(this.lblRegistroCursos);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1004, 65);
            this.panelSuperior.TabIndex = 63;
            // 
            // lblRegistroCursos
            // 
            this.lblRegistroCursos.AutoSize = true;
            this.lblRegistroCursos.Font = new System.Drawing.Font("Noto Sans Cond", 16F, System.Drawing.FontStyle.Bold);
            this.lblRegistroCursos.ForeColor = System.Drawing.Color.White;
            this.lblRegistroCursos.Location = new System.Drawing.Point(21, 14);
            this.lblRegistroCursos.Name = "lblRegistroCursos";
            this.lblRegistroCursos.Size = new System.Drawing.Size(250, 37);
            this.lblRegistroCursos.TabIndex = 0;
            this.lblRegistroCursos.Text = "Registro de Alumnos";
            // 
            // cboCarrera
            // 
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(173, 77);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(179, 31);
            this.cboCarrera.TabIndex = 60;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Noto Sans Cond", 8F);
            this.lblCarrera.Location = new System.Drawing.Point(12, 84);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(55, 19);
            this.lblCarrera.TabIndex = 61;
            this.lblCarrera.Text = "Carrera: ";
            // 
            // frmNuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 600);
            this.Controls.Add(this.panelContenido);
            this.Name = "frmNuevoAlumno";
            this.Text = "frmNuevoAlumno";
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gboAcademica.ResumeLayout(false);
            this.gboAcademica.PerformLayout();
            this.gboCredenciales.ResumeLayout(false);
            this.gboCredenciales.PerformLayout();
            this.gboInfoPersonal.ResumeLayout(false);
            this.gboInfoPersonal.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblRegistroCursos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbBuscarAlumno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gboAcademica;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.GroupBox gboCredenciales;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gboInfoPersonal;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cboCarrera;
    }
}