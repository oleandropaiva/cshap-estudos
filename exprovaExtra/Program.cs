// Uma empresa vende o mesmo produto para diferentes estados. Cada estado possui uma taxa diferente de imposto sobre o produto (MG 7%; SP 12%; RJ 15%; MS 8%; ES 12%; SC 18%;). Faça um programa em que o usuário entre com o valor e o estado de destino do produto e o programa retorne o preço final do produto acrescido do imposto do estado em que ele será vendido. Se o estado digitado não for válido, mostrar uma mensagem de erro.

// O usuário deve utilizar o programa obtendo o preço final até que ele digite SAIR.

using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string estado;
            double preco, precoFinal;

            Console.WriteLine("Digite o valor do produto: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o estado da rota do produto: ");
            estado = Console.ReadLine();

            while (estado != "SAIR")
            {
                if (estado == "MG")
                {
                    precoFinal = preco + (preco * 0.07);
                    Console.WriteLine("O valor final do produto é: " + precoFinal);
                }
                else if (estado == "SP")
                {
                    precoFinal = preco + (preco * 0.12);
                    Console.WriteLine("O valor final do produto é: " + precoFinal);
                }
                else if (estado == "RJ")
                {
                    precoFinal = preco + (preco * 0.15);
                    Console.WriteLine("O valor final do produto é: " + precoFinal);
                }
                else if (estado == "MS")
                {
                    precoFinal = preco + (preco * 0.08);
                    Console.WriteLine("O valor final do produto é: " + precoFinal);
                }
                else if (estado == "ES")
                {
                    precoFinal = preco + (preco * 0.12);
                    Console.WriteLine("O valor final do produto é: " + precoFinal);
                }
                else if (estado == "SC")
                {
                    precoFinal = preco + (preco * 0.18);
                    Console.WriteLine("O valor final do produto é: " + precoFinal);
                }
                else
                {
                    Console.WriteLine("Estado inválido!");
                }

                Console.WriteLine("Digite o valor do produto: ");
                preco = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o estado da rota do produto: ");
                estado = Console.ReadLine();
            }
        }
    }
}