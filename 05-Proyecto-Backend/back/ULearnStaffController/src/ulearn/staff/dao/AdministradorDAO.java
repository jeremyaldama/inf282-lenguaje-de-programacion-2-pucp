/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.staff.dao;

import java.util.ArrayList;
import ulearn.staff.model.Administrador;

/**
 *
 * @author cesar
 */
public interface AdministradorDAO {
    public int insertar(Administrador administrador);
    public int modificar(Administrador administrador);
    public ArrayList<Administrador> listarTodos();
    public int eliminar(int idAdministrador);
    public Administrador hallarAdministradorPorId(int idAdministrador);
}
