/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.academic.dao;

import java.util.ArrayList;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Docente;

/**
 *
 * @author Eilyn Davila
 */
public interface DocenteDAO {
    
    int agregarDocente(Docente docente);
    ArrayList<Docente> listarDocentes();
    int eliminarDocente(int idDocente);
    int actualizarCorreo(String correo,int idDocente);
    int actualizarContrasenha(String password,int idDocente);
    int actualizarUsuario(String user,int idDocente);
    int actualizarTipoDocente(String tipoDocente,int idDocente);
    ArrayList<Curso> listarCursosDocente(int idDocente);
    ArrayList<Docente> listarDocentesXNombre(String nombre);
    Docente hallarDocentePorId(int idDocente);
    int modificar(Docente docente);
    int modificarPerfil(Docente docente);
}
