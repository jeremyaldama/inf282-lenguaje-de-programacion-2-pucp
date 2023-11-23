/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.staff.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.ResultSet;
import java.sql.Time;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.staff.dao.EncargadoBibliotecaDAO;
import ulearn.staff.model.EncargadoBiblioteca;

/**
 *
 * @author cesar
 */
public class EncargadoBibliotecaMySQL implements EncargadoBibliotecaDAO{
    private Connection con;
    private ResultSet rs;
    private String sql;
    private CallableStatement cs;
    @Override
    public int insertar(EncargadoBiblioteca encargado) {
        int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();  
            CallableStatement cStmt = con.prepareCall("{call insertar_encargadobiblioteca(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cStmt.registerOutParameter("_id_usuario", java.sql.Types.INTEGER);
            cStmt.setString("_nombre",encargado.getNombre());
            cStmt.setString("_apellidoPaterno",encargado.getApellidoPaterno());
            cStmt.setString("_apellidoMaterno",encargado.getApellidoMaterno());
            cStmt.setString("_usuario",encargado.getUsuario());
            cStmt.setString("_password",encargado.getPassword());
            cStmt.setString("_salt",encargado.getSalt());
            cStmt.setString("_correo",encargado.getCorreoElectronico());
            cStmt.setTime("_horaEntrada",Time.valueOf(encargado.getHoraEntrada()));
            cStmt.setTime("_horaSalida",Time.valueOf(encargado.getHoraSalida()));
            cStmt.setDate("_fechaContratacion", new java.sql.Date( encargado.getFechaContratacion().getTime()));
            cStmt.setDate("_fecha_nacimiento", new java.sql.Date( encargado.getFechaNacimiento().getTime()));
            cStmt.setString("_sexo", String.valueOf(encargado.getSexo()));
            cStmt.setString("_titulo_trabajo", encargado.getTitulo_trabajo());
            
            resultado = cStmt.executeUpdate();
            encargado.setIdUsuario(cStmt.getInt("_id_usuario"));
            resultado = encargado.getIdUsuario();
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
    public int modificar(EncargadoBiblioteca encargado) {
        
         int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();  
            CallableStatement cStmt = con.prepareCall("{call ACTUALIZAR_ENCARGADO(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cStmt.setInt("_id_usuario", encargado.getIdEmpleado());
            cStmt.setString("_nombre",encargado.getNombre());
            cStmt.setString("_apellidoPaterno",encargado.getApellidoPaterno());
            cStmt.setString("_apellidoMaterno",encargado.getApellidoMaterno());
            cStmt.setString("_usuario",encargado.getUsuario());
            cStmt.setString("_password",encargado.getPassword());
            cStmt.setString("_correo",encargado.getCorreoElectronico());
            cStmt.setTime("_horaEntrada",Time.valueOf(encargado.getHoraEntrada()));
            cStmt.setTime("_horaSalida",Time.valueOf(encargado.getHoraSalida()));
            cStmt.setDate("_fechaContratacion", new java.sql.Date( encargado.getFechaContratacion().getTime()));
            cStmt.setDate("_fecha_nacimiento", new java.sql.Date( encargado.getFechaNacimiento().getTime()));
            cStmt.setString("_sexo", String.valueOf(encargado.getSexo()));
            cStmt.setString("_titulo_trabajo", encargado.getTitulo_trabajo());
            cStmt.setString("_salt", encargado.getSalt());
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
    public ArrayList<EncargadoBiblioteca> listarTodos() {
            
         ArrayList<EncargadoBiblioteca> encargados = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_ENCARGADOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                EncargadoBiblioteca encargado = new EncargadoBiblioteca();
                encargado.setIdUsuario(rs.getInt("id_Usuario"));
                encargado.setIdEmpleado(rs.getInt("id_Usuario"));
                encargado.setNombre(rs.getString("nombre_Encargado"));
                encargado.setApellidoPaterno(rs.getString("apellido_Paterno"));
                encargado.setApellidoMaterno(rs.getString("apellido_Materno"));
                encargado.setUsuario(rs.getString("usuario"));
                encargado.setPassword(rs.getString("pass"));
                encargado.setCorreoElectronico(rs.getString("correo_Electronico"));
                encargado.setHoraEntrada(rs.getTime("hora_Entrada").toLocalTime());
                encargado.setHoraSalida(rs.getTime("hora_Salida").toLocalTime());
                encargado.setFechaContratacion(rs.getDate("fecha_Contratacion"));
                encargado.setSexo(rs.getString("sexo").charAt(0));
                encargado.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                encargado.setTitulo_trabajo(rs.getString("titulo_trabajo"));
                encargados.add(encargado);
            }
                
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return encargados;
        
    }

    @Override
    public int eliminar(int idEncargado) {
        
         int resultado=0;
        
        try{
            con = DBManager.getInstance().getConnection();  
                
            CallableStatement cStmt = con.prepareCall("{call eliminar_ENCARGADOBIBLIOTECA(?)}");
            cStmt.setInt("_idencargadobiblioteca",idEncargado);
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
    public ArrayList<EncargadoBiblioteca> listarUsuarioNombre(String usuarioNombre) {
     
         ArrayList<EncargadoBiblioteca> encargados = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_ENCARGADO_USUARIONOMBRE(?)}");
            cs.setString("_usuarionombre",usuarioNombre);
            rs = cs.executeQuery();
            while(rs.next()){
                EncargadoBiblioteca encargado = new EncargadoBiblioteca();
                encargado.setIdUsuario(rs.getInt("id_usuario"));
                encargado.setIdEmpleado(rs.getInt("id_Usuario"));
                encargado.setNombre(rs.getString("nombre_encargado"));
                encargado.setApellidoPaterno(rs.getString("apellido_Paterno"));
                encargado.setApellidoMaterno(rs.getString("apellido_Materno"));
                encargado.setUsuario(rs.getString("usuario"));
                encargado.setPassword(rs.getString("pass"));
                encargado.setCorreoElectronico(rs.getString("correo_electronico"));
                encargado.setHoraEntrada(rs.getTime("hora_Entrada").toLocalTime());
                encargado.setHoraSalida(rs.getTime("hora_Salida").toLocalTime());
                encargado.setFechaContratacion(rs.getDate("fecha_Contratacion"));
                encargado.setSexo(rs.getString("sexo").charAt(0));
                encargado.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                encargado.setTitulo_trabajo(rs.getString("titulo_trabajo"));
                encargados.add(encargado);
            }
                
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return encargados;
  
    }
    
      @Override
    public EncargadoBiblioteca hallarEncargadoPorId(int idEncargado){
        EncargadoBiblioteca encargado = new EncargadoBiblioteca();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call HALLAR_ENCARGADO_BIBLIOTECA_ID(?)}");
            cs.setInt(1, idEncargado);
            rs = cs.executeQuery();
            if(rs.next()){
                encargado.setIdUsuario(rs.getInt("id_usuario"));
                encargado.setSexo(rs.getString("sexo").charAt(0));
                encargado.setNombre(rs.getString("nombre"));
                encargado.setApellidoPaterno(rs.getString("apellido_paterno"));
                encargado.setApellidoMaterno(rs.getString("apellido_materno"));
                encargado.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                encargado.setUsuario(rs.getString("usuario"));
                encargado.setPassword(rs.getString("pass"));
                encargado.setTitulo_trabajo(rs.getString("titulo_trabajo"));
                encargado.setHoraEntrada(rs.getTime("hora_entrada").toLocalTime());
                encargado.setHoraSalida(rs.getTime("hora_salida").toLocalTime());
                encargado.setFechaContratacion(rs.getDate("fecha_contratacion"));
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return encargado;
    } 
    
}
