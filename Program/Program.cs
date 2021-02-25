using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = 0;
            double P = 0;
            double A = 0;

            Console.WriteLine("CALCULADORA PARA PERÍMETRO Y ÁREA DE UN CUADRADO");
            Console.WriteLine();

            Console.Write("Escriba el valor de uno de los lados en centímetros: ");
            string valor = Console.ReadLine();
            l = Convert.ToDouble(valor);

            Cuadrado c = new Cuadrado();
            P = c.Perimetro(l); // P = 4 * l;
            A = c.Area(l);      // A = Math.Pow(l, 2);

            Console.WriteLine();
            Console.WriteLine("El perímetro del cuadrado es: " + P + " cm");
            Console.WriteLine("El área del cuadrado es: " + A + " cm2");
        }
    }
}
