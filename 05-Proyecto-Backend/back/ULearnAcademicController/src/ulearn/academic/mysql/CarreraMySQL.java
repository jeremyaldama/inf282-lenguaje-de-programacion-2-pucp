/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.academic.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import ulearn.academic.dao.CarreraDAO;
import ulearn.academic.model.Carrera;
import ulearn.academic.model.Facultad;
import ulearn.config.DBManager;

/**
 *
 * @author cesar
 */
public class CarreraMySQL implements CarreraDAO {
    private String sql;
    private Connection con;
    private ResultSet rs; //cursor
    private CallableStatement cs;
    @Override
    public int insertar(Carrera carrera) {
        int resultado = 0, acreditada = carrera.isEsAcreditada() ? 1 : 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_CARRERA(?,?,?,?,?,?)} ");
            cs.registerOutParameter("_id_carrera", java.sql.Types.INTEGER);
            cs.setInt("_id_facultad", carrera.getFacultad().getIdFacultad());
            cs.setString("_nombre",carrera.getNombre());
            cs.setInt("_acreditada", acreditada);
            cs.setDate("_ultimo_cambio_malla", new java.sql.Date(carrera.getCambioMalla().getTime()));
            cs.setDouble("_creditos", carrera.getCreditos());
            resultado = cs.executeUpdate();
            carrera.setIdCarrera(cs.getInt("_id_carrera"));
            resultado = carrera.getIdCarrera();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
            System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int modificar(Carrera carrera) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_CARRERA(?,?,?,?,?)}");
            cs.setInt("_id_carrera", carrera.getIdCarrera());
            cs.setDate("_ultimo_cambio_malla", new java.sql.Date(carrera.getCambioMalla().getTime()));
            int acreditada = carrera.isEsAcreditada() ? 1 : 0;
            cs.setInt("_acreditada", acreditada);
            cs.setDouble("_creditos", carrera.getCreditos());
            cs.setString("_nombre", carrera.getNombre());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
            System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(int idCarrera) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call ELIMINAR_CARRERA(?)}");
            cs.setInt("_id_carrera", idCarrera);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
            System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<Carrera> listarTodas() {
        ArrayList<Carrera> carreras = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_CARRERAS_TODAS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Carrera carrera = new Carrera();
                carrera.setIdCarrera(rs.getInt("id_carrera"));
                carrera.setNombre(rs.getString("nombre_carrera"));
                carrera.setCreditos(rs.getDouble("creditos"));
                carrera.setCambioMalla(new java.util.Date(rs.getDate("ultimo_cambio_malla").getTime()));
                boolean b = (rs.getInt("acreditada") == 1);
                carrera.setEsAcreditada(b);
                carrera.setFacultad(new Facultad());
                carrera.getFacultad().setIdFacultad(rs.getInt("id_facultad"));
                carrera.getFacultad().setNombre("nombre_facultad");
                carreras.add(carrera);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return carreras;
    }

    @Override
    public ArrayList<Carrera> listarPorFacultad(int idFacultad) {
        ArrayList<Carrera> carreras = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_CARRERAS_FACULTAD(?)}");
            cs.setInt("_id_facultad", idFacultad);
            rs = cs.executeQuery();
            while(rs.next()){
                Carrera carrera = new Carrera();
                carrera.setIdCarrera(rs.getInt("id_carrera"));
                carrera.setNombre("nombre_carrera");
                carrera.setCambioMalla(new java.util.Date(rs.getDate("ultimo_cambio_malla").getTime()));
                boolean b = (rs.getInt("acreditada") == 1);
                carrera.setEsAcreditada(b);
                carrera.setFacultad(new Facultad());
                carrera.getFacultad().setIdFacultad(rs.getInt("id_facultad"));
                carrera.getFacultad().setNombre("nombre_facultad");
                carreras.add(carrera);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return carreras;
    }
    
}
