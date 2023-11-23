package ulearn.staff.model;

import java.util.Date;


public class Administrador extends Usuario {

    public Administrador(String nombre, String apellidoPaterno, String apellidoMaterno, String usuario, String password, String correoElectronico,
    Date fechaNacimiento, char sexo) {
        super(nombre, apellidoPaterno, apellidoMaterno, usuario, password, correoElectronico, fechaNacimiento, sexo);
    }

    public Administrador(){
        
    }
    
    public void crearEvento(){
        
    }
    
    public void crearCurso(){
        
    }
    
    public void registrarAlumno(){
        
    }
    
    public void registrarAula(){
        
    }
    
    @Override
    public String consultarDatos() {
        String reporte = "";
        return reporte;
    }

    @Override
    public void consultarRecursosBiblioteca() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
    
    
    
    
    
    
    
}
