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
    public partial class frmAlumnosCurso : Form
    {
        private Panel _panelPrincipal;
        private BindingList<alumno> _alumnosCurso;
        public frmAlumnosCurso(Panel panelPrincipal, BindingList<alumno> alumnosCurso)
        {
            this.PanelPrincipal = panelPrincipal;
            InitializeComponent();
            _alumnosCurso = alumnosCurso;
        }

        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }

        private void frmAlumnosCurso_Load(object sender, EventArgs e)
        {
            foreach(alumno a in _alumnosCurso)
            {
                frmDatosAlumno formDatAlumno = new frmDatosAlumno(this, PanelPrincipal, a);
                formDatAlumno.Dock = DockStyle.Top;
                formDatAlumno.TopLevel = false;
                this.panelContenido.Controls.Add(formDatAlumno);
                formDatAlumno.Visible = true;
            }
        }
    }
}
