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
    public partial class frmDatosPersona : Form
    {
        Form _formPadre;
        Panel _panelPrincipal;
        ServiciosAcademicos.usuario _persona;

        public frmDatosPersona(Form formPadre, Panel panelPrincipal, ServiciosAcademicos.usuario persona)
        {
            InitializeComponent();
            FormPadre = formPadre;
            PanelPrincipal = panelPrincipal;
            this._persona = persona;
        }
        public Form FormPadre { get => _formPadre; set => _formPadre = value; }
        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }

        private void llblNombreApellido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDetallePersona formDetallePersona = new frmDetallePersona(this.FormPadre, this.PanelPrincipal,_persona);
            PanelPrincipal.Controls.Clear();
            formDetallePersona.FormBorderStyle = FormBorderStyle.None;
            formDetallePersona.TopLevel = false;
            formDetallePersona.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Add(formDetallePersona);
            formDetallePersona.noMostrarReporte();
            formDetallePersona.Visible = true;
        }

        private void frmDatosPersona_Load(object sender, EventArgs e)
        {
            if(_persona is ServiciosAcademicos.docente)
            {
                ServiciosAcademicos.docente d = (docente)_persona;
                lblCodigo.Text = "A" + d.idEmpleado.ToString();
                lblFacultad.Text = d.facultad.nombre;
                lblTipoPersona.Text = "Docente";
            }
            if(_persona is ServiciosAcademicos.alumno)
            {
                ServiciosAcademicos.alumno al = (alumno)_persona;
                lblCodigo.Text = al.codigoAlumno;
                lblFacultad.Text = al.carrera.facultad.nombre;
                lblTipoPersona.Text = "Alumno";
            }
            llblNombreApellido.Text = _persona.apellidoPaterno + " " + _persona.apellidoMaterno + ", " + _persona.nombre;
        }
    }
}
