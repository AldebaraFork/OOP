using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4OOP
{
    public class Loja
    {
        static void Main(string[] args)
        {
            ProdutoEstoque Produto = new ProdutoEstoque();
            Console.WriteLine("Digite o nome do produto: ");
            Produto.NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            Produto.PrecoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto: ");
            Produto.QuantidadeProduto = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto:" + Produto);

            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            Produto.ProdutosAdicionados = int.Parse(Console.ReadLine());
            Produto.QuantidadeProduto += Produto.ProdutosAdicionados;

            Console.WriteLine($"Dados do produto atualizados: {Produto.NomeProduto}, R$ {Produto.PrecoProduto}, {Produto.QuantidadeProduto} unidades, Total: {Produto.ValorTotalEmEstoque}");



            Console.WriteLine("Digite o numero de produto a ser removido do estoque: ");
            Produto.ProdutosRemovidos = int.Parse(Console.ReadLine());
            Produto.QuantidadeProduto -= Produto.ProdutosRemovidos;


            Console.WriteLine($"Dados do produto atualizados: {Produto.NomeProduto}, R$ {Produto.PrecoProduto}, {Produto.QuantidadeProduto} unidades, Total: {Produto.ValorTotalEmEstoque}");

        }

    }

    internal class ProdutoEstoque
    {
        public string NomeProduto;
        public double PrecoProduto;
        public int QuantidadeProduto;
        public int ProdutosAdicionados;
        public int ProdutosRemovidos;
       

        public double ValorTotalEmEstoque()
        {
          return PrecoProduto * QuantidadeProduto;
        }


        //bom de usar quando voce precisa repetir muitas vezes 
        public override string ToString()
        {
            return "Nome do Produto inserido:" + NomeProduto + ", No valor de R$:" + PrecoProduto + "cada ,quantidade de produtos em estoque " + QuantidadeProduto + ", No Valor Total de R$:" +ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}