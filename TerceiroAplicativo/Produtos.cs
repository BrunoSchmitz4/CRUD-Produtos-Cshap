using System;
using System.Globalization;

namespace TerceiroAplicativo
{
    class Produtos
    {

        // Os códigos comentados são a versão sem a aplicação de getters e setters

        //public string nome;
        //public double preco;
        //public int quantidade;
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produtos(string nome, double preco, int quantidade)
        {
            //this.nome = nome;
            //this.preco = preco;
            //this.quantidade = quantidade;
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }


        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        //public string GetNome()
        //{
        //    return _nome;
        //}
        //private void SetNome(string nome)
        //{
        //    _nome = nome;
        //}

        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        //public double GetPreco()
        //{
        //    return _preco;
        //}

        //private double SetPreco(double preco)
        //{
        //    return _preco = preco;
        //}

        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        //public int GetQuantidade()
        //{
        //    return _quantidade;
        //}

        //public void SetQuantidade(int quantidade)
        //{
        //    _quantidade = quantidade;
        //}

        public double ValorTotalEmEstoque()
        {
            //Console.WriteLine($"Existe(m) {quantidade} unidade(s) em estoque deste produto.");
            Console.WriteLine($"Existe(m) {Quantidade} unidade(s) em estoque deste produto.");
            //return (preco * quantidade);
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
            //quantidade = quantidade + quantidadeAdicional;
            Quantidade = Quantidade + quantidadeAdicional;
            //SetQuantidade(NovaQuantidade);
            Console.Clear();
            //Console.WriteLine($"Foram adicionados {quantidadeAdicional} no estoque de {nome}.");
            Console.WriteLine($"Foram adicionados {quantidadeAdicional} no estoque de {Nome}.");
            //Console.WriteLine("A quantidade total em estoque é: " + quantidade);
            Console.WriteLine("A quantidade total em estoque é: " + Quantidade);
        }
        public void RemoverProdutos(int quantity)
        {
            Console.Clear();
            //Console.WriteLine($"Quantas unidades das {quantidade} desejas remover?");
            Console.WriteLine($"Quantas unidades das {Quantidade} desejas remover?");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            //quantidade = quantidade - quantidadeRemovida;
            Quantidade = Quantidade - quantidadeRemovida;
            //SetQuantidade(NovaQuantidade);
            Console.Clear();
            //Console.WriteLine($"Foram removidos {quantidadeRemovida} do estoque de {nome}.");
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
                //Console.WriteLine("(P) - Produto: " + nome + "\n(PU) - Preço por unidade: R$" + preco + "\n(S) - Sair da aba de atualizar");
                Console.WriteLine("(P) - Produto: " + Nome + "\n(PU) - Preço por unidade: R$" + Preco + "\n(S) - Sair da aba de atualizar");
                Console.WriteLine("-----------------------------------------------\n-----------------------------------------------");
                opcao = Console.ReadLine();
                opcao.ToUpper();
                if ((opcao == "P") || (opcao == "p"))
                {
                    Console.WriteLine("Insira o novo nome do produto: ");
                    //nome = Console.ReadLine();
                    Nome = Console.ReadLine();
                    //SetNome(NovoNome);
                    //Nome = NovoNome;
                    Console.WriteLine("Dados do produto atualizados:\n{0}", ToString());
                    opcao = "";

                }else if ((opcao == "PU") || (opcao == "pu"))
                {
                    Console.WriteLine("Insira o novo preço do produto: ");
                    //preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //SetPreco(NovoPreco);
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
            //return "Produto: " + nome +
            //"\nPreço por unidade: R$" + preco +
            //"\nQuantidade em estoque: " + quantidade + "\nValor de estoque: R$" + ValorTotalEmEstoque();
            return "Produto: " + Nome +
                "\nPreço por unidade: R$" + Preco +
                "\nQuantidade em estoque: " + Quantidade + "\nValor de estoque: R$" + ValorTotalEmEstoque();
        }

        public void CalculaDolar(double cotacaoAtual = 5.0f)
        {
            //double dolar = (quantidade * preco) / cotacaoAtual;
            //double dolar = (_quantidade * _preco) / cotacaoAtual;
            double dolar = (Quantidade * Preco) / cotacaoAtual;
            Console.WriteLine("O valor de estoque em dolar ficará: ${0}", dolar);
        }
    }
}
