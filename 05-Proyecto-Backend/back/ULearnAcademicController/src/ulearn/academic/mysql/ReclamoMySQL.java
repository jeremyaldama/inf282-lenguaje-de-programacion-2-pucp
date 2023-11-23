/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.academic.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import ulearn.academic.dao.ReclamoDAO;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Evaluacion;
import ulearn.academic.model.NombreEvaluacion;
import ulearn.academic.model.Reclamo;
import ulearn.academic.model.Semestre;
import ulearn.config.DBManager;

/**
 *
 * @author MAURICIO
 */
public class ReclamoMySQL implements ReclamoDAO {
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(Reclamo reclamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_RECLAMO(?,?,?,?)}");
            cs.registerOutParameter("_id_reclamo", INTEGER);
            cs.setInt("_id_evaluacion",reclamo.getEvaluacion().getIdEvaluacion());
            cs.setDate("_fecha",new Date(reclamo.getFechaReclamo().getTime()));
            cs.setString("_descripcion",reclamo.getDescripcion());
            resultado = cs.executeUpdate();
            reclamo.setIdReclamo(cs.getInt("_id_reclamo"));
            resultado = reclamo.getIdReclamo();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Reclamo reclamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_RECLAMO(?,?,?,?,?)}");
            cs.setInt("_id_reclamo",reclamo.getIdReclamo());
            cs.setDate("_fecha",new Date(reclamo.getFechaReclamo().getTime()));
            cs.setString("_descripcion",reclamo.getDescripcion());
            cs.setInt("_es_valido",reclamo.isValido()?1:0);
            cs.setString("_descripcion",reclamo.getDescripcion());
            cs.setString("_respuesta", reclamo.getRespuesta());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idReclamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_RECLAMO(?)}");
            cs.setInt("_id_evaluacion",idReclamo);
            resultado = cs.executeUpdate();   
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Reclamo> listarPorAlumnoYSemestre(Alumno alumno) {
        ArrayList<Reclamo> reclamos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_RECLAMO_ALUMNO_SEMESTRE(?)}");
            cs.setInt("_id_alumno",alumno.getCodAlumno());
            rs = cs.executeQuery();
            while(rs.next()){
                Reclamo reclamo = new Reclamo();
                reclamo.setEvaluacion(new Evaluacion());
                reclamo.getEvaluacion().setSemestre(new Semestre());
                reclamo.getEvaluacion().getSemestre().setSemestre(rs.getString("semestre"));
                reclamo.getEvaluacion().setCurso(new Curso());
                reclamo.getEvaluacion().getCurso().setCodCurso(rs.getString("codigo_curso"));
                reclamo.getEvaluacion().getCurso().setNombre(rs.getString("nombre_curso"));
                reclamo.getEvaluacion().setAlumno(new Alumno());
                reclamo.getEvaluacion().getAlumno().setCodigoAlumno(rs.getString("codigo_alumno"));
                reclamo.getEvaluacion().getAlumno().setNombre(rs.getString("nombre"));
                reclamo.getEvaluacion().getAlumno().setApellidoPaterno(rs.getString("apellido_paterno"));
                reclamo.getEvaluacion().getAlumno().setApellidoMaterno(rs.getString("apellido_materno"));
                reclamo.getEvaluacion().setIdEvaluacion(rs.getInt("id_evaluacion"));
                reclamo.getEvaluacion().setNombreEvaluacion(NombreEvaluacion.valueOf(rs.getString("nombreEvaluacion")));
                reclamo.getEvaluacion().setAsistio(rs.getString("asistio").charAt(0));
                reclamo.setIdReclamo(rs.getInt("id_reclamo"));
                reclamo.setFechaReclamo(rs.getDate("fecha_registro"));
                reclamo.setDescripcion(rs.getString("descripcion"));
                reclamo.setRespuesta(rs.getString("respuesta"));
                if(rs.getInt("es_valido")==1) reclamo.setValido(true);
                else reclamo.setValido(false);
                reclamo.setActivo(true);
                reclamos.add(reclamo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return reclamos;
    }

    @Override
    public ArrayList<Reclamo> listarPorCursoYSemestre(Curso curso) {
        ArrayList<Reclamo> reclamos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_RECLAMO_CURSO_SEMESTRE(?,?)}");
            cs.setInt("_id_curso",curso.getIdCurso());
            cs.setInt("_id_semestre",curso.getSemestreDictado().getIdSemestre());
            rs = cs.executeQuery();
            while(rs.next()){
                Reclamo reclamo = new Reclamo();
                reclamo.setEvaluacion(new Evaluacion());
                reclamo.getEvaluacion().setSemestre(new Semestre());
                reclamo.getEvaluacion().getSemestre().setSemestre(rs.getString("semestre"));
                reclamo.getEvaluacion().setCurso(new Curso());
                reclamo.getEvaluacion().getCurso().setCodCurso(rs.getString("codigo_curso"));
                reclamo.getEvaluacion().getCurso().setNombre(rs.getString("nombre_curso"));
                reclamo.getEvaluacion().getCurso().setSemestreDictado(reclamo.getEvaluacion().getSemestre());
                reclamo.getEvaluacion().setAlumno(new Alumno());
                reclamo.getEvaluacion().getAlumno().setCodigoAlumno(rs.getString("codigo_alumno"));
                reclamo.getEvaluacion().getAlumno().setNombre(rs.getString("nombre"));
                reclamo.getEvaluacion().getAlumno().setApellidoPaterno(rs.getString("apellido_paterno"));
                reclamo.getEvaluacion().getAlumno().setApellidoMaterno(rs.getString("apellido_materno"));
                reclamo.getEvaluacion().setIdEvaluacion(rs.getInt("id_evaluacion"));
                reclamo.getEvaluacion().setNombreEvaluacion(NombreEvaluacion.valueOf(rs.getString("nombreEvaluacion")));
                reclamo.getEvaluacion().setNota(rs.getDouble("valorNota"));
                reclamo.getEvaluacion().setAsistio(rs.getString("asistio").charAt(0));
                reclamo.setIdReclamo(rs.getInt("id_reclamo"));
                reclamo.setFechaReclamo(rs.getDate("fecha_registro"));
                reclamo.setDescripcion(rs.getString("descripcion"));
                reclamo.setRespuesta(rs.getString("respuesta"));
                if(rs.getInt("es_valido")==1) reclamo.setValido(true);
                else reclamo.setValido(false);
                reclamo.setActivo(true);
                reclamos.add(reclamo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return reclamos;
    }
    
}
