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

namespace ULearn.Administrador
{
    public partial class frmNuevaAula : Form
    {
        private Estado _estado;
        private aula _aula;
        private LogisticsWSClient _daoAula;
        public frmNuevaAula()
        {
            InitializeComponent();
            _daoAula = new LogisticsWSClient();
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void limpiarComponentes()
        {
            txtIDEspacio.Text = "";
            txtNombre.Text = "";
            txtAforo.Text = "";
            rbSiProyector.Checked = false;
            rbNoProyector.Checked = false;
            rbSiPizarra.Checked = false;
            rbNoPizarra.Checked = false;
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    tsbNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    tsbBuscarAula.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoEspacio.Enabled = false;
                    gboInfoAula.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarAula.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoEspacio.Enabled = true;
                    gboInfoAula.Enabled = true;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarAula.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoEspacio.Enabled = false;
                    gboInfoAula.Enabled = false;
                    break;
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _aula = new aula();
        }

        private void tsbBuscarAula_Click(object sender, EventArgs e)
        {
            frmBuscarAula formBuscarAula = new frmBuscarAula();
            if (formBuscarAula.ShowDialog() == DialogResult.OK)
            {
                _aula = formBuscarAula.AulaSeleccionada;
                txtIDEspacio.Text = _aula.idEspacio.ToString();
                txtNombre.Text = _aula.nombre;
                txtAforo.Text = _aula.aforo.ToString();
                if (_aula.tienePizarraInteligente == true) rbSiPizarra.Checked = true;
                else rbNoPizarra.Checked = true;
                if (_aula.tieneProyector == true) rbSiProyector.Checked = true;
                else rbNoProyector.Checked = true;
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
            MessageBox.Show("¿Está seguro que desea eliminar esta aula?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoAula.eliminarAula(_aula.idEspacio);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("El aula se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El aula no pudo eliminarse", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Debe ingresar el nombre del aula", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAforo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el aforo del aula", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Int32.Parse(txtAforo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como aforo", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbNoProyector.Checked == false && rbSiProyector.Checked == false)
            {
                MessageBox.Show("Debe indicar si el aula tiene proyector", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbNoPizarra.Checked == false && rbSiPizarra.Checked == false)
            {
                MessageBox.Show("Debe indicar si el aula tiene pizarra inteligente", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _aula.institucion = new institucion();
            _aula.nombre = txtNombre.Text;
            _aula.institucion.idInstitucion = 1;
            _aula.aforo = Int32.Parse(txtAforo.Text);
            if (rbSiPizarra.Checked) _aula.tienePizarraInteligente = true;
            else _aula.tienePizarraInteligente = false;
            if (rbSiProyector.Checked) _aula.tieneProyector = true;
            else _aula.tieneProyector = false;

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoAula.insertarAula(_aula);
                if (resultado != 0)
                {
                    txtIDEspacio.Text = _aula.idEspacio.ToString();
                    MessageBox.Show("El aula se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (_estado == Estado.Modificar)
            {
                _aula.idEspacio = Int32.Parse(txtIDEspacio.Text);
                int resultado = _daoAula.modificarAula(_aula);
                if (resultado != 0)
                {
                    MessageBox.Show("El aula se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
