package pe.edu.pucp.lp2soft.rrhh.dao;
import java.util.ArrayList;
import pe.edu.pucp.lp2soft.rrhh.model.Area;
public interface AreaDAO {
    int insertar(Area area);
    int modificar(Area area);
    int eliminar(int idArea);
    ArrayList<Area> listarTodas();
}