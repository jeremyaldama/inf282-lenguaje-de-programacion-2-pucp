class Persona {
	private string nombre;
	//Constructo
	public Persona(string nombre){
		this.nombre = nombre;
	}
	//get y set del atributo nombre
	public string Nombre{
		get{
			return nombre;
		}
		set{
			this.nombre = value;
		}
	}
}