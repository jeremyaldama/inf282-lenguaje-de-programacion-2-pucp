using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftRRHHModel
{
    public class CuentaUsuario
    {
        private int _idCuentaUsuario;
        private string _username;
        private string _password;
        private bool _activo;

        public int IdCuentaUsuario { get => _idCuentaUsuario; set => _idCuentaUsuario = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
