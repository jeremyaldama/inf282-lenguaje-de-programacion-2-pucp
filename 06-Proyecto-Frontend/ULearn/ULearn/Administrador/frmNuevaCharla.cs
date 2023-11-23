using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.LogisticsWs;

namespace ULearn.Administrador
{
    public partial class frmNuevaCharla : Form
    {
        private Estado _estado;
        private charla _charla;
        private LogisticsWSClient _daoCharla;
        public frmNuevaCharla()
        {
            _estado = Estado.Inicial; 
            _daoCharla = new LogisticsWSClient();
            InitializeComponent();
            cboEspacio.DataSource = _daoCharla.listarTodasAulas();
            cboEspacio.DisplayMember = "Nombre";
            cboEspacio.ValueMember = "IdEspacio";
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        public void limpiarComponentes()
        {
            txtIDEvento.Text = "";
            txtNombre.Text = "";
            cboEspacio.SelectedIndex = -1;
            txtOrganizador.Text = "";
            dtpFecha.Value = DateTime.Now;
            txtHoraFin.Text = "";
            txtHoraInicio.Text = "";
            txtInscritos.Text = "";
            txtPonente.Text = "";
            rbSiGratuito.Checked = false;
            rbNoGratuito.Checked = false;
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    tsbNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    tsbBuscarCharla.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoEspacio.Enabled = false;
                    gboInfoCharla.Enabled = false;
                    break;
                case Estado.Nuevo:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarCharla.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoEspacio.Enabled = true;
                    gboInfoCharla.Enabled = true;
                    txtInscritos.ReadOnly = true;
                    break;
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarCharla.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoEspacio.Enabled = true;
                    gboInfoCharla.Enabled = true;
                    txtInscritos.ReadOnly = false;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarCharla.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoEspacio.Enabled = false;
                    gboInfoCharla.Enabled = false;
                    break;
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _charla = new charla();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void tsbBuscarCharla_Click(object sender, EventArgs e)
        {
            frmBuscarCharla formBuscarCharla = new frmBuscarCharla();
            if (formBuscarCharla.ShowDialog() == DialogResult.OK)
            {
                _charla = formBuscarCharla.CharlaSeleccionada;
                txtIDEvento.Text = _charla.idEvento.ToString();
                txtNombre.Text = _charla.nombre;
                cboEspacio.SelectedValue = _charla.espacio.idEspacio;
                txtOrganizador.Text = _charla.organizador;  
                dtpFecha.Value = _charla.fecha;
                _charla.fechaSpecified = true;
                txtHoraInicio.Text = _charla.horaInicio;
                txtHoraFin.Text = _charla.horaFin;
                txtInscritos.Text = _charla.inscritos.ToString();
                if (_charla.esGratis == true) rbSiGratuito.Checked = true;
                else rbNoGratuito.Checked = true;
                txtPonente.Text = _charla.ponente; 
            }
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("¿Está seguro que desea eliminar esta charla?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoCharla.eliminarCharla(_charla.idEvento);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("La charla se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La charla no pudo eliminarse", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre de la charla", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtOrganizador.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del organizador de la charla", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbSiGratuito.Checked == false && rbNoGratuito.Checked == false)
            {
                MessageBox.Show("Debe indicar si la charla es gratuita o no", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboEspacio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el espacio en el que se dio la charla", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _charla.espacio = new aula();
            _charla.espacio.idEspacio = (int)cboEspacio.SelectedValue;
            _charla.nombre = txtNombre.Text;
            _charla.organizador = txtOrganizador.Text;
            _charla.fecha = dtpFecha.Value;
            _charla.fechaSpecified = true;
            _charla.horaInicio = txtHoraInicio.Text;
            _charla.horaFin = txtHoraFin.Text; 

            if (rbSiGratuito.Checked) _charla.esGratis = true;
            else _charla.esGratis = false;
            _charla.ponente = txtPonente.Text; 

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoCharla.insertarCharla(_charla);
                if (resultado != 0)
                {
                    txtIDEvento.Text = _charla.idEvento.ToString();
                    MessageBox.Show("La charla se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (_estado == Estado.Modificar)
            {
                _charla.inscritos = Int32.Parse(txtInscritos.Text);
                _charla.idEvento = Int32.Parse(txtIDEvento.Text);
                int resultado = _daoCharla.modificarCharla(_charla);
                if (resultado != 0)
                {
                    MessageBox.Show("La charla se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                {
                    MessageBox.Show("Hubo un error en la modificacion", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
