using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {  
            //tipo        //objeto/variavel //criando o objeto
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;
            Console.WriteLine(contaDaGabriela.titular +" "+ contaDaGabriela.agencia +" "+contaDaGabriela.numero +" "+ contaDaGabriela.saldo);
        }
    }
}