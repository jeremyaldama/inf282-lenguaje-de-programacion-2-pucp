

import java.time.LocalTime;
import java.util.Date;


public abstract class Empleado extends Usuario {
    
    private String idEmpleado;
    private LocalTime horaEntrada;
    private LocalTime horaSalida;
    private Date fechaContratacion;

    public Empleado(String idEmpleado, LocalTime horaEntrada, LocalTime horaSalida, Date fechaContratacion, String nombre, String apellidoPaterno, String apellidoMaterno, String usuario, String password, String correoElectronico) {
        super(nombre, apellidoPaterno, apellidoMaterno, usuario, password, correoElectronico);
        this.idEmpleado = idEmpleado;
        this.horaEntrada = horaEntrada;
        this.horaSalida = horaSalida;
        this.fechaContratacion = fechaContratacion;
    }

    public String getIdEmpleado() {
        return idEmpleado;
    }

    public void setIdEmpleado(String idEmpleado) {
        this.idEmpleado = idEmpleado;
    }

    public LocalTime getHoraEntrada() {
        return horaEntrada;
    }

    public void setHoraEntrada(LocalTime horaEntrada) {
        this.horaEntrada = horaEntrada;
    }

    public LocalTime getHoraSalida() {
        return horaSalida;
    }

    public void setHoraSalida(LocalTime horaSalida) {
        this.horaSalida = horaSalida;
    }

    public Date getFechaContratacion() {
        return fechaContratacion;
    }

    public void setFechaContratacion(Date fechaContratacion) {
        this.fechaContratacion = fechaContratacion;
    }
    
    

    @Override
    public abstract String consultarDatos();
    public void registrarAsistencia(){}
    
    
}
