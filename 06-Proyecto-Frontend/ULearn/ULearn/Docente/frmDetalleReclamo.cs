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
    public partial class frmDetalleReclamo : Form
    {
        Form _formPadre;
        Panel _panelPrincipal;
        private ServiciosAcademicos.reclamo _reclamo;
        private ServiciosAcademicos.AcademicsWSClient _dao;
        private frmReclamoPorAtender _esteReclamo;
        public frmDetalleReclamo(Form formPadre, Panel panelPrincipal, ServiciosAcademicos.reclamo reclamo, frmReclamoPorAtender esteReclamo)
        {
            InitializeComponent();
            this.FormPadre = formPadre;
            this.PanelPrincipal = panelPrincipal;
            this._reclamo = reclamo;
            _dao = new ServiciosAcademicos.AcademicsWSClient();
            _esteReclamo = esteReclamo;
        }

        public Form FormPadre { get => _formPadre; set => _formPadre = value; }
        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(FormPadre);
        }

        private void frmDetalleReclamo_Load(object sender, EventArgs e)
        {
            lblValCodAlumno.Text = _reclamo.evaluacion.alumno.codigoAlumno;
            lblValNomAlumno.Text = _reclamo.evaluacion.alumno.nombre + " " + _reclamo.evaluacion.alumno.apellidoPaterno + " " + _reclamo.evaluacion.alumno.apellidoMaterno;
            lblValNomEvaluacion.Text = _reclamo.evaluacion.nombreEvaluacion.ToString();
            txtDescp.Text = _reclamo.descripcion;
            txtDescp.ReadOnly = true;
            txtRespuesta.Text = _reclamo.respuesta;
            rbProcede.Checked = _reclamo.valido;
            rbNoProcede.Checked = !_reclamo.valido;
            dgvEdicionNota.AutoGenerateColumns = false;
            dgvEdicionNota.Rows.Add();
            dgvEdicionNota.Rows[0].Cells[0].Value = _reclamo.evaluacion.alumno.codigoAlumno;
            dgvEdicionNota.Rows[0].Cells[1].Value = _reclamo.evaluacion.nombreEvaluacion;
            dgvEdicionNota.Rows[0].Cells[2].Value = _reclamo.evaluacion.nota;
            if(_reclamo.respuesta != "")
            {
                btnGuardar.Enabled = false;
                dgvEdicionNota.Enabled = false;
                txtRespuesta.ReadOnly = true;
                rbNoProcede.Enabled = false;
                rbProcede.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nNota = dgvEdicionNota.Rows[0].Cells[2].Value.ToString();
            try
            {
                double tnota = Double.Parse(nNota);
                if(tnota >= 0 && tnota <= 20) {
                    _reclamo.evaluacion.nota = tnota;
                    _reclamo.valido = rbProcede.Checked;
                    _reclamo.descripcion = txtDescp.Text;
                    _reclamo.respuesta = txtRespuesta.Text;
                    int res = _dao.modificarReclamo(_reclamo);
                    if (res > 0)
                    {
                        MessageBox.Show("Se atendió al reclamo con éxito", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRespuesta.ReadOnly = true;
                        txtDescp.ReadOnly = true;
                        btnGuardar.Enabled = false;
                        rbNoProcede.Enabled = false;
                        rbProcede.Enabled = false;
                        dgvEdicionNota.Enabled = false;
                        _esteReclamo.cambiarEstadoReclamo(); //lo pasa a atendido
                    }
                }
                else
                {
                    MessageBox.Show("La nota debe ser un valor numérico del 0 al 20", "Mensaje de alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvEdicionNota.Rows[0].Cells[2].Value = _reclamo.evaluacion.nota;
                }  
            }catch(FormatException ex)
            {
                MessageBox.Show("La nota debe ser un valor numérico del 0 al 20", "Mensaje de alerta",MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvEdicionNota.Rows[0].Cells[2].Value = _reclamo.evaluacion.nota;
            }
        }
    }
}
