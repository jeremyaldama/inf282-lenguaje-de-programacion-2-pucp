using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.Alumno;
using ULearn.ServiciosAcademicos;

namespace ULearn.Docente
{
    public partial class frmDetalleCurso : Form
    {
        private Panel _panelPrincipal;
        private Form _formPadre;
        private curso _curso;
        private BindingList<alumno> _alumnosCurso;
        private BindingList<evaluacion> _evaluacionesCurso;
        private AcademicsWSClient _dao;
        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }
        public Form FormPadre { get => _formPadre; set => _formPadre = value; }

        public frmDetalleCurso(Panel panelPrincipal, Form formPadre, curso curso)
        {
            InitializeComponent();
            PanelPrincipal = panelPrincipal;
            FormPadre = formPadre;
            _dao = new AcademicsWSClient();
            _curso = curso;
            try
            {
                _alumnosCurso = new BindingList<alumno>(_dao.listarAlumnosDeHorario(_curso.horarios[0].idHorario));
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void frmDetalleCurso_Load(object sender, EventArgs e)
        {
            lblNombre.Text = _curso.nombre;
            lblCodCurso.Text = _curso.codCurso;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(FormPadre);
            FormPadre.Visible = true;            
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                frmAlumnosCurso formListaAlumnos = new frmAlumnosCurso(this.panelContenido, _alumnosCurso);
                formListaAlumnos.FormBorderStyle = FormBorderStyle.None;
                formListaAlumnos.TopLevel = false;
                formListaAlumnos.Dock = DockStyle.Fill;
                this.panelContenido.Controls.Clear();
                this.panelContenido.Controls.Add(formListaAlumnos);
                formListaAlumnos.Visible = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No hay alumnos registrados para este curso", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<ServiciosAcademicos.reclamo> reclamos = new BindingList<reclamo>(_dao.listarReclamoPorCursoSemestre(_curso));
                frmReclamos formReclamos = new frmReclamos(this.panelContenido, reclamos);
                formReclamos.FormBorderStyle = FormBorderStyle.None;
                formReclamos.TopLevel = false;
                formReclamos.Dock = DockStyle.Fill;
                this.panelContenido.Controls.Clear();
                this.panelContenido.Controls.Add(formReclamos);
                formReclamos.Visible = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No hay reclamos registrados para este curso", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (_evaluacionesCurso == null)
                    _evaluacionesCurso = new BindingList<evaluacion>(_dao.listarEvaluacionPorCursoSemestre(_curso));
                frmNotas formNotas = new frmNotas(_evaluacionesCurso, _alumnosCurso);
                formNotas.FormBorderStyle = FormBorderStyle.None;
                formNotas.TopLevel = false;
                formNotas.Dock = DockStyle.Fill;
                this.panelContenido.Controls.Clear();
                this.panelContenido.Controls.Add(formNotas);
                formNotas.Visible = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            try
            {
                if (_evaluacionesCurso == null)
                    _evaluacionesCurso = new BindingList<evaluacion>(_dao.listarEvaluacionPorCursoSemestre(_curso));
                frmEstadisticasCurso formEstadisticasCurso = new frmEstadisticasCurso(_curso.horarios[0], _curso, _evaluacionesCurso, _alumnosCurso.Count);
                this.panelContenido.Controls.Clear();
                formEstadisticasCurso.TopLevel = false;
                formEstadisticasCurso.FormBorderStyle = FormBorderStyle.None;
                formEstadisticasCurso.Dock = DockStyle.Fill;
                this.panelContenido.Controls.Add(formEstadisticasCurso);
                formEstadisticasCurso.Visible = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
