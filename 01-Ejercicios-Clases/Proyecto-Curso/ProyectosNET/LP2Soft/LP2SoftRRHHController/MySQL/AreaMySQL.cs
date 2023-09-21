using LP2SoftDBManager;
using LP2SoftRRHHController.DAO;
using LP2SoftRRHHModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftRRHHController.MySQL
{
    public class AreaMySQL : AreaDAO
    {
        private MySqlConnection con;
        // similar al CallableStatement
        private MySqlCommand comando;
        // ResultSet de Java
        private MySqlDataReader lector;
        public int insertar(Area area)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                // comando = con.CreateCommand();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                //comando.CommandText = "INSERT INTO area(nombre,activa)" +
                //    " VALUES('" + area.Nombre + "', 1)";
                comando.CommandText = "INSERTAR_AREA";

                comando.Parameters.Add("_id_area", MySqlDbType.Int32)
                    .Direction = ParameterDirection.Output;

                comando.Parameters.AddWithValue("_nombre", area.Nombre);

                resultado = comando.ExecuteNonQuery();

                area.IdArea = 
                    Int32.Parse(comando.Parameters["_id_area"].Value.ToString());
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }
            return resultado;
        }

        public int modificar(Area area)
        {
            throw new NotImplementedException();
        }
        public int eliminar(int idArea)
        {
            throw new NotImplementedException();
        }


        public BindingList<Area> listaTodas()
        {
            BindingList<Area> areas = new BindingList<Area>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                // comando = con.CreateCommand();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_AREAS_TODAS";

                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Area area = new Area();
                    area.IdArea = lector.GetInt32("id_area");
                    area.Nombre = lector.GetString("nombre");
                    area.Activa = true;
                    areas.Add(area);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                try { con.Close(); } catch (Exception ex) { throw new Exception(ex.Message); }
            }
            return areas;
        }
    }
}
