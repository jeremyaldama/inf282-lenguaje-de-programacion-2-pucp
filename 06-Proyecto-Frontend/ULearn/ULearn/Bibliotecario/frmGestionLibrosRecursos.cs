using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.StaffWS;

namespace ULearn.Bibliotecario
{
    public partial class frmGestionLibrosRecursos : Form
    {
        private encargadoBiblioteca _encargado;
        public frmGestionLibrosRecursos(encargadoBiblioteca encargado)
        {
            InitializeComponent();
            _encargado = encargado;
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

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            frmNuevoRecurso frmRecurso = new frmNuevoRecurso(_encargado);
            mostrarFormulario(frmRecurso);
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            frmNuevoAutor frmAutor = new frmNuevoAutor();
            mostrarFormulario(frmAutor);
        }
    }
}
