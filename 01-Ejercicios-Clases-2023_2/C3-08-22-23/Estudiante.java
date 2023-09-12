import java.util.Date;
class Estudiante extends MiembroPUCP{
	private double CRAEST;
	
	public Estudiante(String codigoPUCP, String nombre, String apellidoPaterno, Date fechaNacimiento, String direccion, String email, char sexo, double CRAEST){
		super(codigoPUCP, nombre, apellidoPaterno, fechaNacimiento, direccion, email, sexo);
		this.CRAEST = CRAEST;
	}
	
	@Override
	public String consultarDatos(){
		return "Alumno: " + getCodigoPUCP() + " - " + getNombre() + " " + getApellidoPaterno() + " " + CRAEST;
	}
}