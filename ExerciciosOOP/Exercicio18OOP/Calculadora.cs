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
                //ADIÇÃO
                case 1:
                    
                    Console.WriteLine("Voce selecionou a operação adição");
                    Console.WriteLine("Quantos numeros voce deseja somar? de 2 até 5");
                    int QuantidadeSoma = int.Parse(Console.ReadLine());
                    switch (QuantidadeSoma)
                    {
                        case 2:
                            Console.WriteLine("Voce selecionou 2 numeros! ");
                            Console.Write("Digite o primeiro numero: ");
                            double Soma1 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Soma2 = double.Parse(Console.ReadLine());
                            double Resultado1 = Soma1 + Soma2;
                            Console.WriteLine("O resultado de " + Soma1 + " e " + Soma2 + " é : " + Resultado1.ToString(CultureInfo.InvariantCulture));
                            break;
                        case 3:
                            Console.WriteLine("Voce selecionou 3 numeros! ");
                            Console.Write("Digite o primeiro numero: ");
                            double Soma3 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Soma4 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o terceiro numero: ");
                            double Soma5 = double.Parse(Console.ReadLine());
                            double Resultado2 = Soma3 + Soma4 + Soma5;
                            Console.WriteLine("O resultado de " + Soma3 + " + " + Soma4 + " + " + Soma5 + " é: " + Resultado2.ToString(CultureInfo.InvariantCulture));
                            break;
                        case 4:
                            Console.WriteLine("Voce selecionou 4 numeros! ");
                            Console.Write("Digite o primeiro numero: ");
                            double Soma6 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Soma7 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o terceiro numero: ");
                            double Soma8 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o quarto numero: ");
                            double Soma9 = double.Parse(Console.ReadLine());
                            double Resultado3 = Soma6 + Soma7 + Soma8 + Soma9;
                            Console.WriteLine("O resultado de " + Soma6 + " + " + Soma7 + " + " + Soma8 + " + " + Soma9 + " é: " + Resultado3.ToString(CultureInfo.InvariantCulture));
                            break;
                        case 5:
                            Console.WriteLine("Voce selecionou 5 numeros! ");
                            Console.Write("Digite o primero numero: ");
                            double Soma10 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Soma11 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o terceiro numero: ");
                            double Soma12 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o quarto numero: ");
                            double Soma13 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o quinto numero: ");
                            double Soma14 = double.Parse(Console.ReadLine());
                            double Resultado4 = Soma10 + Soma11 + Soma12 + Soma13 + Soma14;
                            Console.WriteLine("O resultado de " + Soma10 + " + " + Soma11 + " + " + Soma12 + " + " + Soma13 + " + " + Soma14 + " é: " + Resultado4.ToString(CultureInfo.InvariantCulture));
                            break;
                        default:
                            Console.WriteLine("Numero invalido");
                            break;
                    }
                    break;

                //SUBTRAÇÃO
                case 2:
                    Console.WriteLine("Voce selecionou  a operaçao subtração ");
                    Console.WriteLine("Quantos numeros voce deseja subtrair? de 2 ate 5! ");
                    int QuantidadeSubtracao = int.Parse(Console.ReadLine());
                    switch (QuantidadeSubtracao)
                    {
                        case 2:
                            Console.WriteLine("Voce selecionou 2 numeros! ");
                            Console.Write("Digite o primeiro numero: ");
                            double Sub1 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Sub2 = double.Parse(Console.ReadLine());
                            double ResSub1 = Sub1 - Sub2;
                            Console.WriteLine("O resultado de " + Sub1 + " e " + Sub2 + " é : " + ResSub1.ToString(CultureInfo.InvariantCulture));
                            break;
                        case 3:
                            Console.WriteLine("Voce selecionou 3 numeros! ");
                            Console.Write("Digite o primeiro numero: ");
                            double Sub3 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Sub4 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o terceiro numero: ");
                            double Sub5 = double.Parse(Console.ReadLine());
                            double ResSub2 = Sub3 - Sub4 - Sub5;
                            Console.WriteLine("O resultado de " + Sub3 + " + " + Sub4 + " + " + Sub5 + " é: " + ResSub2.ToString(CultureInfo.InvariantCulture));
                            break;
                        case 4:
                            Console.WriteLine("Voce selecionou 4 numeros! ");
                            Console.Write("Digite o primeiro numero: ");
                            double Sub6 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Sub7 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o terceiro numero: ");
                            double Sub8 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o quarto numero: ");
                            double Sub9 = double.Parse(Console.ReadLine());
                            double ResSub3 = Sub6 - Sub7 - Sub8 - Sub9;
                            Console.WriteLine("O resultado de " + Sub6 + " - " + Sub7 + " - " + Sub8 + " - " + Sub9 + " é: " + ResSub3.ToString(CultureInfo.InvariantCulture));
                            break;
                        case 5:
                            Console.WriteLine("Voce selecionou 5 numeros! ");
                            Console.Write("Digite o primero numero: ");
                            double Sub10 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Sub11 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o terceiro numero: ");
                            double Sub12 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o quarto numero: ");
                            double Sub13 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o quinto numero: ");
                            double Sub14 = double.Parse(Console.ReadLine());
                            double ResSub4 = Sub10 - Sub11 - Sub12 - Sub13 - Sub14;
                            Console.WriteLine("O resultado de " + Sub10 + " - " + Sub11 + " - " + Sub12 + " - " + Sub13 + " - " + Sub14 + " é: " + ResSub4.ToString(CultureInfo.InvariantCulture));
                            break;
                        default:
                            Console.WriteLine("Numero invalido");
                            break;
                    }
                    break;


                //MULTIPLICAÇÃO
                case 3:
                    Console.WriteLine("Voce selecionou  a operaçao subtração ");
                    Console.WriteLine("Quantos numeros voce deseja multiplicar? de 2 ate 5! ");
                    int QuantidadeMulti = int.Parse(Console.ReadLine());
                    switch (QuantidadeMulti)
                    {
                        case 2:
                            Console.WriteLine("Voce selecionou 2 numeros! ");
                            Console.Write("Digite o primeiro numero: ");
                            double Mult1 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Mult2 = double.Parse(Console.ReadLine());
                            double ResMult1 = Mult1 * Mult2;
                            Console.WriteLine("O resultado de " + Mult1 + " e " + Mult2 + " é : " + ResMult1.ToString(CultureInfo.InvariantCulture));
                            break;
                        case 3:
                            Console.WriteLine("Voce selecionou 3 numeros! ");
                            Console.Write("Digite o primeiro numero: ");
                            double Mult3 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Mult4 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o terceiro numero: ");
                            double Mult5 = double.Parse(Console.ReadLine());
                            double ResMult2 = Mult3 * Mult4 * Mult5;
                            Console.WriteLine("O resultado de " + Mult3 + " * " + Mult4 + " * " + Mult5 + " é: " + ResMult2.ToString(CultureInfo.InvariantCulture));
                            break;
                        case 4:
                            Console.WriteLine("Voce selecionou 4 numeros! ");
                            Console.Write("Digite o primeiro numero: ");
                            double Mult6 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Mult7 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o terceiro numero: ");
                            double Mult8 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o quarto numero: ");
                            double Mult9 = double.Parse(Console.ReadLine());
                            double ResMult3 = Mult6 * Mult7 * Mult8 * Mult9;
                            Console.WriteLine("O resultado de " + Mult6 + " * " + Mult7 + " * " + Mult8 + " * " + Mult8 + " é: " + ResMult3.ToString(CultureInfo.InvariantCulture));
                            break;
                        case 5:
                            Console.WriteLine("Voce selecionou 5 numeros! ");
                            Console.Write("Digite o primero numero: ");
                            double Sub10 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o segundo numero: ");
                            double Sub11 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o terceiro numero: ");
                            double Sub12 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o quarto numero: ");
                            double Sub13 = double.Parse(Console.ReadLine());
                            Console.Write("Digite o quinto numero: ");
                            double Sub14 = double.Parse(Console.ReadLine());
                            double ResSub4 = Sub10 * Sub11 * Sub12 * Sub13 * Sub14;
                            Console.WriteLine("O resultado de " + Sub10 + " * " + Sub11 + " * " + Sub12 + " * " + Sub13 + " * " + Sub14 + " é: " + ResSub4.ToString(CultureInfo.InvariantCulture));
                            break;
                        default:
                            Console.WriteLine("Numero invalido");
                            break;
                    }
                    break;

                //DIVISÃO
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

                //MOD
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
                    //ADIÇÃO
                    case 1:

                        Console.WriteLine("Voce selecionou a operação adição");
                        Console.WriteLine("Quantos numeros voce deseja somar? de 2 até 5");
                        int QuantidadeSoma = int.Parse(Console.ReadLine());
                        switch (QuantidadeSoma)
                        {
                            case 2:
                                Console.WriteLine("Voce selecionou 2 numeros! ");
                                Console.Write("Digite o primeiro numero: ");
                                double Soma1 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Soma2 = double.Parse(Console.ReadLine());
                                double Resultado1 = Soma1 + Soma2;
                                Console.WriteLine("O resultado de " + Soma1 + " e " + Soma2 + " é : " + Resultado1.ToString(CultureInfo.InvariantCulture));
                                break;
                            case 3:
                                Console.WriteLine("Voce selecionou 3 numeros! ");
                                Console.Write("Digite o primeiro numero: ");
                                double Soma3 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Soma4 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o terceiro numero: ");
                                double Soma5 = double.Parse(Console.ReadLine());
                                double Resultado2 = Soma3 + Soma4 + Soma5;
                                Console.WriteLine("O resultado de " + Soma3 + " + " + Soma4 + " + " + Soma5 + " é: " + Resultado2.ToString(CultureInfo.InvariantCulture));
                                break;
                            case 4:
                                Console.WriteLine("Voce selecionou 4 numeros! ");
                                Console.Write("Digite o primeiro numero: ");
                                double Soma6 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Soma7 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o terceiro numero: ");
                                double Soma8 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o quarto numero: ");
                                double Soma9 = double.Parse(Console.ReadLine());
                                double Resultado3 = Soma6 + Soma7 + Soma8 + Soma9;
                                Console.WriteLine("O resultado de " + Soma6 + " + " + Soma7 + " + " + Soma8 + " + " + Soma9 + " é: " + Resultado3.ToString(CultureInfo.InvariantCulture));
                                break;
                            case 5:
                                Console.WriteLine("Voce selecionou 5 numeros! ");
                                Console.Write("Digite o primero numero: ");
                                double Soma10 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Soma11 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o terceiro numero: ");
                                double Soma12 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o quarto numero: ");
                                double Soma13 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o quinto numero: ");
                                double Soma14 = double.Parse(Console.ReadLine());
                                double Resultado4 = Soma10 + Soma11 + Soma12 + Soma13 + Soma14;
                                Console.WriteLine("O resultado de " + Soma10 + " + " + Soma11 + " + " + Soma12 + " + " + Soma13 + " + " + Soma14 + " é: " + Resultado4.ToString(CultureInfo.InvariantCulture));
                                break;
                            default:
                                Console.WriteLine("Numero invalido");
                                break;
                        }
                        break;
                    //SUBTRAÇÃO
                    case 2:
                        Console.WriteLine("Voce selecionou  a operaçao subtração ");
                        Console.WriteLine("Quantos numeros voce deseja subtrair? de 2 ate 5! ");
                        int QuantidadeSubtracao = int.Parse(Console.ReadLine());
                        switch (QuantidadeSubtracao)
                        {
                            case 2:
                                Console.WriteLine("Voce selecionou 2 numeros! ");
                                Console.Write("Digite o primeiro numero: ");
                                double Sub1 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Sub2 = double.Parse(Console.ReadLine());
                                double ResSub1 = Sub1 - Sub2;
                                Console.WriteLine("O resultado de " + Sub1 + " e " + Sub2 + " é : " + ResSub1.ToString(CultureInfo.InvariantCulture));
                                break;
                            case 3:
                                Console.WriteLine("Voce selecionou 3 numeros! ");
                                Console.Write("Digite o primeiro numero: ");
                                double Sub3 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Sub4 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o terceiro numero: ");
                                double Sub5 = double.Parse(Console.ReadLine());
                                double ResSub2 = Sub3 - Sub4 - Sub5;
                                Console.WriteLine("O resultado de " + Sub3 + " - " + Sub4 + " - " + Sub5 + " é: " + ResSub2.ToString(CultureInfo.InvariantCulture));
                                break;
                            case 4:
                                Console.WriteLine("Voce selecionou 4 numeros! ");
                                Console.Write("Digite o primeiro numero: ");
                                double Sub6 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Sub7 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o terceiro numero: ");
                                double Sub8 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o quarto numero: ");
                                double Sub9 = double.Parse(Console.ReadLine());
                                double ResSub3 = Sub6 - Sub7 - Sub8 - Sub9;
                                Console.WriteLine("O resultado de " + Sub6 + " - " + Sub7 + " - " + Sub8 + " - " + Sub9 + " é: " + ResSub3.ToString(CultureInfo.InvariantCulture));
                                break;
                            case 5:
                                Console.WriteLine("Voce selecionou 5 numeros! ");
                                Console.Write("Digite o primero numero: ");
                                double Sub10 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Sub11 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o terceiro numero: ");
                                double Sub12 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o quarto numero: ");
                                double Sub13 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o quinto numero: ");
                                double Sub14 = double.Parse(Console.ReadLine());
                                double ResSub4 = Sub10 - Sub11 - Sub12 - Sub13 - Sub14;
                                Console.WriteLine("O resultado de " + Sub10 + " - " + Sub11 + " - " + Sub12 + " - " + Sub13 + " - " + Sub14 + " é: " + ResSub4.ToString(CultureInfo.InvariantCulture));
                                break;
                            default:
                                Console.WriteLine("Numero invalido");
                                break;
                        }
                        break;
                    //MULTIPLICAÇÃO
                    case 3:
                        Console.WriteLine("Voce selecionou  a operaçao multiplicãção ");
                        Console.WriteLine("Quantos numeros voce deseja multiplicar? de 2 ate 5! ");
                        int QuantidadeMulti = int.Parse(Console.ReadLine());
                        switch (QuantidadeMulti)
                        {
                            case 2:
                                Console.WriteLine("Voce selecionou 2 numeros! ");
                                Console.Write("Digite o primeiro numero: ");
                                double Mult1 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Mult2 = double.Parse(Console.ReadLine());
                                double ResMult1 = Mult1 * Mult2;
                                Console.WriteLine("O resultado de " + Mult1 + " e " + Mult2 + " é : " + ResMult1.ToString(CultureInfo.InvariantCulture));
                                break;
                            case 3:
                                Console.WriteLine("Voce selecionou 3 numeros! ");
                                Console.Write("Digite o primeiro numero: ");
                                double Mult3 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Mult4 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o terceiro numero: ");
                                double Mult5 = double.Parse(Console.ReadLine());
                                double ResMult2 = Mult3 * Mult4 * Mult5;
                                Console.WriteLine("O resultado de " + Mult3 + " * " + Mult4 + " * " + Mult5 + " é: " + ResMult2.ToString(CultureInfo.InvariantCulture));
                                break;
                            case 4:
                                Console.WriteLine("Voce selecionou 4 numeros! ");
                                Console.Write("Digite o primeiro numero: ");
                                double Mult6 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Mult7 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o terceiro numero: ");
                                double Mult8 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o quarto numero: ");
                                double Mult9 = double.Parse(Console.ReadLine());
                                double ResMult3 = Mult6 * Mult7 * Mult8 * Mult9;
                                Console.WriteLine("O resultado de " + Mult6 + " * " + Mult7 + " * " + Mult8 + " * " + Mult8 + " é: " + ResMult3.ToString(CultureInfo.InvariantCulture));
                                break;
                            case 5:
                                Console.WriteLine("Voce selecionou 5 numeros! ");
                                Console.Write("Digite o primero numero: ");
                                double Sub10 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                double Sub11 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o terceiro numero: ");
                                double Sub12 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o quarto numero: ");
                                double Sub13 = double.Parse(Console.ReadLine());
                                Console.Write("Digite o quinto numero: ");
                                double Sub14 = double.Parse(Console.ReadLine());
                                double ResSub4 = Sub10 * Sub11 * Sub12 * Sub13 * Sub14;
                                Console.WriteLine("O resultado de " + Sub10 + " * " + Sub11 + " * " + Sub12 + " * " + Sub13 + " * " + Sub14 + " é: " + ResSub4.ToString(CultureInfo.InvariantCulture));
                                break;
                            default:
                                Console.WriteLine("Numero invalido");
                                break;
                        }
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
                Console.WriteLine("Fatorial de " + numero + " é " + resultado.ToString(CultureInfo.InvariantCulture));

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

        //MMC (Minimo Multiplo Comum)



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
                            Console.WriteLine("Parabens! você foi aprovado com a média: " + Mediana, "F2".ToString(CultureInfo.InvariantCulture));
                        }
                        else if (Mediana <= MediaAprovacao)
                        {
                            Console.WriteLine("Infelizmente você foi reprovado com a média: " + Mediana, "F2".ToString(CultureInfo.InvariantCulture));
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
                            Console.WriteLine("Parabens! você foi aprovado com a média: " + MEDI, "F2".ToString(CultureInfo.InvariantCulture));
                        }
                        else if (MEDI <= MediaAprovacao)
                        {
                            Console.WriteLine("Infelizmente você foi reprovado com a média: " + MEDI, "F2".ToString(CultureInfo.InvariantCulture));
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
