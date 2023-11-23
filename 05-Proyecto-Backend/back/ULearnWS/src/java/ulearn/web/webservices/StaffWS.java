/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package ulearn.web.webservices;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import ulearn.staff.dao.AdministradorDAO;
import ulearn.staff.dao.EncargadoBibliotecaDAO;
import ulearn.staff.dao.UsuarioDAO;
import ulearn.staff.model.Administrador;
import ulearn.staff.model.EncargadoBiblioteca;
import ulearn.staff.model.Usuario;
import ulearn.staff.model.UsuarioSesion;
import ulearn.staff.mysql.AdministradorMySQL;
import ulearn.staff.mysql.EncargadoBibliotecaMySQL;
import ulearn.staff.mysql.UsuarioMySQL;

/**
 *
 * @author cesar
 */
@WebService(serviceName = "StaffWS")
public class StaffWS {

    private AdministradorDAO daoAdministrador = new AdministradorMySQL();
    private EncargadoBibliotecaDAO daoEncargado = new EncargadoBibliotecaMySQL();
    private UsuarioDAO daoUsuario = new UsuarioMySQL(); //solo para inicio de sesion
    
    @WebMethod(operationName = "iniciarSesion")
    public UsuarioSesion iniciarSesion(String username, String password){
        Usuario usuario = null;
        String salt = "";
        String pass = password;
        try{
            salt = daoUsuario.hallarSalt(username);
            if(!"".equals(salt) && salt != null){
                pass = Usuario.generarHashInicioSesion(password, salt);
            }
            usuario = daoUsuario.iniciarSesion(username, pass);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        if(usuario != null){
            UsuarioSesion sesion = new UsuarioSesion(usuario.getIdUsuario(), usuario.getTipoUsuario());
            return sesion;
        }
        return null;
    }
    
    @WebMethod(operationName = "buscarFotoPerfil")
    public byte[] buscarFotoPerfil(@WebParam(name = "idUsuario")int idUsuario){
        byte[] foto = null;
        try{
            foto = daoUsuario.buscarFoto(idUsuario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return foto;
    }
    
    @WebMethod(operationName = "listarEncargadosXUsuarioNombre")
    public ArrayList<EncargadoBiblioteca> listarEncargadosXUsuarioNombre(@WebParam(name = "usuarioNombre") String usuarioNombre) {
        ArrayList<EncargadoBiblioteca> encargados = new ArrayList<>();
        try{
            encargados = daoEncargado.listarUsuarioNombre(usuarioNombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return encargados;
    }
    
    @WebMethod(operationName = "insertarEncargado")
    public int insertarEncargado(@WebParam(name = "encargado") EncargadoBiblioteca encargado) {
        int resultado = 0;
        try{
            encargado.generarEncriptacionConSalt();
            resultado=daoEncargado.insertar(encargado);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarEncargado")
    public int actualizarEncargado(@WebParam(name = "encargado") EncargadoBiblioteca encargado) {
        int resultado = 0;
        try{
            String salt = daoUsuario.hallarSalt(encargado.getUsuario());
            if(!"".equals(salt) && salt != null){
                String hash = Usuario.generarHashInicioSesion(encargado.getPassword(), salt);
                encargado.setPassword(hash);
            }else{
                encargado.generarEncriptacionConSalt();
            }
            resultado=daoEncargado.modificar(encargado);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodosEncargados")
    public ArrayList<EncargadoBiblioteca> listarTodosEncargados() {
        ArrayList<EncargadoBiblioteca> encargados = new ArrayList<>();
        try{
            encargados = daoEncargado.listarTodos();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return encargados;
    }
    
    @WebMethod(operationName = "eliminarEncargado")
    public int eliminarEncargado(@WebParam(name = "idEncargado") int id) {
        int resultado = 0;
        try{
            resultado = daoEncargado.eliminar(id);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
     @WebMethod(operationName = "hallarEncargadoPorId")
    public EncargadoBiblioteca hallarEncargadoPorId(@WebParam(name = "idEncargado")int idEncargado){
        EncargadoBiblioteca encargado = new EncargadoBiblioteca();
        try{
            encargado = daoEncargado.hallarEncargadoPorId(idEncargado);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return encargado;
    }
    
    @WebMethod(operationName = "insertarAdministrador")
    public int insertarAdministrador(@WebParam(name = "administrador") Administrador admin) {
        int resultado = 0;
        try{
            admin.generarEncriptacionConSalt();
            resultado=daoAdministrador.insertar(admin);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarTodosAdministradores")
    public ArrayList<Administrador> listarTodosAdministradores() {
        ArrayList<Administrador> administradores = new ArrayList<>();
        try{
            administradores = daoAdministrador.listarTodos();
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return administradores;
    }
    
    @WebMethod(operationName = "eliminarAdministrador")
    public int eliminarAdministrador(@WebParam(name = "idAdministrador") int id) {
        int resultado = 0;
        try{
            resultado = daoAdministrador.eliminar(id);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "hallarAdministradorPorId")
    public Administrador hallarAdministradorPorId(@WebParam(name = "idAdministrador")int idAdministrador){
        Administrador administrador = new Administrador();
        try{
            administrador = daoAdministrador.hallarAdministradorPorId(idAdministrador);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return administrador;
    }
}
