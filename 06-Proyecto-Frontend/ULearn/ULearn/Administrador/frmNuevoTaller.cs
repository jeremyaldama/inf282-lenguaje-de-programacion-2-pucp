using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.ServiciosAcademicos;
using ULearn.LogisticsWs;

namespace ULearn.Administrador
{
    public partial class frmNuevoTaller : Form
    {
        private Estado _estado;
        private taller _taller;
        private LogisticsWSClient _daoTaller;
        public frmNuevoTaller()
        {
            _estado = Estado.Inicial;
            _daoTaller = new LogisticsWSClient();
            InitializeComponent();
            cboEspacio.DataSource = _daoTaller.listarTodasSalas();
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
            txtAreaInteres.Text = "";
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
                    tsbBuscarTaller.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoEvento.Enabled = false;
                    gboInfoTaller.Enabled = false;
                    break;
                case Estado.Nuevo:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarTaller.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoEvento.Enabled = true;
                    gboInfoTaller.Enabled = true;
                    txtInscritos.ReadOnly = true;
                    break;
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarTaller.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoEvento.Enabled = true;
                    gboInfoTaller.Enabled = true;
                    txtInscritos.ReadOnly = false;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarTaller.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoEvento.Enabled = false;
                    gboInfoTaller.Enabled = false;
                    break;
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _taller = new taller();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void tsbBuscarTaller_Click(object sender, EventArgs e)
        {
            frmBuscarTaller formBuscarTaller = new frmBuscarTaller();
            if (formBuscarTaller.ShowDialog() == DialogResult.OK)
            {
                _taller = formBuscarTaller.TallerSeleccionado;
                txtIDEvento.Text = _taller.idEvento.ToString();
                txtNombre.Text = _taller.nombre;
                cboEspacio.SelectedValue = _taller.espacio.idEspacio;
                txtOrganizador.Text = _taller.organizador;
                dtpFecha.Value = _taller.fecha;
                txtHoraInicio.Text = _taller.horaInicio;
                txtHoraFin.Text = _taller.horaFin;
                txtInscritos.Text = _taller.inscritos.ToString();
                if (_taller.esGratis == true) rbSiGratuito.Checked = true;
                else rbNoGratuito.Checked = true;
                txtAreaInteres.Text = _taller.areaInteres;
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
            MessageBox.Show("¿Está seguro que desea eliminar este taller?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoTaller.eliminarTaller(_taller.idEvento);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("El horario se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Debe ingresar el nombre del taller", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtOrganizador.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre del organizador del taller", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbSiGratuito.Checked == false && rbNoGratuito.Checked == false)
            {
                MessageBox.Show("Debe indicar si el taller es gratuito o no", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboEspacio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el espacio en el que se dio la charla", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _taller.espacio = new sala();
            _taller.espacio.idEspacio = (int)cboEspacio.SelectedValue;
            _taller.nombre = txtNombre.Text;
            _taller.organizador = txtOrganizador.Text;
            _taller.fecha = dtpFecha.Value;
            _taller.fechaSpecified = true;
            _taller.horaInicio = txtHoraInicio.Text;
            _taller.horaFin = txtHoraFin.Text;
            if (rbSiGratuito.Checked) _taller.esGratis = true;
            else _taller.esGratis = false;
            _taller.areaInteres = txtAreaInteres.Text;
            
            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoTaller.insertarTaller(_taller);
                if (resultado != 0)
                {
                    txtIDEvento.Text = _taller.idEvento.ToString();
                    MessageBox.Show("El taller se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (_estado == Estado.Modificar)
            {
                _taller.inscritos = Int32.Parse(txtInscritos.Text);
                _taller.idEvento = Int32.Parse(txtIDEvento.Text);
                int resultado = _daoTaller.modificarTaller(_taller);
                if (resultado != 0)
                {
                    MessageBox.Show("El taller se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
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
