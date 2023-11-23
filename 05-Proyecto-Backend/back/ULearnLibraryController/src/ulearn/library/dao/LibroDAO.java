
package ulearn.library.dao;

import java.util.ArrayList;
import ulearn.library.model.Libro;

public interface LibroDAO {
    int insertar(Libro libro);
    int modificar(Libro libro);
    int eliminar(int idLibro);
    ArrayList<Libro> listarTodos();
}
