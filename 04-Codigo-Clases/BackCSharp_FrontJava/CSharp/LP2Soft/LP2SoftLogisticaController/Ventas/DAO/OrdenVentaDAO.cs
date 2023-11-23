using LP2SoftLogisticaModel.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftLogisticaController.Ventas.DAO
{
    public interface OrdenVentaDAO
    {
        int insertar(OrdenVenta ordenVenta);
        int modificar(OrdenVenta ordenVenta);
        int eliminar(int idOrdenVenta);
        BindingList<OrdenVenta> listarTodas();
        BindingList<OrdenVenta> listarPorIdDNINombreCliente
            (String idDNINombreCliente);
    }
}
