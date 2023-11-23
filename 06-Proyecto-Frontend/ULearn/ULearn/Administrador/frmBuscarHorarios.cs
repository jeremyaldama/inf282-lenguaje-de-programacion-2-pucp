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
using horario = ULearn.ServiciosAcademicos.horario;

namespace ULearn.Administrador
{
    public partial class frmBuscarHorarios : Form
    {
        private AcademicsWSClient _daoHorario;
        private horario _horarioSeleccionado;

        public horario HorarioSeleccionado { get => _horarioSeleccionado; set => _horarioSeleccionado = value; }

        public frmBuscarHorarios()
        {
            _daoHorario = new AcademicsWSClient();
            InitializeComponent();
            dgvHorarios.AutoGenerateColumns = false;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmNuevoHorario formNuevoHorario = new frmNuevoHorario();
            mostrarFormulario(formNuevoHorario);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HorarioSeleccionado = (horario)dgvHorarios.CurrentRow.DataBoundItem;
            HorarioSeleccionado.alumnos = _daoHorario.listarAlumnosDeHorario(HorarioSeleccionado.idHorario);
            HorarioSeleccionado.docentes = _daoHorario.listarDocentesDeHorario(HorarioSeleccionado.idHorario);
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvHorarios.DataSource = _daoHorario.listarHorariosTodos().ToList();
        }

        private void dgvHorarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            horario horario = (horario)dgvHorarios.Rows[e.RowIndex].DataBoundItem;
            if (horario != null)
            {
                dgvHorarios.Rows[e.RowIndex].Cells[0].Value = horario.idHorario;
                dgvHorarios.Rows[e.RowIndex].Cells[1].Value = horario.codigo;
                dgvHorarios.Rows[e.RowIndex].Cells[2].Value = horario.curso.idCurso;
                dgvHorarios.Rows[e.RowIndex].Cells[3].Value = horario.dia;
                dgvHorarios.Rows[e.RowIndex].Cells[4].Value = horario.horaInicio;
                dgvHorarios.Rows[e.RowIndex].Cells[5].Value = horario.horaFin;
                dgvHorarios.Rows[e.RowIndex].Cells[6].Value = horario.vacantes;
                dgvHorarios.Rows[e.RowIndex].Cells[7].Value = horario.matriculados;
                dgvHorarios.Rows[e.RowIndex].Cells[8].Value = horario.tiempoTolerancia;
                dgvHorarios.Rows[e.RowIndex].Cells[9].Value = (char) horario.tipoHorario;
            }
        }
    }
}
