/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ulearn.logistics.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import ulearn.config.DBManager;
import ulearn.logistics.dao.AulaDAO;
import ulearn.logistics.model.Aula;

/**
 *
 * @author USER
 */
public class AulaMySQL implements AulaDAO{
    
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int agregarAula(Aula aula) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();  
            cs = con.prepareCall("{ call INSERTAR_AULA(?,?,?,?,?,?) }");
            cs.registerOutParameter("_id_aula", java.sql.Types.INTEGER);
            cs.setInt("_tiene_pizarra_inteligente",aula.getTienePizarraInteligente()? 1 : 0);
            cs.setInt("_tiene_proyector",aula.getTieneProyector()? 1 : 0);
            cs.setInt("_aforo",aula.getAforo());
            cs.setString("_nombre",aula.getNombre());
            cs.setInt("_fid_institucion", aula.getInstitucion().getIdInstitucion());
            resultado = cs.executeUpdate();
            aula.setIdEspacio(cs.getInt("_id_aula"));
            resultado = aula.getIdEspacio();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<Aula> listarAulas() {
        ArrayList<Aula> aulas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_AULAS_TODAS() }");
            rs = cs.executeQuery();
            while(rs.next()){
                Aula aula = new Aula();
                aula.setIdEspacio(rs.getInt("id_espacio"));
                aula.setNombre(rs.getString("nombre"));
                aula.setTienePizarraInteligente(rs.getBoolean("tiene_pizarra_inteligente"));
                aula.setTieneProyector(rs.getBoolean("tiene_proyector"));
                aula.setAforo(rs.getInt("aforo"));
                aulas.add(aula);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return aulas;
    }

    @Override
    public int eliminarAula(int idAula) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_AULA(?)}");
            cs.setInt("_id_aula", idAula);
            resultado = cs.executeUpdate();    
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int actualizarAula(Aula aula) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call MODIFICAR_AULA(?,?,?,?,?,?) }");
            cs.setInt("_id_aula", aula.getIdEspacio());
            cs.setInt("_tiene_pizarra_inteligente",aula.getTienePizarraInteligente()? 1 : 0);
            cs.setInt("_tiene_proyector",aula.getTieneProyector()? 1 : 0);
            cs.setInt("_fid_institucion", aula.getInstitucion().getIdInstitucion());
            cs.setInt("_aforo",aula.getAforo());
            cs.setString("_nombre",aula.getNombre());
            resultado = cs.executeUpdate(); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }
}
