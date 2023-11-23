using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashSoft
{
    /* Coloque sus datos
        * -------------------------------------------------
        * Nombre Completo:
        * Código PUCP:
        * Fecha de Modificación: 
    */
    public partial class frmGestionPersonajes : Form
    {
        private Estado _estado;
        private string _rutaFotoLocal;
        public frmGestionPersonajes()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    btnBuscarUniverso.Enabled = false;
                    lblIDPersonaje.Enabled = false;
                    txtIDPersonaje.Enabled = false;
                    lblNombre.Enabled = false;
                    txtNombre.Enabled = false;
                    lblUniverso.Enabled = false;
                    txtUniverso.Enabled = false;
                    lblFechaAparicion.Enabled = false;
                    dtpFechaAparicion.Enabled = false;
                    lblPlataformaOrigen.Enabled = false;
                    cboPlataformaOrigen.Enabled = false;
                    lblDescripcion.Enabled = false;
                    txtDescripcion.Enabled = false;
                    lblVelocidadCaminar.Enabled = false;
                    txtVelocidadCaminar.Enabled = false;
                    lblVelocidadCorrer.Enabled = false;
                    txtVelocidadCorrer.Enabled = false;
                    cbSaltoPared.Enabled = false;
                    cbAdhesionParedes.Enabled = false;
                    cbArrastre.Enabled = false;
                    lblCantMaxSaltos.Enabled = false;
                    nudCantMaxSaltos.Enabled = false;
                    lblDatosTecnicosAdicionales.Enabled = false;
                    lblPeso.Enabled = false;
                    txtPeso.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    btnBuscarUniverso.Enabled = true;
                    lblIDPersonaje.Enabled = true;
                    txtIDPersonaje.Enabled = true;
                    lblNombre.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = false;
                    lblUniverso.Enabled = true;
                    txtUniverso.Enabled = true;
                    lblFechaAparicion.Enabled = true;
                    dtpFechaAparicion.Enabled = true;
                    lblPlataformaOrigen.Enabled = true;
                    cboPlataformaOrigen.Enabled = true;
                    lblDescripcion.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = false;
                    lblVelocidadCaminar.Enabled = true;
                    txtVelocidadCaminar.Enabled = true;
                    txtVelocidadCaminar.ReadOnly = false;
                    lblVelocidadCorrer.Enabled = true;
                    txtVelocidadCorrer.Enabled = true;
                    txtVelocidadCorrer.ReadOnly = false;
                    cbSaltoPared.Enabled = true;
                    cbAdhesionParedes.Enabled = true;
                    cbArrastre.Enabled = true;
                    lblCantMaxSaltos.Enabled = true;
                    nudCantMaxSaltos.Enabled = true;
                    lblDatosTecnicosAdicionales.Enabled = true;
                    lblPeso.Enabled = true;
                    txtPeso.Enabled = true;
                    txtPeso.ReadOnly = false;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnSubirFoto.Enabled = false;
                    btnBuscarUniverso.Enabled = false;
                    lblIDPersonaje.Enabled = true;
                    txtIDPersonaje.Enabled = true;
                    lblNombre.Enabled = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = true;
                    lblUniverso.Enabled = true;
                    txtUniverso.Enabled = false;
                    lblFechaAparicion.Enabled = true;
                    dtpFechaAparicion.Enabled = false;
                    lblPlataformaOrigen.Enabled = true;
                    cboPlataformaOrigen.Enabled = false;
                    lblDescripcion.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtDescripcion.ReadOnly = true;
                    lblVelocidadCaminar.Enabled = true;
                    txtVelocidadCaminar.Enabled = true;
                    txtVelocidadCaminar.ReadOnly = true;
                    lblVelocidadCorrer.Enabled = true;
                    txtVelocidadCorrer.Enabled = true;
                    txtVelocidadCorrer.ReadOnly = true;
                    cbSaltoPared.Enabled = false;
                    cbAdhesionParedes.Enabled = false;
                    cbArrastre.Enabled = false;
                    lblCantMaxSaltos.Enabled = true;
                    nudCantMaxSaltos.Enabled = false;
                    lblDatosTecnicosAdicionales.Enabled = true;
                    lblPeso.Enabled = true;
                    txtPeso.Enabled = true;
                    txtPeso.ReadOnly = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDPersonaje.Text = "";
            txtNombre.Text = "";
            txtUniverso.Text = "";
            dtpFechaAparicion.Value = DateTime.Now;
            cboPlataformaOrigen.SelectedIndex = -1;
            txtDescripcion.Text = "";
            txtVelocidadCaminar.Text = "";
            txtVelocidadCorrer.Text = "";
            nudCantMaxSaltos.Value = 0;
            cbSaltoPared.Checked = false;
            cbAdhesionParedes.Checked = false;
            cbArrastre.Checked = false;
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoLocal = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFotoLocal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }
    }
}
