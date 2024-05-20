using System.Net.Sockets;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //casting (conversão de um para outro)
            double salario = 1200.25;
            int salarioInteiro = (int)salario; 
            Console.WriteLine(salarioInteiro);

            short idade3; //16 bits 
            int idade; //32 bits
            long idade2; //64 bits

            //suporta menos casas decimais que o double
            float altura = 10.2f; //adicionamos o " f " pois precisamos informar para o CSharp que esse número é um float;
            double altura2;
        }
    }
}