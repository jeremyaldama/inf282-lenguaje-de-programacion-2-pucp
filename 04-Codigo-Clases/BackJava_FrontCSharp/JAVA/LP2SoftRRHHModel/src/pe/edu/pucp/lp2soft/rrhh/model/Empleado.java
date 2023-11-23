package pe.edu.pucp.lp2soft.rrhh.model;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Empleado extends Persona{
    private String cargo;
    private double sueldo;
    private boolean activo;
    private Area area;
    private CuentaUsuario cuentaUsuario;

    public Empleado(){}
    
    public Empleado(String DNI, String nombre, String apellidoPaterno, char genero, Date fechaNacimiento, Area area, String cargo, double sueldo) {
        super(DNI, nombre, apellidoPaterno, genero, fechaNacimiento);
        this.cargo = cargo;
        this.sueldo = sueldo;
        this.area = area;
    }
    
    

    public String getCargo() {
        return cargo;
    }

    public void setCargo(String cargo) {
        this.cargo = cargo;
    }

    public double getSueldo() {
        return sueldo;
    }

    public void setSueldo(double sueldo) {
        this.sueldo = sueldo;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public Area getArea() {
        return area;
    }

    public void setArea(Area area) {
        this.area = area;
    }

    public CuentaUsuario getCuentaUsuario() {
        return cuentaUsuario;
    }

    public void setCuentaUsuario(CuentaUsuario cuentaUsuario) {
        this.cuentaUsuario = cuentaUsuario;
    }
    
    public void imprimirInformacion(){
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
        System.out.println(getIdPersona() + ". " + getDNI() + " - " +
                getNombre() + " " + getApellidoPaterno() + " - " +
        getGenero() + " - " + sdf.format(getFechaNacimiento()) +
                " - " + getArea().getNombre() + " - " + 
                cargo + " - " + sueldo);
    }
}