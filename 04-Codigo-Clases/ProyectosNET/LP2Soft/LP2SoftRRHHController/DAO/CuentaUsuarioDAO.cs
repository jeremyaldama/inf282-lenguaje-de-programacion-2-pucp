using LP2SoftRRHHModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftRRHHController.DAO
{
    public interface CuentaUsuarioDAO
    {
        int verificar(CuentaUsuario cuentaUsuario);
    }
}
