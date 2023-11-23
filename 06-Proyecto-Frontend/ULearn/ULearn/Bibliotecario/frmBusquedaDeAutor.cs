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
    public partial class frmBusquedaDeAutor : Form
    {
        private LibraryWSClient _daoLibraryWS;
        private autor _autorSeleccionado;
        public frmBusquedaDeAutor()
        {
            _daoLibraryWS = new LibraryWSClient();
            InitializeComponent();
            dgvAutor.AutoGenerateColumns = false;
            txtAutor.Text = "";
        }

        public autor AutorSeleccionado { get => _autorSeleccionado; set => _autorSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAutor.DataSource = _daoLibraryWS.listarAutoresPorNombre(txtAutor.Text).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se encontraron resultados en la búsqueda", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAutor.DataSource = null;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvAutor.SelectedRows.Count == 1)
            {
                _autorSeleccionado = (autor)dgvAutor.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún autor", "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dgvAutor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            autor _autor = (autor)dgvAutor.Rows[e.RowIndex].DataBoundItem;
            dgvAutor.Rows[e.RowIndex].Cells[0].Value = _autor.idAutor.ToString();
            dgvAutor.Rows[e.RowIndex].Cells[1].Value = _autor.nombre;
            dgvAutor.Rows[e.RowIndex].Cells[2].Value = _autor.nacionalidad;

        }
    }
}
