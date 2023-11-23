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

namespace ULearn.Docente
{
    public partial class frmReclamos : Form
    {
        Panel _panelPrincipal;
        private BindingList<ServiciosAcademicos.reclamo> _reclamos;
        public frmReclamos(Panel panelPrincipal, BindingList<ServiciosAcademicos.reclamo> reclamos)
        {
            InitializeComponent();
            PanelPrincipal = panelPrincipal;
            _reclamos = reclamos;
        }

        public Panel PanelPrincipal { get => _panelPrincipal; set => _panelPrincipal = value; }

        private void frmReclamos_Load(object sender, EventArgs e)
        {
            foreach(ServiciosAcademicos.reclamo r in _reclamos)
            {
                frmReclamoPorAtender formReclamoPorAtender = new frmReclamoPorAtender(this, PanelPrincipal,r);
                formReclamoPorAtender.Dock = DockStyle.Top;
                formReclamoPorAtender.TopLevel = false;
                this.tabpageAtender.Controls.Add(formReclamoPorAtender);
                formReclamoPorAtender.Visible = true;
            } 
        }
    }
}
