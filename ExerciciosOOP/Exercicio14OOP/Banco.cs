using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14OOP
{
    internal class Banco
    {
        static void Main(string[] args)
        {

            Encapsulamento2 usuario = new Encapsulamento2();

            usuario.Nome();
            //para usar o metodo Senha no Banco.cs sem quebrar o encapsulamento, é necessário passar os parametros senha1 e senha2 
            //para o metodo Senha no Banco.cs
            usuario.Senha(null, null);
            //ou usar o null como parametro 
            usuario.Pix(null);
            usuario.Recebedor(null);
            usuario.Transferencia(0, 0, 0);
           
           

        
          
        }
    }
}
