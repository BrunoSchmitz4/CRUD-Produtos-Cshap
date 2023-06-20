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
            if (Quantidade <= 0) { Quantidade = 0; }
        }

        public double ValorTotalEmEstoque()
        {
            Console.WriteLine($"Existe(m) {Quantidade} unidade(s) em estoque deste produto.");
            return (Preco * Quantidade);
        }

        public void DadosProdutos()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------\n-----------------------------------------------" + "\nDados do produto:\n" + ToString());
            CalculaDolar();
            Console.WriteLine("\n-----------------------------------------------\n-----------------------------------------------");
        }
        public void AdicionarProdutos(int quantity)
        {
            Console.Clear();
            Console.WriteLine("Quantas unidades serão adicionadas?");
            int quantidadeAdicional = int.Parse(Console.ReadLine());
            Quantidade = Quantidade + quantidadeAdicional;
            Console.Clear();
            Console.WriteLine($"Foram adicionados {quantidadeAdicional} no estoque de {Nome}.\nA quantidade total em estoque é: " + Quantidade);
            //Console.WriteLine("A quantidade total em estoque é: " + Quantidade);
        }
        public void RemoverProdutos(int quantity)
        {
            Console.Clear();
            Console.WriteLine($"Quantas unidades das {Quantidade} desejas remover?");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            Quantidade = Quantidade - quantidadeRemovida;
            if (Quantidade <= 0)
            {
                Quantidade = 0;
            }
            Console.Clear();
            Console.WriteLine($"Foram removidos {quantidadeRemovida} do estoque de {Nome}.\nA quantidade total em estoque é: " + Quantidade);
        }

        public void AtualizarProdutos()
        {
            string opcao = "";
            opcao.ToUpper();
            while ((opcao != "P") || (opcao != "PU") || (opcao != "S"))
            {
                Console.Clear();
                Console.WriteLine($"Dentre os dados do produto, escolha o que será atualizado:" +
                    $"\n-----------------------------------------------\n-----------------------------------------------" +
                    $"\n(P) - Produto: " + Nome + "\n(PU) - Preço por unidade: R$" + Preco + "\n(S) - Sair da aba de atualizar" +
                    "\n-----------------------------------------------\n-----------------------------------------------");
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
            return "Produto: " + Nome + "\nPreço por unidade: R$" + Preco + "\nQuantidade em estoque: " + Quantidade + "\nValor de estoque: R$" + ValorTotalEmEstoque();
        }
        public void CalculaDolar()
        {
            Console.WriteLine("O valor de estoque em dolar ficará: $" + ((Quantidade * Preco) / 5.0f));
        }
    }
}
