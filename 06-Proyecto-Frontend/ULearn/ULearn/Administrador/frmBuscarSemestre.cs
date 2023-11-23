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
using ULearn.ServiciosAcademicos;
using semestre = ULearn.ServiciosAcademicos.semestre;

namespace ULearn.Administrador
{
    public partial class frmBuscarSemestre : Form
    {
        private AcademicsWSClient _daoSemestre;
        private semestre _semestreSeleccionado;
        public frmBuscarSemestre()
        {
            _daoSemestre = new AcademicsWSClient();
            InitializeComponent();
            dgvSemestres.AutoGenerateColumns = false;
        }

        public semestre SemestreSeleccionado { get => _semestreSeleccionado; set => _semestreSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvSemestres.DataSource = _daoSemestre.listarTodosSemestres().ToList();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SemestreSeleccionado = (semestre)dgvSemestres.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvSemestres_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            semestre semestre = (semestre)dgvSemestres.Rows[e.RowIndex].DataBoundItem;
            if (semestre != null)
            {
                dgvSemestres.Rows[e.RowIndex].Cells[0].Value = semestre.idSemestre;
                dgvSemestres.Rows[e.RowIndex].Cells[1].Value = semestre.semestre1;
                dgvSemestres.Rows[e.RowIndex].Cells[2].Value = semestre.fechaInicio;
                dgvSemestres.Rows[e.RowIndex].Cells[3].Value = semestre.fechaFin; 
                if (semestre.esRegular == true) dgvSemestres.Rows[e.RowIndex].Cells[4].Value = "Si";
                else dgvSemestres.Rows[e.RowIndex].Cells[4].Value = "No";
            }
        }
    }
}
