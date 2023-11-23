
import java.util.ArrayList;
import java.util.Date;
public class Carrera {
    
    private String nombre;
    private int idCarrera;
    private ArrayList<Curso> cursos;
	private Facultad facultad;
	private boolean esAcreditada;
	private Date cambioMalla;
	
	public Carrera(String nombre,Facultad facultad,boolean esAcreditada){
		this.nombre = nombre;
		this.esAcreditada = esAcreditada;
		this.facultad = facultad;
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
