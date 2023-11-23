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
using ULearn.StaffWS;

namespace ULearn.Administrador
{
    public partial class frmNuevoBibliotecario : Form
    {
        private Estado _estado;
        private encargadoBiblioteca _bibliotecario;
        private StaffWSClient _daoBibliotecario;
        public frmNuevoBibliotecario()
        {
            _estado = Estado.Inicial;
            _daoBibliotecario = new StaffWSClient();
            InitializeComponent();
            establecerEstadoComponentes();
            limpiarComponentes();
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
            txtHoraEntrada.Text = "";
            txtHoraSalida.Text = "";
            dtpFechaContratacion.Value = DateTime.Now;
            txtTituloTrabajo.Text = ""; 
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    tsbNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    tsbBuscarBibliotecario.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = false;
                    gboCredenciales.Enabled = false;
                    gboContrato.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarBibliotecario.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = true;
                    gboCredenciales.Enabled = true;
                    gboContrato.Enabled = true;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarBibliotecario.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = false;
                    gboCredenciales.Enabled = false;
                    gboContrato.Enabled = false;
                    break;
            }
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

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbBuscarBibliotecario_Click(object sender, EventArgs e)
        {
            frmBuscarBibliotecarios formBuscarBibliotecarios = new frmBuscarBibliotecarios();
            if (formBuscarBibliotecarios.ShowDialog() == DialogResult.OK)
            {
                _bibliotecario = formBuscarBibliotecarios.BibliotecarioSeleccionado;
                txtIDUsuario.Text = _bibliotecario.idUsuario.ToString();
                txtNombre.Text = _bibliotecario.nombre;
                txtApellidoMaterno.Text = _bibliotecario.apellidoMaterno;
                txtApellidoPaterno.Text = _bibliotecario.apellidoPaterno;
                dtpFechaNacimiento.Value = _bibliotecario.fechaNacimiento;
                _bibliotecario.fechaNacimientoSpecified = true;
                _bibliotecario.fechaContratacionSpecified = true;
                if (_bibliotecario.sexo == 'M') rbMasculino.Checked = true;
                if (_bibliotecario.sexo == 'F') rbFemenino.Checked = true;
                txtUsuario.Text = _bibliotecario.usuario1;
                txtPassword.Text = _bibliotecario.password;
                txtCorreoElectronico.Text = _bibliotecario.correoElectronico;
                txtHoraEntrada.Text = _bibliotecario.horaEntrada;
                txtHoraSalida.Text = _bibliotecario.horaSalida;
                dtpFechaContratacion.Value = _bibliotecario.fechaContratacion;
                txtTituloTrabajo.Text = _bibliotecario.titulo_trabajo; 
            }
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _bibliotecario = new encargadoBiblioteca();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("¿Está seguro que desea eliminar a este encargado de biblioteca?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoBibliotecario.eliminarEncargado(_bibliotecario.idEmpleado);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("El encargado de biblioteca se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El encargado de biblioteca no pudo eliminarse", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del encargado de biblioteca", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoMaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido materno del encargado de biblioteca", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoPaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido paterno del encargado de biblioteca", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbFemenino.Checked == false && rbMasculino.Checked == false)
            {
                MessageBox.Show("Debe indicar el genero del encargado de biblioteca", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtHoraEntrada.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la hora de entrada del encargado de biblioteca", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtHoraSalida.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la hora de salida del encargado de biblioteca", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTituloTrabajo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el titulo del trabajo del encargado de biblioteca", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreoElectronico.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el correo electronico del encargado de biblioteca", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el password del encargado de biblioteca", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el usuario del encargado de biblioteca", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _bibliotecario.nombre = txtNombre.Text;
            _bibliotecario.apellidoMaterno = txtApellidoMaterno.Text;
            _bibliotecario.apellidoPaterno = txtApellidoPaterno.Text;
            _bibliotecario.fechaNacimiento = dtpFechaNacimiento.Value.Date;
            _bibliotecario.fechaNacimientoSpecified = true;
            if (rbFemenino.Checked) _bibliotecario.sexo = 'F';
            else _bibliotecario.sexo = 'M';
            _bibliotecario.usuario1 = txtUsuario.Text;
            _bibliotecario.password = txtPassword.Text;
            _bibliotecario.correoElectronico = txtCorreoElectronico.Text;
            _bibliotecario.horaEntrada = txtHoraEntrada.Text;
            _bibliotecario.horaSalida = txtHoraSalida.Text;
            _bibliotecario.fechaContratacion = dtpFechaContratacion.Value.Date;
            _bibliotecario.fechaContratacionSpecified = true;
            _bibliotecario.titulo_trabajo = txtTituloTrabajo.Text;

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoBibliotecario.insertarEncargado(_bibliotecario);
                if (resultado != 0)
                {
                    txtIDUsuario.Text = resultado.ToString();
                    MessageBox.Show("El encargado de biblioteca se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _bibliotecario.idUsuario = Int32.Parse(txtIDUsuario.Text);
                int resultado = _daoBibliotecario.actualizarEncargado(_bibliotecario);
                if (resultado != 0)
                {
                    MessageBox.Show("El encargado de biblioteca se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
