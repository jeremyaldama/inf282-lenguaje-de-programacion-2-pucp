
import java.util.ArrayList;

public class Alumno extends Usuario implements IConsultarCalendario{
    
    private char estado;
    private String codigoAlumno;
    private ArrayList<Horario> horariosInscritos;

    public Alumno(char estado, String codigoAlumno, String nombre, String apellidoPaterno, String apellidoMaterno, String usuario, String password, String correoElectronico) {
        super(nombre, apellidoPaterno, apellidoMaterno, usuario, password, correoElectronico);
        this.estado = estado;
        this.codigoAlumno = codigoAlumno;
    }

    public char getEstado() {
        return estado;
    }

    public void setEstado(char estado) {
        this.estado = estado;
    }

    public String getCodigoAlumno() {
        return codigoAlumno;
    }

    public void setCodigoAlumno(String codigoAlumno) {
        this.codigoAlumno = codigoAlumno;
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

    public ArrayList<Horario> getHorariosInscritos() {
        return horariosInscritos;
    }

    public void setHorariosInscritos(ArrayList<Horario> horariosInscritos) {
        this.horariosInscritos = horariosInscritos;
    }
    
    public void solicitarPrestamo(Libro libro){}
    public void registrarReclamo(){}
	public void inscribirseCurso(){}
}
