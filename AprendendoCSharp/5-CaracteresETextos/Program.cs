namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            //character
            char primeiraLetra = 'a'; //aspas simples SEMPRE
            primeiraLetra = (char)61; //Assim vai imprimir um carácter = //casting 
            Console.WriteLine(primeiraLetra);
            
            //palavras e textos
            string nome = "Vincius";
            Console.WriteLine(nome);

            string cursoProgramacao = ".NET" + " Java" + " Javascript";
            Console.WriteLine(cursoProgramacao);
        }
    }
} 