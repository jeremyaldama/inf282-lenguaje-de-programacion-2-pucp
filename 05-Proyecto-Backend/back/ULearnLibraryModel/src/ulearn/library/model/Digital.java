package ulearn.library.model;

import java.util.Date;


public class Digital extends RecursoBiblioteca{
    private String repositorio;
    private boolean descargable;
    private String URL;
    private boolean activo;
    
    
    public Digital(){}
	
    public Digital(String titulo,Date fechaPublicacion, String repositorio, boolean descargable){
	super(titulo,fechaPublicacion);
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
    
    public boolean getActivo(){
        return this.activo;
    }
    
    public void setActivo(boolean activo){
        this.activo = activo;
    }

    public String getURL() {
        return URL;
    }

    public void setURL(String URL) {
        this.URL = URL;
    }
    
}