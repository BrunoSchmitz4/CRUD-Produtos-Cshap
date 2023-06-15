using System;
using System.Globalization;

namespace TerceiroAplicativo
{
    class Produtos
    {
        public string nome;
        public double preco;
        public int quantidade;
        public void ValorTotalEmEstoque()
        {
            // talvez tenha que tornar essa função do tipo double novamente e remover o void,
            // alternando o comentado e descomentado abaixo
            Console.WriteLine($"Existe(m) {quantidade} unidade(s) em estoque deste produto.");
            //return (preco * quantidade);
        }
        public void AdicionarProdutos(int quantity)
        {
            Console.WriteLine("Quantas unidades serão adicionadas?");
            int quantidadeAdicional = int.Parse(Console.ReadLine());
            quantidade = quantidade + quantidadeAdicional;
            Console.WriteLine($"Foram adicionados {quantidadeAdicional} no estoque de {nome}.");
        }
        public void RemoverProdutos(int quantity)
        {
            Console.WriteLine($"Quantas unidades das {quantidade} desejas remover?");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            quantidade = quantidade - quantidadeRemovida;
            Console.WriteLine($"Foram removidos {quantidadeRemovida} do estoque de {nome}.");
        }
    }
}
