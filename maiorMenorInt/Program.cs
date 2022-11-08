// Ler um vetor com 10 inteiros e descubra o maior e o menor elemento do vetor.

using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int maior = 0, menor = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
        }
    }
}
