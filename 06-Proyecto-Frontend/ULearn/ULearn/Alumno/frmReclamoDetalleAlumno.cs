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

namespace ULearn.Alumno
{
    public partial class frmReclamoDetalleAlumno : Form
    {
        Form _formPadre;
        Panel _panelPrincipal;
        private ServiciosAcademicos.reclamo _reclamo;
        public frmReclamoDetalleAlumno(Form formPadre, Panel panelPrincipal, ServiciosAcademicos.reclamo reclamo)
        {
            InitializeComponent();
            FormPadre = formPadre;
            PanelPrincipal = panelPrincipal;
            this._reclamo = reclamo;
            lblCodAlumno.Text = reclamo.evaluacion.alumno.codigoAlumno;
            lblEvaluacion.Text = reclamo.evaluacion.nombreEvaluacion.ToString();
            lblFechaReclamo.Text = reclamo.fechaReclamo.ToString("dd/MM/yyyy");
        }

        public Form FormPadre { get => _formPadre; set => _formPadre = value; }
        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }

        private void llblDetalle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDetalleReclamoAlumno formDetalleReclamo = new frmDetalleReclamoAlumno(this, PanelPrincipal, _reclamo);
            formDetalleReclamo.FormBorderStyle = FormBorderStyle.None;
            formDetalleReclamo.TopLevel = false;
            formDetalleReclamo.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(formDetalleReclamo);
            formDetalleReclamo.Visible = true;
        }
    }
}
