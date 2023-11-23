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
    public partial class frmNuevaSala : Form
    {
        private Estado _estado;
        private sala _sala;
        private LogisticsWSClient _daoSala; 
        public frmNuevaSala()
        {
            InitializeComponent();
            _daoSala= new LogisticsWSClient();
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }
        public void limpiarComponentes()
        {
            txtIDEspacio.Text = "";
            txtNombre.Text = "";
            txtAforo.Text = "";
            txtTipoSala.Text = "";
            rbSiSistemaAudio.Checked = false;
            rbNoSistemaAudio.Checked = false;
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    tsbNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    tsbBuscarSala.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoEspacio.Enabled = false;
                    gboInfoSala.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarSala.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoEspacio.Enabled = true;
                    gboInfoSala.Enabled = true;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarSala.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoEspacio.Enabled = false;
                    gboInfoSala.Enabled = false;
                    break;
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _sala = new sala(); 
        }

        private void tsbBuscarSala_Click(object sender, EventArgs e)
        {
            frmBuscarSala formBuscarSala = new frmBuscarSala();
            
            if (formBuscarSala.ShowDialog() == DialogResult.OK)
            {
                _sala = formBuscarSala.SalaSeleccionada;
                txtIDEspacio.Text = _sala.idEspacio.ToString();
                txtNombre.Text = _sala.nombre;
                txtAforo.Text = _sala.aforo.ToString();
                if (_sala.tieneSistemaAudio == true) rbSiSistemaAudio.Checked = true;
                else rbNoSistemaAudio.Checked = true; 
                txtTipoSala.Text = _sala.tipoSala.ToString();
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
            MessageBox.Show("¿Está seguro que desea eliminar esta sala?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoSala.eliminarSala(_sala.idEspacio);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("La sala se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La sala no pudo eliminarse", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Debe ingresar el nombre de la sala", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAforo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el aforo de la sala", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (txtTipoSala.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el tipo de sala", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbNoSistemaAudio.Checked == false && rbSiSistemaAudio.Checked == false)
            {
                MessageBox.Show("Debe indicar si la sala tiene sistema de audio", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _sala.institucion = new institucion(); 
            _sala.nombre = txtNombre.Text;
            _sala.institucion.idInstitucion = 1; 
            _sala.aforo = Int32.Parse(txtAforo.Text);
            if (rbSiSistemaAudio.Checked) _sala.tieneSistemaAudio = true;
            else _sala.tieneSistemaAudio = false;
            _sala.tipoSala = txtTipoSala.Text; 

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoSala.insertarSala(_sala);
                if (resultado != 0)
                {
                    txtIDEspacio.Text = _sala.idEspacio.ToString();
                    MessageBox.Show("La sala se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (_estado == Estado.Modificar)
            {
                _sala.idEspacio = Int32.Parse(txtIDEspacio.Text);
                Console.WriteLine("ID: " + _sala.idEspacio);
                int resultado = _daoSala.modificarSala(_sala);
                if (resultado != 0)
                {
                    MessageBox.Show("La sala se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
