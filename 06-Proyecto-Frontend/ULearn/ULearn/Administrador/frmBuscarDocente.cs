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

namespace ULearn.Administrador
{
    public partial class frmBuscarDocente : Form
    {
        private docente _docenteSeleccionado;
        private AcademicsWSClient _daoDocente;

        public docente DocenteSeleccionado { get => _docenteSeleccionado; set => _docenteSeleccionado = value; }

        public frmBuscarDocente()
        {
            _daoDocente = new AcademicsWSClient(); 
            InitializeComponent();
            dgvDocentes.AutoGenerateColumns = false; 
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmNuevoDocente formNuevoDocente = new frmNuevoDocente();
            mostrarFormulario(formNuevoDocente);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DocenteSeleccionado = (docente)dgvDocentes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDocentes.DataSource = _daoDocente.listarDocentesPorNombre(txtBusqueda.Text).ToList(); 
        }

        private void dgvDocentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            docente docente = (docente)dgvDocentes.Rows[e.RowIndex].DataBoundItem;
            if (docente != null)
            {
                dgvDocentes.Rows[e.RowIndex].Cells[0].Value = docente.idEmpleado;
                dgvDocentes.Rows[e.RowIndex].Cells[1].Value = docente.nombre;
                dgvDocentes.Rows[e.RowIndex].Cells[2].Value = docente.apellidoPaterno;
                dgvDocentes.Rows[e.RowIndex].Cells[3].Value = docente.apellidoMaterno;
                dgvDocentes.Rows[e.RowIndex].Cells[4].Value = (char)docente.sexo;
                dgvDocentes.Rows[e.RowIndex].Cells[5].Value = docente.fechaNacimiento;
                dgvDocentes.Rows[e.RowIndex].Cells[6].Value = docente.usuario1;
                dgvDocentes.Rows[e.RowIndex].Cells[7].Value = docente.password;
                dgvDocentes.Rows[e.RowIndex].Cells[8].Value = docente.correoElectronico;
                dgvDocentes.Rows[e.RowIndex].Cells[9].Value = docente.horaEntrada;
                dgvDocentes.Rows[e.RowIndex].Cells[10].Value = docente.horaSalida;
                dgvDocentes.Rows[e.RowIndex].Cells[11].Value = docente.fechaContratacion;
                dgvDocentes.Rows[e.RowIndex].Cells[12].Value = docente.tipoDocente;
                dgvDocentes.Rows[e.RowIndex].Cells[13].Value = docente.gradoAcademico;
                dgvDocentes.Rows[e.RowIndex].Cells[14].Value = docente.intereses;
            }
        }
    }
}
