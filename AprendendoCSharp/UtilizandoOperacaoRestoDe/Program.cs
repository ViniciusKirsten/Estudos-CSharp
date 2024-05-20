using System.Runtime.Serialization.Formatters;

namespace UtilizandoOperacaoRestoDe
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int cont=0; cont<=100; cont++)
            {
                if(cont%3 == 0)
                {
                    Console.WriteLine(cont);
                }
            }
        }
    }
01-ByteBank}