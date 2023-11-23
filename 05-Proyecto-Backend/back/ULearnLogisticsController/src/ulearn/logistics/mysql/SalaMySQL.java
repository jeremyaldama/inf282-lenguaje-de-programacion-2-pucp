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
import ulearn.logistics.dao.SalaDAO;
import ulearn.logistics.model.Sala;

/*
 * @author Andrea Acosta
 */

public class SalaMySQL implements SalaDAO{
    
    private Connection con;
    private String sql;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int agregarSala(Sala sala) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();  
            cs = con.prepareCall("{call INSERTAR_SALA(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_sala", java.sql.Types.INTEGER);
            cs.setString("_tipo_sala",sala.getTipoSala());
            cs.setInt("_tiene_sistema_audio",sala.isTieneSistemaAudio() ? 1 : 0);
            cs.setInt("_aforo",sala.getAforo());
            cs.setString("_nombre",sala.getNombre());
            cs.setInt("_fid_institucion", sala.getInstitucion().getIdInstitucion());
            resultado = cs.executeUpdate();
            sala.setIdEspacio(cs.getInt("_id_sala"));
            resultado = sala.getIdEspacio();
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
    public ArrayList<Sala> listarSalas() {
        ArrayList<Sala> salas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{ call LISTAR_SALAS_TODAS() }");
            rs = cs.executeQuery();
            while(rs.next()){
                Sala sala = new Sala();
                sala.setIdEspacio(rs.getInt("id_espacio"));
                sala.setNombre(rs.getString("nombre"));
                sala.setTipoSala(rs.getString("tipo_sala"));
                sala.setTieneSistemaAudio(rs.getBoolean("tiene_sistema_audio"));
                sala.setAforo(rs.getInt("aforo"));
                salas.add(sala);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return salas;
    }

    @Override
    public int eliminarSala(int idSala) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_SALA(?)}");
            cs.setInt("_id_sala", idSala); 
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
    public int actualizarSala(Sala sala) {
        int resultado = 0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_SALA(?,?,?,?,?,?)}");
            cs.setInt("_id_sala", sala.getIdEspacio()); 
            cs.setString("_tipo_sala", sala.getTipoSala()); 
            cs.setInt("_tiene_sistema_audio",sala.isTieneSistemaAudio() ? 1 : 0);
            cs.setInt("_fid_institucion", sala.getInstitucion().getIdInstitucion());
            cs.setInt("_aforo",sala.getAforo());
            cs.setString("_nombre",sala.getNombre());
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

