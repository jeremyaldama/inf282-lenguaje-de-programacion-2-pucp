/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.academic.dao;

import java.util.ArrayList;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Reclamo;
import ulearn.academic.model.Semestre;

public interface ReclamoDAO {
    int insertar(Reclamo reclamo);
    int modificar(Reclamo reclamo);
    int eliminar(int idReclamo);
    ArrayList<Reclamo> listarPorAlumnoYSemestre(Alumno idAlumno);
    ArrayList<Reclamo> listarPorCursoYSemestre(Curso curso);
}
