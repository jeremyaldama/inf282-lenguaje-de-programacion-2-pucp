/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package ulearn.academic.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Time;
import java.util.ArrayList;
import ulearn.academic.dao.SemestreDAO;
import ulearn.academic.model.Semestre;
import ulearn.config.DBManager;

/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public class SemestreMySQL implements SemestreDAO {
    private String sql;
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Semestre semestre) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_SEMESTRE(?,?,?,?,?)} ");
            cs.registerOutParameter("_id_semestre", java.sql.Types.INTEGER);
            cs.setString("_semestre", semestre.getSemestre());
            cs.setInt("_es_regular", semestre.isEsRegular()? 1 : 0);
            cs.setDate("_fecha_inicio", new java.sql.Date(semestre.getFechaInicio().getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(semestre.getFechaFin().getTime()));
            resultado = cs.executeUpdate();
            semestre.setIdSemestre(cs.getInt("_id_semestre"));
            resultado = semestre.getIdSemestre();
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
    public int modificar(Semestre semestre) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_SEMESTRE(?,?,?,?)}");
            cs.setInt("_id_semestre", semestre.getIdSemestre());
            cs.setInt("_es_regular", semestre.isEsRegular()? 1:0);
            cs.setDate("_fecha_inicio", new java.sql.Date(semestre.getFechaInicio().getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(semestre.getFechaFin().getTime()));
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
    public int eliminar(int idSemestre) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call ELIMINAR_SEMESTRE(?)}");
            cs.setInt("_id_semestre", idSemestre);
            cs.executeUpdate();
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
    public ArrayList<Semestre> listarTodos() {
        ArrayList<Semestre> semestres = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_SEMESTRES_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Semestre semestre = new Semestre();
                semestre.setEsRegular((rs.getInt("es_regular") == 1));
                semestre.setFechaInicio(rs.getDate("fecha_inicio"));
                semestre.setFechaFin(rs.getDate("fecha_fin"));
                semestre.setSemestre(rs.getString("semestre"));
                semestre.setIdSemestre(rs.getInt("id_semestre"));
                semestres.add(semestre);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return semestres;
    }
    
    public ArrayList<Semestre> listarPorAlumno(int idAlumno) {
        ArrayList<Semestre> semestres = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_SEMESTRES_X_ALUMNO(?)}");
            cs.setInt("_id_alumno", idAlumno);
            rs = cs.executeQuery();
            while(rs.next()){
                Semestre semestre = new Semestre();
                semestre.setIdSemestre(rs.getInt("id_semestre"));
                semestre.setFechaInicio(rs.getDate("fecha_inicio"));
                semestre.setFechaFin(rs.getDate("fecha_fin"));
                semestre.setSemestre(rs.getString("semestre"));
                semestres.add(semestre);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return semestres;
    }
}
