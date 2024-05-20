namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            char acompoanhante = 'S';
            
            if (idade > 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade");
            }
            else
            {
                if (acompoanhante == 'S') 
                {
                    Console.WriteLine("João pode entrar, pois possui acompanhante!");
                }
                else
                {
                    Console.WriteLine("João não tem idade suficiente!");
                }
                
            }
        }
    }
}