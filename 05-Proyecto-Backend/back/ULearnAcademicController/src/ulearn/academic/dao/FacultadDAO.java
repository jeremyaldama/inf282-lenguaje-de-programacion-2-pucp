/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.academic.dao;

import java.util.ArrayList;
import ulearn.academic.model.Facultad;

/**
 *
 * @author cesar
 */
public interface FacultadDAO {
    int insertar(Facultad facultad);
    ArrayList<Facultad> listarTodas();
    int eliminar(int idFacultad);
    int modificar(Facultad facultad);
}
