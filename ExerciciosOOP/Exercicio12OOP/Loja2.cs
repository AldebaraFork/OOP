using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12OOP
{
    internal class Loja2
    {
        static void Main(string[] args)
        {
            //Criando um objeto da classe Estoque e passando nenhum valor para os atributos
            Estoque Loja = new Estoque("","",0,0.0);
            Console.WriteLine("Por-favor digite seu nome: ");
            Loja.NomeUsuario = Console.ReadLine();
            Console.WriteLine("Olá " + Loja.NomeUsuario + " seja bem vindo a nossa loja!");

            Console.WriteLine("Digite o nome do produto: ");
            Loja.NomeProduto = Console.ReadLine();
            Console.WriteLine("OK, agora digite a quantidade do produto: ");
            Loja.QuantidadeProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o valor do produto: ");
            Loja.ValorProduto = double.Parse(Console.ReadLine());



            Console.WriteLine("Deseja adicionar mais produtos ao estoque? S/N");
            
            string resposta = Console.ReadLine();

            if (resposta == "S")
            {
                Console.WriteLine("Digite a quantidade que deseja adicionar: ");
                int quantidade = int.Parse(Console.ReadLine());
                Loja.AdicionarProduto(quantidade);
                Console.WriteLine("A quantidade de produtos no estoque é: " + Loja.QuantidadeProduto);
            }
            else
            {
                Console.WriteLine("Deseja remover produtos do estoque? S/N");
                resposta = Console.ReadLine();
                if (resposta == "S")
                {
                    Console.WriteLine("Digite a quantidade que deseja remover: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    Loja.RemoverProduto(quantidade);
                    Console.WriteLine("A quantidade de produtos no estoque é: " + Loja.QuantidadeProduto);
                }
                else
                {
                    Console.WriteLine("O valor total do estoque é: " + Loja.ValorTotalEstoque());
                }
            }






       

        }
    }
}
