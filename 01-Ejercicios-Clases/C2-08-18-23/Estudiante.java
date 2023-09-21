class Estudiante extends Persona {
	public Estudiante(){System.out.println("Mensaje Estudiante");}
	@Override
	public void imprimirDatos(){
		System.out.println("Comportamiento Estudiante");
	}
	
	public void mostrarCodigoPUCP(){
		System.out.println("Codigo PUCP del estudiante");
	}
}