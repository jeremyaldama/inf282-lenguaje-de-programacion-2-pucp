package rrhh;

import java.util.ArrayList;

public class Area {
    private int idArea;
    private ArrayList<Empleado> empleados;
    private String nombre;

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

    public ArrayList<Empleado> getEmpleados() {
        return empleados;
    }

    public void setEmpleados(ArrayList<Empleado> empleados) {
        this.empleados = empleados;
    }
    
    
}
