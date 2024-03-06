using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio10OOP
{
    internal class MembrosEstaticos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dolar HOJE: ");
            Calculos.CotacaoDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar: ");
            Calculos.Dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Como mostrar apenas as duas casas decimais no conversor de moeda, é necessario instanciar a classe CultureInfo e usar a identação 

            Console.WriteLine("Valor a ser pago em reais: " + Calculos.ConversorDeMoeda().ToString("F2", CultureInfo.InvariantCulture));

          
        }
    }
}
