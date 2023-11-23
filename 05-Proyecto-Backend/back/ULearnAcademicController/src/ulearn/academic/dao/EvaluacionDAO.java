/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.academic.dao;

import java.util.ArrayList;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Evaluacion;
import ulearn.academic.model.Semestre;


public interface EvaluacionDAO {
    int insertar(Evaluacion evaluacion,int fidAlumnoCursoSemestre);
    int modificar(Evaluacion evaluacion);
    int eliminar(int idEvaluacion);
    ArrayList<Evaluacion> listarPorCursoYSemestre(Curso curso);
    ArrayList<Evaluacion> listarEvaluacionxAlumno(Alumno alumno);
}
