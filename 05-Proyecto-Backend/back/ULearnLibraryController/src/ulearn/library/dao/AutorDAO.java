/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.library.dao;

import java.util.ArrayList;
import ulearn.library.model.Autor;

/**
 *
 * @author cesar
 */
public interface AutorDAO {
    int insertar(Autor autor);
    int eliminar(int idAutor);
    int modificar(Autor autor);
    ArrayList<Autor> listarTodos();
    ArrayList<Autor> listarPorNombre(String nombre);
    ArrayList<Autor> listarPorIdRecurso(int idRecurso);
}
