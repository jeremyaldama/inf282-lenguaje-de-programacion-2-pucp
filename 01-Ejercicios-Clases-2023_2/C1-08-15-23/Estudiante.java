// Fecha de modificacion: 15-08-23
/*
	Nombre: FREDDY PAZ
	Código: 20112728
*/
class Estudiante{
	//Propiedades
	String codigo;
	String nombre;
	String apellidoPaterno;
	double CRAEST;
	
	//Constructos
	public Estudiante(){
	}
	public Estudiante(String nombre, String apellidoPaterno){
		this.nombre = nombre;
		this.apellidoPaterno = apellidoPaterno;
	}
	
	//Métodos (Funciones y procedimientos)
	public static void main(String[] args){
		//Declaración una variable
		Estudiante est1;
		//Inicializar la variable
		est1 = new Estudiante();
		//Asignamos un nombre
		est1.nombre = "Juan";
		//Asignamos un apellido paterno
		est1.apellidoPaterno = "Perez";
		//Imprimimos nombre completo
		est1.imprimirNombreCompleto();
		
		//Declarar e inicializar un estudiante
		Estudiante est2 = new Estudiante("Pedro","Sifuentes");
		//Imprimimos nombre completo
		est2.imprimirNombreCompleto();
		
	}
	
	void imprimirNombreCompleto(){
		System.out.println(nombre + " " + apellidoPaterno);
	}
}