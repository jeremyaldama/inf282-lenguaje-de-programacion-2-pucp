
package ulearn.logistics.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Time;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.logistics.dao.CharlaDAO;
import ulearn.logistics.model.Aula;
import ulearn.logistics.model.Charla;
import ulearn.logistics.model.Espacio;

/*
 * @author Andrea Acosta
 */
public class CharlaMySQL implements CharlaDAO{
    
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int agregarCharla(Charla charla) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();  
            cs = con.prepareCall("{ call INSERTAR_CHARLA(?,?,?,?,?,?,?,?,?) }");
            
            cs.registerOutParameter("_id_charla", java.sql.Types.INTEGER);
            
            cs.setInt("_fid_espacio",charla.getEspacio().getIdEspacio());
            cs.setString("_ponente",charla.getPonente());
            cs.setString("_organizador",charla.getOrganizador());
            cs.setString("_nombre",charla.getNombre());
            cs.setDate("_fecha", new java.sql.Date(charla.getFecha().getTime()));
            cs.setTime("_hora_inicio", Time.valueOf(charla.getHoraInicio()));
            cs.setTime("_hora_fin", Time.valueOf(charla.getHoraFin()));
            cs.setInt("_es_gratuito",charla.isEsGratis()? 1 : 0);
            
            resultado = cs.executeUpdate();
            charla.setIdEvento(cs.getInt("_id_charla"));
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
    public ArrayList<Charla> listarCharla() {
        ArrayList<Charla> charlas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_CHARLAS_TODAS() }");
            rs = cs.executeQuery();
            while(rs.next()){
                Charla charla = new Charla();               
                charla.setIdEvento(rs.getInt("id_evento"));
                charla.setEspacio(new Aula());
                charla.getEspacio().setIdEspacio(rs.getInt("id_espacio"));
                charla.getEspacio().setNombre(rs.getString("nombre_espacio"));
                charla.setPonente(rs.getString("ponente"));
                charla.setOrganizador(rs.getString("organizador"));
                charla.setNombre(rs.getString("nombre_evento"));
                charla.setFecha(rs.getDate("fecha"));
                charla.setHoraInicio(rs.getTime("hora_inicio").toLocalTime());
                charla.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                charla.setEsGratis(rs.getBoolean("es_gratuito"));
                charla.setInscritos(rs.getInt("inscritos")); 
                charlas.add(charla);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return charlas;
    }

    @Override
    public int eliminarCharla(int idCharla) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_CHARLA(?)}");
            cs.setInt("_id_charla", idCharla);
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
    public int actualizarCharla(Charla charla) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_CHARLA(?,?,?,?,?,?,?,?,?,?) }");
            
            cs.setInt("_id_charla", charla.getIdEvento());
            cs.setInt("_fid_espacio",charla.getEspacio().getIdEspacio());
            cs.setString("_ponente",charla.getPonente());
            cs.setString("_organizador",charla.getOrganizador());
            cs.setString("_nombre",charla.getNombre());
            cs.setDate("_fecha", new java.sql.Date(charla.getFecha().getTime()));
            cs.setTime("_hora_inicio", Time.valueOf(charla.getHoraInicio()));
            cs.setTime("_hora_fin", Time.valueOf(charla.getHoraFin()));
            cs.setInt("_es_gratuito",charla.isEsGratis()? 1 : 0);
            cs.setInt("_inscritos", charla.getInscritos()); 
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
    public ArrayList<Charla> listarCharlaXFecha(String fecha) {
    
        ArrayList<Charla> charlas = new ArrayList<>();
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call ListarCharlaXFecha(?) }");
            cs.setDate("_fecha", new java.sql.Date(sdf.parse(fecha).getTime()) );
            
            rs = cs.executeQuery();
            while(rs.next()){
                Charla charla = new Charla();               
                charla.setIdEvento(rs.getInt("id_evento"));
                charla.setEspacio(new Aula());
                charla.getEspacio().setIdEspacio(rs.getInt("id_espacio"));
                charla.getEspacio().setNombre(rs.getString("nombre_espacio"));
                charla.setPonente(rs.getString("ponente"));
                charla.setOrganizador(rs.getString("organizador"));
                charla.setNombre(rs.getString("nombre_evento"));
                charla.setFecha(rs.getDate("fecha"));
                charla.setHoraInicio(rs.getTime("hora_inicio").toLocalTime());
                charla.setHoraFin(rs.getTime("hora_fin").toLocalTime());
                charla.setEsGratis(rs.getBoolean("es_gratuito"));
                charla.setInscritos(rs.getInt("inscritos")); 
                charlas.add(charla);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return charlas;
        
    }

    @Override
    public int inscribirse(int id_charla) {
        
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSCRIBIRSE(?)}");
            cs.setInt("_id_evento", id_charla);
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
