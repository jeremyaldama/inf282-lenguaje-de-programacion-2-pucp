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
    public partial class frmBuscarTaller : Form
    {
        private LogisticsWSClient _daoTaller;
        private taller _tallerSeleccionado;

        public taller TallerSeleccionado { get => _tallerSeleccionado; set => _tallerSeleccionado = value; }

        public frmBuscarTaller()
        {
            _daoTaller = new LogisticsWSClient();   
            InitializeComponent();
            dgvTaller.AutoGenerateColumns = false; 
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
            frmNuevoTaller formNuevoTaller = new frmNuevoTaller();
            mostrarFormulario(formNuevoTaller);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TallerSeleccionado = (taller)dgvTaller.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvTaller.DataSource = _daoTaller.listarTodosTalleres().ToList(); 
        }

        private void dgvTaller_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            taller taller = (taller)dgvTaller.Rows[e.RowIndex].DataBoundItem;
            if (taller != null)
            {
                dgvTaller.Rows[e.RowIndex].Cells[0].Value = taller.idEvento;
                dgvTaller.Rows[e.RowIndex].Cells[1].Value = taller.nombre;
                dgvTaller.Rows[e.RowIndex].Cells[2].Value = taller.espacio.nombre;
                dgvTaller.Rows[e.RowIndex].Cells[3].Value = taller.organizador;
                dgvTaller.Rows[e.RowIndex].Cells[4].Value = taller.fecha;
                dgvTaller.Rows[e.RowIndex].Cells[5].Value = taller.horaInicio;
                dgvTaller.Rows[e.RowIndex].Cells[6].Value = taller.horaFin;
                if(taller.esGratis) dgvTaller.Rows[e.RowIndex].Cells[7].Value = "Si";
                else dgvTaller.Rows[e.RowIndex].Cells[7].Value = "No";
                dgvTaller.Rows[e.RowIndex].Cells[8].Value = taller.inscritos;
                dgvTaller.Rows[e.RowIndex].Cells[9].Value = taller.areaInteres;
            }

        }
    }
}
