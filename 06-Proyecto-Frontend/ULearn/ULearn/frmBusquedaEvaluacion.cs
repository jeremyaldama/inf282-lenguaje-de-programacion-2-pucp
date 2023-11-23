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

namespace ULearn
{
    public partial class frmBusquedaEvaluacion : Form
    {
        evaluacion ev;
        alumno _alum;
        ServiciosAcademicos.AcademicsWSClient daoAcademic;
        public frmBusquedaEvaluacion(alumno alum)
        {
            InitializeComponent();
            _alum = alum;
            daoAcademic = new ServiciosAcademicos.AcademicsWSClient();
        }

        public evaluacion Ev { get => ev; set => ev = value; }

        private void frmBusquedaEvaluacion_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = daoAcademic.listarEvaluacionxAlumno(_alum);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            evaluacion evalu = (evaluacion)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = evalu.curso.nombre;
            dataGridView1.Rows[e.RowIndex].Cells[1].Value = evalu.nombreEvaluacion;
            dataGridView1.Rows[e.RowIndex].Cells[2].Value = evalu.nota;
        }

        private void bttnSeleccionar_Click(object sender, EventArgs e)
        {
            Ev = (evaluacion)dataGridView1.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
