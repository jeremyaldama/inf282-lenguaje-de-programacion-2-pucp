using LP2SoftLogisticaModel.Almacen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftLogisticaController.Almacen.DAO
{
    public interface ProductoDAO
    {
        BindingList<Producto> listarPorNombre(String _nombre);
    }
}
