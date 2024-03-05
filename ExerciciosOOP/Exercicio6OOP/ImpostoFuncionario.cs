using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6OOP
{
    internal class ImpostoFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario DadosFuncionario = new Funcionario();

            Console.Write("Digite o nome do funcionario: ");
            DadosFuncionario.nome = Console.ReadLine();

            Console.Write("Digite o salario bruto: ");
            DadosFuncionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Digite o imposto: ");
            DadosFuncionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario selecionado: " + DadosFuncionario.nome + ", R$ " + DadosFuncionario.SalarioLiquido().ToString("F2"));

             Console.WriteLine("Digite a porcentagem para aumentar o salario: ");

            DadosFuncionario.SalarioBruto = DadosFuncionario.AumentarSalario();

            Console.WriteLine("Dados atualizados: " + DadosFuncionario.nome + ", R$ " + DadosFuncionario.SalarioLiquido().ToString("F2"));


         }


    }
}

public class Funcionario
{

   public string nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    public double AumentarSalario()
    {
        return SalarioBruto + (SalarioBruto * 0.1);
    }

}

