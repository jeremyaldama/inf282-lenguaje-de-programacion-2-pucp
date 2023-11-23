
package ulearn.library.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.library.dao.PrestamoDAO;
import ulearn.library.model.Biblioteca;
import ulearn.library.model.Libro;
import ulearn.library.model.Prestamo;

/**
 *
 * @author Eilyn Davila
 */
public class PrestamoMySQL implements PrestamoDAO {

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(Prestamo prestamo, int diasPrestamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PRESTAMO(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_prestamo", INTEGER);
            cs.setInt("_dias_prestamo", diasPrestamo);
            cs.setInt("_id_libro",prestamo.getLibro().getIdRecurso());
            cs.setInt("_id_encargado_libro",prestamo.getIdResponsable());
            cs.setString("_tipo_encargado",String.valueOf(prestamo.getTipoResponsable()));
            cs.setInt("_id_biblioteca",prestamo.getBiblioteca().getIdBiblioteca());
            resultado = cs.executeUpdate();
            prestamo.setIdPrestamo(cs.getInt("_id_prestamo"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Prestamo prestamo) {
        int resultado = 0;
        try{ 
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_PRESTAMO(?,?,?,?,?,?)}");
            cs.setInt("_id_prestamo",prestamo.getIdPrestamo());
            cs.setDate("_fecha_retiro", new Date(prestamo.getFechaRetiro().getTime()));
            cs.setDate("_fecha_devolucion_confirmada", new Date(prestamo.getFechaDevolucionConfirmada().getTime()));
            cs.setDate("_fecha_registro", new Date(prestamo.getFechaRegistro().getTime()));
            cs.setDate("_fecha_maxima_devolucion", new Date(prestamo.getFechaMaximaDevolucion().getTime()));
            cs.setBoolean("_anulado",prestamo.isAnulado());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idPrestamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PRESTAMO(?)}");
            cs.setInt("_id_prestamo",idPrestamo);
            resultado = cs.executeUpdate();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public ArrayList<Prestamo> listarConFiltros(int idBiblioteca, int idResponsable, 
            java.util.Date fecha_inferior, java.util.Date fecha_superior, 
            int anulado, int devuelto, int conRetraso) {
        ArrayList<Prestamo>prestamos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRESTAMOS_CON_FILTROS(?,?,?,?,?,?,?)}");
            cs.setInt("_id_biblioteca",idBiblioteca);
            cs.setInt("_id_responsable",idResponsable);
            cs.setDate("_fecha_lim_inferior", new Date(fecha_inferior.getTime()));
            cs.setDate("_fecha_lim_superior", new Date(fecha_superior.getTime()));
            cs.setInt("_anulado", anulado);
            cs.setInt("_devuelto", devuelto);
            cs.setInt("_con_retraso", conRetraso);
            rs = cs.executeQuery();
            while(rs.next()){
                Prestamo prestamo = new Prestamo();
                prestamo.setIdPrestamo(rs.getInt("id_prestamo"));
                prestamo.setLibro(new Libro());
                prestamo.getLibro().setIdRecurso(rs.getInt("id_libro"));
                prestamo.getLibro().setTitulo(rs.getString("titulo"));
                prestamo.getLibro().setDisponible(rs.getBoolean("disponible"));
                prestamo.getLibro().setFechaPublicacion(rs.getDate("fecha_publicacion_libro"));
                prestamo.getLibro().setTipoRecurso('L');
                prestamo.getLibro().setISBN(rs.getString("ISBN"));
                prestamo.getLibro().setNroCopias(rs.getInt("nroCopias"));
                prestamo.getLibro().setNroPaginas(rs.getInt("nroPaginas"));
                prestamo.getLibro().setFoto(rs.getBytes("foto_portada"));
                prestamo.setBiblioteca(new Biblioteca());
                prestamo.getBiblioteca().setIdBiblioteca(rs.getInt("id_biblioteca"));
                prestamo.getBiblioteca().setNombre(rs.getString("nombre_biblioteca"));
                prestamo.setIdResponsable(rs.getInt("id_encargado_libro"));
                prestamo.setTipoResponsable(rs.getString("tipo_encargado").charAt(0));
                prestamo.setFechaRetiro(rs.getDate("fecha_retiro"));
                prestamo.setFechaDevolucionConfirmada(rs.getDate("fecha_devolucion_confirmada"));
                prestamo.setFechaMaximaDevolucion(rs.getDate("fecha_maxima_devolucion"));
                prestamo.setFechaRegistro(rs.getDate("fecha_registro"));
                prestamo.setAnulado(rs.getBoolean("anulado"));
                prestamos.add(prestamo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return prestamos;
    }

    @Override
    public int registrarRetiro(int idPrestamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call REGISTRAR_RETIRO(?)}");
            cs.setInt("_id_prestamo",idPrestamo);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }
    
    @Override
    public int registrarDevolucion(int idPrestamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call REGISTRAR_DEVOLUCION(?)}");
            cs.setInt("_id_prestamo",idPrestamo);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public int anularPrestamo(int idPrestamo) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ANULAR_PRESTAMO(?)}");
            cs.setInt("_id_prestamo",idPrestamo);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }
    
    @Override
    public ArrayList<Prestamo> listarPorIdLibro(int idLibro) {
        ArrayList<Prestamo>prestamos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PRESTAMOS_X_LIBRO(?)}");
            cs.setInt("_id_libro",idLibro);
            rs = cs.executeQuery();
            while(rs.next()){
                Prestamo prestamo = new Prestamo();
                prestamo.setIdPrestamo(rs.getInt("id_prestamo"));
                prestamo.setLibro(new Libro());
                prestamo.getLibro().setIdRecurso(rs.getInt("id_libro"));
                prestamo.setBiblioteca(new Biblioteca());
                prestamo.getBiblioteca().setIdBiblioteca(rs.getInt("id_biblioteca"));
                prestamo.setIdResponsable(rs.getInt("id_encargado_libro"));
                prestamo.setTipoResponsable(rs.getString("tipo_encargado").charAt(0));
                prestamo.setFechaRetiro(rs.getDate("fecha_retiro"));
                prestamo.setFechaDevolucionConfirmada(rs.getDate("fecha_devolucion_confirmada"));
                prestamo.setFechaMaximaDevolucion(rs.getDate("fecha_maxima_devolucion"));
                prestamo.setFechaRegistro(rs.getDate("fecha_registro"));
                prestamo.setAnulado(rs.getBoolean("anulado"));
                prestamos.add(prestamo);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return prestamos;
    }
    
}
