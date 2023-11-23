using LP2GestClientesModel;
using LP2SoftRRHHModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2SoftLogisticaModel.Ventas
{
    public class OrdenVenta
    {
        private int _idOrdenVenta;
        private BindingList<LineaOrdenVenta> _lineasOrdenVenta;
        private Empleado _empleado;
        private Cliente _cliente;
        private double _total;
        private DateTime _fechaHora;
        private bool _activo;

        public int IdOrdenVenta { get => _idOrdenVenta; set => _idOrdenVenta = value; }
        public Empleado Empleado { get => _empleado; set => _empleado = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public double Total { get => _total; set => _total = value; }
        public DateTime FechaHora { get => _fechaHora; set => _fechaHora = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public BindingList<LineaOrdenVenta> LineasOrdenVenta { get => _lineasOrdenVenta; set => _lineasOrdenVenta = value; }
    }
}
