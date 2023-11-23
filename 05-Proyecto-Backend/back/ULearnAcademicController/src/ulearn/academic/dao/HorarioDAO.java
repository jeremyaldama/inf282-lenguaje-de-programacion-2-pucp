/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.academic.dao;

import java.util.ArrayList;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Docente;
import ulearn.academic.model.Horario;

/**
 *
 * @author cesar
 */
public interface HorarioDAO {
    int insertar(Horario horario);
    int modificar(Horario horario);
    int eliminar(int idHorario);
    ArrayList<Horario> listarTodos();
    ArrayList<Horario> listarPorAlumno(int idAlumno);
    ArrayList<Horario> listarPorDocente(int idDocente);
    ArrayList<Horario> listarPorCurso(int idCurso);
    int agregarAlumnoHorario(Alumno alumno, Horario horario); //para tener info de curso
    int agregarDocenteHorario(int idDocente, int idHorario);
    ArrayList<Alumno> listarAlumnosDeHorario(int idHorario);
    ArrayList<Docente> listarDocentesDeHorario(int idHorario);
    int conseguirTotalizados(Horario horario, Curso curso);
}
