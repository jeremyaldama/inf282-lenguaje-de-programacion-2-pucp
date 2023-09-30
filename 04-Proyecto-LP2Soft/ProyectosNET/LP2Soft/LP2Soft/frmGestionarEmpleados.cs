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
    public partial class frmGestionarEmpleados : Form
    {
        private Estado _estado;
        private Empleado _empleado;
        private EmpleadoDAO _daoEmpleado;
        private AreaDAO _daoArea;
        public frmGestionarEmpleados()
        {
            _estado = Estado.Inicial;
            _daoEmpleado = new EmpleadoMySQL();
            _daoArea = new AreaMySQL();
            InitializeComponent();
            cboArea.DataSource = _daoArea.listarTodas();
            // los getters
            cboArea.DisplayMember = "Nombre";
            cboArea.ValueMember = "IdArea";
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtIDEmpleado.Enabled = false;
                    txtDNI.Enabled = false;
                    txtDNI.ReadOnly = false;
                    txtNombre.Enabled = false;
                    txtNombre.ReadOnly = false;
                    txtApellidoPaterno.Enabled = false;
                    txtApellidoPaterno.ReadOnly = false;
                    rbMasculino.Enabled = false;
                    rbFemenino.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    cboArea.Enabled = false;
                    txtCargo.Enabled = false;
                    txtCargo.ReadOnly = false;
                    txtSueldo.Enabled = false;
                    txtSueldo.ReadOnly = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    txtIDEmpleado.Enabled = true;
                    txtDNI.Enabled = true;
                    txtDNI.ReadOnly = false;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = false;
                    txtApellidoPaterno.Enabled = true;
                    txtApellidoPaterno.ReadOnly = false;
                    rbMasculino.Enabled = true;
                    rbFemenino.Enabled = true;
                    dtpFechaNacimiento.Enabled = true;
                    cboArea.Enabled = true;
                    txtCargo.Enabled = true;
                    txtCargo.ReadOnly = false;
                    txtSueldo.Enabled = true;
                    txtSueldo.ReadOnly = false;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    txtIDEmpleado.Enabled = true;
                    txtDNI.Enabled = true;
                    txtDNI.ReadOnly = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = true;
                    txtApellidoPaterno.Enabled = true;
                    txtApellidoPaterno.ReadOnly = true;
                    rbMasculino.Enabled = false;
                    rbFemenino.Enabled = false;
                    dtpFechaNacimiento.Enabled = false;
                    cboArea.Enabled = false;
                    txtCargo.Enabled = true;
                    txtCargo.ReadOnly = true;
                    txtSueldo.Enabled = true;
                    txtSueldo.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDEmpleado.Text = "";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtDNI.Text = "";
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            dtpFechaNacimiento.Value = DateTime.Now;
            cboArea.SelectedIndex = -1;
            txtCargo.Text = "";
            txtSueldo.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _empleado = new Empleado();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el DNI del empleado", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtDNI.Text);

            } catch(Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como DNI", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDNI.Text.Trim().Length != 8)
            {
                MessageBox.Show("Debe ingresar un DNI que tenga 8 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del empleado", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtApellidoPaterno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el apellido paterno del empleado", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbMasculino.Checked == false && rbFemenino.Checked == false)
            {
                MessageBox.Show("Debe indicar el género del empleado", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboArea.SelectedIndex == -1) 
            {
                MessageBox.Show("Debe seleccionar el área a la que pertenece el empleado", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSueldo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el sueldo del empleado", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Double.Parse(txtSueldo.Text);
            } catch(Exception ex)
            {
                MessageBox.Show("Debe ingresar un monto correcto como sueldo del empleado", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _empleado.Area = new Area();
            _empleado.Area.IdArea = (int)cboArea.SelectedValue;

            _empleado.DNI = txtDNI.Text;
            _empleado.Nombre = txtNombre.Text;
            _empleado.ApellidoPaterno = txtApellidoPaterno.Text;
            _empleado.Cargo = txtCargo.Text;
            if (rbMasculino.Checked) _empleado.Genero = 'M';
            else _empleado.Genero = 'F';
            _empleado.FechaNacimiento = dtpFechaNacimiento.Value;
            _empleado.Sueldo = Double.Parse(txtSueldo.Text);

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoEmpleado.insertar(_empleado);
                if (resultado != 0)
                {
                    txtIDEmpleado.Text = _empleado.IdPersona.ToString();
                    MessageBox.Show("El empleado se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (_estado == Estado.Modificar)
            {
                int resultado = _daoEmpleado.modificar(_empleado);
                if (resultado != 0)
                {
                    MessageBox.Show("El empleado se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error en la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaEmpleados formBusqEmp = new frmBusquedaEmpleados();
            if (formBusqEmp.ShowDialog() == DialogResult.OK)
            {
                _empleado = formBusqEmp.EmpleadoSeleccionado;
                txtIDEmpleado.Text = _empleado.IdPersona.ToString();
                txtNombre.Text = _empleado.Nombre;
                txtApellidoPaterno.Text = _empleado.ApellidoPaterno;
                txtDNI.Text = _empleado.DNI;
                dtpFechaNacimiento.Value = _empleado.FechaNacimiento;
                if (_empleado.Genero == 'M') rbMasculino.Checked = true;
                else rbFemenino.Checked = true;
                txtCargo.Text = _empleado.Cargo;
                txtSueldo.Text = _empleado.Sueldo.ToString();
                cboArea.SelectedValue = _empleado.Area.IdArea;
                _estado = Estado.Buscar;
                establecerEstadoComponentes();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar a este empleado ", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                int resultado = _daoEmpleado.eliminar(_empleado.IdPersona);
                if (resultado != 0)
                {
                    MessageBox.Show("El empleado se eliminó correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
