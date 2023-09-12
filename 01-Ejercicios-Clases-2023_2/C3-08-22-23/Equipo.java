import java.util.ArrayList;
class Equipo{
	private String nombre;
	private String interes;
	private ArrayList<Miembro> miembros;
	//private EQuipu equipu;
	
	public Equipo(String nombre, String interes){
		this.nombre = nombre;
		this.interes = interes;
	}
	
	public void setNombre(String nombre){
		this.nombre = nombre;
	}
	public String getNombre(){
		return nombre;
	}
	
	public void setMiembros(ArrayList<Miembro> miembros){
		this.miembros = miembros;
	}
	public ArrayList<Miembro> getMiembros(){
		return miembros;
	}
	
	public String consultarDatosMiembrosPUCP(){
		String cadena = "";
		for(Miembro m : miembros){
			if(m instanceof MiembroPUCP){
				cadena += ((MiembroPUCP)m).consultarDatos() + "\n";
			}				
		}
		return cadena;
	}
	
	
	
}