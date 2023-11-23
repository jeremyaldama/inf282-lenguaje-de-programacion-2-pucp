package ulearn.academic.model;
import java.util.ArrayList;
import java.util.Date;
public class Carrera {
    private int idCarrera;
    private String nombre;
    private ArrayList<Curso> cursos;
    private Facultad facultad;
    private boolean esAcreditada;
    private Date cambioMalla;
    private double creditos;
    private int cursosTotales;

    public int getCursosTotales() {
        return cursosTotales;
    }

    public void setCursosTotales(int cursosTotales) {
        this.cursosTotales = cursosTotales;
    }

    public double getCreditos() {
        return creditos;
    }
    public void setCreditos(double creditos) {
        this.creditos = creditos;
    }

    public Carrera(String nombre, Facultad facultad, boolean esAcreditada, Date cambioMalla, double creditos) {
        this.nombre = nombre;
        this.facultad = facultad;
        this.esAcreditada = esAcreditada;
        this.cambioMalla = cambioMalla;
        this.creditos = creditos;
    }

    public Carrera(){}

    public Facultad getFacultad() {
        return facultad;
    }

    public void setFacultad(Facultad facultad) {
        this.facultad = facultad;
    }
    
    

    public boolean isEsAcreditada() {
        return esAcreditada;
    }

    public void setEsAcreditada(boolean esAcreditada) {
        this.esAcreditada = esAcreditada;
    }

    public Date getCambioMalla() {
        return cambioMalla;
    }

    public void setCambioMalla(Date cambioMalla) {
        this.cambioMalla = cambioMalla;
    }

    
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getIdCarrera() {
        return idCarrera;
    }

    public void setIdCarrera(int idCarrera) {
        this.idCarrera = idCarrera;
    }

    public ArrayList<Curso> getCursos() {
        return cursos;
    }

    public void setCursos(ArrayList<Curso> cursos) {
        this.cursos = cursos;
    }
}
