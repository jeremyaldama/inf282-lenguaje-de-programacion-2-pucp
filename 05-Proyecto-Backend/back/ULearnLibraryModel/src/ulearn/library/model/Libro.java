package ulearn.library.model;

import java.util.Date;


public class Libro extends RecursoBiblioteca{
    private int nroCopias;
    private int nroPaginas;
    private boolean activo;
    
    public Libro(){}
	
    public Libro(String titulo, String ISBN,Date fechaPublicacion, int nroCopias, int nroPaginas){
	super(titulo,fechaPublicacion);
	this.nroCopias = nroCopias;
	this.nroPaginas = nroPaginas;
    }
    
    public int getNroCopias() {
        return nroCopias;
    }

    public void setNroCopias(int nroCopias) {
        this.nroCopias = nroCopias;
    }

    public int getNroPaginas() {
        return nroPaginas;
    }

    public void setNroPaginas(int nroPaginas) {
        this.nroPaginas = nroPaginas;
    }
    
    public boolean getActivo(){
        return this.activo;
    }
    
    public void setActivo(boolean activo){
        this.activo = activo;
    }
    
}
