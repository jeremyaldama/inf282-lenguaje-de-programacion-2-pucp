package ulearn.library.model;


import java.util.ArrayList;

public class Biblioteca{
    
    private String nombre;
    private int idBiblioteca;
    private int capacidad;
    private int idEncargado;
    private int idInstitucion;
    private ArrayList<Prestamo> prestamos;
    private ArrayList<RecursoBiblioteca> recursos;
    
    public Biblioteca(int capacidad, String nombre, int idEncargado, int idInstitucion) {
        this.capacidad = capacidad;
        this.nombre = nombre;
        this.idEncargado = idEncargado;
        this.idInstitucion = idInstitucion;
    }
    
    public Biblioteca(){}; 

    public int getIdInstitucion() {
        return idInstitucion;
    }

    public void setIdInstitucion(int idInstitucion) {
        this.idInstitucion = idInstitucion;
    }

    
    public int getIdEncargado() {
        return idEncargado;
    }

    public void setIdEncargado(int idEncargado) {
        this.idEncargado = idEncargado;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getIdBiblioteca() {
        return idBiblioteca;
    }

    public void setIdBiblioteca(int idBiblioteca) {
        this.idBiblioteca = idBiblioteca;
    }

    public int getCapacidad() {
        return capacidad;
    }

    public void setCapacidad(int capacidad) {
        this.capacidad = capacidad;
    }
    
    public ArrayList<Prestamo> getPrestamos(){
		return prestamos;
	}
    
    public void setPrestamos(ArrayList<Prestamo> prestamos){
        this.prestamos = prestamos;
    }
	
    public ArrayList<RecursoBiblioteca> getRecursos(){
        return recursos;
    }
    
    public void setRecursos(ArrayList<RecursoBiblioteca> recursos){
        this.recursos = recursos;
    }
    
    //Modificar en versiones posteriores
    public void imprimirInformacion(){
        System.out.println(getIdBiblioteca() + " - " + getNombre()+ " - " + getCapacidad());
    }
}
