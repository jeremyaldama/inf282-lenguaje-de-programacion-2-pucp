package pe.edu.pucp.lp2soft.gestclientes.model;
import java.util.Date;
import pe.edu.pucp.lp2soft.rrhh.model.Persona;
public class Cliente extends Persona {
    private double lineaCredito;
    private Categoria categoria;

    public Cliente( 
            String DNI, String nombre, String apellidoPaterno, 
            char genero, Date fechaNacimiento, double lineaCredito, Categoria categoria) {
        super(DNI, nombre, apellidoPaterno, genero, fechaNacimiento);
        this.lineaCredito = lineaCredito;
        this.categoria = categoria;
    }
    
}
