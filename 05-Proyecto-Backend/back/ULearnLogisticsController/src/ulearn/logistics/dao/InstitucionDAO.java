/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package ulearn.logistics.dao;

import java.util.ArrayList;
import ulearn.logistics.model.Institucion;

/**
 *
 * Author: Jeremy Aldama (20206228)
 */
public interface InstitucionDAO {
    int insertar(Institucion institucion);
    ArrayList<Institucion> listarTodas();
    int eliminar(int idInstitucion);
    int modificar(Institucion institucion);
}
