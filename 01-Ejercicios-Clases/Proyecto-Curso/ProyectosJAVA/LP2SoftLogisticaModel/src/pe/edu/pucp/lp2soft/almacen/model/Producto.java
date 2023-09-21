package pe.edu.pucp.lp2soft.almacen.model;
public class Producto {
    private int idProducto;
    private String nombre;
    private String unidadMedida;
    private double precio;
    private boolean activo;

    public Producto(String nombre, String unidadMedida, double precio) {
        this.nombre = nombre;
        this.unidadMedida = unidadMedida;
        this.precio = precio;
    }
    
    public int getIdProducto() {
        return idProducto;
    }

    public void setIdProducto(int idProducto) {
        this.idProducto = idProducto;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getUnidadMedida() {
        return unidadMedida;
    }

    public void setUnidadMedida(String unidadMedida) {
        this.unidadMedida = unidadMedida;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
}
