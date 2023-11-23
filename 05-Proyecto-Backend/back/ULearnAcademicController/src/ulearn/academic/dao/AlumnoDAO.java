/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.academic.dao;

import java.util.ArrayList;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Curso;

/**
 *
 * @author Eilyn Davila
 */
public interface AlumnoDAO {

    int insertarAlumno(Alumno alumno);
    int eliminarAlumno(int idAlumno);
    int actualizarCorreo(String correo,int idAlumno);
    int actualizarContrasenha(String password,int idAlumno);
    int actualizarUsuario(String user,int idAlumno);
    ArrayList<Curso> listarCursosAlumnos(int idAlumno);
    ArrayList<Alumno> listarAlumnosXCodigoNombre(String codigoNombre);
    Alumno hallarAlumnoPorId(int idAlumno);
    int modificar(Alumno alumno);
    int modificarPerfil(Alumno alumno);
    //historial academico
}
