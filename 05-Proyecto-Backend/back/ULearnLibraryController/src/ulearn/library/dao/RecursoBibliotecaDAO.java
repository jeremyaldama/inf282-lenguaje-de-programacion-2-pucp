/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.library.dao;

import java.util.ArrayList;
import ulearn.library.model.RecursoBiblioteca;

public interface RecursoBibliotecaDAO {
    ArrayList<RecursoBiblioteca> listarPorTituloAutorConFiltros(String tituloAutor,
            int disponibilidad,int idBiblioteca, char tipoRecurso);
}
