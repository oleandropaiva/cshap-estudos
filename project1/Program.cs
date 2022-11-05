
using System;

namespace project1
{
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade = 32;

        idade = 37;
        Console.WriteLine("Minha idade é " + idade);

        idade = 27 + 5;
        Console.WriteLine(idade);

        idade = 5 * 2 -6;
        Console.WriteLine(idade);

        idade = (5 - 2) * 2;
        Console.WriteLine(idade);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
  }
};
