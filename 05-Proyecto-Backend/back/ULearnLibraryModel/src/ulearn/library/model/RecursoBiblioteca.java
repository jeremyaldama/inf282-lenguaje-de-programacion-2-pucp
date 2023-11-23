package ulearn.library.model;

import java.util.ArrayList;
import java.util.Date;


public class RecursoBiblioteca {
    private int idRecurso;
    private boolean disponible;
    private ArrayList<Autor> autores;
    private String titulo;
    private Biblioteca biblioteca;
    private Date fechaPublicacion;
    private char tipoRecurso;
    private String ISBN;
    private byte[] foto;
    
    public RecursoBiblioteca(){}

    public RecursoBiblioteca(String titulo, Date fechaPublicacion) {
        this.titulo = titulo;
        this.fechaPublicacion = fechaPublicacion;
    }

    public ArrayList<Autor> getAutores() {
        return autores;
    }

    public void setAutores(ArrayList<Autor> autores) {
        this.autores = autores;
    }

    public Date getFechaPublicacion() {
        return fechaPublicacion;
    }

    public void setFechaPublicacion(Date fechaPublicacion) {
        this.fechaPublicacion = fechaPublicacion;
    }
    
	
    public int getIdRecurso() {
        return idRecurso;
    }

    public void setIdRecurso(int idRecurso) {
        this.idRecurso = idRecurso;
    }

    public boolean isDisponible() {
        return disponible;
    }

    public void setDisponible(boolean disponible) {
        this.disponible = disponible;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }
    
    public Biblioteca getBiblioteca(){
        return this.biblioteca;
    }
    
    public void setBiblioteca(Biblioteca biblioteca){
        this.biblioteca = biblioteca;
    }
    
    public char getTipoRecurso() {
        return this.tipoRecurso;
    }

    public void setTipoRecurso(char tipoRecurso) {
        this.tipoRecurso = tipoRecurso;
    }

    public String getISBN() {
        return ISBN;
    }

    public void setISBN(String ISBN) {
        this.ISBN = ISBN;
    }

    public byte[] getFoto() {
        return foto;
    }

    public void setFoto(byte[] foto) {
        this.foto = foto;
    }
}
