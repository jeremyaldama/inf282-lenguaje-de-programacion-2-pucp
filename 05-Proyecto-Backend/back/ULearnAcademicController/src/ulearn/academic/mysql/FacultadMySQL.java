/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.academic.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.academic.dao.FacultadDAO;
import ulearn.academic.model.Facultad;

/**
 *
 * @author cesar
 */
public class FacultadMySQL implements FacultadDAO{
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(Facultad facultad) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();  
            cs = con.prepareCall("{ call INSERTAR_FACULTAD(?,?,?,?) }");
            
            cs.registerOutParameter("_id_facultad", java.sql.Types.INTEGER);
            cs.setString("_nombre",facultad.getNombre());
            cs.setString("_anexo", facultad.getAnexo());
            cs.setInt("_inscritos", facultad.getInscritos());
            resultado = cs.executeUpdate();
            facultad.setIdFacultad(cs.getInt("_id_facultad"));
            resultado = facultad.getIdFacultad();
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
    public ArrayList<Facultad> listarTodas() {
       ArrayList<Facultad> facultades = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_FACULTAD_TODAS() }");
            rs = cs.executeQuery();
            while(rs.next()){
                Facultad facultad = new Facultad();
                
                facultad.setIdFacultad(rs.getInt("id_facultad"));
                facultad.setNombre(rs.getString("nombre"));
                facultad.setAnexo(rs.getString("anexo"));
                facultad.setInscritos(rs.getInt("inscritos"));
                facultades.add(facultad);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return facultades;
    }

    @Override
    public int eliminar(int idFacultad) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_FACULTAD(?)}");
            cs.setInt("_idFacultad", idFacultad);
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
    public int modificar(Facultad facultad) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_FACULTAD(?,?,?,?,?) }");
            
            cs.setInt("_id_facultad", facultad.getIdFacultad());
            cs.setString("_nombre", facultad.getNombre());
            cs.setString("_anexo", facultad.getAnexo());
            cs.setInt("_inscritos", facultad.getInscritos());
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
