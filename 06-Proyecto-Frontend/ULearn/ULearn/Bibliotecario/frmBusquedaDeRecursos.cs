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

namespace ULearn.Bibliotecario
{
    public partial class frmBusquedaRecursos : Form
    {
        private recursoBiblioteca _recursoSeleccionado;
        private LibraryWSClient _daoLibraryWS;

        public recursoBiblioteca RecursoSeleccionado { get => _recursoSeleccionado; set => _recursoSeleccionado = value; }

        public frmBusquedaRecursos()
        {
            InitializeComponent();
            dgvRecursos.AutoGenerateColumns = false;
            biblioteca todas = new biblioteca();
            _daoLibraryWS = new LibraryWSClient();
            todas.idBiblioteca = -1;
            todas.nombre = "Todas las bibliotecas";
            BindingList<biblioteca> listaBibliotecas = new BindingList<biblioteca>(_daoLibraryWS.listarBibliotecasTodas().ToList());
            listaBibliotecas.Insert(0, todas);
            cboBiblioteca.DataSource = listaBibliotecas;
            cboBiblioteca.DisplayMember = "nombre";
            cboBiblioteca.ValueMember = "idBiblioteca";
            cboBiblioteca.SelectedIndex = 0;
        }

        private void dgvRecursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSeleccionar.Enabled = true;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvRecursos.SelectedRows.Count == 1)
            {
                if (((recursoBiblioteca)dgvRecursos.CurrentRow.DataBoundItem).tipoRecurso == 'L') _recursoSeleccionado = new libro();
                else _recursoSeleccionado = new digital();
                _recursoSeleccionado = (recursoBiblioteca)dgvRecursos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún recurso", "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            char tipo;
            int disponible;
            int biblioteca;
            if (cboDigital.Checked && cboLibro.Checked) tipo = 'Z';
            else if (cboDigital.Checked) tipo = 'D';
            else if (cboLibro.Checked) tipo = 'L';
            else
            {
                MessageBox.Show("Seleccione al menos un tipo de recurso para realizar la busqueda", "Falta de información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboDisponible.Checked && cboNoDisponible.Checked) disponible = 2;
            else if (cboDisponible.Checked) disponible = 1;
            else if (cboNoDisponible.Checked) disponible = 0;
            else
            {
                MessageBox.Show("Seleccione la disponibilidad del recurso indicado", "Falta de información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboBiblioteca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione las biblioteca sobre las que se realizará la búsqueda", "Falta de información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else biblioteca = (int)cboBiblioteca.SelectedValue;
            try
            {
                BindingList<recursoBiblioteca> recursos = new BindingList<recursoBiblioteca>(_daoLibraryWS.listarRecursosPorTituloAutorConFiltros(txtTituloAutor.Text, disponible,biblioteca, tipo));
                foreach (recursoBiblioteca r in recursos)
                {
                    r.autores = _daoLibraryWS.listarAutoresPorIdRecurso(r.idRecurso);
                }
                dgvRecursos.DataSource = recursos;
            }catch(Exception ex){
                dgvRecursos.DataSource = null;
                MessageBox.Show("No se encontraron resultados en la búsqueda", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dgvRecursos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            recursoBiblioteca recurso = (recursoBiblioteca)dgvRecursos.Rows[e.RowIndex].DataBoundItem;
            dgvRecursos.Rows[e.RowIndex].Cells[0].Value = recurso.idRecurso.ToString();
            dgvRecursos.Rows[e.RowIndex].Cells[1].Value = recurso.titulo;
            dgvRecursos.Rows[e.RowIndex].Cells[2].Value = concatenarAutores(recurso);
            if (recurso.tipoRecurso == 'L') dgvRecursos.Rows[e.RowIndex].Cells[3].Value = "Libro";
            else dgvRecursos.Rows[e.RowIndex].Cells[3].Value = "Digital";
            dgvRecursos.Rows[e.RowIndex].Cells[4].Value = recurso.biblioteca.nombre;
            if (recurso.disponible == true) dgvRecursos.Rows[e.RowIndex].Cells[5].Value = "Si";
            else dgvRecursos.Rows[e.RowIndex].Cells[5].Value = "No";

        }

        public string concatenarAutores(recursoBiblioteca r)
        {
            string cadena = "";
            int i = 0;
            foreach (autor a in r.autores)
            {
                cadena += a.nombre;
                if (r.autores.Length - 1 != i) cadena += ", ";
                i++;
            }
            return cadena;
        }
    }
}
