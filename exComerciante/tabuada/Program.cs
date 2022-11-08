// Faça um programa que leia um número emostre a tabuada de multiplicação dele

using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Digite um número e veja a sua tabuada: ");
            numero = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                resultado = numero * contador;
                Console.WriteLine(numero + " x " + contador + " = " + resultado);
            }
        }
    }
}