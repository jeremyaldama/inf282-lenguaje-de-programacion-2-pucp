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
    public partial class frmNuevoEvento : Form
    {
        public frmNuevoEvento()
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

        private void btnCharla_Click(object sender, EventArgs e)
        {
            frmNuevaCharla formNuevaCharla = new frmNuevaCharla();
            mostrarFormulario(formNuevaCharla);
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            frmNuevoTaller formNuevoTaller = new frmNuevoTaller();
            mostrarFormulario(formNuevoTaller);
        }

        private void tsbBuscarCharla_Click(object sender, EventArgs e)
        {
            frmBuscarCharla formBuscarCharla = new frmBuscarCharla();
            mostrarFormulario(formBuscarCharla);
        }

        private void tsbBuscarTaller_Click(object sender, EventArgs e)
        {
            frmBuscarTaller formBuscarTaller = new frmBuscarTaller();
            mostrarFormulario(formBuscarTaller);
        }
    }
}
