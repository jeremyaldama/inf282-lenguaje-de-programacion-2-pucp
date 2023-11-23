

public class Aula extends Espacio{
    
    private boolean tienePizarraInteligente;
    private boolean tieneProyector;

    public Aula(boolean tienePizarraInteligente, boolean tieneProyector, int aforo, String nombre) {
        super(aforo, nombre);
        this.tienePizarraInteligente = tienePizarraInteligente;
        this.tieneProyector = tieneProyector;
    }

    public boolean getTienePizarraInteligente() {
        return tienePizarraInteligente;
    }

    public void setTienePizarraInteligente(boolean tienePizarraInteligente) {
        this.tienePizarraInteligente = tienePizarraInteligente;
    }

    public boolean getTieneProyector() {
        return tieneProyector;
    }

    public void setTieneProyector(boolean tieneProyector) {
        this.tieneProyector = tieneProyector;
    }
    
    
    
    
}
