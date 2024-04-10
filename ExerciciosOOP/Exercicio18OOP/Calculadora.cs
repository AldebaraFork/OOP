using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio18OOP
{
    public class Calculadora
    {
        double OperacaoSelecionada;
        double OperacaoSelecionada2;


        public Calculadora()
        {
            //primeira operação 
            Console.WriteLine("Digite o numero da Operação ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtraçao");
            Console.WriteLine("3 - Multiplicar ");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Resto de Divisão");
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
                    Console.WriteLine("O resultado da subratraço: " + subtracao.ToString(CultureInfo.InvariantCulture));
                    break;
                case 3:
                    Console.WriteLine("Voce selecionou a operação de multiplicação");
                    Console.Write("Digite o primeiro numero: ");
                    double Multi1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite o segundo numero: ");
                    double Multi2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double Multiplicacao = Multi1 * Multi2;
                    Console.WriteLine("O resultado da multiplicação é: " + Multiplicacao.ToString(CultureInfo.InvariantCulture));
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
                case 5:
                    Console.WriteLine("Você selecionou a operação de Resto de Divisão ");
                    Console.Write("Digite o primeiro numero: ");
                    double Rest1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo numero:");
                    double Rest2 = double.Parse(Console.ReadLine());
                    double Resto1 = Rest1 % Rest2;
                    Console.WriteLine("O resto da divisão é: " + Resto1.ToString(CultureInfo.InvariantCulture));
                    break;

                default:
                    Console.WriteLine("Opção invalida, Selecione uma das opções acima! ");
                    break;
            }

            //segunda operação 
            string AdicionarOperacao;
            Console.WriteLine("Deseja calcular mais uma operação?");
            Console.WriteLine("Digite SIM ou NÂO ");
            AdicionarOperacao = Console.ReadLine();
            if (AdicionarOperacao == "SIM" || AdicionarOperacao == "sim")
            {
                Console.WriteLine("Digite o numero da Operação ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtraçao");
                Console.WriteLine("3 - Multiplicar ");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Resto de divisão");
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
                        }
                        else if (Div2 == 0)
                        {
                            throw new DivideByZeroException("Não é possível dividir por zero.");
                        }
                        else
                        {
                            Console.WriteLine("O resultado da divisão é: " + Divi);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Você selecionou a operação de Resto de Divisão ");
                        Console.Write("Digite o primeiro numero: ");
                        double Res1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero:");
                        double Res2 = double.Parse(Console.ReadLine());
                        double Resto = Res1 % Res2;
                        Console.WriteLine("O resto da divisão é: " + Resto.ToString(CultureInfo.InvariantCulture));
                        break;
                }
            }
            else if (AdicionarOperacao == "NAO" || AdicionarOperacao == "nao")
            {
                Console.WriteLine("Aperte qualquer tecla para continuar");

            }
            else
            {
                Console.WriteLine("Opção inválida ");
            }
        }
        public void Fatorial()
        {
            Console.WriteLine("Voce Deseja Calcular fatorial? ");
            string SelecaoFatorial = Console.ReadLine();
            if (SelecaoFatorial == "SIM" || SelecaoFatorial == "sim" || SelecaoFatorial == "s" || SelecaoFatorial == "Sim")
            {
                Console.Write("Informe um numero inteiro positivo: ");
                double numero = double.Parse(Console.ReadLine());
                double resultado = 1;
                while (numero != 1)
                {
                    resultado = resultado * numero;
                    numero = numero - 1;
                }
                Console.WriteLine("Fatorial de " + numero + " é " + resultado);

            }
            else if (SelecaoFatorial == "NAO" || SelecaoFatorial == "nao" || SelecaoFatorial == "nao" || SelecaoFatorial == "Nao")
            {
                Console.WriteLine("Pressione qualquer tecla para continuar");

            }
            else
            {
                Console.WriteLine("Opção invalida");
            }
        }



        //MDC (Maximo Divisor Comum)
        public void MDC()
        {
            Console.WriteLine("Deseja calcular MDC? (Maximo Divisor Comum)");
            string OperacaoMDC = Console.ReadLine();

            if (OperacaoMDC == "SIM" || OperacaoMDC == "sim" || OperacaoMDC == "Sim" || OperacaoMDC == "s")
            {
                Console.Write("Insira um numero inteiro: ");
                int Mda1 = int.Parse(Console.ReadLine());
                Console.Write("Insira mais um numero inteiro: ");
                int Mda2 = int.Parse(Console.ReadLine());

                if (Mda2 == 0)
                {
                    Console.WriteLine("O divisor não pode ser zero. Tente novamente.");
                    return;
                }

                if (Mda1 == Mda2)
                {
                    Console.WriteLine("O MDC dos números " + Mda1 + " e " + Mda2 + " é " + Mda1);
                    return;
                }

                if (Mda1 == 1 || Mda2 == 1)
                {
                    Console.WriteLine("O MDC dos números " + Mda1 + " e " + Mda2 + " é 1");
                    return;
                }

                int RestoMDC = Mda1 % Mda2;

                while (RestoMDC != 0)
                {
                    Mda1 = Mda2;
                    Mda2 = RestoMDC;
                    RestoMDC = Mda1 % Mda2;
                }

                Console.WriteLine("O MDC dos números " + Mda1 + " e " + Mda2 + " é " + Mda1);
            }
            else if (OperacaoMDC == "NAO" || OperacaoMDC == "nao" || OperacaoMDC == "Nao" || OperacaoMDC == "n")
            {
                Console.WriteLine("Presione qualquer tecla para continuar ");
            }
            else
            {
                Console.WriteLine("Operação invalida ");
            }
        }



        //calcular nota

        public void CalculadoraNota()
        {
            Console.WriteLine("Deseja Calcular uma Nota? ");
            string OperacaoNota = Console.ReadLine();
            if (OperacaoNota == "SIM" || OperacaoNota == "sim" || OperacaoNota == "Sim" || OperacaoNota == "s")
            {
                Console.WriteLine("Qual a Média necessaria para aprovação?  ");
                double MediaAprovacao = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantas notas foram usadas? ");
                int NotasUsadas = int.Parse(Console.ReadLine());

                switch (NotasUsadas)
                {
                    case 1:
                        Console.WriteLine("Nao é possivel calcular uma Media com apenas uma nota! ");
                        break;
                    case 2:
                        Console.Write("Digite a primeira nota: ");
                        double Nota1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a segunda nota: ");
                        double Nota2 = double.Parse(Console.ReadLine());
                        double Median = (Nota1 + Nota2) / 2;

                        if (Median >= MediaAprovacao)
                        {
                            Console.WriteLine("Parabens! você foi aprovado com a média: " + Median.ToString(CultureInfo.InvariantCulture));
                        }
                        else if (Median < MediaAprovacao)
                        {
                            Console.WriteLine("Infelizmente você foi reprovado com a média: " + Median.ToString(CultureInfo.InvariantCulture));
                        }
                        break;
                    case 3:
                        Console.Write("Digite a primeira nota: ");
                        double Nota3 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a segunda nota: ");
                        double Nota4 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a terceira nota: ");
                        double Nota5 = double.Parse(Console.ReadLine());
                        double Mediana = (Nota3 + Nota4 + Nota5) / 3;

                        if (Mediana >= MediaAprovacao)
                        {
                            Console.WriteLine("Parabens! você foi aprovado com a média: " + Mediana.ToString(CultureInfo.InvariantCulture));
                        }
                        else if (Mediana <= MediaAprovacao)
                        {
                            Console.WriteLine("Infelizmente você foi reprovado com a média: " + Mediana.ToString(CultureInfo.InvariantCulture));
                        }
                        break;
                    case 4:
                        Console.Write("Digite a primeira nota: ");
                        double Nota6 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a segunda nota: ");
                        double Nota7 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a terceira nota: ");
                        double Nota8 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a quarta nota: ");
                        double Nota9 = double.Parse(Console.ReadLine());
                        double MEDI = (Nota6 + Nota7 + Nota8 + Nota9) / 4;
                        if (MEDI >= MediaAprovacao)
                        {
                            Console.WriteLine("Parabens! você foi aprovado com a média: " + MEDI.ToString(CultureInfo.InvariantCulture));
                        }
                        else if (MEDI <= MediaAprovacao)
                        {
                            Console.WriteLine("Infelizmente você foi reprovado com a média: " + MEDI.ToString(CultureInfo.InvariantCulture));
                        }
                        break;
                }
            }
            else if (OperacaoNota == "Nao" || OperacaoNota == "NAO" || OperacaoNota == "nao" || OperacaoNota == "n")
            {
                Console.WriteLine("Pressione qualquer tecla para continuar ");

            }
            else
            {
                Console.WriteLine("Operação inválida! ");
            }
        }

    }
}
