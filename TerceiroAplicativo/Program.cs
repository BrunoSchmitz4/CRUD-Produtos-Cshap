using System;
using System.Collections.Concurrent;
using System.Globalization;
using TerceiroAplicativo;

namespace TerceiroProjeto
{
    class Program
    {
        // C# - POO: Classes, atributos, métodos e membros estáticos
        static void Main(string[] args)
        {

            Produtos computador, celular;

            computador = new Produtos();
            computador.quantidade = 0;
            computador.preco = 5000.0f;
            computador.nome = "Acer";
            celular = new Produtos();

            //Console.WriteLine("O que deseja fazer?Opções:\nAdicionar produtos(ap)\nDeletar produtos(dp)\nStatus Produtos(sp)\nSair(s)");
            string opcao = "";
            while ((opcao != "add") || (opcao != "del") || (opcao != "stt") || (opcao != "att") || (opcao != "s"))
            {
                Console.WriteLine("\n\n\n\nO que deseja fazer?Opções:\nAdicionar unidade(s)(add)\nDeletar unidade(s)(del)\nAtualizar produtos(att)\nStatus Produtos(stt)\nSair(s)");
                opcao = Console.ReadLine();
                if (opcao == "add")
                {
                    Console.Clear();
                    computador.AdicionarProdutos(computador.quantidade);
                    Console.WriteLine("Quantidade Adicionada!");
                }else if (opcao == "del")
                {
                    Console.Clear();
                    computador.RemoverProdutos(computador.quantidade);
                    Console.WriteLine("Quantidade removida!");
                    if(computador.quantidade < 0)
                    {
                        computador.quantidade = 0;
                    }
                }else if (opcao == "stt")
                {
                    Console.Clear();
                    computador.DadosProdutos();
                }else if (opcao == "att")
                {
                    Console.Clear();
                    computador.AtualizarProdutos();
                    Console.WriteLine("Produto atualizado com sucesso!");
                }
                else if (opcao == "s")
                {
                    Console.Clear();
                    Console.WriteLine("Programa encerrado");
                    break;
                }
            }
        }
        static void CalcOldest()
        {
            Oldest p1, p2;

            p1 = new Oldest();
            p2 = new Oldest();

            Console.WriteLine("Qual o nome da primeira pessoa?");
            p1.nome = Console.ReadLine();
            Console.WriteLine($"Quantos anos {p1.nome} tem?");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("E como se chama a segunda pessoa?");
            p2.nome = Console.ReadLine();
            Console.WriteLine($"E quantos anos {p2.nome} teria?");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine($"{p1.nome} é mais velho(a) que {p2.nome}.");
            }
            else
            {
                Console.WriteLine($"{p2.nome} é mais velho(a) que {p1.nome}.");
            }
        }
        static void CalcTrianTutorClass()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            if (areaX > areaY)
            {
                Console.WriteLine("A maior área entre o triângulo X ({0}) e o triângulo ({1}) é a do triângulo X", areaX, areaY);
            }
            else
            {
                Console.WriteLine("A maior área entre o triângulo X ({0}) e o triângulo ({1}) é a do triângulo Y", areaX, areaY);
            }
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