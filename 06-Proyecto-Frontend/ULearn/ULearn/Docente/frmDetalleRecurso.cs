using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class frmDetalleRecurso : Form
    {
        private recursoBiblioteca _recurso;
        public frmDetalleRecurso(recursoBiblioteca r)
        {
            InitializeComponent();
            if (r.tipoRecurso == 'L') _recurso = new libro();
            else _recurso = new digital();
            _recurso = r;
            lblTitulo.Text = _recurso.titulo;
            lblAutor.Text = "";
            int i = 0;
            foreach (autor a in _recurso.autores)
            {
                lblAutor.Text += a.nombre;
                if (_recurso.autores.Length - 1 != i) lblAutor.Text += ", ";
                i++;
            }
            this.Text = "Detalle de " + lblTitulo.Text + "/" + lblAutor.Text;
            lblBiblioteca.Text = _recurso.biblioteca.nombre;
            lblISBN.Text = _recurso.ISBN;
            lblFechaPublicacion.Text = _recurso.fechaPublicacion.ToString("dd/MM/yyyy");
            if (_recurso.tipoRecurso == 'L')
            {
                lblTipo.Text = "Libro Físico";
                lblCampo1.Text = "Número de Páginas:";
                lblDato1.Text = ((libro)_recurso).nroPaginas.ToString();
                lblCampo2.Text = "Número de Copias:";
                lblDato2.Text = ((libro)_recurso).nroCopias.ToString();
                btnAcceso.Text = "Registrar solicitud de préstamo";
            }
            else
            {
                lblTipo.Text = "Recurso Digital";
                lblCampo1.Text = "Repositorio:";
                lblDato1.Text = ((digital)_recurso).repositorio;
                lblCampo2.Text = "Descargable:";
                if (((digital)_recurso).descargable) lblDato2.Text = "Sí";
                else lblDato2.Text = "No";
                btnAcceso.Text = "Acceder al recurso";
            }
            if (_recurso.disponible == true)
            {
                lblDisponible.Text = "Sí";
                btnAcceso.Enabled = true;
            }
            else
            {
                lblDisponible.Text = "No";
                btnAcceso.Enabled = false;
            }
            if(_recurso.foto != null)
            {
                MemoryStream ms = new MemoryStream(_recurso.foto);
                pboPortada.Image = new Bitmap(ms);
            }
            
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            if(_recurso is libro) this.DialogResult = DialogResult.OK;
            else
            {
                Process.Start(((digital)_recurso).URL);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
