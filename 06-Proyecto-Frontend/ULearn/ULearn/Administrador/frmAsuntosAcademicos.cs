using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULearn.Administrador
{
    public partial class frmAsuntosAcademicos : Form
    {
        public frmAsuntosAcademicos()
        {
            InitializeComponent();
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

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            frmNuevoDocente formNuevoDocente = new frmNuevoDocente();
            mostrarFormulario(formNuevoDocente);
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            frmNuevoCurso formNuevoCurso = new frmNuevoCurso();
            mostrarFormulario(formNuevoCurso);
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            frmNuevaCarrera formNuevaCarrera = new frmNuevaCarrera();
            mostrarFormulario(formNuevaCarrera);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmNuevoAlumno formNuevoAlumno = new frmNuevoAlumno();
            mostrarFormulario(formNuevoAlumno);
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            frmNuevoHorario formNuevoHorario = new frmNuevoHorario();
            mostrarFormulario(formNuevoHorario);
        }

        private void btnCursos_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCarreras_Click_1(object sender, EventArgs e)
        {

        }

        private void frmAsuntosAcademicos_Load(object sender, EventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
