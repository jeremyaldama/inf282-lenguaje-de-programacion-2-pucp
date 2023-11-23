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
using ULearn.ReportesWS;
using ULearn.ServiciosAcademicos;
using facultad = ULearn.LogisticsWs.facultad;

namespace ULearn.Administrador
{
    public partial class frmNuevaFacultad : Form
    {
        private Estado _estado;
        private facultad _facultad;
        private LogisticsWSClient _daoFacultad;
        public frmNuevaFacultad()
        {
            InitializeComponent();
            _daoFacultad = new LogisticsWSClient();
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    tsbNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    tsbBuscarFacultad.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoFacultad.Enabled = false;
                    break;
                case Estado.Nuevo:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarFacultad.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoFacultad.Enabled = true;
                    txtInscritos.ReadOnly = true;
                    break;
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarFacultad.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoFacultad.Enabled = true;
                    txtInscritos.ReadOnly = false;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarFacultad.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoFacultad.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDFacultad.Text = "";
            txtNombre.Text = "";
            txtInscritos.Text = "";
            txtAnexo.Text = "";
        }

        private void tsbBuscarFacultad_Click(object sender, EventArgs e)
        {
            frmBuscarFacultad formBuscarFacultad = new frmBuscarFacultad();
            if (formBuscarFacultad.ShowDialog() == DialogResult.OK)
            {
                _facultad = formBuscarFacultad.FacultadSeleccionada;
                txtIDFacultad.Text = _facultad.idFacultad.ToString();
                txtNombre.Text = _facultad.nombre;
                txtAnexo.Text = _facultad.anexo;
                txtInscritos.Text = _facultad.inscritos.ToString(); 
            }
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("¿Está seguro que desea eliminar esta facultad?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = -_daoFacultad.eliminarFacultad(_facultad.idFacultad);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("La facultad se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La facultad no pudo eliminarse", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Debe ingresar el nombre de la facultad", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtAnexo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe indicar el anexo de la facultad", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _facultad.nombre = txtNombre.Text;
            _facultad.anexo = txtAnexo.Text;
            

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoFacultad.insertarFacultad(_facultad);
                if (resultado != 0)
                {
                    _facultad.idFacultad = resultado;
                    txtIDFacultad.Text = _facultad.idFacultad.ToString();
                    MessageBox.Show("La facultad se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (_estado == Estado.Modificar)
            {
                _facultad.idFacultad = Int32.Parse(txtIDFacultad.Text);
                _facultad.inscritos = Int32.Parse(txtInscritos.Text);
                int resultado = _daoFacultad.modificarFacultad(_facultad);
                if (resultado != 0)
                {
                    MessageBox.Show("La facultad se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _facultad = new facultad();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }
    }
}
