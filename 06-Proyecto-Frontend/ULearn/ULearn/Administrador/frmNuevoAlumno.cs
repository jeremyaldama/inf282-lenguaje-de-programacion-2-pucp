using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.ServiciosAcademicos;
using ULearn.LogisticsWs;
using alumno = ULearn.ServiciosAcademicos.alumno;

namespace ULearn.Administrador
{
    public partial class frmNuevoAlumno : Form
    {
        private Estado _estado;
        private alumno _alumno;
        private AcademicsWSClient _daoAlumno;
        public frmNuevoAlumno()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            _daoAlumno = new AcademicsWSClient();
            cboCarrera.DataSource = _daoAlumno.listarTodasCarreras();
            cboCarrera.DisplayMember = "Nombre";
            cboCarrera.ValueMember = "IdCarrera";
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    tsbNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    tsbBuscarAlumno.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = false;
                    gboCredenciales.Enabled = false;
                    gboAcademica.Enabled = false;
                    break;
                case Estado.Nuevo:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarAlumno.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = true;
                    gboAcademica.Enabled = true;
                    gboCredenciales.Enabled = true;
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false; 
                    break;
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarAlumno.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = true;
                    gboAcademica.Enabled = true;
                    gboCredenciales.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarAlumno.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = false;
                    gboAcademica.Enabled = false;
                    gboCredenciales.Enabled = false;
                    gboAcademica.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDUsuario.Text = "";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtCorreoElectronico.Text = "";
            txtCodigoAlumno.Text = "";
            cboCarrera.SelectedIndex = -1; 
        }

        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBuscarAlumno formBuscarAlumno = new frmBuscarAlumno();
            if (formBuscarAlumno.ShowDialog() == DialogResult.OK)
            {
                _alumno = formBuscarAlumno.AlumnoSeleccionado;
                txtIDUsuario.Text = _alumno.idUsuario.ToString();
                txtNombre.Text = _alumno.nombre;
                txtApellidoMaterno.Text = _alumno.apellidoMaterno;
                txtApellidoPaterno.Text = _alumno.apellidoPaterno;
                dtpFechaNacimiento.Value = _alumno.fechaNacimiento;
                _alumno.fechaNacimientoSpecified = true;
                if (_alumno.sexo == 'M') rbMasculino.Checked = true;
                if (_alumno.sexo == 'F') rbFemenino.Checked = true;
                txtUsuario.Text = _alumno.usuario1;
                txtPassword.Text = _alumno.password;
                txtCorreoElectronico.Text = _alumno.correoElectronico;
                txtCodigoAlumno.Text = _alumno.codigoAlumno.ToString();
                cboCarrera.SelectedValue = _alumno.carrera.idCarrera;
            }
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _alumno = new alumno();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("¿Está seguro que desea eliminar este alumno?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoAlumno.eliminarAlumno(_alumno.idUsuario);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("El alumno se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El alumno no pudo eliminarse", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            _alumno.nombre = txtNombre.Text;
            _alumno.apellidoMaterno = txtApellidoMaterno.Text;
            _alumno.apellidoPaterno = txtApellidoPaterno.Text;
            _alumno.fechaNacimiento = dtpFechaNacimiento.Value;
            _alumno.fechaNacimientoSpecified = true;

            if (rbFemenino.Checked) _alumno.sexo = 'F';
            else _alumno.sexo = 'M';
            
            _alumno.correoElectronico = txtCorreoElectronico.Text;
            _alumno.codigoAlumno = txtCodigoAlumno.Text;
            _alumno.carrera = new ServiciosAcademicos.carrera();
            _alumno.carrera.idCarrera = (int)cboCarrera.SelectedValue;

            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del alumno", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoMaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido materno del alumno", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoPaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido paterno del alumno", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbFemenino.Checked == false && rbMasculino.Checked == false)
            {
                MessageBox.Show("Debe indicar el genero del alumno", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreoElectronico.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el correo electronico del alumno", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            if (_estado == Estado.Nuevo)
            {
                _alumno.usuario1 = txtCorreoElectronico.Text.ToLower().Substring(0, txtCorreoElectronico.Text.IndexOf("@"));
                _alumno.password = txtCodigoAlumno.Text.Trim();
                txtPassword.Text = _alumno.password;
                txtUsuario.Text = _alumno.usuario1;

                if (txtPassword.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar el password del alumno", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtUsuario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar el usuario del alumno", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int resultado = _daoAlumno.insertarAlumno(_alumno);
                if (resultado != 0)
                {
                    txtIDUsuario.Text = resultado.ToString();
                    MessageBox.Show("El alumno se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (_estado == Estado.Modificar)
            {
                _alumno.password = txtPassword.Text;
                _alumno.usuario1 = txtUsuario.Text;

                if (txtPassword.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar el password del alumno", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtUsuario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar el usuario del alumno", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int resultado = _daoAlumno.actualizarAlumno(_alumno);
                if (resultado != 0)
                {
                    MessageBox.Show("El alumno se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error en la modificacion", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
