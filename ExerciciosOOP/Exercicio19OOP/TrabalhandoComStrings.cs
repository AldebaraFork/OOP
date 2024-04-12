using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19OOP
{
    internal class TrabalhandoComStrings
    {
        public void Teste()
        {
           string frase = "  I become death, The destroyer of worlds  ";


            //para tamanho se usa o length
            // usado para saber o tamanho do texto escrito, por isso a variavel é uma INT
            Console.WriteLine(frase);
            int tamanho = frase.Length;
            Console.WriteLine(tamanho);


            //ToLower e ToUpper é usado para retornar a string em letras Maiuscula ou Minuscula

            //Converte TODOS os caracteres para minusculo
            string Minusculo = frase.ToLower();
            Console.WriteLine(Minusculo);
            //Converte TODOS os caracteres para maiusculo
            string Maiusculo = frase.ToUpper();
            Console.WriteLine(Maiusculo);

            //Split recebe um caractere como separador e quebra a string baseado nesse separador 
            
           // separa o valor recebido de acordo com o que se encontra dentro do split 
            string [] Separador = frase.Split(' ');
            Console.WriteLine(Separador);


            //Trim, TrimEnd, TrimStart removem espaços em branco, receber um caractere no inicio, no meio, ou no fim
            //o TrimStart remove os caracteres em branco do INICIO da string
            string TremInicio = frase.TrimStart();
            Console.WriteLine(TremInicio);

            //o TrimEnd remove os caracteres em branco do FIM da string 
            string TremFim = frase.TrimEnd(',');
            Console.WriteLine(TremFim);
            //Trim remove das duas pontas
            string Trem = frase.Trim();
            Console.WriteLine(Trem);

            //IsNullOrWhiteSpace retorna um bool e verifica se o string se é um valor NULO ou composto apenas por espaços em brancos(vazio)
            //usado quando nao podemos aceitar um espaço em branco na aplicação
            var Nulo = string.IsNullOrWhiteSpace(frase);


            //Replace recebe 2 caracteres e substitui um caracter na string quando esta sendo feito a operação
            //literalmente troca algo na string por outra coisa
            string recoloca = frase.Replace("worlds" , "bitches");
            Console.WriteLine(recoloca);]


            
        }
        public void Buscas()
        {

            string Frase = "Eu sou Aatrox, o destruidor de mundos e seu mundo nâo sera poupado";
          
            
            //IndexOf (string) ou (char) 
            //retorna o Pedaço do indice que encontrar 
            var Indexo = Frase.IndexOf("mundos");
            Console.WriteLine(Indexo);



            //LastIndexOf (string) ou (char) 
            //retorna o ULTIMO indice 
            var UltimoIndexo = Frase.LastIndexOf("Mundos");
            Console.WriteLine(UltimoIndexo);


            //StartsWith (String) ou (char) 
            //verifica se COMEÇA com um indice e retorna um valor bool (verdadeiro ou falso)
            var ComecaCom = Frase.StartsWith("E");
            if (ComecaCom == true)
            {
                Console.Write("Ele de fato é o destruidor de mundos");
            }
            else
            {
                Console.WriteLine("ele nao é o devorador de mundos");
            }

            //Contains(String) ou (Char) 
            //usado para procurar um indice que voce nao sabe se esta maiusculo ou minusculo
            var destruidorRandom = Frase.Contains("destruidor", StringComparison.OrdinalIgnoreCase);
            var destruidorExact = Frase.Contains("Destruidor");
        }
    }
}
