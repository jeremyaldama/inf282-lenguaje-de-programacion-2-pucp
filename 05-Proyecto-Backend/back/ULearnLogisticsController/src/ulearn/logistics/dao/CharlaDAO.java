/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.logistics.dao;
import java.util.ArrayList;
import ulearn.logistics.model.Charla;

/*
 * @author Andrea Acosta
 */

public interface CharlaDAO {
    int agregarCharla(Charla charla);
    ArrayList<Charla> listarCharla();
    ArrayList<Charla> listarCharlaXFecha(String fecha);
    int eliminarCharla(int idCharla);
    int actualizarCharla(Charla charla);  
    int inscribirse(int id_charla);
}
