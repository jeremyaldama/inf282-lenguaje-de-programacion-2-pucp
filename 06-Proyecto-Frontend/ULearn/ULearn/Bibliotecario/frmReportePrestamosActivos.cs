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
using ULearn.StaffWS;

namespace ULearn.Bibliotecario
{
    public partial class frmReportePrestamosActivos : Form
    {
        private LibraryWSClient _daoLibraryWS;
        private BindingList<biblioteca> _listaBibliotecas;
        private int opcionSeleccionada;
        public frmReportePrestamosActivos(encargadoBiblioteca e)
        {
            InitializeComponent();
            _daoLibraryWS = new LibraryWSClient();
            lblFecha.Text += DateTime.Now.ToString("dd/MM/yyyy");
            try
            {
                if (e.titulo_trabajo == "Supervisor Principal" || e.titulo_trabajo == "Supervisor Secundario")
                {
                    _listaBibliotecas = new BindingList<biblioteca>(_daoLibraryWS.listarBibliotecasTodas().ToList());
                    biblioteca _bibTodas = new biblioteca();
                    _bibTodas.idBiblioteca = -1;
                    _bibTodas.nombre = "Todas las bibliotecas";
                    _listaBibliotecas.Insert(0, _bibTodas);
                    cboBiblioteca.DataSource = _listaBibliotecas;
                }
                else
                {
                    cboBiblioteca.DataSource = _daoLibraryWS.listarBibliotecasIdEncargado(e.idUsuario).ToList();
                }
                cboBiblioteca.DisplayMember = "nombre";
                cboBiblioteca.SelectedIndex = 0;
            }
            catch (Exception ex) { cboBiblioteca.DataSource = null; }

            inicializar();
        }

        private void inicializar()
        {
            opcionSeleccionada = 0;
            cboBiblioteca.Hide();
            lblTitulo.Hide();
            lblDescripcion.Hide();
            lblOpcion.Hide();
            lblFecha.Hide();
            btnGenerar.Hide();
        }

        private void activar()
        {
            cboBiblioteca.Show();
            lblTitulo.Show();
            lblDescripcion.Show();
            lblOpcion.Show();
            lblFecha.Show();
            btnGenerar.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(cboBiblioteca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una opción de biblioteca válido", "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Abre visualizador de pdf
            DateTime fechaDesde = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime fechaHasta = DateTime.Now;
            
            int id = ((biblioteca)cboBiblioteca.SelectedValue).idBiblioteca;
            frmReporteGenerado frmGenerado = new frmReporteGenerado(fechaDesde, fechaHasta, id, opcionSeleccionada, lblTitulo.Text);
            frmGenerado.Show();
        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada == 0) activar();
            opcionSeleccionada = 1;
            lblTitulo.Text = "Reporte de Préstamos Pendientes";
            lblDescripcion.Text = "En el siguiente reporte se muestran los préstamos en los cuales los usuarios no han retirado áún el libro" +
                " que han solicitado, pero este ya se encuentra separado.";
        }

        private void btnEnCurso_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada == 0) activar();
            opcionSeleccionada = 2;
            lblTitulo.Text = "Reporte de Préstamos en Curso";
            lblDescripcion.Text = "En el siguiente reporte se muestran los préstamos en los cuales los usuarios ya han retirado el libro de la biblioteca" +
                " y queda pendiente la devolución de los recursos";
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada == 0) activar();
            opcionSeleccionada = 3;
            lblTitulo.Text = "Reporte de Préstamos Activos";
            lblDescripcion.Text = "En el siguiente reporte se muestran todos los préstamos en curso y pendientes registrados";
        }

        private void btnNoDevueltos_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada == 0) activar();
            opcionSeleccionada = 4;
            lblTitulo.Text = "Reporte de Préstamos Con Retraso";
            lblDescripcion.Text = "En el siguiente reporte se muestra los préstamos en los cuales los usuarios aún no han devuelto los libros solicitados" +
                " y ya se ha excedido la fecha límite de devolución pactada en el registro del préstamo";
        }
    }
}
