/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.staff.dao;

import ulearn.staff.model.Usuario;

/**
 *
 * @author cesar
 */
public interface UsuarioDAO {
    Usuario iniciarSesion(String username, String password); //si inicia, modifica ese objeto 
    byte[] buscarFoto(int idUsuario);
    String hallarSalt(String username);
}
