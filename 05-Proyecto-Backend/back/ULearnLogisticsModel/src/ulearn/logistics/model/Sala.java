package ulearn.logistics.model;
public class Sala extends Espacio{
    
    private String tipoSala;
    private boolean tieneSistemaAudio;

    public Sala(String tipoSala, boolean tieneSistemaAudio, int aforo, String nombre) {
        super(aforo, nombre);
        this.tipoSala = tipoSala;
        this.tieneSistemaAudio = tieneSistemaAudio;
    }
    
    public Sala(){}; 

    public String getTipoSala() {
        return tipoSala;
    }

    public void setTipoSala(String tipoSala) {
        this.tipoSala = tipoSala;
    }

    public boolean isTieneSistemaAudio() {
        return tieneSistemaAudio;
    }

    public void setTieneSistemaAudio(boolean tieneSistemaAudio) {
        this.tieneSistemaAudio = tieneSistemaAudio;
    }
    
    public void imprimirInformacion(){
        System.out.println(getIdEspacio() + " - " + getTipoSala()+ " - " + getNombre() + " " + getAforo() + " - " + isTieneSistemaAudio());
    }

}
