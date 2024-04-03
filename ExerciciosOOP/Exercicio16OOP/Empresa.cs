using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16OOP
{
    internal class Empresa
    {

        public string Nome;
        public int Idade;
        public double ID;
        public string Cargo;
        public int CargoDigitado;
        DateTime HorarioEntradaExpediente = DateTime.Now;
        DateTime HorarioSaidaExpediente = DateTime.Now;
       
        


        public void Funcionario()
        {
            Console.WriteLine("Digite seu nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite sua ID");
            ID = double.Parse(Console.ReadLine());


        }

        public void EmpresaDados()
        {
          
            Console.WriteLine("Cargos disponíveis ");
            Console.WriteLine("1 - Diretor");
            Console.WriteLine("2 - Gerente");
            Console.WriteLine("3 - Analista");
            Console.WriteLine("4 - Programador");
            Console.WriteLine("5 - Estagiário");
            Console.WriteLine("Digite o numero do seu cargo ");
            CargoDigitado = int.Parse(Console.ReadLine());
            if(CargoDigitado == 1)
            {
                Cargo = "Diretor";
            }else if (CargoDigitado == 2)
            {
                Cargo = "Gerente";
            }else if (CargoDigitado == 3)
            {
                Cargo = "Analista";
            }else if (CargoDigitado == 4)
            {
                Cargo = "Programador";
            }else if  (CargoDigitado == 5)
            {
                Cargo = "Estagiário";
            }
           

          

            Console.WriteLine("Olá " + Nome + ", ID: " + ID + " Bem vindo!, Seu cargo é: " + Cargo);
            Console.WriteLine("Horário de entrada: " + HorarioEntradaExpediente);
            


        }
    }
}

