
using Exercicio1OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Programa
    {
        static void Main(string[] args)
        {

            //primeira pessoa 
            LerNome Dado = new LerNome();
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Digite o nome: ");
            Dado.nome1 = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            Dado.idade1 = int.Parse(Console.ReadLine());

            //segunda pessoa

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Digite o nome: ");
            Dado.nome2 = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            Dado.idade2 = int.Parse(Console.ReadLine());

            if (Dado.idade1 > Dado.idade2)
            {
                Console.WriteLine("Pessoa mais velha: " + Dado.nome1);
            }else
            {
                Console.WriteLine("Pessoa mais velha: " + Dado.nome2);
            }

        }
    }
}



namespace Exercicio1OOP
{
    internal class LerNome
    {
      public string nome1;
        public string nome2;
      public int idade1;
     public int idade2;
      
    }
}
