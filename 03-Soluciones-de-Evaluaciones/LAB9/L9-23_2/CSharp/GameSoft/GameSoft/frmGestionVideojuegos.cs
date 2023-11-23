using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSoft
{
    /* 
     * Nombre Completo:
     * Código PUCP:
     */
    public partial class frmGestionVideojuegos : Form
    {

        private Estado _estado;
        private string _rutaFotoPortada;
        private string _rutaArchivoPDF;
        public frmGestionVideojuegos()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDVideojuego.Enabled = false;
                    txtIDVideojuego.ReadOnly = true;
                    txtNombre.Enabled = false;
                    txtNombre.ReadOnly = false;
                    txtDesarrolladora.Enabled = false;
                    txtDesarrolladora.ReadOnly = true;
                    btnBuscarDesarrolladora.Enabled = false;
                    dtpFechaLanzamiento.Enabled = false;
                    cboGenero.Enabled = false;
                    btnSubirPortada.Enabled = false;
                    txtCostoDesarrollo.Enabled = false;
                    txtCostoDesarrollo.ReadOnly = false;
                    rbEveryone.Enabled = false;
                    rbTeen.Enabled = false;
                    rbMature.Enabled = false;
                    rbAdultsOnly.Enabled = false;
                    cbPlaystation5.Enabled = false;
                    cbNintendoSwitch.Enabled = false;
                    cbXboxSeries.Enabled = false;
                    cbPC.Enabled = false;
                    cbSmartphone.Enabled = false;
                    btnSubirArchivoPDF.Enabled = false;
                    btnDescargarArchivoPDF.Enabled = false;
                    txtRutaArchivoPDF.Enabled = false;
                    txtRutaArchivoPDF.ReadOnly = true;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtIDVideojuego.Enabled = true;
                    txtIDVideojuego.ReadOnly = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = false;
                    txtDesarrolladora.Enabled = true;
                    txtDesarrolladora.ReadOnly = true;
                    btnBuscarDesarrolladora.Enabled = true;
                    dtpFechaLanzamiento.Enabled = true;
                    cboGenero.Enabled = true;
                    btnSubirPortada.Enabled = true;
                    txtCostoDesarrollo.Enabled = true;
                    txtCostoDesarrollo.ReadOnly = false;
                    rbEveryone.Enabled = true;
                    rbTeen.Enabled = true;
                    rbMature.Enabled = true;
                    rbAdultsOnly.Enabled = true;
                    cbPlaystation5.Enabled = true;
                    cbNintendoSwitch.Enabled = true;
                    cbXboxSeries.Enabled = true;
                    cbPC.Enabled = true;
                    cbSmartphone.Enabled = true;
                    btnSubirArchivoPDF.Enabled = true;
                    btnDescargarArchivoPDF.Enabled = false;
                    txtRutaArchivoPDF.Enabled = true;
                    txtRutaArchivoPDF.ReadOnly = true;
                    break;
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDVideojuego.Enabled = true;
                    txtIDVideojuego.ReadOnly = true;
                    txtNombre.Enabled = true;
                    txtNombre.ReadOnly = true;
                    txtDesarrolladora.Enabled = true;
                    txtDesarrolladora.ReadOnly = true;
                    btnBuscarDesarrolladora.Enabled = false;
                    dtpFechaLanzamiento.Enabled = false;
                    cboGenero.Enabled = false;
                    btnSubirPortada.Enabled = false;
                    txtCostoDesarrollo.Enabled = true;
                    txtCostoDesarrollo.ReadOnly = true;
                    rbEveryone.Enabled = false;
                    rbTeen.Enabled = false;
                    rbMature.Enabled = false;
                    rbAdultsOnly.Enabled = false;
                    cbPlaystation5.Enabled = false;
                    cbNintendoSwitch.Enabled = false;
                    cbXboxSeries.Enabled = false;
                    cbPC.Enabled = false;
                    cbSmartphone.Enabled = false;
                    btnSubirArchivoPDF.Enabled = false;
                    btnDescargarArchivoPDF.Enabled = true;
                    txtRutaArchivoPDF.Enabled = false;
                    txtRutaArchivoPDF.ReadOnly = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDVideojuego.Text = "";
            txtNombre.Text = "";
            txtDesarrolladora.Text = "";
            cboGenero.SelectedIndex = -1;
            dtpFechaLanzamiento.Value = DateTime.Now;
            txtCostoDesarrollo.Text = "";
            rbEveryone.Checked = false;
            rbTeen.Checked = false;
            rbMature.Checked = false;
            rbAdultsOnly.Checked = false;
            cbPlaystation5.Checked = false;
            cbNintendoSwitch.Checked = false;
            cbXboxSeries.Checked = false;
            cbPC.Checked = false;
            cbSmartphone.Checked = false;
            pbPortada.Image = null;
            txtRutaArchivoPDF.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Nuevo;
            establecerEstadoComponentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Buscar;
            establecerEstadoComponentes();
        }

        private void btnSubirPortada_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPortada.ShowDialog() == DialogResult.OK)
                {
                    _rutaFotoPortada = ofdPortada.FileName;
                    pbPortada.Image = Image.FromFile(_rutaFotoPortada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnSubirArchivoPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdArchivo.ShowDialog() == DialogResult.OK)
                {
                    _rutaArchivoPDF = ofdArchivo.FileName;
                    txtRutaArchivoPDF.Text = _rutaArchivoPDF;
                    FileStream fs = new FileStream(_rutaArchivoPDF, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    //Asignamos el archivo al objeto
                    //this._videojuego.materialPromocionalPDF = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al seleccionar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargarArchivoPDF_Click(object sender, EventArgs e)
        {
            if (sfdArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String archivoGenerar = sfdArchivo.FileName;
                    //Convertimos el arreglo de Bytes a archivo
                    //File.WriteAllBytes(archivoGenerar, this._videojuego.materialPromocionalPDF);
                    MessageBox.Show("Se ha guardado el archivo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error al momento de guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
