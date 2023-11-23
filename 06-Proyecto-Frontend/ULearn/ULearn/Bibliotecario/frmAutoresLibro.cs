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
    public partial class frmAutoresLibro : Form
    {
        private Boolean cambios = false;
        private autor _autorSeleccionado;
        private BindingList<autor> _autoresLibro;

        public BindingList<autor> AutoresLibro { get => _autoresLibro; set => _autoresLibro = value; }

        public frmAutoresLibro(BindingList<autor> listaAutores)
        {
            InitializeComponent();
            bntAgregar.Enabled = false;
            bntQuitar.Enabled = false;
            txtID.Enabled = false;
            txtNacionalidad.Enabled = false;
            txtNombre.Enabled = false;
            _autoresLibro = new BindingList<autor>(listaAutores.ToList());
            dgvAutor.AutoGenerateColumns = false;
            dgvAutor.DataSource = AutoresLibro;
        }

        public frmAutoresLibro(BindingList<autor> listaAutores, bool inactivo)
        {
            InitializeComponent();
            bntAgregar.Enabled = false;
            bntQuitar.Enabled = false;
            txtID.Enabled = false;
            txtNacionalidad.Enabled = false;
            txtNombre.Enabled = false;
            AutoresLibro = new BindingList<autor>();
            AutoresLibro = listaAutores;
            dgvAutor.AutoGenerateColumns = false;
            dgvAutor.DataSource = AutoresLibro;
            bntBuscar.Enabled = false;
            bntGuardar.Enabled = false;
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaDeAutor frmBusqAutor = new frmBusquedaDeAutor();
            if (frmBusqAutor.ShowDialog() == DialogResult.OK)
            {
                _autorSeleccionado = frmBusqAutor.AutorSeleccionado;
                txtID.Text = _autorSeleccionado.idAutor.ToString();
                txtNombre.Text = _autorSeleccionado.nombre;
                txtNacionalidad.Text = _autorSeleccionado.nacionalidad;
                bntAgregar.Enabled = true;
                bntQuitar.Enabled = false;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (cambios == true)
            {
                if (MessageBox.Show("¿Está seguro de que desea regresar sin guardar los cambios realizados?",
                    "Mensaje de confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
                this.DialogResult = DialogResult.Cancel;

        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bntQuitar_Click(object sender, EventArgs e)
        {
            cambios = true;
            _autoresLibro.Remove(_autorSeleccionado);
            txtID.Text = "";
            txtNacionalidad.Text = "";
            txtNombre.Text = "";
            _autorSeleccionado = null;
            bntQuitar.Enabled = false;
        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            cambios = true;
            if(txtID.Text == "")
            {
                MessageBox.Show("Debe seleccionar un autor", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach(autor a in this._autoresLibro)
            {
                if (a.idAutor.Equals(_autorSeleccionado.idAutor))
                {
                    MessageBox.Show("Este autor ya ha sido registrado como autor de este recurso", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            autor _autor = new autor();
            _autor = _autorSeleccionado;
            _autoresLibro.Add(_autor);
            _autorSeleccionado = null;
            txtID.Text = "";
            txtNacionalidad.Text = "";
            txtNombre.Text = "";
            bntAgregar.Enabled = false;
        }

        private void dgvAutor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                autor _autor = (autor)dgvAutor.Rows[e.RowIndex].DataBoundItem;
                dgvAutor.Rows[e.RowIndex].Cells[0].Value = _autor.idAutor.ToString();
                dgvAutor.Rows[e.RowIndex].Cells[1].Value = _autor.nombre;
                dgvAutor.Rows[e.RowIndex].Cells[2].Value = _autor.nacionalidad;
            }
            catch(Exception ex)
            {

            }
        }

        private void dgvAutor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgvAutor.SelectedRows[0].Cells[0].Value.ToString();
                txtNacionalidad.Text = dgvAutor.SelectedRows[0].Cells[2].Value.ToString();
                txtNombre.Text = dgvAutor.SelectedRows[0].Cells[1].Value.ToString();
                bntAgregar.Enabled = false;
                bntQuitar.Enabled = true;
                _autorSeleccionado = (autor)dgvAutor.CurrentRow.DataBoundItem;
            }
            catch(Exception ex)
            {
                return;
            }
        }
    }
}
