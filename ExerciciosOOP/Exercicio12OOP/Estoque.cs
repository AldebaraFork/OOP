using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12OOP
{
    internal class Estoque
    {

        public string NomeUsuario;
        public string NomeProduto;
        public int QuantidadeProduto;
        public double ValorProduto;


        //Nesse construtor, o usuário pode passar os valores para os atributos da classe
        //Ou seja, o usuário pode passar o nome do produto, a quantidade e o valor
        //os parametros dentro do construtor começam com letra minuscula e o atributo com letra maiuscula
        public Estoque(string nomeUsuario, string nomeProduto, int quantidadeProduto, double valorProduto)
        {
            NomeUsuario = nomeUsuario;
            NomeProduto = nomeProduto;
            QuantidadeProduto = quantidadeProduto;
            ValorProduto = valorProduto;
        }


        public int AdicionarProduto(int QuantidadeProduto)
        {
            return QuantidadeProduto += QuantidadeProduto;
        }

        public int RemoverProduto(int QuantidadeProduto)
        {
            return QuantidadeProduto -= QuantidadeProduto;
        }

        //criando um método para calcular o valor total do estoque

        public double ValorTotalEstoque()
        {
            return QuantidadeProduto * ValorProduto;
        }


    }
}
