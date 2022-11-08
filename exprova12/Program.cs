// Faça uma prova de matemática para crianças que estão aprendendo a somar números inteiros menores do que 100. Escolha números aleatórios entre 1 e 100, e mostre na tela a pergunta: qual é a soma de a + b, onde a e b são os números aleatórios. Peça a resposta. Faça cinco perguntas ao aluno, e mostre para ele as perguntas e as respostas corretas, além de quais o aluno acertou.

using System;

namespace Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma, resposta, acertos = 0;
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                a = random.Next(1, 100);
                b = random.Next(1, 100);
                soma = a + b;

                Console.WriteLine("Qual é a soma de {0} + {1}?", a, b);
                resposta = int.Parse(Console.ReadLine());

                if (resposta == soma)
                {
                    Console.WriteLine("Resposta correta!");
                    acertos++;
                }
                else
                {
                    Console.WriteLine("Resposta incorreta!");
                }
            }

            Console.WriteLine("Você acertou {0} de 5 questões.", acertos);
        }
    }
}