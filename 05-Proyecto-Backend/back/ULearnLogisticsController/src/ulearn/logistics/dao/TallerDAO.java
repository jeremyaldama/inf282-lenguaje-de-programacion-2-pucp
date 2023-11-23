/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.logistics.dao;

import java.sql.Date;
import java.util.ArrayList;
import ulearn.logistics.model.Taller;

/*
 * @author Andrea Acosta
 */
public interface TallerDAO {
    ArrayList<Taller> listarTaller();
    ArrayList<Taller> listarTallerXFECHA(String fecha);
    int eliminarTaller(int idTaller);
    int actualizarTaller(Taller taller);  
    int agregarTaller(Taller taller);
    int inscribirse(int idTaller);
}
