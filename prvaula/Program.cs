// Faça um algoritmo que leia o nome, a idade, e se tem carteira de motorista de 15 pessoas. Implemente as seguintes regras:

// Caso a idade seja menor que 18 anos, não pergunte se tem carteira de motorista.
// Precisamos de dois motoristas para dirigir em uma viagem.
// Ao identificar os dois primeiros, pare o questionário.
// Ao final, exiba o nome dos motoristas ou caso não encontre os dois, exiba: viagem não será realizada devido falta de motoristas

using System;

namespace project1
{
class Programa
{
    static void Main(string[] args)
    {

        string nome;
        int idade;
        string carteira;
        int motoristas = 0;

        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você tem carteira de motorista? (S/N)");
                carteira = Console.ReadLine();

                if (carteira == "S" || carteira == "s")
                {
                    Console.WriteLine("Você é um motorista!");
                    motoristas++;
                }
                else
                {
                    Console.WriteLine("Você não é um motorista!");
                }
            }
            else
            {
                Console.WriteLine("Você não é um motorista!");
            }

            if (motoristas == 2)
            {
                Console.WriteLine("Viagem realizada com sucesso!");
                break;
            }
        }

        if (motoristas < 2)
        {
            Console.WriteLine("Viagem não será realizada devido falta de motoristas");
        }
    }
}
}


