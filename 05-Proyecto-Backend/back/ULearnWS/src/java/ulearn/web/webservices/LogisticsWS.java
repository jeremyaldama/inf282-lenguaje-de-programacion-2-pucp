
package ulearn.web.webservices;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import ulearn.logistics.dao.AulaDAO;
import ulearn.logistics.dao.CharlaDAO;
import ulearn.academic.dao.FacultadDAO;
import ulearn.logistics.dao.InstitucionDAO;
import ulearn.logistics.dao.SalaDAO;
import ulearn.logistics.dao.TallerDAO;
import ulearn.logistics.model.Aula;
import ulearn.logistics.model.Charla;
import ulearn.academic.model.Facultad;
import ulearn.logistics.model.Institucion;
import ulearn.logistics.model.Sala;
import ulearn.logistics.model.Taller;
import ulearn.logistics.mysql.AulaMySQL;
import ulearn.logistics.mysql.CharlaMySQL;
import ulearn.academic.mysql.FacultadMySQL;
import ulearn.logistics.mysql.InstitucionMySQL;
import ulearn.logistics.mysql.SalaMySQL;
import ulearn.logistics.mysql.TallerMySQL;

@WebService(serviceName = "LogisticsWS")
public class LogisticsWS {
    
    private CharlaDAO daoCharla = new CharlaMySQL();
    private FacultadDAO daoFacultad = new FacultadMySQL();
    private TallerDAO daoTaller = new TallerMySQL(); 
    private SalaDAO daoSala = new SalaMySQL(); 
    private AulaDAO daoAula = new AulaMySQL(); 
    private InstitucionDAO daoInstitucion = new InstitucionMySQL(); 

    //SERVICIOS DE FACULTAD
    
