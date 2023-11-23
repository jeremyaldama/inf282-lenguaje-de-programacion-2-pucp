using MovieSoftController.DAO;
using MovieSoftController.MySQL;
using MovieSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSoft
{
    /* Colocar datos
     * ----------------------------------------------------
     * Código PUCP: 20112728
     * Nombre Completo: Freddy Paz
     * Fecha de modificación: 20-09-2023
     * ----------------------------------------------------
     */
    public partial class frmGestionPeliculas : Form
    {
        private string _rutaPortada = "";
        private Estado _estado;
        private Pelicula _pelicula;

        private GeneroDAO _daoGenero;
        private ProductoraDAO _daoProductora;
        private PeliculaDAO _daoPelicula;
        public frmGestionPeliculas()
        {
            InitializeComponent();
            _estado = Estado.Inicial;

            _daoGenero = new GeneroMySQL();
            cboGenero.DataSource = _daoGenero.listarTodos();
            cboGenero.DisplayMember = "Nombre";
            cboGenero.ValueMember = "IdGenero";

            _daoProductora = new ProductoraMySQL();
            cboProductora.DataSource = _daoProductora.listarTodas();
            cboProductora.DisplayMember = "Nombre";
            cboProductora.ValueMember = "IdProductora";

            _daoPelicula = new PeliculaMySQL();

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
                    gbDatosGenerales.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    gbDatosGenerales.Enabled = true;
                    break;
            }
        }

        public void limpiarComponentes()
        {
            txtIDPelicula.Text = "";
            txtNombre.Text = "";
            cboGenero.SelectedIndex = -1;
            cboProductora.SelectedIndex = -1;
            dtpFechaEstreno.Value = DateTime.Now;
            cbDoblada.Checked = false;
            cbSubtitulada.Checked = false;
            txtCostoProduccion.Text = "";
            txtSinopsis.Text = "";
            panelSuperior.BackColor = SystemColors.Control;
            pbLogoProductora.Image = null;
            pbPortada.Image = null;

        }

        private void btnSubirPortada_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdPortada.ShowDialog() == DialogResult.OK)
                {
                    _rutaPortada = ofdPortada.FileName;
                    pbPortada.Image = Image.FromFile(_rutaPortada);
                }
                FileStream fs = new FileStream(_rutaPortada, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                _pelicula.Portada = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            _pelicula = new Pelicula();
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPeliculas formBusqPeliculas = new frmBusquedaPeliculas();
            if(formBusqPeliculas.ShowDialog() == DialogResult.OK)
            {
                _pelicula = formBusqPeliculas.Pelicula;
                txtIDPelicula.Text = _pelicula.IdPelicula.ToString();
                txtNombre.Text = _pelicula.Nombre;
                cboProductora.SelectedValue = _pelicula.Productora.IdProductora;
                cboGenero.SelectedValue = _pelicula.Genero.IdGenero;
                dtpFechaEstreno.Value = _pelicula.FechaEstreno;
                cbDoblada.Checked = _pelicula.FormatoDoblada;
                cbSubtitulada.Checked = _pelicula.FormatoSubtitulada;
                cbXtreme.Checked = _pelicula.FormatoXtreme;
                cb3D.Checked = _pelicula.Formato3D;
                txtCostoProduccion.Text = _pelicula.CostoProduccion.ToString();
                MemoryStream ms = new MemoryStream(_pelicula.Portada);
                pbPortada.Image = new Bitmap(ms);
                txtSinopsis.Text = _pelicula.Sinopsis;
            }
        }

        private void cboProductora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboProductora.SelectedIndex != -1)
            {
                Productora productora = (Productora) cboProductora.SelectedItem;
                panelSuperior.BackColor = Color.FromArgb(productora.R, productora.G, productora.B);
                MemoryStream ms = new MemoryStream(productora.Logo);
                pbLogoProductora.Image = new Bitmap(ms);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _pelicula.Nombre = txtNombre.Text;
            _pelicula.Genero = new Genero();
            _pelicula.Genero.IdGenero = (int) cboGenero.SelectedValue;
            _pelicula.Productora = new Productora();
            _pelicula.Productora.IdProductora = (int) cboProductora.SelectedValue;
            _pelicula.FechaEstreno = dtpFechaEstreno.Value;
            _pelicula.FormatoDoblada = cbDoblada.Checked;
            _pelicula.FormatoSubtitulada = cbSubtitulada.Checked;
            _pelicula.FormatoXtreme = cbXtreme.Checked;
            _pelicula.Formato3D = cb3D.Checked;
            _pelicula.CostoProduccion = Double.Parse(txtCostoProduccion.Text);
            _pelicula.Sinopsis = txtSinopsis.Text;

            FileStream fs = new FileStream(_rutaPortada, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _pelicula.Portada = br.ReadBytes((int)fs.Length);
            fs.Close();

            int resultado = _daoPelicula.insertar(_pelicula);
            if (resultado != 0)
            {
                txtIDPelicula.Text = _pelicula.IdPelicula.ToString();
                MessageBox.Show("Se ha registrado con éxito la película","Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }else
                MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pbLogoProductora_Click(object sender, EventArgs e)
        {

        }

        private void ofdPortada_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
