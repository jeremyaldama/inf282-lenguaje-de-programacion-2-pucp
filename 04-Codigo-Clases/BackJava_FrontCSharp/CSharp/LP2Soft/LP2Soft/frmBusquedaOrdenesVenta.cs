using LP2SoftLogisticaController.Ventas.DAO;
using LP2SoftLogisticaController.Ventas.MySQL;
using LP2SoftLogisticaModel.Ventas;
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
    public partial class frmBusquedaOrdenesVenta : Form
    {
        private OrdenVentaDAO _daoOrdenVenta;
        private LineaOrdenVentaDAO _daoLineaOrdenVenta;
        private OrdenVenta _ordenVentaSeleccionada;
        public frmBusquedaOrdenesVenta()
        {
            InitializeComponent();
            _daoOrdenVenta = new OrdenVentaMySQL();
            _daoLineaOrdenVenta = new LineaOrdenVentaMySQL();
            dgvOrdenesVenta.AutoGenerateColumns = false;
        }

        public OrdenVenta OrdenVentaSeleccionada { get => _ordenVentaSeleccionada; set => _ordenVentaSeleccionada = value; }

        private void dgvOrdenesVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OrdenVenta ov = (OrdenVenta)dgvOrdenesVenta.Rows[e.RowIndex].DataBoundItem;
            dgvOrdenesVenta.Rows[e.RowIndex].Cells[0].Value = ov.IdOrdenVenta;
            dgvOrdenesVenta.Rows[e.RowIndex].Cells[1].Value = ov.Cliente.DNI;
            dgvOrdenesVenta.Rows[e.RowIndex].Cells[2].Value = ov.Cliente.Nombre + " " + ov.Cliente.ApellidoPaterno;
            dgvOrdenesVenta.Rows[e.RowIndex].Cells[3].Value = ov.FechaHora.ToString("dd-MM-yyyy");
            dgvOrdenesVenta.Rows[e.RowIndex].Cells[4].Value = ov.Total.ToString("N2");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvOrdenesVenta.DataSource = _daoOrdenVenta.listarPorIdDNINombreCliente(txtBusqueda.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _ordenVentaSeleccionada = (OrdenVenta)dgvOrdenesVenta.CurrentRow.DataBoundItem;
            _ordenVentaSeleccionada.LineasOrdenVenta = _daoLineaOrdenVenta.listarPorIdOrdenVenta(_ordenVentaSeleccionada.IdOrdenVenta);
            this.DialogResult = DialogResult.OK;
        }
    }
}
