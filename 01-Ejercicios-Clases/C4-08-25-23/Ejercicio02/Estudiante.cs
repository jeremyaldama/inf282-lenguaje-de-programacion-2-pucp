class Estudiante : Persona, Consultable{
	private double CRAEST;
	public Estudiante(string nombre, double CRAEST) : base(nombre){
		this.CRAEST = CRAEST;
	}
	public void imprimirDatos(){
		System.Console.WriteLine(Nombre + " " + CRAEST);
	}
}