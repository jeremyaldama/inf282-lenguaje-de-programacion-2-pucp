/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.library.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import static java.sql.Types.INTEGER;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.library.dao.AutorDAO;
import ulearn.library.model.Autor;

/**
 *
 * @author cesar
 */
public class AutorMySQL implements AutorDAO{

    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Autor autor) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_AUTOR(?,?,?)}");
            cs.registerOutParameter("_id_autor", INTEGER);
            cs.setString("_nombre", autor.getNombre());
            cs.setString("_nacionalidad", autor.getNacionalidad());
            resultado = cs.executeUpdate();
            autor.setIdAutor(cs.getInt("_id_autor"));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idAutor) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_AUTOR(?)}");
            cs.setInt("_id_autor", idAutor);
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Autor> listarTodos() {
         ArrayList<Autor> autores  = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_AUTORES_TODOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Autor autor = new Autor();
                autor.setIdAutor(rs.getInt("id_autor"));
                autor.setNombre(rs.getString("nombre"));
                autor.setNacionalidad(rs.getString("nacionalidad"));
                autores.add(autor);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return autores;
    }
    
    @Override
    public ArrayList<Autor> listarPorNombre(String nombre) {
        ArrayList<Autor> autores  = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_AUTORES_X_NOMBRE(?)}");
            cs.setString("_nombre",nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Autor autor = new Autor();
                autor.setIdAutor(rs.getInt("id_autor"));
                autor.setNombre(rs.getString("nombre"));
                autor.setNacionalidad(rs.getString("nacionalidad"));
                autores.add(autor);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return autores;
    }
    
    @Override
    public int modificar(Autor autor) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_AUTOR(?,?,?)}");
            cs.setInt("_id_autor",autor.getIdAutor());
            cs.setString("_nombre", autor.getNombre());
            cs.setString("_nacionalidad", autor.getNacionalidad());
            resultado = cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Autor> listarPorIdRecurso(int idRecurso) {
        ArrayList<Autor> autores  = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_AUTORES_RECURSO(?)}");
            cs.setInt("_id_recurso",idRecurso);
            rs = cs.executeQuery();
            while(rs.next()){
                Autor autor = new Autor();
                autor.setIdAutor(rs.getInt("id_autor"));
                autor.setNombre(rs.getString("nombre"));
                autor.setNacionalidad(rs.getString("nacionalidad"));
                autores.add(autor);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return autores;
    }
    
}
