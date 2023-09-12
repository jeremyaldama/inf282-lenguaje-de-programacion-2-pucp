package pe.edu.pucp.lp2soft.rrhh.dao;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.rrhh.model.Empleado;
public interface EmpleadoDAO {
    int insertar(Empleado empleado);
    int modificar(Empleado empleado);
    int eliminar(int idEmpleado);
    ArrayList<Empleado> listarTodos();
}
