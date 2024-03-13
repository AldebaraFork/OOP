using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Globalization;

namespace Exercicio13OOP
{
    internal class Encapsulamento
    {

        //encapsulamento é um dos principios da programação orientada a objetos
        //que consiste em ocultar detalhes de implementação de um objeto
        //expondo apenas o que é necessário para o uso externo.

        public string NomeUsuario;
        public string NomeRecebedor;

        public string ChavePix;
        public double SaldoEmConta;
        public double ValorTransferencia;
        public double SaldoFinal;
        public string Senha1;
        public string Senha2;


        public void Transferencia()
        {
              Console.WriteLine("Olá digite o nome de Usuario: ");
            NomeUsuario = Console.ReadLine();
            Console.WriteLine("Digite o saldo em conta: ");
            SaldoEmConta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a senha: ");
            Senha1 = Console.ReadLine();
            Console.WriteLine("Digite a senha novamente: ");
            Senha2 = Console.ReadLine();
            if (Senha1 != Senha2)
            {
                Console.WriteLine("Senha incorreta");
                Console.WriteLine("Digite a senha novamente: ");
                Senha2 = Console.ReadLine();
            }
            else if (Senha1 == Senha2)
            {
                Console.WriteLine("Digite a Chave Pix: ");
                ChavePix = Console.ReadLine();
                Console.WriteLine("Digite o nome do recebedor: ");
               NomeRecebedor = Console.ReadLine();
                Console.WriteLine("Digite o valor da transferência: ");
                ValorTransferencia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ValorTransferencia > SaldoEmConta)
                {
                    Console.WriteLine("Saldo insuficiente para realizar a transferencia! ");
                }
                else if (ValorTransferencia <= SaldoEmConta)
                {
                    Console.WriteLine("Transferencia para: " + NomeRecebedor + " Concluida!");
                    SaldoFinal = SaldoEmConta - ValorTransferencia;

                    Console.WriteLine("Saldo em conta: " + SaldoFinal);

                }

            }
        }




    }



}
