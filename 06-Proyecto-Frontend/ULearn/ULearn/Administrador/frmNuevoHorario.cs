using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.ServiciosAcademicos;
using ULearn.LogisticsWs;
using curso = ULearn.ServiciosAcademicos.curso;
using docente = ULearn.ServiciosAcademicos.docente;
using alumno = ULearn.ServiciosAcademicos.alumno;
using horario = ULearn.ServiciosAcademicos.horario;
using ULearn.ReportesWS;

namespace ULearn.Administrador
{
    public partial class frmNuevoHorario : Form
    {
        private Estado _estado;
        private horario _horario;
        private docente _docente;
        private alumno _alumno; 
        private AcademicsWSClient _daoHorario;
        private AcademicsWSClient _daoDocente;
        private BindingList<docente> _docentes;
        private BindingList<alumno> _alumnos;
        public frmNuevoHorario()
        {
            InitializeComponent();
            _daoHorario = new AcademicsWSClient();
            _daoDocente = new AcademicsWSClient();
            _estado = Estado.Inicial;
            cboDia.DataSource = Enum.GetNames(typeof(ServiciosAcademicos.diaSemana));
            limpiarComponentes();
            establecerEstadoComponentes();
            dgvAlumnos.AutoGenerateColumns = false;
            dgvDocentes.AutoGenerateColumns = false;
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    tsbNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    tsbBuscarHorario.Enabled = true;
                    btnCancelar.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    gboInfoHorario.Enabled = false;
                    gboInfoCronograma.Enabled = false;
                    break;
                case Estado.Nuevo:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarHorario.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoHorario.Enabled = true;
                    gboInfoCronograma.Enabled = true;
                    txtTiempoTolerancia.ReadOnly = false;
                    txtCodigo.ReadOnly = false;
                    break;
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarHorario.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoHorario.Enabled = true;
                    gboInfoCronograma.Enabled = true;
                    txtTiempoTolerancia.ReadOnly = true;
                    txtCodigo.ReadOnly = true;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarHorario.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoHorario.Enabled = false;
                    gboInfoCronograma.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDHorario.Text = "";
            txtCurso.Text = ""; 
            txtCodigo.Text = "";
            txtTiempoTolerancia.Text = "";
            rbPractica.Checked = false;
            rbClase.Checked = false;
            rbLaboratorio.Checked = false;
            txtVacantes.Text = "";
            txtMatriculados.Text = "";
            cboDia.SelectedIndex = -1;
            txtHoraFin.Text = "";
            txtHoraInicio.Text = "";
            txtIDUsuario.Text = "";
            txtNombre.Text = "";
            txtTipoDocente.Text = "";
            txtFacultad.Text = "";
            txtIDAlumno.Text = "";
            txtNombreCompleto.Text = "";
            txtCodigoAlumno.Text = "";
            txtCarrera.Text = ""; 
        }

        public void limpiarComponentesAlumno()
        {
            txtIDAlumno.Text = "";
            txtNombreCompleto.Text = "";
            txtCodigoAlumno.Text = "";
            txtCarrera.Text = "";
        }

        public void limpiarComponentesDocente()
        {
            txtIDUsuario.Text = "";
            txtNombre.Text = "";
            txtTipoDocente.Text = "";
            txtFacultad.Text = "";
        }

