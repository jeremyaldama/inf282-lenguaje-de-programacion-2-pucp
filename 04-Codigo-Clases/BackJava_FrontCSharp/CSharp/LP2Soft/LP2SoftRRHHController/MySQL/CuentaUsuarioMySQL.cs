using LP2SoftDBManager;
using LP2SoftRRHHController.DAO;
using LP2SoftRRHHModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftRRHHController.MySQL
{
    public class CuentaUsuarioMySQL : CuentaUsuarioDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public int verificar(CuentaUsuario cuentaUsuario)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "VERIFICAR_CUENTA_USUARIO";
                comando.Parameters.AddWithValue("_username", cuentaUsuario.Username);
                comando.Parameters.AddWithValue("_password", cuentaUsuario.Password);
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    resultado = lector.GetInt32("fid_empleado");
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
            return resultado;
        }
    }
}
