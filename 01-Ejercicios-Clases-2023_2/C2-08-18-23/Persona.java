abstract class Persona implements IComun{
	private String nombre;
	String apellidoPaterno;
	static float CRAEST;
	public Persona(){System.out.println("Mensaje Persona");}
	public Persona(String nombre){
		this.nombre = nombre;
	}
	public Persona(String nombre, String apellidoPaterno){
		this.nombre = nombre;
		this.apellidoPaterno = apellidoPaterno;
	}
	public void setNombre(String nombre){
		this.nombre = nombre;
	}
	public String getNombre(){
		return nombre;
	}
	
	public abstract void imprimirDatos();
	
	public abstract void mostrarCodigoPUCP();
	
	/*
	public void finalize(){
		System.out.println("El objeto esta siendo destruido");
	}*/
	
	public static void mostrarMensaje(){
		System.out.println("Hola mundo");
	}	
	
	
	
}