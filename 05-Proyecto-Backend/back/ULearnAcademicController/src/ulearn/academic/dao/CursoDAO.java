/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.academic.dao;

import java.util.ArrayList;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Semestre;

/**
 *
 * @author Eilyn Davila
 */
public interface CursoDAO {
    
    int insertarCurso(Curso curso);
    int eliminarCurso(int idCurso);
    int modificarNombreCurso(int idCurso,String nombre);
    ArrayList<Alumno> listarAlumnosCurso(int idCurso);
    ArrayList<Curso> listarTodos();
    int agregarCursoASemestre(int idCurso, int idSemestre);
    int agregarCursoACarrera(int idCurso, int idCarrera);
    ArrayList<Curso> listarCursosCodigoNombre(String codigoNombre);
    int modificar(Curso curso);
}
