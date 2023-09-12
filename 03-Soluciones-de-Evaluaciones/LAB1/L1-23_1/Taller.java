import java.time.LocalTime;
import java.util.Date;
import java.text.SimpleDateFormat;
class Taller extends ProgramaAcademico{
	private Date fechaRealizacion;
	private LocalTime horaInicio;
	private LocalTime horaFin;
	
	public Taller(String nombre, String clave, char modalidad, double precio,Date fechaRealizacion, LocalTime horaInicio, LocalTime horaFin){
		super(nombre,clave,modalidad,precio);
		this.fechaRealizacion = fechaRealizacion;
		this.horaInicio = horaInicio;
		this.horaFin = horaFin;
	}
	
	@Override
	public String consultarDatos(){
		SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
		return "TALLER: " + getClave() + " - " + getNombre() + " - " + "S/. " + getPrecio() + " - " + "Fecha: " + sdf.format(fechaRealizacion);
	}
}