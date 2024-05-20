namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            bool acompoanhante = true; //true ou false

            // ou = ||
            //  e = &&
            if (idade > 18 || acompoanhante == true)
            {
                Console.WriteLine("João possui mais de 18 anos de idade");
            }
            else
            {
                Console.WriteLine("João não tem idade suficiente!");
            }
        }
    }
}