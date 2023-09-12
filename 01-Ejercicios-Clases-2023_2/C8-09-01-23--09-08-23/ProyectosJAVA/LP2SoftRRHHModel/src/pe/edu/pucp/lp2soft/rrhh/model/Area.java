package pe.edu.pucp.lp2soft.rrhh.model;
import java.util.ArrayList;
public class Area {
    private int idArea;
    private String nombre;
    private boolean activo;
    private ArrayList<Empleado> empleados;

    public Area(){}
    
    public Area(String nombre) {
        this.nombre = nombre;
    }

    
    public int getIdArea() {
        return idArea;
    }

    public void setIdArea(int idArea) {
        this.idArea = idArea;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public ArrayList<Empleado> getEmpleados() {
        return empleados;
    }

    public void setEmpleados(ArrayList<Empleado> empleados) {
        this.empleados = empleados;
    }
    
}