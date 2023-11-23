package ulearn.logistics.model;
import java.time.LocalTime;
import java.util.Date;


public class Taller extends Evento{
    
    private String areaInteres;

    public Taller(String areaInteres, String organizador,String nombre, Date fecha, LocalTime horaInicio, LocalTime horaFin, boolean esGratis,Espacio espacio) {
        super(organizador,nombre, fecha, horaInicio, horaFin, esGratis,espacio);
        this.areaInteres = areaInteres;
    }
    
    public Taller(){};

    public String getAreaInteres() {
        return areaInteres;
    }

    public void setAreaInteres(String areaInteres) {
        this.areaInteres = areaInteres;
    }
    
    public void imprimirInformacion(){
        System.out.println(getIdEvento() + " - " + getNombre()+ " - " + getOrganizador() + " - " + getFecha() + " - " + getHoraInicio() + " - " + getHoraFin() + " - "+ isEsGratis());
    }
    
}
