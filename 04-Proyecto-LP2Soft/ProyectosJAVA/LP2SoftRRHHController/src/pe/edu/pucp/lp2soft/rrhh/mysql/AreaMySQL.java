package pe.edu.pucp.lp2soft.rrhh.mysql;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.rrhh.dao.AreaDAO;
import pe.edu.pucp.lp2soft.rrhh.model.Area;
public class AreaMySQL implements AreaDAO{
    private Connection con;
    private Statement st;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Area area) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call INSERTAR_AREA(?,?) }");
            cs.registerOutParameter("_id_area", java.sql.Types.INTEGER);
            cs.setString("_nombre", area.getNombre());
            resultado = cs.executeUpdate();
            area.setIdArea(cs.getInt("_id_area"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Area area) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_AREA(?,?)}");
            cs.setInt("_id_area", area.getIdArea());
            cs.setString("_nombre", area.getNombre());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idArea) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("call ELIMINAR_AREA(?)");
            cs.setInt("_id_area", idArea);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex)
            {System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Area> listarTodas() {
        ArrayList<Area> areas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_AREAS_TODAS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Area area = new Area();
                area.setIdArea(rs.getInt("id_area"));
                area.setNombre(rs.getString("nombre"));
                area.setActivo(true);
                areas.add(area);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return areas;
    }
    
}
