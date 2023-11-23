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

namespace ULearn.Docente
{
    public partial class frmMisPrestamos : Form
    {
        private ServiciosAcademicos.usuario _persona;
        private LibraryWSClient dao;
        private BindingList<prestamo> _prestamos;
        private BindingList<biblioteca> _biblioteca;
        public frmMisPrestamos(ServiciosAcademicos.usuario persona)
        {
            InitializeComponent();
            _persona = persona;
            dao = new LibraryWSClient();
        }

        private void frmMisPrestamos_Load(object sender, EventArgs e)
        {
            DateTime currentYearStart = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime currentMonthEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));            
            try
            {
                _prestamos = new BindingList<prestamo>(dao.listarPrestamosConFiltros(-1, _persona.idUsuario, currentYearStart, currentMonthEnd, 2, 2, 2));
                foreach (prestamo p in _prestamos)
                {
                    frmDatosPrestamos formDatosPrestamo = new frmDatosPrestamos(p,_persona);
                    formDatosPrestamo.Dock = DockStyle.Top;
                    formDatosPrestamo.TopLevel = false;
                    this.panelListaPrestamos.Controls.Add(formDatosPrestamo);
                    formDatosPrestamo.Visible = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("No cuenta con préstamos activos", "Mensaje de estado de préstamos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

    }
}
