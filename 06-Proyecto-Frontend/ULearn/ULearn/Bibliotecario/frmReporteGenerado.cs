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

namespace ULearn.Bibliotecario
{
    public partial class frmReporteGenerado : Form
    {
        private ReportesWSClient _daoReportesWS;

        public frmReporteGenerado(DateTime desde, DateTime hasta, int idBilioteca,int modo,string titulo)
        {
            InitializeComponent();
            _daoReportesWS = new ReportesWSClient();
            lblReporte.Text = titulo;
            byte[] arregloPDF;
            arregloPDF = _daoReportesWS.generarReportePrestamos(modo, idBilioteca, desde, hasta);
            string nombreReporte = titulo + ".pdf";
            File.WriteAllBytes(nombreReporte, arregloPDF);
            visorPDF.LoadFile(nombreReporte);
            visorPDF.setShowToolbar(true);

        }
    }
}
