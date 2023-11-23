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
using carrera = ULearn.ServiciosAcademicos.carrera;

namespace ULearn.Administrador
{
    public partial class frmNuevaCarrera : Form
    {
        private Estado _estado;
        private carrera _carrera;
        private AcademicsWSClient _daoCarrera;
        private LogisticsWSClient _daoFacultad; 
        public frmNuevaCarrera()
        {
            InitializeComponent();
            _daoCarrera = new AcademicsWSClient();
            _daoFacultad = new LogisticsWSClient();
            _estado = Estado.Inicial;
            cboFacultad.DataSource = _daoFacultad.listarTodasFacultades();
            cboFacultad.DisplayMember = "Nombre";
            cboFacultad.ValueMember = "IdFacultad";
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
                    tsbBuscarCarrera.Enabled = true;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoCarrera.Enabled = false;
                    break;
                case Estado.Nuevo:
                case Estado.Modificar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    tsbBuscarCarrera.Enabled = false;
                    tsbEditar.Enabled = false;
                    tsbEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gboInfoCarrera.Enabled = true;
                    break;
                case Estado.Buscar:
                    tsbNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    tsbBuscarCarrera.Enabled = false;
                    tsbEditar.Enabled = true;
                    tsbEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    gboInfoCarrera.Enabled = false;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDCarrera.Text = "";
            txtNombre.Text = "";
            dtpUltimoCambioMalla.Value = DateTime.Now;
            txtCreditos.Text = "";
            rbNoAcreditada.Checked = false;
            rbSiAcreditada.Checked = true;
            cboFacultad.SelectedIndex = -1; 
        }

        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        private void tsbBuscarCarrera_Click(object sender, EventArgs e)
        {
            frmBuscarCarreras formBuscarCarreras = new frmBuscarCarreras();
            if (formBuscarCarreras.ShowDialog() == DialogResult.OK)
            {
                _carrera = formBuscarCarreras.CarreraSeleccionada;
                txtIDCarrera.Text = _carrera.idCarrera.ToString();
                txtNombre.Text = _carrera.nombre;
                dtpUltimoCambioMalla.Value = _carrera.cambioMalla;
                txtCreditos.Text = _carrera.creditos.ToString(); 
                if (_carrera.esAcreditada == true) rbNoAcreditada.Checked = true;   
                else rbSiAcreditada.Checked = true;
                cboFacultad.SelectedValue = _carrera.facultad.idFacultad;
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _carrera = new carrera();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("¿Está seguro que desea eliminar esta carrera?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoCarrera.eliminarCarrera(_carrera.idCarrera);
                _estado = Estado.Inicial;
                if (resultado != 0)
                {
                    MessageBox.Show("La carrera se eliminó correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La carrera no pudo eliminarse", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el nombre de la carrera", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rbSiAcreditada.Checked == false && rbNoAcreditada.Checked == false)
            {
                MessageBox.Show("Debe indicar si la carrera esta acreditada o no", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboFacultad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la facultad a la que pertenece la carrera", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCreditos.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar los creditos que se necesitan completar a lo largo de la carrera", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Double.Parse(txtCreditos.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un número como creditaje", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _carrera.nombre = txtNombre.Text;
            _carrera.cambioMalla = dtpUltimoCambioMalla.Value;
            _carrera.cambioMallaSpecified = true;
            _carrera.creditos = Double.Parse(txtCreditos.Text);
            LogisticsWs.facultad ftemp = (LogisticsWs.facultad) cboFacultad.SelectedItem;
            ServiciosAcademicos.facultad facu = new ServiciosAcademicos.facultad();
            facu.idFacultad = ftemp.idFacultad;
            facu.nombre = ftemp.nombre;
            facu.anexo = ftemp.anexo;
            facu.inscritos = ftemp.inscritos;
            _carrera.facultad = facu;
            if (rbSiAcreditada.Checked) _carrera.esAcreditada = true;
            else _carrera.esAcreditada = false;

            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoCarrera.insertarCarrera(_carrera);
                if (resultado != 0)
                {
                    _carrera.idCarrera = resultado;
                    txtIDCarrera.Text = _carrera.idCarrera.ToString();
                    MessageBox.Show("La carrera se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    limpiarComponentes();
                    establecerEstadoComponentes();
                }
                else
                    MessageBox.Show("Hubo un error en el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (_estado == Estado.Modificar)
            {
                _carrera.idCarrera = Int32.Parse(txtIDCarrera.Text);
                int resultado = _daoCarrera.modificarCarrera(_carrera);
                if (resultado != 0)
                {
                    MessageBox.Show("La carrera se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
