package pe.edu.pucp.lp2soft.ventas.model;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.lp2soft.gestclientes.model.Cliente;
import pe.edu.pucp.lp2soft.rrhh.model.Empleado;
public class OrdenVenta {
    private int idOrdenVenta;
    private ArrayList<LineaOrdenVenta> lineasOrdenVenta;
    private Cliente cliente;
    private Empleado empleado;
    private double total;
    private Date fechaHora;
    private boolean activo;

    public int getIdOrdenVenta() {
        return idOrdenVenta;
    }

    public void setIdOrdenVenta(int idOrdenVenta) {
        this.idOrdenVenta = idOrdenVenta;
    }

    public ArrayList<LineaOrdenVenta> getLineasOrdenVenta() {
        return lineasOrdenVenta;
    }

    public void setLineasOrdenVenta(ArrayList<LineaOrdenVenta> lineasOrdenVenta) {
        this.lineasOrdenVenta = lineasOrdenVenta;
    }

    public double getTotal() {
        return total;
    }

    public void setTotal(double total) {
        this.total = total;
    }

    public Date getFechaHora() {
        return fechaHora;
    }

    public void setFechaHora(Date fechaHora) {
        this.fechaHora = fechaHora;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public Empleado getEmpleado() {
        return empleado;
    }

    public void setEmpleado(Empleado empleado) {
        this.empleado = empleado;
    }
    
    public void calcularTotal(){
        total = 0;
        for(LineaOrdenVenta lov : lineasOrdenVenta){
            lov.calcularSubtotal();
            total += lov.getSubtotal();
        }
    }
    
    public String generarReporte(){
        String cadena = "ORVEN DE VENTA" + "\n";
        cadena += "-----------------------------------" + "\n";
        cadena += "CLIENTE: " + cliente.getDNI() + " - " + 
                cliente.getNombre() + " " + cliente.getApellidoPaterno() + "\n";
        cadena += "CAJERO: " + empleado.getDNI() + " - " + 
                empleado.getNombre() + " " + empleado.getApellidoPaterno() + "\n";
        cadena += "-----------------------------------" + "\n";
        for(LineaOrdenVenta lov : lineasOrdenVenta){
            cadena += lov.getProducto().getNombre() + " " +
                    lov.getProducto().getUnidadMedida() + " - " +
            lov.getProducto().getPrecio() + " - CANT: " +
                    lov.getCantidad() + " = " + 
                    lov.getSubtotal() + "\n";
        }
        cadena += "-----------------------------------" + "\n";
        cadena += "TOTAL: " + total + "\n";
        return cadena;
    }
}