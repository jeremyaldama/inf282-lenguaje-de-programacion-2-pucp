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
using semestre = ULearn.ServiciosAcademicos.semestre;

namespace ULearn.Administrador
{
    public partial class frmNuevoSemestre : Form
    {
        private Estado _estado;
        private semestre _semestre;
        private AcademicsWSClient _daoSemestre;
        

        public frmNuevoSemestre()
        {
            _estado = Estado.Inicial;
            _daoSemestre = new AcademicsWSClient();
            InitializeComponent();
            establecerEstadoComponentes();
            limpiarComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    tsbNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    tsbBuscarSemestre.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoSemestre.Enabled = false;
                    break;
                case Estado.Nuevo:
                    tsbNuevo.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarSemestre.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoSemestre.Enabled = true;
                    break;
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarSemestre.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoSemestre.Enabled = true;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarSemestre.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoSemestre.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDSemestre.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            txtNombre.Text = ""; 
            rbNoRegular.Checked = false;
            rbSiRegular.Checked = false;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _semestre = new semestre();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void tsbBuscarSemestre_Click(object sender, EventArgs e)
        {
            frmBuscarSemestre formBuscarSemestre = new frmBuscarSemestre();
            if (formBuscarSemestre.ShowDialog() == DialogResult.OK)
            {
                _semestre = formBuscarSemestre.SemestreSeleccionado;
                txtNombre.Text = _semestre.semestre1; 
                txtIDSemestre.Text = _semestre.idSemestre.ToString();
                dtpFechaFin.Value = _semestre.fechaFin;
                dtpFechaInicio.Value = _semestre.fechaInicio;
                if (_semestre.esRegular == true) rbSiRegular.Checked = true;
                else rbNoRegular.Checked = true;
            }
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("¿Está seguro que desea eliminar este semestre?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoSemestre.eliminarSemestre(_semestre.idSemestre);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("El semestre se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El semestre no pudo eliminarse", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
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
            if (rbSiRegular.Checked == false && rbNoRegular.Checked == false)
            {
                MessageBox.Show("Debe indicar si el semestre es regular o no", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _semestre.fechaInicio = dtpFechaInicio.Value;
            _semestre.semestre1 = txtNombre.Text;
            _semestre.fechaInicioSpecified = true;
            _semestre.fechaFin = dtpFechaFin.Value;
            _semestre.fechaFinSpecified = true;
            if (rbSiRegular.Checked) _semestre.esRegular = true;
            else _semestre.esRegular = false;

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoSemestre.insertarSemestre(_semestre);
                if (resultado != 0)
                {
                    txtIDSemestre.Text = _semestre.idSemestre.ToString();
                    MessageBox.Show("El semestre se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (_estado == Estado.Modificar)
            {
                _semestre.idSemestre = Int32.Parse(txtIDSemestre.Text);
                int resultado = _daoSemestre.modificarSemestre(_semestre);
                if (resultado != 0)
                {
                    MessageBox.Show("El semestre se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
