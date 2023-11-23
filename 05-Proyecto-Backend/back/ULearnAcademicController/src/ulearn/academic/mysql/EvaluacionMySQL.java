/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.academic.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import ulearn.academic.dao.EvaluacionDAO;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Evaluacion;
import ulearn.academic.model.NombreEvaluacion;
import ulearn.academic.model.Semestre;
import ulearn.config.DBManager;

/**
 *
 * @author MAURICIO
 */
public class EvaluacionMySQL implements EvaluacionDAO {
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(Evaluacion evaluacion, int fidAlumnoCursoSemestre) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_EVALUACION(?,?,?,?,?)}");
            cs.registerOutParameter("_id_evaluacion", INTEGER);
            cs.setInt("_fid_cursoxalumnoxsemestre",fidAlumnoCursoSemestre);
            cs.setString("_nombreEvaluacion",String.valueOf(evaluacion.getNombreEvaluacion()));
            cs.setDouble("_valorNota",evaluacion.getNota());
            cs.setString("_asistio",String.valueOf(evaluacion.getAsistio()));
            resultado = cs.executeUpdate();
            evaluacion.setIdEvaluacion(cs.getInt("_id_evaluacion"));
            resultado = evaluacion.getIdEvaluacion();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    @Override
    public int modificar(Evaluacion evaluacion) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_EVALUACION(?,?,?,?)}");
            cs.setInt("_id_evaluacion", evaluacion.getIdEvaluacion());
            cs.setString("_nombreEvaluacion",String.valueOf(evaluacion.getNombreEvaluacion()));
            cs.setDouble("_valorNota",evaluacion.getNota());
            cs.setString("_asistio",String.valueOf(evaluacion.getAsistio()));
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    @Override
    public int eliminar(int idEvaluacion) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_EVALUACION(?)}");
            cs.setInt("_id_evaluacion", idEvaluacion);
            resultado = cs.executeUpdate();   
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Evaluacion> listarPorCursoYSemestre(Curso curso) {
        ArrayList<Evaluacion> evaluaciones = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EVALUACION_CURSO_SEMESTRE(?,?)}");
            cs.setInt("_id_curso",curso.getIdCurso());
            cs.setInt("_id_semestre",curso.getSemestreDictado().getIdSemestre());
            rs = cs.executeQuery();
            while(rs.next()){
                Evaluacion evaluacion = new Evaluacion();
                evaluacion.setSemestre(new Semestre());
                evaluacion.getSemestre().setSemestre(rs.getString("semestre"));
                evaluacion.setCurso(new Curso());
                evaluacion.getCurso().setCodCurso(rs.getString("codigo_curso"));
                evaluacion.getCurso().setNombre(rs.getString("nombre_curso"));
                evaluacion.setAlumno(new Alumno());
                evaluacion.getAlumno().setCodigoAlumno(rs.getString("codigo_alumno"));
                evaluacion.getAlumno().setNombre(rs.getString("nombre"));
                evaluacion.getAlumno().setApellidoPaterno(rs.getString("apellido_paterno"));
                evaluacion.getAlumno().setApellidoMaterno(rs.getString("apellido_materno"));
                evaluacion.setIdEvaluacion(rs.getInt("id_evaluacion"));
                evaluacion.setNombreEvaluacion(NombreEvaluacion.valueOf(rs.getString("nombreEvaluacion")));
                evaluacion.setAsistio('N'); // Default value if 'asistio' is null
                String asistioValue = rs.getString("asistio");
                if (!rs.wasNull() && !asistioValue.isEmpty()) //estara en null inicialmente
                    evaluacion.setAsistio(asistioValue.charAt(0));
                double notaValue = rs.getDouble("valorNota");
                if (!rs.wasNull())evaluacion.setNota(notaValue);
                else evaluacion.setNota(0.0); //por si acaso
                evaluacion.setActivo(true);
                evaluaciones.add(evaluacion);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return evaluaciones;
    }
    
    @Override
    public ArrayList<Evaluacion> listarEvaluacionxAlumno(Alumno alumno) {
        ArrayList<Evaluacion> evaluaciones = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ListarEvaluacionesxAlumno(?)}");
            cs.setInt("_id_alumno",alumno.getIdUsuario());
            rs = cs.executeQuery();
            while(rs.next()){
                Evaluacion evaluacion = new Evaluacion();
                evaluacion.setSemestre(new Semestre());
                evaluacion.getSemestre().setSemestre(rs.getString("semestre"));
                evaluacion.setCurso(new Curso());
                evaluacion.getCurso().setCodCurso(rs.getString("codigo_curso"));
                evaluacion.getCurso().setNombre(rs.getString("nombre_curso"));
                evaluacion.setAlumno(new Alumno());
                evaluacion.getAlumno().setCodigoAlumno(rs.getString("codigo_alumno"));
                evaluacion.getAlumno().setNombre(rs.getString("nombre"));
                evaluacion.getAlumno().setApellidoPaterno(rs.getString("apellido_paterno"));
                evaluacion.getAlumno().setApellidoMaterno(rs.getString("apellido_materno"));
                evaluacion.setIdEvaluacion(rs.getInt("id_evaluacion"));
                evaluacion.setNombreEvaluacion(NombreEvaluacion.valueOf(rs.getString("nombreEvaluacion")));
                evaluacion.setAsistio('N'); // Default value if 'asistio' is null
                String asistioValue = rs.getString("asistio");
                if (!rs.wasNull() && !asistioValue.isEmpty()) //estara en null inicialmente
                    evaluacion.setAsistio(asistioValue.charAt(0));
                double notaValue = rs.getDouble("valorNota");
                if (!rs.wasNull())evaluacion.setNota(notaValue);
                else evaluacion.setNota(0.0); //por si acaso
                evaluacion.setActivo(true);
                evaluaciones.add(evaluacion);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return evaluaciones;
    }
    
    
}
