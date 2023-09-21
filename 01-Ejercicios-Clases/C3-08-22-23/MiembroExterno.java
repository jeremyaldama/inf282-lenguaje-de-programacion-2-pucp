import java.util.Date;
class MiembroExterno extends Miembro{
	private char dedicacion;
	public MiembroExterno(String nombre, String apellidoPaterno, Date fechaNacimiento, String direccion, String email, char sexo, char dedicacion){
		super(nombre, apellidoPaterno, fechaNacimiento, direccion, email, sexo);
		this.dedicacion = dedicacion;
	}
}