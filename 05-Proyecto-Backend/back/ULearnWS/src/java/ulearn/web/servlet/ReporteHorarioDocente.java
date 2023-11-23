/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package ulearn.web.servlet;

import java.awt.Image;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.util.HashMap;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import ulearn.config.DBManager;

/**
 *
 * @author cesar
 */
@WebServlet(name = "ReporteHorarioDocente", urlPatterns = {"/ReporteHorarioDocente"})
public class ReporteHorarioDocente extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        try{
            Connection con = 
                    DBManager.getInstance().getConnection();
        JasperReport jr = (JasperReport) JRLoader.loadObject(
                ReporteHorarioDocente.class.getResource(
              "/ulearn/web/reportes/ReporteDesempCurso2.jasper")
            );
        
       String rutaImagen = 
                ReporteHorarioDocente.class.getResource(
                        "/ulearn/web/resources/logo-u_learn.png")
                .getPath().replace("%20"," ");
        Image img = 
                (new ImageIcon(rutaImagen)).getImage();
        String rutaSubreporteResumen = 
                ReporteHorarioDocente.class.getResource(
                        "/ulearn/web/reportes/SubReportePie.jasper")
                .getPath().replace("%20"," ");
        String rutaSubreporteMerito 
                = ReporteHorarioDocente.class.getResource(
                        "/ulearn/web/reportes/SubReporteMerito.jasper")
                .getPath().replace("%20"," ");
        
        String rutaSubreporteBarras 
                = ReporteHorarioDocente.class.getResource(
                        "/ulearn/web/reportes/SubReporteBarras.jasper")
                .getPath().replace("%20"," ");
        String rutaSubreporteEvaluacion 
                = ReporteHorarioDocente.class.getResource(
                        "/ulearn/web/reportes/SubReporteEvaluacion.jasper")
                .getPath().replace("%20"," ");
        
        HashMap hm = new HashMap();
        hm.put("idCursoxsemestre",1);
        hm.put("idHorario",1);
        hm.put("codigoHorario","XXXXXX");
        hm.put("logo", img);
        hm.put("rutaSubreporteResumen", rutaSubreporteResumen);
        hm.put("rutaSubreporteTabla", rutaSubreporteMerito);
        hm.put("rutaSubreporteEvaluaciones", rutaSubreporteEvaluacion);
        hm.put("rutaSubreporteBarras", rutaSubreporteBarras);
        
        JasperPrint jp = JasperFillManager.fillReport
        (jr, hm, con );
        
        con.close();
        
        JasperExportManager.exportReportToPdfStream
        (jp, response.getOutputStream());
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
