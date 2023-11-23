
import java.util.ArrayList;

public abstract class Espacio {
    
    private int aforo;
    private String nombre;
    private ArrayList<Evento> eventos;

    public Espacio(int aforo, String nombre) {
        this.aforo = aforo;
        this.nombre = nombre;
    }

    public int getAforo() {
        return aforo;
    }

    public void setAforo(int aforo) {
        this.aforo = aforo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public ArrayList<Evento> getEventos() {
        return eventos;
    }

    public void setEventos(ArrayList<Evento> eventos) {
        this.eventos = eventos;
    }
    
    
    
}
