/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.library.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.library.dao.BibliotecaDAO;
import ulearn.library.model.Biblioteca;

/**
 * @author USER
 */

public class BibliotecaMySQL implements BibliotecaDAO{
    
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int agregarBiblioteca(Biblioteca biblioteca) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();  
            cs = con.prepareCall("{ call INSERTAR_BIBLIOTECA(?,?,?,?,?) }");
            cs.registerOutParameter("_id_biblioteca", java.sql.Types.INTEGER);
            cs.setInt("_fid_encargado_biblioteca",biblioteca.getIdEncargado());
            cs.setInt("_fid_institucion",biblioteca.getIdInstitucion());
            cs.setString("_nombre",biblioteca.getNombre());
            cs.setInt("_capacidad",biblioteca.getCapacidad());
            resultado = cs.executeUpdate();
            biblioteca.setIdBiblioteca(cs.getInt("_id_biblioteca"));
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
    public ArrayList<Biblioteca> listarBiblioteca() {
        ArrayList<Biblioteca> bibliotecas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_BIBLIOTECAS_TODAS() }");
            rs = cs.executeQuery();
            while(rs.next()){
                Biblioteca biblioteca = new Biblioteca();
                biblioteca.setIdBiblioteca(rs.getInt("id_biblioteca"));
                biblioteca.setNombre(rs.getString("nombre_biblioteca"));
                biblioteca.setCapacidad(rs.getInt("capacidad"));
                bibliotecas.add(biblioteca);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return bibliotecas;
    }

    @Override
    public int eliminarBiblioteca(int idBiblioteca) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_BIBLIOTECA(?)}");
            cs.setInt("_id_biblioteca", idBiblioteca);
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
    public int actualizarBiblioteca(Biblioteca biblioteca) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_BIBLIOTECA(?,?,?,?) }");
            cs.setInt("_id_biblioteca",biblioteca.getIdBiblioteca()); 
            cs.setInt("_fid_encargado_biblioteca",biblioteca.getIdEncargado());
            cs.setString("_nombre",biblioteca.getNombre());
            cs.setInt("_capacidad",biblioteca.getCapacidad());
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
    public ArrayList<Biblioteca> listarPorIdEncargado(int idEncargado) {
        ArrayList<Biblioteca> bibliotecas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_BIBLIOTECAS_X_ID_ENCARGADO(?) }");
            cs.setInt("_id_encargado",idEncargado);
            rs = cs.executeQuery();
            while(rs.next()){
                Biblioteca biblioteca = new Biblioteca();
                biblioteca.setIdBiblioteca(rs.getInt("id_biblioteca"));
                biblioteca.setNombre(rs.getString("nombre"));
                biblioteca.setCapacidad(rs.getInt("capacidad"));
                biblioteca.setIdEncargado(rs.getInt("fid_encargado_biblioteca"));
                biblioteca.setIdInstitucion(rs.getInt("fid_institucion"));
                bibliotecas.add(biblioteca);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return bibliotecas;
    }
    
}
