package paqueteC;
import paqueteA.paqueteB.ClaseB;
public class ClaseC{
	public double promedio(int a, int b){
		ClaseB cb= new ClaseB();
		return cb.sumar(a,b)/2;
	}
}