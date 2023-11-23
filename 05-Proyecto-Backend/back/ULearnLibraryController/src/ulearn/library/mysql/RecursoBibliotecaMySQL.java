
package ulearn.library.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.library.dao.RecursoBibliotecaDAO;
import ulearn.library.model.Biblioteca;
import ulearn.library.model.Digital;
import ulearn.library.model.Libro;
import ulearn.library.model.RecursoBiblioteca;

public class RecursoBibliotecaMySQL implements RecursoBibliotecaDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    
    @Override
    public ArrayList<RecursoBiblioteca> listarPorTituloAutorConFiltros(String tituloAutor,
            int disponibilidad,int idBiblioteca, char tipoRecurso) {
        ArrayList<RecursoBiblioteca>recursos = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_RECURSOS_X_TITULO_AUTOR_DISPONIBILIDAD_BIBLIOTECA_TIPO(?,?,?,?)}");
            cs.setString("_titulo_autor", tituloAutor);
            cs.setInt("_disponibilidad", disponibilidad);
            cs.setInt("_id_biblioteca", idBiblioteca);
            cs.setString("_tipo_recurso",String.valueOf(tipoRecurso));
            rs = cs.executeQuery();
            while(rs.next()){
                RecursoBiblioteca recurso = null;
                char tipo = rs.getString("tipo_recurso").charAt(0);
                if(tipo == 'L'){
                    recurso = new Libro();
                    ((Libro)recurso).setNroCopias(rs.getInt("nroCopias"));
                    ((Libro)recurso).setNroPaginas(rs.getInt("nroPaginas"));
                    ((Libro)recurso).setActivo(true);
                    
                }
                else if(tipo == 'D'){
                    recurso = new Digital();
                    ((Digital)recurso).setRepositorio(rs.getString("repositorio"));
                    ((Digital)recurso).setDescargable(rs.getInt("descargable")==1);
                    ((Digital)recurso).setURL(rs.getString("URL"));
                    ((Digital)recurso).setActivo(true);
                }
                if(recurso != null){
                    recurso.setIdRecurso(rs.getInt("id_recurso"));
                    recurso.setDisponible(rs.getInt("disponible")==1);
                    recurso.setFechaPublicacion(rs.getDate("fecha_publicacion"));
                    recurso.setTitulo(rs.getString("titulo"));
                    recurso.setTipoRecurso(tipo);
                    recurso.setBiblioteca(new Biblioteca());
                    recurso.getBiblioteca().setIdBiblioteca(rs.getInt("id_biblioteca"));
                    recurso.getBiblioteca().setNombre(rs.getString("nombre_biblioteca"));
                    recurso.setISBN(rs.getString("ISBN"));
                    recurso.setFoto(rs.getBytes("foto_portada"));
                    recursos.add(recurso);
                }
                
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return recursos;
    }
    
}
