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
    public partial class frmDatosCurso : Form
    {
        private Panel _panelPrincipal;
        private Form _frmPadre;
        private curso _curso;
        public frmDatosCurso(Panel panelPrincipal, Form frmPadre, curso curso)
        {
            InitializeComponent();
            PanelPrincipal = panelPrincipal;
            FrmPadre = frmPadre;
            this._curso = curso;
        }

        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }
        public Form FrmPadre { get => _frmPadre; set => _frmPadre = value; }

        private void llblDetalle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDetalleCurso formDetalleCurso = new frmDetalleCurso(PanelPrincipal, FrmPadre, _curso); //iria el curso
            formDetalleCurso.TopLevel = false;
            formDetalleCurso.FormBorderStyle = FormBorderStyle.None;
            formDetalleCurso.Dock = DockStyle.Fill;
            PanelPrincipal.Controls.Clear();
            PanelPrincipal.Controls.Add(formDetalleCurso);
            formDetalleCurso.Visible = true;
        }

        private void frmDatosCurso_Load(object sender, EventArgs e)
        {
            lblCodigoCurso.Text = _curso.codCurso;
            lblNombreCurso.Text = _curso.nombre;
            if(_curso.horarios.Length != 0)
            {
                lblHorario.Text = _curso.horarios[0].codigo;
                lblTipoHorarios.Text = ((char) _curso.horarios[0].tipoHorario).ToString();
            }
            lblCreds.Text = _curso.creditos.ToString();
            
        }
    }
}
