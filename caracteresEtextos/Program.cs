using System;

namespace projConversor
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Executando o projeto.");

          char letra = 'a';
          Console.WriteLine(letra);

          letra = (char)65;
          Console.WriteLine(letra);

          Console.WriteLine("Tecle enter para fechar...");
          Console.ReadLine();
        }
    };
};
