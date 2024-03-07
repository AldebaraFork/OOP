using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11OOP
{
    internal class Construtores
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            double valor = double.Parse(Console.ReadLine());
         

            //instanciando o objeto com os valores passados 

            program Produto = new program(nome, valor);

            Console.WriteLine(Produto);

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


}

