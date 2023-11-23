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

namespace ULearn.Docente
{
    public partial class frmRegistroPrestamo : Form
    {
        private usuario _usuario;
        private libro _libro;
        private BindingList<int> opciones;
        private LibraryWSClient _daoLibraryWS;
        private prestamo _prestamo;
        private frmBiblioteca _frmBiblioteca;
        private int diasPrestamo;
        private bool finalizado;
        public frmRegistroPrestamo(usuario u, libro l,frmBiblioteca frmPadre)
        {
            InitializeComponent();
            _usuario = u;
            _libro = l;
            _frmBiblioteca = frmPadre;
            _daoLibraryWS = new LibraryWSClient();
            inicializarCboDias();
            cboDias.DataSource = opciones;
            cboDias.SelectedIndex = 0;
            finalizado = false;
            establecerComponentes();
        }

        public bool getFinalizado()
        {
            return finalizado;
        }

        private void inicializarCboDias()
        {
            opciones = new BindingList<int>();
            /*Las opciones de días de préstamos son 4, 5, 6 o 7 días*/
            for(int i = 0; i < 4; i++)
            {
                opciones.Add(i + 4);
            }
        }

        private void establecerComponentes()
        {
            lblTitulo.Text = _libro.titulo;
            lblAutores.Text = "";
            int i = 0;
            foreach (autor a in _libro.autores)
            {
                lblAutores.Text += a.nombre;
                if (_libro.autores.Length - 1 != i) lblAutores.Text += ", ";
                i++;
            }
            lblBiblioteca.Text = _libro.biblioteca.nombre;
            if (_libro.foto != null)
            {
                MemoryStream ms = new MemoryStream(_libro.foto);
                pboPortada.Image = new Bitmap(ms);
            }
            lblISBN.Text = _libro.ISBN;
            lblFechaPub.Text = _libro.fechaPublicacion.ToString("dd/MM/yyyy");
            lblCopias.Text = _libro.nroCopias.ToString();
            lblPaginas.Text = _libro.nroPaginas .ToString();
            lblFechaRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblFechaMaxRet.Text = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy");
            diasPrestamo = (int)cboDias.SelectedValue;
            lblFechaMaxDev.Text = DateTime.Now.AddDays(diasPrestamo).ToString("dd/MM/yyyy");
        }

        private void cboDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            diasPrestamo = (int)cboDias.SelectedValue;
            lblFechaMaxDev.Text = DateTime.Now.AddDays(diasPrestamo).ToString("dd/MM/yyyy");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea registrar la solicitud de préstamo por el libro " + _libro.titulo + " hasta el" + lblFechaMaxDev.Text + "?",
                "Confirmación de préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_usuario is alumno)
                {
                    if (((alumno)_usuario).esDeudor == 1)
                    {
                        MessageBox.Show("No se pudo registrar el préstamo debido a que usted cuenta con libros por devolver con retraso. Ingrese a la seccion de 'Mis prestamos' para visualizar estos préstamos",
                            "Solicitud rechazada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (_usuario is docente)
                {
                    if (((docente)_usuario).esDeudor == 1)
                    {
                        MessageBox.Show("No se pudo registrar el préstamo debido a que usted cuenta con libros por devolver con retraso. Ingrese a la seccion de 'Mis prestamos' para visualizar estos préstamos",
                            "Solicitud rechazada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                _prestamo = new prestamo();
                _prestamo.libro = new libro();
                _prestamo.libro = _libro;
                _prestamo.idResponsable = _usuario.idUsuario;
                if (_usuario is alumno) _prestamo.tipoResponsable = 'A';
                else _prestamo.tipoResponsable = 'D';
                _prestamo.biblioteca = new biblioteca(); 
                _prestamo.biblioteca.idBiblioteca = _libro.biblioteca.idBiblioteca;
                int resultado;
                resultado = _daoLibraryWS.registrarPrestamo(_prestamo, diasPrestamo);
                if(resultado == 1)
                {
                    MessageBox.Show("Se ha registrado correctamente el préstamo del libro " + _libro.titulo + ". Ingrese a la sección 'Mis préstamos' para visualizar el detalle\n" + 
                        "Recuerde que tiene 2 días para pasar por el libro antes de que el préstamo sea anulado","Solicitud aceptada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRegistrar.Enabled = false;
                    cboDias.Enabled = false;
                    finalizado = true;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (finalizado == false)
            {
                if (MessageBox.Show("¿Está seguro que desea cancelar el registro del prestamo?",
                "Cancelación de préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _frmBiblioteca.cancelarSolicitud();
                }
            }
            else _frmBiblioteca.cancelarSolicitud();
            
        }
    }
}
