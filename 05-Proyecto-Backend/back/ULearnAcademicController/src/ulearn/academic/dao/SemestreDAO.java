/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package ulearn.academic.dao;

import java.util.ArrayList;
import ulearn.academic.model.Semestre;

/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public interface SemestreDAO {
    int insertar(Semestre semestre);
    int modificar(Semestre semestre);
    int eliminar(int idSemestre);
    ArrayList<Semestre> listarTodos();
    ArrayList<Semestre> listarPorAlumno(int idAlumno);
}
