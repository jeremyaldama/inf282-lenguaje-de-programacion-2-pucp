/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package ulearn.academic.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import ulearn.academic.dao.CursoXAlumnoXSemestreDAO;
import ulearn.academic.model.Curso;
import ulearn.academic.model.CursoXAlumnoXSemestre;
import ulearn.config.DBManager;

/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public class CursoXAlumnoXSemestreMySQL implements CursoXAlumnoXSemestreDAO{
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public ArrayList<CursoXAlumnoXSemestre> listarPorAlumnoSemestre(int idAlumno, int idSemestre) {
        ArrayList<CursoXAlumnoXSemestre> cass = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_CASS_X_ALUMNO_SEMESTRE(?,?)}");
            cs.setInt("_alumno_id", idAlumno);
            cs.setInt("_semestre_id", idSemestre);
            
            rs = cs.executeQuery();
            while(rs.next()){
                CursoXAlumnoXSemestre cas = new CursoXAlumnoXSemestre();
                
                cas.setNota(rs.getDouble("nota_final"));
                cas.setVez(rs.getInt("vez"));
                cas.setCurso(new Curso());
                cas.getCurso().setCodCurso(rs.getString("codigo_curso"));
                cas.getCurso().setEsElectivo(rs.getInt("es_electivo"));
                cas.getCurso().setCreditos(rs.getDouble("creditos"));
                cas.getCurso().setNombre(rs.getString("nombre"));
                
                cass.add(cas);
            }
        } catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return cass;
    }
    
    
}