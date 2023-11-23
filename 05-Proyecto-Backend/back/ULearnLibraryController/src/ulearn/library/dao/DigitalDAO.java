
package ulearn.library.dao;

import java.util.ArrayList;
import ulearn.library.model.Digital;

public interface DigitalDAO {
    int insertar(Digital digital);
    int modificar(Digital digital);
    int eliminar(int idDigital);
    ArrayList<Digital> listarTodos();
}
