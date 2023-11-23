package ulearn.logistics.model;

import java.util.ArrayList;
import ulearn.academic.model.Horario;



public class Aula extends Espacio{
    
    private boolean tienePizarraInteligente;
    private boolean tieneProyector;
    private ArrayList<Horario> horarios;
    
    public Aula(boolean tienePizarraInteligente, boolean tieneProyector, int aforo, String nombre) {
        super(aforo, nombre);
        this.tienePizarraInteligente = tienePizarraInteligente;
        this.tieneProyector = tieneProyector;
    }
    
    public Aula(){};

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

    public ArrayList<Horario> getHorarios() {
        return horarios;
    }

    public void setHorarios(ArrayList<Horario> horarios) {
        this.horarios = horarios;
    }
    
    public void imprimirInformacion(){
        System.out.println(getIdEspacio() + " - " + getTienePizarraInteligente()+ " - " + getTieneProyector() + " - " + getNombre() + " " + getAforo());
    }
    
}
