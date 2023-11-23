using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.LibraryWS;
using ULearn.ServiciosAcademicos;
using ULearn.StaffWS;

namespace ULearn.Bibliotecario
{
    public partial class frmBusquedaUsuariosPrestamo : Form
    {
        private AcademicsWSClient _daoAcademicsWS;
        private ServiciosAcademicos.usuario _usuarioSeleccionado;
        private StaffWSClient _daoStaffWS;

        public ServiciosAcademicos.usuario UsuarioSeleccionado { get => _usuarioSeleccionado; set => _usuarioSeleccionado = value; }

        public frmBusquedaUsuariosPrestamo()
        {
            InitializeComponent();
            _daoAcademicsWS = new AcademicsWSClient();
            _daoStaffWS = new StaffWSClient();
            dgvUsuario.ClearSelection();
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AutoGenerateColumns = false;
            btnSeleccionar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count == 1)
            {
                if (((ServiciosAcademicos.usuario)dgvUsuario.CurrentRow.DataBoundItem).tipoUsuario == 'E') _usuarioSeleccionado = new alumno();
                else _usuarioSeleccionado = new docente();
                _usuarioSeleccionado = (ServiciosAcademicos.usuario)dgvUsuario.CurrentRow.DataBoundItem;
                try
                {
                    _usuarioSeleccionado.foto = _daoStaffWS.buscarFotoPerfil(_usuarioSeleccionado.idUsuario);
                }catch(Exception ex) {}
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún usuario", "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbAlumnos.Checked == false && cbDocentes.Checked == false)
            {
                MessageBox.Show("No se selecciono nigun tipo de usuario para la búsqueda", "Falta de parámetros de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BindingList<ServiciosAcademicos.usuario> usuarios = new BindingList<ServiciosAcademicos.usuario>();
            BindingList<alumno> alumnos = null;
            BindingList<docente> docentes = null;
            if (cbAlumnos.Checked == true)
            {
                try
                {
                    alumnos = new BindingList<alumno>(_daoAcademicsWS.listarAlumnosXCodigoNombre(txtNombre.Text));
                    foreach (alumno al in alumnos)
                    {
                        usuarios.Add(al);
                    }
                }
                catch (Exception ex) { alumnos = null; }
               
            }
            if (cbDocentes.Checked == true)
            {
                try
                {
                    docentes = new BindingList<docente>(_daoAcademicsWS.listarDocentesPorNombre(txtNombre.Text));
                    foreach (docente doc in docentes)
                    {
                        usuarios.Add(doc);
                    }
                }
                catch (Exception ex) { docentes = null; }
            }
            dgvUsuario.DataSource = usuarios;
            if(usuarios.Count == 0)
            {
                MessageBox.Show("No hay resultados para esta búsqueda", "Resultados de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSeleccionar.Enabled = false;
                dgvUsuario.DataSource = null;
            }
            else btnSeleccionar.Enabled = true;  
        }

        private void dgvUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ServiciosAcademicos.usuario u = (ServiciosAcademicos.usuario)dgvUsuario.Rows[e.RowIndex].DataBoundItem;
            dgvUsuario.Rows[e.RowIndex].Cells[0].Value = u.idUsuario;
            dgvUsuario.Rows[e.RowIndex].Cells[1].Value = u.nombre;
            dgvUsuario.Rows[e.RowIndex].Cells[2].Value = u.apellidoPaterno + " " + u.apellidoMaterno;
            if(u is alumno) dgvUsuario.Rows[e.RowIndex].Cells[3].Value = "Alumno";
            else if(u is docente) dgvUsuario.Rows[e.RowIndex].Cells[3].Value = "Docente";
            else dgvUsuario.Rows[e.RowIndex].Cells[3].Value = "?";
        }
    }
}
