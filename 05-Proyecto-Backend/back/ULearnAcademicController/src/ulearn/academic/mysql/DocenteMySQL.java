/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.academic.mysql;

import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import ulearn.academic.dao.DocenteDAO;
import ulearn.config.DBManager;
import java.sql.CallableStatement;
import java.sql.Time;
import ulearn.academic.model.Docente;
import ulearn.academic.model.Curso;
import ulearn.academic.model.Facultad;
import ulearn.academic.model.Semestre;


/**
 *
 * @author Eilyn Davila
 */
public class DocenteMySQL implements DocenteDAO{
    
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    
    @Override
    public int agregarDocente(Docente docente) {
        int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();  
                
                CallableStatement cStmt = con.prepareCall("{call insertar_docente(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
                cStmt.registerOutParameter("_id_usuario", java.sql.Types.INTEGER);
                cStmt.setString("_nombre",docente.getNombre());
                cStmt.setString("_apellidoPaterno",docente.getApellidoPaterno());
                cStmt.setString("_apellidoMaterno",docente.getApellidoMaterno());
                cStmt.setString("_usuario",docente.getUsuario());
                cStmt.setString("_password",docente.getPassword());
                cStmt.setString("_salt",docente.getSalt());
                cStmt.setString("_correo",docente.getCorreoElectronico());
                cStmt.setTime("_horaEntrada",Time.valueOf(docente.getHoraEntrada()));
                cStmt.setTime("_horaSalida",Time.valueOf(docente.getHoraSalida()));
                cStmt.setDate("_fechaContratacion", new java.sql.Date(docente.getFechaContratacion().getTime()));
                cStmt.setString("_tipoDocente",docente.getTipoDocente());
                cStmt.setString("_sexo",String.valueOf(docente.getSexo()));
                cStmt.setString("_oficina",docente.getOficina());
                cStmt.setString("_intereses_investigacion", docente.getIntereses());
                cStmt.setString("_grado_academico", docente.getGradoAcademico());
                cStmt.setDate("_fecha_nacimiento", new java.sql.Date( docente.getFechaNacimiento().getTime()));
                cStmt.setInt("_id_facultad", docente.getFacultad().getIdFacultad());
                resultado = cStmt.executeUpdate();
                docente.setIdEmpleado(cStmt.getInt("_id_usuario"));
                resultado = docente.getIdEmpleado();
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
    public ArrayList<Docente> listarDocentes() {
        ArrayList<Docente> docentes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_DOCENTES_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Docente profesor = new Docente();
                profesor.setIdEmpleado(rs.getInt("id_Usuario"));
                profesor.setApellidoPaterno(rs.getString("Apellido_Paterno"));
                profesor.setApellidoMaterno(rs.getString("Apellido_Materno"));
                profesor.setNombre(rs.getString("Nombre_docente"));
                profesor.setUsuario(rs.getString("usuario"));
                profesor.setPassword(rs.getString("pass"));
                profesor.setCorreoElectronico(rs.getString("Correo_Electronico"));
                profesor.setHoraEntrada(rs.getTime("Hora_Entrada").toLocalTime());
                profesor.setHoraSalida(rs.getTime("Hora_Salida").toLocalTime());
                profesor.setFechaContratacion(rs.getDate("fecha_Contratacion"));
                profesor.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                profesor.setTipoDocente(rs.getString("Tipo_Docente"));
                profesor.setSexo(rs.getString("sexo").charAt(0));
                profesor.setOficina(rs.getString("oficina"));
                profesor.setIntereses(rs.getString("intereses_investigacion"));
                profesor.setGradoAcademico(rs.getString("grado_academico"));
                profesor.setFacultad(new Facultad());
                profesor.getFacultad().setIdFacultad(rs.getInt("fid_facultad"));
                profesor.setTelefono(rs.getString("telefono"));
                docentes.add(profesor);
            }
                
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return docentes;
    }
    
    
    @Override
    public ArrayList<Docente> listarDocentesXNombre(String nombre) {
         ArrayList<Docente> docentes = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_DOCENTES_X_NOMBRE(?)}");
            cs.setString(1, nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                 Docente profesor = new Docente();
                profesor.setIdEmpleado(rs.getInt("id_usuario"));
                profesor.setIdUsuario(rs.getInt("id_usuario"));
                profesor.setApellidoPaterno(rs.getString("Apellido_Paterno"));
                profesor.setApellidoMaterno(rs.getString("Apellido_Materno"));
                profesor.setNombre(rs.getString("Nombre_docente"));
                profesor.setUsuario(rs.getString("usuario"));
                profesor.setPassword(rs.getString("pass"));
                profesor.setCorreoElectronico(rs.getString("Correo_Electronico"));
                profesor.setHoraEntrada(rs.getTime("Hora_Entrada").toLocalTime());
                profesor.setHoraSalida(rs.getTime("Hora_Salida").toLocalTime());
                profesor.setFechaContratacion(rs.getDate("fecha_Contratacion"));
                profesor.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                profesor.setTipoDocente(rs.getString("Tipo_Docente"));
                profesor.setSexo(rs.getString("sexo").charAt(0));
                profesor.setOficina(rs.getString("oficina"));
                profesor.setIntereses(rs.getString("intereses_investigacion"));
                profesor.setGradoAcademico(rs.getString("grado_academico"));
                profesor.setFacultad(new Facultad());
                profesor.getFacultad().setIdFacultad(rs.getInt("fid_facultad"));
                profesor.getFacultad().setNombre(rs.getString("nombre_facultad"));
                profesor.setTelefono(rs.getString("telefono"));
                profesor.setEsDeudor(rs.getInt("es_deudor_libros"));
                docentes.add(profesor);
            }
                
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return docentes;
    }