    @WebMethod(operationName = "listarTodasFacultades")
    public ArrayList<Facultad> listarTodasFacultades() {
        ArrayList<Facultad> facultades = new ArrayList<>();
        try{
            facultades = daoFacultad.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return facultades;
    }
    
    @WebMethod(operationName = "insertarFacultad")
    public int insertarFacultad(@WebParam(name = "facultad")
            Facultad facultad){
        int resultado = 0;
        try{
            resultado = daoFacultad.insertar(facultad);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarFacultad")
    public int eliminarFacultad(@WebParam(name = "idFacultad")
            int idFacultad){
        int resultado = 0;
        try{
            resultado = daoFacultad.eliminar(idFacultad);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarFacultad")
    public int modificarFacultad(@WebParam(name = "facultad")
            Facultad facultad){
        int resultado = 0;
        try{
            resultado = daoFacultad.modificar(facultad);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    //SERVICIOS DE CHARLAS 
    
    @WebMethod(operationName = "listarTodasCharlas")
    public ArrayList<Charla> listarTodasCharlas() {
        ArrayList<Charla> charlas = new ArrayList<>();
        try{
            charlas = daoCharla.listarCharla();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return charlas;
    }
    
    @WebMethod(operationName = "insertarCharla")
    public int insertarCharla(@WebParam(name = "charla")
            Charla charla){
        int resultado = 0;
        try{
            resultado = daoCharla.agregarCharla(charla);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarCharla")
    public int eliminarCharla(@WebParam(name = "idCharla")
            int idCharla){
        int resultado = 0;
        try{
            resultado = daoCharla.eliminarCharla(idCharla);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarCharla")
    public int modificarCharla(@WebParam(name = "charla")
            Charla charla){
        int resultado = 0;
        try{
            resultado = daoCharla.actualizarCharla(charla);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    //SERVICIOS DE TALLER 
    
    @WebMethod(operationName = "listarTodosTalleres")
    public ArrayList<Taller> listarTodosTalleres() {
        ArrayList<Taller> talleres = new ArrayList<>();
        try{
            talleres = daoTaller.listarTaller();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return talleres;
    }
    
    @WebMethod(operationName = "insertarTaller")
    public int insertarTaller(@WebParam(name = "taller")
            Taller taller){
        int resultado = 0;
        try{
            resultado = daoTaller.agregarTaller(taller);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarTaller")
    public int eliminarTaller(@WebParam(name = "idTaller")
            int idTaller){
        int resultado = 0;
        try{
            resultado = daoTaller.eliminarTaller(idTaller);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarTaller")
    public int modificarTaller(@WebParam(name = "taller")
            Taller taller){
        int resultado = 0;
        try{
            resultado = daoTaller.actualizarTaller(taller);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    //SERVICIOS DE SALA 
    
    @WebMethod(operationName = "listarTodasSalas")
    public ArrayList<Sala> listarTodasSalas() {
        ArrayList<Sala> salas = new ArrayList<>();
        try{
            salas = daoSala.listarSalas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return salas;
    }
    
    @WebMethod(operationName = "insertarSala")
    public int insertarSala(@WebParam(name = "sala")
            Sala sala){
        int resultado = 0;
        try{
            resultado = daoSala.agregarSala(sala);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarSala")
    public int eliminarSala(@WebParam(name = "idSala")
            int idSala){
        int resultado = 0;
        try{
            resultado = daoSala.eliminarSala(idSala);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarSala")
    public int modificarSala(@WebParam(name = "sala")
            Sala sala){
        int resultado = 0;
        try{
            resultado = daoSala.actualizarSala(sala);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    //SERVICIOS DE AULA 
    
    @WebMethod(operationName = "listarTodasAulas")
    public ArrayList<Aula> listarTodasAulas() {
        ArrayList<Aula> aulas = new ArrayList<>();
        try{
            aulas = daoAula.listarAulas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return aulas;
    }
    
    @WebMethod(operationName = "insertarAula")
    public int insertarAula(@WebParam(name = "aula")
            Aula aula){
        int resultado = 0;
        try{
            resultado = daoAula.agregarAula(aula);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarAula")
    public int eliminarAula(@WebParam(name = "idAula")
            int idAula){
        int resultado = 0;
        try{
            resultado = daoAula.eliminarAula(idAula);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarAula")
    public int modificarAula(@WebParam(name = "aula")
            Aula aula){
        int resultado = 0;
        try{
            resultado = daoAula.actualizarAula(aula);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    //SERVICIOS DE INSTITUCION 
    
    @WebMethod(operationName = "listarTodasInstituciones")
    public ArrayList<Institucion> listarTodasInstituciones() {
        ArrayList<Institucion> instituciones = new ArrayList<>();
        try{
            instituciones = daoInstitucion.listarTodas();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return instituciones;
    }
    
    @WebMethod(operationName = "insertarInstitucion")
    public int insertarInstitucion(@WebParam(name = "institucion")
            Institucion institucion){
        int resultado = 0;
        try{
            resultado = daoInstitucion.insertar(institucion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarInstitucion")
    public int eliminarInstitucion(@WebParam(name = "idInstitucion")
            int idInstitucion){
        int resultado = 0;
        try{
            resultado = daoInstitucion.eliminar(idInstitucion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarInstitucion")
    public int modificarInstitucion(@WebParam(name = "institucion")
            Institucion institucion){
        int resultado = 0;
        try{
            resultado = daoInstitucion.modificar(institucion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTalleresFecha")
    public ArrayList<Taller> listarTalleresFecha(@WebParam(name = "fecha") String fecha) {
        ArrayList<Taller> talleres = new ArrayList<Taller>();
        try{
            talleres = daoTaller.listarTallerXFECHA(fecha);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return talleres;
    }
        
    @WebMethod(operationName = "listaCharlasFecha")
    public ArrayList<Charla> listaCharlasFecha(@WebParam(name = "fecha") String fecha) {
        ArrayList<Charla> charlas = new ArrayList<Charla>();
        try{
            charlas = daoCharla.listarCharlaXFecha(fecha);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return charlas;
    }
    
    @WebMethod(operationName = "inscribirseCharla")
    public int inscribirseCharla(@WebParam(name = "idCharla") int idCharla) {
        int resultado = 0;
        try{
            resultado = daoCharla.inscribirse(idCharla);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "inscribirseTaller")
    public int inscribirseTaller(@WebParam(name = "inscribirseTaller") int idTaller) {
        int resultado = 0;
        try{
            resultado = daoTaller.inscribirse(idTaller);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
