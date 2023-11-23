using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULearn.Administrador
{
    public partial class frmNuevoEspacio : Form
    {
        public frmNuevoEspacio()
        {
            InitializeComponent();
        }

        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            frmNuevaSala formNuevaSala = new frmNuevaSala();
            mostrarFormulario(formNuevaSala);
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            frmNuevaAula formNuevaAula = new frmNuevaAula();
            mostrarFormulario(formNuevaAula);
        }

        private void tsbBuscarSala_Click(object sender, EventArgs e)
        {
            frmBuscarSala formBuscarSala = new frmBuscarSala();
            mostrarFormulario(formBuscarSala);
        }

        private void tsbBuscarAula_Click(object sender, EventArgs e)
        {
            frmBuscarAula formBuscarAula = new frmBuscarAula();
            mostrarFormulario(formBuscarAula);
        }
    }
}
