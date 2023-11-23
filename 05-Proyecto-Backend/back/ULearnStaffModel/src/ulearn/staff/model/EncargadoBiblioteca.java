package ulearn.staff.model;


import java.time.LocalTime;
import java.util.Date;


public class EncargadoBiblioteca extends Empleado{
    private String titulo_trabajo;
    
    public EncargadoBiblioteca(LocalTime horaEntrada, LocalTime horaSalida, Date fechaContratacion, String nombre, String apellidoPaterno, String apellidoMaterno, String usuario, String password, String correoElectronico, Date fechaNacimiento, char sexo) {
        super(horaEntrada, horaSalida, fechaContratacion, nombre, apellidoPaterno, apellidoMaterno, usuario, password, correoElectronico, fechaNacimiento, sexo);
    }

    public EncargadoBiblioteca() {

    }

    @Override
    public String consultarDatos() {
        String reporte = "";
        return reporte;
    }
    
    public String consultarPrestamos(){
        String reporte = "";
        return reporte;
    }
    
    public void registrarRecurso(){
        
    }

    @Override
    public void consultarRecursosBiblioteca() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    public String getTitulo_trabajo() {
        return titulo_trabajo;
    }

    public void setTitulo_trabajo(String titulo_trabajo) {
        this.titulo_trabajo = titulo_trabajo;
    }
    
}
