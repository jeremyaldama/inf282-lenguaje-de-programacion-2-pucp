using LP2SoftLogisticaModel.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftLogisticaController.Ventas.DAO
{
    public interface LineaOrdenVentaDAO
    {
        BindingList<LineaOrdenVenta> listarPorIdOrdenVenta(int idOrdenVenta);
    }
}
