

import java.time.LocalTime;
import java.util.Date;

public abstract class Evento {
    
    private String organizador;
    private String nombre;
    private Date fecha;
    private LocalTime horaInicio;
    private LocalTime horaFin;
    private boolean esGratis;
	private Espacio espacio;

    public Evento(String organizador,String nombre, Date fecha, LocalTime horaInicio, LocalTime horaFin, boolean esGratis, Espacio espacio) {
        this.organizador = organizador;
        this.fecha = fecha;
        this.horaInicio = horaInicio;
        this.horaFin = horaFin;
        this.esGratis = esGratis;
		this.espacio = espacio;
		this.nombre = nombre;
    }

    public String getOrganizador() {
        return organizador;
    }

    public void setOrganizador(String organizador) {
        this.organizador = organizador;
    }
	public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
	
    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public LocalTime getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(LocalTime horaInicio) {
        this.horaInicio = horaInicio;
    }

    public LocalTime getHoraFin() {
        return horaFin;
    }

    public void setHoraFin(LocalTime horaFin) {
        this.horaFin = horaFin;
    }

    public boolean isEsGratis() {
        return esGratis;
    }

    public void setEsGratis(boolean esGratis) {
        this.esGratis = esGratis;
    }
    
    
    
    
}
