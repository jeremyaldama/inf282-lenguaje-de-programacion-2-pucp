using LP2GestClientesController.DAO;
using LP2GestClientesModel;
using LP2SoftDBManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2GestClientesController.MySQL
{
    public class ClienteMySQL : ClienteDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;
        
        public BindingList<Cliente> listarPorNombreDNI(string _nombreDNI)
        {
            BindingList<Cliente> clientes = new BindingList<Cliente>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_CLIENTES_X_NOMBRE_DNI";
                comando.Parameters.AddWithValue("_nombreDNI", _nombreDNI);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Cliente cliente = new Cliente();
                    if (!lector.IsDBNull(lector.GetOrdinal("DNI")))
                        cliente.DNI = lector.GetString("DNI");
                    if (!lector.IsDBNull(lector.GetOrdinal("id_persona")))
                        cliente.IdPersona = lector.GetInt32("id_persona");
                    if (!lector.IsDBNull(lector.GetOrdinal("nombre")))
                        cliente.Nombre = lector.GetString("nombre");
                    if (!lector.IsDBNull(lector.GetOrdinal("apellido_paterno")))
                        cliente.ApellidoPaterno = lector.GetString("apellido_paterno");
                    if (!lector.IsDBNull(lector.GetOrdinal("genero")))
                        cliente.Genero = lector.GetChar("genero");
                    if (!lector.IsDBNull(lector.GetOrdinal("fecha_nacimiento")))
                        cliente.FechaNacimiento = lector.GetDateTime("fecha_nacimiento");
                    if (!lector.IsDBNull(lector.GetOrdinal("linea_credito")))
                        cliente.LineaCredito = lector.GetDouble("linea_credito");
                    if (!lector.IsDBNull(lector.GetOrdinal("categoria")))
                        cliente.Categoria = (Categoria)Enum.Parse(typeof(Categoria), lector.GetString("categoria"));
                    clientes.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                try
                {
                    con.Close();
                } catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return clientes;
        }
    }
}
