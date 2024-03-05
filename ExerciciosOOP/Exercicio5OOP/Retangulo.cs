using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5OOP
{
    internal class Retangulo
    {
        static void Main(string[] args)
        {
           CalculoRetangulo ResultadoRetangulo = new CalculoRetangulo();
           

            Console.WriteLine("Digite a largura do retangulo: ");
            ResultadoRetangulo.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retangulo: ");
            ResultadoRetangulo.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + ResultadoRetangulo.Area());

            Console.WriteLine("PERIMETRO = " + ResultadoRetangulo.Perimetro());

            Console.WriteLine("DIAGONAL = " + ResultadoRetangulo.Diagonal());


        }
    }
}


public class CalculoRetangulo
{
    public double largura;
    public double altura;

    public double Area()
    {
        return largura * altura;
    }
    public double Perimetro()
    {
        return 2 * (largura + altura);
    }

    public double Diagonal()
    {
        return Math.Sqrt(largura * largura + altura * altura);
    }
}
