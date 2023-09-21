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
//        
        AreaDAO daoArea = new AreaMySQL();
        
//        Area area = new Area("DIRECCION");
//        int resultado = daoArea.insertar(area);
//        if(resultado == 1)
//            System.out.println("Se ha registrado con exito"+
//               " el area " + area.getNombre() + " con el id "
//            + area.getIdArea());
        
        
        
        ArrayList<Area> areas = daoArea.listarTodas();
        for(Area a : areas){
            System.out.println(a.getIdArea() + ". " + a.getNombre());
        }
//        
//        areas.get(0).setNombre("CONTABILIDAD");
//        daoArea.eliminar(areas.get(0).getIdArea());
        
        
        Empleado emp1 = new Empleado("12345678", "JUAN", "PALERMO", 'M', sdf.parse("19-10-1987"), areas.get(0), "CAJERO", 1500.00);
        EmpleadoDAO daoEmpleado = new EmpleadoMySQL();
        int resultado = daoEmpleado.insertar(emp1);
        if(resultado == 1)
            System.out.println("El empleado se ha registrado con exito");

        ArrayList<Empleado> empleados = daoEmpleado.listarTodos();
        for(Empleado emp : empleados){
            emp.imprimirInformacion();
        }
        
        Empleado empModificar = empleados.get(empleados.size()-1);
        empModificar.setNombre("RODRIGO");
        resultado = daoEmpleado.modificar(empModificar);
        if(resultado == 1)
            System.out.println("El empleado se ha modificado con exito");
        
        Empleado empEliminar = empleados.get(empleados.size()-1);
        resultado = daoEmpleado.eliminar(empEliminar.getIdPersona());
        if(resultado == 1)
            System.out.println("El empleado se ha eliminado con exito");
    }

}