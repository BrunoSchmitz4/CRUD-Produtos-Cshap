using System;
using System.Globalization;

namespace TerceiroAplicativo
{
    class Produtos
    {
        public string nome;
        public double preco;
        public int quantidade;
        public double ValorTotalEmEstoque()
        {
            //Console.WriteLine($"Existe(m) {quantidade} unidade(s) em estoque deste produto.");
            return (preco * quantidade);
        }

        public void DadosProdutos()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Dados do produto:\n{0}", ToString());
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
        }
        public void AdicionarProdutos(int quantity)
        {
            Console.Clear();
            Console.WriteLine("Quantas unidades serão adicionadas?");
            int quantidadeAdicional = int.Parse(Console.ReadLine());
            quantidade = quantidade + quantidadeAdicional;
            Console.Clear();
            Console.WriteLine($"Foram adicionados {quantidadeAdicional} no estoque de {nome}.");
            Console.WriteLine("A quantidade total em estoque é: " + quantidade);
        }
        public void RemoverProdutos(int quantity)
        {
            Console.Clear();
            Console.WriteLine($"Quantas unidades das {quantidade} desejas remover?");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            quantidade = quantidade - quantidadeRemovida;
            Console.Clear();
            Console.WriteLine($"Foram removidos {quantidadeRemovida} do estoque de {nome}.");
        }

        public void AtualizarProdutos()
        {
            string opcao = "";
            opcao.ToUpper();
            while ((opcao != "P") || (opcao != "PU") || (opcao != "S"))
            {
                Console.Clear();
                Console.WriteLine($"Dentre os dados do produto, escolha o que será atualizado:");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("(P) - Produto: " + nome + "\n(PU) - Preço por unidade: R$" + preco + "\n(S) - Sair da aba de atualizar");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("-----------------------------------------------");
                opcao = Console.ReadLine();
                opcao.ToUpper();
                if ((opcao == "P") || (opcao == "p"))
                {
                    Console.WriteLine("Insira o novo nome do produto: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Dados do produto atualizados:\n{0}", ToString());
                    opcao = "";
                }else if ((opcao == "PU") || (opcao == "pu"))
                {
                    Console.WriteLine("Insira o novo preço do produto: ");
                    preco = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
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
            return "Produto: " + nome +
                "\nPreço por unidade: R$" + preco +
                "\nQuantidade em estoque: " + quantidade + "\nValor de estoque: R$" + ValorTotalEmEstoque();
        }
    }
}
