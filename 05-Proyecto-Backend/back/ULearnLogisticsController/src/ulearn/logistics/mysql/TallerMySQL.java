/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.logistics.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.util.Date;
import java.sql.ResultSet;
import java.sql.Time;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.logistics.dao.TallerDAO;
import ulearn.logistics.model.Aula;
import ulearn.logistics.model.Charla;
import ulearn.logistics.model.Sala;
import ulearn.logistics.model.Taller;

/*
 * @author Andrea Acosta
 */
public class TallerMySQL implements TallerDAO{
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int agregarTaller(Taller taller) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();  
            cs = con.prepareCall("{ call INSERTAR_TALLER(?,?,?,?,?,?,?,?,?) }");
            
            cs.registerOutParameter("_id_taller", java.sql.Types.INTEGER);
            
            cs.setInt("_fid_espacio",taller.getEspacio().getIdEspacio());
            cs.setString("_organizador",taller.getOrganizador());
            cs.setString("_nombre",taller.getNombre());
            cs.setDate("_fecha", new java.sql.Date(taller.getFecha().getTime()));
            cs.setTime("_hora_inicio", Time.valueOf(taller.getHoraInicio()));
            cs.setTime("_hora_fin", Time.valueOf(taller.getHoraFin()));
            cs.setInt("_es_gratuito",taller.isEsGratis()? 1 : 0);
            cs.setString("_area_interes",taller.getAreaInteres());
            
            resultado = cs.executeUpdate();
            taller.setIdEvento(cs.getInt("_id_taller"));
            resultado = taller.getIdEvento();
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

    //Mejorar en futuras versiones
    @Override
    public ArrayList<Taller> listarTaller() {
        ArrayList<Taller> talleres = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_TALLERES_TODOS() }");
            rs = cs.executeQuery();
            while(rs.next()){
                Taller taller = new Taller();
                
                taller.setIdEvento(rs.getInt("id_evento"));
                taller.setEspacio(new Sala());
                taller.getEspacio().setIdEspacio(rs.getInt("id_espacio"));
                taller.getEspacio().setNombre(rs.getString("nombre_espacio"));
                taller.setOrganizador(rs.getString("organizador"));
                taller.setAreaInteres(rs.getString("area_interes"));
                taller.setNombre(rs.getString("nombre_evento"));
                taller.setFecha(rs.getDate("fecha"));
                taller.setHoraInicio(rs.getTime("hora_inicio").toLocalTime());
                taller.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                taller.setEsGratis(rs.getBoolean("es_gratuito"));
                taller.setInscritos(rs.getInt("inscritos"));
                talleres.add(taller);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return talleres;
    }

    @Override
    public int eliminarTaller(int idTaller) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_TALLER(?)}");
            cs.setInt("_id_taller", idTaller);
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
    public int actualizarTaller(Taller taller) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_TALLER(?,?,?,?,?,?,?,?,?,?) }");
            
            cs.setInt("_id_taller", taller.getIdEvento());
            cs.setInt("_fid_espacio",taller.getEspacio().getIdEspacio());
            cs.setString("_organizador",taller.getOrganizador());
            cs.setString("_nombre",taller.getNombre());
            cs.setDate("_fecha", new java.sql.Date(taller.getFecha().getTime()));
            cs.setTime("_hora_inicio", Time.valueOf(taller.getHoraInicio()));
            cs.setTime("_hora_fin", Time.valueOf(taller.getHoraFin()));
            cs.setInt("_es_gratuito",taller.isEsGratis()? 1 : 0);
            cs.setString("_area_interes",taller.getAreaInteres());
            cs.setInt("_inscritos", taller.getInscritos()); 
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
    public ArrayList<Taller> listarTallerXFECHA(String fecha) {
    
        ArrayList<Taller> talleres = new ArrayList<>();
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call ListarTallerXFecha(?) }");
            cs.setDate("_fecha", new java.sql.Date(sdf.parse(fecha).getTime()) );
            
            rs = cs.executeQuery();
            while(rs.next()){
                Taller taller = new Taller();
                taller.setIdEvento(rs.getInt("id_evento"));
                taller.setEspacio(new Sala());
                taller.getEspacio().setIdEspacio(rs.getInt("id_espacio"));
                taller.getEspacio().setNombre(rs.getString("nombre_espacio"));
                taller.setOrganizador(rs.getString("organizador"));
                taller.setAreaInteres(rs.getString("area_interes"));
                taller.setNombre(rs.getString("nombre_evento"));
                taller.setFecha(rs.getDate("fecha"));
                taller.setHoraInicio(rs.getTime("hora_inicio").toLocalTime());
                taller.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                taller.setEsGratis(rs.getBoolean("es_gratuito"));
                taller.setInscritos(rs.getInt("inscritos"));
                talleres.add(taller);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return talleres;
    
    }

    @Override
    public int inscribirse(int idTaller) {
        
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSCRIBIRSE(?)}");
            cs.setInt("_id_evento", idTaller);
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
