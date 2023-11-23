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
using carrera = ULearn.ServiciosAcademicos.carrera;

namespace ULearn.Administrador
{
    public partial class frmBuscarCarreras : Form
    {
        private AcademicsWSClient _daoCarrera;
        private carrera _carreraSeleccionada;

        public carrera CarreraSeleccionada { get => _carreraSeleccionada; set => _carreraSeleccionada = value; }

        public frmBuscarCarreras()
        {
            _daoCarrera = new AcademicsWSClient();
            InitializeComponent();
            dgvCarreras.AutoGenerateColumns = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmNuevaCarrera formNuevaCarrera = new frmNuevaCarrera();
            mostrarFormulario(formNuevaCarrera);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            panelContenido.Controls.Clear();
            frmNuevaCarrera formNuevaCarrera = new frmNuevaCarrera();
            formNuevaCarrera.FormBorderStyle = FormBorderStyle.None;
            formNuevaCarrera.TopLevel = false;
            panelContenido.Controls.Add(formNuevaCarrera);
            formNuevaCarrera.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CarreraSeleccionada = (carrera) dgvCarreras.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCarreras.DataSource = _daoCarrera.listarTodasCarreras().ToList();
        }

        private void dgvCarreras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            carrera carrera = (carrera) dgvCarreras.Rows[e.RowIndex].DataBoundItem;
            if (carrera != null)
            {
                dgvCarreras.Rows[e.RowIndex].Cells[0].Value = carrera.idCarrera;
                dgvCarreras.Rows[e.RowIndex].Cells[1].Value = carrera.facultad.idFacultad;
                dgvCarreras.Rows[e.RowIndex].Cells[2].Value = carrera.nombre;
                dgvCarreras.Rows[e.RowIndex].Cells[3].Value = carrera.creditos;
                if(carrera.esAcreditada == true) dgvCarreras.Rows[e.RowIndex].Cells[4].Value = "Si";
                else dgvCarreras.Rows[e.RowIndex].Cells[4].Value = "No";
                dgvCarreras.Rows[e.RowIndex].Cells[5].Value = carrera.cambioMalla;
            }
        }
    }
}
