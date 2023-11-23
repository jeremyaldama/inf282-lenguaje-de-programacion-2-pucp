using LP2SoftDBManager;
using LP2SoftRRHHController.DAO;
using LP2SoftRRHHModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftRRHHController.MySQL
{
    public class EmpleadoMySQL : EmpleadoDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;

        public int insertar(Empleado empleado)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "INSERTAR_EMPLEADO";
                comando.Parameters.Add("_id_empleado", MySqlDbType.Int32).Direction =
                    System.Data.ParameterDirection.Output;
                comando.Parameters.AddWithValue("_fid_area", empleado.Area.IdArea);
                comando.Parameters.AddWithValue("_DNI", empleado.DNI);
                comando.Parameters.AddWithValue("_nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("_apellido_paterno", empleado.ApellidoPaterno);
                comando.Parameters.AddWithValue("_genero", empleado.Genero);
                comando.Parameters.AddWithValue("_fecha_nacimiento", empleado.FechaNacimiento);
                comando.Parameters.AddWithValue("_cargo", empleado.Cargo);
                comando.Parameters.AddWithValue("_sueldo", empleado.Sueldo);
                resultado = comando.ExecuteNonQuery();
                empleado.IdPersona = Int32.Parse(
                    comando.Parameters["_id_empleado"].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                try { con.Close(); } catch(Exception ex) { throw new Exception(ex.Message); }
            }
            return resultado;
        }
        public int eliminar(int idEmpleado)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "ELIMINAR_EMPLEADO";
                comando.Parameters.AddWithValue("_id_empleado", idEmpleado);
                resultado = comando.ExecuteNonQuery();
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
        
        public BindingList<Empleado> listarTodos()
        {
            BindingList<Empleado> empleados = new BindingList<Empleado>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_EMPLEADOS_TODOS";
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado.DNI = lector.GetString("DNI");
                    empleado.Nombre = lector.GetString("nombre_empleado");
                    empleado.ApellidoPaterno = lector.GetString("apellido_paterno");
                    empleado.Area = new Area();
                    empleado.Area.IdArea = lector.GetInt32("id_area");
                    empleado.Area.Nombre = lector.GetString("nombre_area");
                    empleados.Add(empleado);
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
            return empleados;
        }

        public int modificar(Empleado empleado)
        {
            int resultado = 0;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "MODIFICAR_EMPLEADO";
                comando.Parameters.AddWithValue("_id_empleado", empleado.IdPersona);
                comando.Parameters.AddWithValue("_fid_area", empleado.Area.IdArea);
                comando.Parameters.AddWithValue("_DNI", empleado.DNI);
                comando.Parameters.AddWithValue("_nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("_apellido_paterno", empleado.ApellidoPaterno);
                comando.Parameters.AddWithValue("_genero", empleado.Genero);
                comando.Parameters.AddWithValue("_fecha_nacimiento", empleado.FechaNacimiento);
                comando.Parameters.AddWithValue("_cargo", empleado.Cargo);
                comando.Parameters.AddWithValue("_sueldo", empleado.Sueldo);
                resultado = comando.ExecuteNonQuery();
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

        public BindingList<Empleado> listarPorNombreDNI(string nombreDNI)
        {
            BindingList<Empleado> empleados = new BindingList<Empleado>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_EMPLEADOS_X_NOMBREDNI";
                comando.Parameters.AddWithValue("_nombreDNI", nombreDNI);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado.DNI = lector.GetString("DNI");
                    empleado.Nombre = lector.GetString("nombre_empleado");
                    empleado.ApellidoPaterno = lector.GetString("apellido_paterno");
                    empleado.Area = new Area();
                    empleado.Area.IdArea = lector.GetInt32("id_area");
                    empleado.Area.Nombre = lector.GetString("nombre_area");
                    empleado.IdPersona = lector.GetInt32("id_persona");
                    empleado.Genero = lector.GetChar("genero");
                    empleado.FechaNacimiento = lector.GetDateTime("fecha_nacimiento");
                    empleado.Cargo = lector.GetString("cargo");
                    empleado.Sueldo = lector.GetDouble("sueldo");
                    empleados.Add(empleado);
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
            return empleados;
        }

        public Empleado buscarPorId(int idEmpleado)
        {
            Empleado empleado = new Empleado();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "BUSCAR_EMPLEADO_X_ID";
                comando.Parameters.AddWithValue("_id_empleado", idEmpleado);
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    empleado.IdPersona = lector.GetInt32("id_persona");
                    empleado.DNI = lector.GetString("DNI");
                    empleado.Nombre = lector.GetString("nombre_empleado");
                    empleado.ApellidoPaterno = lector.GetString("apellido_paterno");
                    empleado.Area = new Area();
                    empleado.Area.IdArea = lector.GetInt32("id_area");
                    empleado.Area.Nombre = lector.GetString("nombre_area");
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
            return empleado;
        }
    }
}
