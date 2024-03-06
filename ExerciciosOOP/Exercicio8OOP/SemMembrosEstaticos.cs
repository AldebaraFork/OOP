using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio8OOP
{
    internal class SemMembrosEstaticos
    {
        static void Main(string[] args)
        {
            Circuferencia Dados = new Circuferencia();
            Console.Write("Entre o valor do raio: ");
            Dados.ValorRaio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Circunferência: {Dados.CalculoCircunferenia().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Dados.CalculoVolume().ToString("F2",CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Valor de PI: {Dados.Pi}");
        }
    }

    public class Circuferencia
    {

        public double ValorRaio;
        public double Pi = 3.14;


        public double CalculoCircunferenia()
        {
            return 2 * Pi * ValorRaio;

        }

        public double CalculoVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(ValorRaio, 3);
        }

    }
}
