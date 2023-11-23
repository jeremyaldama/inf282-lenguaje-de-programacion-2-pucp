
import java.util.ArrayList;

public class Biblioteca{
    
    private String nombre;
    private int idBiblioteca;
    private int capacidad;
	private ArrayList<Prestamo> prestamos;
	private ArrayList<RecursoBiblioteca> recursos;
	
    public Biblioteca(int idBiblioteca,int capacidad, String nombre) {
        this.idBiblioteca = idBiblioteca;
		this.capacidad = capacidad;
		this.nombre = nombre;
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
}
