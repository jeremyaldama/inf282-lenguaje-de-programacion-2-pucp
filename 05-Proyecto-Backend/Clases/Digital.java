
public class Digital extends RecursoBiblioteca{
    private String repositorio;
    private boolean descargable;
	
	public Digital(String autor, String titulo, String repositorio, boolean descargable){
		super(autor,titulo);
		this.repositorio = repositorio;
		this.descargable = descargable;
	}
    public String getRepositorio() {
        return repositorio;
    }

    public void setRepositorio(String repositorio) {
        this.repositorio = repositorio;
    }

    public boolean isDescargable() {
        return descargable;
    }

    public void setDescargable(boolean descargable) {
        this.descargable = descargable;
    }
    
}