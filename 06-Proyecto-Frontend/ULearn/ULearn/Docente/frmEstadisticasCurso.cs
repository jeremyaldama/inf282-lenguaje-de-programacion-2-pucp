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

namespace ULearn.Docente
{
    public partial class frmEstadisticasCurso : Form
    {
        private BindingList<ServiciosAcademicos.evaluacion> _evaluaciones;
        private BindingList<ServiciosAcademicos.evaluacion> _elegidas;
        private curso _curso;
        private horario _horario;
        private AcademicsWSClient _dao;
        public frmEstadisticasCurso(horario horario, curso curso, BindingList<ServiciosAcademicos.evaluacion> evaluaciones, int matriculados)
        {
            this._evaluaciones = evaluaciones;
            InitializeComponent();
            this.cboEval.DataSource = Enum.GetNames(typeof(ServiciosAcademicos.nombreEvaluacion));
            lblValMat.Text = matriculados.ToString();
            _dao = new AcademicsWSClient();
            this._curso = curso;
            this._horario = _dao.hallarTotalizadosHorario(horario,curso);
            if (this._horario.media != - 1 && this._horario.aprobados != -1)
            {
                lblValAp.Text = this._horario.aprobados.ToString();
                lblValMedia.Text = this._horario.media.ToString();
            }
        }

        private void cboEval_SelectedIndexChanged(object sender, EventArgs e)
        {
            _elegidas = new BindingList<ServiciosAcademicos.evaluacion>(_evaluaciones.Where(x => x.nombreEvaluacion.ToString() == cboEval.SelectedItem.ToString()).ToList());
            dgvNotas.AutoGenerateColumns = false;
            dgvNotas.DataSource = _elegidas;
            dgvNotas.ClearSelection();
            BindingList<ServiciosAcademicos.evaluacion> _cuantificables = new BindingList<ServiciosAcademicos.evaluacion>(_elegidas.Where(x => x.nota != -1).ToList());
            try
            {
                lblValMedEval.Text = _cuantificables.Average(x => x.nota).ToString();
                lblValAsist.Text = _cuantificables.Count.ToString();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("No hay notas disponibles para esta evaluación", "Mensaje de alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                lblValAsist.Text = "-";
                lblValMedEval.Text = "-";
            }
        }

        private void dgvNota_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ServiciosAcademicos.evaluacion eval = (ServiciosAcademicos.evaluacion)dgvNotas.Rows[e.RowIndex].DataBoundItem;
            dgvNotas.Rows[e.RowIndex].Cells[0].Value = eval.alumno.codigoAlumno;
            dgvNotas.Rows[e.RowIndex].Cells[1].Value = eval.alumno.apellidoPaterno + " " + eval.alumno.apellidoMaterno + ", " + eval.alumno.nombre;
            if(eval.nota != -1)
                dgvNotas.Rows[e.RowIndex].Cells[2].Value = eval.nota;
            else
                dgvNotas.Rows[e.RowIndex].Cells[2].Value = 'F'; //faltó
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporteCurso formReporteCurso = new frmReporteCurso(this._curso, this._horario);
            formReporteCurso.Show();
        }
    }
}
