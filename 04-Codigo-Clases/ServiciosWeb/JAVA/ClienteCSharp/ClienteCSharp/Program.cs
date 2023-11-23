using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicioWeb.ServicioWebClient objRemoto =
                new ServicioWeb.ServicioWebClient();
            int a = 10; int b = 20;
            System.Console.WriteLine("La suma de " + a + " " + b + " es " +
                objRemoto.sumar(a, b));

            System.Console.WriteLine("La suma de " + a + " " + b + " es " +
                objRemoto.restar(a, b));
            System.Console.WriteLine(objRemoto.hello("Jeremy"));
            System.Console.ReadLine();
        }
    }
}
