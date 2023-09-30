using LP2SoftLogisticaModel.Almacen;
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
    public partial class frmGestionarOrdenesVenta : Form
    {
        private Estado _estado;
        private OrdenVenta _ordenVenta;
        private Producto _producto;
        
        public frmGestionarOrdenesVenta()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            dgvDetalleOrdenVenta.AutoGenerateColumns = false;
            
        }

        public void establecerEstadoComponentes()
        {
            switch (this._estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscarProducto.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnEliminarProducto.Enabled = false;
                    dtpFechaOrdenVenta.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtDNICliente.Enabled = false;
                    txtDNICliente.ReadOnly = true;
                    txtIDOrdenVenta.Enabled = false;
                    txtIDOrdenVenta.ReadOnly = true;
                    txtNombreCliente.Enabled = false;
                    txtNombreCliente.ReadOnly = true;
                    dgvDetalleOrdenVenta.Enabled = false;
                    txtCodigoProducto.Enabled = false;
                    txtNombreProducto.Enabled = false;
                    txtPrecioUnitario.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    dtpFechaOrdenVenta.Enabled = false;
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscarProducto.Enabled = true;
                    btnBuscarCliente.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                    btnEliminarProducto.Enabled = true;
                    txtCantidad.Enabled = true;
                    txtDNICliente.Enabled = true;
                    txtDNICliente.ReadOnly = true;
                    txtIDOrdenVenta.Enabled = true;
                    txtIDOrdenVenta.ReadOnly = true;
                    txtNombreCliente.Enabled = true;
                    txtNombreCliente.ReadOnly = true;
                    dgvDetalleOrdenVenta.Enabled = true;
                    txtCodigoProducto.Enabled = true;
                    txtCodigoProducto.ReadOnly = true;
                    txtNombreProducto.Enabled = true;
                    txtNombreProducto.ReadOnly = true;
                    txtPrecioUnitario.Enabled = true;
                    txtPrecioUnitario.ReadOnly = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscarProducto.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    btnEliminarProducto.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtDNICliente.Enabled = true;
                    txtDNICliente.ReadOnly = true;
                    txtIDOrdenVenta.Enabled = true;
                    txtIDOrdenVenta.ReadOnly = true;
                    txtNombreCliente.Enabled = true;
                    txtNombreCliente.ReadOnly = true;
                    dgvDetalleOrdenVenta.Enabled = false;
                    txtCodigoProducto.Enabled = false;
                    txtNombreProducto.Enabled = false;
                    txtPrecioUnitario.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDOrdenVenta.Text = "";
            dtpFechaOrdenVenta.Value = DateTime.Now;
            txtCantidad.Text = "";
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioUnitario.Text = "";
            txtDNICliente.Text = "";
            txtNombreCliente.Text = "";
            txtTotal.Text = "";
            dgvDetalleOrdenVenta.DataSource = null;
        }

        private void txtIDOrdenVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCantidad.Text == "" || Int32.Parse(txtCantidad.Text.Trim()) == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad válida", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach(LineaOrdenVenta linea in this._ordenVenta.LineasOrdenVenta)
            {
                if (linea.Producto.IdProducto.Equals(_producto.IdProducto))
                {
                    linea.Cantidad = linea.Cantidad + Int32.Parse(txtCantidad.Text);
                    linea.Subtotal = linea.Cantidad * linea.Producto.Precio;
                    dgvDetalleOrdenVenta.Refresh();
                    calcularTotal();
                    txtTotal.Text = this._ordenVenta.Total.ToString("N2");
                    _producto = null;
                    txtNombreProducto.Text = "";
                    txtCodigoProducto.Text = "";
                    txtPrecioUnitario.Text = "";
                    txtCantidad.Text = "";
                    return;
                }
            }

            LineaOrdenVenta lov = new LineaOrdenVenta();
            lov.Producto = _producto;
            lov.Cantidad = Int32.Parse(txtCantidad.Text);
            lov.Subtotal = lov.Cantidad * lov.Producto.Precio;
            _ordenVenta.LineasOrdenVenta.Add(lov);
            calcularTotal();
            txtTotal.Text = this._ordenVenta.Total.ToString("N2");
            _producto = null;
            txtNombreProducto.Text = "";
            txtCodigoProducto.Text = "";
            txtPrecioUnitario.Text = "";
            txtCantidad.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaClientes formBusqClientes = new frmBusquedaClientes();
            if (formBusqClientes.ShowDialog() == DialogResult.OK)
            {
                txtDNICliente.Text = formBusqClientes.ClienteSeleccionado.DNI;
                txtNombreCliente.Text = formBusqClientes.ClienteSeleccionado.Nombre + " " + formBusqClientes.ClienteSeleccionado.ApellidoPaterno;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _ordenVenta = new OrdenVenta();
            _ordenVenta.LineasOrdenVenta = new BindingList<LineaOrdenVenta>();
            dgvDetalleOrdenVenta.DataSource = _ordenVenta.LineasOrdenVenta;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBusquedaProductos formBusqProd = new frmBusquedaProductos();
            if (formBusqProd.ShowDialog() == DialogResult.OK)
            {
                _producto = formBusqProd.ProductoSeleccionado;
                txtCodigoProducto.Text = _producto.IdProducto.ToString();
                txtNombreProducto.Text = _producto.Nombre + " " + _producto.UnidadMedida;
                txtPrecioUnitario.Text = _producto.Precio.ToString("N2");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalleOrdenVenta.CurrentRow != null)
            {
                LineaOrdenVenta lov = (LineaOrdenVenta)dgvDetalleOrdenVenta.CurrentRow.DataBoundItem;
                this._ordenVenta.LineasOrdenVenta.Remove(lov);
                calcularTotal();
                txtTotal.Text = this._ordenVenta.Total.ToString("N2");
            }
            else
            {
                MessageBox.Show("Debe seleccionar una linea de orden de venta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void calcularTotal()
        {
            this._ordenVenta.Total = 0;
            foreach(LineaOrdenVenta lov in this._ordenVenta.LineasOrdenVenta)
            {
                _ordenVenta.Total = _ordenVenta.Total + lov.Subtotal;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void dgvDetalleOrdenVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                LineaOrdenVenta lov = (LineaOrdenVenta)dgvDetalleOrdenVenta.Rows[e.RowIndex].DataBoundItem;
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[0].Value = lov.Producto.Nombre + " " + lov.Producto.UnidadMedida;
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[1].Value = lov.Cantidad;
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[2].Value = lov.Producto.Precio;
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[3].Value = lov.Subtotal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
