using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.ServiciosAcademicos;

namespace ULearn.Alumno
{
    public partial class frmRegistrarReclamo : Form
    {
        Form _formPadre;
        Panel _panelPrincipal;
        private ServiciosAcademicos.alumno _alumno;
        private ServiciosAcademicos.evaluacion _evaluacion;
        private ServiciosAcademicos.reclamo _reclamo;
        private ServiciosAcademicos.AcademicsWSClient _dao;
        public frmRegistrarReclamo(Form formPadre, Panel panelPrincipal, ServiciosAcademicos.alumno alum)
        {
            InitializeComponent();
            this.FormPadre = formPadre;
            this.PanelPrincipal = panelPrincipal;
            this._alumno = alum;
            _reclamo = new ServiciosAcademicos.reclamo();
            _dao = new ServiciosAcademicos.AcademicsWSClient();
        }

        public Form FormPadre { get => _formPadre; set => _formPadre = value; }
        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }

        private void frmRegistrarReclamo_Load(object sender, EventArgs e)
        {
            //lblValCodAlumno.Text = _reclamo.evaluacion.alumno.codigoAlumno;
            //lblValNomAlumno.Text = _reclamo.evaluacion.alumno.nombre + " " + _reclamo.evaluacion.alumno.apellidoPaterno + " " + _reclamo.evaluacion.alumno.apellidoMaterno;
            //lblValNomEvaluacion.Text = _reclamo.evaluacion.nombreEvaluacion.ToString();
            //txtDescp.Text = _reclamo.descripcion;
            lblValCodAlumno.Text = "Codigo Alumno";
            lblValNomEvaluacion.Text = "Evaluacion";
            lblValNomAlumno.Text = "Nombre Alumno";
            txtDescp.Text = "";
        }

        private void bttnBuscarEvaluacion_Click(object sender, EventArgs e)
        {
            frmBusquedaEvaluacion frmBusqueda = new frmBusquedaEvaluacion(_alumno);
            if(frmBusqueda.ShowDialog() == DialogResult.OK)
            {
                _evaluacion = frmBusqueda.Ev;
                lblValCodAlumno.Text = _alumno.codigoAlumno;
                lblValNomEvaluacion.Text = _evaluacion.nombreEvaluacion.ToString();
                lblValNomAlumno.Text = _alumno.nombre;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            //PanelPrincipal.Controls.Add(FormPadre);
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
           
            DateTime dia = DateTime.Now;
            string fechaFormateada = dia.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
            _reclamo.evaluacion = _evaluacion;
           _reclamo.fechaReclamoSpecified = true;
            _reclamo.fechaReclamo = DateTime.Parse(fechaFormateada);
            _reclamo.descripcion = txtDescp.Text;
            if(_dao.insertarReclamo(_reclamo)!=0)
            {
                MessageBox.Show("Reclamo exitoso", "Se ha registrado el reclamo con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _panelPrincipal.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Reclamo incorrecto", "No se ha registrado el reclamo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
