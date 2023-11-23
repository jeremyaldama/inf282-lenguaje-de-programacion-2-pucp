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
    public partial class frmReportePrestamosFinalizados : Form
    {
        private LibraryWSClient _daoLibraryWS;
        private BindingList<biblioteca> _listaBibliotecas;
        private int opcionSeleccionada;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        public frmReportePrestamosFinalizados(encargadoBiblioteca e)
        {
            InitializeComponent();
            _daoLibraryWS = new LibraryWSClient();
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
            }catch(Exception ex){ cboBiblioteca.DataSource = null; }
            

            DateTime fechaActual = DateTime.Now;
            DateTime primerDiaDelAnio = new DateTime(fechaActual.Year, 1, 1);

            dtpDesde.MinDate = dtpHasta.MinDate = primerDiaDelAnio;
            dtpDesde.MaxDate = dtpHasta.MaxDate = fechaActual;

            inicializar();
        }

        private void inicializar()
        {
            opcionSeleccionada = 0;
            cboBiblioteca.Hide();
            lblTitulo.Hide();
            lblDescripcion.Hide();
            lblOpcion.Hide();
            btnGenerar.Hide();
            dtpDesde.Hide();
            dtpHasta.Hide();
            rb7dias.Hide();
            rbMes.Hide();
            rbPersonalizado.Hide();
            lblIntervalo.Hide();
            lblDesde.Hide();
            lblHasta.Hide();
        }

        private void activar()
        {
            cboBiblioteca.Show();
            lblTitulo.Show();
            lblDescripcion.Show();
            lblOpcion.Show();
            btnGenerar.Show();
            rb7dias.Show();
            rbMes.Show();
            rbPersonalizado.Show();
            lblIntervalo.Show();
        }

        private void btnDevueltos_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada == 0) activar();
            opcionSeleccionada = 5;
            lblTitulo.Text = "Reporte de Préstamos Devueltos";
            lblDescripcion.Text = "En el siguiente reporte se muestran los préstamos en los cuales los usuarios han devuelto el recurso solicitado. Incluye" +
                " prestamos devueltos a tiempo y préstamos devueltos con tardanza";
        }

        private void btnConRetraso_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada == 0) activar();
            opcionSeleccionada = 6;
            lblTitulo.Text = "Reporte de Préstamos Devueltos Con Retraso";
            lblDescripcion.Text = "En el siguiente reporte se muestran los préstamos en los cuales los usuarios han devuelto el recurso solicitado" +
                " tiempo después del límite de devolución pactado al momento del registro del préstamo";
        }

        private void btnAnulados_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada == 0) activar();
            opcionSeleccionada = 7;
            lblTitulo.Text = "Reporte de Préstamos Anulados";
            lblDescripcion.Text = "En el siguiente reporte se muestran los préstamos que tuvieron que ser anulados porque el usuario no se acercó a recoger" +
                " el libro o este mismo solicitó su cancelación";
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (opcionSeleccionada == 0) activar();
            opcionSeleccionada = 8;
            lblTitulo.Text = "Reporte de Préstamos Finalizados";
            lblDescripcion.Text = "En el siguiente reporte se muestran los préstamos que se han dado por concluidos, entre los cuales tenemos los préstamos" +
                " donde los usuarios han devuelto los libros o se concluyó el préstamo por una anulación del mismo";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cboBiblioteca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una opción de biblioteca para la búsqueda de préstamos", "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rb7dias.Checked == rbMes.Checked == rbPersonalizado.Checked == false)
            {
                MessageBox.Show("Seleccione un intervalo para la búsqueda de prestamos", "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(rb7dias.Checked == true)
            {
                fechaDesde = DateTime.Now.AddDays(-7);
                fechaHasta = DateTime.Now;
            }
            else if(rbMes.Checked == true)
            {
                fechaDesde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                fechaHasta = DateTime.Now;
            }
            else
            {
                if(dtpHasta.Value < dtpDesde.Value)
                {
                    MessageBox.Show("Seleccione un intervalo válido para la búsqueda de prestamos", "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                fechaDesde = dtpDesde.Value;
                fechaHasta = dtpHasta.Value;
            }
            //Abre visualizador de pdf
            int id = ((biblioteca)cboBiblioteca.SelectedValue).idBiblioteca;
            frmReporteGenerado frmGenerado = new frmReporteGenerado(fechaDesde, fechaHasta,id,opcionSeleccionada,lblTitulo.Text);
            frmGenerado.Show();
        }

        private void rbPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPersonalizado.Checked == true) 
            {
                dtpHasta.Show();
                dtpDesde.Show();
                lblDesde.Show();
                lblHasta.Show();
            }
            else
            {
                dtpHasta.Hide();
                dtpDesde.Hide();
                lblDesde.Hide();
                lblHasta.Hide();
            }
        }
    }
}
