namespace _9_Esccopo
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            bool acompoanhante = true; //true ou false
            string mensagemAdicional = "";

            if (acompoanhante == true)
            {
                mensagemAdicional = "João está acompanhado.";
            }else
            {
                mensagemAdicional = "João não está acompanhado";
            }
            // ou = ||
            //  e = &&
            if (idade > 18 || acompoanhante == true)
            {
                Console.WriteLine("João possui mais de 18 anos de idade e " + mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não tem idade suficiente!");
            }
        }
    }
}