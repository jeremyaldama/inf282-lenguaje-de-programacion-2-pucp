
package ulearn.library.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.library.dao.LibroDAO;
import ulearn.library.model.Autor;
import ulearn.library.model.Biblioteca;
import ulearn.library.model.Libro;


public class LibroMySQL implements LibroDAO{
    
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public int insertar(Libro libro) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_LIBRO(?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_libro", INTEGER);
            cs.setInt("_fid_biblioteca",libro.getBiblioteca().getIdBiblioteca());
            cs.setInt("_disponible",libro.isDisponible()?1:0);
            cs.setString("_titulo",libro.getTitulo());
            cs.setInt("_nroCopias",libro.getNroCopias());
            cs.setInt("_nroPaginas",libro.getNroPaginas());
            cs.setString("_ISBN",libro.getISBN());
            cs.setDate("_fecha_publicacion", new java.sql.Date(libro.getFechaPublicacion().getTime()));
            cs.setString("_tipo_recurso",String.valueOf(libro.getTipoRecurso()));
            cs.setBytes("_foto_portada", libro.getFoto());
            resultado = cs.executeUpdate();
            libro.setIdRecurso(cs.getInt("_id_libro"));
            for(Autor autor : libro.getAutores()){
                cs = con.prepareCall("{call AGREGAR_AUTOR_RECURSO(?,?)}");
                cs.setInt("_id_autor", autor.getIdAutor());
                cs.setInt("_id_recurso",libro.getIdRecurso());
                cs.executeUpdate();
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Libro libro) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_LIBRO(?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_libro",libro.getIdRecurso());
            cs.setInt("_fid_biblioteca",libro.getBiblioteca().getIdBiblioteca());
            cs.setInt("_disponible",libro.isDisponible()?1:0);
            cs.setString("_titulo",libro.getTitulo());
            cs.setDate("_fecha_publicacion",new Date(libro.getFechaPublicacion().getTime()));
            cs.setInt("_nroCopias",libro.getNroCopias());
            cs.setInt("_nroPaginas",libro.getNroPaginas());
            cs.setString("_ISBN",libro.getISBN());
            cs.setBytes("_foto_portada",libro.getFoto());
            resultado = cs.executeUpdate();
            for(Autor autor : libro.getAutores()){
                cs = con.prepareCall("{call AGREGAR_AUTOR_RECURSO(?,?)}");
                cs.setInt("_id_autor", autor.getIdAutor());
                cs.setInt("_id_recurso",libro.getIdRecurso());
                cs.executeUpdate();
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idLibro) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_LIBRO(?)}");
            cs.setInt("_id_libro",idLibro);
            resultado = cs.executeUpdate();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public ArrayList<Libro> listarTodos() {
        ArrayList<Libro>libros = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LIBROS_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Libro libro = new Libro();
                libro.setIdRecurso(rs.getInt("id_libro"));
                libro.setBiblioteca(new Biblioteca());
                libro.getBiblioteca().setIdBiblioteca(rs.getInt("id_biblioteca"));
                libro.getBiblioteca().setNombre(rs.getString("nombre_biblioteca"));
                libro.setISBN(rs.getString("ISBN"));
                libro.setTitulo(rs.getString("titulo"));
                libro.setNroCopias(rs.getInt("nroCopias"));
                libro.setNroPaginas(rs.getInt("nroPaginas"));
                libro.setDisponible(rs.getInt("disponible") == 1);
                libro.setTipoRecurso(rs.getString("tipo_recurso").charAt(0));
                libro.setFechaPublicacion(rs.getDate("fecha_publicacion"));
                libro.setFoto(rs.getBytes("foto_portada"));
                libro.setActivo(true);
                libros.add(libro);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return libros;
    }
    
}
