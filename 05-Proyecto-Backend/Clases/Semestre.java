
public class Semestre {
    
    private String semestre;
    private boolean esRegular;
	
	public Semestre(String semestre, boolean esRegular){
		this.semestre = semestre;
		this.esRegular = esRegular;
	}
    public String getSemestre() {
        return semestre;
    }

    public void setSemestre(String semestre) {
        this.semestre = semestre;
    }

    public boolean isEsRegular() {
        return esRegular;
    }

    public void setEsRegular(boolean esRegular) {
        this.esRegular = esRegular;
    }
    
    
    
}
