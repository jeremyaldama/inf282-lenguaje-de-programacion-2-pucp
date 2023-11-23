/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.academic.model;

/**
 *
 * @author cesar
 */
public class HistorialAcademico {
    private Alumno alumno;
    private int cantCurAprobados;
    private int cantCurTotal;
    private double cantCredAprob;
    private double cantCredTotal;
    private int nivelAcademico;

    public Alumno getAlumno() {
        return alumno;
    }

    public void setAlumno(Alumno alumno) {
        this.alumno = alumno;
    }

    public int getCantCurAprobados() {
        return cantCurAprobados;
    }

    public void setCantCurAprobados(int cantCurAprobados) {
        this.cantCurAprobados = cantCurAprobados;
    }

    public int getCantCurTotal() {
        return cantCurTotal;
    }

    public void setCantCurTotal(int cantCurTotal) {
        this.cantCurTotal = cantCurTotal;
    }

    public double getCantCredAprob() {
        return cantCredAprob;
    }

    public void setCantCredAprob(double cantCredAprob) {
        this.cantCredAprob = cantCredAprob;
    }

    public double getCantCredTotal() {
        return cantCredTotal;
    }

    public void setCantCredTotal(double cantCredTotal) {
        this.cantCredTotal = cantCredTotal;
    }

    public int getNivelAcademico() {
        return nivelAcademico;
    }

    public void setNivelAcademico(int nivelAcademico) {
        this.nivelAcademico = nivelAcademico;
    }
    
}
