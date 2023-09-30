using LP2GestClientesModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2GestClientesController.DAO
{
    public interface ClienteDAO
    {
        BindingList<Cliente> listarPorNombreDNI(string _nombreDNI);
    }
}
