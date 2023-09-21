package pe.edu.pucp.lp2soft.main;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2soft.rrhh.dao.AreaDAO;
import pe.edu.pucp.lp2soft.rrhh.dao.EmpleadoDAO;
import pe.edu.pucp.lp2soft.rrhh.model.Area;
import pe.edu.pucp.lp2soft.rrhh.model.Empleado;
import pe.edu.pucp.lp2soft.rrhh.mysql.AreaMySQL;
import pe.edu.pucp.lp2soft.rrhh.mysql.EmpleadoMySQL;
public class Principal {
    public static void main(String[] args) throws Exception{
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
        
        AreaDAO daoArea = new AreaMySQL();
        ArrayList<Area> areas = daoArea.listarTodas();
        
        Empleado emp1 = new Empleado("77888888", "JEREMY", "ALDAMA", 'M', sdf.parse("19-10-1987"), areas.get(0), "CAJERO", 1500.00);
        EmpleadoMySQL daoEmpleado = new EmpleadoMySQL();
        int resultado = daoEmpleado.insertar(emp1);
        if(resultado == 1)
            System.out.println("Se ha registrado con exito");
    }

}