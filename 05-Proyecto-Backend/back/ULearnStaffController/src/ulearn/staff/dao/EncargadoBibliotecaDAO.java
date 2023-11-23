/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.staff.dao;

import java.util.ArrayList;
import ulearn.staff.model.EncargadoBiblioteca;

/**
 *
 * @author cesar
 */
public interface EncargadoBibliotecaDAO {
    public int insertar(EncargadoBiblioteca encargado);
    public int modificar(EncargadoBiblioteca encargado);
    public ArrayList<EncargadoBiblioteca> listarTodos();
    public ArrayList<EncargadoBiblioteca> listarUsuarioNombre(String usuarioNombre);
    public int eliminar(int idEncargado);
    public EncargadoBiblioteca hallarEncargadoPorId(int idEncargado);
}
