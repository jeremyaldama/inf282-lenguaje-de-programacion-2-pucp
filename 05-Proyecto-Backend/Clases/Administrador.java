
public class Administrador extends Usuario {

    public Administrador(String nombre, String apellidoPaterno, String apellidoMaterno, String usuario, String password, String correoElectronico) {
        super(nombre, apellidoPaterno, apellidoMaterno, usuario, password, correoElectronico);
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
    
    
    
    
    
    
    
    
}
