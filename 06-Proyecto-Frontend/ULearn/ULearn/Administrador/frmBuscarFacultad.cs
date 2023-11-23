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
using ULearn.ServiciosAcademicos;
using facultad = ULearn.LogisticsWs.facultad;

namespace ULearn.Administrador
{
    public partial class frmBuscarFacultad : Form
    {
        private LogisticsWSClient _daoFacultad;
        private facultad _facultadSeleccionada;
        public frmBuscarFacultad()
        {
            _daoFacultad = new LogisticsWSClient();
            InitializeComponent();
            dgvFacultades.AutoGenerateColumns = false;
        }

        public facultad FacultadSeleccionada { get => _facultadSeleccionada; set => _facultadSeleccionada = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvFacultades.DataSource = _daoFacultad.listarTodasFacultades().ToList();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FacultadSeleccionada = (facultad)dgvFacultades.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvFacultades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            facultad facultad = (facultad)dgvFacultades.Rows[e.RowIndex].DataBoundItem;
            if (facultad != null)
            {
                dgvFacultades.Rows[e.RowIndex].Cells[0].Value = facultad.idFacultad;
                dgvFacultades.Rows[e.RowIndex].Cells[1].Value = facultad.nombre;
                dgvFacultades.Rows[e.RowIndex].Cells[2].Value = facultad.anexo;
                dgvFacultades.Rows[e.RowIndex].Cells[3].Value = facultad.inscritos;
            }
        }
    }
}
