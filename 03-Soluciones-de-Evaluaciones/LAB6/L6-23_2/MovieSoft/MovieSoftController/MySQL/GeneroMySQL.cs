using MovieSoftController.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSoftModel;
using MovieSoftDBManager;

namespace MovieSoftController.MySQL
{
    public class GeneroMySQL : GeneroDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public int insertar(Genero genero)
        {
            throw new NotImplementedException();
        }

        public int modificar(Genero genero)
        {
            throw new NotImplementedException();
        }

        public int eliminar(int idGenero)
        {
            throw new NotImplementedException();
        }

        public BindingList<Genero> listarTodas()
        {
            BindingList<Genero> generos = new BindingList<Genero>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_GENEROS_TODOS";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Genero genero = new Genero();
                    genero.IdGenero = lector.GetInt32("id_genero");
                    genero.Nombre = lector.GetString("nombre");
                    genero.Activo = true;
                    generos.Add(genero);
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
            return generos;
        }
    }
}
