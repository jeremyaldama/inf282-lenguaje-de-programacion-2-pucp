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
using ULearn.ServiciosAcademicos;

namespace ULearn.Alumno
{
    public partial class frmPerfil : Form
    {
        private Estado _estado;
        private alumno _alumno;
        private string _rutaFoto;
        private AcademicsWSClient _daoAcademicWS;

        public frmPerfil(alumno alumno)
        {
            _estado = Estado.Inicial;
            _alumno = alumno;
            _daoAcademicWS = new AcademicsWSClient();
            InitializeComponent();
            establecerEstadoComponentes();
        }

        private void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    txtCodigo.Enabled = false;
                    txtNombres.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtNumero.Enabled = false;
                    txtNuevaCont.Enabled = false;
                    txtConfContra.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnActFoto.Enabled = false;
                    btnEditar.Enabled = true;
                    break;
                case Estado.Modificar:
                    txtCorreo.Enabled = true;
                    txtNumero.Enabled = true;
                    txtConfContra.Enabled = true;
                    txtNuevaCont.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnActFoto.Enabled = true;
                    btnEditar.Enabled = false;
                    break;
                case Estado.Guardar:

                    break;
            }
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = _alumno.codigoAlumno;
            txtNombres.Text = _alumno.nombre + " " + _alumno.apellidoPaterno + " " + _alumno.apellidoMaterno;
            txtCorreo.Text = _alumno.correoElectronico;
            txtNumero.Text = _alumno.telefono;
            txtConfContra.Text = _alumno.password;
            txtNuevaCont.Text = _alumno.password;
            try
            {
                MemoryStream ms = new MemoryStream(_alumno.foto);
                pbFoto.BackgroundImage = new Bitmap(ms);
            }catch(Exception ex)
            {

            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }

        private void btnActFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFoto.BackgroundImage = Image.FromFile(_rutaFoto);
                }
                FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                _alumno.foto = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _alumno.correoElectronico = txtCorreo.Text;
            _alumno.telefono = txtNumero.Text;

            if (txtConfContra.Text == txtNuevaCont.Text)
            {
                _alumno.password = txtConfContra.Text;
            } else
            {
                MessageBox.Show("Las contraseñas son distintas", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfContra.Text = "";
                txtNuevaCont.Text = "";
                return;
            }

            int resultado = _daoAcademicWS.actualizarAlumnoPerfil(_alumno);

            if (resultado != 0)
            {
                MessageBox.Show("Se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Hubo un error en la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void limpiarComponentes()
        {
            txtCodigo.Text = "A" + _alumno.idUsuario.ToString();
            txtNombres.Text = _alumno.nombre + " " + _alumno.apellidoPaterno + " " + _alumno.apellidoMaterno;
            txtCorreo.Text = _alumno.correoElectronico;
            txtNumero.Text = _alumno.telefono;
            txtConfContra.Text = _alumno.password;
            txtNuevaCont.Text = _alumno.password;
            try
            {
                MemoryStream ms = new MemoryStream(_alumno.foto);
                pbFoto.BackgroundImage = new Bitmap(ms);
            }
            catch { 
                pbFoto.Image = null;
            }
        }

        private void lblNContra_Click(object sender, EventArgs e)
        {

        }
    }
}
