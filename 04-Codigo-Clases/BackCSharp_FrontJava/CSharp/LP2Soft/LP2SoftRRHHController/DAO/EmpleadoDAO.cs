using LP2SoftRRHHModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftRRHHController.DAO
{
    public interface EmpleadoDAO
    {
        int insertar(Empleado empleado);
        int modificar(Empleado empleado);
        int eliminar(int idEmpleado);
        BindingList<Empleado> listarPorNombreDNI(string nombreDNI);
        BindingList<Empleado> listarTodos();
        Empleado buscarPorId(int idEmpleado);
    }
}
