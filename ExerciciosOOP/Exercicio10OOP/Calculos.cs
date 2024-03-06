using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio10OOP
{
    //membros estaticos são membros que pertencem a classe e não a instancia do objeto
    //ou seja nao é necessario CRIAR um objeto no programa principal para poder utilizar os membros estaticos de uma classe

    internal class Calculos
    {


        public static double CotacaoDolar;
        public static double IOF = 6;
        public static double Dolares;
        public static double ValorEmReais;

        public static double ConversorDeMoeda()
        {
            return (CotacaoDolar * Dolares) + (CotacaoDolar * Dolares * IOF / 100);
        }
    }
}
