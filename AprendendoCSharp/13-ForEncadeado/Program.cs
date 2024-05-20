using System;

namespace _13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int cont=1; cont<=10; cont++)
            {
                Console.WriteLine("");
                for (int cont2=1; cont2 <= cont; cont2++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}