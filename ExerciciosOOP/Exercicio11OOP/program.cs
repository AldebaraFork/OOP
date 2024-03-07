using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11OOP
{
    public class program
    {
       
    
        public string NomeProduto;
        public double PrecoProduto;
        public int QuantidadeProduto;
        public int ProdutosAdicionados;
        public int ProdutosRemovidos;

        //o construtor OBRIGA a passar os valores para o objeto que no caso é o Produto
            public program(string produto, double preco, int quantidade)
            {
                NomeProduto = produto;
                PrecoProduto = preco;
                QuantidadeProduto = quantidade;
            }

        //é possivel utilizar mais de um construtor 
        public program(string produto, double preco)
        {
            NomeProduto = produto;
            PrecoProduto = preco;   
            
        }


        public double ValorTotalEmEstoque()
        {
            return PrecoProduto * QuantidadeProduto;
        }


        //bom de usar quando voce precisa repetir muitas vezes 
        public override string ToString()
        {
            return "Nome do Produto inserido:" + NomeProduto + ", No valor de R$:" + PrecoProduto + " cada ,quantidade de produtos em estoque " + QuantidadeProduto + ", No Valor Total de R$:" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    }

