using System;

namespace _11_CalculaInverstimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatorInvestimento = 1.0036;
            double valorInvestido = 1000.0;

            for (int cont = 1; cont <= 5; cont++) //lacos de repeticao para ano
            {
                for(int cont2 = 1; cont2 <= 12; cont2++)// lacos de repeticao para mês
                {
                    valorInvestido += fatorInvestimento;
                }
                fatorInvestimento += 0.0010;
            }
            Console.WriteLine(valorInvestido);
        }
    }
}