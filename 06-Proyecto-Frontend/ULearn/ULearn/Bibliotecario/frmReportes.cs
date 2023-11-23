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
    public partial class frmReportes : Form
    {
        private encargadoBiblioteca encargado;
        public frmReportes(encargadoBiblioteca e)
        {
            InitializeComponent();
            encargado = e;
        }

        private void btnReporteLibros_Click(object sender, EventArgs e)
        {
            frmReportePrestamosActivos frmActivos = new frmReportePrestamosActivos(encargado);
            mostrarFormulario(frmActivos);
        }

        private void btnReportePrestamos_Click(object sender, EventArgs e)
        {
            frmReportePrestamosFinalizados frmFinalizados = new frmReportePrestamosFinalizados(encargado);
            mostrarFormulario(frmFinalizados);
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
    }
}
