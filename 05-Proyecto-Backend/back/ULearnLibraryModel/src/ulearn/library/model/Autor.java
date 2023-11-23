/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.library.model;

import java.util.ArrayList;

/**
 *
 * @author cesar
 */
public class Autor {
    private int idAutor;
    private String nombre;
    private String nacionalidad;
    private ArrayList<RecursoBiblioteca> autoria;

    public Autor(String nombre, String nacionalidad) {
        this.nombre = nombre;
        this.nacionalidad = nacionalidad;
    }
    
    public Autor(){}

    public ArrayList<RecursoBiblioteca> getAutoria() {
        return autoria;
    }

    public void setAutoria(ArrayList<RecursoBiblioteca> autoria) {
        this.autoria = autoria;
    }
    
    
    public int getIdAutor() {
        return idAutor;
    }

    public void setIdAutor(int idAutor) {
        this.idAutor = idAutor;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getNacionalidad() {
        return nacionalidad;
    }

    public void setNacionalidad(String nacionalidad) {
        this.nacionalidad = nacionalidad;
    }
}