        private void gboDetallePrestamo_Enter(object sender, EventArgs e)
        {

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

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarHorarios formBuscarHorarios = new frmBuscarHorarios();
            if (formBuscarHorarios.ShowDialog() == DialogResult.OK)
            {
                _horario = formBuscarHorarios.HorarioSeleccionado;
                txtIDHorario.Text = _horario.idHorario.ToString();
                txtCurso.Text = _horario.curso.idCurso.ToString();
                txtCodigo.Text = _horario.codigo.ToString();
                txtTiempoTolerancia.Text = _horario.tiempoTolerancia.ToString();
                if (_horario.tipoHorario == 'C') rbClase.Checked = true;
                if (_horario.tipoHorario == 'L') rbLaboratorio.Checked = true;
                if (_horario.tipoHorario == 'P') rbPractica.Checked = true;
                txtVacantes.Text = _horario.vacantes.ToString();
                txtMatriculados.Text = _horario.matriculados.ToString();
                int index = Array.IndexOf(Enum.GetValues(_horario.dia.GetType()), _horario.dia);
                cboDia.SelectedIndex= index;
                txtHoraFin.Text = _horario.horaFin.ToString(); 
                txtHoraInicio.Text = _horario.horaInicio.ToString();

                if (_horario.alumnos != null)
                {
                    _alumnos = new BindingList<alumno>(_horario.alumnos.ToList());
                    dgvAlumnos.DataSource = _alumnos;
                }
                if (_horario.docentes != null)
                {
                    _docentes = new BindingList<docente>(_horario.docentes.ToList());
                    dgvDocentes.DataSource = _docentes;
                }
            }
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _horario = new horario();
            _alumno = new alumno();
            _docente = new docente(); 
            _docentes = new BindingList<docente>();
            _alumnos = new BindingList<alumno>();
            dgvAlumnos.DataSource = _alumnos;
            dgvDocentes.DataSource = _docentes; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            if(_alumnos != null) _alumnos.Clear();
            if (_docentes != null) _docentes.Clear(); 
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("¿Está seguro que desea eliminar este horario?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoHorario.eliminarHorario(_horario.idHorario);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("El horario se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el codigo del horario", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbClase.Checked == false && rbLaboratorio.Checked == false && rbPractica.Checked == false)
            {
                MessageBox.Show("Debe indicar el tipo de horario", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCurso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe seleccionar el curso al que pertenece el horario", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTiempoTolerancia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el tiempo de tolerancia que brinda el horario", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtTiempoTolerancia.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como tiempo de tolerancia", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtVacantes.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la cantidad de vacantes que brinda el horario", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtVacantes.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como cantidad de vacantes", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMatriculados.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar la cantidad de alumnos matriculados en el horario", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtMatriculados.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como cantidad de alumnos matriculados", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _horario.codigo = txtCodigo.Text;
            _horario.tiempoTolerancia = Int32.Parse(txtTiempoTolerancia.Text);
            if (rbClase.Checked) _horario.tipoHorario = 'C';
            if (rbLaboratorio.Checked) _horario.tipoHorario = 'L';
            if (rbPractica.Checked) _horario.tipoHorario = 'P';
            _horario.vacantes = Int32.Parse(txtVacantes.Text);
            _horario.matriculados = Int32.Parse(txtMatriculados.Text);
            _horario.dia = (ServiciosAcademicos.diaSemana)cboDia.SelectedIndex;
            _horario.diaSpecified = true;
            _horario.horaInicio = txtHoraInicio.Text;
            _horario.horaFin = txtHoraFin.Text;


            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoHorario.insertarHorario(_horario);
                if (resultado != 0)
                {
                    txtIDHorario.Text = _horario.idHorario.ToString();
                    _horario.idHorario = resultado;
                    MessageBox.Show("El horario se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                    foreach(ServiciosAcademicos.alumno a in this._alumnos)
                    {
                        _daoDocente.agregarAlumnoAHorario(a, this._horario);
                    }

                    foreach (ServiciosAcademicos.docente d in this._docentes)
                    {
                        _daoDocente.agregarDocenteAHorario(d.idEmpleado, this._horario.idHorario);
                    }

                    if (_alumnos != null) _alumnos.Clear();
                    if (_docentes != null) _docentes.Clear();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (_estado == Estado.Modificar)
            {
                _horario.idHorario = Int32.Parse(txtIDHorario.Text);
                int resultado = _daoHorario.modificarHorario(_horario);
                if (resultado != 0)
                {
                    MessageBox.Show("El horario se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error en la modificacion", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tsbBuscarDocentes_Click(object sender, EventArgs e)
        {
            frmBuscarDocente formBuscarDocente = new frmBuscarDocente();
            if (formBuscarDocente.ShowDialog() == DialogResult.OK)
            {
                _docente = formBuscarDocente.DocenteSeleccionado;
                txtIDUsuario.Text = _docente.idUsuario.ToString();
                txtNombre.Text = _docente.apellidoPaterno + " " + _docente.apellidoMaterno + ", " + _docente.nombre;
                txtTipoDocente.Text = _docente.tipoDocente;
                txtFacultad.Text = _docente.facultad.nombre;
            }
        }

        private void dgvDocente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            docente docente = (docente)dgvDocentes.Rows[e.RowIndex].DataBoundItem;
            if (docente != null)
            {
                dgvDocentes.Rows[e.RowIndex].Cells[0].Value = docente.idEmpleado;
                dgvDocentes.Rows[e.RowIndex].Cells[1].Value = docente.apellidoPaterno + " " + docente.apellidoMaterno + ", " + docente.nombre;
                dgvDocentes.Rows[e.RowIndex].Cells[2].Value = docente.tipoDocente;
                dgvDocentes.Rows[e.RowIndex].Cells[3].Value = docente.facultad.idFacultad;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtIDUsuario.Text == "")
            {
                MessageBox.Show("Debe seleccionar un docente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _docentes.Add(_docente);
            limpiarComponentesDocente();

        }

        private void tsbBuscarAlumnos_Click(object sender, EventArgs e)
        {
            frmBuscarAlumno formBuscarAlumno = new frmBuscarAlumno();
            if (formBuscarAlumno.ShowDialog() == DialogResult.OK)
            {
                _alumno = formBuscarAlumno.AlumnoSeleccionado;
                txtIDAlumno.Text = _alumno.idUsuario.ToString();
                txtNombreCompleto.Text = _alumno.apellidoPaterno + " " + _alumno.apellidoMaterno + ", " + _alumno.nombre;
                txtCodigoAlumno.Text = _alumno.codigoAlumno;
                txtCarrera.Text = _alumno.carrera.nombre;
            }
        }

        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            alumno alumno = (alumno)dgvAlumnos.Rows[e.RowIndex].DataBoundItem;
            if (alumno != null)
            {
                dgvAlumnos.Rows[e.RowIndex].Cells[0].Value = alumno.codAlumno;
                dgvAlumnos.Rows[e.RowIndex].Cells[1].Value = alumno.apellidoPaterno + " " + alumno.apellidoMaterno + ", " + alumno.nombre;
                dgvAlumnos.Rows[e.RowIndex].Cells[2].Value = alumno.codigoAlumno;
                dgvAlumnos.Rows[e.RowIndex].Cells[3].Value = alumno.carrera.nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow != null)
            {
                alumno alumnoEliminar = (alumno)dgvAlumnos.CurrentRow.DataBoundItem;
                _alumnos.Remove(alumnoEliminar); 
            }
            else
            {
                MessageBox.Show("Debe seleccionar un alumno", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.CurrentRow != null)
            {
                docente docenteEliminar = (docente)dgvDocentes.CurrentRow.DataBoundItem;
                _docentes.Remove(docenteEliminar);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un docente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (txtIDAlumno.Text == "")
            {
                MessageBox.Show("Debe seleccionar un alumno", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _alumnos.Add(_alumno);
            limpiarComponentesAlumno(); 
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            frmBuscarCursos formBuscarCursos = new frmBuscarCursos();
            if (formBuscarCursos.ShowDialog() == DialogResult.OK)
            {
                _horario.curso = formBuscarCursos.CursoSeleccionado;
                txtCurso.Text = _horario.curso.nombre; 
            }
        }
    }
}
