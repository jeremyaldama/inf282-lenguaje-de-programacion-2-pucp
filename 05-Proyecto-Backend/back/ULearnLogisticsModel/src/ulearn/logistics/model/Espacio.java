package ulearn.logistics.model;
import java.util.ArrayList;

public abstract class Espacio {
    private static int identificadorEspacio = 1;
    private int idEspacio;
    private int aforo;
    private Institucion institucion;
    private String nombre;
    private ArrayList<Evento> eventos;
    
    public Espacio(){}; 

    public Espacio(int aforo, String nombre) {
        this.aforo = aforo;
        this.nombre = nombre;
        this.idEspacio = identificadorEspacio;
	identificadorEspacio++;
    }

    public static int getIdentificadorEspacio() {
        return identificadorEspacio;
    }

    public static void setIdentificadorEspacio(int identificadorEspacio) {
        Espacio.identificadorEspacio = identificadorEspacio;
    }

    public Institucion getInstitucion() {
        return institucion;
    }

    public void setInstitucion(Institucion institucion) {
        this.institucion = institucion;
    }
    
    

    public int getIdEspacio() {
        return idEspacio;
    }

    public void setIdEspacio(int idEspacio) {
        this.idEspacio = idEspacio;
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
