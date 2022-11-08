using System;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Executando o projeto Condicionais.");

          int idadeJoão = 16;
          int quantidadePessoas = 2;


          bool acompanhado = quantidadePessoas > 1;

          string textoAdicional;

          if(acompanhado == true)
          {
            textoAdicional = "João está acompanhado!";
          }
          else
          {
            textoAdicional = "João não está acompanhado!";
          }


          if (idadeJoão >= 18 || acompanhado)
          {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
          }
          else
          {
              Console.WriteLine("Não pode entrar!");
          }

          Console.WriteLine("Tecle enter para fechar ...");      
          Console.ReadLine();    
        }
    }
}
