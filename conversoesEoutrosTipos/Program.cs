using System;

namespace convrsoesEoutrosTipos
{
class Programa
{
  static void Main(string[] args)
  {
    Console.WriteLine("Conversões e outros tipos");

    char letra = 'a';
    Console.WriteLine(letra);

    letra = (char)65;
    Console.WriteLine(letra);

    letra = (char)(86 + 1);
    Console.WriteLine(letra);

    string primeiraFrase = "Curso de Tecnologia - C# ";
    Console.WriteLine(primeiraFrase + 2022);

    string vazia = "";
    Console.WriteLine(vazia);

    letra = ' ';

    string cursos = @"Cursos de Tecnologia: 
    Go
    C#
    Java
    Python";
    Console.WriteLine(cursos);


    Console.WriteLine("Tecle enter para fechar...");
    Console.ReadLine();

    }
  }
};