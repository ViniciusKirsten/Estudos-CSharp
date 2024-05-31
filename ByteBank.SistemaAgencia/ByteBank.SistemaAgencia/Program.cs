using ByteBank.Modelos; //quando eu coloco em minhas referencias a biblioteca criada, consigo utilizar os recursos de "Modelo"
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime representa apenas uma data, não um intervalo de tempo
            DateTime dataFimPagamento = new DateTime(2024, 8, 17);
            DateTime dataCorrente = DateTime.Now;
            //Representa um intervalo de tempo
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);

            Console.ReadLine();
        }
    }
}
