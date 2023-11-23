using System;
using System.Collections;
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
    public partial class frmCursos : Form
    {
        private Panel _panelPrincipal;
        private BindingList<curso> _cursos;
        private BindingList<horario> _horarios;
        public frmCursos(Panel panelPrincipal, BindingList<curso> cursos, BindingList<horario> horarios)
        {
            InitializeComponent();
            _panelPrincipal = panelPrincipal;
            this._cursos = cursos;
            this._horarios = horarios;
        }

        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }


        private void frmCursos_Load(object sender, EventArgs e)
        {
            BindingList<curso> ordenados = new BindingList<curso>(_cursos.OrderBy(curso => curso.semestreDictado.semestre1).ToList());
            txtTotal.Text = _cursos.Count.ToString();
            this._cursos = ordenados;
            txtSemestre.Text = _cursos[_cursos.Count - 1].semestreDictado.semestre1;
            foreach(curso c in this._cursos)
            {
                if (c.semestreDictado.semestre1 == txtSemestre.Text){
                    BindingList<horario> _especificos = new BindingList<horario>();
                    foreach (horario h in this._horarios)
                    {
                        if (h.curso.nombre == c.nombre)
                        {
                            _especificos.Add(h);
                        }

                    }
                    c.horarios = _especificos.ToArray();
                    frmDatosCurso formDatCursos = new frmDatosCurso(PanelPrincipal, this, c);
                    formDatCursos.TopLevel = false;
                    formDatCursos.Dock = DockStyle.Top;
                    this.panelCursosDictados.Controls.Add(formDatCursos);
                    formDatCursos.Visible = true;
                }
            }
            
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            frmHorario formHorario = new frmHorario(this._horarios);
            formHorario.Show();
        }
    }
}
