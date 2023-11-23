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
    public partial class frmResumenDatosRecurso : Form
    {
        private recursoBiblioteca _recursoBib;
        private LibraryWSClient _daoLibraryWS;
        private frmBiblioteca _frmBiblioteca;
        public frmResumenDatosRecurso(recursoBiblioteca recurso, frmBiblioteca frmPadre)
        {
            InitializeComponent();
            _daoLibraryWS = new LibraryWSClient();
            if (recurso.tipoRecurso == 'L') _recursoBib = new libro();
            else _recursoBib = new digital();
            _recursoBib = recurso;
            _frmBiblioteca = frmPadre;
            _recursoBib.autores = _daoLibraryWS.listarAutoresPorIdRecurso(_recursoBib.idRecurso);
            lblTitulo.Text = _recursoBib.titulo;
            lblAutor.Text = "";
            int i = 0;
            foreach(autor a in _recursoBib.autores)
            {
                lblAutor.Text += a.nombre;
                if (_recursoBib.autores.Length - 1 != i) lblAutor.Text += ", ";
                i++;
            }
            lblBiblioteca.Text = _recursoBib.biblioteca.nombre;
            if (_recursoBib.tipoRecurso == 'L') lblTipo.Text = "Libro Físico";
            else lblTipo.Text = "Recurso Digital";
            if (_recursoBib.disponible == true) lblDisponible.Text = "Sí";
            else lblDisponible.Text = "No";
            if (_recursoBib.foto != null)
            {
                MemoryStream ms = new MemoryStream(_recursoBib.foto);
                pboPortada.Image = new Bitmap(ms);
            }
        }

        private void frmResumenDatosRecurso_Click(object sender, EventArgs e)
        {
            frmDetalleRecurso frmDetalle = new frmDetalleRecurso(_recursoBib);
            if(frmDetalle.ShowDialog() == DialogResult.OK){
                _frmBiblioteca.registroPrestamo((libro)_recursoBib);
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            frmDetalleRecurso frmDetalle = new frmDetalleRecurso(_recursoBib);
            if (frmDetalle.ShowDialog() == DialogResult.OK)
            {
                _frmBiblioteca.registroPrestamo((libro)_recursoBib);
            }
        }

        private void pboPortada_Click(object sender, EventArgs e)
        {
            frmDetalleRecurso frmDetalle = new frmDetalleRecurso(_recursoBib);
            if (frmDetalle.ShowDialog() == DialogResult.OK)
            {
                _frmBiblioteca.registroPrestamo((libro)_recursoBib);
            }
        }
    }
}
