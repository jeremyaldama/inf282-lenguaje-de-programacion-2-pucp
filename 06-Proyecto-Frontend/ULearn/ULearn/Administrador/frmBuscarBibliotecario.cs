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

namespace ULearn.Administrador
{
    public partial class frmBuscarBibliotecarios : Form
    {
        private encargadoBiblioteca _bibliotecarioSeleccionado;
        private StaffWSClient _daoBibliotecario;

        public encargadoBiblioteca BibliotecarioSeleccionado { get => _bibliotecarioSeleccionado; set => _bibliotecarioSeleccionado = value; }

        public frmBuscarBibliotecarios()
        {
            _daoBibliotecario = new StaffWSClient();
            InitializeComponent();
            dgvBibliotecarios.AutoGenerateColumns = false;
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
            frmNuevoBibliotecario formNuevoBibliotecario = new frmNuevoBibliotecario();
            mostrarFormulario(formNuevoBibliotecario);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            BibliotecarioSeleccionado = (encargadoBiblioteca)dgvBibliotecarios.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBibliotecarios.DataSource = _daoBibliotecario.listarEncargadosXUsuarioNombre(txtBusqueda.Text).ToList();
        }

        private void dgvBibliotecarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            encargadoBiblioteca bibliotecario = (encargadoBiblioteca)dgvBibliotecarios.Rows[e.RowIndex].DataBoundItem;
            if (bibliotecario != null)
            {
                dgvBibliotecarios.Rows[e.RowIndex].Cells[0].Value = bibliotecario.idEmpleado;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[1].Value = bibliotecario.nombre;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[2].Value = bibliotecario.apellidoPaterno;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[3].Value = bibliotecario.apellidoMaterno;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[4].Value = (char) bibliotecario.sexo;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[5].Value = bibliotecario.fechaNacimiento;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[6].Value = bibliotecario.usuario1;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[7].Value = bibliotecario.password;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[8].Value = bibliotecario.correoElectronico;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[9].Value = bibliotecario.horaEntrada;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[10].Value = bibliotecario.horaSalida;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[11].Value = bibliotecario.fechaContratacion;
                dgvBibliotecarios.Rows[e.RowIndex].Cells[12].Value = bibliotecario.titulo_trabajo;
            }
        }
    }
}
