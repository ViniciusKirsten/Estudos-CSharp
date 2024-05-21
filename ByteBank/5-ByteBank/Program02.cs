using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program02
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5364527;

            conta.titular = new Cliente(); //criando uma nova instancia dentro do objeto;
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "434.562.878.20";
            conta.titular.profissao = "Desenvolvedora C#";

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);
        }
    }
}