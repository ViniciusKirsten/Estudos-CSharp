using System;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.0;
            int mes = 1;
            while (mes <= 12)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.0036);
                Console.WriteLine("Valor investido após " + mes + "= " + valorInvestido);
                mes++;
            }
        }
    }
}