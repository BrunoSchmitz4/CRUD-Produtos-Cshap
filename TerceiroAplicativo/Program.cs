using System;
using System.Globalization;

namespace TerceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# - POO: Classes, atributos, métodos e membros estáticos



            CalcTrian();
            
        }

        // Função que faz o Cálculo dos Triângulos sem uso de POO (Versão Tutor)
        static void CalcTrianTutor()
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double px = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(px * (px - xA) * (px - xB) * (px - xC));

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double py = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(py * (py - yA) * (py - yB) * (py - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
        // Função que faz o Cálculo dos Triângulos sem uso de POO (Versão própria)
        static void CalcTrian()
        {
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
            double raizy = py * (py - ay) * (py - by) * (py - cy);
            double areay = Math.Sqrt(raizy);
            double trianguloY = areay;
            Console.WriteLine("A área do triângulo X é: " + trianguloX);
            Console.WriteLine("A área do triângulo Y é: " + trianguloY);

            if (trianguloY > trianguloX)
            {
                Console.WriteLine("Logo, a área do triângulo Y é maior que a do triângulo X");
            }
            else if (trianguloY == trianguloX)
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