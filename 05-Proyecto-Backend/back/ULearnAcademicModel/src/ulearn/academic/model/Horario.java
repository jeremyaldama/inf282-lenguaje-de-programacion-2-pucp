package ulearn.academic.model;
import java.time.LocalTime;
import java.util.ArrayList;


public class Horario {
    private int idHorario;
    private DiaSemana dia;
    private LocalTime horaInicio;
    private LocalTime horaFin;
    private String codigo;
    private ArrayList<Alumno> alumnos;
    private ArrayList<Docente> docentes;
    private int matriculados;
    private int aprobados;
    private int vacantes;
    private double media;
    private int tiempoTolerancia;
    private char tipoHorario;
    private Curso curso;

    public Horario(DiaSemana dia, LocalTime horaInicio, LocalTime horaFin, String codigo, int matriculados, int vacantes, int tiempoTolerancia, char tipoHorario, Curso curso) {
        this.dia = dia;
        this.horaInicio = horaInicio;
        this.horaFin = horaFin;
        this.codigo = codigo;
        this.matriculados = matriculados;
        this.vacantes = vacantes;
        this.tiempoTolerancia = tiempoTolerancia;
        this.tipoHorario = tipoHorario;
        this.curso = curso;
    }
    
    public Horario(){}
    public Curso getCurso() {
        return curso;
    }

    public int getIdHorario() {
        return idHorario;
    }

    public void setIdHorario(int idHorario) {
        this.idHorario = idHorario;
    }

    public int getAprobados() {
        return aprobados;
    }

    public void setAprobados(int aprobados) {
        this.aprobados = aprobados;
    }

    public double getMedia() {
        return media;
    }

    public void setMedia(double media) {
        this.media = media;
    }

    
    public void setCurso(Curso curso) {
        this.curso = curso;
    }

    public int getMatriculados() {
        return matriculados;
    }

    public void setMatriculados(int matriculados) {
        this.matriculados = matriculados;
    }

    public int getVacantes() {
        return vacantes;
    }

    public void setVacantes(int vacantes) {
        this.vacantes = vacantes;
    }

    public int getTiempoTolerancia() {
        return tiempoTolerancia;
    }

    public void setTiempoTolerancia(int tiempoTolerancia) {
        this.tiempoTolerancia = tiempoTolerancia;
    }

    public char getTipoHorario() {
        return tipoHorario;
    }

    public void setTipoHorario(char tipoHorario) {
        this.tipoHorario = tipoHorario;
    }
    
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
    public ArrayList<Alumno> getAlumnos() {
        return alumnos;
    }

    public void setAlumnos(ArrayList<Alumno> alumnos) {
        this.alumnos = alumnos;
    }

    public ArrayList<Docente> getDocentes() {
        return docentes;
    }

    public void setDocentes(ArrayList<Docente> docentes) {
        this.docentes = docentes;
    }
    
    
}
