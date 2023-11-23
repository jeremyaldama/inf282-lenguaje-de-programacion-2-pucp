
import java.time.LocalTime;
import java.util.Date;


public class EncargadoBiblioteca extends Empleado{

    public EncargadoBiblioteca(String idEmpleado, LocalTime horaEntrada, LocalTime horaSalida, Date fechaContratacion, String nombre, String apellidoPaterno, String apellidoMaterno, String usuario, String password, String correoElectronico) {
        super(idEmpleado, horaEntrada, horaSalida, fechaContratacion, nombre, apellidoPaterno, apellidoMaterno, usuario, password, correoElectronico);
    }

    @Override
    public String consultarDatos() {
        String reporte = "";
        return reporte;
    }
    
    public String consultarPrestamos(){
        String reporte = "";
        return reporte;
    }
    
    public void registrarRecurso(){
        
    }
    
}
