package pe.edu.pucp.lp2soft.rrhh.mysql;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.rrhh.dao.EmpleadoDAO;
import pe.edu.pucp.lp2soft.rrhh.model.Empleado;
public class EmpleadoMySQL implements EmpleadoDAO{
    private Connection con;
    private PreparedStatement ps;
    private ResultSet rs;
    private String sql;
    @Override
    public int insertar(Empleado empleado) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            sql = "INSERT INTO persona(DNI,nombre,apellido_paterno,genero,fecha_nacimiento) VALUES(?,?,?,?,?)";
            ps = con.prepareStatement(sql);
            ps.setString(1,empleado.getDNI());
            ps.setString(2, empleado.getNombre());
            ps.setString(3, empleado.getApellidoPaterno());
            ps.setString(4, String.valueOf(empleado.getGenero()));
            ps.setDate(5, new java.sql.Date(empleado.getFechaNacimiento().getTime()));       
            resultado = ps.executeUpdate();
            // devuelve el ultimo id que ha generado la conexion actual
            sql = "SELECT @@last_insert_id AS id";
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            rs.next();
            empleado.setIdPersona(rs.getInt("id"));
            
            sql = "INSERT INTO empleado (id_empleado,fid_area,cargo,sueldo,activo) VALUES(?,?,?,?,1)";
            ps = con.prepareStatement(sql);
            ps.setInt(1,empleado.getIdPersona());
            ps.setInt(2, empleado.getArea().getIdArea());
            ps.setString(3, empleado.getCargo());
            ps.setDouble(4,empleado.getSueldo());
            
            resultado = ps.executeUpdate();     
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Empleado empleado) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public int eliminar(int idEmpleado) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    @Override
    public ArrayList<Empleado> listarTodos() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
}
