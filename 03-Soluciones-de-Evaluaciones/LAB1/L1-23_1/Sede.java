import java.util.ArrayList;
class Sede{
	private int idSede;
	private String nombre;
	private String direccion;
	private ArrayList<ProgramaAcademico> programasAcademicos;
	
	public Sede(int idSede, String nombre, String direccion){
		this.idSede = idSede;
		this.nombre = nombre;
		this.direccion = direccion;
	}
	
	public String getNombre(){
		return nombre;
	}
	
	public ArrayList<ProgramaAcademico> getProgramasAcademicos(){
		return programasAcademicos;
	}
	
	public void setProgramasAcademicos(ArrayList<ProgramaAcademico> programasAcademicos){
		this.programasAcademicos = programasAcademicos;
	}
	
	public String consultarProgramas(){
		String cadena = "";
		for(ProgramaAcademico pa : programasAcademicos){
			cadena += pa.consultarDatos() + "\n";
		}
		return cadena;
	}
}