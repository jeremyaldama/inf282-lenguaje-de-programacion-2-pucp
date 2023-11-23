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
using ULearn.ReportesWS;

namespace ULearn.Alumno
{
    public partial class frmReporteHistorialAcademico : Form
    {
        private byte[] _arregloPDF;
        private ReportesWSClient _daoReportesWS;
        public frmReporteHistorialAcademico(int idAlumno)
        {
            InitializeComponent();
            _daoReportesWS = new ReportesWSClient();

            _arregloPDF = _daoReportesWS.generarReporteHistorialAcademicoAlumno(idAlumno);
            File.WriteAllBytes("temporal.pdf", _arregloPDF);
            PDFHistorial.LoadFile("temporal.pdf");
            PDFHistorial.setShowToolbar(true);
        }
    }
}
