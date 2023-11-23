/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.academic.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import ulearn.academic.dao.AlumnoDAO;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Carrera;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Facultad;
import ulearn.academic.model.HistorialAcademico;
import ulearn.academic.model.Semestre;
import ulearn.config.DBManager;

/**
 *
 * @author Eilyn Davila
 */
public class AlumnoMySQL implements AlumnoDAO {

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    
    @Override
    public int insertarAlumno(Alumno alumno) {
        
        int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();  
                
            CallableStatement cStmt = con.prepareCall("{call INSERTAR_ALUMNO(?,?,?,?,?,?,?,?,?,?,?,?)}");
            cStmt.registerOutParameter("_id_usuario", java.sql.Types.INTEGER);
            cStmt.setString("_nombre",alumno.getNombre());
            cStmt.setString("_apellidoPaterno",alumno.getApellidoPaterno());
            cStmt.setString("_apellidoMaterno",alumno.getApellidoMaterno());
            cStmt.setString("_usuario", alumno.getUsuario());
            cStmt.setString("_password", alumno.getPassword());
            cStmt.setString("_salt", alumno.getSalt());
            cStmt.setString("_correo", alumno.getCorreoElectronico());
            cStmt.setString("_codigoAlumno", alumno.getCodigoAlumno());
            cStmt.setString("_sexo",String.valueOf(alumno.getSexo()));
            cStmt.setDate("_fecha_nacimiento", new java.sql.Date(alumno.getFechaNacimiento().getTime()));
            cStmt.setInt("_id_carrera", alumno.getCarrera().getIdCarrera());
            resultado = cStmt.executeUpdate();
            alumno.setCodAlumno(cStmt.getInt("_id_usuario"));
            resultado = alumno.getCodAlumno();
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
    public int actualizarCorreo(String correo,int idDocente) {
        
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ACTUALIZAR_CORREO(?,?)}");
            cs.setString(1,correo);
            cs.setInt(2,idDocente);
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
    public int actualizarContrasenha(String password,int idDocente) {

        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ACTUALIZAR_CONTRASENHA(?,?)}");
            cs.setString(1,password);
            cs.setInt(2,idDocente);
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
    public int actualizarUsuario(String user,int idDocente) {
        
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ACTUALIZAR_USUARIO(?,?)}");
            cs.setString(1,user);
            cs.setInt(2,idDocente);
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
    public int eliminarAlumno(int idAlumno) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_ALUMNO(?)}");
            cs.setInt(1,idAlumno);
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
    public ArrayList<Curso> listarCursosAlumnos(int idAlumno) {

        ArrayList<Curso> cursos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call listarCursosAlumnos(?)}");
            cs.setInt(1, idAlumno);
            rs = cs.executeQuery();
            while(rs.next()){
                Curso curso = new Curso();
                curso.setIdCurso(rs.getInt("id_curso"));
                curso.setCodCurso(rs.getString("codigo_Curso"));
                curso.setCreditos(rs.getDouble("creditos"));
                curso.setNombre(rs.getString("nombre"));
                curso.setSemestreDictado(new Semestre());
                curso.getSemestreDictado().setSemestre(rs.getString("semestre"));
                curso.getSemestreDictado().setIdSemestre(rs.getInt("id_semestre"));
                cursos.add(curso);
            }
                
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return cursos;
        

    }
    
    @Override
    public ArrayList<Alumno> listarAlumnosXCodigoNombre(String codigoNombre) {
         ArrayList<Alumno> alumnos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_ALUMNOS_X_CODIGO_NOMBRE(?)}");
            cs.setString(1, codigoNombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Alumno alumno = new Alumno();
                alumno.setIdUsuario(rs.getInt("id_usuario"));
                alumno.setSexo(rs.getString("sexo").charAt(0));
                alumno.setNombre(rs.getString("nombre"));
                alumno.setApellidoPaterno(rs.getString("apellido_paterno"));
                alumno.setApellidoMaterno(rs.getString("apellido_materno"));
                alumno.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                alumno.setUsuario(rs.getString("usuario"));
                alumno.setPassword(rs.getString("pass"));
                alumno.setCorreoElectronico(rs.getString("correo_electronico"));
                alumno.setCodigoAlumno(rs.getString("codigo_alumno"));
                alumno.setCarrera(new Carrera());
                alumno.getCarrera().setIdCarrera(rs.getInt("fid_carrera"));
                alumno.getCarrera().setNombre(rs.getString("nombre_carrera"));
                alumno.getCarrera().setFacultad(new Facultad());
                alumno.getCarrera().getFacultad().setIdFacultad(rs.getInt("id_facultad"));
                alumno.getCarrera().getFacultad().setNombre(rs.getString("nombre_facultad"));
                alumno.setEsDeudor(rs.getInt("es_deudor_libros"));
                alumnos.add(alumno);
            }
                
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return alumnos;
    }

    @Override
    public Alumno hallarAlumnoPorId(int idAlumno) { 
        Alumno alumno = new Alumno();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call HALLAR_ALUMNO_ID(?)}");
            cs.setInt(1, idAlumno);
            rs = cs.executeQuery();
            if(rs.next()){
                alumno.setIdUsuario(rs.getInt("id_usuario"));
                alumno.setSexo(rs.getString("sexo").charAt(0));
                alumno.setNombre(rs.getString("nombre"));
                alumno.setApellidoPaterno(rs.getString("apellido_paterno"));
                alumno.setApellidoMaterno(rs.getString("apellido_materno"));
                alumno.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                alumno.setCorreoElectronico(rs.getString("correo_electronico"));
                alumno.setTelefono(rs.getString("telefono"));
                alumno.setUsuario(rs.getString("usuario"));
                alumno.setCodigoAlumno(rs.getString("codigo_alumno"));
                alumno.setCarrera(new Carrera());
                alumno.getCarrera().setIdCarrera(rs.getInt("fid_carrera"));
                alumno.getCarrera().setCreditos(rs.getDouble("creditos"));
                alumno.getCarrera().setCursosTotales(rs.getInt("cursos_totales"));
                alumno.setFoto(rs.getBytes("foto_perfil"));
                alumno.setPassword(rs.getString("pass"));
                alumno.setEsDeudor(rs.getInt("es_deudor_libros"));
                try{
                alumno.setSalt(rs.getString("salt"));}
                catch(Exception ex){
                    alumno.setSalt("");
                }
                alumno.setHistorialAcademico(new HistorialAcademico());
                alumno.getHistorialAcademico().setCantCredAprob(rs.getDouble("cantidad_creditos_aprobados"));
                alumno.getHistorialAcademico().setCantCredTotal(rs.getDouble("cantidad_creditos_total"));
                alumno.getHistorialAcademico().setCantCurTotal(rs.getInt("cantidad_cursos_total"));
                alumno.getHistorialAcademico().setCantCurAprobados(rs.getInt("cantidad_cursos_aprobados"));
                alumno.getHistorialAcademico().setNivelAcademico(rs.getInt("nivel_academico"));
            }
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return alumno;
    }
    
    @Override
    public int modificar(Alumno alumno) {
        
        int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();  
            CallableStatement cStmt = con.prepareCall("{call ACTUALIZAR_ALUMNO(?,?,?,?,?,?,?,?,?,?,?,?)}");
            cStmt.setInt("_id_usuario", alumno.getIdUsuario());
            cStmt.setString("_nombre",alumno.getNombre());
            cStmt.setString("_apellidoPaterno",alumno.getApellidoPaterno());
            cStmt.setString("_apellidoMaterno",alumno.getApellidoMaterno());
            cStmt.setString("_usuario",alumno.getUsuario());
            cStmt.setString("_password",alumno.getPassword());
            cStmt.setString("_correo",alumno.getCorreoElectronico());
            cStmt.setString("_codigoAlumno",alumno.getCodigoAlumno());
            cStmt.setString("_sexo",String.valueOf(alumno.getSexo()));
            cStmt.setInt("_fid_carrera", alumno.getCarrera().getIdCarrera());
            cStmt.setDate("_fecha_nacimiento", new java.sql.Date( alumno.getFechaNacimiento().getTime()));
            cStmt.setString("_salt", alumno.getSalt());
            resultado = cStmt.executeUpdate();
            
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
    public int modificarPerfil(Alumno alumno) {
        
        int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();  
            CallableStatement cs = con.prepareCall("{call MODIFICAR_PERFIL(?,?,?,?,?)}");
            cs.setInt("_id_usuario", alumno.getIdUsuario());
            cs.setString("_correo_electronico", alumno.getCorreoElectronico());
            cs.setString("_contrasenia", alumno.getPassword());
            cs.setString("_telefono", alumno.getTelefono());
            cs.setBytes("_foto_perfil", alumno.getFoto());
            
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
