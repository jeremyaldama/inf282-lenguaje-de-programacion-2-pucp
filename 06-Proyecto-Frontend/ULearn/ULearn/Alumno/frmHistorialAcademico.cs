using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.LibraryWS;
using ULearn.ServiciosAcademicos;

namespace ULearn.Alumno
{
    public partial class frmHistorialAcademico : Form
    {
        private AcademicsWSClient _daoAcademicWS;
        private alumno _alumno;
        BindingList<semestre> _semestres;
        public frmHistorialAcademico(alumno alumno)
        {
            InitializeComponent();
            _alumno = alumno;
            _daoAcademicWS = new AcademicsWSClient();

            _semestres = new BindingList<semestre>(_daoAcademicWS.listarSemestresPorAlumno(_alumno.idUsuario).ToList());

            semestre todos = new semestre();
            todos.semestre1 = "Todos";
            _semestres.Insert(0, todos);
            cboSemestre.DataSource = _semestres;
            cboSemestre.DisplayMember = "semestre1";
            cboSemestre.ValueMember = "idSemestre";
            cboSemestre.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            if (cboSemestre.SelectedIndex == 0)
            {
                for (int i=1; i<_semestres.Count(); i++)
                {
                    frmDatosCursosXSemestre frmCurSem = new frmDatosCursosXSemestre(_semestres[i], _alumno);
                    frmCurSem.TopLevel = false;
                    frmCurSem.Dock = DockStyle.Top;
                    panelContenido.Controls.Add(frmCurSem);
                    frmCurSem.Visible = true;
                }
            }
            else
            {
                frmDatosCursosXSemestre frmCurSem = new frmDatosCursosXSemestre(_semestres[cboSemestre.SelectedIndex], _alumno);
                frmCurSem.TopLevel = false;
                frmCurSem.Dock = DockStyle.Top;
                panelContenido.Controls.Add(frmCurSem);
                frmCurSem.Visible = true;
            }
        }

        private void frmHistorialAcademico_Load(object sender, EventArgs e)
        {
            lblRequeridosCur.Text = _alumno.carrera.cursosTotales.ToString();
            lblRequeridosCre.Text = _alumno.carrera.creditos.ToString();

            lblTotalCur.Text = _alumno.historialAcademico.cantCurTotal.ToString();
            lblTotalCre.Text = _alumno.historialAcademico.cantCredTotal.ToString();

            lblAprobadosCur.Text = _alumno.historialAcademico.cantCurAprobados.ToString();
            lblCumplidosCre.Text = _alumno.historialAcademico.cantCredAprob.ToString();

            lblFaltantesCur.Text = (_alumno.carrera.cursosTotales - _alumno.historialAcademico.cantCurAprobados).ToString();
            lblFaltantesCre.Text = (_alumno.carrera.creditos - _alumno.historialAcademico.cantCredAprob).ToString();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporteHistorialAcademico frmRHA = new frmReporteHistorialAcademico(_alumno.idUsuario);
            frmRHA.Show();
        }
    }
}
