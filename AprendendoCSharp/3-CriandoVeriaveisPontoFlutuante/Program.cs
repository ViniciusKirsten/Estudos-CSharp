namespace _3_CriandoVeriaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1500.50;
            Console.WriteLine("Meu salário é:" + salario);

            /* C# ele vai olhar para o que esta a direita, então
             * caso eu tenha dois inteiros para dividir, ele 
             * vai trazer o resulado de um inteiro.*/
            double divisao = 15 / 2; //posso colodar 15.0 e ou 2.0 assim vai retornar um double
            Console.WriteLine("Resultado de 15 dividido por 2 é: "+ divisao);
        }
    }
}