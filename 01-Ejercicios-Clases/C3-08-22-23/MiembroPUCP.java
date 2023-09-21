import java.util.Date;
abstract class MiembroPUCP extends Miembro implements Consultable{
	private String codigoPUCP;
	
	public MiembroPUCP(String codigoPUCP, String nombre, String apellidoPaterno, Date fechaNacimiento, String direccion, String email, char sexo){
		super(nombre, apellidoPaterno, fechaNacimiento, direccion, email, sexo);
		this.codigoPUCP = codigoPUCP;
	}
	
	public abstract String consultarDatos();
	
	public String getCodigoPUCP(){
		return codigoPUCP;
	}
}