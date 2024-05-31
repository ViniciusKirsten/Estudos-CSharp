using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            CarregarContas();

            //Dentro do C# exceções são objetos.
            //Essa exceção está se aplicando a toda a pilha de chamada de metodos que o nosso "Metodo".
            try
            {
                Metodo();
                ContaCorrente conta = new ContaCorrente(2, 2); //caso de erro dentro do try, então vai retonrnar a mensagem de erro dentro
                conta.Sacar(500);
            }
            catch (ArgumentException e) //"e" é o nome do nosso objeto, por conveção sempre utilizamos a descrição como "e".
            {
                //aqui ele vai se orientar pelo erro de argumento que vai dentro do construtor ou método
                Console.WriteLine("Argumento com problema: " + e.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exceção de saldo Insuficiente!");
            }
            catch (Exception e) //Multiplas exceções
            {
                Console.WriteLine(e.Message); //mostra a mensagem de erro da chamada
                Console.WriteLine(e.StackTrace); //mostra o rastro do erro
            }
            /*
             * Poderia ter utilizado somente Exception, caso queria uma exceção que vai abranger tudo.
             * 
             * Todas as exceções derivam da Classe Exception
             * Se utilizarmos a busca por “ir para definição”, conseguimos localiza 
             * as classes que ele deriva da classe principal. Que a classe principal
             * seria a Exceptions e outras que não são filhas, são como por exemplo
             * “NullReferenceException”.
             */

            Console.ReadLine();
        }
        private static void CarregarContas()
        {
            //MODO MAIS FACIL DE EXECUTAR, UTILIZANDO RECURSOS DO C#
            //Por debaixo dos panos, esse "using" vai fazer toda a parte do (try/catch/finally) utilizando os recursos da interface
            using (LeitorDeArquivo leitor2 = new LeitorDeArquivo("teste.txt"))
            {
                //"IDisposable" é uma interface do C#
                leitor2.LerProximaLinha();
            }
            
            //MODO MAIS VERBAL SEM UTILIZAR OS RECUSOS DO C#
            LeitorDeArquivo leitor = null;
            try
            {
                leitor = new LeitorDeArquivo("Contas.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();

            }
            catch (IOException)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            }
            finally //bloco finally, sempre vai executar, mesmo que não estando descrito
                    //diretamente. Ele vai executar mesmo depois do try ou depois de um
                    //catch ele sempre vai executar
            {
                if (leitor != null)
                {

                    //leitor.Fechar();//utilizo aqui para não precisar escrever em ambas as opções (try e catch)
                }

            }
        }
        private static void TestaInnerException()
        {
            //testando o metodo transferir (utilizando o inner exceptions), para veriricar se ele vai enviar dados sensiveis/pessoais
            try
            {
                ContaCorrente conta1 = new ContaCorrente(12547, 458416);
                ContaCorrente conta2 = new ContaCorrente(12547, 458416);

                conta1.Transferir(1000, conta2);

            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Informações de INNER EXCEPTIONS (exceção interna):");
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
        }

        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
           
        }
        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com o número " +numero+ " e divisor " +divisor);
                throw; //essa palavra reservada vai encerrar o método caso entre nessa exceção
            }
        }
    }
}