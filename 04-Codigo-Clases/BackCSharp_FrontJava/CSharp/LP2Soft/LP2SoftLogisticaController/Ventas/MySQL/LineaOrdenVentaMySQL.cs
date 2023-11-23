using LP2SoftDBManager;
using LP2SoftLogisticaController.Ventas.DAO;
using LP2SoftLogisticaModel.Almacen;
using LP2SoftLogisticaModel.Ventas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftLogisticaController.Ventas.MySQL
{
    public class LineaOrdenVentaMySQL : LineaOrdenVentaDAO
    {
        private MySqlConnection con;
        private MySqlCommand comando;
        private MySqlDataReader lector;
        public BindingList<LineaOrdenVenta> listarPorIdOrdenVenta(int idOrdenVenta)
        {
            BindingList<LineaOrdenVenta> lineasOrdenVenta = new BindingList<LineaOrdenVenta>();
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "LISTAR_LINEAS_ORDEN_VENTA_X_ID_ORDEN_VENTA";
                comando.Parameters.AddWithValue("_id_orden_venta", idOrdenVenta);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    LineaOrdenVenta lov = new LineaOrdenVenta();
                    lov.IdLineaOrdenVenta = lector.GetInt32("id_linea_orden_venta");
                    lov.Producto = new Producto();
                    lov.Producto.IdProducto = lector.GetInt32("id_producto");
                    lov.Producto.Nombre = lector.GetString("nombre");
                    lov.Producto.UnidadMedida = lector.GetString("unidad_medida");
                    lov.Producto.Precio = lector.GetDouble("precio");
                    lov.Cantidad = lector.GetInt32("cantidad");
                    lov.Subtotal = lector.GetDouble("subtotal");
                    lineasOrdenVenta.Add(lov);
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
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return lineasOrdenVenta;
        }
    }
}
