package principales;
import java.text.SimpleDateFormat;
import rrhh.Area;
import rrhh.Empleado;
public class Principal {
    public static void main(String[] args) throws Exception{
        
        SimpleDateFormat sdf = new SimpleDateFormat(
                "dd-MM-yyyy");
        Area area1 = new Area("CONTABILIDAD");
        Empleado empleado1 = new Empleado(
                "82765223", "JUAN", 
                "PEREZ", 
                sdf.parse("20-03-1992"));
        empleado1.setArea(area1);
        
        empleado1.imprimirDatos();
        
    }
}
