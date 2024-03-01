
using System.Reflection.Metadata.Ecma335;

namespace OOP1
{
     class Programa
    {
        static void Main(string[] args)
        {

            //Precisa botar o new para INSTANCIAR a variavel, que cria na memoria um OBJETO composto pelos atributos da classe
            //Agora Dados é um objeto da classe Pessoa
            Pessoa Dados = new Pessoa();


            //Aqui é um exemplo de como usar o atributo NOME  da classe Pessoa
            Console.WriteLine("Olá, Por favor digite seu nome: ");
            Dados.Nome = Console.ReadLine();
            //Aqui é um exemplo de como usar os atributos da classe
            Dados.Idade = int.Parse(Console.ReadLine());


        }
    }


    internal class Pessoa
    {
        //Isso é um atributo public (significa que os atributos podem ser usados em outro arquivo)
        public int Idade;
        public string Nome;
        private double CPF;
        private string Genero;
        private string Endereco;
        private string Telefone;


        
    }
}
