using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULearn.LibraryWS;
using ULearn.ServiciosAcademicos;

namespace ULearn.Docente
{
    public partial class frmBiblioteca : Form
    {
        private frmBusquedaDeRecursos frmCatalogo;
        private frmRegistroPrestamo frmPrestamo = null;
        private usuario _persona;
        private bool _registro_activo;
        public frmBiblioteca(usuario u)
        {
            InitializeComponent();
            this._persona = u;
            _registro_activo = false;
            frmCatalogo = new frmBusquedaDeRecursos(_persona,this);
            mostrarFormulario(frmCatalogo);
        }

        public void mostrarFormulario(Form form)
        {
            panelContenido.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(form);
            form.Visible = true;
        }

        public void registroPrestamo(libro _libro)
        {
            _registro_activo=true;
            frmPrestamo = new frmRegistroPrestamo(_persona, _libro,this);
            mostrarFormulario(frmPrestamo);
        }

        public void cancelarSolicitud()
        {
            _registro_activo = false;
            mostrarFormulario(frmCatalogo);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            if (_registro_activo == true && frmPrestamo != null && frmPrestamo.getFinalizado() == false)
            {
                if (MessageBox.Show("¿Está seguro que desea cancelar el registro del prestamo?",
                "Cancelación de préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _registro_activo = false;
                    frmMisPrestamos formMisPrestamos = new frmMisPrestamos(_persona);
                    mostrarFormulario(formMisPrestamos);
                }
            }
            else
            {
                _registro_activo = false;
                frmMisPrestamos formMisPrestamos = new frmMisPrestamos(_persona);
                mostrarFormulario(formMisPrestamos);
            }
        }

        private void btnBuscarRecurso_Click(object sender, EventArgs e)
        {
            if (_registro_activo == true && frmPrestamo != null && frmPrestamo.getFinalizado() == false)
            {
                if (MessageBox.Show("¿Está seguro que desea cancelar el registro del prestamo?",
                "Cancelación de préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _registro_activo = false;
                    mostrarFormulario(frmCatalogo);
                }
            }
            else
            {
                _registro_activo = false;
                mostrarFormulario(frmCatalogo);
            }
        }
    }
}
