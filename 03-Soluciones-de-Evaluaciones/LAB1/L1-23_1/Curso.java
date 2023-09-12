import java.time.LocalTime;
import java.util.Date;
class Curso extends ProgramaAcademico{
	private int cantHorasClasePorSemana;
	private float cantidadCreditos;
	private Date fechaInicioClases;
	private Date fechaFinClases;
	private DiaSemana diaDeDictado;
	private LocalTime horaInicioClases;
	private LocalTime horaFinClases;
	
	public Curso(String nombre, String clave, char modalidad, double precio, int cantHorasClasePorSemana, float cantidadCreditos, Date fechaInicioClases, Date fechaFinClases, DiaSemana diaDeDictado, LocalTime horaInicioClases, LocalTime horaFinClases){
		super(nombre, clave, modalidad, precio);
		this.cantHorasClasePorSemana = cantHorasClasePorSemana;
		this.cantidadCreditos = cantidadCreditos;
		this.fechaInicioClases = fechaInicioClases;
		this.fechaFinClases = fechaFinClases;
		this.diaDeDictado = diaDeDictado;
		this.horaInicioClases = horaInicioClases;
		this.horaFinClases = horaFinClases;		
	}
	
	@Override
	public String consultarDatos(){
		return "CURSO: " + getClave() + " - " + getNombre() + " - " + "S/. " + getPrecio() + " - " + "CRED:" + cantidadCreditos; 
	}
}