package ulearn.logistics.model;
import ulearn.academic.model.Facultad;
import java.util.ArrayList;

public class Institucion{
    
    private String direccion;
    private String nombre;
    private String telefono;
    private int idInstitucion;
    private int aforo;
    private ArrayList<Espacio> espacios;
    private ArrayList<Facultad> facultades;

    public Institucion() {
    }

    public Institucion(String direccion, String nombre, String telefono, int aforo) {
        this.direccion = direccion;
        this.nombre = nombre;
        this.telefono = telefono;
        this.aforo = aforo;
    }

    public int getIdInstitucion() {
        return idInstitucion;
    }

    public void setIdInstitucion(int idInstitucion) {
        this.idInstitucion = idInstitucion;
    }

    
    public ArrayList<Espacio> getEspacios() {
        return espacios;
    }

    public void setEspacios(ArrayList<Espacio> espacios) {
        this.espacios = espacios;
    }

    
    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    
    public int getAforo() {
        return aforo;
    }

    public void setAforo(int aforo) {
        this.aforo = aforo;
    }

    public ArrayList<Facultad> getFacultades() {
        return facultades;
    }

    public void setFacultades(ArrayList<Facultad> facultades) {
        this.facultades = facultades;
    }
    
    
    
    
}
