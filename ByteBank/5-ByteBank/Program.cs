//using _5_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "  434.562.878-20";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela; //"gabriela" é a instancia que criamos para titular
                                      //agora estamos atribuido a referencia de gabriela
                                      //dentro da referencia "conta".
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5364527;

            conta.titular.nome = "Gabriela Costa";

            Console.WriteLine(gabriela.nome); //posso buscar diretamente na minha referencia
            Console.WriteLine(conta.titular.nome); //posso buscar ela atraves de outra referencia
        }
    }
}