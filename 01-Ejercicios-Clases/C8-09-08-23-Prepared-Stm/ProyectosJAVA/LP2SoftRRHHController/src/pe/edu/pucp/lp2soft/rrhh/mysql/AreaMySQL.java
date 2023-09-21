package pe.edu.pucp.lp2soft.rrhh.mysql;
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
    @Override
    public int insertar(Area area) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            st = con.createStatement();
            sql = "INSERT INTO area(nombre,activa) VALUES("
                    + "'" + area.getNombre() + "',1)";
            resultado = st.executeUpdate(sql);
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
            st = con.createStatement();
            sql = "UPDATE area SET nombre = '" 
                    + area.getNombre()+"' WHERE id_area = "
                    + area.getIdArea();
            resultado = st.executeUpdate(sql);
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
            st = con.createStatement();
            sql = "UPDATE area SET activa = 0 WHERE id_area = "
                    + idArea;
            resultado = st.executeUpdate(sql);
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
            st = con.createStatement();
            sql = "SELECT id_area,nombre "
                    + "FROM area WHERE activa = 1";
            rs = st.executeQuery(sql);
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
