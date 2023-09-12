package paqueteA;
import paqueteC.ClaseC;
public class ClaseA{
	public static void main(String[] args){
		int a,b; a = 10; b = 4;
		ClaseC cc = new ClaseC();
		System.out.println("El promedio de a y b es: " + cc.promedio(a,b));
	}
}