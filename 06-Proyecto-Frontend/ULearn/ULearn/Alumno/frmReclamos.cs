using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.Docente;
using ULearn.ServiciosAcademicos;

namespace ULearn.Alumno
{
    
    public partial class frmReclamos : Form
    {
        private semestre sem;
        private BindingList<reclamo> reclamos;
        private reclamo _reclamo = new reclamo();
        private ServiciosAcademicos.AcademicsWSClient ws;
        private alumno _alum;
        public frmReclamos(alumno alum)
        {
            ws = new AcademicsWSClient();
            InitializeComponent();
            sem = new semestre();
            _alum = alum;
        }

        public void mostrarFormReclamo(Form form)
        {
            panelReclamo.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelReclamo.Controls.Add(form);
            form.Visible = true;
        }

        public void mostrarFormEvaluacion(Form form)
        {
            
        }

        public void mostrarFormCurso(Form form)
        {
          
        }

        private void bttnBuscarReclamos_Click(object sender, EventArgs e)
        {
            
           


        }

        private void frmReclamos_Load(object sender, EventArgs e)
        {
            
        }

        private void bttnRegistrarReclamo_Click(object sender, EventArgs e)
        {
            panelLabels.Visible = false;
            panelReclamo.Controls.Clear();
            frmRegistrarReclamo formRegistrarReclamo = new frmRegistrarReclamo(this,panelReclamo,_alum);
            mostrarFormReclamo(formRegistrarReclamo);
        }

        private void bttnBuscarReclamos_Click_1(object sender, EventArgs e)
        {
            try
            {
                panelReclamo.Controls.Clear();
                panelLabels.Visible = true;
                reclamos = new BindingList<reclamo>(ws.listarReclamoPorAlumnoSemestre(_alum));
                foreach (reclamo reclam in reclamos)
                {
                    frmReclamoDetalleAlumno formReclamoPorAtender = new frmReclamoDetalleAlumno(this, panelReclamo, reclam);
                    formReclamoPorAtender.Dock = DockStyle.Top;
                    formReclamoPorAtender.TopLevel = false;
                    panelReclamo.Controls.Add(formReclamoPorAtender);
                    formReclamoPorAtender.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay reclamos en el semestre", "Sin reclamos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
