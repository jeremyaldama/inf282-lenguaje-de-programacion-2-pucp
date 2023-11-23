using LP2SoftRRHHModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2GestClientesModel
{
    public class Cliente : Persona
    {
        private Categoria _categoria;
        private double _lineaCredito;

        public Categoria Categoria { get => _categoria; set => _categoria = value; }
        public double LineaCredito { get => _lineaCredito; set => _lineaCredito = value; }
    }
}
