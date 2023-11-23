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

namespace ULearn.Docente
{
    public partial class frmReporteCurso : Form
    {
        private ServiciosAcademicos.curso _curso;
        private ServiciosAcademicos.horario _horario;
        private ReportesWSClient _daoReporte;
        public frmReporteCurso(ServiciosAcademicos.curso curso, ServiciosAcademicos.horario horario)
        {
            InitializeComponent();
            _daoReporte = new ReportesWSClient();
            ReportesWS.curso c = new ReportesWS.curso();
            c.idCurso = curso.idCurso;
            ReportesWS.semestre s = new ReportesWS.semestre();
            s.idSemestre = curso.semestreDictado.idSemestre;
            c.semestreDictado = s;
            ReportesWS.horario h = new ReportesWS.horario();
            h.idHorario = horario.idHorario;
            h.codigo = horario.codigo;
            byte[] arregloPDF;
            arregloPDF = _daoReporte.generarReporteHorarioCurso(h, c);
            string nombreReporte = "Reporte" + curso.codCurso + horario.codigo + "´.pdf";
            try
            {
                File.WriteAllBytes(nombreReporte, arregloPDF);
                visorPDF.LoadFile(nombreReporte);
                visorPDF.setShowToolbar(true);
            }catch(Exception ex)
            {
                MessageBox.Show("No hay datos para generar reporte", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
