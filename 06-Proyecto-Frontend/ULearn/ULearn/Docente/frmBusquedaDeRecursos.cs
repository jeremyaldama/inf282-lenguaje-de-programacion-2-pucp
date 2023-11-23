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
    public partial class frmBusquedaDeRecursos : Form
    {
        private usuario _usuario;
        private LibraryWSClient _daoLibraryWS;
        private frmBiblioteca _frmBiblioteca;
        public frmBusquedaDeRecursos(usuario u, frmBiblioteca frmPadre)
        {
            InitializeComponent();
            if (u.tipoUsuario == 'E') _usuario = new alumno();
            else if (u.tipoUsuario == 'D') _usuario = new docente();
            _usuario = u;
            _daoLibraryWS = new LibraryWSClient();
            biblioteca todas = new biblioteca();
            todas.idBiblioteca = -1;
            todas.nombre = "Todas las bibliotecas";
            BindingList<biblioteca> listaBibliotecas = new BindingList<biblioteca>(_daoLibraryWS.listarBibliotecasTodas().ToList());
            listaBibliotecas.Insert(0, todas);
            cboBiblioteca.DataSource = listaBibliotecas;
            cboBiblioteca.DisplayMember = "nombre";
            cboBiblioteca.ValueMember = "idBiblioteca";
            cboBiblioteca.SelectedIndex = 0;
            _frmBiblioteca = frmPadre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            char tipo;
            int disponible;
            int biblioteca;
            if (cboDigital.Checked && cboLibro.Checked) tipo = 'Z';
            else if (cboDigital.Checked) tipo = 'D';
            else if (cboLibro.Checked) tipo = 'L';
            else
            {
                MessageBox.Show("Seleccione al menos un tipo de recurso para realizar la busqueda", "Falta de información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboDisponible.Checked && cboNoDisponible.Checked) disponible = 2;
            else if (cboDisponible.Checked) disponible = 1;
            else if (cboNoDisponible.Checked) disponible = 0;
            else
            {
                MessageBox.Show("Seleccione la disponibilidad del recurso indicado", "Falta de información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboBiblioteca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione las biblioteca sobre las que se realizará la búsqueda", "Falta de información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else biblioteca = (int)cboBiblioteca.SelectedValue;

            panelContenido.Controls.Clear();
            try
            {
                BindingList<recursoBiblioteca> _listarecursos = new BindingList<recursoBiblioteca>(_daoLibraryWS.listarRecursosPorTituloAutorConFiltros(txtBusqueda.Text,
                disponible, biblioteca, tipo).ToList());
                foreach (recursoBiblioteca r in _listarecursos)
                {
                    frmResumenDatosRecurso frmResumenDatosRec = new frmResumenDatosRecurso(r,_frmBiblioteca);
                    frmResumenDatosRec.TopLevel = false;
                    frmResumenDatosRec.Dock = DockStyle.Top;
                    panelContenido.Controls.Add(frmResumenDatosRec);
                    frmResumenDatosRec.Visible = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No se encontraron resultados para la búsqueda", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

      
    }
}
