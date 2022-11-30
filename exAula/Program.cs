// Escreva um programa que leia quatro notas escolares de um aluno 
// e apresentar uma mensagem que Você aprovado se o valor da média escolar for 
// maior ou igual a 7.
// Se o valor da média for menor que 7, solicitar a nota do recuperação,
// somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7, 
// apresentar uma mensagem informando que Você aprovado na recuperação. Se o aluno não foi aprovado, 
// apresentar uma mensagem informando esta condição. 
// Apresentar junto com as mensagens o valor da média do aluno.


using System;

namespace exercício1
{
class Programa
{
    static void Main(string[] args)
    {
        double bim1, bim2, bim3, bim4, media;
        Console.WriteLine("Digite a nota do primeiro bimestre: ");
        bim1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota do segundo bimestre: ");
        bim2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota do terceiro bimestre: ");
        bim3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota do quarto bimestre: ");
        bim4 = Convert.ToDouble(Console.ReadLine());

        media = (bim1 + bim2 + bim3 + bim4) / 4;
        Console.WriteLine("A média é: " + media);

        if (media >= 7)
        {
            Console.WriteLine("Você aprovado! :)");
        }
        else
        {
            Console.WriteLine("Você reprovado! :(");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
    }
};

