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
    public partial class frmBuscarAula : Form
    {
        private LogisticsWSClient _daoAula;
        private aula _aulaSeleccionada;

        public aula AulaSeleccionada { get => _aulaSeleccionada; set => _aulaSeleccionada = value; }

        public frmBuscarAula()
        {
            _daoAula = new LogisticsWSClient();
            InitializeComponent();
            dgvAulas.AutoGenerateColumns = false;
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
            frmNuevaAula formNuevaAula = new frmNuevaAula();
            mostrarFormulario(formNuevaAula);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AulaSeleccionada = (aula)dgvAulas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAulas.DataSource = _daoAula.listarTodasAulas().ToList();
        }

        private void dgvAulas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            aula aula = (aula)dgvAulas.Rows[e.RowIndex].DataBoundItem;
            if (aula != null)
            {
                dgvAulas.Rows[e.RowIndex].Cells[0].Value = aula.idEspacio;
                dgvAulas.Rows[e.RowIndex].Cells[1].Value = aula.nombre;
                dgvAulas.Rows[e.RowIndex].Cells[2].Value = aula.aforo;
                if (aula.tienePizarraInteligente == true) dgvAulas.Rows[e.RowIndex].Cells[3].Value = "Si";
                else dgvAulas.Rows[e.RowIndex].Cells[3].Value = "No";
                if (aula.tieneProyector == true) dgvAulas.Rows[e.RowIndex].Cells[4].Value = "Si";
                else dgvAulas.Rows[e.RowIndex].Cells[4].Value = "No";
            }
        }
    }
}
