using LP2Soft.RRHHWS;
using LP2SoftRRHHController.DAO;
using LP2SoftRRHHController.MySQL;
using LP2SoftRRHHModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frmBusquedaEmpleados : Form
    {
        private RRHHWSClient _daoRRHHWS;
        private empleado _empleadoSeleccionado;
        public empleado EmpleadoSeleccionado { get => _empleadoSeleccionado; set => _empleadoSeleccionado = value; }
        public frmBusquedaEmpleados()
        {
            _daoRRHHWS = new RRHHWSClient();
            InitializeComponent();
            dgvEmpleados.AutoGenerateColumns = false;
        }

        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            empleado empleado = (empleado)dgvEmpleados.Rows[e.RowIndex].DataBoundItem;
            dgvEmpleados.Rows[e.RowIndex].Cells[0].Value = empleado.DNI;
            dgvEmpleados.Rows[e.RowIndex].Cells[1].Value = empleado.nombre + " " + empleado.apellidoPaterno;
            dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = empleado.area.idArea;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = _daoRRHHWS.listarEmpleadosPorDNINombre(txtNombreDNI.Text).ToList();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            EmpleadoSeleccionado = (empleado)dgvEmpleados.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void txtNombreDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
