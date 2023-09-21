class Principal{
	public static void Main(){
		Persona p1 = new Persona("Pedro");
		Estudiante e1 = new Estudiante("Manuel",99.9);
		//p1.Nombre = "Pedro";
		System.Console.WriteLine("Mi primer programa C#");
		System.Console.WriteLine(p1.Nombre);
		System.Console.WriteLine(e1.Nombre);
		e1.imprimirDatos();
	}
}