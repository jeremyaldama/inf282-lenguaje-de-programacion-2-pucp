package pe.edu.pucp.lp2soft.rrhh.mysql;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.config.DBManager;
import pe.edu.pucp.lp2soft.rrhh.dao.EmpleadoDAO;
import pe.edu.pucp.lp2soft.rrhh.model.Area;
import pe.edu.pucp.lp2soft.rrhh.model.Empleado;
public class EmpleadoMySQL implements EmpleadoDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Empleado empleado) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_EMPLEADO(?,?,?,?,?,?,?,?,?)}");
            // se puede poner los nombres de los parametros o el indice
            cs.registerOutParameter("_id_empleado", INTEGER);
            cs.setString("_DNI",empleado.getDNI());
            cs.setString("_nombre", empleado.getNombre());
            cs.setString("_apellido_paterno", empleado.getApellidoPaterno());
            cs.setString("_genero", String.valueOf(empleado.getGenero()));
            cs.setDate("_fecha_nacimiento", new java.sql.Date(empleado.getFechaNacimiento().getTime()));       
            cs.setInt("_fid_area", empleado.getArea().getIdArea());
            cs.setString("_cargo", empleado.getCargo());
            cs.setDouble("_sueldo",empleado.getSueldo());
            resultado = cs.executeUpdate();
            empleado.setIdPersona(cs.getInt("_id_empleado"));   
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Empleado empleado) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_EMPLEADO(?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_empleado", empleado.getIdPersona());
            cs.setString("_DNI",empleado.getDNI());
            cs.setString("_nombre", empleado.getNombre());
            cs.setString("_apellido_paterno", empleado.getApellidoPaterno());
            cs.setString("_genero", String.valueOf(empleado.getGenero()));
            cs.setDate("_fecha_nacimiento", new java.sql.Date(empleado.getFechaNacimiento().getTime()));       
            cs.setInt("_fid_area", empleado.getArea().getIdArea());
            cs.setString("_cargo", empleado.getCargo());
            cs.setDouble("_sueldo",empleado.getSueldo());
            resultado = cs.executeUpdate();   
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idEmpleado) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_EMPLEADO(?)}");
            cs.setInt("_id_empleado", idEmpleado);
            resultado = cs.executeUpdate();   
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Empleado> listarTodos() {
        ArrayList<Empleado> empleados = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_EMPLEADOS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Empleado empleado = new Empleado();
                empleado.setIdPersona(rs.getInt("id_persona"));
                empleado.setDNI(rs.getString("DNI"));
                empleado.setNombre(rs.getString("nombre_empleado"));
                empleado.setApellidoPaterno(rs.getString("apellido_paterno"));
                empleado.setGenero(rs.getString("genero").charAt(0));
                empleado.setFechaNacimiento(rs.getDate("fecha_nacimiento"));
                empleado.setCargo(rs.getString("cargo"));
                empleado.setSueldo(rs.getDouble("sueldo"));
                empleado.setArea(new Area());
                empleado.getArea().setIdArea(rs.getInt("id_area"));
                empleado.getArea().setNombre(rs.getString("nombre_area"));
                empleado.setActivo(true);
                empleados.add(empleado);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return empleados;
    }
    
}
