package ulearn.academic.model;

import java.util.ArrayList;


public class Facultad {
    private int idFacultad;
    private String nombre;
    private String anexo;
    private int inscritos;
    private ArrayList<Carrera> carreras;

    public Facultad() {
    }

    public Facultad(String nombre, String anexo, int inscritos) {
        this.nombre = nombre;
        this.anexo = anexo;
        this.inscritos = inscritos;
    }

    public int getIdFacultad() {
        return idFacultad;
    }

    public void setIdFacultad(int idFacultad) {
        this.idFacultad = idFacultad;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getAnexo() {
        return anexo;
    }

    public void setAnexo(String anexo) {
        this.anexo = anexo;
    }

    public int getInscritos() {
        return inscritos;
    }

    public void setInscritos(int inscritos) {
        this.inscritos = inscritos;
    }

    public ArrayList<Carrera> getCarreras() {
        return carreras;
    }

    public void setCarreras(ArrayList<Carrera> carreras) {
        this.carreras = carreras;
    }
    
    
    public void mostrarDatos() {
        System.out.println(nombre + " " + this.anexo + " " + this.inscritos);
    }
    
}
