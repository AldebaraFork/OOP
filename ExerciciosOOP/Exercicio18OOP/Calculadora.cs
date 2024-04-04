using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio18OOP
{
    internal class Calculadora
    {
        double OperacaoSelecionada;
        public Calculadora()
        {
            Console.WriteLine("Digite o numero da Operação ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtraçao");
            Console.WriteLine("3 - Multiplicar ");
            Console.WriteLine("4 - Divisão");
            double OperacaoSelecionada = double.Parse(Console.ReadLine());
            switch (OperacaoSelecionada)
            {
                case 1:
                    Console.WriteLine("Voce selecionou a operação soma ");
                    Console.Write("Digite o primeiro numero: ");
                    double Adicao1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite o segundo numero: ");
                    double Adicao2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    double Soma = Adicao1 + Adicao2;
                    Console.WriteLine("O resultado da soma é: " + Soma.ToString(CultureInfo.InvariantCulture));
                    break;
                case 2:
                    Console.WriteLine("Voce selecionou  a operaçao subtração ");
                    Console.Write("Digite o primeiro numero: ");
                    double Sub1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite o segundo numero: ");
                    double Sub2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double subtracao = Sub1 - Sub2;
                    Console.Write("O resultado da subratraço é: " + subtracao.ToString(CultureInfo.InvariantCulture));
                    break;
                case 3:
                    Console.WriteLine("Voce selecionou a operação de multiplicação");
                    Console.Write("Digite o primeiro numero: ");
                    double Multi1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Digite o segundo numero: ");
                    double Multi2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    double Multiplicacao = Multi1 * Multi2;
                    Console.WriteLine("O resultado da multiplicação é: " + Multiplicacao.ToString(CultureInfo.InvariantCulture));
                    break;
                case 4:
                    Console.WriteLine("Voce selecionou a operação de Divisão, Cuidado pois 0 não é divisivel");
                    Console.Write("Digite o primeiro numero: ");
                    double Divi1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Digite o segundo numero: ");
                    double Divi2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    double Divisao = Divi1 / Divi2;
                    if (Divi1 == 0)
                    {
                        throw new DivideByZeroException("Não é possível dividir por zero.");
                    }
                    else if (Divi2 == 0)
                    {
                        throw new DivideByZeroException("Não é possível dividir por zero.");
                    }
                    else
                    {
                        Console.WriteLine("O resultado da divisão é: " + Divisao.ToString(CultureInfo.InvariantCulture));
                    }
                    break;
                    default:
                    Console.WriteLine("Selecione uma operação acima! ");
                    break;





            }

        }
    }

}
