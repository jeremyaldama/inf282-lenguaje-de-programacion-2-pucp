using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULearn.Docente
{
    public partial class frmReclamoPorAtender : Form
    {
        Form _formPadre;
        Panel _panelPrincipal;
        private ServiciosAcademicos.reclamo _reclamo;
        public frmReclamoPorAtender(Form formPadre, Panel panelPrincipal, ServiciosAcademicos.reclamo reclamo)
        {
            InitializeComponent();
            FormPadre = formPadre; 
            PanelPrincipal = panelPrincipal;
            this._reclamo = reclamo;
            lblCodAlumno.Text = reclamo.evaluacion.alumno.codigoAlumno;
            if(_reclamo.respuesta != null)
                lblAtendido.Text = "Atendido";
            else
                lblAtendido.Text = "Por Atender";
            lblFechaReclamo.Text = reclamo.fechaReclamo.ToString("dd/MM/yyyy");
        }

        public Form FormPadre { get => _formPadre; set => _formPadre = value; }
        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }

        private void llblDetalle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDetalleReclamo formDetalleReclamo = new frmDetalleReclamo(FormPadre, PanelPrincipal,_reclamo,this);
            formDetalleReclamo.FormBorderStyle = FormBorderStyle.None;
            formDetalleReclamo.TopLevel = false;
            formDetalleReclamo.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(formDetalleReclamo);
            formDetalleReclamo.Visible = true;
        }

        public void cambiarEstadoReclamo()
        {
            this.lblAtendido.Text = "Atendido";
        }
    }
}
