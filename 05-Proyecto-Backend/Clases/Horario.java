
import java.time.LocalTime;
import java.util.ArrayList;


public class Horario {
    
    private DiaSemana dia;
    private LocalTime horaInicio;
    private LocalTime horaFin;
    private String codigo;
    private Docente docente;
    private Aula aula;
    private ArrayList<Nota> notasAlumnos;
	private ArrayList<Alumno> alumnos;
    private ArrayList<Reclamo> reclamos;

    public DiaSemana getDia() {
        return dia;
    }

    public void setDia(DiaSemana dia) {
        this.dia = dia;
    }

    public LocalTime getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(LocalTime horaInicio) {
        this.horaInicio = horaInicio;
    }

    public LocalTime getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(LocalTime horaFin) {
        this.horaFin = horaFin;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public Docente getDocente() {
        return docente;
    }

    public void setDocente(Docente docente) {
        this.docente = docente;
    }

    public Aula getAula() {
        return aula;
    }

    public void setAula(Aula aula) {
        this.aula = aula;
    }

    public ArrayList<Nota> getNotasAlumnos() {
        return notasAlumnos;
    }

    public void setNotasAlumnos(ArrayList<Nota> notasAlumnos) {
        this.notasAlumnos = notasAlumnos;
    }
    
	public ArrayList<Alumno> getAlumnos() {
        return alumnos;
    }

    public void setAlumnos(ArrayList<Alumno> alumnos) {
        this.alumnos = alumnos;
    }
    
    public ArrayList<Reclamo> getReclamos() {
        return reclamos;
    }

    public void setReclamos(ArrayList<Reclamo> reclamos) {
        this.reclamos = reclamos;
    }
}
