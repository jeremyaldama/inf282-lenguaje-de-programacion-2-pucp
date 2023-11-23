/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.logistics.dao;

import java.util.ArrayList;
import ulearn.logistics.model.Sala;

/*
 * @author Andrea Acosta
 */

public interface SalaDAO {
    int agregarSala(Sala sala);
    ArrayList<Sala> listarSalas();
    int eliminarSala(int idSala);
    int actualizarSala(Sala sala);
}