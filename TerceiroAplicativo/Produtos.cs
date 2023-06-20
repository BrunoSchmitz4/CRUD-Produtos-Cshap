using System;
using System.Globalization;

namespace TerceiroAplicativo
{
    class Produtos // Continha 178 linhas de código
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produtos(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            Console.WriteLine($"Existe(m) {Quantidade} unidade(s) em estoque deste produto.");
            return (Preco * Quantidade);
        }

        public void DadosProdutos()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Dados do produto:\n{0}", ToString());
            CalculaDolar();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
        }
        public void AdicionarProdutos(int quantity)
        {
            Console.Clear();
            Console.WriteLine("Quantas unidades serão adicionadas?");
            int quantidadeAdicional = int.Parse(Console.ReadLine());
            Quantidade = Quantidade + quantidadeAdicional;
            Console.Clear();
            Console.WriteLine($"Foram adicionados {quantidadeAdicional} no estoque de {Nome}.");
            Console.WriteLine("A quantidade total em estoque é: " + Quantidade);
        }
        public void RemoverProdutos(int quantity)
        {
            Console.Clear();
            Console.WriteLine($"Quantas unidades das {Quantidade} desejas remover?");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            Quantidade = Quantidade - quantidadeRemovida;
            Console.Clear();
            Console.WriteLine($"Foram removidos {quantidadeRemovida} do estoque de {Nome}.");
        }

        public void AtualizarProdutos()
        {
            string opcao = "";
            opcao.ToUpper();
            while ((opcao != "P") || (opcao != "PU") || (opcao != "S"))
            {
                Console.Clear();
                Console.WriteLine($"Dentre os dados do produto, escolha o que será atualizado:");
                Console.WriteLine("-----------------------------------------------\n-----------------------------------------------");
                Console.WriteLine("(P) - Produto: " + Nome + "\n(PU) - Preço por unidade: R$" + Preco + "\n(S) - Sair da aba de atualizar");
                Console.WriteLine("-----------------------------------------------\n-----------------------------------------------");
                opcao = Console.ReadLine();
                opcao.ToUpper();
                if ((opcao == "P") || (opcao == "p"))
                {
                    Console.WriteLine("Insira o novo nome do produto: ");
                    Nome = Console.ReadLine();
                    Console.WriteLine("Dados do produto atualizados:\n{0}", ToString());
                    opcao = "";

                }else if ((opcao == "PU") || (opcao == "pu"))
                {
                    Console.WriteLine("Insira o novo preço do produto: ");
                    Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Dados do produto atualizados:\n{0}", ToString());
                    opcao = "";
                }else if ((opcao == "S") || (opcao == "s"))
                {
                    Console.Clear();
                    Console.WriteLine("Saiu da aba.");
                    break;
                }
            }
        }
        public override string ToString()
        {
            return "Produto: " + Nome +
                "\nPreço por unidade: R$" + Preco +
                "\nQuantidade em estoque: " + Quantidade + "\nValor de estoque: R$" + ValorTotalEmEstoque();
        }

        public void CalculaDolar(double cotacaoAtual = 5.0f)
        {
            double dolar = (Quantidade * Preco) / cotacaoAtual;
            Console.WriteLine("O valor de estoque em dolar ficará: ${0}", dolar);
        }
    }
}
