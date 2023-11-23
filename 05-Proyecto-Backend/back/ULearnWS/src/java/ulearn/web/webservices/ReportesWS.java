/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package ulearn.web.webservices;

import java.awt.Image;
import java.sql.Connection;
import java.util.Date;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Horario;
import ulearn.config.DBManager;
import ulearn.web.servlet.ReporteHorarioDocente;
import ulearn.web.servlet.ReportePrestamos;

/**
 *
 * @author cesar
 */
@WebService(serviceName = "ReportesWS")
public class ReportesWS {


    @WebMethod(operationName = "generarReporteHorarioCurso")
    public byte[] generarReporteHorarioCurso(@WebParam(name = "horario")Horario horario,@WebParam(name = "curso")Curso curso){
        byte[] archivoPDF = null;
        try{
            Connection con = 
                    DBManager.getInstance().getConnection();
        JasperReport jr = (JasperReport) JRLoader.loadObject(
                ReportesWS.class.getResource(
              "/ulearn/web/reportes/ReporteDesempCurso2.jasper")
            );
        
        String rutaImagen = 
                ReportesWS.class.getResource(
                        "/ulearn/web/resources/logo-u_learn.png")
                .getPath().replace("%20"," ");
        Image img = 
                (new ImageIcon(rutaImagen)).getImage();
        String rutaSubreporteResumen = 
                ReportesWS.class.getResource(
                        "/ulearn/web/reportes/SubReportePie.jasper")
                .getPath().replace("%20"," ");
        String rutaSubreporteMerito 
                = ReportesWS.class.getResource(
                        "/ulearn/web/reportes/SubReporteMerito.jasper")
                .getPath().replace("%20"," ");
        String rutaSubreporteBarras 
                = ReportesWS.class.getResource(
                        "/ulearn/web/reportes/SubReporteBarras.jasper")
                .getPath().replace("%20"," ");
        String rutaSubreporteEvaluacion 
                = ReportesWS.class.getResource(
                        "/ulearn/web/reportes/SubReporteEvaluacion.jasper")
                .getPath().replace("%20"," ");
        
        HashMap hm = new HashMap();
        hm.put("idCurso",curso.getIdCurso());
        hm.put("idSemestre", curso.getSemestreDictado().getIdSemestre());
        hm.put("idHorario",horario.getIdHorario());
        hm.put("codigoHorario",horario.getCodigo());
        hm.put("logo", img);
        hm.put("rutaSubreporteResumen", rutaSubreporteResumen);
        hm.put("rutaSubreporteTabla", rutaSubreporteMerito);
        hm.put("rutaSubreporteEvaluaciones", rutaSubreporteEvaluacion);
        hm.put("rutaSubreporteBarras", rutaSubreporteBarras);
        
        JasperPrint jp = JasperFillManager.fillReport
        (jr, hm, con );
        
        con.close();
        
        archivoPDF = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return archivoPDF;
    }
    
    @WebMethod(operationName = "generarReporteHistorialAcademicoAlumno")
    public byte[] generarReporteHistorialAcademicoAlumno(
            @WebParam(name = "idAlumno") int idAlumno) {
        byte[] archivoPDF = null;
        try{
            Connection con = 
                    DBManager.getInstance().getConnection();
            JasperReport jr = (JasperReport) JRLoader.loadObject(
                    ReportesWS.class.getResource(
                  "/ulearn/web/reportes/ReporteAcademico.jasper")
                );

            String rutaImagen = 
                    ReportesWS.class.getResource(
                            "/ulearn/web/resources/logo-u_learn.png")
                    .getPath().replace("%20"," ");
            Image img = 
                    (new ImageIcon(rutaImagen)).getImage();
            String rutaSubreporteHistorial = 
                    ReportesWS.class.getResource(
                            "/ulearn/web/reportes/SubreporteHistorial.jasper")
                    .getPath().replace("%20"," ");

            HashMap hm = new HashMap();
            hm.put("id_alumno", idAlumno);
            hm.put("rutaSubreporte", rutaSubreporteHistorial);
            hm.put("rutaFoto",rutaImagen);
            JasperPrint jp = JasperFillManager.fillReport
            (jr, hm, con );

            con.close();

            archivoPDF = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return archivoPDF;
    }
    
    @WebMethod(operationName = "generarReportePrestamos")
    public byte[] generarReportePrestamos(@WebParam(name = "modo")int modo,
            @WebParam(name = "idBiblioteca")int idBiblioteca,@WebParam(name="fechaInicio")Date fechaInicio,
            @WebParam(name="fechaFin")Date fechaFin){
        byte[] archivoPDF = null;
        try{
            Connection con = 
                    DBManager.getInstance().getConnection();
        JasperReport jr = (JasperReport) JRLoader.loadObject(
                ReportePrestamos.class.getResource(
              "/ulearn/web/reportes/ReportePrestamos.jasper")
            );
        
       String rutaImagen = 
                ReportePrestamos.class.getResource(
                        "/ulearn/web/resources/logo-u_learn.png")
                .getPath().replace("%20"," ");;
      System.out.println(rutaImagen);
        Image img = 
                (new ImageIcon(rutaImagen)).getImage();
        String rutaSubreportePrestamosBib = 
                ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreportePrestamosBib.jasper")
                .getPath().replace("%20"," ");;
        String rutaSubreporteEnCurso 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteEnCurso.jasper")
                .getPath().replace("%20"," ");;
        
        String rutaSubreporteSinDevolver 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteSinDevolver.jasper")
                .getPath().replace("%20"," ");;
        String rutaSubreporteDevueltos 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteDevueltos.jasper")
                .getPath().replace("%20"," ");;
        String rutaSubreporteDevueltosRetraso 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteDevueltosRetraso.jasper")
                .getPath().replace("%20"," ");;
        String rutaSubreporteAnulados 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteAnulados.jasper")
                .getPath().replace("%20"," ");;
        String rutaSubreporteAutores 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteAutores.jasper")
                .getPath().replace("%20"," ");;
        
        
        HashMap hm = new HashMap();
        hm.put("modo",modo);
        hm.put("idBiblioteca",idBiblioteca);
        hm.put("fechaInicio",fechaInicio);
        hm.put("fechaFin",fechaFin);
        hm.put("logo", img);
        hm.put("rutaSubreporteAutores", rutaSubreporteAutores);
        hm.put("rutaSubreportePrestamosBib", rutaSubreportePrestamosBib);
        hm.put("rutaSubreporteEnCurso", rutaSubreporteEnCurso);
        hm.put("rutaSubreporteSinDevolver", rutaSubreporteSinDevolver);
        hm.put("rutaSubreporteDevueltosRetraso", rutaSubreporteDevueltosRetraso);
        hm.put("rutaSubreporteDevueltos", rutaSubreporteDevueltos);
        hm.put("rutaSubreporteAnulados", rutaSubreporteAnulados);
        
        JasperPrint jp = JasperFillManager.fillReport
        (jr, hm, con );
        
        con.close();
        
        archivoPDF = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return archivoPDF;
    }
}
