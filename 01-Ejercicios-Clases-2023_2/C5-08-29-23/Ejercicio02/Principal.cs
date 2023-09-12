//using matematicas;
namespace principales{
	public class Principal{
		public static void Main(){
			System.Console.WriteLine("Metodo main...");
			matematicas.Operacion op = new matematicas.Operacion();
			int a = 10;
			int b = 20;
			System.Console.WriteLine("La suma de " + a + " y " + b + " es: " + op.sumar(a,b));
		}
	}
}