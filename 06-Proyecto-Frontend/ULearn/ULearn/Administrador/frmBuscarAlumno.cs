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
    public partial class frmBuscarAlumno : Form
    {
        private alumno _alumnoSeleccionado;
        private AcademicsWSClient _daoAlumno;

        public alumno AlumnoSeleccionado { get => _alumnoSeleccionado; set => _alumnoSeleccionado = value; }

        public frmBuscarAlumno()
        {
            _daoAlumno = new AcademicsWSClient();
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
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
            frmNuevoAlumno formNuevoAlumno = new frmNuevoAlumno();
            formNuevoAlumno.FormBorderStyle = FormBorderStyle.None;
            formNuevoAlumno.TopLevel = false;
            panelContenido.Controls.Add(formNuevoAlumno);
            formNuevoAlumno.Visible = true;
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmNuevoAlumno formNuevoAlumno = new frmNuevoAlumno();
            mostrarFormulario(formNuevoAlumno);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AlumnoSeleccionado = (alumno)dgvAlumnos.CurrentRow.DataBoundItem;
            AlumnoSeleccionado.codAlumno = AlumnoSeleccionado.idUsuario; //se usa codalumno para el servicio o MUERE    
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = _daoAlumno.listarAlumnosXCodigoNombre(txtBusqueda.Text).ToList();
        }

        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            alumno alumno = (alumno)dgvAlumnos.Rows[e.RowIndex].DataBoundItem;
            if (alumno != null)
            {
                dgvAlumnos.Rows[e.RowIndex].Cells[0].Value = alumno.idUsuario;
                dgvAlumnos.Rows[e.RowIndex].Cells[1].Value = alumno.nombre;
                dgvAlumnos.Rows[e.RowIndex].Cells[2].Value = alumno.apellidoPaterno;
                dgvAlumnos.Rows[e.RowIndex].Cells[3].Value = alumno.apellidoMaterno;
                dgvAlumnos.Rows[e.RowIndex].Cells[4].Value = (char) alumno.sexo;
                dgvAlumnos.Rows[e.RowIndex].Cells[5].Value = alumno.fechaNacimiento;
                dgvAlumnos.Rows[e.RowIndex].Cells[6].Value = alumno.usuario1;
                dgvAlumnos.Rows[e.RowIndex].Cells[7].Value = alumno.password;
                dgvAlumnos.Rows[e.RowIndex].Cells[8].Value = alumno.correoElectronico;
                dgvAlumnos.Rows[e.RowIndex].Cells[9].Value = alumno.codigoAlumno;
                dgvAlumnos.Rows[e.RowIndex].Cells[10].Value = alumno.esDeudor;
                dgvAlumnos.Rows[e.RowIndex].Cells[11].Value = alumno.carrera.idCarrera;
            }
        }
    }
}
