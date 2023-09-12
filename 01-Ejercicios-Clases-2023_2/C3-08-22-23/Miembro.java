import java.util.Date;
abstract class Miembro{
	private static int correlativo = 1;
	private int codigo;
	private String nombre;
	private String apellidoPaterno;
	private Date fechaNacimiento;
	private String direccion;
	private String email;
	private char sexo;
	
	public Miembro(String nombre, String apellidoPaterno, Date fechaNacimiento, String direccion, String email, char sexo){
		this.codigo = correlativo;
		this.nombre = nombre;
		this.apellidoPaterno = apellidoPaterno;
		this.fechaNacimiento = fechaNacimiento;
		this.direccion = direccion;
		this.email = email;
		this.sexo = sexo;
		correlativo++;
	}
	
	public Miembro(){
		this.codigo = correlativo;
		correlativo++;
	}
	
	public String getNombre(){
		return nombre;
	}
	
	public String getApellidoPaterno(){
		return apellidoPaterno;
	}
}