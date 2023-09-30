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
        public EmpleadoDAO _daoEmpleado;
        private Empleado _empleadoSeleccionado;
        public Empleado EmpleadoSeleccionado { get => _empleadoSeleccionado; set => _empleadoSeleccionado = value; }
        public frmBusquedaEmpleados()
        {
            _daoEmpleado = new EmpleadoMySQL();
            InitializeComponent();
            dgvEmpleados.AutoGenerateColumns = false;
        }

        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Empleado empleado = (Empleado)dgvEmpleados.Rows[e.RowIndex].DataBoundItem;
            dgvEmpleados.Rows[e.RowIndex].Cells[0].Value = empleado.DNI;
            dgvEmpleados.Rows[e.RowIndex].Cells[1].Value = empleado.Nombre + " " + empleado.ApellidoPaterno;
            dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = empleado.Area.Nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = _daoEmpleado.listarPorNombreDNI(txtNombreDNI.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            EmpleadoSeleccionado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void txtNombreDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
