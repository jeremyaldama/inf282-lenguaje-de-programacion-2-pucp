package ulearn.library.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.library.dao.DigitalDAO;
import ulearn.library.model.Autor;
import ulearn.library.model.Biblioteca;
import ulearn.library.model.Digital;


public class DigitalMySQL implements DigitalDAO {
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(Digital digital) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_DIGITAL(?,?,?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_digital", INTEGER);
            cs.setInt("_fid_biblioteca",digital.getBiblioteca().getIdBiblioteca());
            cs.setInt("_disponible",digital.isDisponible()?1:0);
            cs.setString("_titulo",digital.getTitulo());
            cs.setString("_repositorio",digital.getRepositorio());
            cs.setInt("_descargable",digital.isDescargable()?1:0);
            cs.setDate("_fecha_publicacion", new java.sql.Date(digital.getFechaPublicacion().getTime()));
            cs.setString("_tipo_recurso",String.valueOf(digital.getTipoRecurso()));
            cs.setString("_ISBN",digital.getISBN());
            cs.setString("_URL", digital.getURL());
            cs.setBytes("_foto_portada",digital.getFoto());
            resultado = cs.executeUpdate();
            digital.setIdRecurso(cs.getInt("_id_digital"));
            for(Autor autor : digital.getAutores()){
                cs = con.prepareCall("{call AGREGAR_AUTOR_RECURSO(?,?)}");
                cs.setInt("_id_autor", autor.getIdAutor());
                cs.setInt("_id_recurso",digital.getIdRecurso());
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
    public int modificar(Digital digital) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_DIGITAL(?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_digital",digital.getIdRecurso());
            cs.setInt("_fid_biblioteca",digital.getBiblioteca().getIdBiblioteca());
            cs.setInt("_disponible",digital.isDisponible()?1:0);
            cs.setString("_titulo",digital.getTitulo());
            cs.setDate("_fecha_publicacion",new Date(digital.getFechaPublicacion().getTime()));
            cs.setString("_repositorio",digital.getRepositorio());
            cs.setInt("_descargable",digital.isDescargable()?1:0);
            cs.setBytes("_foto_portada",digital.getFoto());
            cs.setString("_ISBN", digital.getISBN());
            cs.setString("_URL", digital.getURL());
            resultado = cs.executeUpdate();
            for(Autor autor : digital.getAutores()){
                cs = con.prepareCall("{call AGREGAR_AUTOR_RECURSO(?,?)}");
                cs.setInt("_id_autor", autor.getIdAutor());
                cs.setInt("_id_recurso",digital.getIdRecurso());
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
    public int eliminar(int idDigital) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_DIGITAL(?)}");
            cs.setInt("_id_digital",idDigital);
            resultado = cs.executeUpdate();
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }

    @Override
    public ArrayList<Digital> listarTodos() {
        ArrayList<Digital>digitales = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_DIGITAL_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Digital digital = new Digital();
                digital.setIdRecurso(rs.getInt("id_digital"));
                digital.setBiblioteca(new Biblioteca());
                digital.getBiblioteca().setIdBiblioteca(rs.getInt("id_biblioteca"));
                digital.getBiblioteca().setNombre(rs.getString("nombre_biblioteca"));
                digital.setTitulo(rs.getString("titulo"));
                digital.setRepositorio(rs.getString("repositorio"));
                digital.setDescargable(rs.getInt("descargable")==1);
                digital.setDisponible(rs.getInt("disponible") == 1);
                digital.setTipoRecurso(rs.getString("tipo_recurso").charAt(0));
                digital.setFechaPublicacion(rs.getDate("fecha_publicacion"));
                digital.setISBN(rs.getString("ISBN"));
                digital.setURL(rs.getString("URL"));
                digital.setFoto(rs.getBytes("foto_portada"));
                digital.setActivo(true);
                digitales.add(digital);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return digitales;
    }
}
