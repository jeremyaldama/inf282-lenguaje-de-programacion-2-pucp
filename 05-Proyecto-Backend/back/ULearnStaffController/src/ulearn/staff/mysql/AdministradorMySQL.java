/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.staff.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.staff.dao.AdministradorDAO;
import ulearn.staff.model.Administrador;

/**
 *
 * @author cesar
 */
public class AdministradorMySQL implements AdministradorDAO{

    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Administrador administrador) {
        int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();  
                
            CallableStatement cStmt = con.prepareCall("{call INSERTAR_ADMINISTRADOR(?,?,?,?,?,?,?)}");
            cStmt.registerOutParameter("_id_usuario", java.sql.Types.INTEGER);
            cStmt.setString("_nombre",administrador.getNombre());
            cStmt.setString("_apellidoPaterno",administrador.getApellidoPaterno());
            cStmt.setString("_apellidoMaterno",administrador.getApellidoMaterno());
            cStmt.setString("_usuario", administrador.getUsuario());
            cStmt.setString("_password", administrador.getPassword());
            cStmt.setString("_salt", administrador.getSalt());
            cStmt.setString("_correo", administrador.getCorreoElectronico());
            resultado = cStmt.executeUpdate();
            administrador.setIdUsuario(cStmt.getInt("_id_administrador"));
            resultado = administrador.getIdUsuario();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int modificar(Administrador administrador) {
        
        int resultado=0;
        
        try{
            con = DBManager.getInstance().getConnection();  
                
            CallableStatement cStmt = con.prepareCall("{call ACTUALIZAR_ADMINISTRADOR(?,?,?,?,?,?,?)}");
            cStmt.setInt("_id_usuario",administrador.getIdUsuario());
            cStmt.setString("_nombre",administrador.getNombre());
            cStmt.setString("_apellidoPaterno",administrador.getApellidoPaterno());
            cStmt.setString("_apellidoMaterno",administrador.getApellidoMaterno());
            cStmt.setString("_usuario", administrador.getUsuario());
            cStmt.setString("_password", administrador.getPassword());
            cStmt.setString("_correo", administrador.getCorreoElectronico());
            resultado = cStmt.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<Administrador> listarTodos() {
         ArrayList<Administrador> administradores = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_ADMINISTRADORES()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Administrador administrador = new Administrador();
                administrador.setApellidoPaterno(rs.getString("apellido_Paterno"));
                administrador.setApellidoMaterno(rs.getString("apellido_Materno"));
                administrador.setNombre(rs.getString("nombre"));
                administradores.add(administrador);
            }
                
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return administradores;
        
    }

    @Override
    public int eliminar(int idAdministrador) {
        int resultado=0;
        
        try{
            con = DBManager.getInstance().getConnection();  
                
            CallableStatement cStmt = con.prepareCall("{call eliminar_Administrador(?)}");
            cStmt.setInt("_idAdministrador",idAdministrador);
            resultado = cStmt.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
    
    
    @Override
    public Administrador hallarAdministradorPorId(int idAdministrador){
        Administrador administrador = new Administrador();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call HALLAR_ADMINISTRADOR_ID(?)}");
            cs.setInt(1, idAdministrador);
            rs = cs.executeQuery();
            if(rs.next()){
                administrador.setIdUsuario(rs.getInt("id_Usuario"));
                administrador.setNombre(rs.getString("nombre_Administrador"));
                administrador.setApellidoPaterno(rs.getString("apellido_Paterno"));
                administrador.setApellidoMaterno(rs.getString("apellido_materno"));
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return administrador;
    } 
    
    
}
