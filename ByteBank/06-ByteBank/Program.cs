using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program02
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();
            cliente.Nome = "Guilherme";
            cliente.Cpf = "434.564.879-20";
            cliente.Profissao = "Desenvolvedor";

            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome); 

            //METODO NOVO FAZENDO COM GET E SET

            conta.Saldo = -10;
            Console.WriteLine(conta.Saldo);

            /*MODO ANTIGO FAZENDO COM METODO
            conta.SetSaldo(-10);
            Console.WriteLine(conta.GetSaldo());
            */
        }
    }
}