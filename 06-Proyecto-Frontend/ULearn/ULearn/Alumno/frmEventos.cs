using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULearn.Alumno
{
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        public void mostrarForm(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void bttnTalleres_Click(object sender, EventArgs e)
        {
            frmTaller frmtaller = new frmTaller();
            mostrarForm(frmtaller);
        }

        private void bttnCharla_Click(object sender, EventArgs e)
        {
            frmCharla frmCharla = new frmCharla();
            mostrarForm(frmCharla);
        }
    }
}
