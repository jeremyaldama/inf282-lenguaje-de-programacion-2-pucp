using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.ServiciosAcademicos;

namespace ULearn.Docente
{
    public partial class frmDatosPrestamos : Form
    {
        private LibraryWS.prestamo _prestamo;
        private LibraryWS.LibraryWSClient dao;
        private BindingList<LibraryWS.autor> _autores;
        private usuario _persona;
        public frmDatosPrestamos(LibraryWS.prestamo prestamo,usuario u)
        {
            InitializeComponent();
            this._prestamo = prestamo;
            this._persona = u;
            dao = new LibraryWS.LibraryWSClient();
        }

        private void frmDatosPrestamos_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = _prestamo.libro.titulo;
            _autores = new BindingList<LibraryWS.autor>(dao.listarAutoresPorIdRecurso(_prestamo.libro.idRecurso));
            if(_autores.Count == 1)
            {
                lblAutores.Text = _autores[0].nombre;
            }
            else
            {
                foreach (LibraryWS.autor a in _autores)
                {
                    lblAutores.Text += a.nombre + " - ";
                }
            }
            lblFechaPrestamo.Text = _prestamo.fechaRegistro.ToString("dd/MM/yyyy");
            definirEstadoPrestamo();
        }

        private void definirEstadoPrestamo()
        {
            lblEstado.Text = "";
            if (_prestamo.anulado == true)
            {
                lblEstado.Text = "Anulado";

            }
            else
            {
                if (_prestamo.fechaRetiroSpecified == false)
                {
                    lblEstado.Text = "Solicitado - Por retirar";

                }
                else
                {
                    if (_prestamo.fechaDevolucionConfirmadaSpecified == false)
                    {
                        if (_prestamo.fechaMaximaDevolucion >= DateTime.Now)
                        {
                            lblEstado.Text = "En curso - ";
                            DateTime currentDate = DateTime.Now;
                            TimeSpan timeSpan = _prestamo.fechaMaximaDevolucion - currentDate;
                            if (timeSpan.Days == 0)
                            {
                                lblEstado.BackColor = Color.Red; //color advertencia
                                lblEstado.Text += "Último día";
                            }
                            else lblEstado.Text += timeSpan.Days.ToString() + " días restantes";

                        }
                        else
                        {
                            lblEstado.Text = "En curso - Con retraso";
                            lblEstado.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        if (_prestamo.fechaDevolucionConfirmada <= _prestamo.fechaMaximaDevolucion) lblEstado.Text = "Devuelto";
                        else
                        {
                            lblEstado.Text = "Devuelto - Con retraso";
                            lblEstado.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void frmDatosPrestamos_Click(object sender, EventArgs e)
        {
            Bibliotecario.frmDetallesPrestamo frmDetalles = new Bibliotecario.frmDetallesPrestamo(_prestamo,_persona,1);
            if(frmDetalles.ShowDialog() == DialogResult.OK)
            {
                _prestamo.anulado = true;
                definirEstadoPrestamo();
            }
        }
    }
}
