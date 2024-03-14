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
        //exemplo de encapsulamento, os atributos são privados e só podem ser acessados por metodos publicos
        private double _saldoEmConta;
        public double ValorTransferencia;
        public double SaldoFinal;
        //atributos privados para a senha começam com underline para diferenciar dos atributos publicos
        private string _senha1;
        private string _senha2;


        // metodo para realizar transferencia bancaria sem poluir o codigo principal
        // com detalhes de implementação, requer apenas a chamada do metodo para realizar a transferencia 
        //ainda precisa de ajustes que serão feitos em breve, como banco de dados e validações de dados 
        public void Transferencia()
        {
            Console.WriteLine("Olá digite o nome de Usuario: ");
            NomeUsuario = Console.ReadLine();
            Console.WriteLine("Digite o saldo em conta: ");
            _saldoEmConta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a senha: ");
            _senha1 = Console.ReadLine();
            Console.WriteLine("Digite a senha novamente: ");
            _senha2 = Console.ReadLine();
            if (_senha1 != _senha2)
            {
                Console.WriteLine("Senha incorreta");
                Console.WriteLine("Digite a senha novamente: ");
                _senha2 = Console.ReadLine();
            }
            else if (_senha1 == _senha2)
            {
                Console.WriteLine("Digite a Chave Pix: ");
                ChavePix = Console.ReadLine();
                Console.WriteLine("Digite o nome do recebedor: ");
                NomeRecebedor = Console.ReadLine();
                Console.WriteLine("Digite o valor da transferência: ");
                ValorTransferencia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ValorTransferencia > _saldoEmConta)
                {
                    Console.WriteLine("Saldo insuficiente para realizar a transferencia! ");
                }
                else if (ValorTransferencia <= _saldoEmConta)
                {
                    Console.WriteLine("Transferencia para: " + NomeRecebedor + " Concluida!");
                    SaldoFinal = _saldoEmConta - ValorTransferencia;

                    Console.WriteLine("Saldo em conta: " + SaldoFinal);

                }

            }
        }




    }



}
