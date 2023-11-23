package ulearn.academic.model;
import java.util.ArrayList;

public class Curso {
    
    private int idCurso;
    private String codCurso;
    private String nombre;
    private int esElectivo;
    private double creditos;
    private ArrayList<Horario> horarios;
    private ArrayList<Docente> docentes;
    private ArrayList<Evaluacion> evaluaciones;
    private Semestre semestreDictado;

    public Curso(){}
    public Curso(String codCurso, String nombre, int esElectivo, double creditos) {
        this.codCurso = codCurso;
        this.nombre = nombre;
        this.esElectivo = esElectivo;
        this.creditos = creditos;
    }
    
    public ArrayList<Evaluacion> getEvaluaciones() {
        return evaluaciones;
    }

    public void setEvaluaciones(ArrayList<Evaluacion> evaluaciones) {
        this.evaluaciones = evaluaciones;
    }
    
    public int getIdCurso() {
        return idCurso;
    }

    public void setIdCurso(int idCurso) {
        this.idCurso = idCurso;
    }

    public String getCodCurso() {
        return codCurso;
    }

    public void setCodCurso(String codCurso) {
        this.codCurso = codCurso;
    }

    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setEsElectivo(int esElectivo) {
        this.esElectivo = esElectivo;
    }
    
    public int getEsElectivo(){
        return this.esElectivo;
    }

    public double getCreditos() {
        return creditos;
    }

    public void setCreditos(double creditos) {
        this.creditos = creditos;
    }
    
    public String consultarHorarios(){
        String reporte = "";
        return reporte;
    }

    public ArrayList<Horario> getHorarios() {
        return horarios;
    }

    public void setHorarios(ArrayList<Horario> horarios) {
        this.horarios = horarios;
    }
	
	public ArrayList<Docente> getDocentes() {
        return docentes;
    }

    public void setDocentes(ArrayList<Docente> docentes) {
        this.docentes = docentes;
    }
    public Semestre getSemestreDictado() {
        return semestreDictado;
    }

    public void setSemestreDictado(Semestre semestreDictado) {
        this.semestreDictado = semestreDictado;
    }
    
    
}
