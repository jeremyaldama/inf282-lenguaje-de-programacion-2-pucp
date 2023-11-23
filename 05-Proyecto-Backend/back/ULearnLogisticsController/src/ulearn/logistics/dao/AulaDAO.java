/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.logistics.dao;

import java.util.ArrayList;
import ulearn.logistics.model.Aula;

/*
 * @author Andrea Acosta
 */

public interface AulaDAO {
    int agregarAula(Aula aula);
    ArrayList<Aula> listarAulas();
    int eliminarAula(int idAula);
    int actualizarAula(Aula aula);
}
