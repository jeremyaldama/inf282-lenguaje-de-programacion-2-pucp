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
import ulearn.academic.dao.HorarioDAO;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Carrera;
import ulearn.academic.model.Curso;
import ulearn.academic.model.DiaSemana;
import ulearn.academic.model.Docente;
import ulearn.academic.model.Facultad;
import ulearn.academic.model.Horario;
import ulearn.config.DBManager;

/**
 *
 * @author cesar
 */
public class HorarioMySQL implements HorarioDAO{
    private String sql;
    private Connection con;
    private ResultSet rs; //cursor
    private CallableStatement cs;
    @Override
    public int insertar(Horario horario) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_HORARIO(?,?,?,?,?,?,?,?,?,?)} ");
            cs.registerOutParameter("_id_horario", java.sql.Types.INTEGER);
            cs.setInt("_id_curso", horario.getCurso().getIdCurso());
            cs.setString("_codigo_horario",horario.getCodigo());
            cs.setTime("_hora_inicio", Time.valueOf(horario.getHoraInicio()));
            cs.setTime("_hora_fin", Time.valueOf(horario.getHoraFin()));
            cs.setString("_dia_semana", String.valueOf(horario.getDia()));
            cs.setInt("_vacantes", horario.getVacantes());
            cs.setInt("_matriculados", horario.getMatriculados());
            cs.setInt("_tiempo_tolerancia",horario.getTiempoTolerancia());
            cs.setString("_tipo_horario", String.valueOf(horario.getTipoHorario()));
            resultado = cs.executeUpdate();
            horario.setIdHorario(cs.getInt("_id_horario"));
            resultado = horario.getIdHorario();
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
    public int modificar(Horario horario) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_HORARIO(?,?,?,?,?,?)}");
            cs.setInt("_id_horario", horario.getIdHorario());
            cs.setTime("_hora_inicio", Time.valueOf(horario.getHoraInicio()));
            cs.setTime("_hora_fin", Time.valueOf(horario.getHoraFin()));
            cs.setString("_dia_semana", String.valueOf(horario.getDia()));
            cs.setInt("_vacantes", horario.getVacantes());
            cs.setInt("_matriculados", horario.getMatriculados());
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
    public int eliminar(int idHorario) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call ELIMINAR_HORARIO(?)}");
            cs.setInt("_id_horario", idHorario);
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
    public ArrayList<Horario> listarTodos(){
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_HORARIOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Horario horario = new Horario();
                horario.setIdHorario(rs.getInt("id_horario"));
                horario.setCodigo(rs.getString("codigo_horario"));
                horario.setHoraInicio(rs.getTime("hora_inicio").toLocalTime());
                horario.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                horario.setDia(DiaSemana.valueOf(rs.getString("dia_semana")));
                horario.setVacantes(rs.getInt("vacantes"));
                horario.setMatriculados(rs.getInt("matriculados"));
                horario.setTiempoTolerancia(rs.getInt("tiempo_tolerancia"));
                horario.setTipoHorario(rs.getString("tipo_horario").charAt(0));
                horario.setCurso(new Curso());
                horario.getCurso().setIdCurso(rs.getInt("id_curso")); 
                horarios.add(horario);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return horarios;
    }
    @Override
    public ArrayList<Horario> listarPorAlumno(int idAlumno){
       ArrayList<Horario> horarios = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_HORARIOS_ALUMNO(?)}");
            cs.setInt("_id_alumno", idAlumno);
            rs = cs.executeQuery();
            while(rs.next()){
                Horario horario = new Horario();
                horario.setIdHorario(rs.getInt("id_horario"));
                horario.setCodigo(rs.getString("codigo_horario"));
                horario.setHoraInicio(rs.getTime("hora_inicio").toLocalTime());
                horario.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                horario.setDia(DiaSemana.valueOf(rs.getString("dia_semana")));
                horario.setMatriculados(rs.getInt("matriculados"));
                horario.setTiempoTolerancia(rs.getInt("tiempo_tolerancia"));
                horario.setTipoHorario(rs.getString("tipo_horario").charAt(0));
                horario.setCurso(new Curso());
                horario.getCurso().setIdCurso(rs.getInt("id_curso"));
                horario.getCurso().setCodCurso(rs.getString("codigo_curso"));
                horario.getCurso().setNombre(rs.getString("nombre_curso"));
                horarios.add(horario);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return horarios; 
    }
    @Override
    public ArrayList<Horario> listarPorDocente(int idDocente){
       ArrayList<Horario> horarios = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_HORARIOS_DOCENTE(?)}");
            cs.setInt("_id_docente", idDocente);
            rs = cs.executeQuery();
            while(rs.next()){
                Horario horario = new Horario();
                horario.setIdHorario(rs.getInt("id_horario"));
                horario.setCodigo(rs.getString("codigo_horario"));
                horario.setHoraInicio(rs.getTime("hora_inicio").toLocalTime());
                horario.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                horario.setDia(DiaSemana.valueOf(rs.getString("dia_semana")));
                horario.setMatriculados(rs.getInt("matriculados"));
                horario.setTiempoTolerancia(rs.getInt("tiempo_tolerancia"));
                horario.setTipoHorario(rs.getString("tipo_horario").charAt(0));
                horario.setCurso(new Curso());
                horario.getCurso().setIdCurso(rs.getInt("id_curso")); 
                horario.getCurso().setNombre(rs.getString("nombre_curso"));
                horarios.add(horario);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return horarios; 
    }
    @Override
    public ArrayList<Horario> listarPorCurso(int idCurso){
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_HORARIOS_CURSO(?)}");
            cs.setInt("_id_curso", idCurso);
            rs = cs.executeQuery();
            while(rs.next()){
                Horario horario = new Horario();
                horario.setIdHorario(rs.getInt("id_horario"));
                horario.setCodigo(rs.getString("codigo_horario"));
                horario.setHoraInicio(rs.getTime("hora_inicio").toLocalTime());
                horario.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                horario.setDia(DiaSemana.valueOf(rs.getString("dia_semana")));
                horario.setMatriculados(rs.getInt("matriculados"));
                horario.setTiempoTolerancia(rs.getInt("tiempo_tolerancia"));
                horario.setTipoHorario(rs.getString("tipo_horario").charAt(0));
                horario.setCurso(new Curso());
                horario.getCurso().setIdCurso(idCurso);
                horarios.add(horario);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return horarios;
    }   
    
    @Override
    public int agregarAlumnoHorario(Alumno alumno, Horario horario){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call AGREGAR_ALUMNO_HORARIO(?,?,?)}");
            cs.registerOutParameter("_id_alumnoxcursoxsemestre", java.sql.Types.INTEGER);
            cs.setInt("_id_horario", horario.getIdHorario());
            cs.setInt("_id_alumno", alumno.getCodAlumno());
            cs.executeUpdate();
            resultado = cs.getInt("_id_alumnoxcursoxsemestre"); //llave
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
    public int agregarDocenteHorario(int idDocente, int idHorario){
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call AGREGAR_DOCENTE_HORARIO(?,?)}");
            cs.setInt("_id_horario", idHorario);
            cs.setInt("_id_docente", idDocente);
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
    public ArrayList<Alumno> listarAlumnosDeHorario(int idHorario) {
        ArrayList<Alumno> alumnos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_ALUMNOS_HORARIO(?)}");
            cs.setInt(1, idHorario);
            rs = cs.executeQuery();
            while(rs.next()){
                Alumno alumno = new Alumno();
                alumno.setCodAlumno(rs.getInt("id_usuario"));
                alumno.setNombre(rs.getString("nombre"));
                alumno.setApellidoPaterno(rs.getString("apellido_paterno"));
                alumno.setApellidoMaterno(rs.getString("apellido_materno"));
                alumno.setCodigoAlumno(rs.getString("codigo_alumno"));
                alumno.setCorreoElectronico(rs.getString("correo_electronico"));
                alumno.setCarrera(new Carrera());
                alumno.getCarrera().setIdCarrera(rs.getInt("fid_carrera"));
                alumno.getCarrera().setNombre(rs.getString("nombre_carrera"));
                alumnos.add(alumno);
            }    
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
            System.out.println(ex.getMessage());
            }
        }
        return alumnos;
    }

    @Override
    public ArrayList<Docente> listarDocentesDeHorario(int idHorario) {
        ArrayList<Docente> docentes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_DOCENTES_HORARIO(?)}");
            cs.setInt(1, idHorario);
            rs = cs.executeQuery();
            while(rs.next()){
                Docente docente = new Docente();
                docente.setGradoAcademico(rs.getString("grado_academico"));
                docente.setNombre(rs.getString("nombre"));
                docente.setApellidoPaterno(rs.getString("apellido_paterno"));
                docente.setApellidoMaterno(rs.getString("apellido_materno"));
                docente.setOficina(rs.getString("oficina"));
                docente.setIdUsuario(rs.getInt("id_usuario"));
                docente.setIdEmpleado(rs.getInt("id_usuario"));
                docente.setTipoDocente(rs.getString("tipo_docente"));
                docente.setCorreoElectronico(rs.getString("correo_electronico"));
                docente.setFacultad(new Facultad());
                docente.getFacultad().setIdFacultad(rs.getInt("fid_facultad"));
                docente.setTelefono(rs.getString("telefono"));
                docentes.add(docente);
            } 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{con.close();}catch(Exception ex){
            System.out.println(ex.getMessage());
            }
        }
        return docentes;
    }

    @Override
    public int conseguirTotalizados(Horario horario, Curso curso) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LLENAR_MEDIA_APROBADOS_HORARIO(?,?,?,?,?)}");
            cs.registerOutParameter("media", java.sql.Types.INTEGER);
            cs.registerOutParameter("aprobados", java.sql.Types.DOUBLE);
            cs.setInt(1, horario.getIdHorario());
            cs.setInt(2, curso.getIdCurso());
            cs.setInt(3, curso.getSemestreDictado().getIdSemestre());
            resultado = cs.executeUpdate();
            if(resultado == 1){
                horario.setAprobados(cs.getInt("aprobados"));
                horario.setMedia(cs.getDouble("media"));
            }
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

    

