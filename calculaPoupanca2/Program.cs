using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto Calcula Poupança");

            double valorInvestido = 1000;
            // rendimento de 0.5 (0.005) ao mês

            valorInvestido  =  valorInvestido  + valorInvestido *  0.005;
            Console.WriteLine("Após um mês, você terá " + valorInvestido);


            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
    }
  }
}

