/* Um comerciante comprou um produto e quer vende-lo com um lucro de 45% 
se o valor da compra for menor que R$20,00; caso contrário, o lucro 
será de 30%. Entrar como valor do produto e imprimir o valor da venda. */

using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoProduto, precoVenda;

            Console.Write("Digite o valor do produto: ");
            precoProduto = Convert.ToDouble(Console.ReadLine());

            if (precoProduto < 20)
            {
                precoVenda = precoProduto + (precoProduto * 0.45);
            }
            else
            {
                precoVenda = precoProduto + (precoProduto * 0.30);
            }

            Console.WriteLine("O valor da venda é: " + precoVenda);
        }
    }
}