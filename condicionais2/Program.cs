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
          bool grupo = true;

          if (idadeJoão >= 18 || grupo)
          {
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
