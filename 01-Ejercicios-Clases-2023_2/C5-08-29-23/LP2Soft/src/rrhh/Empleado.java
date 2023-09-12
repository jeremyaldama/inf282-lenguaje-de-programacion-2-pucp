package rrhh;
import java.text.SimpleDateFormat;
import java.util.Date;
public class Empleado {
    private int idEmpleado;
    private Area area;
    private String DNI;
    private String nombre;
    private String apellidoPaterno;
    private Date fechaNacimiento;

    public Empleado(String DNI, String nombre, String apellidoPaterno, Date fechaNacimiento) {
        this.DNI = DNI;
        this.nombre = nombre;
        this.apellidoPaterno = apellidoPaterno;
        this.fechaNacimiento = fechaNacimiento;
    }

    public Area getArea() {
        return area;
    }

    public void setArea(Area area) {
        this.area = area;
    }

    
    
    
    public int getIdEmpleado() {
        return idEmpleado;
    }

    public void setIdEmpleado(int idEmpleado) {
        this.idEmpleado = idEmpleado;
    }

    public String getDNI() {
        return DNI;
    }

    public void setDNI(String DNI) {
        this.DNI = DNI;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellidoPaterno() {
        return apellidoPaterno;
    }

    public void setApellidoPaterno(String apellidoPaterno) {
        this.apellidoPaterno = apellidoPaterno;
    }

    public Date getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(Date fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }
    
    public void imprimirDatos(){
        SimpleDateFormat sdf = new SimpleDateFormat
        ("dd-MM-yyyy");
        System.out.println(DNI + " - " + 
                nombre + " " + apellidoPaterno + " - " +
                sdf.format(fechaNacimiento) + " - " + 
                area.getNombre());
    }
}
