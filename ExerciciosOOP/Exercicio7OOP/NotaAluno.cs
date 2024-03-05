using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio7OOP
{
    internal class NotaAluno
    {
        static void Main(string[] args)
        {

           Aluno DadosAluno = new Aluno();

            Console.Write($"Nome do Aluno:  {DadosAluno.nome} ");
            DadosAluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            DadosAluno.nota1 = double.Parse(Console.ReadLine());
            DadosAluno.nota2 = double.Parse(Console.ReadLine());
            DadosAluno.nota3 = double.Parse(Console.ReadLine());

            DadosAluno.NotaFinal = DadosAluno.nota1 + DadosAluno.nota2 + DadosAluno.nota3;

            if (DadosAluno.NotaFinal > 60)
            {
                Console.WriteLine($"NOTA FINAL = {DadosAluno.NotaFinal}");
                Console.WriteLine("APROVADO");
            }else
            {
                Console.WriteLine($"NOTA FINAL = {DadosAluno.NotaFinal}");
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {60 - DadosAluno.NotaFinal} PONTOS");
            }

        }
    }

    public class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;
        public double NotaFinal;


    }

}