    @Override
    public int eliminarDocente(int idDocente) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_DOCENTE(?)}");
            cs.setInt(1,idDocente);
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
    public int actualizarCorreo(String correo,int idDocente) {
        
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ACTUALIZAR_CORREO(?,?)}");
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
            cs = con.prepareCall("{call ACTUALIZAR_CONTRASENHA(?,?)}");
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
            cs = con.prepareCall("{call ACTUALIZAR_USUARIO(?,?)}");
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
    public int actualizarTipoDocente(String tipoDocente,int idDocente) {

        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ACTUALIZAR_TIPODOCENTE(?,?)}");
            String cad = "";
            cs.setString(resultado,cad + tipoDocente);
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
    public ArrayList<Curso> listarCursosDocente(int idDocente) {
        
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call listarCursosDocente(?)}");
            cs.setInt(1, idDocente);
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
    public Docente hallarDocentePorId(int idDocente) {
        Docente profesor = new Docente();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call HALLAR_DOCENTE_ID(?)}");
            cs.setInt(1, idDocente);
            rs = cs.executeQuery();
            if(rs.next()){
                profesor.setFoto(rs.getBytes("foto_perfil"));
                profesor.setIdEmpleado(rs.getInt("id_Usuario"));
                profesor.setApellidoPaterno(rs.getString("Apellido_Paterno"));
                profesor.setApellidoMaterno(rs.getString("Apellido_Materno"));
                profesor.setNombre(rs.getString("Nombre_docente"));
                profesor.setUsuario(rs.getString("usuario"));
                profesor.setPassword(rs.getString("pass"));
                try{
                profesor.setSalt(rs.getString("salt"));
                }
                catch(Exception ex){
                    profesor.setSalt("");
                }
                profesor.setCorreoElectronico(rs.getString("Correo_Electronico"));
                profesor.setHoraEntrada(rs.getTime("Hora_Entrada").toLocalTime());
                profesor.setHoraSalida(rs.getTime("Hora_Salida").toLocalTime());
                profesor.setFechaContratacion(rs.getDate("fecha_Contratacion"));
                profesor.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                profesor.setTipoDocente(rs.getString("Tipo_Docente"));
                profesor.setSexo(rs.getString("sexo").charAt(0));
                profesor.setOficina(rs.getString("oficina"));
                profesor.setIntereses(rs.getString("intereses_investigacion"));
                profesor.setGradoAcademico(rs.getString("grado_academico"));
                profesor.setFacultad(new Facultad());
                profesor.getFacultad().setIdFacultad(rs.getInt("fid_facultad"));
                profesor.setTelefono(rs.getString("telefono"));
                profesor.setEsDeudor(rs.getInt("es_deudor_libros"));
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return profesor;
    }
    
    @Override
    public int modificar(Docente docente) {
        
         int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();  
            CallableStatement cStmt = con.prepareCall("{call ACTUALIZAR_DOCENTE(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cStmt.setInt("_id_usuario", docente.getIdUsuario());
            cStmt.setString("_nombre",docente.getNombre());
            cStmt.setString("_apellidoPaterno",docente.getApellidoPaterno());
            cStmt.setString("_apellidoMaterno",docente.getApellidoMaterno());
            cStmt.setString("_usuario",docente.getUsuario());
            cStmt.setString("_password",docente.getPassword());
            cStmt.setString("_correo",docente.getCorreoElectronico());
            cStmt.setString("_grado_academico",docente.getGradoAcademico());
            cStmt.setString("_oficina", docente.getOficina());
            cStmt.setString("_intereses_investigacion", docente.getIntereses());
            cStmt.setString("_tipo_docente",docente.getTipoDocente());
            cStmt.setString("_sexo",String.valueOf(docente.getSexo()));
            cStmt.setInt("_fid_facultad", docente.getFacultad().getIdFacultad());
            cStmt.setDate("_fecha_nacimiento", new java.sql.Date( docente.getFechaNacimiento().getTime()));
            cStmt.setTime("_horaEntrada",Time.valueOf(docente.getHoraEntrada()));
            cStmt.setTime("_horaSalida",Time.valueOf(docente.getHoraSalida()));
            cStmt.setDate("_fechaContratacion", new java.sql.Date( docente.getFechaContratacion().getTime()));
            cStmt.setString("_salt",docente.getSalt());
            resultado = cStmt.executeUpdate();
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
    public int modificarPerfil(Docente docente) {
        int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();  
            CallableStatement cs = con.prepareCall("{call MODIFICAR_PERFIL(?,?,?,?,?)}");
            cs.setInt("_id_usuario", docente.getIdUsuario());
            cs.setString("_correo_electronico", docente.getCorreoElectronico());
            cs.setString("_contrasenia", docente.getPassword());
            cs.setString("_telefono", docente.getTelefono());
            cs.setBytes("_foto_perfil", docente.getFoto());
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

