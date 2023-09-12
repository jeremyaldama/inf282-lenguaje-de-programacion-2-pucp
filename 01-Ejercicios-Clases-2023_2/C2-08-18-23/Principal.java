class Principal{
	public static void main(String[] args){
		//Persona p1 = new Persona();
		Estudiante e1 = new Estudiante();
		Docente d1 = new Docente();
		//e1.nombre = "Juan";
		e1.setNombre("Juan");
		e1.CRAEST = 99.9f;
		Persona.CRAEST = 100.0f;
		//System.out.println(e1.getNombre());
		e1.imprimirDatos();
		d1.imprimirDatos();
		Persona.mostrarMensaje();
		
		e1.mostrarCodigoPUCP();
		d1.mostrarCodigoPUCP();
	}
}