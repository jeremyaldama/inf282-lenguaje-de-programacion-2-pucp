using LP2SoftLogisticaModel.Almacen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftLogisticaModel.Ventas
{
    public class LineaOrdenVenta
    {
        private int _idLineaOrdenVenta;
        private Producto _producto;
        private int _cantidad;
        private double _subtotal;
        private bool _activo;

        public int IdLineaOrdenVenta { get => _idLineaOrdenVenta; set => _idLineaOrdenVenta = value; }
        public Producto Producto { get => _producto; set => _producto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public double Subtotal { get => _subtotal; set => _subtotal = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
