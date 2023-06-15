using System;
using System.Globalization;

namespace TerceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# - POO: Classes, atributos, métodos e membros estáticos

            Console.WriteLine("Insira o valor de A do triângulo X: ");
            double ax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de B do triângulo X: ");
            double bx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de C do triângulo X: ");
            double cx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double px = (ax + bx + cx) / 2;
            double raizx = px * (px - ax) * (px - bx) * (px - cx);
            double areax = Math.Sqrt(raizx);
            double trianguloX = areax;
            Console.WriteLine("A área do triângulo X é: " + trianguloX);

            Console.WriteLine("Insira o valor de A do triângulo Y: ");
            double ay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de B do triângulo Y: ");
            double by = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o valor de C do triângulo Y: ");
            double cy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double py = (ay + by + cy) / 2;
            double raizy = py * (py - ay) * (py - bx) * (py - cx);
            double areay = Math.Sqrt(raizy);
            double trianguloY = areay;
            Console.WriteLine("A área do triângulo X é: " + trianguloX);
            Console.WriteLine("A área do triângulo Y é: " + trianguloY);

            if(trianguloY > trianguloX)
            {
                Console.WriteLine("Logo, a área do triângulo Y é maior que a do triângulo X");
            }else if (trianguloY == trianguloX)
            {
                Console.WriteLine("Logo, a área do triângulo Y é igual a do triângulo X");
            }
            else
            {
                Console.WriteLine("Logo, a área do triângulo X é igual a do triângulo Y");
            }
        }
    }
}