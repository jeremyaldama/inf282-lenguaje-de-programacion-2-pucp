using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULearn.Alumno
{

    public partial class frmDetalleReclamoAlumno : Form
    {
        Form _formPadre;
        Panel _panelPrincipal;
        private ServiciosAcademicos.reclamo _reclamo;
        private ServiciosAcademicos.AcademicsWSClient _dao;
        public frmDetalleReclamoAlumno(Form formPadre, Panel panelPrincipal, ServiciosAcademicos.reclamo reclamo)
        {
            InitializeComponent();
            this.FormPadre = formPadre;
            this.PanelPrincipal = panelPrincipal;
            this._reclamo = reclamo;
            _dao = new ServiciosAcademicos.AcademicsWSClient();
        }

        public Form FormPadre { get => _formPadre; set => _formPadre = value; }
        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }

        private void frmDetalleReclamoAlumno_Load(object sender, EventArgs e)
        {
            lblValCodAlumno.Text = _reclamo.evaluacion.alumno.codigoAlumno;
            lblValNomAlumno.Text = _reclamo.evaluacion.alumno.nombre + " " + _reclamo.evaluacion.alumno.apellidoPaterno + " " + _reclamo.evaluacion.alumno.apellidoMaterno;
            lblValNomEvaluacion.Text = _reclamo.evaluacion.nombreEvaluacion.ToString();
            txtDescp.Text = _reclamo.descripcion;
            txtDescp.ReadOnly = true;
            rbProcede.Checked = _reclamo.valido;
            rbNoProcede.Checked = !_reclamo.valido;
            rbNoProcede.Enabled = false;
            rbProcede.Enabled = false;
            txtRespuesta.Text = _reclamo.respuesta;
            txtRespuesta.ReadOnly = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            //PanelPrincipal.Controls.Add(FormPadre);
        }
    }
}
