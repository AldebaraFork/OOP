using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercicio17OOP
{
    internal class SwitchCase
    {

        public int NumeroSelecionado;

        public void Atendimento()
        {
            Console.WriteLine("Olá, Bem vindo ao atendimento! ");
            Console.WriteLine("Digite o número correspondente ao atendimento desejado: ");
            Console.WriteLine("1 - Suporte Técnico");
            Console.WriteLine("2 - Financeiro");
            Console.WriteLine("3 - Vendas");
            Console.WriteLine("4 - Reclamações");
            Console.WriteLine("5 - Outros");
            Console.WriteLine("6 - Sair");

            NumeroSelecionado = int.Parse(Console.ReadLine());
            switch (NumeroSelecionado)
            {
                case 1:
                    Console.WriteLine("Você selecionou Suporte Técnico");

                    break;
                case 2:
                    Console.WriteLine("Você selecionou Financeiro");
                    break;
                case 3:
                    Console.WriteLine("Você selecionou Vendas");
                    break;
                case 4:
                    Console.WriteLine("Você selecionou Reclamações");
                    break;
                case 5:
                    Console.WriteLine("Você selecionou Outros");
                    break;
                case 6:
                    Console.WriteLine("Você selecionou Sair");
                    break;
                 default:
                    Console.WriteLine("Digite o número correspondente ao atendimento desejado: ");
                    break;
            }
        }


    }


}

