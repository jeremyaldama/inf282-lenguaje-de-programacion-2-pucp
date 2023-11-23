/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/Servlet.java to edit this template
 */
package ulearn.web.servlet;

import java.awt.Image;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.util.Date;
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
 * @author MAURICIO
 */
@WebServlet(name = "ReportePrestamos", urlPatterns = {"/ReportePrestamos"})
public class ReportePrestamos extends HttpServlet {

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
                ReportePrestamos.class.getResource(
              "/ulearn/web/reportes/ReportePrestamos.jasper")
            );
        
      String rutaImagen = 
                ReportePrestamos.class.getResource(
                        "/ulearn/web/resources/logo-u_learn.png")
                .getPath();
      System.out.println(rutaImagen);
        Image img = 
                (new ImageIcon(rutaImagen)).getImage();
        String rutaSubreportePrestamosBib = 
                ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreportePrestamosBib.jasper")
                .getPath();
        String rutaSubreporteEnCurso 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteEnCurso.jasper")
                .getPath();
        
        String rutaSubreporteSinDevolver 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteSinDevolver.jasper")
                .getPath();
        String rutaSubreporteDevueltos 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteDevueltos.jasper")
                .getPath();
        String rutaSubreporteDevueltosRetraso 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteDevueltosRetraso.jasper")
                .getPath();
        String rutaSubreporteAnulados 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteAnulados.jasper")
                .getPath();
        String rutaSubreporteAutores 
                = ReportePrestamos.class.getResource(
                        "/ulearn/web/reportes/SubreporteAutores.jasper")
                .getPath();
        
        System.out.println(rutaSubreporteAutores);
        System.out.println(rutaSubreporteAnulados);
        System.out.println(rutaSubreporteDevueltosRetraso);
        System.out.println(rutaSubreporteDevueltos);
        System.out.println(rutaSubreporteSinDevolver);
        System.out.println(rutaSubreporteEnCurso);
        System.out.println(rutaSubreporteEnCurso);
        
        
        HashMap hm = new HashMap();
        hm.put("modo",1);
        hm.put("idBiblioteca",-1);
        hm.put("fechaInicio",new Date());
        hm.put("fechaFin",new Date());
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
