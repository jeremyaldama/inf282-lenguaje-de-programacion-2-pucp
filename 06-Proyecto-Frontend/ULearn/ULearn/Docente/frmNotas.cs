using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.LogisticsWs;
using ULearn.ServiciosAcademicos;

namespace ULearn.Docente
{
    public partial class frmNotas : Form
    {
        private BindingList<ServiciosAcademicos.evaluacion> _evaluaciones;
        private BindingList<ServiciosAcademicos.evaluacion> _elegidas;
        private BindingList<ServiciosAcademicos.alumno> _alumnos;
        private ServiciosAcademicos.AcademicsWSClient dao;
        private Estado _estado;
        public frmNotas(BindingList<ServiciosAcademicos.evaluacion> evaluaciones, BindingList<ServiciosAcademicos.alumno> alumnos)
        {
            this._evaluaciones = evaluaciones;
            InitializeComponent();
            cboEval.DataSource = Enum.GetNames(typeof(ServiciosAcademicos.nombreEvaluacion));

            _alumnos = alumnos;
            _estado = Estado.Inicial;
            establecerEstado();
            dao = new AcademicsWSClient();
        }

        private void establecerEstado()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnGuardar.Enabled = false;
                    break;
                case Estado.Modificar:
                    foreach (var item in this.panelCont.Controls)
                    {
                        frmRegNota f = (frmRegNota)item;
                        f.actualizarEstado(_estado);
                    }
                    btnGuardar.Enabled = true;
                    break;
            }
        }
        private void cboEval_SelectedIndexChanged(object sender, EventArgs e)
        {
            _elegidas = new BindingList<ServiciosAcademicos.evaluacion>(_evaluaciones.Where(x => x.nombreEvaluacion.ToString() == cboEval.SelectedItem.ToString()).ToList());
            foreach (var item in this.panelCont.Controls)
            {
                frmRegNota f = (frmRegNota)item;
                foreach (ServiciosAcademicos.evaluacion ev in _elegidas)
                {
                    if (ev.alumno.codigoAlumno == f.Alumno.codigoAlumno)
                    {
                        f.Evaluacion = ev;
                        f.cambioEvaluacion();
                        break;
                    }
                }
            }
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            
            foreach (ServiciosAcademicos.alumno a in _alumnos)
            {
                foreach (ServiciosAcademicos.evaluacion ev in _elegidas)
                {
                    if (ev.alumno.codigoAlumno == a.codigoAlumno)
                    {
                        frmRegNota formDatAlumno = new frmRegNota(a, ev);
                        formDatAlumno.Dock = DockStyle.Top;
                        formDatAlumno.TopLevel = false;
                        this.panelCont.Controls.Add(formDatAlumno);
                        formDatAlumno.Visible = true;
                        break;
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Guardar;
            int res = 0;
            foreach(var item in this.panelCont.Controls)
            {
                frmRegNota f = (frmRegNota)item;
                if(f.esValido() == 1)
                {
                    f.Evaluacion.nota = f.Nota;
                    f.Evaluacion.asistio = (ushort)(f.Falto ?'F':'A');
                    res = dao.modificarEvaluacion(f.Evaluacion);
                    f.actualizarEstado(_estado, res); //se bloquea porque inserta normal
                }  
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstado();
        }
    }
}
