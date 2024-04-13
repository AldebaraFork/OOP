using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio20OOP
{
    internal class TextEditor
    {
        string TextoInserido;

        public void TextoModificado()
        {
            Console.WriteLine("Olá digite o texto que deseja modificar: ");
            string TextoInserido = Console.ReadLine();
         
      
            Console.WriteLine("O que você deseja fazer com o texto?: ");
            Console.WriteLine("1 - Contar os caracteres");
            Console.WriteLine("2 - Buscar uma palavra ou frase ");
            Console.WriteLine("3 - Deixar o texto maiúsculo: ");
            Console.WriteLine("4 - Deixar o texto minúsculo: ");
            Console.WriteLine("5 - Substituir palavras: ");
            int OpcaoInserida = int.Parse(Console.ReadLine());
            switch (OpcaoInserida)
            {
                case 1:
                    Console.WriteLine("Você selecionou a opção 1, contar caracteres! ");
                    int QuantidadeCaracteres = TextoInserido.Length;
                    Console.WriteLine("A quantidade de caracteres no texto inserido é de: " + QuantidadeCaracteres);
                    break;
                case 2:
                    Console.WriteLine("Você selecionou a opção 2, Buscar uma palavra ou frase!");
                    Console.WriteLine("Por-favor digite a palavra ou frase que deseja buscar: ");
                    string Buscada = Console.ReadLine();
                    var PalavraBuscadas = Buscada.Contains(Buscada, StringComparison.OrdinalIgnoreCase);
                    Console.Write("A palavra Existe no texto inserido!");
                    break;
                case 3:
                    Console.WriteLine("Você selecionou a opção 3, deixar o texto MAIÚSCULO: ");
                    string TextoMaiusculo = TextoInserido.ToUpper();
                    Console.WriteLine(TextoMaiusculo);
                    break;
                case 4:
                    Console.WriteLine("Você selecionou a opção 4, deixar o testo MINÚSCULO: ");
                    string TextoMinusculo = TextoInserido.ToLower();
                    Console.WriteLine(TextoMinusculo);
                    break;
                case 5:
                    Console.WriteLine("Você selecionou a opção 5, substituir uma palavra no texto! ");
                    Console.Write("Por-favor digite a palavra que deseja substituir: ");
                    string PalavraSubstituida = Console.ReadLine();
                    Console.Write("Por-favor digite a palavra que deseja subsituir por: " + PalavraSubstituida + " ");
                    string PalavraSubstituta = Console.ReadLine();
                    string TextoModificado = TextoInserido.Replace(PalavraSubstituida, PalavraSubstituta);
                    Console.WriteLine(TextoModificado);
                    break;
                default:
                    Console.WriteLine("Opção invalida! ");

                    break;


            }
        }
    }
}
