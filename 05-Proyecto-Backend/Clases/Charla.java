
import java.time.LocalTime;
import java.util.Date;

public class Charla extends Evento {
    
    private String ponente;

    public Charla(String ponente, String organizador, String nombre, Date fecha, LocalTime horaInicio, LocalTime horaFin, boolean esGratis, Espacio espacio) {
        super(organizador,nombre, fecha, horaInicio, horaFin, esGratis, espacio);
        this.ponente = ponente;
    }

    public String getPonente() {
        return ponente;
    }

    public void setPonente(String ponente) {
        this.ponente = ponente;
    }
    
    
    
}
