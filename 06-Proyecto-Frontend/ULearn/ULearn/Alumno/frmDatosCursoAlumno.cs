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
    public partial class frmDatosCursoAlumno : Form
    {
        public frmDatosCursoAlumno(curso curso)
        {
            InitializeComponent();
            lblCodigoCurso.Text = curso.codCurso.ToString();
            lblNombreCurso.Text = curso.nombre;
            lblCreditos.Text = curso.creditos.ToString();
        }
    }
}
