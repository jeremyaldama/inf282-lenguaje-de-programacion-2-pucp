using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.Docente;

namespace ULearn.Alumno
{
    public partial class frmBuscarCursosPersonas : Form
    {
        public frmBuscarCursosPersonas()
        {
            InitializeComponent();
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            //panelContenido.Controls.Clear();
            //BindingList<Persona> personas = 
            //procedimiento de buscar por nombre
            //forearch(Persona per in personas){
            //formDatosPersonas formBusqueda = new formDatosPersonas(per);
            //formBusq.TopLevel = false;
            //panelContenido.Controls.Add(formBusqueda);
            //formBusq.Visible = true;
            //}
        }

        private void bttnContactar_Click(object sender, EventArgs e)
        {
            //mandar correo
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

       

        private void FormCursosPersonasSearch_Load(object sender, EventArgs e)
        {

        }

        private void bttnBusquedaPersonas_Click(object sender, EventArgs e)
        {
            frmBuscarPersonas frmPersonas = new frmBuscarPersonas(panelContenido);
            mostrarFormulario(frmPersonas);
        }

        private void bttnBusquedaCursos_Click(object sender, EventArgs e)
        {
            frmBusquedaCursos frmCursos = new frmBusquedaCursos();
            mostrarFormulario(frmCursos);
        }
    }
}
