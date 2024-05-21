using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            Console.WriteLine("Saldo ="+contaDoBruno.saldo);
            Console.WriteLine(contaDoBruno.Sacar(50));
            Console.WriteLine("Saldo ="+contaDoBruno.saldo);
            contaDoBruno.Depositar(500);
            Console.WriteLine("Saldo =" + contaDoBruno.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo Bruno =" + contaDoBruno.saldo);
            contaDoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine("Saldo Bruno =" + contaDoBruno.saldo);
            Console.WriteLine("Saldo Gabriela =" + contaDaGabriela.saldo);
        }
    }
}