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

namespace ULearn.Administrador
{
    public partial class frmBuscarSala : Form
    {
        private LogisticsWSClient _daoSala;
        private sala _salaSeleccionada;

        public sala SalaSeleccionada { get => _salaSeleccionada; set => _salaSeleccionada = value; }

        public frmBuscarSala()
        {
            _daoSala = new LogisticsWSClient();
            InitializeComponent();
            dgvSalas.AutoGenerateColumns = false;
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
            frmNuevaSala formNuevaSala = new frmNuevaSala();
            mostrarFormulario(formNuevaSala);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SalaSeleccionada = (sala)dgvSalas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvSalas.DataSource = _daoSala.listarTodasSalas().ToList();
        }

        private void dgvSalas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            sala sala = (sala)dgvSalas.Rows[e.RowIndex].DataBoundItem;
            if (sala != null)
            {
                dgvSalas.Rows[e.RowIndex].Cells[0].Value = sala.idEspacio;
                dgvSalas.Rows[e.RowIndex].Cells[1].Value = sala.nombre;
                dgvSalas.Rows[e.RowIndex].Cells[2].Value = sala.aforo;
                if(sala.tieneSistemaAudio == true) dgvSalas.Rows[e.RowIndex].Cells[3].Value = "Si";
                else dgvSalas.Rows[e.RowIndex].Cells[3].Value = "No";
                dgvSalas.Rows[e.RowIndex].Cells[4].Value = sala.tipoSala;
            }
        }
    }
}
