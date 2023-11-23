/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package ulearn.academic.dao;

import java.util.ArrayList;
import ulearn.academic.model.CursoXAlumnoXSemestre;

/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public interface CursoXAlumnoXSemestreDAO {
    ArrayList<CursoXAlumnoXSemestre> listarPorAlumnoSemestre(int idAlumno, int idSemestre);
}
