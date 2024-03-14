using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14OOP
{
    internal class Encapsulamento2
    {
       

      
        //exemplo de encapsulamento, os atributos são privados e só podem ser acessados por metodos publicos
        //atributos privados começam com underline e letra minuscula
        public string NomeUsuario;
        public string NomeRecebedor;
        private string _senha1;
        private string _senha2;
        public string ChavePix;
        private double _saldoEmConta;
        public double ValorTransferencia;
        public double SaldoFinal;


        // metodo para realizar transferencia bancaria sem poluir o codigo principal
        // com detalhes de implementação, requer apenas a chamada do metodo para realizar a transferencia 
        //ainda precisa de ajustes que serão feitos em breve, como banco de dados e validações de dados 


        public void Nome()
        {
            Console.WriteLine("Olá digite o nome de Usuario: ");
            NomeUsuario = Console.ReadLine();
            if (NomeUsuario != null && NomeUsuario.Length > 1)
            {
                this.NomeUsuario = NomeUsuario;
            }
            else
            {
                Console.WriteLine("Nome de usuario invalido");
            }


        }
        //como usar o metodo Senha no Banco.cs sem quebrar o encapsulamento?


        public void Senha(string senha1, string senha2)
        {
            Console.WriteLine("Digite a senha: ");
            senha1 = Console.ReadLine();
            Console.WriteLine("Digite a senha novamente: ");
            senha2 = Console.ReadLine();


            if (senha1 == senha2)
            {
                Console.WriteLine("Bem vindo ao aplicativo! ");
            }
            else if (senha1 != senha2)
            {
                Console.WriteLine("As senhas não conferem, tente novamente");
            }
            else if (senha1 == null || senha2 == null)
            {
                Console.WriteLine("Senha invalida");
            }
            else if (senha1.Length <= 1 || senha2.Length <= 1)
            {
                Console.WriteLine("Senha invalida");
            }
         
            
        }

        public void Pix(string ChavePix)
        {
            Console.WriteLine("Digite a chave PIX: ");
            ChavePix = Console.ReadLine();
            if (ChavePix != null && ChavePix.Length > 1)
            {
                ChavePix = ChavePix;
            }
            else
            {
                Console.WriteLine("Chave PIX invalida");
            }
        }
        public void Recebedor(string NomeRecebedor)
        {
            Console.WriteLine("Digite o nome do recebedor: ");
            NomeRecebedor = Console.ReadLine();
            if (NomeRecebedor != null && NomeRecebedor.Length > 1)
            {
                NomeRecebedor = NomeRecebedor;
            }
            else if (NomeRecebedor == null)
            {
                Console.WriteLine("Nome do recebedor invalido");
            }
            else if (NomeRecebedor.Length < 1)
            {
                Console.WriteLine("Nome do recebedor invalido");
            }


        }

        public void Transferencia(double _saldoEmConta, double ValorTransferencia, double SaldoFinal)
        {
            Console.WriteLine("Digite o valor em conta: ");
            _saldoEmConta = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da transferencia: ");
            ValorTransferencia = double.Parse(Console.ReadLine());
            SaldoFinal = _saldoEmConta - ValorTransferencia;
            if (_saldoEmConta < ValorTransferencia)
            {
                Console.WriteLine("Saldo insuficiente! ");
            }
            else if (_saldoEmConta <= 0)
            {
                Console.WriteLine("Saldo insuficiente!");

            }
            else
            {
                Console.WriteLine("Transferencia realizada com sucesso! ");
                Console.WriteLine("Saldo atual: " + SaldoFinal);
            }

        }
    }
}
