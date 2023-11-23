package ulearn.academic.model;

import java.util.Date;

public class Semestre {
    private int idSemestre;
    private String semestre;
    private boolean esRegular;
    private Date fechaInicio;
    private Date fechaFin;
    
    public Semestre() {
    }

    public Semestre(String semestre, boolean esRegular, Date fechaInicio, Date fechaFin) {
        this.semestre = semestre;
        this.esRegular = esRegular;
        this.fechaInicio = fechaInicio;
        this.fechaFin = fechaFin;
    }

    public int getIdSemestre() {
        return idSemestre;
    }

    public void setIdSemestre(int idSemestre) {
        this.idSemestre = idSemestre;
    }
    
    public Date getFechaInicio() {
        return fechaInicio;
    }

    public void setFechaInicio(Date fechaInicio) {
        this.fechaInicio = fechaInicio;
    }

    public Date getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(Date fechaFin) {
        this.fechaFin = fechaFin;
    }

    public String getSemestre() {
        return semestre;
    }

    public void setSemestre(String semestre) {
        this.semestre = semestre;
    }

    public boolean isEsRegular() {
        return esRegular;
    }

    public void setEsRegular(boolean esRegular) {
        this.esRegular = esRegular;
    }
}
