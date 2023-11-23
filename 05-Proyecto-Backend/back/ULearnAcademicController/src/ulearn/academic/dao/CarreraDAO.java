/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.academic.dao;

import java.util.ArrayList;
import ulearn.academic.model.Carrera;


/**
 *
 * @author cesar
 */
public interface CarreraDAO {
    int insertar(Carrera carrera);
    int modificar(Carrera carrera);
    int eliminar(int idCarrera);
    ArrayList<Carrera> listarTodas();
    ArrayList<Carrera> listarPorFacultad(int idFacultad);
}
