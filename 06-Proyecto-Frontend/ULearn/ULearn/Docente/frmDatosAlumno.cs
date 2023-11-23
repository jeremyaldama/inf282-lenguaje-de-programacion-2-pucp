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
    public partial class frmDatosAlumno : Form
    {
        private Panel _panelPrincipal;
        private Form _formPadre;
        private alumno _alumno;
        public frmDatosAlumno(Form formPadre, Panel panelPrincipal, alumno alumno)
        {
            InitializeComponent();
            this.PanelPrincipal = panelPrincipal;
            this.FormPadre = formPadre;
            this._alumno = alumno;
        }

        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }
        public Form FormPadre { get => _formPadre; set => _formPadre = value; }

        private void llblNombreApellido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDetallePersona formDetalleAlumno = new frmDetallePersona(FormPadre, PanelPrincipal,_alumno);
            formDetalleAlumno.FormBorderStyle = FormBorderStyle.None;
            formDetalleAlumno.TopLevel = false;
            formDetalleAlumno.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(formDetalleAlumno);
            formDetalleAlumno.Visible = true;
        }

        private void frmDatosAlumno_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = _alumno.codigoAlumno;
            lblNombreApellido.Text = _alumno.nombre + " " + _alumno.apellidoPaterno + " " + _alumno.apellidoMaterno;
            lblCorreo.Text = _alumno.correoElectronico;
            lblFacultad.Text = _alumno.carrera.nombre;
        }
    }
}
