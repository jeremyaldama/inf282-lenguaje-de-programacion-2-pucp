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
using ULearn.LibraryWS;
using ULearn.ServiciosAcademicos;

namespace ULearn.Bibliotecario
{
    public partial class frmDetallesPrestamo : Form
    {
        private bool modificacion;
        private prestamo _prestamo;
        private usuario _responsable;
        private LibraryWSClient _daoLibraryWS;
        private bool vistaUsuario = false;
        public frmDetallesPrestamo(prestamo p, usuario u)
        {
            InitializeComponent();
            _daoLibraryWS = new LibraryWSClient();
            if (u.tipoUsuario == 'E') _responsable = new alumno();
            else _responsable = new docente();
            _responsable = u;
            _prestamo = p;
            modificacion = false;
            this.Text = "Detalle del préstamo #" + _prestamo.idPrestamo.ToString();
            establecerComponentes();
        }

        public frmDetallesPrestamo(prestamo p, usuario u, int flag)
        {
            InitializeComponent();
            _daoLibraryWS = new LibraryWSClient();
            if (u.tipoUsuario == 'E') _responsable = new alumno();
            else _responsable = new docente();
            _responsable = u;
            _prestamo = p;
            modificacion = false;
            vistaUsuario = true;
            btnDevolucion.Hide();
            btnRetiro.Hide();
            this.Text = "Detalle del préstamo #" + _prestamo.idPrestamo.ToString();
            establecerComponentes();
        }

        public void establecerComponentes()
        {
            lblTitulo.Text = _prestamo.libro.titulo;
            _prestamo.libro.autores = _daoLibraryWS.listarAutoresPorIdRecurso(_prestamo.libro.idRecurso).ToArray();
            lblAutores.Text = "";
            int i = 0;
            foreach (autor a in _prestamo.libro.autores)
            {
                lblAutores.Text += a.nombre;
                if (_prestamo.libro.autores.Length - 1 != i) lblAutores.Text += ", ";
                i++;
            }
            lblIDPrestamo.Text = _prestamo.idPrestamo.ToString();
            lblISBN.Text = _prestamo.libro.ISBN;
            lblFechaPub.Text = _prestamo.libro.fechaPublicacion.ToString("dd/MM/yyyy");
            lblNombre.Text = _responsable.nombre + " " + _responsable.apellidoPaterno + " " + _responsable.apellidoMaterno;
            lblCorreo.Text = _responsable.correoElectronico;
            lblFechaReg.Text = _prestamo.fechaRegistro.ToString("dd/MM/yyyy");
            lblFechaMaxDev.Text = _prestamo.fechaMaximaDevolucion.ToString("dd/MM/yyyy");
            lblFechaMaxRet.Text = _prestamo.fechaRegistro.AddDays(2).ToString("dd/MM/yyyy");
            if (_responsable is alumno) lblRol.Text = "Alumno";
            else if (_responsable is docente) lblRol.Text = "Docente";
            if (_prestamo.fechaDevolucionConfirmadaSpecified == true) lblFechaDev.Text = _prestamo.fechaDevolucionConfirmada.ToString("dd/MM/yyyy");
            else lblFechaDev.Text = "--/--/----";
            if (_prestamo.fechaRetiroSpecified == true) lblFechaRet.Text = _prestamo.fechaRetiro.ToString("dd/MM/yyyy");
            else lblFechaRet.Text = "--/--/----";
            MemoryStream ms = new MemoryStream(_prestamo.libro.foto);
            pboPortada.Image = new Bitmap(ms);
            definirEstadoPrestamo();
        }

        private void definirEstadoPrestamo()
        {
            lblEstado.Text = "";
            if (_prestamo.anulado == true)
            {
                lblEstado.Text = "Anulado";
                btnDevolucion.Enabled = false;
                btnRetiro.Enabled = false;
                btnAnular.Enabled = false;
            }
            else
            {
                if (_prestamo.fechaRetiroSpecified == false)
                {
                    lblEstado.Text = "Solicitado - Por retirar";
                    btnDevolucion.Enabled = false;
                    btnRetiro.Enabled = true;
                    btnAnular.Enabled = true;
                }
                else
                {
                    if (_prestamo.fechaDevolucionConfirmadaSpecified == false)
                    {
                        if (_prestamo.fechaMaximaDevolucion >= DateTime.Now) lblEstado.Text = "En curso";
                        else
                        {
                            lblEstado.Text = "En curso - Con retraso";
                            lblEstado.ForeColor = Color.Red;
                        }
                        btnDevolucion.Enabled = true;
                        btnRetiro.Enabled = false;
                        btnAnular .Enabled = false;
                    }
                    else
                    {
                        if (_prestamo.fechaDevolucionConfirmada <= _prestamo.fechaMaximaDevolucion) lblEstado.Text = "Devuelto";
                        else
                        {
                            lblEstado.Text = "Devuelto - Con retraso";
                            lblEstado.ForeColor = Color.Red;
                        }
                        btnDevolucion.Enabled = false;
                        btnRetiro.Enabled = false;
                        btnAnular .Enabled = false;
                    }
                }
            }
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea registrar la devolución del libro " + _prestamo.libro.titulo + "?", "Registro de devolución",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                int resultado = _daoLibraryWS.registrarDevolucionPrestamo(_prestamo.idPrestamo);
                if (resultado == 1)
                {
                    MessageBox.Show("Se ha registrado correctamente la devolucion del libro " + _prestamo.libro.titulo,
                        "Registro de devolución", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _prestamo.fechaDevolucionConfirmada = DateTime.Now;
                    _prestamo.fechaDevolucionConfirmadaSpecified = true;
                    modificacion = true;
                    establecerComponentes();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la devolucion del libro correctamente",
                        "Registro de devolución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(modificacion == true) this.DialogResult = DialogResult.OK;
            else this.DialogResult = DialogResult.Cancel;
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea registrar el retiro del libro " + _prestamo.libro.titulo + "?", "Registro de retiro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int resultado = _daoLibraryWS.registrarRetiroPrestamo(_prestamo.idPrestamo);
                if (resultado == 1)
                {
                    MessageBox.Show("Se ha registrado correctamente el retiro del libro " + _prestamo.libro.titulo,
                        "Registro de retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _prestamo.fechaRetiro = DateTime.Now;
                    _prestamo.fechaRetiroSpecified = true;
                    modificacion = true;
                    establecerComponentes();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el retiro del libro correctamente",
                        "Registro de retiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea anular el prestamo del libro " + _prestamo.libro.titulo + "?", "Anulación de préstamo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = _daoLibraryWS.anularPrestamo(_prestamo.idPrestamo);
                if (resultado == 1)
                {
                    MessageBox.Show("Se ha anulado correctamente el préstamo del libro " + _prestamo.libro.titulo,
                        "Anulación de préstamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _prestamo.anulado = true;
                    modificacion = true;
                    establecerComponentes();
                }
                else
                {
                    MessageBox.Show("No se pudo anular el préstamo correctamente",
                        "Anulación de préstamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
