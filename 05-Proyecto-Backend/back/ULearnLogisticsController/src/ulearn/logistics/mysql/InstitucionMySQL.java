/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package ulearn.logistics.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.logistics.dao.InstitucionDAO;
import ulearn.logistics.model.Institucion;

/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public class InstitucionMySQL implements InstitucionDAO {
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(Institucion institucion) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();  
            cs = con.prepareCall("{ call INSERTAR_INSTITUCION(?,?,?,?,?) }");
            
            cs.registerOutParameter("_id_institucion", java.sql.Types.INTEGER);
            cs.setString("_direccion", institucion.getDireccion());
            cs.setString("_nombre", institucion.getNombre());
            cs.setString("_telefono", institucion.getTelefono());
            cs.setInt("_aforo",institucion.getAforo());
            resultado = cs.executeUpdate();
            institucion.setIdInstitucion(cs.getInt("_id_institucion"));
            resultado = institucion.getIdInstitucion();
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
    public ArrayList<Institucion> listarTodas() {
        ArrayList<Institucion> instituciones = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_INSTITUCIONES_TODAS() }");
            rs = cs.executeQuery();
            while(rs.next()){
                Institucion institucion = new Institucion();
                
                institucion.setIdInstitucion(rs.getInt("id_institucion"));
                institucion.setDireccion(rs.getString("direccion"));
                institucion.setNombre(rs.getString("nombre"));
                institucion.setTelefono(rs.getString("telefono"));
                institucion.setAforo(rs.getInt("aforo"));
                instituciones.add(institucion);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return instituciones;
    }

    @Override
    public int eliminar(int idInstitucion) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_INSTITUCION(?)}");
            cs.setInt("_id_institucion", idInstitucion);
            resultado = cs.executeUpdate();
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
    public int modificar(Institucion institucion) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_INSTITUCION(?,?,?,?,?) }");
            
            cs.setInt("_id_institucion", institucion.getIdInstitucion());
            cs.setString("_direccion", institucion.getDireccion());
            cs.setString("_nombre", institucion.getNombre());
            cs.setString("_telefono", institucion.getTelefono());
            cs.setInt("_aforo", institucion.getAforo());
            resultado = cs.executeUpdate(); 
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
    
}
