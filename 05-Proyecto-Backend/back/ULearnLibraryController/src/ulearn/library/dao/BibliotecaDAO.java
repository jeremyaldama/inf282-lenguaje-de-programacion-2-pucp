/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.library.dao;

import java.util.ArrayList;
import ulearn.library.model.Biblioteca;

/**
 * @author USER
 */

public interface BibliotecaDAO {
    int agregarBiblioteca(Biblioteca biblioteca);
    ArrayList<Biblioteca> listarBiblioteca();
    ArrayList<Biblioteca> listarPorIdEncargado(int idEncargado);
    int eliminarBiblioteca(int idBiblioteca);
    int actualizarBiblioteca(Biblioteca biblioteca);    
}
