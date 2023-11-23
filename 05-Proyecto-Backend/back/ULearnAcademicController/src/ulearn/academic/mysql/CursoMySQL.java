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
import ulearn.academic.dao.CursoDAO;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Horario;
import ulearn.config.DBManager;

/**
 *
 * @author Eilyn Davila
 */
public class CursoMySQL implements CursoDAO{

    
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    
    
    @Override
    public int insertarCurso(Curso curso) {

        int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();  
            CallableStatement cStmt = con.prepareCall("{call insertar_curso(?,?,?,?,?)}");
            cStmt.registerOutParameter("_id_Curso", java.sql.Types.INTEGER);
            cStmt.setString("_codCurso",curso.getCodCurso());
            cStmt.setString("_nombre",curso.getNombre());
            cStmt.setInt("_es_electivo",curso.getEsElectivo());
            cStmt.setDouble("_creditos",curso.getCreditos());
            resultado = cStmt.executeUpdate();
            curso.setIdCurso(cStmt.getInt("_id_Curso"));
            resultado = curso.getIdCurso();
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
    public int eliminarCurso(int idCurso) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call eliminar_Curso(?)}");
            cs.setInt(1,idCurso);
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
    public ArrayList<Alumno> listarAlumnosCurso(int idCurso) {
        
        ArrayList<Alumno> alumnos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call listarAlumnosCursos(?)}");
            cs.setInt(1, idCurso);
            rs = cs.executeQuery(sql);
            while(rs.next()){
                Alumno alumno = new Alumno();
                alumno.setNombre(rs.getString("nombre"));
                alumno.setApellidoPaterno(rs.getString("apellido_paterno"));
                alumno.setCodigoAlumno(rs.getString("codigo_alumno"));
                alumnos.add(alumno);
            }
                
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return alumnos;
        


    }

    @Override
    public int modificarNombreCurso(int idCurso, String nombre) {
        
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_NOMBRE_CURSO(?,?)}");
            cs.setInt(1,idCurso);
            cs.setString(2,nombre);
            resultado =cs.executeUpdate();
            
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
    public int agregarCursoASemestre(int idCurso, int idSemestre){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call AGREGAR_CURSO_SEMESTRE(?,?)}");
            cs.setInt("_id_curso",idCurso);
            cs.setInt("_id_semestre",idSemestre);
            resultado =cs.executeUpdate();
            
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
    public int agregarCursoACarrera(int idCurso, int idCarrera){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call AGREGAR_CURSO_CARRERA(?,?)}");
            cs.setInt("_id_curso",idCurso);
            cs.setInt("_id_carrera",idCarrera);
            resultado =cs.executeUpdate();
            
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
    public ArrayList<Curso> listarTodos() {
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CURSOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Curso curso = new Curso();
                curso.setIdCurso(rs.getInt("id_curso"));
                curso.setCodCurso(rs.getString("codigo_curso"));
                curso.setEsElectivo(rs.getInt("es_electivo"));
                curso.setCreditos(rs.getDouble("creditos"));
                curso.setNombre(rs.getString("nombre"));
                
                cursos.add(curso);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return cursos;
    }
    @Override
    public ArrayList<Curso> listarCursosCodigoNombre(String codigoNombre) {
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CURSOS_CODIGO_NOMBRE(?)}");
            cs.setString("_nombre",codigoNombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Curso curso = new Curso();
                curso.setIdCurso(rs.getInt("id_curso"));
                curso.setCodCurso(rs.getString("codigo_curso"));
                curso.setEsElectivo(rs.getInt("es_electivo"));
                curso.setCreditos(rs.getDouble("creditos"));
                curso.setNombre(rs.getString("nombre"));
                
                cursos.add(curso);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return cursos;
    }
    
    @Override
    public int modificar(Curso curso) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_CURSO(?,?,?,?,?)}");
            cs.setInt("_id_Curso", curso.getIdCurso());
            cs.setString("_codCurso", curso.getCodCurso());
            cs.setString("_nombre", curso.getNombre());
            cs.setInt("_es_electivo", curso.getEsElectivo());
            cs.setDouble("_creditos", curso.getCreditos());
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
}
