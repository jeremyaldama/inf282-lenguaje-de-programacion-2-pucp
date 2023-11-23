
import java.util.ArrayList;

public class Curso {
    
    private int idCurso;
    private String codCurso;
    private boolean esElectivo;
    private double creditos;
    private ArrayList<Horario> horarios;
	private ArrayList<Docente> docentes;
    private Semestre semestreDictado;
    
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

    public boolean isEsElectivo() {
        return esElectivo;
    }

    public void setEsElectivo(boolean esElectivo) {
        this.esElectivo = esElectivo;
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
