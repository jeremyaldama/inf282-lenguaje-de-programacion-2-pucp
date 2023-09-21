import java.util.Date;
class Profesor extends MiembroPUCP{
	private Dedicacion estado; //TC TPA
	public Profesor(String codigoPUCP, String nombre, String apellidoPaterno, Date fechaNacimiento, String direccion, String email, char sexo, Dedicacion estado){
		super(codigoPUCP, nombre, apellidoPaterno, fechaNacimiento, direccion, email, sexo);
		this.estado = estado;
	}
	
	@Override
	public String consultarDatos(){
		return "Profesor: " + getCodigoPUCP() + " - " + getNombre() + " " + getApellidoPaterno() + " " + estado;
	}
}