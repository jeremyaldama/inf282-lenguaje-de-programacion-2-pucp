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

namespace ULearn.Alumno
{
    public partial class frmDatosCursosXSemestre : Form
    {
        private AcademicsWSClient _daoAcademicsWS;
        public frmDatosCursosXSemestre(semestre semestre, alumno alumno)
        {
            InitializeComponent();
            _daoAcademicsWS = new AcademicsWSClient();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = _daoAcademicsWS.listarCASSPorAlumnoSemestre(alumno.idUsuario, semestre.idSemestre);

            //BindingList<cursoXAlumnoXSemestre> cas = new BindingList<cursoXAlumnoXSemestre>( _daoAcademicsWS.listarCASSPorAlumnoSemestre(alumno.idUsuario, semestre.idSemestre) );

            //for (int i=0; i<cas.Count; i++)
            //{
            //    dgvCursos.Rows[i].Cells[0].Value = cas.curso.codCurso;
            //    dgvCursos.Rows[i].Cells[1].Value = cas.curso.nombre;
            //    dgvCursos.Rows[i].Cells[2].Value = cas.curso.creditos;
            //    dgvCursos.Rows[i].Cells[3].Value = cas.vez;
            //    dgvCursos.Rows[i].Cells[4].Value = cas.nota;
            //}

            txtCiclo.Text = semestre.semestre1;
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            cursoXAlumnoXSemestre cas = (cursoXAlumnoXSemestre)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            dgvCursos.Rows[e.RowIndex].Cells[0].Value = cas.curso.codCurso;
            dgvCursos.Rows[e.RowIndex].Cells[1].Value = cas.curso.nombre;
            dgvCursos.Rows[e.RowIndex].Cells[2].Value = cas.curso.creditos;
            dgvCursos.Rows[e.RowIndex].Cells[3].Value = cas.vez;
            dgvCursos.Rows[e.RowIndex].Cells[4].Value = cas.nota;
        }

        private void dgvCursos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
