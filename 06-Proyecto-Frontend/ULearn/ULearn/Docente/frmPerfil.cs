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

namespace ULearn.Docente
{
    public partial class frmPerfil : Form
    {
        private ServiciosAcademicos.AcademicsWSClient _dao;
        private Estado _estado;
        private docente _docente;
        private string _rutaFoto;

        public frmPerfil(docente docente)
        {
            _estado = Estado.Inicial;
            _docente = docente;
            _dao = new AcademicsWSClient();
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
                    txtTipo.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtNumero.Enabled = false;
                    txtContActual.Enabled = false;
                    txtNuevaCont.Enabled = false;
                    btnActCont.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    break;
                case Estado.Modificar:
                    txtCorreo.Enabled = true;
                    txtNumero.Enabled = true;
                    txtContActual.Enabled = true;
                    txtNuevaCont.Enabled = true;
                    pboFoto.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnActCont.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case Estado.Guardar: 

                    break;
            }
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = "A" + _docente.idEmpleado.ToString();
            txtNombres.Text = _docente.nombre + " " + _docente.apellidoPaterno + " " + _docente.apellidoMaterno;
            txtTipo.Text = _docente.tipoDocente;
            txtNumero.Text = _docente.telefono;
            try
            {
                txtCorreo.Text = _docente.correoElectronico;
                MemoryStream ms = new MemoryStream(_docente.foto);
                pboFoto.BackgroundImage = new Bitmap(ms);
            }catch{
                Console.WriteLine("no tiene foto");
            }
            txtContActual.Text = _docente.password;
            txtNuevaCont.Text = _docente.password;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerEstadoComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _docente.correoElectronico = txtCorreo.Text;
            _docente.telefono = txtNumero.Text;

            if (txtContActual.Text == txtNuevaCont.Text)
            {
                _docente.password = txtContActual.Text;
            }
            else
            {
                MessageBox.Show("Las contraseñas son distintas", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContActual.Text = "";
                txtNuevaCont.Text = "";
                return;
            }

            int resultado = _dao.actualizarDocentePerfil(_docente);

            if (resultado != 0)
            {
                MessageBox.Show("Se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerEstadoComponentes();
            }
            else
                MessageBox.Show("Hubo un error en la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pboFoto.Image = Image.FromFile(_rutaFoto);
                }
                FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                _docente.foto = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void limpiarComponentes()
        {
            txtCodigo.Text = "A" + _docente.idUsuario.ToString();
            txtNombres.Text = _docente.nombre + " " + _docente.apellidoPaterno + " " + _docente.apellidoMaterno;
            txtCorreo.Text = _docente.correoElectronico;
            txtNumero.Text = _docente.telefono;
            txtContActual.Text = _docente.password;
            txtNuevaCont.Text = _docente.password;
            try
            {
                MemoryStream ms = new MemoryStream(_docente.foto);
                pboFoto.Image = new Bitmap(ms);
            }
            catch
            {
                pboFoto.Image = null;
            }
            
        }
    }
}
