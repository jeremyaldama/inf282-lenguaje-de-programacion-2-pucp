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
using curso = ULearn.ServiciosAcademicos.curso;

namespace ULearn.Administrador
{
    public partial class frmBuscarCursos : Form
    {
        private AcademicsWSClient _daoCurso;
        private curso _cursoSeleccionado;

        public curso CursoSeleccionado { get => _cursoSeleccionado; set => _cursoSeleccionado = value; }

        public frmBuscarCursos()
        {
            _daoCurso = new AcademicsWSClient();
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
        }

        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            frmNuevoCurso formNuevoCurso = new frmNuevoCurso();
            formNuevoCurso.FormBorderStyle = FormBorderStyle.None;
            formNuevoCurso.TopLevel = false;
            panelContenido.Controls.Add(formNuevoCurso);
            formNuevoCurso.Visible = true;
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

        private void frmGestionarCursos_Load(object sender, EventArgs e)
        {

        }

        private void lblBusqueda_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmNuevoCurso formNuevoCurso = new frmNuevoCurso();
            mostrarFormulario(formNuevoCurso);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvCursos.CurrentRow != null) CursoSeleccionado = (curso) dgvCursos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = _daoCurso.listarTodosCursos().ToList();
        }

        private void dgvCursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            curso curso = (curso)dgvCursos.Rows[e.RowIndex].DataBoundItem;
            if (curso != null)
            {
                dgvCursos.Rows[e.RowIndex].Cells[0].Value = curso.idCurso;
                dgvCursos.Rows[e.RowIndex].Cells[1].Value = curso.nombre;
                dgvCursos.Rows[e.RowIndex].Cells[2].Value = curso.codCurso;
                dgvCursos.Rows[e.RowIndex].Cells[3].Value = curso.creditos;
                if (curso.esElectivo == 1) dgvCursos.Rows[e.RowIndex].Cells[4].Value = "Si";
                else dgvCursos.Rows[e.RowIndex].Cells[4].Value = "No";
            }
        }
    }
}
