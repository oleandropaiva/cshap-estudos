using System;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Executando o projeto Condicionais.");

          int idadeJoão = 16;

          if (idadeJoão >= 18)
          {
            Console.WriteLine("Pode entrar!");
          }
          else
          {
            Console.WriteLine("Não pode entrar.");
          }

          Console.WriteLine("Tecle enter para fechar ...");      
          Console.ReadLine();    
        }
    };
};
