/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.staff.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Docente;
import ulearn.config.DBManager;
import ulearn.staff.dao.UsuarioDAO;
import ulearn.staff.model.Administrador;
import ulearn.staff.model.EncargadoBiblioteca;
import ulearn.staff.model.Usuario;

/**
 *
 * @author cesar
 */
public class UsuarioMySQL implements UsuarioDAO{
    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    
    @Override
    
    public Usuario iniciarSesion(String username, String password) {
        Usuario usuario = null;
        try{
            con = DBManager.getInstance().getConnection();  
            cs = con.prepareCall("{call INICIAR_SESION(?,?)}");
            cs.setString("_pass", password);
            cs.setString("_usuario", username);
            rs = cs.executeQuery();
            while(rs.next()){
                char tipo = rs.getString("tipo_usuario").charAt(0);
                switch (tipo){
                    case 'D':
                        usuario = new Docente();
                        break;
                    case 'A':
                        usuario = new Administrador();
                        break;
                    case 'E':
                        usuario = new Alumno();
                        break;
                    case 'B':
                        usuario = new EncargadoBiblioteca();
                        break;
                }
                if(usuario != null){
                    usuario.setIdUsuario(rs.getInt("id_usuario"));
                    usuario.setTipoUsuario(tipo);
                    usuario.setNombre(rs.getString("nombre"));
                    usuario.setApellidoMaterno(rs.getString("apellido_materno"));
                    usuario.setApellidoPaterno(rs.getString("apellido_paterno"));
                    usuario.setCorreoElectronico(rs.getString("correo_electronico"));
                }
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return usuario;
    }

    @Override
    public byte[] buscarFoto(int idUsuario) {
        byte[] foto = null;
        try{
            con = DBManager.getInstance().getConnection();  
            cs = con.prepareCall("{call BUSCAR_FOTO_PERFIL(?)}");
            cs.setInt("_id_usuario",idUsuario);
            rs = cs.executeQuery();
            if(rs.next()){
                foto = rs.getBytes("foto_perfil");
            }  
        }catch(Exception ex){System.out.println(ex.getMessage());}
        return foto;        
    }
    
    @Override
    public String hallarSalt(String username) {
        String salt = "";
        try{
            con = DBManager.getInstance().getConnection();  
            cs = con.prepareCall("{call HALLAR_SALT(?)}");
            cs.setString("_username", username);
            rs = cs.executeQuery();
            if(rs.next()){
                salt = rs.getString("salt");
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return salt;
    }
    
}
