using System;

namespace _10_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.0;
            for (int cont=1; cont <= 12; cont++)
            {
                valorInvestido *= 1.0036; //forma diferente de realizar o calculo de porcentagem
                Console.WriteLine("Valor investido após " + cont + "= " + valorInvestido);
            }
        }
    }
}