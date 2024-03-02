using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1OOP
{
     class SalarioFuncionarios
    {
        static void Main(string[] args)
        {

            //Funcionario 1
            Funcionarios Dados = new Funcionarios();
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Digite o nome do Primeiro funcionario: ");
            Dados.NomeFuncionario1 = Console.ReadLine();
            Console.WriteLine("Digite o salário: ");
            Dados.SalarioFuncionario1 = double.Parse(Console.ReadLine());

            //Funcionario 2
            Console.WriteLine("Dados do segundo funcionario: ");
            Console.WriteLine("Digite o nome do Segundo funcionario ");
            Dados.NomeFuncionario2 = Console.ReadLine();
            Console.WriteLine("Digite o salário: ");
            Dados.SalarioFuncionario2 = double.Parse(Console.ReadLine());

            double media = (Dados.SalarioFuncionario1 + Dados.SalarioFuncionario2) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2"));
        }
    }

    internal class Funcionarios
    {
        //o que tiver aqui dentro é atributo
        public string NomeFuncionario1;
        public string NomeFuncionario2;

        public double SalarioFuncionario1;
        public double SalarioFuncionario2;



    }
}


