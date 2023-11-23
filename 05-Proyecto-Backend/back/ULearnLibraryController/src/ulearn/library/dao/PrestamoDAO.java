/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ulearn.library.dao;

import java.util.ArrayList;
import java.util.Date;
import ulearn.library.model.Prestamo;

/**
 *
 * @author Eilyn Davila
 */
public interface PrestamoDAO {
    
    int insertar(Prestamo prestamo,int diasPrestamo);
    int modificar(Prestamo prestamo);
    int eliminar(int idPrestamo);
    ArrayList<Prestamo> listarConFiltros(int idBiblioteca, int idResponsable,
            Date fecha_inferior,Date fecha_superior,int anulado, int devuelto,
            int conRetraso);
    int registrarRetiro(int idPrestamo);
    int registrarDevolucion(int idPrestamo);
    int anularPrestamo(int idPrestamo);
    ArrayList<Prestamo> listarPorIdLibro(int idLibro);
}
