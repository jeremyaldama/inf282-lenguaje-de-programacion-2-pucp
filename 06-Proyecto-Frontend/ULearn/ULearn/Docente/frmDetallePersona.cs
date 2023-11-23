using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.ServiciosAcademicos;

namespace ULearn.Docente
{
    public partial class frmDetallePersona : Form
    {
        Form _formPadre;
        Panel _panelPrincipal;
        private alumno _alumno;
        private docente _docente;
        private usuario _persona;
        public frmDetallePersona(Form formPadre, Panel panelPrincipal, ServiciosAcademicos.usuario persona)
        {
            InitializeComponent();
            this.FormPadre = formPadre;
            this.PanelPrincipal = panelPrincipal;
            _persona = persona;
            if (persona is ServiciosAcademicos.alumno)
                _alumno = (alumno)persona;
            if(persona is ServiciosAcademicos.docente)
                _docente = (docente)persona;
        }

        public frmDetallePersona(alumno alumno) { 
            InitializeComponent();
            this.btnVolver.Visible = false;
            this._alumno = alumno;
        }
        public Form FormPadre { get => _formPadre; set => _formPadre = value; }
        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(FormPadre);
        }

        private void btnHistorialAcademico_Click(object sender, EventArgs e)
        {
            ULearn.Alumno.frmReporteHistorialAcademico formReporte = new Alumno.frmReporteHistorialAcademico(_alumno.codAlumno);
            formReporte.Show();
        }

        private void frmDetallePersona_Load(object sender, EventArgs e)
        {
            if(_alumno != null) { 
                txtCodigo.Text = _alumno.codigoAlumno;
                txtEspecialidad.Text = _alumno.carrera.nombre;
                lblCondicion.Visible = false;
                txtTipo.Visible = false;
            }  
            else if(_docente != null)
            {
                lblCarrera.Text = "Facultad:";
                txtEspecialidad.Text = _docente.facultad.nombre;
                txtTipo.Text = _docente.tipoDocente;
                txtNivelAcademico.Text = _docente.gradoAcademico;
                btnHistorialAcademico.Enabled = false;
                btnHistorialAcademico.Visible = false;
            }
            txtCorreoElectronico.Text = _persona.correoElectronico;
            txtNombres.Text = _persona.nombre + " " + _persona.apellidoPaterno + " " + _persona.apellidoMaterno;
        }

        public void noMostrarReporte()
        {
            btnHistorialAcademico.Visible = false;
            btnHistorialAcademico.Enabled = false;
        }
    }
}
