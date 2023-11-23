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
    public partial class frmBuscarCharla : Form
    {
        private LogisticsWSClient _daoCharla;
        private charla _charlaSeleccionada;

        public charla CharlaSeleccionada { get => _charlaSeleccionada; set => _charlaSeleccionada = value; }

        public frmBuscarCharla()
        {
            _daoCharla = new LogisticsWSClient();
            InitializeComponent();
            dgvCharlas.AutoGenerateColumns = false;
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
            frmNuevaCharla formNuevaCharla = new frmNuevaCharla();
            mostrarFormulario(formNuevaCharla);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CharlaSeleccionada = (charla)dgvCharlas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCharlas.DataSource = _daoCharla.listarTodasCharlas().ToList();
        }

        private void dgvCharlas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            charla charla = (charla)dgvCharlas.Rows[e.RowIndex].DataBoundItem;
            if (charla != null)
            {
                dgvCharlas.Rows[e.RowIndex].Cells[0].Value = charla.idEvento;
                dgvCharlas.Rows[e.RowIndex].Cells[1].Value = charla.nombre;
                dgvCharlas.Rows[e.RowIndex].Cells[2].Value = charla.espacio.nombre;
                dgvCharlas.Rows[e.RowIndex].Cells[3].Value = charla.organizador;
                dgvCharlas.Rows[e.RowIndex].Cells[4].Value = charla.fecha;
                dgvCharlas.Rows[e.RowIndex].Cells[5].Value = charla.horaInicio;
                dgvCharlas.Rows[e.RowIndex].Cells[6].Value = charla.horaFin;
                if(charla.esGratis == true) dgvCharlas.Rows[e.RowIndex].Cells[7].Value = "Si";
                else dgvCharlas.Rows[e.RowIndex].Cells[7].Value = "No";
                dgvCharlas.Rows[e.RowIndex].Cells[8].Value = charla.inscritos;
                dgvCharlas.Rows[e.RowIndex].Cells[9].Value = charla.ponente;
            }
        }
    }
}
