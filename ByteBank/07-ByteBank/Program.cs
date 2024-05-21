using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program02
    {
        static void Main(string[] args)
        {
            //criando um objeto com os construres, assim obrigando apontar os campos configurados
            ContaCorrente conta = new ContaCorrente(876, 86712540);

            //Consultando um membro estático
            Console.WriteLine("Qtd contas: "+ContaCorrente.TotalDeContasCriadas);

            conta.Numero = 86712540;
            conta.Agencia = 876;

        }
    }
}