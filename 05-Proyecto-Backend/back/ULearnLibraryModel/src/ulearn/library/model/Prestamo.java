package ulearn.library.model;


import java.util.Date;


public class Prestamo {
    private int idPrestamo;
    private Libro libro;
    private int idResponsable;
    private char tipoResponsable; // Docente (D) o Estudiante(E)
    private Biblioteca biblioteca;
    private Date fechaRegistro;
    private Date fechaRetiro;
    private Date fechaMaximaDevolucion;
    private Date fechaDevolucionConfirmada;
    private boolean anulado;

    public Biblioteca getBiblioteca() {
        return biblioteca;
    }

    public void setBiblioteca(Biblioteca biblioteca) {
        this.biblioteca = biblioteca;
    }
    
    
    
    public Libro getLibro() {
        return libro;
    }

    public void setLibro(Libro libro) {
        this.libro = libro;
    }

    public int getIdResponsable() {
        return idResponsable;
    }

    public void setIdResponsable(int idResponsable) {
        this.idResponsable = idResponsable;
    }
    
    public int getIdPrestamo() {
        return idPrestamo;
    }

    public void setIdPrestamo(int idPrestamo) {
        this.idPrestamo = idPrestamo;
    }

    
    public Date getFechaRetiro() {
        return fechaRetiro;
    }

    public void setFechaRetiro(Date fechaRetiro) {
        this.fechaRetiro = fechaRetiro;
    }

    public Date getFechaMaximaDevolucion() {
        return fechaMaximaDevolucion;
    }

    public void setFechaMaximaDevolucion(Date fechaMaximaDevolucion) {
        this.fechaMaximaDevolucion = fechaMaximaDevolucion;
    }

    public Date getFechaDevolucionConfirmada() {
        return fechaDevolucionConfirmada;
    }

    public void setFechaDevolucionConfirmada(Date fechaDevolucionConfirmada) {
        this.fechaDevolucionConfirmada = fechaDevolucionConfirmada;
    }

    public char getTipoResponsable() {
        return tipoResponsable;
    }

    public void setTipoResponsable(char tipoResponsable) {
        this.tipoResponsable = tipoResponsable;
    }

    public Date getFechaRegistro() {
        return fechaRegistro;
    }

    public void setFechaRegistro(Date fechaRegistro) {
        this.fechaRegistro = fechaRegistro;
    }

    public boolean isAnulado() {
        return anulado;
    }

    public void setAnulado(boolean anulado) {
        this.anulado = anulado;
    }
    
}
