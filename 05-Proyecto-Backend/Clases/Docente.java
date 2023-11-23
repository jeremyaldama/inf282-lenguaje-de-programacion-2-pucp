
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.Date;


public class Docente extends Empleado implements IConsultarCalendario{
    
    private String tipoDocente;
    private ArrayList<Curso> cursosDictar;

    public Docente(String tipoDocente, String idEmpleado, LocalTime horaEntrada, LocalTime horaSalida, Date fechaContratacion, String nombre, String apellidoPaterno, String apellidoMaterno, String usuario, String password, String correoElectronico) {
        super(idEmpleado, horaEntrada, horaSalida, fechaContratacion, nombre, apellidoPaterno, apellidoMaterno, usuario, password, correoElectronico);
        this.tipoDocente = tipoDocente;
    }

    public String getTipoDocente() {
        return tipoDocente;
    }

    public void setTipoDocente(String tipoDocente) {
        this.tipoDocente = tipoDocente;
    }

    @Override
    public String consultarDatos() {
        String reporte = "";
        return reporte;
    }

    @Override
    public String consultarCalendarioAcademico() {
        String reporte = "";
        return reporte;
    }

    public ArrayList<Curso> getCursosDictar() {
        return cursosDictar;
    }

    public void setCursosDictar(ArrayList<Curso> cursosDictar) {
        this.cursosDictar = cursosDictar;
    }

    public void consultarNotaAlumnos(){}
    public void registrarNota(){}
    public void consultarReclamos(){}
    
    
}
