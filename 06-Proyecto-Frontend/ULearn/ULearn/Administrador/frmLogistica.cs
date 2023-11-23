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
    public partial class frmLogistica : Form
    {
        public frmLogistica()
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

        private void btnEncargadosBiblioteca_Click(object sender, EventArgs e)
        {
            frmNuevoBibliotecario formNuevoBibliotecario = new frmNuevoBibliotecario();
            mostrarFormulario(formNuevoBibliotecario);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            frmNuevoEvento formNuevoEvento = new frmNuevoEvento();
            mostrarFormulario(formNuevoEvento);
        }

        private void btnEspacios_Click(object sender, EventArgs e)
        {
            frmNuevoEspacio formNuevoEspacio = new frmNuevoEspacio();
            mostrarFormulario(formNuevoEspacio);
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFacultad_Click(object sender, EventArgs e)
        {
            frmNuevaFacultad formNuevaFacultad = new frmNuevaFacultad();
            mostrarFormulario(formNuevaFacultad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevoSemestre formNuevoSemestre = new frmNuevoSemestre();
            mostrarFormulario(formNuevoSemestre);
        }
    }
}
