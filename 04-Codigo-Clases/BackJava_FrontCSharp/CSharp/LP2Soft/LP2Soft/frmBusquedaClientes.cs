using LP2GestClientesController.DAO;
using LP2GestClientesController.MySQL;
using LP2GestClientesModel;
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
    public partial class frmBusquedaClientes : Form
    {
        private ClienteDAO _daoCliente;
        private Cliente _clienteSeleccionado;
        public frmBusquedaClientes()
        {
            InitializeComponent();
            _daoCliente = new ClienteMySQL();
            dgvClientes.AutoGenerateColumns = false;
        }

        public Cliente ClienteSeleccionado { get => _clienteSeleccionado; set => _clienteSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = _daoCliente.listarPorNombreDNI(txtNombreDNI.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Cliente cliente = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;
            dgvClientes.Rows[e.RowIndex].Cells[0].Value = cliente.DNI;
            dgvClientes.Rows[e.RowIndex].Cells[1].Value = cliente.Nombre + " " + cliente.ApellidoPaterno;
        }
    }
}
