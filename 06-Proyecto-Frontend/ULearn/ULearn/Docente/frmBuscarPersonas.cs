using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.Alumno;

namespace ULearn.Docente
{
    public partial class frmBuscarPersonas : Form
    {
        Panel _panelPrincipal;
        ServiciosAcademicos.AcademicsWSClient _dao;
        public frmBuscarPersonas(Panel panelPrincipal)
        {
            InitializeComponent();
            this.PanelPrincipal = panelPrincipal;
            cbAlumno.Checked = true; //por default
            _dao = new ServiciosAcademicos.AcademicsWSClient();
            txtBusqueda.Text = string.Empty;
        }

        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            BindingList<ServiciosAcademicos.alumno> resAlums = new BindingList<ServiciosAcademicos.alumno>();
            BindingList<ServiciosAcademicos.docente> resDocs = new BindingList<ServiciosAcademicos.docente>();
            if(cbDocente.Checked)
            {
                resDocs = new BindingList<ServiciosAcademicos.docente>(_dao.listarDocentesPorNombre(txtBusqueda.Text));
                if(resDocs != null)
                {
                    foreach(ServiciosAcademicos.docente d in resDocs)
                    {
                        frmDatosPersona formDatosPersona = new frmDatosPersona(this, PanelPrincipal, d);
                        formDatosPersona.TopLevel = false;
                        formDatosPersona.Dock = DockStyle.Top;
                        this.panelContenido.Controls.Add(formDatosPersona);
                        formDatosPersona.Visible = true;
                    }
                }
            }
            if (cbAlumno.Checked)
            {
                resAlums = new BindingList<ServiciosAcademicos.alumno>(_dao.listarAlumnosXCodigoNombre(txtBusqueda.Text));
                if(resAlums != null)
                {
                    foreach (ServiciosAcademicos.alumno a in resAlums)
                    {
                        frmDatosPersona formDatosPersona = new frmDatosPersona(this, PanelPrincipal, a);
                        formDatosPersona.TopLevel = false;
                        formDatosPersona.Dock = DockStyle.Top;
                        this.panelContenido.Controls.Add(formDatosPersona);
                        formDatosPersona.Visible = true;
                    }
                }
            }
            this.txtBusqueda.Text = string.Empty;
            if(resAlums == null && resDocs == null)
            {
                MessageBox.Show("No se hallaron resultados", "Mensaje de alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
