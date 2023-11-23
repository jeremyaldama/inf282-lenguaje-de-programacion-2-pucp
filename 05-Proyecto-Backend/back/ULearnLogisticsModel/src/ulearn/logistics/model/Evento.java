
package ulearn.logistics.model;
import java.time.LocalTime;
import java.util.Date;

public abstract class Evento {
    private static int identificadorEvento = 1;
    private int idEvento;
    private String organizador;
    private String nombre;
    private Date fecha;
    private LocalTime horaInicio;
    private LocalTime horaFin;
    private boolean esGratis;
    private Espacio espacio;
    private int inscritos; 
    
    public Evento(String organizador,String nombre, Date fecha, LocalTime horaInicio, LocalTime horaFin, boolean esGratis, Espacio espacio) {
        this.organizador = organizador;
        this.fecha = fecha;
        this.horaInicio = horaInicio;
        this.horaFin = horaFin;
        this.esGratis = esGratis;
	this.espacio = espacio;
	this.nombre = nombre;
        this.idEvento = identificadorEvento;
        identificadorEvento++;
    }
    
    public Evento(){};

    public int getIdEvento() {
        return idEvento;
    }

    public void setIdEvento(int idEvento) {
        this.idEvento = idEvento;
    }

    public Espacio getEspacio() {
        return espacio;
    }

    public void setEspacio(Espacio espacio) {
        this.espacio = espacio;
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
    
    public int getInscritos() {
        return inscritos;
    }

    public void setInscritos(int inscritos) {
        this.inscritos = inscritos;
    }

}
