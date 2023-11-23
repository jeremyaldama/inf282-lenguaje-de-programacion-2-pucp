using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.ServiciosAcademicos;
using ULearn.LogisticsWs;
using docente = ULearn.ServiciosAcademicos.docente;
using facultad = ULearn.ServiciosAcademicos.facultad;

namespace ULearn.Administrador
{
    public partial class frmNuevoDocente : Form
    {

        BindingList<string> tiposDocente = new BindingList<string>{"TC","TP"};
        BindingList<string> gradoAcademico = new BindingList<string> { "MAGISTER", "DOCTOR", "BACHILLER", "LICENCIADO"};
        
        private Estado _estado;
        private docente _docente;
        private AcademicsWSClient _daoDocente;
        private LogisticsWSClient _daoFacultad;
        public frmNuevoDocente()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            _daoDocente = new AcademicsWSClient();
            _daoFacultad = new LogisticsWSClient();
            cboFacultad.DataSource = _daoFacultad.listarTodasFacultades();
            cboTipoDocente.DataSource = tiposDocente;
            cboGradoAcademico.DataSource = gradoAcademico;
            cboFacultad.DisplayMember = "Nombre";
            cboFacultad.ValueMember = "IdFacultad";
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
                    tsbBuscarDocente.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = false;
                    gboAcademica.Enabled = false;
                    gboCredenciales.Enabled = false;
                    gboContrato.Enabled = false;
                    break;
                case Estado.Nuevo:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarDocente.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = true;
                    gboAcademica.Enabled = true;
                    gboCredenciales.Enabled = true;
                    gboContrato.Enabled = true;
                    txtUsuario.Enabled = false;
                    txtPassword.Enabled = false;
                    break;
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarDocente.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = true;
                    gboAcademica.Enabled = true;
                    gboCredenciales.Enabled = true;
                    gboContrato.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtPassword.Enabled = true;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarDocente.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoPersonal.Enabled = false;
                    gboAcademica.Enabled = false;
                    gboCredenciales.Enabled = false;
                    gboContrato.Enabled = false;
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
            txtInteresInvestigacion.Text = "";
            txtOficina.Text = "";
            txtHoraEntrada.Text = "";
            cboFacultad.SelectedIndex = -1;
            cboGradoAcademico.SelectedIndex = -1;
            cboTipoDocente.SelectedIndex = -1;
            txtHoraSalida.Text = "";
            dtpFechaContratacion.Value = DateTime.Now;
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

        private void tsbBuscarDocente_Click(object sender, EventArgs e)
        {
            frmBuscarDocente formBuscarDocente = new frmBuscarDocente();
            if (formBuscarDocente.ShowDialog() == DialogResult.OK)
            {
                _docente = formBuscarDocente.DocenteSeleccionado;
                txtIDUsuario.Text = _docente.idUsuario.ToString();
                txtNombre.Text = _docente.nombre;
                txtApellidoMaterno.Text = _docente.apellidoMaterno;
                txtApellidoPaterno.Text = _docente.apellidoPaterno; 
                dtpFechaNacimiento.Value = _docente.fechaNacimiento;
                _docente.fechaNacimientoSpecified = true;
                _docente.fechaContratacionSpecified = true;
                if (_docente.sexo == 'M') rbMasculino.Checked = true;
                if(_docente.sexo == 'F') rbFemenino.Checked = true;
                txtUsuario.Text = _docente.usuario1;
                txtPassword.Text = _docente.password; 
                txtCorreoElectronico.Text = _docente.correoElectronico;
                cboTipoDocente.SelectedItem = _docente.tipoDocente;
                cboGradoAcademico.SelectedItem = _docente.gradoAcademico;
                txtOficina.Text = _docente.oficina;
                txtInteresInvestigacion.Text = _docente.intereses;
                dtpFechaContratacion.Value = _docente.fechaContratacion;
                txtHoraEntrada.Text = _docente.horaEntrada;
                txtHoraSalida.Text = _docente.horaSalida;
                cboFacultad.SelectedValue = _docente.facultad.idFacultad; 

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
            _docente = new docente();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("¿Está seguro que desea eliminar este docente?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoDocente.eliminarDocentePorId(_docente.idEmpleado);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("El docente se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El docente no pudo eliminarse", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
           
            _docente.nombre = txtNombre.Text;
            _docente.apellidoMaterno = txtApellidoMaterno.Text;
            _docente.apellidoPaterno = txtApellidoPaterno.Text;
            _docente.fechaNacimiento = dtpFechaNacimiento.Value;
            _docente.fechaNacimientoSpecified = true;
            if (rbFemenino.Checked) _docente.sexo = 'F';
            else _docente.sexo = 'M';
            
            _docente.correoElectronico = txtCorreoElectronico.Text;
            _docente.tipoDocente = cboTipoDocente.SelectedItem.ToString();
            _docente.intereses = txtInteresInvestigacion.Text;
            _docente.gradoAcademico = cboGradoAcademico.SelectedItem.ToString();
            _docente.oficina = txtOficina.Text;
            _docente.horaEntrada = txtHoraEntrada.Text;
            _docente.horaSalida = txtHoraSalida.Text;
            _docente.fechaContratacion = dtpFechaContratacion.Value;
            _docente.fechaContratacionSpecified = true;

            _docente.facultad = new facultad();
            _docente.facultad.idFacultad = (int)cboFacultad.SelectedValue;

            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoMaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido materno del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoPaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido paterno del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtOficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la oficina del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbFemenino.Checked == false && rbMasculino.Checked == false)
            {
                MessageBox.Show("Debe indicar el genero del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtHoraEntrada.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la hora de entrada del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtHoraSalida.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la hora de salida del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtInteresInvestigacion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar los intereses de investigacion del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreoElectronico.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el correo electronico del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            if (_estado == Estado.Nuevo)
            {
                _docente.usuario1 = txtCorreoElectronico.Text.ToLower().Substring(0, txtCorreoElectronico.Text.IndexOf("@"));
                _docente.password = _docente.usuario1; 
                txtPassword.Text = _docente.password;
                txtUsuario.Text = _docente.usuario1;

                if (txtPassword.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar el password del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtUsuario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar el usuario del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int resultado = _daoDocente.insertarDocente(_docente);
                if (resultado != 0)
                {
                    txtIDUsuario.Text = resultado.ToString();
                    MessageBox.Show("El docente se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _docente.password = txtPassword.Text;
                _docente.usuario1 = txtUsuario.Text;

                if (txtPassword.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar el password del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtUsuario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Debe ingresar el usuario del docente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int resultado = _daoDocente.actualizarDocente(_docente);
                if (resultado != 0)
                {
                    MessageBox.Show("El docente se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
