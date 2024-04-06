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
        double OperacaoSelecionada2;


        public Calculadora()
        {
            Console.WriteLine("Digite o numero da Operação ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtraçao");
            Console.WriteLine("3 - Multiplicar ");
            Console.WriteLine("4 - Divisão");
            double OperacaoSelecionada = double.Parse(Console.ReadLine());
            switch (OperacaoSelecionada)
            {
                case 1:
                    Console.WriteLine("Voce selecionou a operação adição");
                    Console.Write("Digite o primeiro numero: ");
                    double Adicao1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite o segundo numero: ");
                    double Adicao2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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
                    double Multi1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite o segundo numero: ");
                    double Multi2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double Multiplicacao = Multi1 * Multi2;
                    Console.Write("O resultado da multiplicação é: " + Multiplicacao.ToString(CultureInfo.InvariantCulture));
                    break;
                case 4:
                    Console.WriteLine("Voce selecionou a operação de Divisão, Cuidado pois 0 não é divisivel");
                    Console.Write("Digite o primeiro numero: ");
                    double Divi1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite o segundo numero: ");
                    double Divi2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
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
            string AdicionarOperacao;
            Console.WriteLine("Deseja calcular a operação anterior com mais uma? ");
            Console.WriteLine("Digite SIM ou NÂO ");
            AdicionarOperacao = Console.ReadLine();
            if (AdicionarOperacao == "SIM" || AdicionarOperacao == "sim")
            {
                Console.WriteLine("Digite o numero da Operação ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtraçao");
                Console.WriteLine("3 - Multiplicar ");
                Console.WriteLine("4 - Divisão");
                double OperacaoSelecionada2 = double.Parse(Console.ReadLine());
                switch (OperacaoSelecionada2)
                {
                    case 1:
                        Console.WriteLine("Voce Selecionou a operação Adição ");
                        Console.Write("Selecione o primeiro numero para a adição: ");
                        double Adc1 = double.Parse(Console.ReadLine());
                        Console.Write("Selecione o segundo numero para a adição: ");
                        double Adc2 = double.Parse(Console.ReadLine());
                        double Soma2 = Adc1 + Adc2;
                        Console.WriteLine("O resultado da adição é: " + Soma2);
                        break;
                    case 2:
                        Console.WriteLine("Você selecionou a operação Subtração: ");
                        Console.Write("Selecione o primeiro numero para a subtração: ");
                        double Sub1 = double.Parse(Console.ReadLine());
                        Console.Write("Selecione o segundo numero para a subtração ");
                        double Sub2 = double.Parse(Console.ReadLine());
                        double Subtracao = Sub1 - Sub2;
                        Console.WriteLine("O resultado da subtração é: " + Subtracao);
                        break;
                    case 3:
                        Console.WriteLine("Você selecionou a operação Multiplicação: ");
                        Console.Write("Digite o primeiro numero para a Multiplicação ");
                        double Multi1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero para a multiplicação ");
                        double Multi2 = double.Parse(Console.ReadLine());
                        double Multipli = Multi1 * Multi2;
                        Console.WriteLine("O resultado da multiplicação é: " + Multipli);

                        break;
                    case 4:
                        Console.WriteLine("Você selecionou a operação Divisão: ");
                        Console.Write("Digite o primeiro numero para divisão, Cuidado 0 não é divisivel! ");
                        double Div1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero para a divisão ");
                        double Div2 = double.Parse(Console.ReadLine());
                        double Divi = Div1 / Div2;
                        if (Div1 == 0)
                        {
                            throw new DivideByZeroException("Não é possível dividir por zero.");
                        }else if(Div2 == 0)
                        {
                            throw new DivideByZeroException("Não é possível dividir por zero.");
                        }
                        else
                        {
                            Console.WriteLine("O resultado da divisão é: " + Divi);                        }
                        break;
                }

            }
            else if (AdicionarOperacao == "NAO" || AdicionarOperacao == "nao")
            {
                Console.WriteLine("Aperte qualquer tecla para encerrar");
            }
            else
            {
                Console.WriteLine("Opção inválida ");
            }



        }
    }

}
