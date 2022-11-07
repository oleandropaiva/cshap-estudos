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

          if (idadeJoão >= 18)
          {
            Console.WriteLine("Pode entrar!");
          }
          else
          {
            if (quantidadePessoas > 1)
            {
              Console.WriteLine("Pode entrar, pois está acompanhado!");
            }
            else
            {
              Console.WriteLine("Não pode entrar!");
          }

          Console.WriteLine("Tecle enter para fechar ...");      
          Console.ReadLine();    
        }
    }
}}
