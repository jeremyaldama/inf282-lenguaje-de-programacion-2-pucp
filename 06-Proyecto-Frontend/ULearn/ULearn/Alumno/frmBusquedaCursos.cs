using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.Docente;
using ULearn.LogisticsWs;
using ULearn.ServiciosAcademicos;

namespace ULearn.Alumno
{
    public partial class frmBusquedaCursos : Form
    {
        private AcademicsWSClient wsclient;
        private BindingList<ServiciosAcademicos.horario> _horarios;
        private BindingList<ServiciosAcademicos.curso> cursos;
        private ServiciosAcademicos.curso cur;
        public frmBusquedaCursos()
        {
            wsclient = new AcademicsWSClient();
            
            InitializeComponent();
        }

        public void mostrarForm(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            lblCodigoCurso.Visible = true;
            lblCreditos.Visible = true;
            lblNombreCurso.Visible = true;
            cursos = new BindingList<ServiciosAcademicos.curso>(wsclient.listarCursosCodigoNombre(txtNombreCurso.Text));
            foreach (ServiciosAcademicos.curso c in cursos)
            {
                frmDatosCursoAlumno formDatCursos = new frmDatosCursoAlumno(c);
                formDatCursos.TopLevel = false;
                formDatCursos.Dock = DockStyle.Top;
                this.panelContenido.Controls.Add(formDatCursos);
                formDatCursos.Visible = true;
            }

        }

        private void bttnLimpiar_Click(object sender, EventArgs e)
        {
            lblCodigoCurso.Visible = false;
            lblCreditos.Visible = false;
            lblNombreCurso.Visible=false;
            panelContenido.Controls.Clear();
        }

        private void frmBusquedaCursos_Load(object sender, EventArgs e)
        {
            lblCodigoCurso.Visible = false;
            lblCreditos.Visible = false;
            lblNombreCurso.Visible=false;
        }
    }
}
