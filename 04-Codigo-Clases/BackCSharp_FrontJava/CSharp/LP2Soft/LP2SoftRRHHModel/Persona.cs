using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftRRHHModel
{
    public class Persona
    {
        private int _idPersona;
        private string _DNI;
        private string _nombre;
        private string _apellidoPaterno;
        private char _genero;
        private DateTime _fechaNacimiento;

        public int IdPersona { get => _idPersona; set => _idPersona = value; }
        public string DNI { get => _DNI; set => _DNI = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoPaterno { get => _apellidoPaterno; set => _apellidoPaterno = value; }
        public char Genero { get => _genero; set => _genero = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
    }
}
